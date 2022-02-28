using System; // Импорт библиотеки

namespace ITPROGER_Leson_1 {

    class Program {

        static void Main(){
            System.Console.WriteLine("Ввидите радиус круга :");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            System.Console.WriteLine("Площадь круга с радиусом {0} равна {1}", radius, area);
        }
    }
}             