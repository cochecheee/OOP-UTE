using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiTapDay06
{
    public class Window
    {
        private int left;
        private int top;

        public Window(int left, int top)
        {
            this.left = left;
            this.top = top;
        }

        public int Left { get => left; set => left = value; }
        public int Top { get => top; set => top = value; }

        public virtual void DrawWindow()
        {
            System.Console.WriteLine("Ve Window tai Top {0}---- Left {1}", top, left);
        }
    }
}