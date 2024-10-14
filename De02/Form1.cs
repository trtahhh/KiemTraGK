using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De02
{
    public partial class frmSanPham : Form
    {
        Model1 db;

        public frmSanPham()
        {
            InitializeComponent();
            db = new Model1();
        }

        private void ReturnToDefault()
        {
            txt_MaSP.Clear();
            txt_TenSP.Clear();
        }

        private void FillTypeProductComboBox(List<tbl_LoaiSP> listTypeProduct)
        {
            try
            {
                cb_LoaiSP.Items.Clear();
                this.cb_LoaiSP.DataSource = listTypeProduct;
                this.cb_LoaiSP.DisplayMember = "TenLoai";
                this.cb_LoaiSP.ValueMember = "MaLoai";
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Lõi khi cập nhật dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData(List<tbl_SanPham> listProduct)
        {
            try
            {
                dgv_SP.Rows.Clear();
                foreach(var item in listProduct)
                {
                    int index = dgv_SP.Rows.Add();
                    dgv_SP.Rows[index].Cells["col_TenSP"].Value = item.TenSP;
                    dgv_SP.Rows[index].Cells["col_MaSP"].Value = item.MaSP;
                    dgv_SP.Rows[index].Cells["col_NgayNhap"].Value = item.NgayNhap;
                    dgv_SP.Rows[index].Cells["col_Loai"].Value = item.tbl_LoaiSP.TenLoai;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            try
            {
                List<tbl_SanPham> listProduct = db.tbl_SanPham.ToList();
                List<tbl_LoaiSP> listTypeProduct = db.tbl_LoaiSP.ToList();
                FillTypeProductComboBox(listTypeProduct);
                LoadData(listProduct);
                btn_Save.Enabled = false;   
                btn_UnSave.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dgv_SP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_SP.Rows[e.RowIndex];
                txt_MaSP.Text = selectedRow.Cells[0].Value.ToString();
                txt_TenSP.Text = selectedRow.Cells[1].Value.ToString();
                dtp_NgayNhap.Value = (DateTime)selectedRow.Cells[2].Value;
                cb_LoaiSP.Text = selectedRow.Cells[3].Value.ToString();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_MaSP.Text) || string.IsNullOrEmpty(txt_TenSP.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txt_MaSP.Text.Length != 6)
                {
                    MessageBox.Show("Mã sản phẩm phải kéo dài 6 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                List<tbl_SanPham> listProduct = db.tbl_SanPham.ToList();
                if(listProduct.Any(p => p.MaSP == txt_MaSP.Text))
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại, vui lòng nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var newProduct = new tbl_SanPham
                {
                    MaSP = txt_MaSP.Text,
                    TenSP = txt_TenSP.Text,
                    NgayNhap = dtp_NgayNhap.Value,
                    MaLoai = cb_LoaiSP.SelectedValue.ToString(),
                };
                db.tbl_SanPham.Add(newProduct);
                db.SaveChanges();
                LoadData(db.tbl_SanPham.ToList());
                ReturnToDefault();
                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                List<tbl_SanPham> listProduct = db.tbl_SanPham.ToList();
                var product = listProduct.FirstOrDefault(p => p.MaSP == txt_MaSP.Text);
                if (product != null)
                {
                    if(listProduct.Any(p => p.MaSP == txt_MaSP.Text && p.MaSP != product.MaSP))
                    {
                        MessageBox.Show("Mã sản phẩm đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    product.TenSP = txt_TenSP.Text;
                    product.NgayNhap = dtp_NgayNhap.Value;
                    product.MaLoai = cb_LoaiSP.SelectedValue.ToString();  
                    db.SaveChanges();
                    LoadData(db.tbl_SanPham.ToList());
                    ReturnToDefault();
                    MessageBox.Show("Chỉnh sửa thông tin sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            try
            {
                List<tbl_SanPham> listProduct = db.tbl_SanPham.ToList();
                var product = listProduct.FirstOrDefault(p => p.MaSP == txt_MaSP.Text);
                if(product != null)
                {
                    var noti = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (noti == DialogResult.Yes) 
                    {
                        db.tbl_SanPham.Remove(product);
                        db.SaveChanges();
                        LoadData(db.tbl_SanPham.ToList());
                        ReturnToDefault();
                        MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch ( Exception ex ) 
            {
                MessageBox.Show($"Lỗi khi cập nhật dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            var noti = MessageBox.Show("Bạn có muốn đóng chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(noti == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string productName = txtSearch.Text.Trim().ToLower();
            foreach(DataGridViewRow row in dgv_SP.Rows)
            {
                string rowProductName = row.Cells["col_TenSP"].Value.ToString().ToLower();
                if(rowProductName.Contains(productName))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }
    }
}
