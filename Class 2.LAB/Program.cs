using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Class_2.LAB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choose ;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Введите координаты треугольника");
                Console.WriteLine("x1:");
                double x1 = double.Parse(Console.ReadLine());
                Console.WriteLine("y1:");
                double y1 = double.Parse(Console.ReadLine());
                Console.WriteLine("x2:");
                double x2 = double.Parse(Console.ReadLine());
                Console.WriteLine("y2:");
                double y2 = double.Parse(Console.ReadLine());
                Console.WriteLine("x3:");
                double x3 = double.Parse(Console.ReadLine());
                Console.WriteLine("y3:");
                double y3 = double.Parse(Console.ReadLine());
                Treygolnik Tr = new Treygolnik(x1, y1, x2, y2, x3, y3);
                Console.WriteLine($"1 Периметр треугольника = {Tr.Perimeter()}");
                Console.WriteLine($"2 Площадь треугольника = {Tr.Ploscha()}");
                Console.WriteLine($"3 Высота треугольника = {Tr.Visota()}");
                Console.WriteLine($"4 Бисекриса треугольника = {Tr.Bisektrisa()}");
                Console.WriteLine($"5 Радиус описанного круга = {Tr.RadOp()}");
                Console.WriteLine($"6 Радиус вписанного круга = {Tr.RadVpis()}");
                Console.WriteLine($"7 Тип треугольника = {Tr.TypeOf()}");
                Console.WriteLine($"8 {Tr.RotatePoint()}");
                Console.WriteLine($"9 {Tr.RotateCenter()}");
                Console.WriteLine($"10 {Tr.Ravenstvo()}");
                Console.WriteLine("11 Объект сериализовано");
                string jsonData = JsonConvert.SerializeObject(Tr);
                string path = @"C:\Users\chubk\Desktop\Json.txt";
                File.WriteAllText(path, jsonData);
                Console.WriteLine("Для того чтобы продолжить нажмите 1");
                choose = Console.ReadLine();
            } while (choose == "1");
        }

        public static object Deserialize()
        {
            using (StreamReader reader = File.OpenText(@"C:\Users\chubk\Desktop\Json.txt"))
            {
                JsonSerializer serializer = new JsonSerializer();
                Treygolnik Tr = (Treygolnik)serializer.Deserialize(reader, typeof(Treygolnik));
                return Tr;
            }
        }
    }
}      
    

