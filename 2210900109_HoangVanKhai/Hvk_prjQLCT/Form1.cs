using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hvk_prjQLCT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hoang_Van_Khai_2210900109_03DataSet.CONGTRINH_2210900109' table. You can move, or remove it, as needed.
            this.cONGTRINH_2210900109TableAdapter.Fill(this.hoang_Van_Khai_2210900109_03DataSet.CONGTRINH_2210900109);

        }

        private void TxtNKK_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                cONGTRINH2210900109BindingSource.EndEdit();
                cONGTRINH_2210900109TableAdapter.Update(hoang_Van_Khai_2210900109_03DataSet.CONGTRINH_2210900109);
                MessageBox.Show("Đã xóa dữ liệu thành công");
                dataGridView1.Refresh();
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int rowIndex = dataGridView1.CurrentRow.Index;
                DataRow row = hoang_Van_Khai_2210900109_03DataSet.CONGTRINH_2210900109.Rows[rowIndex];

                row["MaCT"] = txtMCT.Text;
                row["TenCT"] = TxtTCT.Text;
                row["NgayKC"] = TxtNKC.Text;
                row["NgayHT"] = TxtNHT.Value;
                row["DiaDiem"] = Txtdd.Text;
                row["MaPhong"] = txtMaPhong.Text;

                cONGTRINH2210900109BindingSource.EndEdit();
                cONGTRINH_2210900109TableAdapter.Update(hoang_Van_Khai_2210900109_03DataSet.CONGTRINH_2210900109);

                MessageBox.Show("Sửa thành công!");
                dataGridView1.Refresh();
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btdatlai_Click(object sender, EventArgs e)
        {
            cONGTRINH2210900109BindingSource.AddNew();
        }
    }
}
