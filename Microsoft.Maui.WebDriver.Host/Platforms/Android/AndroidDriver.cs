﻿using System;
using System.Collections.Generic;

namespace Microsoft.Maui.WebDriver.Host
{
	// All the code in this file is only included on Android.
	public class AndroidDriver : PlatformDriverBase
	{
		public override IEnumerable<IPlatformElement> Views
		{
			get
			{
				var rootView = AppBuilderExtensions.CurrentActivity.Window?.DecorView?.RootView ??
					AppBuilderExtensions.CurrentActivity.FindViewById(Android.Resource.Id.Content)?.RootView ??
					AppBuilderExtensions.CurrentActivity.Window?.DecorView?.FindViewById(Android.Resource.Id.Content);

				if (rootView is not null)
					yield return new AndroidElement(rootView);
			}
		}
	}
}