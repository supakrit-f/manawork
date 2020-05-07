using Microsoft.VisualBasic.CompilerServices;
using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            string LedNo1 = " ";
            string LedNo2 = " ";
            string LedNo3 = " ";
            string LedNo4 = " ";
            string LedNo5 = " ";
            string LedNo6 = " ";
            string LedNo7 = " ";
            string LedNo8 = " ";
            string LedNo9 = " ";
            string LedNoA = " ";
            Console.WriteLine("1[ " + LedNo1 + " ] 2[ " + LedNo2 + " ] 3[ " + LedNo3 + " ] " +
                    "4[ " + LedNo4 + " ] 5[ " + LedNo5 + "] 6[ " + LedNo6 + " ] 7[ " + LedNo7 + " ]" +
                    " 8[ " + LedNo8 + " ] 9[ " + LedNo9 + " ] A[ " + LedNoA + " ]");
            do
            {
                Console.WriteLine("Please choose LED to turn On/Off: ");
                string i = Console.ReadLine();
                if (i == "1")
                {
                    if (LedNo1 == " ")
                    {
                        LedNo1 = "!";
                    }
                    else
                    {
                        LedNo1 = " ";
                    }
                }
                if (i == "2")
                {
                    if (LedNo2 == " ")
                    {
                        LedNo2 = "!";
                    }
                    else
                    {
                        LedNo2 = " ";
                    }
                }
                if (i == "3")
                {
                    if (LedNo3 == " ")
                    {
                        LedNo3 = "!";
                    }
                    else
                    {
                        LedNo3 = " ";
                    }
                }
                if (i == "4")
                {
                    if (LedNo4 == " ")
                    {
                        LedNo4 = "!";
                    }
                    else
                    {
                        LedNo4 = " ";
                    }
                }
                if (i == "5")
                {
                    if (LedNo5 == " ")
                    {
                        LedNo5 = "!";
                    }
                    else
                    {
                        LedNo5 = " ";
                    }
                }
                if (i == "6")
                {
                    if (LedNo6 == " ")
                    {
                        LedNo6 = "!";
                    }
                    else
                    {
                        LedNo6 = " ";
                    }
                }
                if (i == "7")
                {
                    if (LedNo7 == " ")
                    {
                        LedNo7 = "!";
                    }
                    else
                    {
                        LedNo7 = " ";
                    }
                }
                if (i == "8")
                {
                    if (LedNo8 == " ")
                    {
                        LedNo8 = "!";
                    }
                    else
                    {
                        LedNo8 = " ";
                    }
                }
                if (i == "9")
                {
                    if (LedNo9 == " ")
                    {
                        LedNo9 = "!";
                    }
                    else
                    {
                        LedNo9 = " ";
                    }
                }
                if (i == "A")
                {
                    if (LedNoA == " ")
                    {
                        LedNoA = "!";
                    }
                    else
                    {
                        LedNoA = " ";
                    }
                }
                Console.WriteLine("1[ " + LedNo1 + " ] 2[ " + LedNo2 + " ] 3[ " + LedNo3 + " ] " +
                    "4[ " + LedNo4 + " ] 5[ " + LedNo5 + "] 6[ " + LedNo6 + " ] 7[ " + LedNo7 + " ]" +
                    " 8[ " + LedNo8 + " ] 9[ " + LedNo9 + " ] A[ " + LedNoA + " ]");

            } while (count == 1);
        }
    }
}
