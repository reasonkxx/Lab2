using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_2.LAB
{
    internal class Treygolnik
    {
        public double x1, y1, x2, y2, x3, y3, AB, BC, AC, p, S, Ad = 0, Bd = 0, Cd = 0;
        string TypeOfAngles, TypeOfTriangle;
        public Treygolnik(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
            AB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            BC = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            AC = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
        }
        public double Perimeter()
        {
            return p = AB + BC + AC;
        }
        public double Ploscha()
        {
            return S = Math.Sqrt((p / 2) * ((p / 2) - AB) * ((p / 2) - BC) * ((p / 2) - AC));
        }
        public double Visota()
        {
            return (2 * S) / AB;
        }
        public double Bisektrisa()
        {
            return (2 * Math.Sqrt(AB * BC * (p / 2) * ((p / 2) - AC))) / (AB + BC);
        }
        public double RadOp()
        {
            return (AB * BC * AC) / 4 * Math.Sqrt((p / 2) * ((p / 2) - AB) * ((p / 2) - AC) * ((p / 2) - BC));
        }
        public double RadVpis()
        {
            return Math.Sqrt((((p / 2) - AB) * ((p / 2) - AC) * ((p / 2) - BC)) / (p / 2));
        }
        public string TypeOf()
        {
            if ((AB * AB == BC * BC + AC * AC) || (BC * BC == AB * AB + AC * AC) || (AC * AC == AB * AB + BC * BC))
            {
                TypeOfAngles = "Прямоугольный";
            }
            if ((AB * AB > BC * BC + AC * AC) || (BC * BC > AB * AB + AC * AC) || (AC * AC > AB * AB + BC * BC))
            {
                TypeOfAngles = "Треугольный";
            }
            else TypeOfAngles = "Остроугольный ";

            if (AB == BC || AB == AC || BC == AC)
            {
                TypeOfTriangle = "Равнобедренный";
            }
            if (AB == BC && BC == AC && AB == AC)
            {
                TypeOfTriangle = "Равносторонний";
            }
            else TypeOfTriangle = "Треугольник";
            return TypeOfAngles + TypeOfTriangle;
        }
        public string RotatePoint()
        {
            Console.WriteLine();
            Console.WriteLine("9 Выберите вершину (1=a,2=b,3=c)");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("9 На сколько градусов повернуть ?");
            int temp = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Bd = Bd + temp;
                Cd = Cd + temp;
                return $"Вершины B i C повернулись на {temp} градусов относительно точки";
            }
            if (choice == 2)
            {
                Ad = Ad + temp;
                Cd = Cd + temp;
                return $"Вершины A i C повернулись на {temp} градусов относительно заданой точки";
            }
            if (choice == 3)
            {
                Bd = Bd + temp;
                Ad = Ad + temp;
                return $"Вершины B i A повернулись на {temp} градусов относительно заданой точки";
            }
            else
            {
                return "null";
            }
        }
        public string RotateCenter()
        {
            Console.WriteLine();
            Console.WriteLine("10 На сколько градусов вернуть треугольник относительно центра вписанного круга ?");
            int temp = int.Parse(Console.ReadLine());
            Ad = Ad + temp;
            Bd = Bd + temp;
            Cd = Cd + temp;
            return $"Вершины A,B,C повернулись на {temp} градусов относительно центру вписанного круга";
        }
        public string Ravenstvo()
        {
            Console.WriteLine();
            Console.WriteLine("Введите координаты другого треугольника ");
            Console.WriteLine("x1:");
            double x11 = double.Parse(Console.ReadLine());
            Console.WriteLine("y1:");
            double y11 = double.Parse(Console.ReadLine());
            Console.WriteLine("x2:");
            double x22 = double.Parse(Console.ReadLine());
            Console.WriteLine("y2:");
            double y22 = double.Parse(Console.ReadLine());
            Console.WriteLine("x3:");
            double x33 = double.Parse(Console.ReadLine());
            Console.WriteLine("y3:");
            double y33 = double.Parse(Console.ReadLine());
            double AB1 = Math.Sqrt(Math.Pow(x22 - x11, 2) + Math.Pow(y22 - y11, 2));
            double BC1 = Math.Sqrt(Math.Pow(x33 - x22, 2) + Math.Pow(y33 - y22, 2));
            double AC1 = Math.Sqrt(Math.Pow(x33 - x11, 2) + Math.Pow(y33 - y11, 2));
            if ((AB == AB1 && BC == BC1 && AC == AC1 || AB == BC1 && BC == AC1 && AC == AB1 || AB == AC1 && BC == AB1 && AC == BC1) == true)
            {
                return "Треугольники равные";
            }
            else
            {
                return "Треугольники не равные";
            }
        }
    }
}
