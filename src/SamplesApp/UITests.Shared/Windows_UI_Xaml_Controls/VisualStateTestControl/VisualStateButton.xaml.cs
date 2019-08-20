﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Uno.UI.Samples.Controls;
using Uno.UI.Samples.UITests.Helpers;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace UITests.Shared.Windows_UI_Xaml_Controls.VisualStateTestControl
{
	[SampleControlInfoAttribute("VisualStateTestControl", "VisualStateButton", typeof(ViewModelBase))]
	public sealed partial class VisualStateButton : UserControl
	{
		public VisualStateButton()
		{
			this.InitializeComponent();
		}
		private void Button_Click(object sender, RoutedEventArgs e)
		{

		}
	}
}
