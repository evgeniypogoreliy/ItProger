using System; // Импорт библиотеки

namespace ITPROGER_Leson_1 {

    class Program {

        static void Main(){
            int number = 0;          // Положительные целые числа от -2147483648 до 2147483647
            uint number2 = 4294967295; // uint только положительные целые числа от 0 до 4294967295
            byte number3 = 0;          // Целые числа от 0 до 255
            short number4 = -32768;    // Целые числа от -32768 до 32767
            long number5 = 7777777;    // Целые числа от -9223372036854775808 до 9223372036854775807
            float number6 = 2.3434f;   // Дробные числа от 1.175494351 Е - 38 до 3.402803466 Е +38
            double number7 = 4.218d;  // Дробные числа от 2.2250738585072014 E - 308 до 1,7976931348623158 Е +308

            String word = "Переменная: "; //буквенное вырожение, строка
            // char simbol = 's' Тип данных для одного знака

            bool isHeppy = false;         
            // Буливый тип данных принимает два значение true/false

            number = Convert.ToInt32(Console.ReadLine());   
            // Принимаем от пользователя строку и конвертируем ее в int

            Console.WriteLine(word +number);
            Console.WriteLine(word +number2);
            Console.WriteLine(word +number3);
            Console.WriteLine(word +number4);
            Console.WriteLine(word +number5);
            Console.WriteLine(word +number6);
            Console.WriteLine(word +number7);
        }

    }
}