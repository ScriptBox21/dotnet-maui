﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Maui.Controls.CustomAttributes;
using Microsoft.Maui.Controls.Internals;

namespace Microsoft.Maui.Controls.Compatibility.ControlGallery.Issues
{

#if APP
#if UITEST
	[NUnit.Framework.Category(Compatibility.UITests.UITestCategories.Github5000)]
#endif
	[Preserve(AllMembers = true)]
	[Issue(IssueTracker.Github, 1653, "ScrollView exceeding bounds", PlatformAffected.Android | PlatformAffected.iOS | PlatformAffected.WinPhone)]
	public partial class Issue1653 : ContentPage
	{
		public Issue1653()
		{
			InitializeComponent();

			for (int i = 0; i < 40; i++)
				addonGroupStack.Children.Add(new Label { Text = "Testing 123" });
		}
	}
#endif
}
