using System;
using System.Collections.Generic;
using System.Text;

namespace _9_iyun
{
    class Book: Product
    {
        public string Author;
        public string Genre;
        public override void GetInfo()
        {
            Console.WriteLine($"Name: {Name} Author: {Author} Genre: {Genre} Price: {Price}");
        }
    }
}
