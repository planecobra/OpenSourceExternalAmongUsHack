using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlitzAmongUsHack
{
    public partial class Tp : Form
    {
        Memory.Mem memory = new Memory.Mem();
        public Tp()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "1");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "1");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "-3.977076054");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "-8.963065147");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "-0.5172079802");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "-15.38019943");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "-5.684704781");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "-20.38776398");
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "-5.684704781");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "-13.55440712");
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "-11.60218525");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "-15.32543182");
 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "-9.997632027");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "-6.896958351");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "-3.054044485");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "-14.3635931");
        }

        private void Tp_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "5.085710526");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "-15.87962341");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "9.405842781");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "-12.17786312");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "16.8096447");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "-4.736552715");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "6.275378227");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "-3.567876816");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "8.539666176");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "0.6249289513");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "3.675093174");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "-7.480415821");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "-4.507832527");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "3.003291607");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "15.16388988");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "-0.6787188649");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "15.10914993");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "3.658082485");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "8.672992706");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "1.144504786");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "8.753035545");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "12.5608139");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "6.202031612");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "6.327486038");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "2.551826715");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "11.41436195");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "25.35578537");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "2.516243935");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "22.54683113");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "-2.184158802");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "19.21593475");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "2.474913597");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "15.45456409");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "18.75750923");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "19.58657455");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "19.00005341");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "17.66397476");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "23.25600433");
        }

        private void button53_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "17.72599983");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "-16.54052353");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "3.374999046");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "11.76109219");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "17.72599983");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "-16.54052353");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "22.09211731");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "-22.85111427");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "12.42958641");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "-22.95984459");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "10.84033394");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "-17.21226311");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "3.172129869");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "-18.63650703");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "2.564459324");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "-10.07079411");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "16.63914108");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "-2.783050776");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "20.33515167");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "-11.84211254");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "32.53540039");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "-7.90550518");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "38.07585144");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "-20.91271973");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "10.9981575");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "-17.56380844");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "2.569083214");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "-11.66883755");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "4.576008797");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "-4.302119732");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "24.08552361");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "-3.212550163");
        }
    }
}
