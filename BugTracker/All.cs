using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace BugTracker
{
    public class All
    {
        public List<Bug> BugArray;
        public List<Task> TaskArray;
        public All()
        {
            BugArray = new List<Bug>();
            TaskArray = new List<Task>();
        }
        public void MergeBugs(List<Bug> list)
        {
            foreach(Bug i in list)
            {
                BugArray.Add(i);
            }
        }
        public void MergeTasks(List<Task> list)
        {
            foreach (Task i in list)
            {
                TaskArray.Add(i);
            }
        }
        public void AddBug(Bug bug)
        {
            BugArray.Add(bug);
        }
        public void AddTask(Task task)
        {
            TaskArray.Add(task);
        }
        public void Wipe()
        {
            BugArray = new List<Bug>();
            TaskArray = new List<Task>();
        }

        public override string ToString()
        {
            string output = "";
            foreach (Bug item in BugArray)
            {
                output += item.ToString();
            }
            output += '\x01';
            foreach (Task item in TaskArray)
            {
                output += item.ToString();
            }
            return output;
        }

    }
}
