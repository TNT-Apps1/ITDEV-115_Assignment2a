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
    class Program
    {

        static void Main(string[] args)
        {
            Info info_1 = new Info();
            Student_UI student_ui = new Student_UI();//Main will instantiate a StudentUI Class and Call the MainMethod().

            info_1.DisplayInfo();//display app info
            student_ui.MainMethod();
            

        }//end main
    }//end class
}//end namespace
