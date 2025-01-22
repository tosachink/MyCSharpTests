using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeScansNoFixTest
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
            NFCommonFunctions.nfprintme(null);

            // Create File Test
            NFCommonFunctions.nfcreateFile("");

            // CSS Vulnerability
            NFCSSVulnerability c = new NFCSSVulnerability();
        }
    }
}
