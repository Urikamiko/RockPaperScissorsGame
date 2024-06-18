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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RockPaperScissorsGame
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RPSGame game;
        public MainWindow()
        {
            InitializeComponent();
            game = new RPSGame();
        }

        private void StoneButton_Click(object sender, RoutedEventArgs e)
        {
            int result = game.Run(StoneButton.Content.ToString());
            UserChoiceLabel.Content = StoneButton.Content.ToString();
            CompChoiceLabel.Content = game.compChoice;
            CheckResult(result);
        }

        private void ScissorsButton_Click(object sender, RoutedEventArgs e)
        {
            int result = game.Run(ScissorsButton.Content.ToString());
            UserChoiceLabel.Content = ScissorsButton.Content.ToString();
            CompChoiceLabel.Content = game.compChoice;
            CheckResult(result);
        }

        private void PaperButton_Click(object sender, RoutedEventArgs e)
        {
            int result = game.Run(PaperButton.Content.ToString());
            UserChoiceLabel.Content = PaperButton.Content.ToString();
            CompChoiceLabel.Content = game.compChoice;
            CheckResult(result);
        }
        private void CheckResult(int result)
        {
            switch (result)
            {
                case -1:
                    ResultLabel.Content = "Вы проиграли!";
                    break;
                case 0:
                    ResultLabel.Content = "Ничья!";
                    break;
                case 1:
                    ResultLabel.Content = "Вы победили!";
                    break;
                default:
                    ResultLabel.Content = "";
                    break;
            }
        }
    }
}
