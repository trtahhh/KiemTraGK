namespace De02
{
    partial class frmSanPham
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
            this.lbl_DanhMucSanPham = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_UnSave = new System.Windows.Forms.Button();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.dgv_SP = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MaSP = new System.Windows.Forms.TextBox();
            this.txt_TenSP = new System.Windows.Forms.TextBox();
            this.dtp_NgayNhap = new System.Windows.Forms.DateTimePicker();
            this.cb_LoaiSP = new System.Windows.Forms.ComboBox();
            this.col_MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SP)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_DanhMucSanPham
            // 
            this.lbl_DanhMucSanPham.AutoSize = true;
            this.lbl_DanhMucSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DanhMucSanPham.Location = new System.Drawing.Point(209, 25);
            this.lbl_DanhMucSanPham.Name = "lbl_DanhMucSanPham";
            this.lbl_DanhMucSanPham.Size = new System.Drawing.Size(409, 39);
            this.lbl_DanhMucSanPham.TabIndex = 0;
            this.lbl_DanhMucSanPham.Text = "DANH MỤC SẢN PHẨM";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(76, 102);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(202, 99);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(86, 404);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(187, 404);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(71, 23);
            this.btn_Edit.TabIndex = 4;
            this.btn_Edit.Text = "Sửa";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(287, 404);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(75, 23);
            this.btn_Del.TabIndex = 5;
            this.btn_Del.Text = "Xóa";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(385, 404);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_UnSave
            // 
            this.btn_UnSave.Location = new System.Drawing.Point(485, 404);
            this.btn_UnSave.Name = "btn_UnSave";
            this.btn_UnSave.Size = new System.Drawing.Size(75, 23);
            this.btn_UnSave.TabIndex = 7;
            this.btn_UnSave.Text = "Không lưu";
            this.btn_UnSave.UseVisualStyleBackColor = true;
            // 
            // btn_Quit
            // 
            this.btn_Quit.Location = new System.Drawing.Point(584, 404);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(75, 23);
            this.btn_Quit.TabIndex = 8;
            this.btn_Quit.Text = "Thoát";
            this.btn_Quit.UseVisualStyleBackColor = true;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // dgv_SP
            // 
            this.dgv_SP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaSP,
            this.col_TenSP,
            this.col_NgayNhap,
            this.col_Loai});
            this.dgv_SP.Location = new System.Drawing.Point(31, 140);
            this.dgv_SP.Name = "dgv_SP";
            this.dgv_SP.Size = new System.Drawing.Size(397, 236);
            this.dgv_SP.TabIndex = 9;
            this.dgv_SP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SP_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã SP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên SP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ngày nhập:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Loại SP:";
            // 
            // txt_MaSP
            // 
            this.txt_MaSP.Location = new System.Drawing.Point(518, 162);
            this.txt_MaSP.Name = "txt_MaSP";
            this.txt_MaSP.Size = new System.Drawing.Size(200, 20);
            this.txt_MaSP.TabIndex = 14;
            // 
            // txt_TenSP
            // 
            this.txt_TenSP.Location = new System.Drawing.Point(518, 208);
            this.txt_TenSP.Name = "txt_TenSP";
            this.txt_TenSP.Size = new System.Drawing.Size(200, 20);
            this.txt_TenSP.TabIndex = 15;
            // 
            // dtp_NgayNhap
            // 
            this.dtp_NgayNhap.Location = new System.Drawing.Point(518, 249);
            this.dtp_NgayNhap.Name = "dtp_NgayNhap";
            this.dtp_NgayNhap.Size = new System.Drawing.Size(200, 20);
            this.dtp_NgayNhap.TabIndex = 16;
            // 
            // cb_LoaiSP
            // 
            this.cb_LoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_LoaiSP.FormattingEnabled = true;
            this.cb_LoaiSP.Location = new System.Drawing.Point(518, 299);
            this.cb_LoaiSP.Name = "cb_LoaiSP";
            this.cb_LoaiSP.Size = new System.Drawing.Size(200, 21);
            this.cb_LoaiSP.TabIndex = 17;
            // 
            // col_MaSP
            // 
            this.col_MaSP.HeaderText = "Mã SP";
            this.col_MaSP.Name = "col_MaSP";
            // 
            // col_TenSP
            // 
            this.col_TenSP.HeaderText = "Tên SP";
            this.col_TenSP.Name = "col_TenSP";
            // 
            // col_NgayNhap
            // 
            this.col_NgayNhap.HeaderText = "Ngày nhập";
            this.col_NgayNhap.Name = "col_NgayNhap";
            // 
            // col_Loai
            // 
            this.col_Loai.HeaderText = "Loại";
            this.col_Loai.Name = "col_Loai";
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_LoaiSP);
            this.Controls.Add(this.dtp_NgayNhap);
            this.Controls.Add(this.txt_TenSP);
            this.Controls.Add(this.txt_MaSP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_SP);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.btn_UnSave);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lbl_DanhMucSanPham);
            this.Name = "frmSanPham";
            this.Text = "QUẢN LÝ SẢN PHẨM";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_DanhMucSanPham;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_UnSave;
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.DataGridView dgv_SP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_MaSP;
        private System.Windows.Forms.TextBox txt_TenSP;
        private System.Windows.Forms.DateTimePicker dtp_NgayNhap;
        private System.Windows.Forms.ComboBox cb_LoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Loai;
    }
}

