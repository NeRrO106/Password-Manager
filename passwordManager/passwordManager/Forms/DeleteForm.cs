using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passwordManager
{
    public partial class DeleteForm : Form
    {
        int id;
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                if (value != null)
                {
                    id = value;
                }
            }
        }
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void transferBtn_Click(object sender, EventArgs e)
        {
            int tempid;
            if (Int32.TryParse(idTxt.Text, out tempid))
            {
                ID = tempid;
            }
            this.Close();
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {

        }
    }
}
