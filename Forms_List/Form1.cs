using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_List
{
    public partial class Form1 : Form
    {List<PersonList> persons = new List<PersonList>();
        public void Persons()
        {
            String ruta = "C:\\Users\\Pere\\source\\repos\\ConsoleBasicAplications\\StandardDataSet.csv";

            List<string> lines = File.ReadAllLines(ruta).ToList();
            lines.RemoveAt(0);
            foreach (var linia in lines)
            {
                string[] content = linia.Split(',');
                PersonList pl = new PersonList();
                pl.FirstName = content[0];
                pl.LastName = content[1];
                pl.Age = content[2];
                pl.IsAlive = Convert.ToBoolean(Convert.ToInt32(content[3]));

                persons.Add(pl);
                listBox1.Items.Add(linia);
            }
            //UptadePerson();
        }

        /*public void UptadePerson()
        {
            listBox1.Items.AddRange(persons);
        }*/
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Persons();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*String ruta2 = "C:\\Users\\Pere\\source\\repos\\ConsoleBasicAplications\\StandardDataSet.csv";
            TextWriter txt = new StreamWriter(ruta2);
            txt.WriteLine(textBox1.Text + " " + textBox2.Text + " " + numericUpDown1.Value);
            txt.Close();
            Persons();*/
            PersonList pl = new PersonList();
            pl.FirstName = textBox1.Text;
            pl.LastName = textBox2.Text;
            pl.Age = numericUpDown1.Value.ToString();
            pl.IsAlive = checkBox1.Checked;
            persons.Add(pl);
            listBox1.Items.Add(textBox1.Text + "," + textBox2.Text + "," + numericUpDown1.Value + "," + checkBox1.Checked);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
