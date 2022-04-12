using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using ConsoleProject.Classes;

namespace ConsoleProject
{
    class Program
    {
        static void Main()
        {
            // !
            int NumberStart = 0, NumberStop = 16; // !
            // NumberStop = Number of things at the end /2
            

            Random rnd = new Random();
            string[] surarray = { "1", "2", "3", "4", "5", "6", "7", "8" }; // Number of list
            List<string> list1 = new List<string>() { "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "A10" };
            List<string> list2 = new List<string>() { "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "B10" };
            List<string> list3 = new List<string>() { "C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8", "C9", "C10" };
            List<string> list4 = new List<string>() { "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "D10" };
            List<string> list5 = new List<string>() { "E1", "E2", "E3", "E4", "E5", "E6", "E7", "E8", "E9", "E10" };
            List<string> list6 = new List<string>() { "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10" };
            List<string> list7 = new List<string>() { "G1", "G2", "G3", "G4", "G5", "G6", "G7", "G8", "G9", "G10" };
            List<string> list8 = new List<string>() { "H1", "H2", "H3", "H4", "H5", "H6", "H7", "H8", "H9", "H10" };
            List<string> containerlist1 = new List<string>();
            List<string> containerlist2 = new List<string>();
            int surIndex, Index;
            int a, plus, less;


            while (NumberStart < NumberStop)
            {
                surIndex = rnd.Next(0, surarray.Length);
                switch (surIndex)
                {
                    case 0:
                        Index = rnd.Next(0, list1.Count);
                        containerlist1.Add(list1[Index].ToString());
                        list1.Remove(list1[Index]);
                        break;
                    case 1:
                        Index = rnd.Next(0, list2.Count);
                        containerlist1.Add(list2[Index].ToString());
                        list2.Remove(list2[Index]);
                        break;
                    case 2:
                        Index = rnd.Next(0, list3.Count);
                        containerlist1.Add(list3[Index].ToString());
                        list3.Remove(list3[Index]);
                        break;
                    case 3:
                        Index = rnd.Next(0, list4.Count);
                        containerlist1.Add(list4[Index].ToString());
                        list4.Remove(list4[Index]);
                        break;
                    case 4:
                        Index = rnd.Next(0, list5.Count);
                        containerlist1.Add(list5[Index].ToString());
                        list1.Remove(list5[Index]);
                        break;
                    case 5:
                        Index = rnd.Next(0, list6.Count);
                        containerlist1.Add(list6[Index].ToString());
                        list2.Remove(list6[Index]);
                        break;
                    case 6:
                        Index = rnd.Next(0, list7.Count);
                        containerlist1.Add(list7[Index].ToString());
                        list3.Remove(list7[Index]);
                        break;
                    case 7:
                        Index = rnd.Next(0, list8.Count);
                        containerlist1.Add(list8[Index].ToString());
                        list4.Remove(list8[Index]);
                        break;
                    default:
                        Console.WriteLine("Autre");
                        break;
                }
                NumberStart += 1;
            }

            Console.WriteLine(String.Join(" - ", containerlist1));

            a = containerlist1.Count();
            while (a > 0)
            {
                less = rnd.Next(0, containerlist1.Count);
                Console.WriteLine("Less: " + containerlist1[less]);
                containerlist1.Remove(containerlist1[less]);
                plus = rnd.Next(0, containerlist1.Count);
                if (plus == less) // while
                {
                    plus = rnd.Next(0, containerlist1.Count);
                    // Console.WriteLine(" RESULTS1: " + String.Join(" - ", containerlist2));
                }
                Console.WriteLine("Plus: " + containerlist1[plus]);
                containerlist2.Add(containerlist1[plus]);
                containerlist1.Remove(containerlist1[plus]);
                Console.WriteLine(" Container list 1: " + String.Join(" - ", containerlist1));
                Console.WriteLine(" Container list 2: " + String.Join(" - ", containerlist2));
                Thread.Sleep(2000);
                a = a - 2;
            };

            Console.WriteLine();
            Console.WriteLine(" RESULTS: " + String.Join(" - ", containerlist2));

        }
        
    }
}
