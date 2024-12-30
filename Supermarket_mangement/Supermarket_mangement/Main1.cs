using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mangement
{
    public partial class Main1 : Form
    {
        public Main1()
        {
            InitializeComponent();
            Product pr = new Product();
            move_panl(button1);
            add_panle(pr.panel_product);
            la_show.Text = button1.Text;
        }

        private void label_btn_Click(object sender, EventArgs e)
        {

        }
        private void move_panl(Button btn)
        {
            panel_slide.Top = btn.Top;
            panel_slide.Height = btn.Height;
        }
        private void add_panle(Panel pn)
        {
            pn_conten.Controls.Clear();
            pn.Dock = DockStyle.Fill;
            pn_conten.Controls.Clear();
            pn_conten.Controls.Add(pn);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Product pr = new Product();
            move_panl(button1);
            add_panle(pr.panel_product);
            la_show.Text = button1.Text;
        }

        private void btn_emp_Click(object sender, EventArgs e)
        {
           Emp_Form emp = new Emp_Form();
            move_panl(btn_emp);
            add_panle(emp.emp_container);
            la_show.Text = btn_emp.Text;
        }

        private void ptn_cat_Click(object sender, EventArgs e)
        {
            catgory ca = new catgory();
            move_panl(ptn_cat);
            add_panle(ca.panel_cat);
            la_show.Text = ptn_cat.Text;
        }

        private void btn_store_Click(object sender, EventArgs e)
        {
           store1 stor = new store1();
            move_panl(btn_store);
            add_panle(stor.panel_store);
            la_show.Text = btn_store.Text;
        }

        private void btn_bii_Click(object sender, EventArgs e)
        {
            invoice invo = new invoice();
            move_panl(btn_bii);
            add_panle(invo.panel_invo);
            la_show.Text = btn_store.Text;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pn_conten_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            client c = new client();
            move_panl(btn_bii);
            add_panle(c.panel1);
            la_show.Text = btn_store.Text;
        }
    }
}
