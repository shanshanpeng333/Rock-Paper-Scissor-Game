using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Rock_Paper_Scissor_Game
{
    public enum RPSGame
    {
        Rock,
        Paper,
        Scissor,
        Lizard,
        Spock
    }

    class VM : INotifyPropertyChanged
    {
        #region variables
        RPSGame computerChoice;

        #endregion

        #region Properties
        //property for image of Computer's Choice
        private string displayImage = "";
        public string DisplayImage
        {
            get { return displayImage; }
            set { displayImage = value; NotifyChanged(); }
        }

        //property for output label
        private string displayResult = "";
        public string DisplayResult
        {
            get { return displayResult; }
            set { displayResult = value; NotifyChanged(); }
        }
        #endregion

        #region Logic
        //Get a random number from 1 to 5
        public int GenerateComputerChoice()
        {
            //use enum to generate random choice
            Random r = new Random();
            int rand = r.Next(1, 6);
            return rand;
        }
        //Display computer's choice
        public RPSGame DisplayComputerChoice()
        {
            int rand = GenerateComputerChoice();
            switch (rand)
            {
                case (1):
                    DisplayImage = "Rock.bmp";
                    computerChoice = RPSGame.Rock;
                    break;
                case (2):
                    DisplayImage = "Paper.bmp";
                    computerChoice = RPSGame.Paper;
                    break;
                case (3):
                    DisplayImage = "Scissors.bmp";
                    computerChoice = RPSGame.Scissor;
                    break;
                case (4):
                    DisplayImage = "Lizard.png";
                    computerChoice = RPSGame.Lizard;
                    break;
                case (5):
                    DisplayImage = "Spock.jpg";
                    computerChoice = RPSGame.Spock;
                    break;
            }
            return computerChoice;
        }
        //Compare computer and people's choice and get result
        public void CompareandDisplayChoice(RPSGame computerchoice, RPSGame peoplechoice)
        {
            if (computerchoice == peoplechoice)
            {
                DisplayResult = $"You are same.Try it again.";
            }
            else if (computerchoice == RPSGame.Rock && peoplechoice == RPSGame.Paper || 
                computerchoice == RPSGame.Paper && peoplechoice == RPSGame.Scissor || 
                computerchoice == RPSGame.Scissor && peoplechoice == RPSGame.Rock || 
                computerchoice == RPSGame.Paper && peoplechoice == RPSGame.Lizard || 
                computerchoice == RPSGame.Spock && peoplechoice == RPSGame.Lizard || 
                computerchoice == RPSGame.Scissor && peoplechoice == RPSGame.Spock || 
                computerchoice == RPSGame.Rock && peoplechoice == RPSGame.Spock || 
                computerchoice == RPSGame.Spock && peoplechoice == RPSGame.Paper || 
                computerchoice == RPSGame.Lizard && peoplechoice == RPSGame.Rock)
            {
                DisplayResult = $"You win. Good job! Try it again.";
            }
            else
            {
                DisplayResult = $"Computer win. Don't worry. Try it again.";
            }
            return;
        }
        #endregion

        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}
