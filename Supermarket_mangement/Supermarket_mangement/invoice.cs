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
    public partial class invoice : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=Abdullah;User ID=supermarket;Password=sm;");
        public invoice()
        {
            InitializeComponent();
            text_date.Text = DateTime.Now.ToString("dd/MM/yyyy");
            add_dgv();
            add_emp();
            add_data_combo1();
           

        }
       
        private void add_data_combo1()
        {
            OleDbDataAdapter dataA = new OleDbDataAdapter("select * from item", con);
            DataTable dtab = new DataTable();
            dataA.Fill(dtab);
            combo_product.DataSource = dtab;
            combo_product.DisplayMember = "item_name";
            combo_product.ValueMember = "item_price";
            price.Text = combo_product.SelectedValue + "";

        }

        private void add_emp()
        {
            OleDbDataAdapter dataA = new OleDbDataAdapter("select * from emp", con);
            DataTable dtab = new DataTable();
            dataA.Fill(dtab);
            combo_emp.DataSource = dtab;
            combo_emp.DisplayMember = "EMP_NAME";
            combo_emp.ValueMember = "emp_id";
        }

        private void add_dgv()
        {
            DataTable dtab = new DataTable();
            var ora = "select * from product_info";
            OleDbDataAdapter dataA = new OleDbDataAdapter(ora, con);
            dataA.Fill(dtab);
            bunifuCustomDataGrid1.DataSource = dtab;
        }
        private void panel_invo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string getlastId = "select max (id_pro) from  product_info";
                OleDbCommand cmd = new OleDbCommand(getlastId, con);

                int newId;
                int lastId;
                if (Convert.IsDBNull(cmd.ExecuteScalar()))
                {
                    newId = 0;
                }
                else
                {
                    lastId = Convert.ToInt32(cmd.ExecuteScalar());
                    newId = lastId + 1;
                }

                int subproduct = Convert.ToInt32(qualty.Text) * Convert.ToInt32(price.Text);
                OleDbCommand cmd1 = new OleDbCommand("insert into product_info values('" + newId + "','" + combo_product.Text + "','"
                    + Convert.ToInt32(price.Text) + "','" + Convert.ToInt32(qualty.Text) + "','" + subproduct + "')", con);


                cmd1.ExecuteNonQuery();

                string sum = "select sum (SUBTOTAL) from product_info";
                OleDbCommand oleTo = new OleDbCommand(sum, con);
                object result = oleTo.ExecuteScalar();
                
                if(result != DBNull.Value)
                {
                    int sum1 = Convert.ToInt32(result);
                    total.Text = sum1.ToString();
                }
                else
                {
                    total.Text = "0";
                }

                con.Close();
                MessageBox.Show("تم الاضافة بنجاح");

                add_dgv();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }


        }

        private void newBill_Click(object sender, EventArgs e)
        {
            con.Open();

            OleDbCommand old = new OleDbCommand("delete from product_info", con);
            old.ExecuteNonQuery();
            con.Close();
            add_dgv();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                con.Open();
                string name = name_cus.Text;
                string getname = "select CUS_NAME from bill where cus_name ='" + name + "'";
                OleDbCommand olN = new OleDbCommand(getname, con);
                object resultN = olN.ExecuteScalar();
                //التحقق من اسم العميل

                string sumT = "select TOTAL from bill where cus_name ='" + name + "'";
                OleDbCommand oleT = new OleDbCommand(sumT, con);
                object resultnew = oleT.ExecuteScalar();
                int lastTotal = Convert.ToInt32(resultnew);
                int newTotal = lastTotal + Convert.ToInt32(total.Text);
                //جمع المبلغ القديم مع الجديد
                
                if (resultN != null)
                {
                    OleDbCommand olU = new OleDbCommand("update bill set TOTAL ='" + newTotal + "' where CUS_NAME ='" + name + "'" , con);
                    olU.ExecuteNonQuery();
                    MessageBox.Show("تم التحديث بنجاح");
                }
                else
                {
                string getlastId = "select max (ID_BILL) from  bill";
                OleDbCommand cmd2 = new OleDbCommand(getlastId, con);
                int newId;
                int lastId;
                if (Convert.IsDBNull(cmd2.ExecuteScalar()))
                {
                    newId = 0;
                }
                else
                {
                    lastId = Convert.ToInt32(cmd2.ExecuteScalar());
                    newId = lastId + 1;
                }
                
                OleDbCommand olB = new OleDbCommand("insert into bill values('" + newId + "','" + name_cus.Text + "','" + text_date.Text + "','" +  combo_emp.SelectedValue + "','" + Convert.ToInt32(total.Text) +  "')", con);

                olB.ExecuteNonQuery();
                MessageBox.Show("تم الحفظ بنجاح");
                con.Close();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font f = new Font("Arial", 18, FontStyle.Bold);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void combo_emp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
