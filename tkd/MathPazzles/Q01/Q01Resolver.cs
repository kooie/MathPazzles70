using System;

namespace Q01
{
    public static class Q01Resolver
    {
        public static int Resolve()
        {
            for (var i = 10; i < 1000; i++)
            {
                if(PalindromeValidator.Validate(i.ToString())
                    && PalindromeValidator.Validate(Convert.ToString(i, 2))
                    && PalindromeValidator.Validate(Convert.ToString(i, 8)))
                {
                    return i;
                }
            }
            throw new Exception("Not Resolve");
        }
    }
}