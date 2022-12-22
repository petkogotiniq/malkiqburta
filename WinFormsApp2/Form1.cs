using System;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            

            //IList<double> numArray = new List<double>();
            //int count = 0;
            //numArray.Add(Convert.ToDouble(textBox1.Text));
            //count++;


            //int[] array = new int[5];
            //string UserInputText = textBox1.Text;
            //label2.Text = UserInputText;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsNumber(ch) && !char.IsSeparator(ch) && !char.IsPunctuation(ch) && ch !=8)
            {
                e.Handled= true;
                

            }
            

        }
    }
}
