﻿namespace BallisticCalculator
{
    class GSDragTable : DragTable
    {
        public override DragTableId TableId => DragTableId.GS;

        public static int PointCount => gDataPoints.Length;

        public static DragTableDataPoint DataPoint(int index) => gDataPoints[index];


        private static DragTableDataPoint[] gDataPoints = new DragTableDataPoint[]
        {
            new DragTableDataPoint(0.00, 0.4662),
            new DragTableDataPoint(0.05, 0.4689),
            new DragTableDataPoint(0.10, 0.4717),
            new DragTableDataPoint(0.15, 0.4745),
            new DragTableDataPoint(0.20, 0.4772),
            new DragTableDataPoint(0.25, 0.4800),
            new DragTableDataPoint(0.30, 0.4827),
            new DragTableDataPoint(0.35, 0.4852),
            new DragTableDataPoint(0.40, 0.4882),
            new DragTableDataPoint(0.45, 0.4920),
            new DragTableDataPoint(0.50, 0.4970),
            new DragTableDataPoint(0.55, 0.5080),
            new DragTableDataPoint(0.60, 0.5260),
            new DragTableDataPoint(0.65, 0.5590),
            new DragTableDataPoint(0.70, 0.5920),
            new DragTableDataPoint(0.75, 0.6258),
            new DragTableDataPoint(0.80, 0.6610),
            new DragTableDataPoint(0.85, 0.6985),
            new DragTableDataPoint(0.90, 0.7370),
            new DragTableDataPoint(0.95, 0.7757),
            new DragTableDataPoint(1.0, 0.8140),
            new DragTableDataPoint(1.05, 0.8512),
            new DragTableDataPoint(1.10, 0.8870),
            new DragTableDataPoint(1.15, 0.9210),
            new DragTableDataPoint(1.20, 0.9510),
            new DragTableDataPoint(1.25, 0.9740),
            new DragTableDataPoint(1.30, 0.9910),
            new DragTableDataPoint(1.35, 0.9990),
            new DragTableDataPoint(1.40, 1.0030),
            new DragTableDataPoint(1.45, 1.0060),
            new DragTableDataPoint(1.50, 1.0080),
            new DragTableDataPoint(1.55, 1.0090),
            new DragTableDataPoint(1.60, 1.0090),
            new DragTableDataPoint(1.65, 1.0090),
            new DragTableDataPoint(1.70, 1.0090),
            new DragTableDataPoint(1.75, 1.0080),
            new DragTableDataPoint(1.80, 1.0070),
            new DragTableDataPoint(1.85, 1.0060),
            new DragTableDataPoint(1.90, 1.0040),
            new DragTableDataPoint(1.95, 1.0025),
            new DragTableDataPoint(2.00, 1.0010),
            new DragTableDataPoint(2.05, 0.9990),
            new DragTableDataPoint(2.10, 0.9970),
            new DragTableDataPoint(2.15, 0.9956),
            new DragTableDataPoint(2.20, 0.9940),
            new DragTableDataPoint(2.25, 0.9916),
            new DragTableDataPoint(2.30, 0.9890),
            new DragTableDataPoint(2.35, 0.9869),
            new DragTableDataPoint(2.40, 0.9850),
            new DragTableDataPoint(2.45, 0.9830),
            new DragTableDataPoint(2.50, 0.9810),
            new DragTableDataPoint(2.55, 0.9790),
            new DragTableDataPoint(2.60, 0.9770),
            new DragTableDataPoint(2.65, 0.9750),
            new DragTableDataPoint(2.70, 0.9730),
            new DragTableDataPoint(2.75, 0.9710),
            new DragTableDataPoint(2.80, 0.9690),
            new DragTableDataPoint(2.85, 0.9670),
            new DragTableDataPoint(2.90, 0.9650),
            new DragTableDataPoint(2.95, 0.9630),
            new DragTableDataPoint(3.00, 0.9610),
            new DragTableDataPoint(3.05, 0.9589),
            new DragTableDataPoint(3.10, 0.9570),
            new DragTableDataPoint(3.15, 0.9555),
            new DragTableDataPoint(3.20, 0.9540),
            new DragTableDataPoint(3.25, 0.9520),
            new DragTableDataPoint(3.30, 0.9500),
            new DragTableDataPoint(3.35, 0.9485),
            new DragTableDataPoint(3.40, 0.9470),
            new DragTableDataPoint(3.45, 0.9450),
            new DragTableDataPoint(3.50, 0.9430),
            new DragTableDataPoint(3.55, 0.9414),
            new DragTableDataPoint(3.60, 0.9400),
            new DragTableDataPoint(3.65, 0.9385),
            new DragTableDataPoint(3.70, 0.9370),
            new DragTableDataPoint(3.75, 0.9355),
            new DragTableDataPoint(3.80, 0.9340),
            new DragTableDataPoint(3.85, 0.9325),
            new DragTableDataPoint(3.90, 0.9310),
            new DragTableDataPoint(3.95, 0.9295),
            new DragTableDataPoint(4.00, 0.9280),

        };

        public GSDragTable() : base(gDataPoints)
        {

        }
    }

}
