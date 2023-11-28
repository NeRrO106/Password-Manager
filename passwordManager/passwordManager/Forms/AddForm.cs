using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passwordManager
{
    public partial class AddForm : Form
    {

        string site;
        string pass;
        string user;

        public string SITE
        {
            get
            {
                return site;
            }
            set
            {
                if(value != null)
                {
                    site = value;
                }
            }
        }
        public string PASSWORD
        {
            get
            {
                return pass;
            }
            set
            {
                if (value != null)
                {
                    pass = value;
                }
            }
        }
        public string USER
        {
            get { return user; }
            set {
                if( value != null) { user = value; }
            }
        }
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            SITE = textSite.Text;
            PASSWORD = textPass.Text;
            USER = textUser.Text;
            this.Close();
        }
    }
}
