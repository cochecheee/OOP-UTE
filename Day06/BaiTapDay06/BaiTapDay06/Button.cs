using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiTapDay06
{
    public class Button : Window
    {
        public Button(int top, int left) : base(top, left) { }

        public override void DrawWindow()
        {
            base.DrawWindow();
            Console.WriteLine("ve lai button");
        }
    }
}