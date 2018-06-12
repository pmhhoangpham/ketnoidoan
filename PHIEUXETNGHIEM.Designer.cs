namespace QLKhamChuaBenh
{
    partial class PHIEUXETNGHIEM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PHIEUXETNGHIEM));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnthoat = new Telerik.WinControls.UI.RadButton();
            this.btncapnhat = new Telerik.WinControls.UI.RadButton();
            this.btnthem = new Telerik.WinControls.UI.RadButton();
            this.btnhuy = new Telerik.WinControls.UI.RadButton();
            this.btnluu = new Telerik.WinControls.UI.RadButton();
            this.btnxoa = new Telerik.WinControls.UI.RadButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.danhsachphieuxetnghiem = new Telerik.WinControls.UI.RadGridView();
            this.combenhnhan = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.dtngaykham = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmaphieuxetnghiem = new Telerik.WinControls.UI.RadTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnthoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncapnhat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnthem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnhuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnluu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnxoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachphieuxetnghiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachphieuxetnghiem.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combenhnhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combenhnhan.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combenhnhan.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmaphieuxetnghiem)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(562, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 110);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoat.Location = new System.Drawing.Point(279, 71);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(108, 24);
            this.btnthoat.TabIndex = 95;
            this.btnthoat.Text = "THOÁT";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btncapnhat.Location = new System.Drawing.Point(165, 25);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(108, 24);
            this.btncapnhat.TabIndex = 91;
            this.btncapnhat.Text = "CẬP NHẬT";
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthem.Location = new System.Drawing.Point(51, 25);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(108, 24);
            this.btnthem.TabIndex = 90;
            this.btnthem.Text = "THÊM MỚI";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnhuy.Location = new System.Drawing.Point(165, 71);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(108, 24);
            this.btnhuy.TabIndex = 94;
            this.btnhuy.Text = "HŨY BỎ";
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnluu.Location = new System.Drawing.Point(51, 71);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(108, 24);
            this.btnluu.TabIndex = 93;
            this.btnluu.Text = "LƯU LẠI";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnxoa.Location = new System.Drawing.Point(279, 25);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(108, 24);
            this.btnxoa.TabIndex = 92;
            this.btnxoa.Text = "XÓA BỎ";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-14, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1237, 70);
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(288, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(98, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 79;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // danhsachphieuxetnghiem
            // 
            this.danhsachphieuxetnghiem.Location = new System.Drawing.Point(25, 22);
            // 
            // 
            // 
            this.danhsachphieuxetnghiem.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.danhsachphieuxetnghiem.Name = "danhsachphieuxetnghiem";
            this.danhsachphieuxetnghiem.ReadOnly = true;
            this.danhsachphieuxetnghiem.Size = new System.Drawing.Size(771, 254);
            this.danhsachphieuxetnghiem.TabIndex = 96;
            this.danhsachphieuxetnghiem.Text = "radGridView1";
            this.danhsachphieuxetnghiem.SelectionChanged += new System.EventHandler(this.danhsachphieuxetnghiem_SelectionChanged);
            this.danhsachphieuxetnghiem.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.danhsachphieuxetnghiem_CellDoubleClick);
            // 
            // combenhnhan
            // 
            this.combenhnhan.AutoSize = true;
            // 
            // combenhnhan.NestedRadGridView
            // 
            this.combenhnhan.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.combenhnhan.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.combenhnhan.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.combenhnhan.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.combenhnhan.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.combenhnhan.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.combenhnhan.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.combenhnhan.EditorControl.MasterTemplate.EnableGrouping = false;
            this.combenhnhan.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.combenhnhan.EditorControl.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.combenhnhan.EditorControl.Name = "NestedRadGridView";
            this.combenhnhan.EditorControl.ReadOnly = true;
            this.combenhnhan.EditorControl.ShowGroupPanel = false;
            this.combenhnhan.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.combenhnhan.EditorControl.TabIndex = 0;
            this.combenhnhan.Location = new System.Drawing.Point(130, 50);
            this.combenhnhan.Name = "combenhnhan";
            this.combenhnhan.Size = new System.Drawing.Size(377, 20);
            this.combenhnhan.TabIndex = 52;
            this.combenhnhan.TabStop = false;
            this.combenhnhan.Text = "radMultiColumnComboBox1";
            // 
            // dtngaykham
            // 
            this.dtngaykham.CalendarFont = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtngaykham.CustomFormat = "MM/dd/yyyy";
            this.dtngaykham.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtngaykham.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtngaykham.Location = new System.Drawing.Point(130, 76);
            this.dtngaykham.Name = "dtngaykham";
            this.dtngaykham.Size = new System.Drawing.Size(377, 21);
            this.dtngaykham.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(20, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 50;
            this.label8.Text = "Bệnh nhân";
            // 
            // txtmaphieuxetnghiem
            // 
            this.txtmaphieuxetnghiem.ForeColor = System.Drawing.Color.Blue;
            this.txtmaphieuxetnghiem.Location = new System.Drawing.Point(130, 24);
            this.txtmaphieuxetnghiem.Name = "txtmaphieuxetnghiem";
            this.txtmaphieuxetnghiem.Size = new System.Drawing.Size(377, 20);
            this.txtmaphieuxetnghiem.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Aqua;
            this.label2.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(392, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 36);
            this.label2.TabIndex = 80;
            this.label2.Text = "PHIẾU XÉT NGHIỆM";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.combenhnhan);
            this.groupBox2.Controls.Add(this.dtngaykham);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtmaphieuxetnghiem);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(23, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(533, 110);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phiếu xét nghiệm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(20, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 50;
            this.label4.Text = "Ngày khám";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 50;
            this.label1.Text = "Mã phiếu xét nghiệm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.danhsachphieuxetnghiem);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(100, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(817, 294);
            this.groupBox3.TabIndex = 77;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách phiếu xét nghiệm";
            // 
            // PHIEUXETNGHIEM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1022, 489);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PHIEUXETNGHIEM";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHIẾU XÉT NGHIỆM";
            this.Load += new System.EventHandler(this.PHIEUXETNGHIEM_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnthoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncapnhat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnthem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnhuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnluu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnxoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachphieuxetnghiem.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachphieuxetnghiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combenhnhan.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combenhnhan.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combenhnhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmaphieuxetnghiem)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadButton btnthoat;
        private Telerik.WinControls.UI.RadButton btncapnhat;
        private Telerik.WinControls.UI.RadButton btnthem;
        private Telerik.WinControls.UI.RadButton btnhuy;
        private Telerik.WinControls.UI.RadButton btnluu;
        private Telerik.WinControls.UI.RadButton btnxoa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Telerik.WinControls.UI.RadGridView danhsachphieuxetnghiem;
        private Telerik.WinControls.UI.RadMultiColumnComboBox combenhnhan;
        private System.Windows.Forms.DateTimePicker dtngaykham;
        private System.Windows.Forms.Label label8;
        private Telerik.WinControls.UI.RadTextBox txtmaphieuxetnghiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}
