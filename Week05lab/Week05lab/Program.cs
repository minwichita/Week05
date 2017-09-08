using System;
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
            Console.Write("Input day name : ");
            string Day = Console.ReadLine();
            string message;
            switch (Day.ToUpper())
            {
                case "SUN":
                    message = "sun is Sunday, color Red";
                    break;
                case "MON":
                    message = "mon is monday, color Yello";
                    break;
                case "TUE":
                    message = "Tue is Tuesday, color Pink";
                    break;
                case "WED":
                    message = "Wed is Wednesday, color Green";
                    break;
                case "THU":
                    message = "Thu is Thursday, color Orange";
                    break;
                case "FRI":
                    message = "Fri is Friday, color Blue";
                    break;
                case "SAT":
                    message = "Sat is Saturday, color Purple";
                    break;
                default:
                    message = "Incorrect day";
                    break;
            }
            Console.WriteLine(message);



        }

    }



    }
        
    


  


    


