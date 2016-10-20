using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculate_volume
{
    class Program
    {
        public static double cubicalVolume(double height, double width, double length)
        {
            return (height * width * length);
        }

        public static double cylindricalVolume(double radius, double height)
        {
            return (Math.PI * Math.Pow(radius, 2) * height);
        }

        public static double cubicalSA(double front, double right, double top)
        {
            return (front * right * top) * 2;
        }

        public static double cylindricalSA(double radius, double height)
        {
            return 2 * (Math.PI * Math.Pow(radius, 2)) + (2 * Math.PI * radius * height);
        }

        public static double findDensity(double mass_weight, double volume)
        {
            return (mass_weight / volume);
        }

        static void Main(string[] args)
        {
            bool retry = true;
            double length;
            double width;
            double height;
            double radius;
            double weight;
            double density;
            double volume;
            double SA;
            while (retry)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                retry = false;
                double calculateChoice;
                Console.WriteLine(" ____       _  _     _     ____");
                Console.WriteLine("/ ___|  ___ | (_) __| |   / ___| ___ _ __   ___  ___");
                Console.WriteLine("\\___ \\ / _ \\| | |/ _` |  | |  _ / _ \\ '_ \\ / _ \\/ _ \\");
                Console.WriteLine(" ___) | (_) | | | (_| |  | |_| |  __/ | | |  __/  __/");
                Console.WriteLine("|____/ \\___/|_|_|\\__,_|___\\____|\\___|_| |_|\\___|\\___|");
                Console.WriteLine("                     |_____|");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("     1. Calculate Volume");
                Console.WriteLine("     2. Calculate Surface Area");
                Console.WriteLine("     3. Calculate Density");
                Console.WriteLine("     4. Calculate Weight");
                Console.Write(" > ");
                calculateChoice = Convert.ToDouble(Console.ReadLine());
                if (calculateChoice == 1)
                {
                    Console.WriteLine("     1. Cubic Object");
                    Console.WriteLine("     2. Cylindrical Object");
                    Console.Write(" > ");
                    int objectChoice = Convert.ToInt32(Console.ReadLine());
                    if (objectChoice == 1)
                    {
                        Console.WriteLine("What is the LENGTH of the object?");
                        Console.Write(" > ");
                        length = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("What is the WIDTH of the object?");
                        Console.Write(" > ");
                        width = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("What is the HEIGHT of the object?");
                        Console.Write(" > ");
                        height = Convert.ToDouble(Console.ReadLine());
                        volume = Program.cubicalVolume(height, width, length);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("The VOLUME is {0}", volume);
                        retry = true;
                    }
                    if (objectChoice == 2)
                    {
                        Console.WriteLine("What is the RADIUS of the object?");
                        Console.Write(" > ");
                        radius = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("What is the HEIGHT of the object?");
                        Console.Write(" > ");
                        height = Convert.ToDouble(Console.ReadLine());
                        volume = Program.cylindricalVolume(radius, height);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("The VOLUME of the object is {0}", volume);
                        retry = true;
                    }
                }
                if (calculateChoice == 2)
                {
                    double objectChoice;
                    Console.WriteLine("     1. Cubical Object");
                    Console.WriteLine("     2. Cylindrical Object");
                    Console.Write(" > ");
                    objectChoice = Convert.ToDouble(Console.ReadLine());
                    if (objectChoice == 1)
                    {
                        double front;
                        double top;
                        double right;
                        Console.WriteLine("What is the LENGTH of the Object?");
                        Console.Write(" > ");
                        length = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("What is the WIDTH of the Object?");
                        Console.Write(" > ");
                        width = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("What is the HEIGHT of the Object?");
                        Console.Write(" > ");
                        height = Convert.ToDouble(Console.ReadLine());
                        front = length * height;
                        right = length * height;
                        top = length * width;
                        SA = Program.cubicalSA(front, right, top);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("The SURFACE AREA is {0}", SA);
                        retry = true;
                    }
                    if (objectChoice == 2)
                    {
                        Console.WriteLine("What is the RADIUS of the object?");
                        Console.Write(" > ");
                        radius = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("What is the HEIGHT of the object?");
                        Console.Write(" > ");
                        height = Convert.ToDouble(Console.ReadLine());
                        SA = Program.cylindricalSA(radius, height);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("The SURFACE AREA is {0}", SA);
                        retry = true;
                    }
                }
                if (calculateChoice == 3)
                {
                    double mass_weight;
                    Console.Write("What is the MASS/WEIGHT of the object?\n > ");
                    mass_weight = Convert.ToDouble(Console.ReadLine());
                    Console.Write("What is the VOLUME of the object?\n > ");
                    volume = Convert.ToDouble(Console.ReadLine());
                    density = Program.findDensity(mass_weight, volume);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The DENSITY of the object is {0}", density);
                    retry = true;
                }
                if (calculateChoice == 4)
                {
                    Console.Write("What is the VOLUME of the object?\n > ");
                    volume = Convert.ToDouble(Console.ReadLine());
                    Console.Write("What is the DENSITY of the object\n > ");
                    density = Convert.ToDouble(Console.ReadLine());
                    weight = volume * density;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The WEIGHT of the object is {0}", weight);
                    retry = true;
                }
            }
        }
    }
}
