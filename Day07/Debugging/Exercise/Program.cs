using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Welcome();
            
        }

        public static void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to Ceasar Cipherapp, choose");
            Console.WriteLine("(E) to encryprt");
            Console.WriteLine("(D) to decrypt");
            Console.WriteLine("(X) to exit");
            Console.ForegroundColor = ConsoleColor.White;

            char mode = Console.ReadKey().KeyChar;

            Process(mode);
        }
        public static void Process(char mode)
        {
            bool flg = true;
            switch (mode)
            {
                case 'E':
                    Console.WriteLine();
                    encryptMode();
                    break;
                case 'X':
                    flg = false;
                    Console.WriteLine();
                    break;
                case 'D':
                    Console.WriteLine();
                    decryptMode();
                    break; // Add a break statement here to fix CS0163
                default:
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine("Invalid Input");
                    Console.BackgroundColor = ConsoleColor.Black;
                    break; // Add a break statement here to fix CS8070
            }
            if (flg) { Welcome(); }
            
        }


        public static void encryptMode()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to encryption mode");
            Console.WriteLine("Enter message to encrypt");
            Console.ForegroundColor = ConsoleColor.White;
            string script = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter the shift: ");
            Console.ForegroundColor = ConsoleColor.White;
            int num = int.Parse(Console.ReadLine());
            char[] encrypt = CeaserCipher.Encrypt(script, num);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cipher is: ");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in encrypt)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");

        }

        public static void decryptMode()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to decryption mode");
            Console.WriteLine("Enter the path of file to decrypt");
            Console.ForegroundColor = ConsoleColor.White;
            string path = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter file name: ");
            Console.ForegroundColor = ConsoleColor.White;
            string filename = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter the shift: ");
            Console.ForegroundColor = ConsoleColor.White;
            int shift = int.Parse(Console.ReadLine());
            Console.WriteLine();

            string fullpath = (@path + filename);
            System.IO.StreamReader sr = new System.IO.StreamReader(fullpath);
            string encrypt = sr.ReadToEnd();
            sr.Close();

            char[] decrypt = CeaserCipher.Decrypt(encrypt, shift);
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in decrypt)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");

        }
    }

    public class CeaserCipher
    {
        public static char[] Encrypt(string plainText, int shift)
        {
            char[] plainArray = plainText.ToLower().ToCharArray();
            char[] cipherArray = new char[plainArray.Length];

            for (int i = 0; i < plainArray.Length; i++)
            {
                char letter = plainArray[i];
                if (letter != ' ')
                {
                    letter = (char)(letter + shift);
                    if (letter > 'z')
                    {
                        letter = (char)(letter - 26);
                    }
                    else if (letter < 'a')
                    {
                        letter = (char)(letter + 26);
                    }
                    cipherArray[i] = letter;
                }
            }
            return cipherArray;
        }

        public static char[] Decrypt(string cipherText, int shift)
        {
            char[] cipherArray = cipherText.ToLower().ToCharArray();
            char[] plainArray = new char[cipherText.Length];

            for (int i = 0; i < cipherArray.Length; i++)
            {
                char letter = cipherArray[i];
                if (letter != ' ')
                {
                    letter = (char)(letter - shift);
                    if (letter > 'z')
                    {
                        letter = (char)(letter - 26);
                    }
                    else if (letter < 'a')
                    {
                        letter = (char)(letter + 26);
                    }
                    plainArray[i] = letter;
                }
            }
            return plainArray;
        }
    }
}

