using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ngay03_BT03
{
    namespace first_namespace
    {
        public class namespace_cl
        {
            public void func()
            {
                Console.WriteLine("Ben trong namespace thu nhat!");
            }
        }
    }

        namespace second_namespace
        {
            public class namespace_cl
            {
                public void func()
                {
                    Console.WriteLine("Ben trong namespace thu hai!");
                }
            }
        }
    
    public class TesCsharp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("namespace trong C#");
            System.Console.WriteLine("Vi du minh hoa cach su dung cua namespace");
            Console.WriteLine("-------------------------------------------");

            first_namespace.namespace_cl fc = new first_namespace.namespace_cl();
            second_namespace.namespace_cl sc = new second_namespace.namespace_cl();

            fc.func();
            sc.func();  

        }
    }
}