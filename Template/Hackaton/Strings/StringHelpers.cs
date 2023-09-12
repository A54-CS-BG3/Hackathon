using System;
using System.Text;

namespace Hackaton
{
    public class StringHelpers
    {
        public static string Abbreviate(string source, int maxLength)
        {
            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: Abbreviate is not implemented!");
        }
        /// <summary>
        /// Capitalize the first symbol of string <paramref name="source"/> and returns a new capitalized string
        /// </summary>
        /// <param name="source"></param>
        /// 
        /// <returns>String with capitalized first symbol if not null or empty</returns>
        /// <author>Asen Asenov</author>
        public static string Capitalize(string source)
        {
            if (string.IsNullOrEmpty(source))
            {
                return source;
            }
            char[] charArr = source.ToCharArray();
            charArr[0] = char.ToUpper(charArr[0]);
            return new string(charArr);
        }

        /// <summary>
        /// Concatenates two strings and returns a new string.
        /// </summary>
        /// <param name="string1">The left part of the new string</param>
        /// <param name="string2">The right part of the new string</param>
        /// <returns>A string that represents the concatenation of string1's characters followed by string2's characters.</returns>
        /// <author>Kiril Stanoev</author>
        public static string Concat(string string1, string string2)
        {
            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: Concat is not implemented!");
        }
        /// <summary>
        /// Loops through each character in the string "source"
        /// If the "symbol" is found returns true
        /// If the "symbol" is not found returns false
        /// </summary>
        /// <param name="source"></param>
        /// <param name="symbol"></param>
        /// <returns>true or false</returns>
        /// <exception cref="NotImplementedException"></exception>
        /// <author> Georgi Aleksandrov </author>
        public static bool Contains(string source, char symbol)
        {
            foreach (char c in source)
            {
                if (c == symbol)
                {
                    return true;  
                }
            }

            return false;
        }

        /// <summary>
        /// Checks if <paramref name="source"/> begins with <paramref name="target"/> char.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <returns>If <paramref name="source"/> begins with <paramref name="target"/> returns true, else return false.</returns>
        /// <author> Nikolay Dobrev</author>
        public static bool StartsWith(string source, char target)
        {
            if(source.Length == 0)
            {
                return false;
            }

            if (source[0] == target)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Checks if the last element in <paramref name="source"/> is equal to <paramref name="target"/>
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <returns>true if last element of source is equal to target, false otherwise</returns>
        /// <author>Ventsislav Georgiev</author>
        public static bool EndsWith(string source, char target)
        {
            if (source.Length == 0) return false;
            return source[source.Length - 1] == target;
        }

        public static int FirstIndexOf(string source, char target)
        {
            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: FirstIndexOf is not implemented!");
        }
        /// <summary>
        /// Checks the index of last occurence of selected symbol <paramref name="symbol"/> in string <paramref name="source"/> and returns index
        /// </summary>
        /// <param name="source"></param>
        /// <param name="symbol"></param>
        /// <returns>Returns last index of symbol if string contains it, else returns -1</returns>
        /// <author>Asen Asenov</author>
        public static int LastIndexOf(string source, char symbol)
        {
            for (int i = source.Length - 1; i >= 0; i--)
            {
                if (symbol == source[i])
                {
                    return i;
                }
            }
            return -1;
        }

        public static string Pad(string source, int length, char paddingSymbol)
        {
            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: Pad is not implemented!");
        }
        /// <summary>
        /// Compares the lenght of the "source" to the desired "lenght"
        /// Adds "paddingSymbol" to the "source"
        /// Then returns the new padded "source"
        /// </summary>
        /// <param name="source"></param>
        /// <param name="length"></param>
        /// <param name="paddingSymbol"></param>
        /// <returns> padded "source" </returns>
        /// <exception cref="NotImplementedException"></exception>
        /// <author> Georgi Aleksandrov </author>
        public static string PadEnd(string source, int length, char paddingSymbol)
        {
            while (length > source.Length)
            {
                source += paddingSymbol;
            }

            return source;
        }

        /// <summary>
        /// Returns new string with <paramref name="length"/> of chars with such as the <paramref name="source"/> is at the end of the new string, preceded by <paramref name="length"/>.Length - <paramref name="source"/>.Length number of  <paramref name="paddingSymbol"/>.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="length"></param>
        /// <param name="paddingSymbol"></param>
        /// <returns>Returns new string with <paramref name="length"/> of chars with such as the <paramref name="source"/> is at the end of the new string, preceded by <paramref name="length"/>.Length - <paramref name="source"/>.Length number of  <paramref name="paddingSymbol"/>. </returns>
        /// <author> Nikolay Dobrev </author>
        public static string PadStart(string source, int length, char paddingSymbol)
        {
            //Possible problem if new length is shorter than source.Length or if source = null

            string result = new string(paddingSymbol, length - source.Length) + source;

            return result;
            
        }

        /// <summary>
        /// Creates a new string with <paramref name="source"/> string repeated
        /// </summary>
        /// <param name="source"></param>
        /// <param name="times"></param>
        /// <returns>a new string with source repeated "times" times</returns>
        /// <author>Ventsislav Georgiev</author>
        public static string Repeat(string source, int times)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < times; i++)
            {
                sb.Append(source);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Reverse the <paramref name="source"/> array
        /// </summary>
        /// <param name="source"></param>
        /// <returns>the reversed string</returns>
        /// <author>Ventsislav Georgiev</author>
        public static string Reverse(string source)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = source.Length - 1; i >= 0; i--)
            {
                stringBuilder.Append(source[i]);
            }
            return stringBuilder.ToString();
        }

        /// <summary>
        /// Extracts a substring from <paramref name="source"/> array
        /// </summary>
        /// <param name="source"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns>the substring extracted from <paramref name="source"/></returns>
        /// <author>Ventsislav Georgiev</author>
        public static string Section(string source, int start, int end)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = start; i <= end; i++)
            {
                stringBuilder.Append(source[i]);
            }
            return stringBuilder.ToString();
        }
    }
}
