// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Playground.TvOS
{
	[Register ("RootView")]
	partial class RootView
	{
		[Outlet]
		UIKit.UIButton btnChild { get; set; }

		[Outlet]
		UIKit.UIButton btnModal { get; set; }

		[Outlet]
		UIKit.UIButton btnModalAttribute { get; set; }

		[Outlet]
		UIKit.UIButton btnModalNav { get; set; }

		[Outlet]
		UIKit.UIButton btnTabs { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnChild != null) {
				btnChild.Dispose ();
				btnChild = null;
			}

			if (btnTabs != null) {
				btnTabs.Dispose ();
				btnTabs = null;
			}

			if (btnModalNav != null) {
				btnModalNav.Dispose ();
				btnModalNav = null;
			}

			if (btnModal != null) {
				btnModal.Dispose ();
				btnModal = null;
			}

			if (btnModalAttribute != null) {
				btnModalAttribute.Dispose ();
				btnModalAttribute = null;
			}
		}
	}
}
