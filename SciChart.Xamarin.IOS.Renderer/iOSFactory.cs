﻿using SciChart.Xamarin.iOS.Renderer;
using SciChart.Xamarin.Views.Core.Common;
using Xamarin.Forms;

[assembly: Dependency(typeof(iOSFactory))]
namespace SciChart.Xamarin.iOS.Renderer
{
    public partial class iOSFactory : INativeSciChartObjectFactory
    {
    }
}