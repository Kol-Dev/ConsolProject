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
            int NumberStart = 0, NumberStop = 8; // !
            // !


            Random rnd = new Random();
            string[] surarray = { "A", "B", "C", "D" };
            List<string> list1 = new List<string>() { "A1", "B1", "C1", "D1", "E1", "F1", "G1", "H1" };
            List<string> list2 = new List<string>() { "A2", "B2", "C2", "D2", "E2", "F2", "G2", "H2" };
            List<string> list3 = new List<string>() { "A3", "B3", "C3", "D3", "E3", "F3", "G3", "H3" };
            List<string> list4 = new List<string>() { "A4", "B4", "C4", "D4", "E4", "F4", "G4", "H4" };
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
                while (plus == less)
                {
                    plus = rnd.Next(0, containerlist1.Count);
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
            Console.WriteLine(" Container list 2: " + String.Join(" - ", containerlist2));

        }
        
    }
}
