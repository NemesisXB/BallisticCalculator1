﻿namespace BallisticCalculator
{
    class G2DragTable : DragTable
    {
        public static int PointCount => gDataPoints.Length;

        public override DragTableId TableId => DragTableId.G2;

        public static DragTableDataPoint DataPoint(int index) => gDataPoints[index];


        private static DragTableDataPoint[] gDataPoints = new DragTableDataPoint[]
        {
            new DragTableDataPoint(0.00, 0.2303),
            new DragTableDataPoint(0.05, 0.2298),
            new DragTableDataPoint(0.10, 0.2287),
            new DragTableDataPoint(0.15, 0.2271),
            new DragTableDataPoint(0.20, 0.2251),
            new DragTableDataPoint(0.25, 0.2227),
            new DragTableDataPoint(0.30, 0.2196),
            new DragTableDataPoint(0.35, 0.2156),
            new DragTableDataPoint(0.40, 0.2107),
            new DragTableDataPoint(0.45, 0.2048),
            new DragTableDataPoint(0.50, 0.1980),
            new DragTableDataPoint(0.55, 0.1905),
            new DragTableDataPoint(0.60, 0.1828),
            new DragTableDataPoint(0.65, 0.1758),
            new DragTableDataPoint(0.70, 0.1702),
            new DragTableDataPoint(0.75, 0.1669),
            new DragTableDataPoint(0.775, 0.1664),
            new DragTableDataPoint(0.80, 0.1667),
            new DragTableDataPoint(0.825, 0.1682),
            new DragTableDataPoint(0.85, 0.1711),
            new DragTableDataPoint(0.875, 0.1761),
            new DragTableDataPoint(0.90, 0.1831),
            new DragTableDataPoint(0.925, 0.2004),
            new DragTableDataPoint(0.95, 0.2589),
            new DragTableDataPoint(0.975, 0.3492),
            new DragTableDataPoint(1.0, 0.3983),
            new DragTableDataPoint(1.025, 0.4075),
            new DragTableDataPoint(1.05, 0.4103),
            new DragTableDataPoint(1.075, 0.4114),
            new DragTableDataPoint(1.10, 0.4106),
            new DragTableDataPoint(1.125, 0.4089),
            new DragTableDataPoint(1.15, 0.4068),
            new DragTableDataPoint(1.175, 0.4046),
            new DragTableDataPoint(1.20, 0.4021),
            new DragTableDataPoint(1.25, 0.3966),
            new DragTableDataPoint(1.30, 0.3904),
            new DragTableDataPoint(1.35, 0.3835),
            new DragTableDataPoint(1.40, 0.3759),
            new DragTableDataPoint(1.45, 0.3678),
            new DragTableDataPoint(1.50, 0.3594),
            new DragTableDataPoint(1.55, 0.3512),
            new DragTableDataPoint(1.60, 0.3432),
            new DragTableDataPoint(1.65, 0.3356),
            new DragTableDataPoint(1.70, 0.3282),
            new DragTableDataPoint(1.75, 0.3213),
            new DragTableDataPoint(1.80, 0.3149),
            new DragTableDataPoint(1.85, 0.3089),
            new DragTableDataPoint(1.90, 0.3033),
            new DragTableDataPoint(1.95, 0.2982),
            new DragTableDataPoint(2.00, 0.2933),
            new DragTableDataPoint(2.05, 0.2889),
            new DragTableDataPoint(2.10, 0.2846),
            new DragTableDataPoint(2.15, 0.2806),
            new DragTableDataPoint(2.20, 0.2768),
            new DragTableDataPoint(2.25, 0.2731),
            new DragTableDataPoint(2.30, 0.2696),
            new DragTableDataPoint(2.35, 0.2663),
            new DragTableDataPoint(2.40, 0.2632),
            new DragTableDataPoint(2.45, 0.2602),
            new DragTableDataPoint(2.50, 0.2572),
            new DragTableDataPoint(2.55, 0.2543),
            new DragTableDataPoint(2.60, 0.2515),
            new DragTableDataPoint(2.65, 0.2487),
            new DragTableDataPoint(2.70, 0.2460),
            new DragTableDataPoint(2.75, 0.2433),
            new DragTableDataPoint(2.80, 0.2408),
            new DragTableDataPoint(2.85, 0.2382),
            new DragTableDataPoint(2.90, 0.2357),
            new DragTableDataPoint(2.95, 0.2333),
            new DragTableDataPoint(3.00, 0.2309),
            new DragTableDataPoint(3.10, 0.2262),
            new DragTableDataPoint(3.20, 0.2217),
            new DragTableDataPoint(3.30, 0.2173),
            new DragTableDataPoint(3.40, 0.2132),
            new DragTableDataPoint(3.50, 0.2091),
            new DragTableDataPoint(3.60, 0.2052),
            new DragTableDataPoint(3.70, 0.2014),
            new DragTableDataPoint(3.80, 0.1978),
            new DragTableDataPoint(3.90, 0.1944),
            new DragTableDataPoint(4.00, 0.1912),
            new DragTableDataPoint(4.20, 0.1851),
            new DragTableDataPoint(4.40, 0.1794),
            new DragTableDataPoint(4.60, 0.1741),
            new DragTableDataPoint(4.80, 0.1693),
            new DragTableDataPoint(5.00, 0.1648),
        };

        public G2DragTable() : base(gDataPoints)
        {

        }
    }

}
