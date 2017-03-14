using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace ratings.iOS
{
	public partial class PlayersViewController : UITableViewController
	{
		public List<Player> Players;
		public PlayersViewController(IntPtr handle) : base(handle)
		{

		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			Players = PlayerRepository.GetPlayers();
			//TableView.RegisterClassForCellReuse(UITableViewCellStyle.Subtitle , "PlayerCell");
			TableView.Source = new PlayersDataSource(this);
		}

		public class PlayersDataSource : UITableViewSource
		{
			PlayersViewController controller;
			public PlayersDataSource(PlayersViewController controller)
			{
				this.controller = controller;
			}

			public override nint NumberOfSections(UITableView tableView)
			{
				return 1;
			}
			public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
			{
				var cell = tableView.DequeueReusableCell("CustomCell") as CustomCell;
				Player player = controller.Players[indexPath.Row] as Player;
				cell.UpdateCell(player.Name, player.Game, imageForRating(player.Rating));
				return cell;
			}

			public override nint RowsInSection(UITableView tableview, nint section)
			{
				return controller.Players.Count;
			}

			public UIImage imageForRating(int rating)
			{
				string imageName = $"Images/{rating}Stars";
				return new UIImage(imageName);
			}
		}

		//[Action ("UnwindToPlayerDetail")]
		//public void cancelToPlayersViewController(UIStoryboardSegue seque) 
		//{
			
		//}

		//[Action ("Save player detail")]
		//public void savePlayerDetail(UIStoryboardSegue seque) 
		//{
			
		//}
	}
}