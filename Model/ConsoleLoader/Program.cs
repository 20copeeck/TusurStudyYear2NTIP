using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Model
{
    class Program
    {
        /// <summary>
        /// Метод для демонстрации корректной работы бизнес-логики
        /// </summary>
        static void Main()
        {
            double initialCoordinate = 23, speed = 4.1, acceleration = -5;
            double amplitude = 6, frequency = 22.3, initialPhase = -30;
            int time = 11;
            

            IMovement solid1 = new UniformlyMovement(initialCoordinate, speed);
            double newSolid1 = solid1.CalculateNewCoordinate(time);

            Console.WriteLine("Демонстрация расчета координаты при прямолинейном движении\n");
            Console.WriteLine("Начальная координата X = {0};\nСкорость (в м/с) = {1};\nВремя (в сек.) = {2};\n", initialCoordinate, speed, time);
            Console.WriteLine("Значение новой координаты Х: " + newSolid1);
            Console.WriteLine("----------------------------------------------------------");
          
            IMovement solid2 = new UniformlyAcceleratedMovement(initialCoordinate, speed, acceleration);
            double newSolid2 = solid2.CalculateNewCoordinate(time);

            Console.WriteLine("Демонстрация расчета координаты при равноускоренном движении\n");
            Console.WriteLine("Начальная координата X = {0};\nСкорость (в м/с) = {1};\nУскорение = {2};\n", initialCoordinate, speed, acceleration);
            Console.WriteLine("Значение новой координаты Х: " + newSolid2);
            Console.WriteLine("----------------------------------------------------------");

            
            IMovement solid3 = new OscillatoryMovement(amplitude, frequency, initialPhase);
            double newSolid3 = solid3.CalculateNewCoordinate(time);

            Console.WriteLine("Демонстрация расчета координаты при колебательном движении\n");
            Console.WriteLine("Амплитуда = {0};\nНачальная фаза (в градусах) = {1};\nЧастота = {2};\nВремя (в сек.) = {3};\n", amplitude, initialPhase, frequency, time);
            Console.WriteLine("Значение новой координаты Х: " + newSolid3);
            Console.WriteLine("----------------------------------------------------------");

            Console.ReadKey();
        }
    }
}
