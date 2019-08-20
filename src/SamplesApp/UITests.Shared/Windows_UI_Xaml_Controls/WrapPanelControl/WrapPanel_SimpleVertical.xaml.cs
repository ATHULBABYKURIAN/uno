﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using SamplesApp.Windows_UI_Xaml_Controls.Models;
using Uno.UI.Samples.Controls;
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

namespace UITests.Shared.Windows_UI_Xaml_Controls.WrapPanelControl
{
#if HAS_UMBRELLA_UI
	[SampleControlInfoAttribute("WrapPanelControl", "WrapPanel_SimpleVertical", typeof(ListViewViewModel))]
#endif
	public sealed partial class WrapPanel_SimpleVertical : UserControl
	{
		public WrapPanel_SimpleVertical()
		{
			this.InitializeComponent();
		}
	}
}
