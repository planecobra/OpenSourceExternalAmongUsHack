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


    public partial class Free : Form
    {
        Memory.Mem memory = new Memory.Mem();
        public Free()
        {
            InitializeComponent();
        }
     
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Login f2 = new Login();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //speed

            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("GameAssembly.dll+013EF894,5C,0,0,18,4C,4,14", "float", textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //sight crewmate
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("GameAssembly.dll+01468910,5C,4,18", "float", textBox2.Text);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //imposter sight
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("GameAssembly.dll+01468910,5C,4,1C", "Float", textBox6.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "1");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Y Value for Plyr 1 
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", textBox5.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //X Value for Plyr 1 
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", textBox3.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCowNM-mSxEcZJSHMtI4nNoQ?view_as=subscriber");

        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/C2KNGW9");
        }

        private void Free_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        Point lastPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            //noclip
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5c,0", "byte", "1");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //clip
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5c,0", "byte", "2");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //imposter
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("GameAssembly.dll+01468910,5C,0,34,28", "int", "1");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Crewmate

            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("GameAssembly.dll+01468910,5C,0,34,28", "int", "0");
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("GameAssembly.dll+01468910,5c,0,2c", "float", textBox7.Text);
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            
            
            
            
        }

        private void button4_Click_3(object sender, EventArgs e)
        {
            
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            
        }

       

        private void button17_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button10_Click_2(object sender, EventArgs e)
        {
            
        }

        private void Long_Click_3(object sender, EventArgs e)
        { //Kill distance long

            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("GameAssembly.dll+01468910,05c,04,40", "int", "2");
        }

        private void Short_Click_1(object sender, EventArgs e)
        {
            //Kill distance short

            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("GameAssembly.dll+01468910,05c,04,40", "int", "1");
        }

        private void button10_Click_3(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("GameAssembly.dll+01468910,5c,0,48", "int", "10");
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button17_Click_2(object sender, EventArgs e)
        {
            //Kill Cooldown

            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("GameAssembly.dll+01468910,44,0,5C", "Float", textBox4.Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {//Hats
        

        }

        private void button4_Click_4(object sender, EventArgs e)
        {



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
                memory.WriteMemory("GameAssembly.dll+01468910,05c,04,40", "int", "2");
                return;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("GameAssembly.dll+01468910,05c,04,40", "int", "1");
        }

        private void button4_Click_5(object sender, EventArgs e)
        {
           
            Tp f2 = new Tp();
            f2.Show();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
                memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5c,0", "byte", "1");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
                memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5c,0", "byte", "2");
            }
        }
    }
}


