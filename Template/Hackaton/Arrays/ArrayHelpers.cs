using System;
using System.Collections.Generic;
using System.Text;

namespace Hackaton
{
    public class ArrayHelpers
    {
        /// <summary>
        /// Adds the int element at the start of the array source.
        /// </summary>
        /// <param name="source">The array to add to</param>
        /// <param name="element">The element to add</param>
        /// <returns>A new array that has all the elements from the original array and the added element at head position.</returns>
        /// <author>Kiril Stanoev</author>
        public static int[] AddFirst(int[] source, int element)
        {
            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: AddFirst is not implemented!");
        }

        public static int[] AddLast(int[] source, int element)
        {
            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: AddLast is not implemented!");
        }

        public static int[] AppendAll(int[] source, int[] elements)
        {
            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: AppendAll is not implemented!");
        }
        /// <summary>
        /// Creates a new array with the size of "source.Length + 1"
        /// Copies the "elements" before the specified "index"
        /// Inserts the "element"
        /// Copies the "elements" after the specified "index"
        /// Returns "result"
        /// </summary>
        /// <param name="source"></param>
        /// <param name="index"></param>
        /// <param name="element"></param>
        /// <returns> result </returns>
        /// <exception cref="NotImplementedException"></exception>
        /// <author> Georgi Aleksandrov </author>
        public static int[] InsertAt(int[] source, int index, int element)
        {
            int[] result = new int[source.Length + 1];

            for (int i = 0; i < index; i++)
            {
                result[i] = source[i];
            }

            result[index] = element;

            for (int i = index; i < source.Length; i++)
            {
                result[i + 1] = source[i];
            }

            return result;
        }

        public static bool Contains(int[] source, int element)
        {
            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: Contains is not implemented!");
        }

        /// <summary>
        /// It copies the first <paramref name="count"/> elements from <paramref name="sourceArray"/> into <paramref name="destinationArray"/>
        /// </summary>
        /// <param name="sourceArray"></param>
        /// <param name="destinationArray"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        /// <author>Ventsislav Georgiev</author>
        public static void Copy(int[] sourceArray, int[] destinationArray, int count)
        {
            if (sourceArray.Length > destinationArray.Length)
            {
                for (int i = 0; i < count; i++)
                {
                    destinationArray[i] = sourceArray[i];
                }
            }            
        }

        public static void CopyFrom(int[] sourceArray, int sourceStartIndex, int[] destinationArray, int destStartIndex, int count)
        {
            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: CopyFrom is not implemented!");
        }

        public static void Fill(int[] source, int element)
        {
            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: Fill is not implemented!");
        }

        public static int FirstIndexOf(int[] source, int target)
        {
            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: FirstIndexOf is not implemented!");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static int LastIndexOf(int[] source, int target)
        {
            if (source == null || source.Length == 0)
            {
                return -1;
            }

            for (int i = source.Length - 1; i >= 0; i--)
            {
                if (source[i] == target)
                {
                    return i;
                }
            }

            return -1;
        }

        public static bool IsValidIndex(int[] source, int index)
        {
            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: IsValidIndex is not implemented!");
        }

        /// <summary>
        /// Removes all elements from <paramref name="source"/> array that do not match <paramref name="element"/>
        /// </summary>
        /// <param name="source"></param>
        /// <param name="element"></param>
        /// <returns>An array of ints with all elements from source that are not equal to element.</returns>
        /// <author>Ventsislav Georgiev</author>
        public static int[] RemoveAllOccurrences(int[] source, int element)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] != element)
                    list.Add(source[i]);
            }

            return list.ToArray();
        }

        public static void Reverse(int[] arrayToReverse)
        {
            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: Reverse is not implemented!");
        }

        public static int[] Section(int[] source, int startIndex, int endIndex)
        {
            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: Section is not implemented!");
        }
    }
}
