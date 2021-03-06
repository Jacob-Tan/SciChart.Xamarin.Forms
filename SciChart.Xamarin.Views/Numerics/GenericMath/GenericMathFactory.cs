﻿using System;
using System.Collections.Generic;

namespace SciChart.Xamarin.Views.Numerics.GenericMath
{
    internal static class GenericMathFactory
    {
        private static readonly FloatMath floatMath = new FloatMath();
        private static readonly DoubleMath doubleMath = new DoubleMath();
        private static readonly Int32Math int32Math = new Int32Math();
        private static readonly Int64Math int64Math = new Int64Math();
        private static readonly DateTimeMath dateTimeMath = new DateTimeMath();
        private static readonly TimeSpanMath timeSpanMath = new TimeSpanMath();
        private static readonly DecimalMath decimalMath = new DecimalMath();
        private static readonly UShortMath uShortMath = new UShortMath();
        private static readonly ShortMath shortMath = new ShortMath();
        private static readonly Uint32Math uint32Math = new Uint32Math();
        private static readonly Uint64Math uint64Math = new Uint64Math();
        private static readonly SbyteMath sbyteMath = new SbyteMath();
        private static readonly ByteMath byteMath = new ByteMath();

        private static readonly IDictionary<Type, object> mathMap = new Dictionary<Type, object>()
            {
                { typeof(double), doubleMath}, 
                { typeof(DateTime), dateTimeMath}, 
                { typeof(float), floatMath}, 
                { typeof(int), int32Math}, 
                { typeof(long), int64Math}, 
                { typeof(decimal), decimalMath}, 
                { typeof(TimeSpan), timeSpanMath}, 
                { typeof(short), shortMath}, 
                { typeof(ushort), uShortMath}, 
                { typeof(sbyte), sbyteMath}, 
                { typeof(ulong), uint64Math}, 
                { typeof(uint), uint32Math}, 
                { typeof(byte), byteMath}, 
            };

       
        internal static IMath<T> New<T>()
        {
            var math = TryNew<T>();
            if(math != null)
            {
                return math;
            }

            throw new NotSupportedException("GenericMath does not support Type " + typeof(T));
        }

        internal static IMath<T> TryNew<T>()
        {
            var type = typeof(T);
            object math;
            if (mathMap.TryGetValue(type, out math))
            {
                return (IMath<T>)math;
            }

            return null;
        }
    }
}
