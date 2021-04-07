using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{
    // Julius Caesar protected his confidential information by encrypting it using a cipher.
    // Caesar's cipher shifts each letter by a number of letters. If the shift takes you
    // past the end of the alphabet, just rotate back to the front of the alphabet. In
    // the case of a rotation by 3, w, x, y and z would map to z, a, b and c.
    // Note: The cipher only encrypts letters; symbols, such as -, remain unencrypted.

    // Complete the caesarCipher function below.
    static string caesarCipher(string s, int k)
    {
        StringBuilder sb = new StringBuilder();
        foreach(char c in s)
        {
            // If it's a letter perform the shift
            if (char.IsLetter(c))
            {
                char start = char.IsUpper(c) ? 'A' : 'a';

                // calculate the shift
                int idx = (c - start + k) % 26;

                sb.Append((char)(start + idx));
            }
            else
            {
                sb.Append(c);
            }
        }

        return sb.ToString();
    }

    static void Main(string[] args)
    {
        string s = "middle-Outz";

        int k = 2;

        string result = caesarCipher(s, k);

        Console.WriteLine(result);
    }
}
