// Sample Code for Code Scanning with Code QL
// Author: Sachin Keskar


using System;
using System.IO;


namespace CodeScansNoFixTest
{
    internal class NFCommonFunctions
    {
        public static void nfprintme(Object obj)
        {
            Console.WriteLine(obj);
        }

        public static void nfcreateFile(String fileName)
        {
            if (fileName != null && fileName.Length >= 0)
            {
                File.Delete(fileName);
                File.Create(fileName);
            }
        }
    }
}
