using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace QUIZGAME.Models
{
    public class Question
    {
        public string Statement { get; set; }
        public string[] Answers { get; set; }
        public int CorrectAnswers { get; set; }

        public string Category { get; set; }

    }
}
