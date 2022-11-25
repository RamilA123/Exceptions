using Exceptions.Controllers;
using Service.Exceptions.FactorialException1;
using System;
using System.Collections.Generic;

namespace Exceptions
{
    public class Program
    {
        static void Main(string[] args)
        {
            //LoginController logincontroller = new LoginController();
            //logincontroller.GetLogin();
            LoginController.GetLogin();

            //try
            //{
            //    int num = int.Parse(Console.ReadLine());
            //    var result = CalculateFactorial(num);
            //    Console.WriteLine(result);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
        }

        public static int CalculateFactorial(int num)
        {
            int mult = 1;
            if (num == 0)
            {
                return 1;
            }
            else if (num > 0)
            {
                for (int i = 1; i <= num; i++)
                {
                    mult *= i;
                }
                return mult;
            }
            else
            {
                throw new FactorialException("A negative number doesnt't have a factoriality.");
            }
        }
    }
}
