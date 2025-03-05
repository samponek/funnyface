using System;
using System.Linq;
using System.Windows.Forms;

namespace funnyface
{
    public partial class Form1 : Form
    {
        private static Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int length = (int)numPasswordLength.Value;
            txtPassword.Text = GeneratePassword(length);
        }

        private string GeneratePassword(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
                
            
        }
    }
}
