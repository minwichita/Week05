﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week05lab
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Input your grade (A, B, C, D or F) : ");
            string gradeString = Console.ReadLine();
            string message;
            switch (gradeString.ToUpper())
            {
                case "A":
                    message = "Excellent";
                    break;
                case "B":
                    message = "Good";
                    break;
                case "C":
                    message = "Cool";
                    break;
                case "D":
                    message = "Try";
                    break;
                case "F":
                    message = "Get out!!";
                    break;
                default:
                    message = "Incorrect grade";
                    break;
            }
            Console.WriteLine(message);




        }
    }
        }
  


    


