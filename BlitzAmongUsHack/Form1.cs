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
    public partial class Form1 : Form
    {

        Memory.Mem memory = new Memory.Mem();
        public Form1()
        {
            InitializeComponent();

        }
   

        private void Form1_StyleChanged(EventArgs e, object sender)
        {

        }
        private void Form1_Load(EventArgs e, object sender)
        {

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

        private void button2_Click_1(object sender, EventArgs e)
        {
            //color
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("GameAssembly.dll+014688CC,5C,18", "float", textBox3.Text);
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            //speed

            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("GameAssembly.dll+013EF894,5C,0,0,18,4C,4,14", "float", textBox1.Text);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            //sight crewmate
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("GameAssembly.dll+01468910,5C,4,18", "float", textBox2.Text);
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            //force imposter
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("GameAssembly.dll+01468910,5C,0,34,28", "Float", textBox3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //report distance button 
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("GameAssembly.dll+01468910,5C,04,44", "Float", textBox4.Text);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //force imposter

            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("GameAssembly.dll+01468910,5C,0,34,28", "Float", textBox3.Text);
        }

       

        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        
        private void button2_Click_3(object sender, EventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,2C", "Float", "1");
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,30", "Float", "1");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,0", "byte", "1");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("UnityPlayer.dll+012A86E0,80,5C,0", "byte", "2");
        }

        

        private void button7_Click_1(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("GameAssembly.dll+01468910,5C,0,34,28", "int", "1");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("GameAssembly.dll+01468910,5C,0,34,28", "int", "0");
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/flash-mods");

        }

      
        private void button13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCowNM-mSxEcZJSHMtI4nNoQ?view_as=subscriber");
        }

       

        private void button15_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("GameAssembly.dll+00DA5A84,5C,4,1C", "Float", textBox6.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("GameAssembly.dll+00DA5A84,05C,04,40", "Float", "2");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("GameAssembly.dll+00DA5A84,05C,04,40", "Float", "1");
        }

       

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            
        }
        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
