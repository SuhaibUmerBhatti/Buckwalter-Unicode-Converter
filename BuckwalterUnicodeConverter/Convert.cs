using System.Text;

namespace ArabicUnicodeBuckwalterConverter
{
    internal class Convert
    {
        private static char[] uCodes = {'\u0628', '\u0650', '\u0633', '\u0652', '\u0645', '\u0671', '\u0644', '\u0651', '\u064E', '\u0647', '\u0631', '\u062D', '\u0670', '\u0646', '\u064A', '\u062F', '\u064F', '\u0639', '\u0643', '\u0648', '\u0625', '\u0627', '\u062A', '\u0635', '\u0637', '\u0642', '\u0630', '\u0623', '\u063A', '\u0636', '\u0653', '\u0641', '\u064B', '\u0649', '\u0624', '\u0629', '\u0632', '\u0621', '\u062E', '\u06DF', '\u0626', '\u064C', '\u0634', '\u0638', '\u06E2', '\u062C', '\u062B', '\u06E5', '\u064D', '\u06E6', '\u0640', '\u0654', '\u06ED', '\u06DC', '\u06E0', '\u06EA', '\u06EB', '\u06E8', '\u06EC', '\u06E3', '\u0020'};
        private static char[] bCodes = {'b', 'i', 's', 'o', 'm', '{', 'l', '~', 'a', 'h', 'r', 'H', '`', 'n', 'y', 'd', 'u', 'E', 'k', 'w', '<', 'A', 't', 'S', 'T', 'q', '*', '>', 'g', 'D', '^', 'f', 'F', 'Y', '&', 'p', 'z', '\'', 'x', '@', '}', 'N', '$', 'Z', '[', 'j', 'v', ',', 'K', '.', '_', '#', ']', ':', '"', '-', '+', '!', '%', ';',' '};
        
        /// <summary>
        /// To check if passed string is Buckwalter transliteration.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static bool isBuckwalter(string str)
        {
            bool result = true;
            try
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (((short)str[i]) > 500)
                    {
                        result = false;
                        break;
                    }
                }
                return result;
            }
            catch (Exception)
            {
                MessageBox.Show($"Error occured in 'isBuckwalter' function");
                return false;
            }
        }
        
        /// <summary>
        /// Converts Arabic unicode string to Buckwalter transliteration.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToBuckwalter(string str)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < str.Length; i++)
                    sb.Append(bCodes[Array.IndexOf(uCodes, str[i])]);
                return sb.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Error occured in 'ToBuckwalter' function. String not converted.");
                return str;
            }
        }
        
        /// <summary>
        /// Coverts Buckwalter string to Arabic unicode string.
        /// </summary>
        /// <returns></returns>
        public static string ToArabicUnicode(string str)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < str.Length; i++)
                    sb.Append(uCodes[Array.IndexOf(bCodes, str[i])]);
                return sb.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Error occured in 'ToArabicUnicode' function. String not converted.");
                return str;
            }
        }

        /// <summary>
        /// Checks the string and converts accordingly.
        /// From Buckwalter string to Arabic Unicode string.
        /// and from Arabic Unicode string to Buckwalter string.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string This(string str)
        {
            if (isBuckwalter(str))
                return ToArabicUnicode(str);
            else
                return ToBuckwalter(str);
        }
    }
}
