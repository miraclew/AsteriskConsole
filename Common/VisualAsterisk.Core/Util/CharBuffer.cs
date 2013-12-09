using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace VisualAsterisk.Core.Util
{
    public class CharBuffer
    {
        ArrayList charArray;
        int capacity;
        int limit;
        int position;
        int mark_pos = -1;

        public int Position
        {
            get { return position; }
            set { position = value; }
        }

        public int Limit
        {
            get { return limit; }
            set { limit = value; }
        }

        public int Capacity
        {
            get { return capacity; }
            //set { capacity = value; }
        }

        protected CharBuffer(int capacity)
        {
            this.capacity = capacity;
            limit = capacity;
            charArray = new ArrayList(capacity);
            position = 0;
        }

        public static CharBuffer allocate(int capacity)
        {
            return new CharBuffer(capacity);
        }

        public void clear()
        {
            charArray.Clear();
            position = 0; 
        }

        public CharBuffer put(string src)
        {
            put(src.ToCharArray());
            return this;
        }

        public CharBuffer put(char[] chars)
        {
            foreach (char c in chars)
            {
                charArray.Add(c);
                position++;
            }
            return this;
        }

        public CharBuffer flip()
        {
            limit = position;
            position = 0;
            mark_pos = -1;
            return this;
        }

        public bool hasRemaining()
        {
            return limit > position;
        }

        public int remaining()
        {
            return limit - position; 
        }

        public char get()
        {
            char current = (char)charArray[position];
            position++;
            return current;
        }

        public char get(int index)
        {
            return (char)charArray[index];
        }

        public CharBuffer mark()
        {
            mark_pos = position;
            return this;
        }

        public CharBuffer reset()
        {
            position = mark_pos;
            return this;
        }

        public CharBuffer compact()
        {
            ArrayList newChars = new ArrayList();
            int n = limit - 1 - position;
            for (int i = position ; i < limit; i++)
            {
                newChars.Add(charArray[i]);
            }

            for (int i = 0; i < newChars.Count; i++)
            {
                charArray[i] = newChars[i];
            }

            position = n + 1;
            limit = capacity;
            mark_pos = -1;

            return this;
        }
    }
}
