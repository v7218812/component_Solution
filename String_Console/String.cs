using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace String_Console
{
    //先判斷第一個字是否為大寫是的話改為小寫
    //第二步判斷內容有沒有大寫有的話轉為小寫且前面+一個_
    internal class String
    {

        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個帶大寫字元和小寫字元的字串！");
            string Str = Console.ReadLine();//"StringTest";
            Str = Str.Capitalize();
            string newStr = string.Empty;

            foreach (char item in Str)
            {
                if (item >= 'A' && item <= 'Z')
                {
                    //大寫字母轉小寫
                    newStr += "_" + item.ToString().ToLower(); 
                }
                else if (item >= 'a' && item <= 'z')
                {
                    //小寫字母轉大寫
                    newStr += item.ToString();
                }
            }
            Console.WriteLine(newStr);


        }
    }
    public static class StringExtensions
    {
        public static string Capitalize(this string value)
        {

            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("String is mull or empty");
            }

            return value[0].ToString().ToLower() + value.Substring(1);
        }


    }

}
