namespace Supermarket_mangement
{
    partial class Product
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
            this.panel_product = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add_pro = new System.Windows.Forms.Button();
            this.combo_type = new System.Windows.Forms.ComboBox();
            this.dgv_pro = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.text_qounty = new System.Windows.Forms.TextBox();
            this.text_price = new System.Windows.Forms.TextBox();
            this.text_id = new System.Windows.Forms.TextBox();
            this.text_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_product
            // 
            this.panel_product.Controls.Add(this.label6);
            this.panel_product.Controls.Add(this.btn_delete);
            this.panel_product.Controls.Add(this.btn_update);
            this.panel_product.Controls.Add(this.btn_add_pro);
            this.panel_product.Controls.Add(this.combo_type);
            this.panel_product.Controls.Add(this.dgv_pro);
            this.panel_product.Controls.Add(this.text_qounty);
            this.panel_product.Controls.Add(this.text_price);
            this.panel_product.Controls.Add(this.text_id);
            this.panel_product.Controls.Add(this.text_name);
            this.panel_product.Controls.Add(this.label5);
            this.panel_product.Controls.Add(this.label4);
            this.panel_product.Controls.Add(this.label2);
            this.panel_product.Controls.Add(this.label3);
            this.panel_product.Controls.Add(this.label1);
            this.panel_product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_product.Location = new System.Drawing.Point(0, 0);
            this.panel_product.Name = "panel_product";
            this.panel_product.Size = new System.Drawing.Size(926, 471);
            this.panel_product.TabIndex = 0;
            this.panel_product.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_product_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mudir MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(406, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 30);
            this.label6.TabIndex = 25;
            this.label6.Text = "المنتجات";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Mudir MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_delete.Location = new System.Drawing.Point(238, 178);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(145, 44);
            this.btn_delete.TabIndex = 24;
            this.btn_delete.Text = "حذف";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click_1);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Mudir MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_update.Location = new System.Drawing.Point(396, 178);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(145, 44);
            this.btn_update.TabIndex = 23;
            this.btn_update.Text = "تعديل";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click_1);
            // 
            // btn_add_pro
            // 
            this.btn_add_pro.BackColor = System.Drawing.Color.Teal;
            this.btn_add_pro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_pro.Font = new System.Drawing.Font("Mudir MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_add_pro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_add_pro.Location = new System.Drawing.Point(554, 178);
            this.btn_add_pro.Name = "btn_add_pro";
            this.btn_add_pro.Size = new System.Drawing.Size(167, 46);
            this.btn_add_pro.TabIndex = 22;
            this.btn_add_pro.Text = "إضافة";
            this.btn_add_pro.UseVisualStyleBackColor = false;
            this.btn_add_pro.Click += new System.EventHandler(this.btn_add_pro_Click_1);
            // 
            // combo_type
            // 
            this.combo_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_type.FormattingEnabled = true;
            this.combo_type.Location = new System.Drawing.Point(577, 103);
            this.combo_type.Name = "combo_type";
            this.combo_type.Size = new System.Drawing.Size(168, 31);
            this.combo_type.TabIndex = 21;
            this.combo_type.SelectedIndexChanged += new System.EventHandler(this.combo_type_SelectedIndexChanged_1);
            this.combo_type.SelectionChangeCommitted += new System.EventHandler(this.combo_type_SelectionChangeCommitted_1);
            this.combo_type.KeyDown += new System.Windows.Forms.KeyEventHandler(this.combo_type_KeyDown);
            // 
            // dgv_pro
            // 
            this.dgv_pro.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_pro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_pro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pro.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_pro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_pro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_pro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_pro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_pro.DoubleBuffered = true;
            this.dgv_pro.EnableHeadersVisualStyles = false;
            this.dgv_pro.HeaderBgColor = System.Drawing.Color.White;
            this.dgv_pro.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgv_pro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_pro.Location = new System.Drawing.Point(0, 254);
            this.dgv_pro.Name = "dgv_pro";
            this.dgv_pro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_pro.Size = new System.Drawing.Size(926, 217);
            this.dgv_pro.TabIndex = 20;
            this.dgv_pro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pro_CellClick_2);
            this.dgv_pro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pro_CellContentClick_1);
            // 
            // text_qounty
            // 
            this.text_qounty.Location = new System.Drawing.Point(366, 103);
            this.text_qounty.Name = "text_qounty";
            this.text_qounty.Size = new System.Drawing.Size(142, 30);
            this.text_qounty.TabIndex = 17;
            this.text_qounty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_qounty_KeyDown);
            // 
            // text_price
            // 
            this.text_price.Location = new System.Drawing.Point(94, 103);
            this.text_price.Name = "text_price";
            this.text_price.Size = new System.Drawing.Size(117, 30);
            this.text_price.TabIndex = 18;
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(94, 48);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(117, 30);
            this.text_id.TabIndex = 19;
            this.text_id.TextChanged += new System.EventHandler(this.text_id_TextChanged);
            // 
            // text_name
            // 
            this.text_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.text_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_name.HintForeColor = System.Drawing.Color.Empty;
            this.text_name.HintText = "";
            this.text_name.isPassword = false;
            this.text_name.LineFocusedColor = System.Drawing.Color.Blue;
            this.text_name.LineIdleColor = System.Drawing.Color.Gray;
            this.text_name.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.text_name.LineThickness = 3;
            this.text_name.Location = new System.Drawing.Point(374, 46);
            this.text_name.Margin = new System.Windows.Forms.Padding(4);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(370, 32);
            this.text_name.TabIndex = 16;
            this.text_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mudir MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(514, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 35);
            this.label5.TabIndex = 11;
            this.label5.Text = "الكمية";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mudir MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(272, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 35);
            this.label4.TabIndex = 12;
            this.label4.Text = "السعر";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mudir MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(217, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 35);
            this.label2.TabIndex = 13;
            this.label2.Text = "رقم التسلسلي";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mudir MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(751, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 35);
            this.label3.TabIndex = 14;
            this.label3.Text = "نوع المنتج";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mudir MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(751, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 35);
            this.label1.TabIndex = 15;
            this.label1.Text = "اسم المنتج";
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 471);
            this.Controls.Add(this.panel_product);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Product";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            this.panel_product.ResumeLayout(false);
            this.panel_product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add_pro;
        private System.Windows.Forms.ComboBox combo_type;
        private System.Windows.Forms.TextBox text_qounty;
        private System.Windows.Forms.TextBox text_price;
        private Bunifu.Framework.UI.BunifuMaterialTextbox text_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel_product;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_pro;
        private System.Windows.Forms.Label label6;
    }
}