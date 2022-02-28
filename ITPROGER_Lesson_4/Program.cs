using System;

namespace ITPROGER_Leson_1 {

    class Program {


        static void Main() {
            System.Console.WriteLine("Enter yor name");
            String role = Console.ReadLine();

            if(role == "Admin"){ 
                Console.Write("Enter user name: ");
                String user_name = Console.ReadLine();
                Console.Write("Enter {0} age: ", user_name);
                short age = Convert.ToInt16(Console.ReadLine());
                if(age <= 0 || age >99)
                    Console.WriteLine("Error");
                else
                    System.Console.WriteLine("User age " + age);

            
            
            }else 
            System.Console.WriteLine("You are not Admin");
           



        }

    }        
}