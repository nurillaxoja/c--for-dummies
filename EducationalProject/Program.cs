using System;
using System.Collections.Generic;
using System.IO;
using MytestLib;

namespace EducationalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string startupUploadsPath = System.IO.Directory.GetParent(@"../../../../uploads/").FullName;
            File.Copy("D:\\Nurillaxoja\\wallpaper\\g14.jpg", startupUploadsPath + "\\images");
            //Console.WriteLine(startupPath);
        }
       
    }
}


