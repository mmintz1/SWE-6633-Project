﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManagementTool.Framework.Models.Project
{
    public class ProjectVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime DueDate { get; set; }
        public int Id { get; set; }
        public string Manager { get; set; }
    }
}
