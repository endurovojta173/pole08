using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pole08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] poleA = new int[10];
        int[] poleB = new int[10];
        int[] poleC = new int[10];
        private void button1_Click(object sender, EventArgs e)
        {
            GenerovatCislaDoPole(poleA, 3, 10);
            GenerovatCislaDoPole(poleB, 5, 12);
            poleC= poleA.Intersect(poleB).ToArray();
        }
        static private void GenerovatCislaDoPole(int[] pole, int minimum, int maximum)
        {
            Random rnd = new Random();
            for(int i =0;i<pole.Length;i++)
            {
                pole[i] = rnd.Next(minimum, maximum+1);
            }
        }
        private static void zobrazPole(int[] pole, ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (int x in pole)
            {
                listBox.Items.Add(x); 
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            zobrazPole(poleA, listBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            zobrazPole(poleB, listBox2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            zobrazPole(poleC, listBox3);
        }
    }
}
