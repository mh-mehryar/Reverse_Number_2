using System;

namespace Revers_Number_1
{
    class Program
    {
 static void Main(string[] args)
        {

            System.Console.WriteLine("Please Enter your Number :");
            string n = Console.ReadLine();

            string[] num = new string[n.Length];

            for (var i = 0; i < n.Length; i++)
            {
                num[i] = n.Substring(i,1);
            }
            reversNum(num);
            
            
        }
        public static void reversNum(string[] number)
        {
            for (var i = number.Length - 1 ; i >= 0; i--)
            {
                System.Console.Write(number[i]);
            }
        

        


        }
        }
    }
