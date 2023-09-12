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

        public static bool Contains(string source, char symbol)
        {
            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: Contains is not implemented!");
        }

        public static bool StartsWith(string source, char target)
        {
            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: StartsWith is not implemented!");
        }

        public static bool EndsWith(string source, char target)
        {
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

        public static string PadEnd(string source, int length, char paddingSymbol)
        {
            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: PadEnd is not implemented!");
        }

        public static string PadStart(string source, int length, char paddingSymbol)
        {
            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: PadStart is not implemented!");
        }

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
