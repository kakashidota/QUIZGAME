using QUIZGAME.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace QUIZGAME
{
    /// <summary> 
    /// Interaction logic for QuizView.xaml
    /// </summary>
    public partial class QuizView : Window
    {
        private int currentIndex =0;
        public string CounterQuestion {  get; set; }
        public Question CurrentQuestion { get; set; }
        public List<Question> questions {  get; set; }

        private int score = 0;
        public QuizView() 
        {
            InitializeComponent();
            ScoreText.Text = $"Score: {score}";

        }

        private void ShowQuestion()
        {

            CurrentQuestion = questions[currentIndex];
            CurrentQuestionText.Text = CurrentQuestion.Statement;
            AnswerA.Content = CurrentQuestion.Answers[0];
            AnswerB.Content = CurrentQuestion.Answers[1];
            AnswerC.Content = CurrentQuestion.Answers[2];
            AnswerD.Content = CurrentQuestion.Answers[3];
            CounterQuestion = $"Question {currentIndex + 1} of {questions.Count}";
            CounterQuestionText.Text = CounterQuestion;
            this.DataContext = CurrentQuestion;
        }

        private void AnswerButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse((sender as Button).Tag.ToString()) == CurrentQuestion.CorrectAnswers)
            {
                MessageBox.Show("Good Job!");
                currentIndex++;
                score++;
                ScoreText.Text = $"{score}";
                ShowQuestion();
                
            }
            else
            {
                MessageBox.Show("Wrong answer");
                currentIndex++;
                ShowQuestion();
            }
        }

        private void NextQuestionButton_Click(object sender, RoutedEventArgs e)
        {
            ShowQuestion();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CurrentQuestion = questions.First();
            CurrentQuestionText.Text = CurrentQuestion.Statement;
            CounterQuestion = $" Question {currentIndex + 1} of {questions.Count}";
            CounterQuestionText.Text = CounterQuestion;
            ShowQuestion();
            this.DataContext = CurrentQuestion;
        }

        private void GoBackToCategoryButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow newQuizGame = new MainWindow();
            newQuizGame.Show();
            this.Close();
        }
    }
}
