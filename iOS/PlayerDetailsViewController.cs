using Foundation;
using System;
using UIKit;

namespace ratings.iOS
{
    public partial class PlayerDetailsViewController : UITableViewController
    {
        public Player player;
        public string game = "Chess";
        public PlayerDetailsViewController (IntPtr handle) : base (handle)
        {
            player = new Player();           
        }
        public override void ViewDidLoad()
        {
            detailLabel.Text = game;
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);
            var playersViewController = segue.DestinationViewController as PlayersViewController;            
            if (playersViewController != null)
            {
                var player = new Player
                {
                    Name = nameTextField.Text,
                    Game = game,
                    Rating = 1                   
                };

                this.player = player;           
            }

           
        }

        [Action("SaveSelectedGame:")]
        public void SaveSelectedGame(UIStoryboardSegue seque)
        {
            Console.WriteLine("SaveSelectedGame SaveSelectedGame");
            var gamePickerViewController = seque.SourceViewController as GamePickerViewController;
            game = gamePickerViewController.selectedGame;
            detailLabel.Text = game;
        }






    }
}