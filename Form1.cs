using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class PasswordGenerator : Form
    {
        int currPasswordLength = 0;
        Random random = new Random();
        private void passwordGenerator(int passwordLength) 
        {
            String allcharacters = "qwertyuiopasdfghjklzxcvbnm1234567890QWERTYUIOPASDFGHJKLZXCVBNM!@#$%^&";
            String randomPassword = "";
            for (int i = 0; i < passwordLength; i++) 
            {
                int randomNum = random.Next(0, allcharacters.Length);
                randomPassword += allcharacters[randomNum];//goes inside allcharacters string pick randomnum index and adds it to randomPassword string
            }
            labelPassword.Text = randomPassword;
        }
        public PasswordGenerator()
        {
            InitializeComponent();
            trackBarPasswordLength.Minimum = 5;
            trackBarPasswordLength.Maximum = 20;
            passwordGenerator(5);
        }

        private void PasswordGenerator_Load(object sender, EventArgs e)
        {

        }

        private void buttonCopyPassword_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(labelPassword.Text);
        }

        private void trackBarPasswordLength_Scroll(object sender, EventArgs e)
        {
            labelPasswordLength.Text = " Password Length: " + trackBarPasswordLength.Value.ToString();
            
            

        }

        private void buttonGeneratePassword_Click(object sender, EventArgs e)
        {
            currPasswordLength = trackBarPasswordLength.Value;
            passwordGenerator(currPasswordLength);
        }
    }
}
