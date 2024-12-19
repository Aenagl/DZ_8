using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASKS
{
    internal class Project
    {
        public string Description { get; set; }
        public DateTime DeadLine { get; set; }
        public Person Client { get; set; }
        public Person TeamLead { get; set; }
        public List<Task> Tasks { get; set; }
        public ProjectStatus Status { get; set; }

        public Project(string description, Person client, Person teamlead)
        {
            Description = description;
            Client = client;
            TeamLead = teamlead;
            Tasks = new List<Task>();
            Status = ProjectStatus.Draft;
        }
        public void SetDeadLine(DateTime deadLine)
        {
            DeadLine = deadLine;
        }
        public void AddTask(string Description,Person performer)
        {
            if(Status == ProjectStatus.Draft)
            { 
                Task task = new Task();
                Tasks.Add(task);
            }
        }
        public void StartProject()
        {
            Status = ProjectStatus.Active;
        }
    }
}
