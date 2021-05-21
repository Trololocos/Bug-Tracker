using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BugTracker
{
    public class Bug : BaseObject
    {
        public Bug(string bug, BaseObject.Severity severity,string description)
        {
            Date = DateTime.Now;
            Information = bug;
            Code = severity;
            IsSolved = false;
            Description = description;
        }
        public Bug(string info, BaseObject.Severity severity, string description,string observations)
        {
            Date = DateTime.Now;
            Information = info;
            Code = severity;
            IsSolved = false;
            Description = description;
            Observations = observations;
        }

        static public Bug Parse(string text)
        {
            if (String.IsNullOrEmpty(text))
                return null;
            string[] x = text.Split('\x02');
            BaseObject.Severity sev = (BaseObject.Severity)Enum.Parse(typeof(BaseObject.Severity), x[1]); //Converting the string severity code to enum type
            Bug ret = new Bug(x[0], sev, x[6], x[5]); //The definition of what this means is in BaseObject.ToString
            ret.Date = DateTime.Parse(x[2]);
            if (x[3] == "true")
            {
                ret.IsSolved = true;
                ret.SolvedDate = DateTime.Parse(x[4]);
            }
            return ret;


        }


    }
}