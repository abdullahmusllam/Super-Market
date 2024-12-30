namespace Supermarket_mangement
{
    partial class invoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(invoice));
            this.panel_invo = new System.Windows.Forms.Panel();
            this.btnQu = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.save_bill = new System.Windows.Forms.Button();
            this.newBill = new System.Windows.Forms.Button();
            this.qualty = new System.Windows.Forms.TextBox();
            this.combo_emp = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.price = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.TextBox();
            this.text_date = new System.Windows.Forms.TextBox();
            this.text_id = new System.Windows.Forms.TextBox();
            this.combo_product = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name_cus = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lab_total = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel_invo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_invo
            // 
            this.panel_invo.Controls.Add(this.btnQu);
            this.panel_invo.Controls.Add(this.btnPrint);
            this.panel_invo.Controls.Add(this.save_bill);
            this.panel_invo.Controls.Add(this.newBill);
            this.panel_invo.Controls.Add(this.qualty);
            this.panel_invo.Controls.Add(this.combo_emp);
            this.panel_invo.Controls.Add(this.btn_add);
            this.panel_invo.Controls.Add(this.bunifuCustomDataGrid1);
            this.panel_invo.Controls.Add(this.price);
            this.panel_invo.Controls.Add(this.total);
            this.panel_invo.Controls.Add(this.text_date);
            this.panel_invo.Controls.Add(this.text_id);
            this.panel_invo.Controls.Add(this.combo_product);
            this.panel_invo.Controls.Add(this.label1);
            this.panel_invo.Controls.Add(this.name_cus);
            this.panel_invo.Controls.Add(this.bunifuCustomLabel8);
            this.panel_invo.Controls.Add(this.bunifuCustomLabel4);
            this.panel_invo.Controls.Add(this.lab_total);
            this.panel_invo.Controls.Add(this.bunifuCustomLabel7);
            this.panel_invo.Controls.Add(this.bunifuCustomLabel6);
            this.panel_invo.Controls.Add(this.bunifuCustomLabel5);
            this.panel_invo.Controls.Add(this.bunifuCustomLabel3);
            this.panel_invo.Controls.Add(this.bunifuCustomLabel2);
            this.panel_invo.Controls.Add(this.bunifuCustomLabel1);
            this.panel_invo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_invo.Location = new System.Drawing.Point(0, 0);
            this.panel_invo.Name = "panel_invo";
            this.panel_invo.Size = new System.Drawing.Size(1047, 533);
            this.panel_invo.TabIndex = 0;
            this.panel_invo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_invo_Paint);
            // 
            // btnQu
            // 
            this.btnQu.Font = new System.Drawing.Font("Mudir MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnQu.Location = new System.Drawing.Point(32, 236);
            this.btnQu.Name = "btnQu";
            this.btnQu.Size = new System.Drawing.Size(120, 39);
            this.btnQu.TabIndex = 64;
            this.btnQu.Text = "البحث عن العميل";
            this.btnQu.UseVisualStyleBackColor = true;
            this.btnQu.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Mudir MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPrint.Location = new System.Drawing.Point(170, 236);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(120, 39);
            this.btnPrint.TabIndex = 63;
            this.btnPrint.Text = "طباعة الفاتورة";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // save_bill
            // 
            this.save_bill.BackColor = System.Drawing.Color.LightSeaGreen;
            this.save_bill.Font = new System.Drawing.Font("Mudir MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.save_bill.Location = new System.Drawing.Point(32, 281);
            this.save_bill.Name = "save_bill";
            this.save_bill.Size = new System.Drawing.Size(120, 39);
            this.save_bill.TabIndex = 62;
            this.save_bill.Text = "حفظ الفاتورة";
            this.save_bill.UseVisualStyleBackColor = false;
            this.save_bill.Click += new System.EventHandler(this.button1_Click);
            // 
            // newBill
            // 
            this.newBill.BackColor = System.Drawing.Color.Red;
            this.newBill.Font = new System.Drawing.Font("Mudir MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.newBill.Location = new System.Drawing.Point(170, 281);
            this.newBill.Name = "newBill";
            this.newBill.Size = new System.Drawing.Size(120, 39);
            this.newBill.TabIndex = 61;
            this.newBill.Text = "فاتورة جديدة";
            this.newBill.UseVisualStyleBackColor = false;
            this.newBill.Click += new System.EventHandler(this.newBill_Click);
            // 
            // qualty
            // 
            this.qualty.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qualty.Location = new System.Drawing.Point(786, 217);
            this.qualty.Multiline = true;
            this.qualty.Name = "qualty";
            this.qualty.Size = new System.Drawing.Size(100, 35);
            this.qualty.TabIndex = 60;
            // 
            // combo_emp
            // 
            this.combo_emp.FormattingEnabled = true;
            this.combo_emp.Location = new System.Drawing.Point(88, 104);
            this.combo_emp.Name = "combo_emp";
            this.combo_emp.Size = new System.Drawing.Size(317, 21);
            this.combo_emp.TabIndex = 59;
            this.combo_emp.SelectedIndexChanged += new System.EventHandler(this.combo_emp_SelectedIndexChanged);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Teal;
            this.btn_add.Font = new System.Drawing.Font("Mudir MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_add.Location = new System.Drawing.Point(825, 281);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(120, 39);
            this.btn_add.TabIndex = 58;
            this.btn_add.Text = "إضافة";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(0, 344);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(1047, 189);
            this.bunifuCustomDataGrid1.TabIndex = 57;
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(528, 217);
            this.price.Multiline = true;
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(190, 35);
            this.price.TabIndex = 55;
            // 
            // total
            // 
            this.total.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(314, 218);
            this.total.Multiline = true;
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(132, 35);
            this.total.TabIndex = 54;
            this.total.Text = "0";
            this.total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_date
            // 
            this.text_date.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.text_date.Location = new System.Drawing.Point(88, 45);
            this.text_date.Multiline = true;
            this.text_date.Name = "text_date";
            this.text_date.Size = new System.Drawing.Size(317, 34);
            this.text_date.TabIndex = 53;
            // 
            // text_id
            // 
            this.text_id.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.text_id.Location = new System.Drawing.Point(521, 45);
            this.text_id.Multiline = true;
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(309, 34);
            this.text_id.TabIndex = 52;
            // 
            // combo_product
            // 
            this.combo_product.FormattingEnabled = true;
            this.combo_product.ItemHeight = 20;
            this.combo_product.Location = new System.Drawing.Point(409, 174);
            this.combo_product.Name = "combo_product";
            this.combo_product.Size = new System.Drawing.Size(475, 26);
            this.combo_product.TabIndex = 51;
            this.combo_product.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(992, 23);
            this.label1.TabIndex = 50;
            this.label1.Text = "_________________________________________________________________________________" +
    "____________________________________________";
            // 
            // name_cus
            // 
            this.name_cus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name_cus.Font = new System.Drawing.Font("Mudir MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.name_cus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.name_cus.HintForeColor = System.Drawing.Color.Empty;
            this.name_cus.HintText = "";
            this.name_cus.isPassword = false;
            this.name_cus.LineFocusedColor = System.Drawing.Color.Blue;
            this.name_cus.LineIdleColor = System.Drawing.Color.Gray;
            this.name_cus.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.name_cus.LineThickness = 4;
            this.name_cus.Location = new System.Drawing.Point(521, 95);
            this.name_cus.Margin = new System.Windows.Forms.Padding(4);
            this.name_cus.Name = "name_cus";
            this.name_cus.Size = new System.Drawing.Size(308, 33);
            this.name_cus.TabIndex = 49;
            this.name_cus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Mudir MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(407, 94);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(105, 35);
            this.bunifuCustomLabel8.TabIndex = 47;
            this.bunifuCustomLabel8.Text = "اسم الموضف";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Mudir MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(408, 41);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(105, 35);
            this.bunifuCustomLabel4.TabIndex = 46;
            this.bunifuCustomLabel4.Text = "تاريخ الفاتورة";
            // 
            // lab_total
            // 
            this.lab_total.AutoSize = true;
            this.lab_total.Font = new System.Drawing.Font("Mudir MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lab_total.Location = new System.Drawing.Point(449, 215);
            this.lab_total.Name = "lab_total";
            this.lab_total.Size = new System.Drawing.Size(79, 35);
            this.lab_total.TabIndex = 45;
            this.lab_total.Text = "المجموع";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Mudir MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(722, 215);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(47, 35);
            this.bunifuCustomLabel7.TabIndex = 44;
            this.bunifuCustomLabel7.Text = "السعر";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Mudir MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(892, 215);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(57, 35);
            this.bunifuCustomLabel6.TabIndex = 43;
            this.bunifuCustomLabel6.Text = "الكمية";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Mudir MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(892, 167);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(89, 35);
            this.bunifuCustomLabel5.TabIndex = 42;
            this.bunifuCustomLabel5.Text = "اسم المنتج";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Mudir MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(834, 94);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(90, 35);
            this.bunifuCustomLabel3.TabIndex = 41;
            this.bunifuCustomLabel3.Text = "اسم العميل";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Mudir MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(834, 43);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(111, 35);
            this.bunifuCustomLabel2.TabIndex = 48;
            this.bunifuCustomLabel2.Text = "الرقم التسلسلي";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Mudir MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(437, -2);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(100, 35);
            this.bunifuCustomLabel1.TabIndex = 40;
            this.bunifuCustomLabel1.Text = "فاتورة الشراء";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 533);
            this.Controls.Add(this.panel_invo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "invoice";
            this.Text = "Main";
            this.panel_invo.ResumeLayout(false);
            this.panel_invo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button newBill;
        private System.Windows.Forms.TextBox qualty;
        private System.Windows.Forms.ComboBox combo_emp;
        private System.Windows.Forms.Button btn_add;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.TextBox text_date;
        private System.Windows.Forms.TextBox text_id;
        private MetroFramework.Controls.MetroComboBox combo_product;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox name_cus;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel lab_total;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Button save_bill;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        public System.Windows.Forms.Panel panel_invo;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnQu;
    }
}