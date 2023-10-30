using QUIZGAME.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QUIZGAME
{
    public partial class CategoriesView : Window
    {
        public Quiz selectedQuiz { get; set; }
        public CategoriesView()
        {
            InitializeComponent();
        }

        private void SportQuizButton_Click(object sender, RoutedEventArgs e)
        {   
            List<Question> sportQuestion = selectedQuiz.Questions.Where(q => q.Category == "Sport").ToList();

            StartView startSport = new StartView();
            startSport.questions = sportQuestion;
            startSport.Show();
            Close();
        }

        private void MusicQuizButton_Click(object sender, RoutedEventArgs e)
        {
            List<Question> musicQuestion = selectedQuiz.Questions.Where(q => q.Category == "Music").ToList();
            
            StartView startMusic = new StartView();
            startMusic.questions = musicQuestion;
            startMusic.Show();
            Close();
        }

        private void CreateAQuizButton_Click(object sender, RoutedEventArgs e)
        {
            EditQuizView editQuiz = new EditQuizView();
            editQuiz.Show();
            this.Close();
        }
    }
}
