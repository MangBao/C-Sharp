using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class chuoi
    {
        string s;
        int col, row;
        public chuoi(string s1="",int c=0,int r = 0)
        {
            s = s1; col = c; row = r;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
        }
        public void hienthi()
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.CursorTop = row;
            Console.CursorLeft = col;
            Console.Write(s);
        }
        public void RunChu()
        {
            while (true)
            {
                ConsoleKeyInfo phim = Console.ReadKey(true);
                if (phim.Key == ConsoleKey.Escape)
                    break;
                if (phim.Key == ConsoleKey.LeftArrow)
                    col--;
                else if (phim.Key == ConsoleKey.RightArrow)
                    col++;
                else if (phim.Key == ConsoleKey.UpArrow)
                    row--;
                else if (phim.Key == ConsoleKey.DownArrow)
                    row++;
                if (col <= 0)
                    col = Console.WindowWidth;
                if (col >= Console.WindowWidth)
                    col = 0;
                if (row <= 0)
                    row = Console.WindowHeight;
                if (row >= Console.WindowHeight)
                    row = 0;
                hienthi();
            }
        }
    }
}
