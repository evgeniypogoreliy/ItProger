using System;

namespace ITPROGER_Lesson_9{
    class Robot{

        private static int count;

        private string name;

        private int wedth;

        private byte[] coordinates;

        public string Name {
            get{
                return name;
            }
         private set{}
         }

        protected string surname;

        public int Wedth{
            get{
                System.Console.Write("Результат: ");
                return this.wedth;
            }
            set{
                if(value < 1)
                   this.wedth = 1;
                else if(value > 5000)
                    this.wedth = 5000;    
                else 
                   this.wedth = value;   
            }
        }

        public Robot(string name, int wedth, byte[] coordinates){
            System.Console.WriteLine("Object has been created");
            setValues(name, wedth, coordinates);
            count++;
        }

        public Robot(string name){
            System.Console.WriteLine("Object has been created");
            count++;
        }

        public Robot(){
            System.Console.WriteLine("Object has been created");
            count++;
        }

        public void setValues(string name, int wedth, byte[] coordinates){
            this.name = name;
            this.wedth = wedth;
            this.coordinates = coordinates;
        }

        public void prinValues(){
            System.Console.WriteLine(this.name +" wedth: " + this.wedth + ". Coordinates");
            foreach(byte el in this.coordinates)
            System.Console.WriteLine(el);
        }

        public static void Print(){
            System.Console.WriteLine("Count is: " + count);
        }

    }
}