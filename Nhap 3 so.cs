using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");


            // Khai báo mảng double có 3 phần tử
            double[] numbers = new double[3];
            
            for (int i = 0; i < 3; i++)
            {
                while(true)
                    {

                    Console.WriteLine("Nhap so thu " + (i + 1));
                    string input = Console.ReadLine();

                    if (double.TryParse(input, out numbers[i]))
                        {
                        break;
                        }

                    Console.WriteLine("Khong phai so, vui long nhap lai.");
                    }    
            }
            Console.WriteLine("So ban da nhap la ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("So thu " + (i+1) + " ban da nhap la " + numbers[i]);
            }
        }
    }
}


