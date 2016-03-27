using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Uniform motion1 = new Uniform(0,0,0);
            Accelerated motion2 = new Accelerated(0,0,0,0);
            Vibrational motion3 = new Vibrational(0,0,0,0);
            IMotion[] arrayMotions = new IMotion[] { motion1, motion2, motion3 };
            IMotion m1;
            for (int i = 0; i < 3; i++)
            {
                m1 = arrayMotions[i];

                //m1 = motion1;
                try
                {
                    Console.WriteLine("Введите начальную координату");
                    m1.startCoor = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Были использованны параметры конструктора.");
                }
                try
                {
                    Console.WriteLine("Введите начальную скорость");
                    m1.startSpeed = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Были использованны параметры конструктора.");
                }
                try
                {
                    Console.WriteLine("Введите время движения");
                    m1.time =  Convert.ToInt32(Console.ReadLine());
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Попытка присваивания отрицательного значения!");
                }
                switch (i)
                {
                    case 0:
                        Console.WriteLine("Конечная координата для тела с типом движения <<{0}>>, начальной координатой {1}, с начальной\nскоростью {2} м/c и временем движения {3} секунд составяет {4}",
                                            m1.style, m1.startCoor, m1.startSpeed, m1.time, m1.CalcFinishCoor());
                        break;
                    case 1:
                         try
                {
                    Console.WriteLine("Введите ускорение");
                    motion2.acceleration = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Были использованны параметры конструктора.");
                }
                Console.WriteLine("Конечная координата для тела с типом движения <<{0}>>, начальной координатой {1}, с начальной\nскоростью {2} м/c временем движения {3} секунд с ускорением {4} составяет {5}",
                    m1.style, m1.startCoor, m1.startSpeed, m1.time, motion2.acceleration, m1.CalcFinishCoor());
                        break;
                    case 2:
                         try
                {
                    Console.WriteLine("Введите амплитуду");
                    motion3.amplitude = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Были использованны параметры конструктора.");
                }
                Console.WriteLine("Конечная координата для тела с типом движения <<{0}>>, начальной координатой {1}, с начальной\nскоростью {2} м/c временем движения {3} секунд, с амплетудой {4} составяет {5}",
                    m1.style, m1.startCoor, m1.startSpeed, m1.time, motion3.amplitude, m1.CalcFinishCoor());
                        break;
                }
                
            }
            Console.ReadKey();
        }
    }
    }
