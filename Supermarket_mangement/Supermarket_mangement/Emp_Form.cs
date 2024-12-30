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
    public partial class Emp_Form : Form
        
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=Abdullah;User ID=supermarket;Password=sm;");
        public Emp_Form()
        {
            InitializeComponent();
            add_data_combo();
            fill_dgv1();
        }
        public void datagridview_style()
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            try {
                string getlastId = "select max (id) from emp";
                OleDbCommand cmd = new OleDbCommand(getlastId, con);
                int lastId;
                int newId;
                if (Convert.IsDBNull(cmd.ExecuteScalar()))
                {
                    newId = 1;
                }
                else
                {
                    lastId = Convert.ToInt32(cmd.ExecuteScalar());
                    newId = lastId + 1;
                }
                OleDbCommand cmd1 = new OleDbCommand("insert into emp values('" + newId + "','" + name.Text +
                    "','" + Convert.ToInt32(phone.Text) + "','" + comb_type.SelectedValue + "','" + text_pass.Text + "')", con);

                cmd1.ExecuteNonQuery();



                MessageBox.Show("تم الحفظ بنجاح");

                fill_dgv1();
                con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void add_data_combo()
        {
           
            OleDbDataAdapter dataA = new OleDbDataAdapter("select * from type_jop", con);
            DataTable dtab = new DataTable();
            dataA.Fill(dtab);
            comb_type.DataSource = dtab;
            comb_type.DisplayMember = "jop_name";
            comb_type.ValueMember = "jop_id";



        }
          private void fill_dgv1()
        {
            OleDbDataAdapter dataAd = new OleDbDataAdapter("select * from emp ", con);
            DataTable dtabl = new DataTable();
            dataAd.Fill(dtabl);
            emp_grdview.DataSource = dtabl;
          
        }

        private void add_data_combo1()
        {
            OleDbDataAdapter dataA = new OleDbDataAdapter("select * from type_jop ", con);
            DataTable dtab = new DataTable();
            dataA.Fill(dtab);
            comb_type.DataSource = dtab;
            comb_type.DisplayMember = "jop_name";
            comb_type.ValueMember = "jop_id";

        }
        private void comb_type_SelectedIndexChanged(object sender, EventArgs e)
        {

          
        }

        private void Emp_Form_Load(object sender, EventArgs e)
        {
            add_data_combo();
            fill_dgv1();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("update emp set emp_name='" + name.Text + "', emp_phone='" + phone.Text + "' ,jop_id='"+comb_type.SelectedValue+"',pas='"+text_pass.Text+"' where emp_id='" + Convert.ToInt32( id.Text) + "' ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم التعديل بنجاح");
            fill_dgv1();
        }

        private void emp_grdview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           id.Text = emp_grdview.Rows[e.RowIndex].Cells[0].Value.ToString();
           name.Text = emp_grdview.Rows[e.RowIndex].Cells[1].Value.ToString();
            phone.Text = emp_grdview.Rows[e.RowIndex].Cells[2].Value.ToString();
          comb_type.DisplayMember = emp_grdview.Rows[e.RowIndex].Cells[3].Value.ToString();
            text_pass.Text = emp_grdview.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("delete  from emp where emp_id='" + Convert.ToInt32( id.Text) + "' ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم الحذف  بنجاح");
            fill_dgv1();
        }

        private void emp_grdview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                comb_type.Focus();
            }
        }

        private void comb_type_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                phone.Focus();
            }
        }

        private void phone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                button4.PerformClick();
                name.Focus();
                
            }
        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
