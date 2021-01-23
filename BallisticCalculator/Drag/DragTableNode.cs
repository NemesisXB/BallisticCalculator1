﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BallisticCalculator
{
    /// <summary>
    /// The range table node
    /// </summary>
    public class DragTableNode
    {
        /// <summary>
        /// The velocity range start
        /// </summary>
        public double Mach { get; }

           /// <summary>
        /// The basic drag coefficient value
        /// </summary>
        public double DragCoefficient { get; }

        private double A { get; }
        private double B { get; }
        private double C { get; }

        public DragTableNode Previous { get; private set;}
        public DragTableNode Next { get; private set; }


        internal DragTableNode(double range, double value, double a, double b, double c, DragTableNode previous)
        {
            Mach = range;
            DragCoefficient = value;
            A = a;
            B = b;
            C = c;

            Previous = previous;
            Next = null;
            if (previous != null)
                previous.Next = this;
        }

        /// <summary>
        /// Calculate drag using drag approximation curve for the specified range
        /// </summary>
        /// <param name="mach"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double CalculateDrag(double mach)
        {
            return C + mach * (B + A * mach);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool In(double mach)
        {
            if (mach < Mach)
                return false;
            if (Next == null)
                return true;
            return mach < Next.Mach;
        }
    }
}
