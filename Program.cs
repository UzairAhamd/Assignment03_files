using System;
using System.Collections.Generic;
using System.Linq;
namespace UzairAhmadA03_Attemp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> candidateData = new Dictionary<string, string>() { { "name", "Uzair" }, { "city", "Lahore" }, { "cgpa", "3.2" } };
            List<Dictionary<string,string>> candidateList = new();
            candidateList.Add(candidateData);
            candidateData = new Dictionary<string, string>() { { "name", "Ali" }, { "city", "Rawalpindi" }, { "cgpa", "3.5" } };
            candidateList.Add(candidateData);
            candidateData = new Dictionary<string, string>() { { "name", "Ahmad" }, { "city", "Istanbul2" }, { "cgpa", "4" } };
            candidateList.Add(candidateData);
            candidateData = new Dictionary<string, string>() { { "name", "Umer" }, { "city", "Hafizabad2" }, { "cgpa", "3.5" } };
            candidateList.Add(candidateData);
            candidateData = new Dictionary<string, string>() { { "name", "Afaq" }, { "city", "Rawalpindi" }, { "cgpa", "3.9" } };
            candidateList.Add(candidateData);
            candidateData = new Dictionary<string, string>() { { "name", "Ibrar" }, { "city", "Hafizabad3" }, { "cgpa", "4" } };
            candidateList.Add(candidateData);
            candidateData = new Dictionary<string, string>() { { "name", "Muaz" }, { "city", "Istanbul3" }, { "cgpa", "4" } };
            candidateList.Add(candidateData);
            List<Dictionary<string, string>> sortedCandidateList = new();
            foreach (var dictD in candidateList)
            {
                foreach (var candDetail in dictD)
                {
                    if (candDetail.Key =="cgpa")
                    {
                        if (Convert.ToDouble(candDetail.Value) > 3.3)
                        { 
                            sortedCandidateList.Add(dictD);
                        }
                    }
                }
            }
            foreach (var sortCandDetail in sortedCandidateList)
            {
                Random rand = new Random();
                for (int i = 0; i < 2; i++) 
                {
                    sortCandDetail["marksP"+Convert.ToString(i+1)] = Convert.ToString(rand.Next(1, 101));
                }
                foreach (KeyValuePair<string, string> ele2 in sortCandDetail)
                {
                    Console.Write("{0} : {1}", ele2.Key, ele2.Value+"  ");
                }
                Console.WriteLine();
            }
            List<Dictionary<string, string>> passedSortedCandidateList = new();
            foreach (var dictD in sortedCandidateList)
            {   
                int j = 0;
                double sum = 0;
                foreach (var candDetail in dictD)
                {
                    if (candDetail.Key == "marksP" + Convert.ToString(j + 1))
                    {
                        sum += Convert.ToDouble(candDetail.Value);
                        j++;
                    }
                }
                if (sum > 0.5 * (j + 1)*100)
                {
                    passedSortedCandidateList.Add(dictD);
                }
            }
            Console.WriteLine("Passed");
            foreach (var passSortCandDetail in passedSortedCandidateList)
            {
                foreach (KeyValuePair<string, string> ele2 in passSortCandDetail)
                {
                    Console.Write("{0} : {1}", ele2.Key, ele2.Value + "  ");
                }
                Console.WriteLine();
            }
            //List<Dictionary<string, string>> citySortedCandidateList = new();
            //foreach (var dictD in candidateList)
            //{
            //    foreach (var candDetail in dictD)
            //    {
            //        if (candDetail.Value == "Rawalpindi")
            //        {
            //            citySortedCandidateList.Add(dictD);
            //        }
            //    }
            //}
            //Console.WriteLine("City sorted:");
            //foreach (var citySortCandDetail in citySortedCandidateList)
            //{
            //    foreach (KeyValuePair<string, string> ele2 in citySortCandDetail)
            //    {
            //        Console.Write("{0} : {1}", ele2.Key, ele2.Value + "  ");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}