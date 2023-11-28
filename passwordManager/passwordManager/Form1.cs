using passwordManager.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace passwordManager
{
    public partial class Form1 : Form
    {
        private AddForm addForm;
        private DeleteForm deleteForm;
        private EditForm editForm;
        private EditPin editPinForm;
        private LoginForm loginForm;

        string option;

        public string siteText;
        public string sitePass;
        public string siteUser;
        public int id;

        public int pin;

        public Form1()
        {
            InitializeComponent();
            DBHelper.EstablishConnection();
            dataGridView1.DataSource = DBHelper.LoadData();
            loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Hide();
            if (loginForm.LOGGED)
            {
                this.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            switch (option)
            {
                case "add":
                    siteText = addForm.SITE;
                    sitePass = addForm.PASSWORD;
                    siteUser = addForm.USER;
                    DBHelper.AddData(siteText,siteUser,sitePass);
                    dataGridView1.DataSource = DBHelper.LoadData();
                    break;

                case "edit":
                    id = editForm.ID;
                    siteText = editForm.SITE;
                    sitePass = editForm.PASSWORD;
                    siteUser = editForm.USER;
                    if (id != null)
                    {
                        if (string.IsNullOrEmpty(siteText)) siteText = DBHelper.getSite(id);
                        if (string.IsNullOrEmpty(sitePass)) sitePass = DBHelper.getPass(id);
                        if (string.IsNullOrEmpty(siteUser)) siteUser = DBHelper.getUser(id);
                        DBHelper.EditData(id, siteText, siteUser, sitePass);
                        dataGridView1.DataSource = DBHelper.LoadData();
                    }
                    break;
                case "editpin":
                    pin = editPinForm.PIN;
                    LoginForm.SaveFile(pin);
                    break;
                case "delete":
                    id = deleteForm.ID;
                    DBHelper.DeleteData(id);
                    dataGridView1.DataSource = DBHelper.LoadData();
                    break;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            addForm = new AddForm();
            addForm.TopLevel = false;
            addForm.AutoScroll = true;
            addForm.Show();
            panel1.Controls.Add(addForm);
            option = "add";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            deleteForm = new DeleteForm();
            deleteForm.TopLevel = false;
            deleteForm.AutoScroll = true;
            deleteForm.Show();
            panel1.Controls.Add(deleteForm);
            option = "delete";
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            editForm = new EditForm();
            editForm.TopLevel = false;
            editForm.AutoScroll = true;
            editForm.Show();
            panel1.Controls.Add(editForm);
            option = "edit";
        }
        private void EditPinButton_Click(object sender, EventArgs e)
        {
            editPinForm = new EditPin();
            editPinForm.TopLevel = false;
            editPinForm.AutoScroll = true;
            editPinForm.Show();
            panel1.Controls.Add(editPinForm);
            option = "editpin";
        }
    }
}
