namespace Supermarket_mangement
{
    partial class store1
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
            this.panel_store = new System.Windows.Forms.Panel();
            this.dgv_store = new System.Windows.Forms.DataGridView();
            this.revresh1 = new System.Windows.Forms.Button();
            this.revresh = new System.Windows.Forms.Button();
            this.combo_cat = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_store.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_store)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_store
            // 
            this.panel_store.Controls.Add(this.dgv_store);
            this.panel_store.Controls.Add(this.revresh1);
            this.panel_store.Controls.Add(this.revresh);
            this.panel_store.Controls.Add(this.combo_cat);
            this.panel_store.Controls.Add(this.textBox1);
            this.panel_store.Controls.Add(this.label1);
            this.panel_store.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_store.Location = new System.Drawing.Point(0, 0);
            this.panel_store.Name = "panel_store";
            this.panel_store.Size = new System.Drawing.Size(982, 452);
            this.panel_store.TabIndex = 0;
            this.panel_store.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_store_Paint);
            // 
            // dgv_store
            // 
            this.dgv_store.AllowUserToAddRows = false;
            this.dgv_store.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_store.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_store.Location = new System.Drawing.Point(34, 199);
            this.dgv_store.Name = "dgv_store";
            this.dgv_store.Size = new System.Drawing.Size(873, 241);
            this.dgv_store.TabIndex = 22;
            // 
            // revresh1
            // 
            this.revresh1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.revresh1.FlatAppearance.BorderSize = 0;
            this.revresh1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.revresh1.Font = new System.Drawing.Font("Mudir MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.revresh1.ForeColor = System.Drawing.Color.White;
            this.revresh1.Location = new System.Drawing.Point(773, 116);
            this.revresh1.Name = "revresh1";
            this.revresh1.Size = new System.Drawing.Size(120, 44);
            this.revresh1.TabIndex = 20;
            this.revresh1.Text = "تحديث";
            this.revresh1.UseVisualStyleBackColor = false;
            this.revresh1.Click += new System.EventHandler(this.revresh1_Click);
            // 
            // revresh
            // 
            this.revresh.BackColor = System.Drawing.Color.LightSeaGreen;
            this.revresh.FlatAppearance.BorderSize = 0;
            this.revresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.revresh.Font = new System.Drawing.Font("Mudir MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.revresh.ForeColor = System.Drawing.Color.White;
            this.revresh.Location = new System.Drawing.Point(387, 118);
            this.revresh.Name = "revresh";
            this.revresh.Size = new System.Drawing.Size(120, 44);
            this.revresh.TabIndex = 21;
            this.revresh.Text = "تحديث";
            this.revresh.UseVisualStyleBackColor = false;
            this.revresh.Click += new System.EventHandler(this.revresh_Click);
            // 
            // combo_cat
            // 
            this.combo_cat.Font = new System.Drawing.Font("Mudir MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.combo_cat.FormattingEnabled = true;
            this.combo_cat.Location = new System.Drawing.Point(595, 117);
            this.combo_cat.Name = "combo_cat";
            this.combo_cat.Size = new System.Drawing.Size(167, 43);
            this.combo_cat.TabIndex = 19;
            this.combo_cat.SelectionChangeCommitted += new System.EventHandler(this.combo_cat_SelectionChangeCommitted);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Mudir MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox1.Location = new System.Drawing.Point(117, 118);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 44);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mudir MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(444, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 35);
            this.label1.TabIndex = 17;
            this.label1.Text = "المخازن";
            // 
            // store1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 452);
            this.Controls.Add(this.panel_store);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "store1";
            this.Text = "store1";
            this.Load += new System.EventHandler(this.store1_Load);
            this.panel_store.ResumeLayout(false);
            this.panel_store.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_store)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_store;
        private System.Windows.Forms.Button revresh1;
        private System.Windows.Forms.Button revresh;
        private System.Windows.Forms.ComboBox combo_cat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel_store;
    }
}