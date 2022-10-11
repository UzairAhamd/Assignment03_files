using System;
using System.Collections.Generic;
namespace UzairAhmadA03
{
    public class Candidate
    {
        public string name;
  //      public string cnic;
 //       public string contact;
//        public string email;
        public string city;
//        public string degree;
        public string cgpa;
        //public int totalCandidates()
        //{
        //    return;
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Candidate> Persons = new List<Candidate>();
            int maxCandidateThreshold = 3;
            int maxCandidates = 0;
            //string bookNextCandidate="y";
            while (maxCandidates < maxCandidateThreshold)
            {
                Console.WriteLine("Enter Candidate "+ (maxCandidates+1)+" info: ");
                Candidate C = new Candidate();
                Console.Write("Enter Name: ");
                C.name = Console.ReadLine();
                Console.Write("Enter City: ");
                C.city = Console.ReadLine();
                Console.Write("Enter CGPA: ");
                C.cgpa = Console.ReadLine();
                Persons.Add(C);
                if (maxCandidates < (maxCandidateThreshold - 1)) 
                {
                    Console.WriteLine("Do you want to enter more candidate data? (y/n)");
                    string bookNextCandidate = Console.ReadLine();
                    if (bookNextCandidate == "n")
                    {
                        break;
                    }
                }
                maxCandidates++;
            }
            foreach (Candidate i in Persons) { Console.WriteLine(i.name + " " + i.city + " " + i.cgpa); }
        }
    }
}
