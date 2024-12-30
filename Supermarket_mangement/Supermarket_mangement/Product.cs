using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Supermarket_mangement
{
    public partial class Product : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=Abdullah;User ID=supermarket;Password=sm;");
        public Product()
        {
            InitializeComponent();
            dgv_add();
            add_combo();
            text_name.Focus();
            text_name.Select();
        }

        private void dgv_add()
        {
            DataTable dtab = new DataTable();
            var ora = "select * from item";
            OleDbDataAdapter dataA = new OleDbDataAdapter(ora, con);
            dataA.Fill(dtab);
            dgv_pro.DataSource = dtab;
        }

        private void Product_Load(object sender, EventArgs e)
        {
            dgv_add();
            add_combo();
            text_name.Focus();
            text_name.Select();
        }
        private void add_combo()
        {
            OleDbDataAdapter dataA = new OleDbDataAdapter("select * from quality", con);
            DataTable dtab = new DataTable();
            dataA.Fill(dtab);
            combo_type.DataSource = dtab;
            combo_type.DisplayMember = "quality_name";
            combo_type.ValueMember = "QUALITY_ID";
        }

        private void clear()
        {

            text_name.Text = "";
            text_price.Text = "";
            text_qounty.Text = "";

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void text_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                combo_type.Focus();
            }

        }

        private void text_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                text_name.Focus();
            }
        }

        private void text_qounty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                text_price.Focus();

            }
        }

        private void combo_type_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                text_qounty.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_pro_Click_1(object sender, EventArgs e)
        {
           
             if (text_qounty.Text == "")
            {


                MessageBox.Show("الكمية غير موجود", "الكمية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text_qounty.Focus();
            }
            else if (text_price.Text == "")
            {
                MessageBox.Show("السعر غير موجود", "السعر ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text_price.Focus();
            }
            else if (text_name.Text == "")
            {

                MessageBox.Show("الاسم غير موجود", "السعر ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     text_name.Focus();
                text_name.Select();

            }
            else if (combo_type.SelectedIndex <= -1)
            {
                MessageBox.Show("اسم النوع غير موجد");
                return;
            }
            else
            {
                try
                {
                    
                    OleDbCommand cmd1 = new OleDbCommand("insert into item values('" +Convert.ToInt32( text_id.Text) + "','" + text_name.Text + "','" + Convert.ToInt32(text_price.Text) + "','" + Convert.ToInt32(text_qounty.Text) + "','" + combo_type.SelectedValue + "')", con);
                    con.Open();
                   
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("تم الحفظ بنجاح");
                    clear();
                    dgv_add();
                
    text_name.Focus();
                }
                catch (Exception Ex) {
                    MessageBox.Show(Ex.Message);
                }
                
            } }
        public void count_id(int c)
        {
            c += 1;

        }
        private void btn_update_Click_1(object sender, EventArgs e)
        {

            try {
                con.Open();
                OleDbCommand cmd = new OleDbCommand(" update item set item_name ='" + text_name.Text + "',item_price ='" + Convert.ToInt32(text_price.Text) + "', item_quantiy='" + Convert.ToInt32(text_qounty.Text) + "',quality_id= '" + combo_type.SelectedValue + "' where item_id ='" + Convert.ToInt32(text_id.Text) + "' ", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم التعديل بنجاح");
                dgv_add();
            }
            catch(Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            }


        private void btn_delete_Click_1(object sender, EventArgs e)
        {

            con.Open();
            OleDbCommand cmd = new OleDbCommand("delete  from  item where item_id='" + text_id.Text + "' ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم الحذف  بنجاح");
            dgv_add();
        }

        private void text_price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btn_add_pro.PerformClick();

            }
            
        }

        private void text_qounty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void text_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void text_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void text_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void combo_type_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void combo_type_SelectionChangeCommitted_1(object sender, EventArgs e)
        {

        }

        private void dgv_pro_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgv_pro_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            text_id.Text = dgv_pro.Rows[e.RowIndex].Cells[0].Value.ToString();
            text_name.Text = dgv_pro.Rows[e.RowIndex].Cells[1].Value.ToString();
            text_price.Text = dgv_pro.Rows[e.RowIndex].Cells[2].Value.ToString();
            text_qounty.Text = dgv_pro.Rows[e.RowIndex].Cells[3].Value.ToString();
            combo_type.SelectedItem = dgv_pro.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void dgv_pro_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel_product_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
