using System.Windows;

namespace Rock_Paper_Scissor_Game
{

    /// <summary>
    /// Group 6, Assignment 6 Rock Paper Scissors Game
    /// </summary>
    public partial class MainWindow : Window
    {
        VM vm = new VM();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }

        //Get people's choice and game result when people click one button
        private void BTnRock_Click(object sender, RoutedEventArgs e)
        {
            vm.CompareandDisplayChoice(vm.DisplayComputerChoice(), RPSGame.Rock);
        }

        private void BTnPaper_Click(object sender, RoutedEventArgs e)
        {
            RPSGame peopleChoice = RPSGame.Paper;
            RPSGame computerChoice = vm.DisplayComputerChoice();
            vm.CompareandDisplayChoice(computerChoice, peopleChoice);
        }

        private void BTnScissor_Click(object sender, RoutedEventArgs e)
        {
            RPSGame peopleChoice = RPSGame.Scissor;
            RPSGame computerChoice = vm.DisplayComputerChoice();
            vm.CompareandDisplayChoice(computerChoice, peopleChoice);
        }

        private void BTnLizard_Click(object sender, RoutedEventArgs e)
        {
            RPSGame peopleChoice = RPSGame.Lizard;
            RPSGame computerChoice = vm.DisplayComputerChoice();
            vm.CompareandDisplayChoice(computerChoice, peopleChoice);
        }

        private void BTnSpock_Click(object sender, RoutedEventArgs e)
        {
            RPSGame peopleChoice = RPSGame.Spock;
            RPSGame computerChoice = vm.DisplayComputerChoice();
            vm.CompareandDisplayChoice(computerChoice, peopleChoice);

        }

        //Open a new window to show game rule when click the rule button
        private void BTnRule_Click(object sender, RoutedEventArgs e)
        {
            GameRule gr = new GameRule();
            gr.ShowDialog(); //show will open a new window everytime, but showdialog will not
        }
    }
}
