using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk
{
    public class Codecs
    {
        public static readonly string[] Items = new string[] { "g726", "alaw", "ulaw",
            "lpc10", "a_mu", "adpcm", "gsm" };
        /// <summary>
        /// display Name
        /// </summary>
        public static readonly string[] CodecNames = new string[] { "G.726", "a-law", "u-law", "a-mu", "LPC10", "ADPCM", "GSM" };
        /// <summary>
        /// a map of codec by code Name as key
        /// </summary>
        public static readonly Dictionary<string, string> NameToCodec = new Dictionary<string, string>();
        public static readonly Dictionary<string, string> CodecToName = new Dictionary<string, string>();

        static Codecs()
        {
            for (int i = 0; i < CodecNames.Length; i++)
            {
                NameToCodec.Add(CodecNames[i], Items[i]);
                CodecToName.Add(Items[i], CodecNames[i]);
            }
        }
    }
}
