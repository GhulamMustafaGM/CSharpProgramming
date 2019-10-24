// Switch Program

using System;  
  public class SwitchProgram  
    {  
      public static void Main(string[] args)  
      {  
          Console.WriteLine("Enter a value:");

          int value = Convert.ToInt32(Console.ReadLine());  
  
          switch (value)  
          {  
              case 10:
                     Console.WriteLine("It is 20");
                      break;  
              case 20:
                     Console.WriteLine("It is 30");
                      break;  
              case 30:
                     Console.WriteLine("It is 40");
                      break;  
              default:
                     Console.WriteLine("Not 20, 30 or 40");
                      break;  
          }  
      }  
    }