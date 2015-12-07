using System;
using System.Text.RegularExpressions;

namespace SharePointTools.Tools
{
    public class MenuOperation
    {
        public static void Menu()
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("1、开始测试");
            Console.WriteLine("2、退出");
            Console.WriteLine("==============================================");
        }

        public static bool IsNumber(string strNumber)
        {
            var regex = new Regex("[^1-2]");
            return !regex.IsMatch(strNumber);
        }
    }
}
