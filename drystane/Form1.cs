using System.Windows.Forms;
using System.Runtime.InteropServices;

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
            outputPanel.Text = lenghtBox.Text;
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            string word = lenghtBox.Text;
            outputPanel.Text = word;
            System.Diagnostics.Debug.WriteLine(word);
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("analytics");
        }
    }
}