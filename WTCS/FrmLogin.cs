using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WTCS
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        //DataProvider connect = new DataProvider();
        public static int Lang_ID = 1, Count =0;
        public static string User_ID, User_Name, TimeNow;
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            LoadFirst();
            LoadLanguage(Lang_ID);
        }
        private void LoadFirst()
        {
            //txtUserName.Text = connect.GetRememberUser();
            //int lang = connect.GetLangdefaul();
            //if (lang == 1)
            //{
            //    cbLanguage.SelectedIndex = 0;
            //    Lang_ID = 1;
            //}
            //if (lang == 2)
            //{
            //    cbLanguage.SelectedIndex = 1;
            //    Lang_ID = 2;
            //}
            //if (lang == 3)
            //{
            //    cbLanguage.SelectedIndex = 2;
            //    Lang_ID = 3;
            //}
        }

        private void LoadLanguage(int Lang_ID)
        {
            //DataTable dt = connect.ChoiLanguages(" WHERE MODULE ='Login' ");
            //foreach (DataRow dr in dt.Rows)
            //{
            //    if (dr["NAME"].ToString() == "lblTitle") lblTitle.Text = dr["LANG"].ToString();
            //    if (dr["NAME"].ToString() == "cbRemember") cbRemember.Text = dr["LANG"].ToString();
            //    if (dr["NAME"].ToString() == "btnLogin") btnLogin.Text = dr["LANG"].ToString();
            //    if (dr["NAME"].ToString() == "blLanguage") blLanguage.Text = dr["LANG"].ToString();
            //    if (dr["NAME"].ToString() == "lblConfig") lblConfig.Text = dr["LANG"].ToString();
            //}
        }

        //public string GetNameUser(string ID_User)
        //{
        //    //string UserName = string.Empty;
        //    //try
        //    //{
        //    //    string sql = "SELECT NAME FROM USRH1 WHERE USER_ID ='" + ID_User + "'";
        //    //    UserName = connect.ExecuteScalar(sql);
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    MessageBox.Show(ex.Message);
        //    //}
        //    //return UserName;
        //}

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //lblName.Text = GetNameUser(txtUserName.Text);
            //if (!string.IsNullOrEmpty(lblName.Text))
            //{
            //    if (connect.Login(txtUserName.Text, txtPassWord.Text))
            //    {
            //        if (cbRemember.Checked == true) connect.SetRememberUser(txtUserName.Text);
            //        connect.SetLangdefaul(Lang_ID);
            //        FrmMain fm = new FrmMain();
            //        User_ID = txtUserName.Text;
            //        User_Name = lblName.Text;
            //        this.Hide();
            //        fm.ShowDialog();
            //        this.Show();
            //        Count = 0;
            //    }
            //    else
            //    {
            //        Count++;
            //        if (Count == 3)
            //        {
            //            MessageBox.Show("The number of login attempts has exceeded the limit 3 time ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            this.Close();
            //        }
            //        MessageBox.Show("Password's Wrong: " + Count, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        txtPassWord.Clear();
            //        txtPassWord.Focus();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("User Name Wrong !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtUserName.Clear();
            //    txtUserName.Focus();
            //}
        }

        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLanguage.SelectedIndex == 0) Lang_ID = 1;
            if (cbLanguage.SelectedIndex == 1) Lang_ID = 2;
            if (cbLanguage.SelectedIndex == 2) Lang_ID = 3;
            LoadLanguage(Lang_ID);
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    if (!string.IsNullOrEmpty(GetNameUser(txtUserName.Text)))
            //    {
            //        lblName.Text = GetNameUser(txtUserName.Text);
            //        txtPassWord.Focus();
            //    }
            //    else
            //    {
            //        MessageBox.Show("User Name Wrong !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        lblName.Text = string.Empty;
            //        txtUserName.Clear();
            //        txtUserName.Focus();
            //    }
            //}
        }

        private void txtPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)  btnLogin.PerformClick();
        }

        private void txtPassWord_MouseClick(object sender, MouseEventArgs e)
        {
            //if (!string.IsNullOrEmpty(GetNameUser(txtUserName.Text)))
            //{
            //    lblName.Text = GetNameUser(txtUserName.Text);
            //    txtPassWord.Focus();
            //}
            //else
            //{
            //    MessageBox.Show("User Name Wrong !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    lblName.Text = "";
            //    txtUserName.Clear();
            //    txtUserName.Focus();
            //}
        }

        
    }
}
