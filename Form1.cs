using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_01_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] task_list = { };
            listBox1.Items.AddRange(task_list);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string task_for_add = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(task_for_add))
            {
                listBox1.Items.Add(task_for_add);
                
            }
            else
            {
                MessageBox.Show("[Подсказка]: Задача для добавления не может быть пустой.");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (listBox1.SelectedItem != null)
            {
               string old_task = listBox1.SelectedItem.ToString();
               string new_task = textBox1.Text;

               int task_index = listBox1.Items.IndexOf(old_task);

                listBox1.Items[task_index] = new_task;
            }
            else
            {
                MessageBox.Show("[Подсказка]: В списке задач нажмите на ту, которую нужно заменить.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
