using System;
using System.Collections.Generic;

namespace ITPROGER_Lesson_9{
    class Program{

        public static void Main(){
            Bot bot = new Bot("Bot", 800, new byte[] {0, 0, 0});
           
            bot.prinValues();

            // bot.name = "Bot";
            // bot.wedth = 800;
            // bot.coordinates = new byte[] {0, 0, 0};

            Killer killer = new Killer("killer", 1000, new byte[] {0, 0, 10}, 100, Type.Hero);
            // killer.setValues("killer", 1000, new byte[] {0, 0, 10});
            killer.prinValues();
            // killer.Helth = 100;
            killer.Lazer();

            // killer.name = "killer";
            // killer.wedth = 1000;
            // killer.coordinates = new byte[] {0, 0, 10};

            Bot bot1 = new Bot();
            bot1.Wedth = -100;

            // Robot.Print();

            // List<Killer> robots = new List<Killer>();
            // robots.Add(new Killer("Alex", 400, new byte[] {0, 0, 10}, 100));
            // robots.Add(new Killer("Bob", 400, new byte[] {0, 10, 10}, 100));
            // robots.Add(new Killer("John", 800, new byte[] {10, 0, 10}, 100));
            // robots.Add(new Killer("Josh", 600, new byte[] {0, 50, 10}, 100));

            // Robot newRobot = null;
            // foreach(Killer obj in robots){
            //     if(obj.Name == "John"){
            //     newRobot = obj as Robot;
            //      Console.WriteLine(obj.Name);
            //     }
            //     Console.Write(obj is Robot);
            //}    
        }
    }
}    