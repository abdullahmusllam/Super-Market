using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mangement
{
    public partial class Login : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=Abdullah;User ID=supermarket;Password=sm;");
        public Login()
        {
            InitializeComponent();
        }

        private void text_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                text_pas.Focus();
            }
        }

        private void text_pas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btn_add.PerformClick();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(text_user.Text))
            {
                text_user.Focus();
                return;

            }
            if(String.IsNullOrEmpty(text_pas.Text))
            {
                text_pas.Focus();
                return;

            }
            try {
                OleDbDataAdapter dataA = new OleDbDataAdapter("select * from emp where emp_name='"+text_user.Text+"'and pas='"+text_pas.Text+"'", con);
                DataTable dtab = new DataTable();
                dataA.Fill(dtab);
                if (dtab.Rows.Count <= 0)
                {
                    MessageBox.Show("كلمة المرور المدخلة او الاسم المستخدم غير صحيح");
                    text_user.Text = "";
                    text_pas.Text = "";
                    text_user.Focus();
                    return;
                }
                else
                {
                    Main1 main = new Main1();
                    MessageBox.Show("تم تسجيل الدخول بنجاح");

                    this.Hide();
               
                    main.Show();

                }
            } catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
