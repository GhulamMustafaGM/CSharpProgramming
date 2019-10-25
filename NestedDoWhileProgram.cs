// NestedDoWhile Loop Program 

using System;  
public class NestedDoWhileProgram
    {  
        
      public static void Main(string[] args)  
      {  
          int a = 1;

          do{  
              int b = 1;
            
            do{
                Console.WriteLine(a+ " " +b);
                b++;
            }
            while(b <= 3);
           a++;
           } while(a <= 3);
     }
 } 