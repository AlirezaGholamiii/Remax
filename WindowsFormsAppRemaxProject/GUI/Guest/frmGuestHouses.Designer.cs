namespace WindowsFormsAppRemaxProject
{
    partial class frmGuestHouses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuestHouses));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.datagridAllHouses = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cboPrice = new System.Windows.Forms.ComboBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.checkPrice = new System.Windows.Forms.CheckBox();
            this.checkPropertyType = new System.Windows.Forms.CheckBox();
            this.btnSerach = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.cboBedrooms = new System.Windows.Forms.ComboBox();
            this.cboNeighbourhood = new System.Windows.Forms.ComboBox();
            this.checkBedrooms = new System.Windows.Forms.CheckBox();
            this.checkNeighbourhood = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridAllHouses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(73, 227);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Size = new System.Drawing.Size(73, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.datagridAllHouses);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Location = new System.Drawing.Point(53, 260);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1134, 484);
            this.panel2.TabIndex = 28;
            // 
            // datagridAllHouses
            // 
            this.datagridAllHouses.AllowUserToAddRows = false;
            this.datagridAllHouses.AllowUserToDeleteRows = false;
            this.datagridAllHouses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridAllHouses.BackgroundColor = System.Drawing.Color.White;
            this.datagridAllHouses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridAllHouses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.datagridAllHouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridAllHouses.Location = new System.Drawing.Point(-1, 36);
            this.datagridAllHouses.MultiSelect = false;
            this.datagridAllHouses.Name = "datagridAllHouses";
            this.datagridAllHouses.ReadOnly = true;
            this.datagridAllHouses.RowHeadersWidth = 45;
            this.datagridAllHouses.RowTemplate.Height = 24;
            this.datagridAllHouses.Size = new System.Drawing.Size(1134, 447);
            this.datagridAllHouses.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label17.Location = new System.Drawing.Point(94, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 21);
            this.label17.TabIndex = 0;
            this.label17.Text = "All Houses";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.DarkGray;
            this.label13.Location = new System.Drawing.Point(431, 822);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(270, 3);
            this.label13.TabIndex = 30;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(262, 73);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox5.Size = new System.Drawing.Size(73, 67);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 50;
            this.pictureBox5.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cboPrice);
            this.panel4.Controls.Add(this.cboType);
            this.panel4.Controls.Add(this.checkPrice);
            this.panel4.Controls.Add(this.checkPropertyType);
            this.panel4.Controls.Add(this.btnSerach);
            this.panel4.Controls.Add(this.label29);
            this.panel4.Controls.Add(this.cboBedrooms);
            this.panel4.Controls.Add(this.cboNeighbourhood);
            this.panel4.Controls.Add(this.checkBedrooms);
            this.panel4.Controls.Add(this.checkNeighbourhood);
            this.panel4.Location = new System.Drawing.Point(247, 115);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(937, 135);
            this.panel4.TabIndex = 49;
            // 
            // cboPrice
            // 
            this.cboPrice.FormattingEnabled = true;
            this.cboPrice.Location = new System.Drawing.Point(562, 89);
            this.cboPrice.Name = "cboPrice";
            this.cboPrice.Size = new System.Drawing.Size(99, 24);
            this.cboPrice.TabIndex = 40;
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(562, 51);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(178, 24);
            this.cboType.TabIndex = 39;
            // 
            // checkPrice
            // 
            this.checkPrice.AutoSize = true;
            this.checkPrice.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPrice.ForeColor = System.Drawing.Color.DimGray;
            this.checkPrice.Location = new System.Drawing.Point(405, 90);
            this.checkPrice.Name = "checkPrice";
            this.checkPrice.Size = new System.Drawing.Size(151, 23);
            this.checkPrice.TabIndex = 38;
            this.checkPrice.Text = "By Minimum Price";
            this.checkPrice.UseVisualStyleBackColor = true;
            this.checkPrice.CheckedChanged += new System.EventHandler(this.checkPrice_CheckedChanged);
            // 
            // checkPropertyType
            // 
            this.checkPropertyType.AutoSize = true;
            this.checkPropertyType.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPropertyType.ForeColor = System.Drawing.Color.DimGray;
            this.checkPropertyType.Location = new System.Drawing.Point(405, 51);
            this.checkPropertyType.Name = "checkPropertyType";
            this.checkPropertyType.Size = new System.Drawing.Size(144, 23);
            this.checkPropertyType.TabIndex = 37;
            this.checkPropertyType.Text = "By Property Type";
            this.checkPropertyType.UseVisualStyleBackColor = true;
            this.checkPropertyType.CheckedChanged += new System.EventHandler(this.checkPropertyType_CheckedChanged);
            // 
            // btnSerach
            // 
            this.btnSerach.BackColor = System.Drawing.Color.Firebrick;
            this.btnSerach.FlatAppearance.BorderSize = 0;
            this.btnSerach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerach.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerach.ForeColor = System.Drawing.Color.White;
            this.btnSerach.Location = new System.Drawing.Point(804, 66);
            this.btnSerach.Name = "btnSerach";
            this.btnSerach.Size = new System.Drawing.Size(124, 36);
            this.btnSerach.TabIndex = 36;
            this.btnSerach.Text = "Search";
            this.btnSerach.UseVisualStyleBackColor = false;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label29.Location = new System.Drawing.Point(95, 3);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(156, 21);
            this.label29.TabIndex = 35;
            this.label29.Text = "Filter Your Search ";
            // 
            // cboBedrooms
            // 
            this.cboBedrooms.FormattingEnabled = true;
            this.cboBedrooms.Location = new System.Drawing.Point(182, 90);
            this.cboBedrooms.Name = "cboBedrooms";
            this.cboBedrooms.Size = new System.Drawing.Size(99, 24);
            this.cboBedrooms.TabIndex = 26;
            // 
            // cboNeighbourhood
            // 
            this.cboNeighbourhood.FormattingEnabled = true;
            this.cboNeighbourhood.Location = new System.Drawing.Point(182, 49);
            this.cboNeighbourhood.Name = "cboNeighbourhood";
            this.cboNeighbourhood.Size = new System.Drawing.Size(178, 24);
            this.cboNeighbourhood.TabIndex = 25;
            // 
            // checkBedrooms
            // 
            this.checkBedrooms.AutoSize = true;
            this.checkBedrooms.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBedrooms.ForeColor = System.Drawing.Color.DimGray;
            this.checkBedrooms.Location = new System.Drawing.Point(12, 90);
            this.checkBedrooms.Name = "checkBedrooms";
            this.checkBedrooms.Size = new System.Drawing.Size(127, 23);
            this.checkBedrooms.TabIndex = 24;
            this.checkBedrooms.Text = "By Bed Rooms";
            this.checkBedrooms.UseVisualStyleBackColor = true;
            this.checkBedrooms.CheckedChanged += new System.EventHandler(this.checkBedrooms_CheckedChanged);
            // 
            // checkNeighbourhood
            // 
            this.checkNeighbourhood.AutoSize = true;
            this.checkNeighbourhood.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNeighbourhood.ForeColor = System.Drawing.Color.DimGray;
            this.checkNeighbourhood.Location = new System.Drawing.Point(12, 51);
            this.checkNeighbourhood.Name = "checkNeighbourhood";
            this.checkNeighbourhood.Size = new System.Drawing.Size(160, 23);
            this.checkNeighbourhood.TabIndex = 23;
            this.checkNeighbourhood.Text = "By Neighbourhood";
            this.checkNeighbourhood.UseVisualStyleBackColor = true;
            this.checkNeighbourhood.CheckedChanged += new System.EventHandler(this.checkNeighbourhood_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(887, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 47);
            this.panel1.TabIndex = 48;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.DimGray;
            this.textBox2.Location = new System.Drawing.Point(40, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(249, 19);
            this.textBox2.TabIndex = 22;
            this.textBox2.Text = "Search House By ID";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 1);
            this.label1.TabIndex = 21;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // frmGuestHouses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1223, 830);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGuestHouses";
            this.Text = "Guest - Houses";
            this.Load += new System.EventHandler(this.frmGuestHouses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridAllHouses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cboPrice;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.CheckBox checkPrice;
        private System.Windows.Forms.CheckBox checkPropertyType;
        private System.Windows.Forms.Button btnSerach;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox cboBedrooms;
        private System.Windows.Forms.ComboBox cboNeighbourhood;
        private System.Windows.Forms.CheckBox checkBedrooms;
        private System.Windows.Forms.CheckBox checkNeighbourhood;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView datagridAllHouses;
    }
}