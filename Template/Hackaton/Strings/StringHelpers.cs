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

        public static string Capitalize(string source)
        {
            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: Capitalize is not implemented!");
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

        public static int LastIndexOf(string source, char symbol)
        {
            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: LastIndexOf is not implemented!");
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

        public static string Reverse(string source)
        {
            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: Reverse is not implemented!");
        }

        public static string Section(string source, int start, int end)
        {
            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: Section is not implemented!");
        }
    }
}
