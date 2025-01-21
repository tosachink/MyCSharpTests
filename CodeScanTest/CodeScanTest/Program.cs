// Sample Code for Code Scanning with Code QL
// Author: Sachin Keskar

using System;
using System.Web;

namespace CodeScanTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Dynamic Test call
            dynamic obj = new DynamicTest();
            obj.printme(null);

            // Invalid API Test
            CommonFunctions.printme(null);

            // Create File Test
            CommonFunctions.createFile("");

            // CSS Vulnerability
            //CSSVulnerability c = new CSSVulnerability();
        }
    }
}
