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

namespace UITests.Shared.Windows_UI_Xaml_Controls.ScrollViewerTests
{
	[SampleControlInfoAttribute("ScrollViewer", "ScrollViewer_HorizontalScrollMode", typeof(ViewModelBase))]
	public sealed partial class ScrollViewer_HorizontalScrollMode : UserControl
	{
		private int pressCount;
		public ScrollViewer_HorizontalScrollMode()
		{
			this.InitializeComponent();
			MyButton.Click += MyButton_OnClick;
		}

		private void MyButton_OnClick(object sender, RoutedEventArgs e)
		{
			MyTextBlock.Text = $"Button pressed {++pressCount} times";
		}
	}
}
