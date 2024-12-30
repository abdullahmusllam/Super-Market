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
    public partial class client : Form
    {
        private object bunifuCustomDataGrid1;
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=Abdullah;User ID=supermarket;Password=sm;");

        public client()
        {
            InitializeComponent();
            add_dgv();
        }
        private void add_dgv()
        {
            DataTable dtab = new DataTable();
            var ora = "select * from client";
            OleDbDataAdapter dataA = new OleDbDataAdapter(ora, con);
            dataA.Fill(dtab);
            cli_grdview.DataSource = dtab;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string getlastId = "select max (id_cli) from  client";
            OleDbCommand cmd = new OleDbCommand(getlastId, con);

            int newId;
            int lastId;
            if (Convert.IsDBNull(cmd.ExecuteScalar()))
            {
                newId = 1;
            }
            else
            {
                lastId = Convert.ToInt32(cmd.ExecuteScalar());
                newId = lastId + 1;
            }
            OleDbCommand cmd1 = new OleDbCommand("insert into client values('" + newId + "','" + name_cli.Text + "','"
                   + Convert.ToInt32(pho_cli.Text) + "','" + add_cli.Text + "')", con);

            cmd1.ExecuteNonQuery();

            MessageBox.Show("تم الاضافة بنجاح");

            add_dgv();

            con.Close();
        }

        private void client_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("update client set CLI_NAME='" + name_cli.Text + "',CLI_PHONE='" + Convert.ToInt32(pho_cli.Text) + "' ,CLIENT_ADD='" + add_cli.Text + "'where ID_CLI='" + Convert.ToInt32(id.Text) + "' ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم التعديل بنجاح");
            add_dgv();
        }

        private void cli_grdview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = cli_grdview.Rows[e.RowIndex].Cells[0].Value.ToString();
            name_cli.Text = cli_grdview.Rows[e.RowIndex].Cells[1].Value.ToString();
            pho_cli.Text = cli_grdview.Rows[e.RowIndex].Cells[2].Value.ToString();
            add_cli.Text = cli_grdview.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
