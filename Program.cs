using System;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            string mode;
            double x, y,p,t,t1,t2,check1,check2;
            mode = Console.ReadLine();
            switch (mode)
            {
                case "time"://หาp
                    x = double.Parse(Console.ReadLine());//ค่าt
                    y = double.Parse(Console.ReadLine());
                    if (x < 0)
                    {
                        Console.WriteLine("Invalid mouse position");
                    }
                    else
                    {
                        p = Math.Pow(x - 1, 2); //p=(t-1)2
                        Console.WriteLine("{0},{1}", x, p);
                    }
                    break;
                
                case "price"://หาtค่าx
                    x = double.Parse(Console.ReadLine());
                    y = double.Parse(Console.ReadLine());//ค่าp
                    if (x < 0)
                    {
                        Console.WriteLine("Invalid mouse position");
                    }
                    else
                    {
                        double a = 1, b = -2, c;
                        c = (1-y);
                        t = Math.Sqrt((b * b) - (4 * a * c));
                        t1 = (-b + t) / (2 * a);
                        t2 = (-b - t) / (2 * a);
                        check1 = Math.Abs(x - t1);
                        check2 = Math.Abs(x - t2);
                        if (check1>check2){
                            Console.WriteLine("{0},{1}", t2, y);
                        }
                        else if(check1 <check2)
                        {
                            Console.WriteLine("{0},{1}", t1, y);
                        }
                    }
                    break;
                  
                default:
                    x = double.Parse(Console.ReadLine());
                    y = double.Parse(Console.ReadLine());
                    Console.WriteLine("Invalid mode"); break;
            }
        }
    }
}
