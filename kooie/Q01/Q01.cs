using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q01Cs
{
    class Q01Cs
    {

        public static int getAnswer()
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            // 最初の１つを探すのではなく何個あるかしらべる
            // intの最大値までループして調べる
            for (int i = 10; i < int.MaxValue; i++)
            {
                if (isKaibun(i, 2) && isKaibun(i, 8) && isKaibun(i, 10))
                //if (isKaibun(i, 8) && isKaibun(i, 10))
                {
                    //Console.WriteLine(string.Format("10:{0}  2:{1}  8:{2}", Convert.ToString(i, 10), Convert.ToString(i, 2), Convert.ToString(i, 8)));
                    return i;
                }
            }
            sw.Stop();
            //Console.WriteLine("End:" + sw.ToString());

            return 0;
        }


        private static bool isKaibun(int value, int baseNum)
        {
            return Convert.ToString(value, baseNum) == new string(Convert.ToString(value, baseNum).Reverse().ToArray());
        }

    }
}
