using System;
namespace School
{
    class Student
    {
        static void Main(string[] args)
        {
            string studentName;
            int english, maths, sience;
            float percent = 0, amount = 0;

            Console.WriteLine("Enter the name of the student : ");
            studentName = Console.ReadLine();   
            Console.WriteLine("Enter marks in English  : ");
            english = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Enter marks in Maths  : ");
            maths =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks in Sience  : ");
            sience = Convert.ToInt32(Console.ReadLine());

            if((english >=0 && english <=100) && (maths >=0 && maths <=100) && (sience >= 0 && sience <= 100)) 
            {
                if(english >=35 && maths >=35 && sience>=35)
                {
                    percent = ((english + maths + sience) * 100) / 300;
                        if (percent >= 75)
                        amount = 1500;
                    else if (percent >= 60 && percent <= 75)
                        amount = 1000;
                    else
                        amount = 0;

                    Console.WriteLine("\nStudent Name: " + studentName);
                    Console.WriteLine("Totals Marks : "+(english+maths+sience));
                    Console.WriteLine("Percentage : " + percent + "%");

                    Console.WriteLine("Scholarship Amount: " + amount + "$");
               
                }
                else
                {
                    Console.WriteLine("\nStudent Name: " + studentName);
                    Console.WriteLine("Result : Failed");
                }
            }
            else
            {
                Console.WriteLine("Invalid entry of marks");
            }
        }
    }
}