namespace WorkShop
{
    partial class ListCarRentUCForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvCarRent = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ckbColor = new System.Windows.Forms.CheckBox();
            this.txtColorCar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ckbType = new System.Windows.Forms.CheckBox();
            this.txtTypeCar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCarRent)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvCarRent);
            this.panel1.Location = new System.Drawing.Point(13, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 546);
            this.panel1.TabIndex = 0;
            // 
            // dtgvCarRent
            // 
            this.dtgvCarRent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCarRent.BackgroundColor = System.Drawing.Color.White;
            this.dtgvCarRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCarRent.Location = new System.Drawing.Point(4, 3);
            this.dtgvCarRent.Name = "dtgvCarRent";
            this.dtgvCarRent.Size = new System.Drawing.Size(563, 538);
            this.dtgvCarRent.TabIndex = 5;
            this.dtgvCarRent.DoubleClick += new System.EventHandler(this.dtgvCarRent_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(17, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(562, 36);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ckbColor);
            this.panel4.Controls.Add(this.txtColorCar);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(298, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 33);
            this.panel4.TabIndex = 11;
            // 
            // ckbColor
            // 
            this.ckbColor.AutoSize = true;
            this.ckbColor.Location = new System.Drawing.Point(180, 9);
            this.ckbColor.Name = "ckbColor";
            this.ckbColor.Size = new System.Drawing.Size(15, 14);
            this.ckbColor.TabIndex = 6;
            this.ckbColor.UseVisualStyleBackColor = true;
            this.ckbColor.CheckedChanged += new System.EventHandler(this.ckbColor_CheckedChanged);
            // 
            // txtColorCar
            // 
            this.txtColorCar.Location = new System.Drawing.Point(74, 3);
            this.txtColorCar.Name = "txtColorCar";
            this.txtColorCar.Size = new System.Drawing.Size(100, 26);
            this.txtColorCar.TabIndex = 7;
            this.txtColorCar.TextChanged += new System.EventHandler(this.txtColorCar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Color:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ckbType);
            this.panel3.Controls.Add(this.txtTypeCar);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(52, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 33);
            this.panel3.TabIndex = 6;
            // 
            // ckbType
            // 
            this.ckbType.AutoSize = true;
            this.ckbType.Location = new System.Drawing.Point(182, 11);
            this.ckbType.Name = "ckbType";
            this.ckbType.Size = new System.Drawing.Size(15, 14);
            this.ckbType.TabIndex = 7;
            this.ckbType.UseVisualStyleBackColor = true;
            this.ckbType.CheckedChanged += new System.EventHandler(this.ckbType_CheckedChanged);
            // 
            // txtTypeCar
            // 
            this.txtTypeCar.Location = new System.Drawing.Point(76, 3);
            this.txtTypeCar.Name = "txtTypeCar";
            this.txtTypeCar.Size = new System.Drawing.Size(100, 26);
            this.txtTypeCar.TabIndex = 6;
            this.txtTypeCar.TextChanged += new System.EventHandler(this.txtTypeCar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Type Car:";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Yellow;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(455, 607);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(124, 40);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Location = new System.Drawing.Point(325, 607);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(124, 40);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // ListCarRentUCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListCarRentUCForm";
            this.Size = new System.Drawing.Size(600, 650);
            this.Load += new System.EventHandler(this.ListCarRentUCForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCarRent)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvCarRent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTypeCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtColorCar;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.CheckBox ckbColor;
        private System.Windows.Forms.CheckBox ckbType;
    }
}
