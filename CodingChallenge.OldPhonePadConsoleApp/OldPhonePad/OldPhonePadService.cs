using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.OldPhonePadConsoleApp.OldPhonePad
{
    public class OldPhonePadService 
    {
        public string OldPhonePad(string input)
        {
            Dictionary<char, string> key = new Dictionary<char, string>
            {
                {'1' , "&'("},
                {'2' , "ABC"},
                {'3' , "DEF"},
                {'4' , "GHI"},
                {'5' , "JKL"},
                {'6' , "MNO"},
                {'7' , "PQRS"},
                {'8' , "TUV"},
                {'9' , "WXYZ"},
                {'0' , " "},
            };

            var result = CalculateSequence(key, input);
            return result;
            
        }

        private string CalculateSequence(Dictionary<char, string> key, string input)
        {
            StringBuilder result = new StringBuilder();
            char lastDigit = '\0';
            int pressCount = 0;

            foreach (char digit in input)
            {
                if (digit == '#')
                {
                    break;
                }
                if (digit == '*')
                {
                    lastDigit = '\0';
                    continue;
                }
                if (Char.IsWhiteSpace(digit))
                {
                    if (pressCount > 0 && key.ContainsKey(lastDigit))
                    {
                        char letter = CalculateLetter(key, lastDigit, pressCount);
                        if (!Char.IsWhiteSpace(letter))
                        {
                            result.Append(letter);
                        }
                    }
                    lastDigit = '\0';
                    pressCount = 0;
                    continue;
                }
                if (digit == lastDigit)
                {
                    pressCount++;
                }
                else
                {
                    if (pressCount > 0 && key.ContainsKey(lastDigit))
                    {
                        char letter = CalculateLetter(key, lastDigit, pressCount);
                        result.Append(letter);
                    }
                    pressCount = 1;
                    lastDigit = digit;
                }
            }
            if (pressCount > 0 && key.ContainsKey(lastDigit))
            {
                char letter = CalculateLetter(key, lastDigit, pressCount);
                result.Append(letter);
            }

            return result.ToString();
        }

        private char CalculateLetter(Dictionary<char, string> key, char digit, int count)
        {
            char result = key[digit][(count - 1) % key[digit].Length];
            return result;
        }
    }
}
