using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManagementTool.Framework.Models.Task
{
    public class TaskVM
    {
        public string Title { get; set; }
        public int Status { get; set; }
        public string Desription { get; set; }
        public string DueDate { get; set; }
    }
}
