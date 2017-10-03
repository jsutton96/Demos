﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Arrays
{
    public class Chapter1
    {
        /// <summary>
        /// Checks to see if a string contains only unique characters
        /// 
        /// <info>Time Complexity: O(n) Space Complexity: O(1)</info>
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool HasUniqueCharacters(string s)
        {
            // ASCI has 128 characters max so if we are greater than that, we can return false
            if (s.Length > 128)
            {
                return false;
            }

            // Create a boolean array that will be our lookup table
            var charLookup = new bool[128];

            for (int i = 0; i < s.Length; i++)
            {
                int val = s[i];
                if (charLookup[val] == true) // already found the character
                {
                    return false; 
                }
                charLookup[val] = true;
            }
            return true;
        }

        /// <summary>
        /// Write a method to replace all spaces in a word with '%20'. You may assume that the string has sufficient space at the end of the string to hold the additional chaaacters, and that
        /// you are given the "true" length of the string. 
        /// 
        /// EX: 
        /// INPUT: "Mr John Smith    ", 13
        /// OUTPUT: "Mr%20John%20Smith"
        /// </summary>
        /// <param name="word"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static char[] ReplaceAllSpaces(char[] word, int length)
        {
            int spaceCount = 0;
            int newLength;

            // Count the spaces in the string
            for (int i = 0; i < length; i++)
            {
                if (word[i] == ' ')
                {
                    spaceCount++;
                }
            }
            newLength = length + spaceCount * 2;
            word[newLength] = '\0';

            for (int i = length - 1; i >= 0; i--)
            {
                if (word[i] == ' ')
                {
                    word[newLength - 1] = '0';
                    word[newLength - 2] = '2';
                    word[newLength - 3] = '%';
                    newLength = newLength - 3;
                } else
                {
                    word[newLength - 1] = word[i];
                    newLength = newLength - 1;
                }
            }
            return word;
        }
    }
}