using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConsoleApplication1;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Character titan = new Titan(500, 300, 15, 30, 0);
        Character sisadmin = new siskadmin(250, 500, 5, 20, 0);
        Character invoker = new invoker(350, 500, 10, 20, 0);
        Character Ninjos = new Ninjos(300, 400, 3, 100, 0.1);
        Character cheater = new cheater(99999, 99999, 99999, 9999999, 9999999999);
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            List<Character> targets = new List<Character>();
            listBox1.Items.Add(titan.Skill1(targets));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            listBox1.Items.Add(invoker.Skill1(targets));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            listBox1.Items.Add(sisadmin.Skill1(targets));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            listBox1.Items.Add(Ninjos.Skill1(targets));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Character> targets = new List<Character>();
            listBox1.Items.Add(cheater.Skill1(targets));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
