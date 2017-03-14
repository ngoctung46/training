using Foundation;
using System;
using UIKit;

namespace ratings.iOS
{
    public partial class CustomCell : UITableViewCell
    {

		public CustomCell(IntPtr handle) : base(handle){
			
		}

		public void UpdateCell(string name, string game, UIImage image) 
		{
			NameLabel.Text = name;
			GameLabel.Text = game;
			RatingImageView.Image = image;
		}

	}
}