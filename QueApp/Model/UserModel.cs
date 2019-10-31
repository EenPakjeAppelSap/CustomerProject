using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueApp.Model
{
    public class UserModel
    {
        public bool LoginSucceeded { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int QuestionCount { get; set; }
        public int AnsweredQuestions { get; set; }
        public int StudentPoints { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
    }
}
