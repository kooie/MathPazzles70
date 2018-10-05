using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            // intの最大値までループして調べる
            for (int i = 10; i < int.MaxValue; i++)
            {
                if (isKaibun(i, 2) && isKaibun(i, 8) && isKaibun(i, 10))
                //if (isKaibun(i, 8) && isKaibun(i, 10))
                {
                    Console.WriteLine(string.Format("10:{0}  2:{1}  8:{2}", Convert.ToString(i, 10), Convert.ToString(i, 2), Convert.ToString(i,8)));
                }
            }
            sw.Stop();
            Console.WriteLine("End:" + sw.ToString() );
        }

        private bool isKaibun(int value,int baseNum)
        {
            return Convert.ToString(value, baseNum) == new string(Convert.ToString(value, baseNum).Reverse().ToArray());
        }
    }
}
