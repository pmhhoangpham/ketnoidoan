namespace QLKhamChuaBenh
{
    partial class BENH
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BENH));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.danhsachbenh = new Telerik.WinControls.UI.RadGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnthoat = new Telerik.WinControls.UI.RadButton();
            this.btncapnhat = new Telerik.WinControls.UI.RadButton();
            this.btnthem = new Telerik.WinControls.UI.RadButton();
            this.btnhuy = new Telerik.WinControls.UI.RadButton();
            this.btnluu = new Telerik.WinControls.UI.RadButton();
            this.btnxoa = new Telerik.WinControls.UI.RadButton();
            this.txtmabenh = new Telerik.WinControls.UI.RadTextBox();
            this.txttenbenh = new Telerik.WinControls.UI.RadTextBox();
            this.txttrieuchung = new Telerik.WinControls.UI.RadTextBox();
            this.txtghichu = new Telerik.WinControls.UI.RadTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kiemtrathongtin = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachbenh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachbenh.MasterTemplate)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnthoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncapnhat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnthem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnhuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnluu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnxoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmabenh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenbenh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttrieuchung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtghichu)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiemtrathongtin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.danhsachbenh);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(27, 221);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(590, 196);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách bệnh";
            // 
            // danhsachbenh
            // 
            this.danhsachbenh.Location = new System.Drawing.Point(17, 20);
            // 
            // 
            // 
            this.danhsachbenh.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.danhsachbenh.Name = "danhsachbenh";
            this.danhsachbenh.ReadOnly = true;
            this.danhsachbenh.Size = new System.Drawing.Size(556, 168);
            this.danhsachbenh.TabIndex = 0;
            this.danhsachbenh.Text = "radGridView1";
            this.danhsachbenh.SelectionChanged += new System.EventHandler(this.danhsachbenh_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Controls.Add(this.btncapnhat);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.btnhuy);
            this.groupBox1.Controls.Add(this.btnluu);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(27, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 63);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoat.Location = new System.Drawing.Point(454, 22);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(72, 24);
            this.btnthoat.TabIndex = 57;
            this.btnthoat.Text = "THOÁT";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btncapnhat.Location = new System.Drawing.Point(142, 22);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(72, 24);
            this.btncapnhat.TabIndex = 59;
            this.btncapnhat.Text = "CẬP NHẬT";
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthem.Location = new System.Drawing.Point(64, 22);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(72, 24);
            this.btnthem.TabIndex = 55;
            this.btnthem.Text = "THÊM MỚI";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnhuy.Location = new System.Drawing.Point(376, 22);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(72, 24);
            this.btnhuy.TabIndex = 60;
            this.btnhuy.Text = "HŨY BỎ";
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnluu.Location = new System.Drawing.Point(298, 22);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(72, 24);
            this.btnluu.TabIndex = 56;
            this.btnluu.Text = "LƯU LẠI";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnxoa.Location = new System.Drawing.Point(220, 22);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(72, 24);
            this.btnxoa.TabIndex = 58;
            this.btnxoa.Text = "XÓA BỎ";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // txtmabenh
            // 
            this.txtmabenh.ForeColor = System.Drawing.Color.Blue;
            this.txtmabenh.Location = new System.Drawing.Point(100, 22);
            this.txtmabenh.Name = "txtmabenh";
            this.txtmabenh.Size = new System.Drawing.Size(151, 20);
            this.txtmabenh.TabIndex = 49;
            // 
            // txttenbenh
            // 
            this.txttenbenh.ForeColor = System.Drawing.Color.Blue;
            this.txttenbenh.Location = new System.Drawing.Point(100, 48);
            this.txttenbenh.Name = "txttenbenh";
            this.txttenbenh.Size = new System.Drawing.Size(151, 20);
            this.txttenbenh.TabIndex = 49;
            // 
            // txttrieuchung
            // 
            this.txttrieuchung.ForeColor = System.Drawing.Color.Blue;
            this.txttrieuchung.Location = new System.Drawing.Point(409, 22);
            this.txttrieuchung.Name = "txttrieuchung";
            this.txttrieuchung.Size = new System.Drawing.Size(151, 20);
            this.txttrieuchung.TabIndex = 49;
            // 
            // txtghichu
            // 
            this.txtghichu.ForeColor = System.Drawing.Color.Blue;
            this.txtghichu.Location = new System.Drawing.Point(409, 48);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(151, 20);
            this.txtghichu.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 50;
            this.label1.Text = "Mã Bệnh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(23, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 50;
            this.label3.Text = "Tên Bệnh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(330, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 50;
            this.label4.Text = "Triệu chứng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(330, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 50;
            this.label5.Text = "Ghi chú";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtghichu);
            this.groupBox2.Controls.Add(this.txttenbenh);
            this.groupBox2.Controls.Add(this.txttrieuchung);
            this.groupBox2.Controls.Add(this.txtmabenh);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(27, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(590, 87);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin bệnh";
            // 
            // kiemtrathongtin
            // 
            this.kiemtrathongtin.ContainerControl = this;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(211, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(98, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 82;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Aqua;
            this.label2.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(315, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 36);
            this.label2.TabIndex = 83;
            this.label2.Text = "BỆNH";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-250, -16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1237, 70);
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // BENH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(645, 434);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BENH";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ BỆNH";
            this.Load += new System.EventHandler(this.BENH_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.danhsachbenh.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachbenh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnthoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncapnhat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnthem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnhuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnluu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnxoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmabenh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenbenh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttrieuchung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtghichu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiemtrathongtin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadButton btnthoat;
        private Telerik.WinControls.UI.RadButton btncapnhat;
        private Telerik.WinControls.UI.RadButton btnthem;
        private Telerik.WinControls.UI.RadButton btnhuy;
        private Telerik.WinControls.UI.RadButton btnluu;
        private Telerik.WinControls.UI.RadButton btnxoa;
        private Telerik.WinControls.UI.RadTextBox txtmabenh;
        private Telerik.WinControls.UI.RadTextBox txttenbenh;
        private Telerik.WinControls.UI.RadTextBox txttrieuchung;
        private Telerik.WinControls.UI.RadTextBox txtghichu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private Telerik.WinControls.UI.RadGridView danhsachbenh;
        private System.Windows.Forms.ErrorProvider kiemtrathongtin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
