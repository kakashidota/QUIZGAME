using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZGAME.Models
{
    public class Quiz
    {
        public IEnumerable<Question> Questions { get; set; }
        
        public string Title {  get; set; }

        public Quiz(string _)
        {
            //_questions = new List<Question>();
        }

        public Quiz()
        {
            //_questions = new List<Question>();
        }

        public Question GetRandomQuestion()
        {
            throw new NotImplementedException("A random Question needs to be returned here!");
        }

        public void AddQuestion(string statement, int correctAnswer, params string[] answers)
        {
            throw new NotImplementedException("Question need to be instantiated and added to list of questions here!");
        }

        public void RemoveQuestion(int index)
        {
            throw new NotImplementedException("Question at requested index need to be removed here!");
        }
    }
}
