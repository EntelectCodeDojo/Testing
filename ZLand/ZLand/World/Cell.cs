using System;
using ZLand.Actors;

namespace ZLand.World
{
    public class Cell
    {
        public int XValue { get; set; }
        public int YValue { get; set; }
        public Actor Actor { get; set; }
        public Terrain Terrain { get; set; }

        public int DistanceTo(Cell targetsCell)
        {
            var differenceOfXValuesSquared = (Math.Abs(XValue) - Math.Abs(targetsCell.XValue)) ^ 2;
            var differenceOfYValuesSquared = (Math.Abs(YValue) - Math.Abs(targetsCell.YValue)) ^ 2;
            var distance = Math.Sqrt(differenceOfXValuesSquared + differenceOfYValuesSquared);
            return (int)Math.Ceiling(distance);
        }
    }
}