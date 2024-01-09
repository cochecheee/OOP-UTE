﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace BTday03_trenlop
{
    public class Process
    {
        public void process(matran a, matran b)
        {
        menu:
            int chon;
            Console.WriteLine("\n\n\t......Moi lan lam viec xong menu nay deu hien ra......\n\n");
            Console.WriteLine(" 0 de thoat");
            Console.WriteLine(" 1 xuat ma tran");
            Console.WriteLine(" 2 tong hai ma tran");
            Console.WriteLine(" 3 hieu hai ma tran");
            Console.WriteLine(" 4 tich hai ma tran");
            Console.WriteLine(" 5 tim he so theo chi muc");

            try
            {
                Console.Write("nhap mot so trong menu:\t");
                chon = int.Parse(Console.ReadLine());
                if (chon < 0 || chon > 5)
                    goto menu;
            }
            catch (Exception e)
            {
                Console.WriteLine("\n\n Da co loi" + e.Message);
                goto menu;
            }
            switch (chon)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine("\n\nma tran a");
                    a.xuat();
                    Console.WriteLine("\n\nma tran b"); b.xuat();
                    goto menu;
                case 2:
                    if (a.Dong == b.Dong && a.Cot == b.Cot)
                    {
                        matran c = a + b;
                        Console.WriteLine("\n\n\ntong hai ma tran la");
                        c.xuat();
                    }
                    else
                    {
                        Console.WriteLine("\n\n\nhai ma tran nay khong cong duoc");
                    }
                    goto menu;
                case 3:
                    if (a.Dong == b.Dong && a.Cot == b.Cot)
                    {
                        matran c = a - b;
                        Console.WriteLine("\n\n\nhieu hai ma tran la");
                        c.xuat();
                    }
                    else
                    {
                        Console.WriteLine("\n\nhai ma tran nay khong tru duoc");
                    }
                    goto menu;
                case 4:
                    if (a.Cot != b.Dong)
                    {
                        Console.WriteLine("\n\nkhong the thuc hien phep nhan hai ma tran");
                    }
                    else
                    {
                        Console.WriteLine("\n\ntich hai ma tran la:");
                        matran c = a * b;
                        c.xuat();
                    }
                    goto menu;
                case 5:
                laimatrancantim:
                    Console.Write("nhap vao ma tran can tim theo chi muc (a hoac b):\t");
                    string mtcantim = Console.ReadLine();
                    if (mtcantim == "a")
                    {
                    laidongcottim:
                        Console.Write("nhap vao dong:\t");
                        int dd = int.Parse(Console.ReadLine());
                        Console.Write("nhap vao cot:\t");
                        int cc = int.Parse(Console.ReadLine());
                        if (dd > a.Dong || cc > a.Cot)
                        {
                            Console.WriteLine("khong duoc nhap so qua lon");
                            goto laidongcottim;
                        }
                        else
                        {
                            if (a[dd, cc] == -100)
                            {
                                Console.WriteLine("he so nay khong ton tai");
                            }
                            else
                                Console.WriteLine("\n\nGia tri tim duoc la:\t" +
                                a[dd, cc]);
                        }
                    }
                    else if (mtcantim == "b")
                    {
                    laidongcottim:
                        Console.Write("nhap vao dong:\t");
                        int dd = int.Parse(Console.ReadLine());
                        Console.Write("nhap vao cot:\t");
                        int cc = int.Parse(Console.ReadLine());
                        if (dd > b.Dong || cc > b.Cot)
                        {
                            Console.WriteLine("khong duoc nhap so qua lon");
                            goto laidongcottim;
                        }
                        else
                        {
                            if (b[dd, cc] == -100)
                            {
                                Console.WriteLine("he so nay khong ton tai");
                            }
                            else
                                Console.WriteLine("\n\nGia tri tim duoc la:\t" +
                                b[dd, cc]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("khong co ma tran nay");
                        goto laimatrancantim;
                    }
                    goto menu;
                default:
                    goto menu;
                    break;
            }
            Console.ReadLine();
        }
    }
}