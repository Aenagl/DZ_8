using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASKS
{
    internal class Task
    {
        public string Description { get; set; }
        public DateTime DeadLine { get; set; }
        public Person Initiator { get; set; }
        public Person Performer { get; set; }
        public List<Report> Reports { get; set; }
        public TaskStatus Status { get; set; }
    }
}
