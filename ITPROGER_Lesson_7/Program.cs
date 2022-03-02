using System;
using System.IO;

class Program{

    public static void Main(){
        // System.Console.WriteLine("Введите текст");
        // string text = Console.ReadLine();
        // using(FileStream stream = new FileStream("info1.txt", FileMode.OpenOrCreate)){
        //     byte[] array = System.Text.Encoding.Default.GetBytes(text);

        //     stream.Write(array, 0, array.Length);
        // }

        using(FileStream stream1 = File.OpenRead("info1.txt" )) {
            byte[] array = new byte[stream1.Length];

            stream1.Read(array, 0, array.Length);

            string textFromFile = System.Text.Encoding.Default.GetString(array);
            System.Console.WriteLine(textFromFile); 
        }
    }
}