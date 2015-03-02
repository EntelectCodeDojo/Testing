using System.Collections.Generic;

namespace NUnitCheatSheet
{
    public class WhoCaresComparer : IEqualityComparer<int>
    {
        public bool Equals(int b1, int b2)
        {
            return true;
        }

        public int GetHashCode(int aNumber)
        {
            return aNumber.GetHashCode();
        }
    }
}