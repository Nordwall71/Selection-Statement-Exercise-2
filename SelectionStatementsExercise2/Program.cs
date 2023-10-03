using System;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");
            
            string faveSubject = Console.ReadLine();
            
            
            

            switch (faveSubject)
                
                

               
            
            {

                case "Math":
                    Console.WriteLine("Math is too tough for me!");
                    break;
                case "Gym":
                    Console.WriteLine("You can't be serious...");
                    break;
                case "Lunch":
                    Console.WriteLine("I can't with you.");
                    break;
                case "Science":
                    Console.WriteLine("Now we're getting somewhere!");
                    break;
                case "Reading":
                    Console.WriteLine("Sounds good to me...");
                    break;
                default: Console.WriteLine("I'm not familiar with that at all.");
                    break;

            
            }
        }       
    }
}