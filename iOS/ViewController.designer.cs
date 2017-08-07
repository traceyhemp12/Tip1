// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace TipCalculatorIOS.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        UIKit.UIButton Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnCalc { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblBillLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblTip { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblTipLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblTotalAmt { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtCost { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtTip { get; set; }

        [Action ("BtnCalc_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnCalc_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnCalc != null) {
                btnCalc.Dispose ();
                btnCalc = null;
            }

            if (lblBillLabel != null) {
                lblBillLabel.Dispose ();
                lblBillLabel = null;
            }

            if (lblTip != null) {
                lblTip.Dispose ();
                lblTip = null;
            }

            if (lblTipLabel != null) {
                lblTipLabel.Dispose ();
                lblTipLabel = null;
            }

            if (lblTotalAmt != null) {
                lblTotalAmt.Dispose ();
                lblTotalAmt = null;
            }

            if (txtCost != null) {
                txtCost.Dispose ();
                txtCost = null;
            }

            if (txtTip != null) {
                txtTip.Dispose ();
                txtTip = null;
            }
        }
    }
}