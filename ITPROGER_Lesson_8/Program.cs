using System;
class Program{

    static void Main(){

        try {
            int a, b, res;
            Console.Write("Введите первое число: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = Convert.ToInt32(Console.ReadLine());
            res = a / b;
            System.Console.WriteLine("Результат: " + res);
        }catch(DivideByZeroException){
            Console.WriteLine("Деление на ноль!");
        }catch(FormatException){
            Console.WriteLine("Вы ввели не тот формат!");
        }finally{
            Console.WriteLine("Конец программы!");
        }
    }
}