﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;


namespace HinhHoc
{
    public abstract class HinhHoc
    {
        private Point _Tam;
        protected Point Tam
        {
            get { return _Tam; }
            set { _Tam = value; }
        }
        public abstract double ChuVi();
        public abstract double DienTich();
        public abstract void Ve(Graphics g);
    }
}