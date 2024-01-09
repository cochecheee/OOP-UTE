using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Matrix_Operator
{
    public class matrix
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

        public int[,] Mt { get => mt; set => mt = value; }

        private int[,] mt;
        public matrix(int d, int c)
        {
            Dong = d;
            Cot = c;
            Mt = new int[Dong, Cot];
        }

        public static matrix Add(matrix a, matrix b)
        {
            int dong = a.Dong;
            int cot = a.Cot;
            matrix c = new matrix(dong, cot);
            for (int i = 0; i < dong; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    c.mt[i, j] = a.mt[i, j] + b.mt[i, j];
                }
            }
            return c;
        }
        public static matrix Subtract(matrix a, matrix b)
        {
            int dong = a.Dong;
            int cot = a.Cot;
            matrix c = new matrix(dong, cot);
            for (int i = 0; i < dong; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    c.mt[i, j] = a.mt[i, j] - b.mt[i, j];
                }
            }
            return c;
        }
        public static matrix Multiply(matrix a, matrix b)
        {
            int dong = a.Dong;
            int cot = b.Cot;
            matrix c = new matrix(dong, cot);
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
