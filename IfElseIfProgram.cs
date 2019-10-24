// if else-if program

using System;      
public class IfElseIfProgram  
    {  
        public static void Main(string[] args)  
        {  
            Console.WriteLine("Enter a value to check grade:");  
            int value = Convert.ToInt32(Console.ReadLine());  
  
            if (value <0 || value >100)  
            {  
                Console.WriteLine("wrong number");  
            }  
            else if(value >= 0 && value < 50){  
                Console.WriteLine("Fail");  
            }  
            else if (value >= 50 && value < 60)  
            {  
                Console.WriteLine("D Grade");  
            }  
            else if (value >= 60 && value < 70)  
            {  
                Console.WriteLine("C Grade");  
            }  
            else if (value >= 70 && value < 80)  
            {  
                Console.WriteLine("B Grade");  
            }  
            else if (value >= 80 && value < 90)  
            {  
                Console.WriteLine("A Grade");  
            }  
            else if (value >= 90 && value <= 100)  
            {  
                Console.WriteLine("A+ Grade");  
            }  
        }  
    }