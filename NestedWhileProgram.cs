// NestedWhile Loop Program

using System;  
public class InfiniteForProgram
    {  
        
      public static void Main(string[] args)  
      {  
          int a = 1;
          while (a <= 5 )  
          {  
              int b = 1;
              while( b <= 7)
              {
                  Console.WriteLine(a+ " "+b);
                  b++;
              }
              a++;
          }   
      }  
 } 