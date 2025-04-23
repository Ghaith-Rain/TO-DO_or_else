using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO_DO_or_else.Domain
{
    public class Objective
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }

        public List<TaskItem> Tasks { get; set; } = new();
    }

}
