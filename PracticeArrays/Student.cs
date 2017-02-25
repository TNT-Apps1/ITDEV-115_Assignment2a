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
    class Student
    {
        private double[] hours = new double[7];
        private string name;
        private string id;

        public string Id
        {
            get { return id; }
            
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public double[] Hours //discovered I can set and get hours properties by entity
        {
            get { return hours; }
            set { hours = value; }
        }

        public Student(string id, string name) //constructor
        {

            this.id = id;
            this.name = name;

        }//end constructor



        // discovered I can set and get hours properties by entity (see above)
        //public void EnterHours(int arg1, double arg2)
        //{
        //    hours[arg1] = arg2;
        //}




        public double CalculateAvg() //return average daily hours studied
        {
            double tempHours = 0;

            foreach (double temp1 in hours)
            {
                tempHours = tempHours + temp1;
            }

            tempHours = tempHours / hours.Length;

            return tempHours;
        }





    }
}
