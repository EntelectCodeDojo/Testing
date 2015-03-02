using System.Collections;

namespace NUnitCheatSheet
{
    public class ReverseComparer : IComparer
    {
        public int Compare(object a, object b)
        {
            return ((int)b).CompareTo((int)a);
        }
    }
}