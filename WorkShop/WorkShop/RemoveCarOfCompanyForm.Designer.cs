namespace WorkShop
{
    partial class RemoveCarOfCompanyForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveCarOfCompanyForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLicensePlates = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbIDCar = new System.Windows.Forms.Label();
            this.txtIDCar = new System.Windows.Forms.TextBox();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.picBackCar = new System.Windows.Forms.PictureBox();
            this.picFrontCar = new System.Windows.Forms.PictureBox();
            this.errorProviderDel = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrontCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picSearch);
            this.panel1.Controls.Add(this.lbIDCar);
            this.panel1.Controls.Add(this.txtIDCar);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.picBackCar);
            this.panel1.Controls.Add(this.picFrontCar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtColor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtLicensePlates);
            this.panel1.Location = new System.Drawing.Point(27, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 580);
            this.panel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 36;
            this.label6.Text = "Back Car:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 35;
            this.label5.Text = "Front Car:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Color:";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(212, 227);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(167, 26);
            this.txtColor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "Type:";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(212, 181);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(167, 26);
            this.txtType.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(223, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "Delete Car";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "License Plates:";
            // 
            // txtLicensePlates
            // 
            this.txtLicensePlates.Location = new System.Drawing.Point(212, 134);
            this.txtLicensePlates.Name = "txtLicensePlates";
            this.txtLicensePlates.Size = new System.Drawing.Size(167, 26);
            this.txtLicensePlates.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(212, 520);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 40);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete Car";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbIDCar
            // 
            this.lbIDCar.AutoSize = true;
            this.lbIDCar.Location = new System.Drawing.Point(109, 94);
            this.lbIDCar.Name = "lbIDCar";
            this.lbIDCar.Size = new System.Drawing.Size(55, 19);
            this.lbIDCar.TabIndex = 37;
            this.lbIDCar.Text = "ID Car:";
            // 
            // txtIDCar
            // 
            this.txtIDCar.Location = new System.Drawing.Point(212, 91);
            this.txtIDCar.Name = "txtIDCar";
            this.txtIDCar.Size = new System.Drawing.Size(88, 26);
            this.txtIDCar.TabIndex = 1;
            this.txtIDCar.TextChanged += new System.EventHandler(this.txtIDCar_TextChanged);
            // 
            // picSearch
            // 
            this.picSearch.Image = global::WorkShop.Properties.Resources.loupe_78956;
            this.picSearch.Location = new System.Drawing.Point(306, 87);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(30, 30);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearch.TabIndex = 38;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click);
            // 
            // picBackCar
            // 
            this.picBackCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picBackCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBackCar.Location = new System.Drawing.Point(286, 290);
            this.picBackCar.Name = "picBackCar";
            this.picBackCar.Size = new System.Drawing.Size(236, 210);
            this.picBackCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackCar.TabIndex = 34;
            this.picBackCar.TabStop = false;
            // 
            // picFrontCar
            // 
            this.picFrontCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picFrontCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFrontCar.Location = new System.Drawing.Point(43, 290);
            this.picFrontCar.Name = "picFrontCar";
            this.picFrontCar.Size = new System.Drawing.Size(236, 210);
            this.picFrontCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFrontCar.TabIndex = 33;
            this.picFrontCar.TabStop = false;
            // 
            // errorProviderDel
            // 
            this.errorProviderDel.ContainerControl = this;
            // 
            // RemoveCarOfCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 671);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RemoveCarOfCompanyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RemoveCarOfCompanyForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrontCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picBackCar;
        private System.Windows.Forms.PictureBox picFrontCar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLicensePlates;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lbIDCar;
        private System.Windows.Forms.TextBox txtIDCar;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.ErrorProvider errorProviderDel;
    }
}