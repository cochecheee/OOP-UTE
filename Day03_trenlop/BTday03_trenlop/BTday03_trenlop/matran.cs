﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTday03_trenlop
{
    public class matran
    {
        private int _dong;
        public int Dong
        {
            get { return _dong; }
            set { _dong = value; }
        }

        private int _cot;
        public int Cot
        {
            get { return _cot; }
            set { _cot = value; }
        }

        int[,] mt;
        public matran(int d, int c)
        {
            Dong = d;
            Cot = c;
            mt = new int[Dong, Cot];
        }

        public void nhap()
        {
            for (int i = 0; i < Dong; i++)
            {
                for (int j = 0; j < Cot; j++)
                {
                nhaplai:
                    try
                    {
                        Console.Write("nhap vao phan tu thu a[{0}][{1}]:\t", i, j);
                        mt[i, j] = int.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Loi :\t" + e.Message);
                        goto nhaplai;
                    }
                }
            }
        }
        public void xuat()
        {
            for (int i = 0; i < Dong; i++)
            {
                for (int j = 0; j < Cot; j++)
                {
                    Console.Write("\t" + mt[i, j]);
                }
                Console.WriteLine();
            }
        }

        public int this[int dong, int cot]
        {
            get
            {
                for (int i = 0; i < Dong; i++)
                {
                    for (int j = 0; j < Cot; j++)
                    {
                        if (dong == i && cot == j)
                            return mt[i, j];
                    }
                }
                return -100;
            }
        }

        public static matran operator +(matran a, matran b)
        {
            int dong = a.Dong;
            int cot = a.Cot;
            matran c = new matran(dong, cot);
            for (int i = 0; i < dong; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    c.mt[i, j] = a.mt[i, j] + b.mt[i, j];
                }
            }
            return c;
        }

        public static matran operator -(matran a, matran b)
        {
            int dong = a.Dong;
            int cot = a.Cot;
            matran c = new matran(dong, cot);
            for (int i = 0; i < dong; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    c.mt[i, j] = a.mt[i, j] - b.mt[i, j];
                }
            }
            return c;
        }
        public static matran operator *(matran a, matran b)
        {
            int dong = a.Dong;
            int cot = b.Cot;
            matran c = new matran(dong, cot);
            for (int i = 0; i < dong; i++)
                for (int j = 0; j < cot; j++)
                {
                    c.mt[i, j] = 0;
                    for (int k = 0; k < b.Dong; k++)
                    {
                        c.mt[i, j] += a.mt[i, k] * b.mt[k, j];
                    }
                }
            return c;
        }
    }
}