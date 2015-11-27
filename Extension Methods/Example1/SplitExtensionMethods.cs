using System;

namespace Extension_Methods.Example1
{
    public static class SplitExtensionMethods
    {
        public static string[] SplitByComma(this String s)
        {
            return s.Split(',');
        }
    }
}
