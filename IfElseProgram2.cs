// IfElse Program - User Input

using System;      
public class IfProgram 
    {  
       public static void Main(string[] args)  
        {  
            Console.WriteLine("Enter a value:");  
            int value = Convert.ToInt32(Console.ReadLine());  
  
            if (value % 2 == 0)  
            {  
                Console.WriteLine("It is even value:");  
            }  
            else  
            {  
                Console.WriteLine("It is odd value: ");  
            }  
              
        }  
    }  