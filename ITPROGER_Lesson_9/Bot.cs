namespace ITPROGER_Lesson_9{

    class Bot : Robot{

        public Bot(){}

        public Bot(string name, int wedth, byte[] coordinates) : base(name, wedth, coordinates){

        }

        public override void prinValues(){   
            System.Console.WriteLine(this.Name +" wedth: " + this.Wedth + ". Coordinates");
            foreach(byte el in this.Coordinates)
            System.Console.WriteLine(el);
        }

    }
}