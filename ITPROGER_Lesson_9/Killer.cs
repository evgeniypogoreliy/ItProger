using System;

namespace ITPROGER_Lesson_9{

    enum Type {Enemy, Hero, Traitor}
    class Killer : Robot {

        public int Helth {get; set;}

        public Killer(){}

        public Type type;

        public Killer(string name, int wedth, byte[] coordinates, int helth, Type type) : base(name, wedth, coordinates){
            this.Helth = helth;
            this.type = type;
        }

        public override void prinValues(){
            System.Console.WriteLine(this.Name +" wedth: " + this.Wedth + ".");
            System.Console.WriteLine("Helth: "+ this.Helth);

            if(this.type == Type.Hero)
               Console.Write("He is hero!");
        }
        

        public void Lazer(){
            System.Console.WriteLine("Lazer  shooting");
            this.surname = "Doe";
        }
    }
}