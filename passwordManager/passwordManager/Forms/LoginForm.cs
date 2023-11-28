using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace passwordManager.Forms
{
    public partial class LoginForm : Form
    {

        int pin;
        bool logged = false;
        public bool LOGGED
        {
            get { return logged; }
            set { logged = value; }
        }

        private static string filename = "pin.txt";

        public LoginForm()
        {
            InitializeComponent();
            ReadFile(filename);
            if(pin == 0)
            {
                pin = 1234;
                SaveFile(pin);
            }
        }

        public void ReadFile(string filename)
        {
            if (File.Exists(filename))
            {
                string continutFisier = File.ReadAllText(filename);
                int tempPin;
                if (int.TryParse(continutFisier, out tempPin))
                {
                    pin = tempPin;
                }
            }
        }

        public static  void SaveFile(int pin)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.Write(pin);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int temppin;
            if (Int32.TryParse(pinTxt.Text, out temppin))
            {
                if (pin == temppin)
                {
                    LOGGED = true;
                    this.Close();
                }
                else MessageBox.Show("Error!");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
