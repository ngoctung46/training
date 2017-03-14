// WARNING
// This file has been generated automatically by Xamarin Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>
#import <ratings/ratings.h>

#import "PlayerDetailsViewController.h"

@interface PlayerDetailsViewController : UITableViewController {
	PlayerDetailsViewController *_dataSource;
	PlayerDetailsViewController *_delegate;
	UITextField *_nameTextField;
}

@property (nonatomic, retain) IBOutlet PlayerDetailsViewController *dataSource;

@property (nonatomic, retain) IBOutlet PlayerDetailsViewController *delegate;

@property (nonatomic, retain) IBOutlet UITextField *nameTextField;

@end
