using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Operator;

namespace BTday03_trenlop
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap vao dong ma tran a:\t");
            int dong = int.Parse(Console.ReadLine());
            Console.Write("nhap so cot cua ma tran a:\t");
            int cot = int.Parse(Console.ReadLine());
            matran a = new matran(dong, cot);
            a.nhap();
            a.xuat();
            Console.Write("\n\nnhap vao dong ma tran b:\t");
            dong = int.Parse(Console.ReadLine());
            Console.Write("nhap so cot cua ma tran b:\t");
            cot = int.Parse(Console.ReadLine());
            matran b = new matran(dong, cot);
            b.nhap();
            b.xuat();

            Process p = new Process();
            p.process(a, b);
        }
    }
}