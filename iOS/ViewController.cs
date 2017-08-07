using System;

using UIKit;

namespace TipCalculatorIOS.iOS
{
	public partial class ViewController : UIViewController
	{

		float totalCost;
		float tipAmt;
		//int count = 1;

		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();


		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.		
		}


		partial void BtnCalc_TouchUpInside(UIButton sender)
		{
			//throw new NotImplementedException();
			callButton();

		}


		void callButton()
		{
			// Perform any additional setup after loading the view, typically from a nib.
			btnCalc.AccessibilityIdentifier = "calculateButton";
			btnCalc.TouchUpInside += delegate
			{
				//var title = string.Format("{0} clicks!", count++);		
				//Button.SetTitle(title, UIControlState.Normal);
				calculateCost();

			};

		}

		void calculateCost()
		{
			float cost = float.Parse(txtCost.Text);
			float tip = float.Parse(txtTip.Text);


			tip = tip / 100;
			tip = tip*cost;

			tipAmt = tip;
			totalCost = tip + cost;

			printTotalCostandTip();

		}

		void printTotalCostandTip()
		{
			lblTotalAmt.Text = totalCost.ToString();
			lblTip.Text = tipAmt.ToString();
		}

	}
}
