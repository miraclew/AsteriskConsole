using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;
using VisualAsterisk.Core.Util;
using System.Diagnostics;

namespace VisualAsterisk.Asterisk.Config
{
    public class ConfigFileReader : VisualAsterisk.Asterisk.Config.ConfigFiles.IConfigFileReader
    {
        private const int MAX_LINE_LENGTH = 8192;
        private static char COMMENT_META = ';';
        private static char COMMENT_TAG = '-';
        //private const Set<Class> WARNING_CLASSES;

        static ConfigFileReader()
        {
            //WARNING_CLASSES = new HashSet<Class>();
            //WARNING_CLASSES.Add(MissingEqualSignException.class);
            //WARNING_CLASSES.Add(UnknownDirectiveException.class);
            //WARNING_CLASSES.Add(MissingDirectiveParameterException.class);
        }

        private StringBuilder commentBlock;
        protected readonly Dictionary<string, Category> categories;
        private readonly List<ConfigParseException> warnings;

        protected Category currentCategory;
        private int currentCommentLevel = 0;
        private string configFileDirectory;

        /// <summary>
        /// 
        /// </summary>
        /// <param Name="dir"></param>
        public ConfigFileReader(string dir)
            : this()
        {
            configFileDirectory = dir;
        }

        public ConfigFileReader()
        {
            this.commentBlock = new StringBuilder();
            // TODO: 
            //this.Categories = new LinkedHashMap<string, Category>();
            this.categories = new Dictionary<string, Category>();
            this.warnings = new List<ConfigParseException>();
        }

        public ConfigFile ReadString(string configFileName, string fileContent)
        {
            ConfigFile result;
            string[] lines = fileContent.Split('\n');

            int lineno = 0;
            CharBuffer buffer = CharBuffer.allocate(MAX_LINE_LENGTH);

            reset();
            foreach (string line in lines)
            {
                lineno++;
                buffer.clear();
                buffer.put(line);
                buffer.put("\n");
                buffer.flip();

                processLine(configFileName, lineno, buffer);
            }
            result = new ConfigFile(configFileName, new Dictionary<string, Category>(categories));
            return result;
        }

        /// <summary>
        ///  throws IOException, ConfigParseException
        /// </summary>
        /// <param Name="configfile"></param>
        /// <returns></returns>
        public ConfigFile ReadFile(string configfile)
        {
            ConfigFile result;
            StreamReader reader = null;

            try
            {
                if (string.IsNullOrEmpty(configFileDirectory))
                {
                    reader = new StreamReader(configfile);
                }
                else
                {
                    reader = new StreamReader(Path.Combine(configFileDirectory, configfile));
                }

                readFile(configfile, reader);
                result = new ConfigFile(configfile, new Dictionary<string, Category>(categories));
            }
            catch (FileNotFoundException ex)
            {
                Trace.WriteLine(ex.Message);
                result = null;
            }
            finally
            {
                try
                {
                    if (reader != null)
                    {
                        reader.Close();                        
                    }
                }
                catch (System.Exception e) // NOPMD
                {
                    // ignore
                }
            }

            return result;
        }

        void reset()
        {
            commentBlock = new StringBuilder();
            categories.Clear();
            warnings.Clear();
            currentCategory = null;
            currentCommentLevel = 0;
        }

        ICollection<Category> getCategories()
        {
            return categories.Values;
        }

        public ICollection<ConfigParseException> getWarnings()
        {
            return new List<ConfigParseException>(warnings);
        }
        /// <summary>
        ///  throws IOException, ConfigParseException
        /// </summary>
        /// <param Name="configfile"></param>
        /// <param Name="reader"></param>
        void readFile(string configfile, StreamReader reader)
        {
            string line;
            int lineno = 0;
            CharBuffer buffer = CharBuffer.allocate(MAX_LINE_LENGTH);

            reset();
            while ((line = reader.ReadLine()) != null)
            {
                lineno++;
                buffer.clear();
                buffer.put(line);
                buffer.put("\n");
                buffer.flip();

                processLine(configfile, lineno, buffer);
            }
        }
        /// <summary>
        ///  throws ConfigParseException
        /// </summary>
        /// <param Name="configfile"></param>
        /// <param Name="Lineno"></param>
        /// <param Name="buffer"></param>
        /// <returns></returns>

        ConfigElement processLine(string configfile, int lineno, CharBuffer buffer)
        {
            char c;
            StringBuilder processLineBuilder;
            StringBuilder lineCommentBuilder;

            processLineBuilder = new StringBuilder(MAX_LINE_LENGTH);
            lineCommentBuilder = new StringBuilder(MAX_LINE_LENGTH);
            buffer.mark();

            while (buffer.hasRemaining())
            {
                int position;

                position = buffer.Position;
                c = buffer.get();
                //System.out.println(Position + ": " + c);

                if (c == COMMENT_META)
                {
                    if (position >= 1 && buffer.get(position - 1) == '\\')
                    {
                        // Escaped semicolons aren't comments. 
                    } // NOPMD
                    else if (buffer.remaining() >= 3
                            && buffer.get(position + 1) == COMMENT_TAG
                            && buffer.get(position + 2) == COMMENT_TAG
                            && buffer.get(position + 3) != COMMENT_TAG)
                    {
                        // Meta-Comment start detected ";--" 

                        currentCommentLevel++;
                        //System.out.println("Comment start, new level: " + currentCommentLevel);

                        if (!inComment())
                        {
                            commentBlock.Append(";--");
                            buffer.Position = position + 3;
                            buffer.mark();
                            continue;
                        }
                    }
                    else if (inComment()
                            && position >= 2
                            && buffer.get(position - 1) == COMMENT_TAG
                            && buffer.get(position - 2) == COMMENT_TAG)
                    {
                        // Meta-Comment end detected 

                        currentCommentLevel--;

                        if (!inComment())
                        {
                            buffer.reset();

                            //int commentLength = (Position + 1) - buffer.Position();

                            //buffer.reset();
                            //for (int i = 0; i < commentLength; i++)
                            //{
                            //    commentBlock.Append(buffer.get());
                            //}

                            commentBlock.Append(c);
                            //System.out.println("Comment end at " + Position + ": '" + commentBlock.ToString() + "'");

                            buffer.Position = position + 1;
                            buffer.compact();
                            buffer.flip();

                            //System.out.println("Buffer compacted");
                            continue;
                        }
                    }
                    else
                    {
                        if (!inComment())
                        {
                            // If ; is found, and we are not nested in a Comment, we immediately stop all Comment processing 
                            //System.out.println("Found ; while not in Comment");
                            while (buffer.hasRemaining())
                            {
                                lineCommentBuilder.Append(buffer.get());
                            }
                            break;
                        }
                        else
                        {
                            // Found ';' while in Comment 
                        } // NOPMD
                    }
                }


                if (inComment())
                {
                    commentBlock.Append(c);
                }
                else
                {
                    //System.out.println("Added '" + c + "' to processLine");
                    processLineBuilder.Append(c);
                }
            }

            string processLineString;
            string lineCommentString;
            ConfigElement configElement;

            processLineString = processLineBuilder.ToString().Trim();
            lineCommentString = lineCommentBuilder.ToString().Trim();

            //System.out.println("process line: '" + processLineString + "'");
            if (processLineString.Length == 0)
            {
                if (lineCommentString.Length != 0)
                {
                    commentBlock.Append(";");
                    commentBlock.Append(lineCommentString);
                }
                if (!inComment())
                {
                    commentBlock.Append("\n");
                }
                return null;
            }

            try
            {
                configElement = processTextLine(configfile, lineno, processLineString);
            }
            catch (ConfigParseException e)
            {
                // some parsing exceptions are treated as warnings by Asterisk, we mirror this behavior.
                //if (WARNING_CLASSES.contains(e.getClass()))
                //{
                //    warnings.Add(e);
                //    return null;
                //}
                //else
                //{
                //    throw e;
                //}
                throw e;
            }

            if (lineCommentString.Length != 0)
            {
                configElement.Comment = lineCommentString;
            }

            if (commentBlock.Length != 0)
            {
                configElement.PreComment = commentBlock.ToString();
                commentBlock.Remove(0, commentBlock.Length);
            }

            return configElement;
        }

        bool inComment()
        {
            return currentCommentLevel != 0;
        }
        /// <summary>
        ///  throws ConfigParseException
        /// </summary>
        /// <param Name="configfile"></param>
        /// <param Name="Lineno"></param>
        /// <param Name="line"></param>
        /// <returns></returns>
        protected virtual ConfigElement processTextLine(string configfile, int lineno, string line)
        {
            ConfigElement configElement;

            if (line[0] == '[') // A Category header
            {
                configElement = parseCategoryHeader(configfile, lineno, line);
            }
            else if (line[0] == '#') // a directive - #include or #exec
            {
                configElement = parseDirective(configfile, lineno, line);
            }
            else // just a line
            {
                if (currentCategory == null)
                {
                    throw new ConfigParseException(configfile, lineno,
                            "parse error: No category context for line %d of %s", lineno, configfile);
                }

                configElement = parseVariable(configfile, lineno, line);
                currentCategory.addElement(configElement);
            }

            return configElement;
        }
        /// <summary>
        /// throws ConfigParseException
        /// </summary>
        /// <param Name="configfile"></param>
        /// <param Name="Lineno"></param>
        /// <param Name="line"></param>
        /// <returns></returns>
        protected Category parseCategoryHeader(string configfile, int lineno, string line)
        {
            Category category;
            string name;
            int nameEndPos;

            /* format is one of the following:
            * [foo]        define a new Category named 'foo'
            * [foo](!)     define a new Template Category named 'foo'
            * [foo](+)     append to Category 'foo', error if foo does not exist.
            * [foo](a)     define a new Category and inherit from Template a.
            *              You can put a comma-separated list of templates and '!' and '+'
            *              between parentheses, with obvious meaning.
            */

            nameEndPos = line.IndexOf(']');
            if (nameEndPos == -1)
            {
                throw new ConfigParseException(configfile, lineno,
                        "parse error: no closing ']', line %d of %s", lineno, configfile);
            }
            name = line.Substring(1, nameEndPos - 1);
            category = new Category(configfile, lineno, name);

            /* Handle Options or Categories to inherit from if available */
            if (line.Length > nameEndPos + 1 && line[nameEndPos + 1] == '(')
            {
                string[] options;
                string optionsString;
                int optionsEndPos;

                optionsString = line.Substring(nameEndPos + 1);
                optionsEndPos = optionsString.IndexOf(')');
                if (optionsEndPos == -1)
                {
                    throw new ConfigParseException(configfile, lineno,
                            "parse error: no closing ')', line %d of %s", lineno, configfile);
                }

                options = optionsString.Substring(1, optionsEndPos).Split(new char[] { ',' });
                foreach (string cur in options)
                {
                    if ("!".Equals(cur)) // Category Template
                    {
                        category.markAsTemplate();
                    }
                    else if ("+".Equals(cur)) // Category addition
                    {
                        Category categoryToAddTo;

                        categoryToAddTo = categories[name];
                        if (categoryToAddTo == null)
                        {
                            throw new ConfigParseException(configfile, lineno,
                                    "Category addition requested, but category '%s' does not exist, line %d of %s",
                                    name, lineno, configfile);
                        }

                        //todo implement Category addition
                        //Category = categoryToAddTo;
                    }
                    else
                    {
                        Category baseCategory;

                        baseCategory = categories[cur];
                        if (baseCategory == null)
                        {
                            throw new ConfigParseException(configfile, lineno,
                                    "Inheritance requested, but category '%s' does not exist, line %d of %s",
                                    cur, lineno, configfile);
                        }
                        inheritCategory(category, baseCategory);
                    }
                }
            }

            appendCategory(category);
            return category;
        }
        /// <summary>
        ///  throws ConfigParseException
        /// </summary>
        /// <param Name="configfile"></param>
        /// <param Name="Lineno"></param>
        /// <param Name="line"></param>
        /// <returns></returns>
        ConfigDirective parseDirective(string configfile, int lineno, string line)
        {
            ConfigDirective directive;
            StringBuilder nameBuilder;
            StringBuilder paramBuilder;
            string name = null;
            string param;

            nameBuilder = new StringBuilder();
            paramBuilder = new StringBuilder();
            for (int i = 1; i < line.Length; i++)
            {
                char c;

                c = line[i];
                if (name == null)
                {
                    nameBuilder.Append(c);
                    if (char.IsWhiteSpace(c) || i + 1 == line.Length)
                    {
                        name = nameBuilder.ToString().Trim();
                    }
                }
                else
                {
                    paramBuilder.Append(c);
                }
            }

            param = paramBuilder.ToString().Trim();

            if (param.Length != 0 &&
                    (param[0] == '"' || param[0] == '<' || param[0] == '>'))
            {
                param = param.Substring(1);
            }

            int endPos = param.Length - 1;
            if (param.Length != 0 &&
                    (param[endPos] == '"' || param[endPos] == '<' || param[endPos] == '>'))
            {
                param = param.Substring(0, endPos);
            }

            if ("exec".Equals(name, StringComparison.CurrentCultureIgnoreCase))
            {
                directive = new ExecDirective(configfile, lineno, param);
            }
            else if ("include".Equals(name, StringComparison.CurrentCultureIgnoreCase))
            {
                directive = new IncludeDirective(configfile, lineno, param);
            }
            else
            {
                throw new UnknownDirectiveException(configfile, lineno,
                        "Unknown directive '%s' at line %d of %s", name, lineno, configfile);
            }

            if (param.Length == 0)
            {
                throw new MissingDirectiveParameterException(configfile, lineno,
                        "Directive '#%s' needs an argument (%s) at line %d of %s",
                        name.ToLower(), // TODO: culture ignore
                        "include".Equals(name, StringComparison.CurrentCultureIgnoreCase) ? "filename" : "/path/to/executable",
                        lineno,
                        configfile);
            }

            return directive;
        }
        /// <summary>
        /// throws ConfigParseException
        /// </summary>
        /// <param Name="configfile"></param>
        /// <param Name="Lineno"></param>
        /// <param Name="line"></param>
        /// <returns></returns>
        protected ConfigVariable parseVariable(string configfile, int lineno, string line)
        {
            int pos;
            string name;
            string value;

            pos = line.IndexOf('=');
            if (pos == -1)
            {
                throw new MissingEqualSignException(configfile, lineno,
                        "No '=' (equal sign) in line %d of %s", lineno, configfile);
            }

            name = line.Substring(0, pos).Trim();

            // Ignore > in =>
            if (line.Length > pos + 1 && line[pos + 1] == '>')
            {
                pos++;
            }

            value = (line.Length > pos + 1) ? line.Substring(pos + 1).Trim() : "";
            return new ConfigVariable(configfile, lineno, name, value);
        }

        void inheritCategory(Category category, Category baseCategory)
        {
            category.addBaseCategory(baseCategory);
        }

        void appendCategory(Category category)
        {
            if (categories.ContainsKey(category.Name))
            {
                categories[category.Name] = category;
                Trace.TraceWarning("duplicated category {0} in {1}", category.Name, category.FileName);
            }
            else
            {
                categories.Add(category.Name, category);
            }
            currentCategory = category;
        }
    }
}
