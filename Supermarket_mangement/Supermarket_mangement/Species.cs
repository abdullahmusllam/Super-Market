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
    public partial class catgory : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=Abdullah;User ID=supermarket;Password=sm;");
        public catgory()

        {
            InitializeComponent();
            text_id_jop.Focus();
            text_id_jop.Select();
            dgv_add();
            dgv_add1();
        }

        private void catgory_Load(object sender, EventArgs e)
        {
                        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void text_id_jop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                text_name_jop.Focus();
            }
        }
        private void clear1()
        {

            text_id_jop.Text = "";
            text_name_jop.Text = "";
            

        }
        private void clear()
        {

            text_id_cat.Text = "";
            text_name_cat.Text = "";


        }
        private void add_jop_Click(object sender, EventArgs e)
        {
            if (text_name_jop.Text == "" || text_id_jop.Text == "") {
                MessageBox.Show("البيانات المدخلة غير مكتملة");
            }
            else {
                try
                {
                    con.Open();
                   // string getlast_id = "select max (jop_id) from type_jop";
                   // OleDbCommand cmd = new OleDbCommand(getlast_id, con);
                   //// int last_id = Convert.ToInt16(cmd.ExecuteScalar());
                   // int new_id = last_id + 1;

                    OleDbCommand cmd1 = new OleDbCommand("insert into type_jop values('" + Convert.ToInt32(text_id_jop.Text) + "','" + text_name_jop.Text + "')", con);

                    
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("تم الحفظ بنجاح");
                    clear1();
                    dgv_add();

                    text_id_jop.Focus();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                } }
        }

        private void update_jop_Click(object sender, EventArgs e)
        {
            try {
                con.Open();
                OleDbCommand cmd = new OleDbCommand(" update type_jop  set jop_id ='" + Convert.ToInt32(text_id_jop.Text) + "',jop_name='" + (text_name_jop.Text) + "' where jop_id ='" + Convert.ToInt32(text_id_jop.Text) + "' ", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم التعديل بنجاح");
              dgv_add();
                clear1();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void Delete_jop_Click(object sender, EventArgs e)
        {

            con.Open();
            OleDbCommand cmd = new OleDbCommand("delete from type_jop where jop_id='" + text_id_jop.Text + "' ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم الحذف  بنجاح");
            dgv_add();
        }

        private void dgv_dep_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            text_id_jop.Text = dgv_dep.Rows[e.RowIndex].Cells[0].Value.ToString();
            text_name_jop.Text = dgv_dep.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        private void dgv_add()
        {
            OleDbDataAdapter dataA = new OleDbDataAdapter("select * from type_jop", con);
            DataTable dtab = new DataTable();
            dataA.Fill(dtab);
            dgv_dep.DataSource = dtab;
        }
        private void dgv_add1()
        {
            OleDbDataAdapter dataA = new OleDbDataAdapter("select * from quality", con);
            DataTable dtab = new DataTable();
            dataA.Fill(dtab);
            dgv_catgory.DataSource = dtab;
        }

        private void text_id_cat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                text_name_cat.Focus();
            }
        }

        private void add_pro_Click(object sender, EventArgs e)
        {
            if (text_name_cat.Text == "" || text_id_cat.Text == "")
            {
                MessageBox.Show("البيانات الصنف المدخلة غير مكتملة");
            }
            else
            {
                try
                {


                    OleDbCommand cmd = new OleDbCommand("insert into quality values('" + Convert.ToInt32(text_id_cat.Text) + "','" + text_name_cat.Text + "')", con);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("تم الحفظ بنجاح");
                    clear1();
                    dgv_add1();

                    text_id_cat.Focus();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void dgv_catgory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            text_id_jop.Text = dgv_catgory.Rows[e.RowIndex].Cells[0].Value.ToString();
            text_name_jop.Text = dgv_catgory.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("delete  from quality where quality_id='" + text_id_cat.Text + "' ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم الحذف  بنجاح");
            dgv_add1();
            clear();
        }

        private void update_cat_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand(" update  quality   set quality_id ='" + Convert.ToInt32(text_id_cat.Text) + "', quality_name='" + (text_name_cat.Text) + "' where quality_id ='" + Convert.ToInt32(text_id_cat.Text) + "' ", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم التعديل بنجاح");
                dgv_add();
                clear1();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void text_name_jop_KeyDown(object sender, KeyEventArgs e)
        {
           /// add_jop.PerformClick();
        }

        private void text_name_cat_KeyDown(object sender, KeyEventArgs e)
        {
           // add_pro.PerformClick();
        }

        private void dgv_catgory_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            text_id_cat.Text = dgv_catgory.Rows[e.RowIndex].Cells[0].Value.ToString();
            text_name_cat.Text = dgv_catgory.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void panel_cat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

           /* OleDbCommand cmd = new OleDbCommand("select * from quality  where quality_name like '%" + //هنا نضع صندوق الادخال + "%'", con);
            OleDbDataAdapter dataAd = new OleDbDataAdapter(cmd);
            DataTable dtabl = new DataTable();
            dataAd.Fill(dtabl);
            dgv_catgory.DataSource = dtabl;*/
            //كود البحث
        }
    }
}
