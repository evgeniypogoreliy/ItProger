using System;

namespace ITPROGER_Lesson_9{
    class Killer : Robot {

        public int Helth {get; set;}

        public Killer(){}

        public Killer(string name, int wedth, byte[] coordinates, int helth) : base(name, wedth, coordinates){
            this.Helth = helth;
            base.prinValues();

        }
        

        public void Lazer(){
            System.Console.WriteLine("Lazer  shooting");
            this.surname = "Doe";
        }
    }
}