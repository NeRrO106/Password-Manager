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
    public partial class EditForm : Form
    {

        private int id;
        private string site;
        private string password;
        private string user;
        public int ID
        {
            get { return id; }
            set {
                if (value != null) id = value;
            }
        }
        public string SITE
        {
            get { return site; }
            set
            {
                if (value != null) site = value;
            }
        }
        public string PASSWORD
        {
            get { return password; }
            set { 
                if (value != null) password = value;
            }
        }

        public string USER
        {
            get { return user; }
            set
            {
                if (value != null) user = value;
            }
        }

        public EditForm()
        {
            InitializeComponent();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            int tempid;
            if(Int32.TryParse(idText.Text, out tempid))
            {
                ID = tempid;
            }
            SITE = SiteTxt.Text;
            PASSWORD = passTxt.Text;
            USER = userTxt.Text;
            this.Close();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }
    }
}
