using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR11
{
    class Program
    {
        class boots
        {
            protected string factoryName;
            protected int size;
            protected string manOrwoman;
            protected string color;
            protected double price;

            public void input()
            {
                Console.Write("Input factory name: ");
                factoryName = Console.ReadLine();
                Console.Write("Input size: ");
                size = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input boots for man or woman: ");
                manOrwoman = Console.ReadLine();
                Console.Write("Input color: ");
                color = Console.ReadLine();
                Console.Write("Input price: ");
                price = Convert.ToDouble(Console.ReadLine());


            }

            public static bool operator ==(boots obj1, boots obj2)
            {
                return (obj1.factoryName == obj2.factoryName &&
                        obj1.size == obj2.size &&
                        obj1.manOrwoman == obj2.manOrwoman &&
                        obj1.color == obj2.color &&
                        obj1.price == obj2.price);
            }

            
            public static bool operator !=(boots obj1, boots obj2)
            {
                return (obj1.factoryName != obj2.factoryName ||
                        obj1.size != obj2.size ||
                        obj1.manOrwoman != obj2.manOrwoman ||
                        obj1.color != obj2.color ||
                        obj1.price != obj2.price);
            }
            
            public static bool operator >(boots obj1, boots obj2)
            {
                return (obj1.price > obj2.price);
            }

            public static bool operator <(boots obj1, boots obj2)
            {
                return (obj1.price < obj2.price);
            }

            public static double operator +(boots obj1, boots obj2)
            {
                return (obj1.price + obj2.price);
            }
            
            public double GET()
            {
                return price;
            }

        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Input number of boots: ");
            n = Convert.ToInt32(Console.ReadLine());
            boots[] mass = new boots[n];

            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = new boots();
                Console.WriteLine("\nInput boots({0})" , i+1);
                mass[i].input();
            }

            Console.WriteLine("\n");
            for (int i = 0; i <= mass.Length - 2; i++)
            {
                if (mass[i] == mass[i + 1])
                {
                    Console.WriteLine("Boots {0} is equal to Boots {1}", i + 1, i + 2);
                }
                else if (mass[i] != mass[i + 1])
                {
                    Console.WriteLine("Boots {0} isn't equal to Boots {1}", i + 1, i + 2);
                    if (mass[i] > mass[i + 1])
                    {
                        Console.WriteLine("Boots {0} is more expensive than Boots {1}", i + 1, i + 2);
                    }
                    else
                    {
                        if (mass[i].GET() == mass[i + 1].GET())
                        {
                            Console.WriteLine("Price boots {0} is equal to price Boots {1}", i + 1, i + 2);
                        }
                        else
                        {
                            Console.WriteLine("Boots {0} is cheaper than Boots {1}", i + 1, i + 2);
                        }
                    }
                }
            }

            Console.WriteLine("Sum of price Boots 1 and Boots {0}: {1}", n, mass[0] + mass[mass.Length - 1]);

            Console.ReadLine();
        }
    }
}
