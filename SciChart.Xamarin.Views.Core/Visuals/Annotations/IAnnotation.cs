﻿using System;
using SciChart.Xamarin.Views.Core.Common;
using SciChart.Xamarin.Views.Core.Generation;
using Xamarin.Forms;

namespace SciChart.Xamarin.Views.Visuals.Annotations
{
    [InjectAndroidContext]
    [AbstractClassDefinition]
    [ClassDeclaration("AnnotationBase", "SCIAnnotationBase", typeof(View))]
    [XamarinFormsWrapperDefinition("AnnotationBase")]
    public interface IAnnotation : INativeSciChartObjectWrapper
    {        
        [BindablePropertyDefinition()]
        [NativePropertyConverterDeclaration(nativeProperty: "X1Value")]

        IComparable X1 { get; set; }
        [BindablePropertyDefinition()]
        [NativePropertyConverterDeclaration(nativeProperty: "X2Value")]
        IComparable X2 { get; set; }
        [BindablePropertyDefinition()]
        [NativePropertyConverterDeclaration(nativeProperty: "Y1Value")]
        IComparable Y1 { get; set; }
        [BindablePropertyDefinition()]
        [NativePropertyConverterDeclaration(nativeProperty: "Y2Value")]
        IComparable Y2 { get; set; }
    }
}