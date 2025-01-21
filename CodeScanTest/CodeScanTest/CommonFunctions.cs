// Sample Code for Code Scanning with Code QL
// Author: Sachin Keskar

using System;
using System.IO;

namespace CodeScanTest
{
    internal class CommonFunctions
    {
        public static void printme(Object obj)
        {
            Console.WriteLine(obj.ToString());
        }

        public static void createFile(String fileName)
        {
            if (fileName != null && fileName.Length >= 0)
            {
                File.Delete(fileName);
                File.Create(fileName);
            }
        }
    }
}
