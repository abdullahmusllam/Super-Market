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

namespace Store
{
    public partial class store : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=ORCL;User ID=fawzi; Password=aa778;");
        public store()
        {
            InitializeComponent();
        }

       
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }
    }
}
