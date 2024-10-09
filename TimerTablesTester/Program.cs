using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace TimerTablesTester
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            bool playing = true;
            while (playing == true)
            {
                Console.WriteLine("If you want to exit Time Table Tester - Enter `X`, If not press any other key."); //if you want to exit before a new game
                string exit = Console.ReadLine(); //stores
                if (exit == "X") //if you want to exit
                { 
                    Console.WriteLine("Goodbye!");
                    playing = false; //stops loop
                    break; //breaks out of loop
                }
                Console.WriteLine("Welcome!");
                Console.WriteLine("What is your name? "); //input name
                string name = Console.ReadLine(); //stores name
                Console.WriteLine(name + " what times table would you like to learn?"); //asks what time tables
                int timetable = int.Parse(Console.ReadLine()); //stores answer
                if (timetable >= 1 && timetable <= 12) //checks if answer is 1-12
                {
                int score = TimeTables(timetable); //runs the int method 
                    if (score <= 5)
                    {
                        Console.WriteLine("You need more practice"); 
                        Console.WriteLine("You scored: " + score + "/10"); //score is returned to here
                    }
                    else if (score <= 8)
                    {
                        Console.WriteLine("Thats pretty good!");
                        Console.WriteLine("You scored: " + score + "/10"); //score is returned to here
                    }
                    else if (score >= 9)
                    {
                        Console.WriteLine("Excellent");
                        Console.WriteLine("You scored: " + score + "/10"); //score is returned to here
                    }
                 
          
                     }
                else //if not 1-12
                {
                  Console.WriteLine("An error has occured :( (invaid input)"); //error
                   return;//returns to the loop
                 }
               Console.ReadLine(); //reads all the lines!
            }
           
        }
        static int TimeTables(int timetable) //Method TimeTables
        {
            int score = 0; //value of score
            for (int i = 0; i < 10; i++)//For loop for 10 questions
            {
               
                Random r = new Random(); //imports random
                int RandNumber = r.Next(1, 13); // Generates random number
                Console.WriteLine("What is " + RandNumber + "x" + timetable); //The question
                int answer = int.Parse(Console.ReadLine()); //stores answer
                int realAnswer = (timetable * RandNumber); //gets the answer
                if (answer == realAnswer) //checks the answer is correct
                {
                   Console.WriteLine("Well done you got it correct!");
                    score++; //adds to score as it is correct
                    //Console.WriteLine(score);
                }
                else
                {
                    Console.WriteLine("Sorry you got it incorrect!"); //says it is incorrect
                }
            }
            return score;



        }
        
    }
}
