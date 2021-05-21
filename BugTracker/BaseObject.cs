using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BugTracker
{
    public class BaseObject
    {



        public string Description { get; set; }
        public string Information { get; set; }
        public DateTime Date { get; set; }
        public enum Severity : byte { Unknown = 0, Critical, Urgent, Important, Medium, Minor }
        public Severity Code { get; set; }
        public DateTime SolvedDate { get; set; }
        public string Observations { get; set; }
        public bool IsSolved;
        public void Solve()
        {
            IsSolved = true;
            SolvedDate = DateTime.Now;
        }
        override public string ToString()
        {
            char nl = '\x02';
            return $"" +
                $"{Information}{nl}" +
                $"{Code}{nl}" +
                $"{Date}{nl}" +
                $"{IsSolved}{nl}" +
                $"{SolvedDate}{nl}" +
                $"{Observations}{nl}" +
                $"{Description}{nl}" +
                $"\x00";
        }

        static public All ParseFile(string text)
        {
            All ret = new All();
            string[] x = text.Split('\x01');
            string[] bugs = x[0].Split('\x00');
            string[] tasks = x[1].Split('\x00');

            foreach (string i in bugs)
            {
                Bug bug = Bug.Parse(i);
                if (bug != null)
                    ret.BugArray.Add(bug);

            }
            foreach (string i in tasks)
            {
                Task task = Task.Parse(i);
                if (task != null)
                    ret.TaskArray.Add(task);

            }   
            return ret;


        }

        static public void SaveTo(string file, All problems)
        {
            using (StreamWriter outputFile = new StreamWriter(file, true))
            {
                //Iterate through every bug and add to file
                string outputString = "";
                foreach (Bug i in problems.BugArray)
                {
                    outputString += i.ToString();
                }
                outputFile.WriteLine('\x01');
                foreach (Bug i in problems.BugArray)
                {
                    outputString += i.ToString();
                }
                outputFile.WriteLine(outputString);
            }
        }

    }
}