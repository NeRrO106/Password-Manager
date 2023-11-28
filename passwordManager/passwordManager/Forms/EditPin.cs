using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passwordManager.Forms
{
    public partial class EditPin : Form
    {
        int pin;
        public int PIN
        {
            get { return pin; }
            set { pin = value; }
        }

        public EditPin()
        {
            InitializeComponent();
        }

        private void transferBtn_Click(object sender, EventArgs e)
        {
            int temp;
            if(Int32.TryParse(txtPin.Text, out temp))
            {
                PIN = temp;
            }
            this.Close();
        }
    }
}
