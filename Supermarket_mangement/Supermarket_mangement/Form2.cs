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
   
    public partial class Form2 : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=Abdullah;User ID=supermarket;Password=sm;");
        public Form2()
        {
            InitializeComponent();
            add_combo();
            add_data_grid();
        }

        private void dgv_stor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        private void add_combo()
        {
            OleDbDataAdapter dataA = new OleDbDataAdapter("select * from quality", con);
            DataTable dtab = new DataTable();
            dataA.Fill(dtab);
            combo_cat.DataSource = dtab;
            combo_cat.DisplayMember = "quality_name";
            combo_cat.ValueMember = "QUALITY_ID";
        }
        private void add_data_grid()
        {
            OleDbDataAdapter dataAd = new OleDbDataAdapter("select i.item_name ,i.item_price,i.ITEM_QUANTIY,q. QUALITY_NAME  from item i,quality q where i. ITEM_ID (+)=q.QUALITY_ID", con);
            DataTable dtabl = new DataTable();
            dataAd.Fill(dtabl);
            dgv_stor.DataSource = dtabl;
        }
        private void panl_stor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            add_data_grid();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            if (textBox1.Text != "")
            {
               
                OleDbCommand cmd = new OleDbCommand("select i.item_name ,i.item_price,i.ITEM_QUANTIY,q. QUALITY_NAME  from item i,quality q  where i.item_name like '%" + textBox1.Text + "%'", con);
                OleDbDataAdapter dataAd = new OleDbDataAdapter(cmd);
                DataTable dtabl = new DataTable();
                dataAd.Fill(dtabl);
                dgv_stor.DataSource = dtabl;
            }
            con.Close();
        }
    }
}
