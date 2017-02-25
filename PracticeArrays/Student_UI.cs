using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//*******************************
//Programmer:  Grant Thompson
// ITDEV115 SPRING 2017 TUESDAY EVENING
//Purpose:  Assignment #2A﻿﻿ Practice Arrays
//Date:2-8-17
//Instructor: Judith Ligocki
//*******************************
namespace PracticeArrays
{
    class Student_UI
    {

        private Student student;
        readonly String[] DAYS = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        
        

         public void MainMethod()
         {
            string tempName, tempId;

            Console.Clear();
            Console.WriteLine("\nPlease enter your name.");
            Console.Write("> ");
            tempName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\n{0}, please enter your student ID#.", tempName);
            Console.Write("> ");
            tempId = Console.ReadLine();
            Console.Clear();
            student = new Student(tempId, tempName);
            FillHours();

        }//end MainMethod()





        private void FillHours()//loop to prompt for input and add to the student hours array..
        {
            bool gotDouble = false;
            double tempDouble;

            Console.WriteLine("\n{0}, please enter the prompted day's hours of study:\n", student.Name);
            for (int i = 0; i < DAYS.Length; i++)//begin getting study hours loop
            {
                do
                {
                    Console.Write("Enter total hours studied for {0} ==> ", DAYS[i]);
                    gotDouble = double.TryParse(Console.ReadLine(), out tempDouble);
                } while (gotDouble == false);//loop until double has been entered

                student.Hours[i] = tempDouble;


            }

            DisplayData();

        }//end GetStudyHours()



        private void DisplayData() //Display name id and Array contents...
        {
            Console.Clear();
            Console.WriteLine("\nStrudent:\t{0}\nId#:\t\t{1}\n", student.Name, student.Id);
            for (int i = 0; i<DAYS.Length;i++)
            {
                if(DAYS[i].Length<7)
                    Console.WriteLine("{0}:\t\t{1}hrs entered.",DAYS[i], student.Hours[i]);
                else
                    Console.WriteLine("{0}:\t{1}hrs entered.", DAYS[i], student.Hours[i]);
            }
            DisplayAverage(student.Name);
            Console.WriteLine("\n\nPress any key to exit.");
            Console.ReadKey();
        }//end DisplayHours()

        private void DisplayAverage(string name)//Average of study hours per day for the week.
        {
            Console.WriteLine("\n{0}, you have an average of {1:0.00} hours of daily study for the week.", name, student.CalculateAvg());
        }

        
    }//end class
}// end namespace
