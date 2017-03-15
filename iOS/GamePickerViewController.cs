using Foundation;
using System;
using UIKit;

namespace ratings.iOS
{
    public partial class GamePickerViewController : UITableViewController
    {
        public string[] games = {
            "Angry Birds",
            "Chess",
            "Russian Roulette",
            "Spin The Bottle",
            "Texas Hold'em Poker",
            "Tic-Tac-Toe"

        };

        public string selectedGame;
        public int selectedGameIndex;       
        
        public GamePickerViewController (IntPtr handle) : base (handle)
        {

        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            
            var cell = tableView.CellAt(indexPath);                        
            cell.Accessory = UITableViewCellAccessory.Checkmark;
            selectedGameIndex = indexPath.Row;                  
            selectedGame = games[indexPath.Row];                      
        }

        public override void RowDeselected(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.CellAt(indexPath);
            cell.Accessory = UITableViewCellAccessory.None;
        }


        public override nint NumberOfSections(UITableView tableView)
        {
            return 1;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return games.Length;
        }
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("GameCell", indexPath);
            cell.TextLabel.Text = games[indexPath.Row];           
            //if(selectedGameIndex == indexPath.Row)
            //{
            //    cell.Accessory = UITableViewCellAccessory.Checkmark;
            //} else
            //{
            //    cell.Accessory = UITableViewCellAccessory.None;
            //}
            return cell;
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier == "SaveSelectedGame")
            {
                var cell = sender as UITableViewCell;
                if (cell != null)
                {
                    var indexPath = TableView.IndexPathForCell(cell);
                    selectedGame = games[indexPath.Row];
                }
            }
        }


    }
}