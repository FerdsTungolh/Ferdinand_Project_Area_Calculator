namespace Ferdinand_Project_Area_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Compute2 rect = new Compute2(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
                textBox6.Text = Convert.ToString(rect.Rectangle(rect.Length, rect.Width));
                listBox1.Items.Add("The are of Rectangle is : "+textBox6.Text);
            }
            else
            {
                MessageBox.Show("Error Either Length or Width is EMPTY");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.Visible != false)
            {
                listBox1.Visible = false;
                button4.Text = "History";
                textBox6.Visible = true;
                label6.Visible = true;
                label7.Visible = false;
                button5.Visible = false;
                textBox6.Visible = true;
            }
            else
            {
                textBox6.Visible = true;
                listBox1.Visible = true;
                button4.Text = "Result";
                textBox6.Visible = false;
                label6.Visible = false;
                label7.Visible = true;
                button5.Visible = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                Compute circ = new Compute(Convert.ToDouble(textBox3.Text));
                textBox6.Text = Convert.ToString(circ.Circle((circ.Radius)));
                listBox1.Items.Add("The area of Circle is : " + textBox6.Text);
            }
            else
            {
                MessageBox.Show("Error Radius is EMPTY");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "" && textBox5.Text != "")
            {
                Compute3 tria = new Compute3(Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text));
                textBox6.Text = Convert.ToString(tria.Triangle(tria.BaseLength, tria.Height));
                listBox1.Items.Add("The area of Triangle is : "+textBox6.Text);
            }
            else
            {
                MessageBox.Show("Error Either Base or Height is EMPTY");
            }
        }
    }
}
