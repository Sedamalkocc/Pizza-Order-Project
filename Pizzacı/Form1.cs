namespace Pizzacı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            richTextBox1.Text = textBox3.Text;
            listBox4.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            
            if(checkBox43.Checked == true)
            {

                listBox6.Items.Add (checkBox43.Text);
            }

            if (checkBox44.Checked == true)
            {

                listBox6.Items.Add(checkBox44.Text);
            }

            if (checkBox40.Checked == true)
            {

                listBox6.Items.Add(checkBox40.Text);
            }

            if (checkBox30.Checked == true)
            {

                listBox6.Items.Add(checkBox30.Text);
            }


            if (checkBox38.Checked == true)
            {

                listBox6.Items.Add(checkBox38.Text);
            }

            if (checkBox27.Checked == true)
            {

                listBox6.Items.Add(checkBox27.Text);
            }

            if (checkBox28.Checked == true)
            {

                listBox6.Items.Add(checkBox28.Text);
            }

            if (checkBox32.Checked == true)
            {

                listBox6.Items.Add(checkBox32.Text);
            }

            if (checkBox33.Checked == true)
            {

                listBox6.Items.Add(checkBox33.Text);
            }

            if (checkBox34.Checked == true)
            {
                
                listBox6.Items.Add(checkBox34.Text);
            }

            if (checkBox35.Checked == true)
            {

                listBox6.Items.Add(checkBox35.Text);
            }

            if (checkBox36.Checked == true)
            {

                listBox6.Items.Add(checkBox36.Text);
            }


            if (checkBox42.Checked == true)
            {

                listBox6.Items.Add(checkBox42.Text);
            }

            if (checkBox31.Checked == true)
            {

                listBox6.Items.Add(checkBox31.Text);
            }

            if (checkBox39.Checked == true)
            {

                listBox6.Items.Add(checkBox39.Text);
            }

            if (checkBox46.Checked == true)
            {

                listBox6.Items.Add(checkBox46.Text);
            }

            if (checkBox45.Checked == true)
            {

                listBox6.Items.Add(checkBox45.Text);
            }

            if (checkBox41.Checked == true)
            {

                listBox6.Items.Add(checkBox41.Text);
            }

            if (checkBox29.Checked == true)
            {

                listBox6.Items.Add(checkBox29.Text);
            }

            if (checkBox37.Checked == true)
            {

                listBox6.Items.Add(checkBox37.Text);
            }

            if(checkBox21.Checked == true)
            {
                listBox7.Items.Add(checkBox21.Text);
            }

            if (checkBox22.Checked == true)
            {
                listBox7.Items.Add(checkBox22.Text);
            }

            if (checkBox23.Checked == true)
            {
                listBox7.Items.Add(checkBox23.Text);
            }

            if (checkBox24.Checked == true)
            {
                listBox7.Items.Add(checkBox24.Text);
            }

            if (checkBox25.Checked == true)
            {
                listBox7.Items.Add(checkBox25.Text);
            }

            if (checkBox26.Checked == true)
            {
                listBox7.Items.Add(checkBox26.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            richTextBox1.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
            checkBox21.Checked = false;
            checkBox22.Checked = false;
            checkBox23.Checked = false;
            checkBox24.Checked = false;
            checkBox25.Checked = false;
            checkBox26.Checked = false;
            checkBox27.Checked = false;
            checkBox28.Checked = false;
            checkBox29.Checked = false;
            checkBox30.Checked = false;
            checkBox31.Checked = false;
            checkBox32.Checked = false;
            checkBox33.Checked = false;
            checkBox34.Checked = false;
            checkBox35.Checked = false;
            checkBox36.Checked = false;
            checkBox37.Checked = false;
            checkBox38.Checked = false;
            checkBox39.Checked = false;
            checkBox40.Checked = false;
            checkBox41.Checked = false;
            checkBox42.Checked = false;
            checkBox43.Checked = false;
            checkBox44.Checked = false;
            checkBox45.Checked = false;
            checkBox46.Checked = false;
        }

       
    }
}