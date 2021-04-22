using System;
using System.IO;

namespace ReNameFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args[0]);
            int i = 0;
            //for문 돌린 부분
            string 파일 = args[i];
            FileInfo fi1 = new FileInfo(파일);
            string path =  fi1.FullName;
            Console.ReadKey();
        }
    }
}
