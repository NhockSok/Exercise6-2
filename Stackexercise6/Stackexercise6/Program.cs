﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stackexercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack S = new Stack(10);
            //S.Push(2);
            //S.Push(0);
            //S.Push(1);
            //S.Push(9);
            //S.Clear();
            //Console.WriteLine(S.pop());
            //Console.WriteLine(S.pop());
            //Console.WriteLine(S.pop());
            //Console.WriteLine(S.pop());
            //Console.WriteLine(S.Count());
            //Console.WriteLine(S.peek());
            //Console.WriteLine(S.peek());
            
            string [] array = {"Pham","Ngoc","Duy"};
            Stack s = new Stack(array.Length);
            for (int i = 0; i < array.Length;i++ )
            {
                s.Push(array[i]);
            }
            for (int i = 0; i < array.Length;i++ )
            {
                array[i] = s.pop();
            }




                for (int i = 0; i < array.Length; i++)
                    Console.Write(array[i] + " ");
        }
    }
}
