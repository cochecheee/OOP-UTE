using System;
using TryParse;

namespace Parse
{
    public class Try_Parse
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");

            //var name = Console.ReadLine();
            //Console.WriteLine("Nice to meet you {0} My name is C#, How old are you?", name);
            //int age;
            //int.TryParse(Console.ReadLine(), out age);
            //if(age== 0)
            //{
            //    Console.WriteLine("That is not a correcr input");
            //}
            //else
            //{
            //    Console.WriteLine("{0} good, As for me I was born on 2002. Which makes me {1} years old", age, DateTime.Now.Year - 2002); ;
            //}

            Parse_T p = new Parse_T();
            //p.Parse_Test();
            p.dateTime();
        }
    }
}