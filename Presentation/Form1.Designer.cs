namespace Presentation
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxBirthOfYear = new System.Windows.Forms.TextBox();
            this.btnSorgu = new System.Windows.Forms.Button();
            this.pbxSonucWrong = new System.Windows.Forms.PictureBox();
            this.pbxSorguTrue = new System.Windows.Forms.PictureBox();
            this.pbxSorguQuestion = new System.Windows.Forms.PictureBox();
            this.tbxNationalIdentity = new System.Windows.Forms.MaskedTextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblTCKN = new System.Windows.Forms.Label();
            this.lblDogumYılı = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSonucWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSorguTrue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSorguQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(128, 109);
            this.tbxFirstName.MaxLength = 50;
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(199, 26);
            this.tbxFirstName.TabIndex = 0;
            this.tbxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxFirstName_KeyPress);
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(128, 141);
            this.tbxLastName.MaxLength = 50;
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(199, 26);
            this.tbxLastName.TabIndex = 1;
            this.tbxLastName.TextChanged += new System.EventHandler(this.tbxLastName_TextChanged);
            // 
            // tbxBirthOfYear
            // 
            this.tbxBirthOfYear.Location = new System.Drawing.Point(128, 205);
            this.tbxBirthOfYear.MaxLength = 4;
            this.tbxBirthOfYear.Name = "tbxBirthOfYear";
            this.tbxBirthOfYear.Size = new System.Drawing.Size(199, 26);
            this.tbxBirthOfYear.TabIndex = 3;
            // 
            // btnSorgu
            // 
            this.btnSorgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSorgu.Location = new System.Drawing.Point(128, 252);
            this.btnSorgu.Name = "btnSorgu";
            this.btnSorgu.Size = new System.Drawing.Size(104, 37);
            this.btnSorgu.TabIndex = 4;
            this.btnSorgu.Text = "Sorgula";
            this.btnSorgu.UseVisualStyleBackColor = true;
            this.btnSorgu.Click += new System.EventHandler(this.btnSorgu_Click);
            // 
            // pbxSonucWrong
            // 
            this.pbxSonucWrong.Image = ((System.Drawing.Image)(resources.GetObject("pbxSonucWrong.Image")));
            this.pbxSonucWrong.Location = new System.Drawing.Point(238, 237);
            this.pbxSonucWrong.Name = "pbxSonucWrong";
            this.pbxSonucWrong.Size = new System.Drawing.Size(64, 62);
            this.pbxSonucWrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSonucWrong.TabIndex = 5;
            this.pbxSonucWrong.TabStop = false;
            // 
            // pbxSorguTrue
            // 
            this.pbxSorguTrue.Image = ((System.Drawing.Image)(resources.GetObject("pbxSorguTrue.Image")));
            this.pbxSorguTrue.Location = new System.Drawing.Point(238, 237);
            this.pbxSorguTrue.Name = "pbxSorguTrue";
            this.pbxSorguTrue.Size = new System.Drawing.Size(64, 62);
            this.pbxSorguTrue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSorguTrue.TabIndex = 6;
            this.pbxSorguTrue.TabStop = false;
            // 
            // pbxSorguQuestion
            // 
            this.pbxSorguQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxSorguQuestion.Image = ((System.Drawing.Image)(resources.GetObject("pbxSorguQuestion.Image")));
            this.pbxSorguQuestion.Location = new System.Drawing.Point(238, 237);
            this.pbxSorguQuestion.Name = "pbxSorguQuestion";
            this.pbxSorguQuestion.Size = new System.Drawing.Size(64, 62);
            this.pbxSorguQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSorguQuestion.TabIndex = 7;
            this.pbxSorguQuestion.TabStop = false;
            // 
            // tbxNationalIdentity
            // 
            this.tbxNationalIdentity.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxNationalIdentity.Location = new System.Drawing.Point(128, 173);
            this.tbxNationalIdentity.Mask = "00000000000";
            this.tbxNationalIdentity.Name = "tbxNationalIdentity";
            this.tbxNationalIdentity.Size = new System.Drawing.Size(199, 26);
            this.tbxNationalIdentity.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(89, 115);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(33, 20);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "Ad:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(64, 147);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(58, 20);
            this.lblSoyad.TabIndex = 10;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblTCKN
            // 
            this.lblTCKN.AutoSize = true;
            this.lblTCKN.Location = new System.Drawing.Point(68, 179);
            this.lblTCKN.Name = "lblTCKN";
            this.lblTCKN.Size = new System.Drawing.Size(54, 20);
            this.lblTCKN.TabIndex = 11;
            this.lblTCKN.Text = "TCKN:";
            // 
            // lblDogumYılı
            // 
            this.lblDogumYılı.AutoSize = true;
            this.lblDogumYılı.Location = new System.Drawing.Point(33, 211);
            this.lblDogumYılı.Name = "lblDogumYılı";
            this.lblDogumYılı.Size = new System.Drawing.Size(89, 20);
            this.lblDogumYılı.TabIndex = 12;
            this.lblDogumYılı.Text = "Doğum Yılı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(97, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "TCKN DOGRULAMA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 354);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDogumYılı);
            this.Controls.Add(this.lblTCKN);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.tbxNationalIdentity);
            this.Controls.Add(this.pbxSorguQuestion);
            this.Controls.Add(this.pbxSorguTrue);
            this.Controls.Add(this.pbxSonucWrong);
            this.Controls.Add(this.btnSorgu);
            this.Controls.Add(this.tbxBirthOfYear);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.tbxFirstName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSonucWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSorguTrue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSorguQuestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxBirthOfYear;
        private System.Windows.Forms.Button btnSorgu;
        private System.Windows.Forms.PictureBox pbxSonucWrong;
        private System.Windows.Forms.PictureBox pbxSorguTrue;
        private System.Windows.Forms.PictureBox pbxSorguQuestion;
        public System.Windows.Forms.MaskedTextBox tbxNationalIdentity;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblTCKN;
        private System.Windows.Forms.Label lblDogumYılı;
        private System.Windows.Forms.Label label1;
    }
}

