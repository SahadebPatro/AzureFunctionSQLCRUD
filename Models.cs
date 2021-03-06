using System;
using System.Collections.Generic;
using System.Text;

namespace SampleFunctionApp
{
   
        public class TaskModel
        {
            public int Id { get; set; }
            public string CreatedOn { get; set; }
            public string Description { get; set; }
            public string IsDone { get; set; }
        }
        public class CreateTaskModel
        {
            public int Id { get; set; }
            public string CreatedOn { get; set; }
            public string Description { get; set; }
            public string IsDone { get; set; }
    }
        public class UpdateTaskModel
        {
            public string Description { get; set; }
            public string IsDone { get; set; }
        }
   
}
