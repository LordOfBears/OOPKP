using System;
using System.Collections.Generic;
using System.Linq;

namespace PlaningTasks
{
    internal class TaskHandler
    {
        public static List<Task> FindTasksByDate(List<Task> list, DateTime deadLine)
        {
            var output = list.Where(x => x.GetDeadLine() == deadLine).ToList();
            return output;
        }
        public static int FindIndexTask(List<Task> list, string name, string description)
        {
            int index = 0;
            foreach (var item in list)
            {
                if ((item.GetName() == name) && (item.GetDescription() == description))
                {
                    return index;
                }
                index++;
            }
            return -1;
        }
        public static List<Task> SortTasksByDate(List<Task> list)
        {
            int n = list.Count();
            for(int i = 0; i < n; i++)
            {
                for(int j = i; j < n; j++)
                {
                    if (list[i].GetDeadLine().CompareTo(list[j].GetDeadLine()) > 0)
                    {
                        string tempTaskName = list[j].GetName();
                        string tempTaskDescription = list[j].GetDescription();
                        DateTime tempDeadLine = list[j].GetDeadLine();

                        list[j].SetName(list[i].GetName());
                        list[i].SetName(tempTaskName);

                        list[j].SetDescription(list[i].GetDescription());
                        list[i].SetDescription(tempTaskDescription);

                        list[j].SetDeadLine(list[i].GetDeadLine());
                        list[i].SetDeadLine(tempDeadLine);
                    }
                }
            }
            return list;
        }
    }
}