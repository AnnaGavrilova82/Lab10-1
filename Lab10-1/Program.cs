using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab10_1
{
    class Program
    {
        static void Main(string[] args)
        {



            Ugol ugol = new Ugol();
            Console.Write("Введите градусы ");
            ugol.Gradus = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите минуты ");
            ugol.Min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите секунды ");
            ugol.Sec = Convert.ToInt32(Console.ReadLine());
            ugol.Result();
            Console.ReadKey();

        }


        class Ugol
        {
            int gradus;
            int min;
            int sec;
            double result;
            public int Gradus
            {
                set
                {
                    if (value >= 0 && value < 360)
                    {
                        gradus = value;
                        Console.WriteLine(value);
                    }
                    else
                    {
                        Console.WriteLine("Градус не может превышать значение 360");
                    }
                }
                get
                {
                    return gradus;
                }
            }
            public int Min
            {
                set
                {
                    if ((value >= 0) && (value < 60))
                    {
                        min = value;
                    }
                    else
                    {
                        Console.WriteLine("Не может превышать значение 60");
                    }
                }
                get
                {
                    return min;
                }
            }
            public int Sec
            {
                set
                {
                    if ((value >= 0) && (value < 60))
                    {
                        sec = value;
                    }
                    else
                    {
                        Console.WriteLine("Не может превышать значение 60");
                    }
                }
                get
                {
                    return sec;
                }
            }
            public Ugol()
            {
                result = (gradus * Math.PI / 180) + (min * Math.PI / (180 * 60)) + (sec * Math.PI / (180 * 3600));

            }

            public void Result()
            {
                Console.WriteLine("Угол в радианах: {0}", result);
            }
        }
    }   
}
