using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueApp.Model
{
    public class QuestionModel
    {
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category1 { get; set; }
        public string Category2 { get; set; }
        public string Category3 { get; set; }
        public string Question1 { get; set; }
        public string Question2 { get; set; }
        public string Answer { get; set; }
        public string AskedBy { get; set; }
        public bool IsActive { get; set; }
    }
}
