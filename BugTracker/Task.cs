using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker
{
    public class Task : BaseObject
    {
        public Task(string bug, BaseObject.Severity severity)
        {
            Date = DateTime.Now;
            Information = bug;
            Code = severity;
            IsSolved = false;
        }
        public Task(string info, BaseObject.Severity severity, string description, string observations)
        {
            Date = DateTime.Now;
            Information = info;
            Code = severity;
            IsSolved = false;
            Description = description;
            Observations = observations;
        }
        public static Task Parse(string text)
        {
            if (String.IsNullOrEmpty(text))
                return null;
            string[] x = text.Split('\x02');
            BaseObject.Severity sev = (BaseObject.Severity)Enum.Parse(typeof(BaseObject.Severity), x[1]); //Converting the string severity code to enum type
            Task ret = new Task(x[0], sev); // 0 = info
            ret.Date = DateTime.Parse(x[2]);
            if (x[3] == "true")
            {
                ret.IsSolved = true;
                ret.SolvedDate = DateTime.Parse(x[4]);
            }
            ret.Observations = x[5];
            ret.Description = x[6];
            return ret;


        }

    }
}

