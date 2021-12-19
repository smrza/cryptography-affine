using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Affine_Cipher
{
    class Encryption
    {
        public static int GCD(int keyA, int alphabet)
        {
            int r = 1;

            if (keyA > alphabet)
            {
                int tmp = keyA;
                keyA = alphabet;
                alphabet = tmp;
            }

            while (r != 0)
            {
                r = alphabet % keyA;

                if (r == 0)
                {
                    break;
                }

                alphabet = keyA;
                keyA = r;
            }

            return keyA;
        }

        public static string Encrypt(int keyA, int keyB, List<char> Input, List<char> alphabet)
        {
            List<char> output = new List<char>();

            for (int i = 0; i < Input.Count; i++)
            {
                for (int j = 0; j < alphabet.Count; j++)
                {
                    if (Input[i] == alphabet[j])
                    {
                        int result = (keyA * alphabet.IndexOf(alphabet[j]) + keyB) % alphabet.Count;
                        output.Add(alphabet[result]);
                        break;
                    }
                }
            }
             
            string finalOutput = string.Join("", output);
            for (int i = 5; i <= finalOutput.Length; i += 5)
            {
                finalOutput = finalOutput.Insert(i, " ");
                i++;
            }

            return finalOutput;
        }

        public static string Decrypt(int keyB, int MMI, List<char> Input, List<char> alphabet)
        {
            List<char> output = new List<char>();

            for (int i = 0; i < Input.Count; i++)
            {
                for (int j = 0; j < alphabet.Count; j++)
                {
                    if (Input[i] == alphabet[j])
                    {
                        double a = ((alphabet.IndexOf(alphabet[j]) - keyB) * MMI);
                        double b = alphabet.Count;
                        double result = a - Math.Floor(a / b) * b;
                        output.Add(alphabet[Convert.ToInt32(result)]);
                        break;
                    }
                }
            }

            string finalOutput = string.Join("", output);
            finalOutput = finalOutput.Replace("XYZ", " ");
            finalOutput = finalOutput.Replace("XNULAX", "0");
            finalOutput = finalOutput.Replace("XJEDNAX", "1");
            finalOutput = finalOutput.Replace("XDVEX", "2");
            finalOutput = finalOutput.Replace("XTRIX", "3");
            finalOutput = finalOutput.Replace("XCTYRIX", "4");
            finalOutput = finalOutput.Replace("XPETX", "5");
            finalOutput = finalOutput.Replace("XSESTX", "6");
            finalOutput = finalOutput.Replace("XSEDMX", "7");
            finalOutput = finalOutput.Replace("XOSMX", "8");
            finalOutput = finalOutput.Replace("XDEVETX", "9");
            finalOutput = finalOutput.Replace("XTECKAX", ".");
            finalOutput = finalOutput.Replace("XVYKRICNIKX", "!");
            finalOutput = finalOutput.Replace("XOTAZNIKX", "?");
            finalOutput = finalOutput.Replace("XLINEX", "\n");
            return finalOutput;
        }

        public static int MMI(int keyA, int alphabetLength)
        {
            for (int i = 1; i < alphabetLength; i++)
            {
                if ((keyA * i) % alphabetLength == 1)
                {
                    return i;
                }
            }
            return 0;
        }

        public static List<char> EncryptedAlphabet(int keyA, int keyB, List<char> alphabet)
        {
            List<char> output = new List<char>();

            for (int i = 0; i < alphabet.Count; i++)
            {
                int result = (keyA * alphabet.IndexOf(alphabet[i]) + keyB) % alphabet.Count;

                output.Add(alphabet[Convert.ToInt32(result)]);
            }
            return output;
        }

        public static string DecryptInBetween(int keyB, int MMI, List<char> Input, List<char> alphabet)
        {
            List<char> output = new List<char>();

            for (int i = 0; i < Input.Count; i++)
            {
                for (int j = 0; j < alphabet.Count; j++)
                {
                    if (Input[i] == alphabet[j])
                    {
                        double a = ((alphabet.IndexOf(alphabet[j]) - keyB) * MMI);
                        double b = alphabet.Count;
                        double result = a - Math.Floor(a / b) * b;
                        output.Add(alphabet[Convert.ToInt32(result)]);
                        break;
                    }
                }
            }

            string finalOutput = string.Join("", output);
            return finalOutput;
        }
    }
}
