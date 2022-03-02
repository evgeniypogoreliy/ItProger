using System;

class Program{

    static void Main(){

        short[] numbers = new short[10];
        short summa = 0;
        
        Random random = new Random();
        for(byte i = 0; i < numbers.Length; i++){
            
            numbers[i] = Convert.ToInt16( random.Next(5, 15));
            System.Console.WriteLine("Elem: " + numbers[i]);
            summa += numbers[i];
        }
        System.Console.WriteLine("Summa: " + summa);
    }
}