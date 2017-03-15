// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace FristXamairniOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lablel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton OKButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField textentry { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lablel != null) {
                lablel.Dispose ();
                lablel = null;
            }

            if (OKButton != null) {
                OKButton.Dispose ();
                OKButton = null;
            }

            if (textentry != null) {
                textentry.Dispose ();
                textentry = null;
            }
        }
    }
}