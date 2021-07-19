namespace WorkShop
{
    partial class AddCarRentUCForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picBackCar = new System.Windows.Forms.PictureBox();
            this.picFrontCar = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLicensePlates = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.pnlNextPage = new System.Windows.Forms.Panel();
            this.errorProviderAddCar = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrontCar)).BeginInit();
            this.pnlNextPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddCar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
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
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 580);
            this.panel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(212, 520);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 40);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Car";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.picBackCar.Click += new System.EventHandler(this.pictureBox2_Click);
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
            this.picFrontCar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Color:";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(212, 196);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(167, 26);
            this.txtColor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "Type:";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(212, 150);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(167, 26);
            this.txtType.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(182, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "Information Car";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "License Plates:";
            // 
            // txtLicensePlates
            // 
            this.txtLicensePlates.Location = new System.Drawing.Point(212, 103);
            this.txtLicensePlates.Name = "txtLicensePlates";
            this.txtLicensePlates.Size = new System.Drawing.Size(167, 26);
            this.txtLicensePlates.TabIndex = 1;
            this.txtLicensePlates.TextChanged += new System.EventHandler(this.txtLicensePlates_TextChanged);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Location = new System.Drawing.Point(5, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(124, 40);
            this.btnPrevious.TabIndex = 6;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Yellow;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(135, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(124, 40);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pnlNextPage
            // 
            this.pnlNextPage.Controls.Add(this.btnPrevious);
            this.pnlNextPage.Controls.Add(this.btnNext);
            this.pnlNextPage.Location = new System.Drawing.Point(325, 600);
            this.pnlNextPage.Name = "pnlNextPage";
            this.pnlNextPage.Size = new System.Drawing.Size(265, 49);
            this.pnlNextPage.TabIndex = 1;
            // 
            // errorProviderAddCar
            // 
            this.errorProviderAddCar.ContainerControl = this;
            // 
            // AddCarRentUCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlNextPage);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddCarRentUCForm";
            this.Size = new System.Drawing.Size(600, 650);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrontCar)).EndInit();
            this.pnlNextPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtLicensePlates;
        private System.Windows.Forms.Panel pnlNextPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picBackCar;
        private System.Windows.Forms.PictureBox picFrontCar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errorProviderAddCar;
    }
}
