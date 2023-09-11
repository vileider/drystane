using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace drystane
{


    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("button2");
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("dash");
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("button2");
            Console.WriteLine("123");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LenghtBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(LenghtBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                LenghtBox.Text = LenghtBox.Text.Remove(LenghtBox.Text.Length - 1);
            }

        }
        private void WidthBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(widthBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                widthBox.Text = widthBox.Text.Remove(widthBox.Text.Length - 1);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            widthBox.Text = "";
            LenghtBox.Text = "";
            outputPanel.Text = "";
        }

            private void button1_Click_1(object sender, EventArgs e)
        {
            int lenght;
            if (int.TryParse(LenghtBox.Text, out lenght))
            {

            }
            else
            {
                MessageBox.Show("Data Invalid");
            }

            int width;
            if (int.TryParse(widthBox.Text, out width))
            {

            }
            else
            {
                MessageBox.Show("Data Invalid");
            }
            double sqareM = lenght * width;
            double wallCost = sqareM * 200;
            outputPanel.Text = Convert.ToString(wallCost);
            outputPanel.Text += "£";
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("analytics");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}