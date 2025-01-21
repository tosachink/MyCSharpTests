// Sample Code for Code Scanning with Code QL
// Author: Sachin Keskar

using System;

namespace CodeScanTest
{
    internal class DynamicTest
    {
        public void printme(Object obj)
        {
            if(null != obj)
                Console.WriteLine(obj);
        }
    }
}
