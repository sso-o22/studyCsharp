﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs06_var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 20;
            Console.WriteLine("Type : {0}, Value : {1}", a.GetType(), a);

            var b = 3.141592;  // f여부에 따라서 double / float 변경 (끝에 f 쓰면 System.Single)
            Console.WriteLine("Type : {0}, Value : {1}", b.GetType(), b);

            var c = "Basic C#";
            Console.WriteLine("Type : {0}, Value : {1}", c.GetType(), c);


        }
    }
}
