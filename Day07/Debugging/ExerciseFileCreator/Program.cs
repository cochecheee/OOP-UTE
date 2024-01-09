using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseFilesCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw;
            string language = string.Empty;
            int count = Enum.GetNames(typeof(Languages)).Length;
            for (int i = 0; i < count; i++)
            {
                language = Enum.GetValues(typeof(Languages)).GetValue(i).ToString();
                Console.WriteLine(language);
                Directory.CreateDirectory(@"D:\Languages");
                Directory.CreateDirectory("D:\\Languages\\" + language);
                sw = new StreamWriter("D:\\Languages\\" + language + "\\log.txt");
                sw.WriteLine("File no " + i + " created on " + DateTime.Now);
                sw.Close();
            }
        }
    }


    enum Languages
    {
        Arabic,
        Azerbaijani,
        Bengali,
        Czech,
        Dutch,
        English,
        French,
        German,
        Greek,
        Hindi,
        Hungarian,
        Italian,
        Japanese,
        Javanese,
        Korean,
        Kurdish,
        Malay,
        Mandarin,
        Persian,
        Polish,
        Portuguese,
        Romanian,
        Russian,
        Spanish,
        Swedish,
        Thai,
        Turkish,
        Ukrainian,
        Urdu,
        Vietnamese,
        Zulu
    }
}
