using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Runtime.InteropServices; // Для getch

namespace Model
{
    class Program
    {
        [DllImport("msvcrt")]
        static extern char _getch();

        static void Main()
        {
            char key;
            int ascii = 0;
            
            while (ascii != 27)
            {
                try
                {
                    Console.Clear();

                    Console.WriteLine("Нажмите...");
                    Console.WriteLine(" '1'  - Демонстрация расчета координаты при прямолинейном движении;");
                    Console.WriteLine(" '2'  - Демонстрация расчета координаты при равноускоренном движении;");
                    Console.WriteLine(" '3'  - Демонстрация расчета координаты при колебательном движении;");
                    Console.WriteLine("'Esc' - Для выхода из программы...");
                    Console.WriteLine("----------------------------------------------------------------------\n");

                    key = _getch();
                    ascii = key;

                    switch (ascii)
                    {
                        case '1':
                            {
                                Console.WriteLine("Введите начальную координату Х");
                                double coordinate = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Введите время в секундах");
                                int time = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите скорость");
                                double speed = Convert.ToDouble(Console.ReadLine());

                                IMovement solid = new Uniformly(coordinate, time, speed);
                                double newSolid = solid.CalculateNewCoordinate();
                                Console.WriteLine("Значение новой координаты Х: " + newSolid);

                                Console.ReadKey();
                                break;
                            }
                        case '2':
                            {
                                Console.WriteLine("Введите начальную координату Х");
                                double coordinate = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Введите время в секундах");
                                int time = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите начальную скорость");
                                double speed = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Введите ускорение");
                                double acceleration = Convert.ToDouble(Console.ReadLine());

                                IMovement solid = new UniformlyAccelerated(coordinate, time, speed, acceleration);
                                double newSolid = solid.CalculateNewCoordinate();
                                Console.WriteLine("Значение новой координаты Х: " + newSolid);

                                Console.ReadKey();
                                break;
                            }
                        case '3':
                            {
                                Console.WriteLine("Введите амплитуду");
                                double amplitude = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Введите частоту");
                                double cyclicFrequency = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Введите время в секундах");
                                int time = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите начальную фазу");
                                double initialPhase = Convert.ToDouble(Console.ReadLine());

                                IMovement solid = new Oscillatory(amplitude, cyclicFrequency, time, initialPhase);
                                double newSolid = solid.CalculateNewCoordinate();
                                Console.WriteLine("Значение новой координаты Х: " + newSolid);

                                Console.ReadKey();
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Некорректное значение");
                                Console.ReadKey();
                                break;
                            }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Несоответсвие типа");
                    Console.ReadKey();
                }
                
            }
        }
    }
}
