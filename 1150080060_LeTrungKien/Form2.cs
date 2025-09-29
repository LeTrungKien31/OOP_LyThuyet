using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1150080060_LeTrungKien
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private int TinhUSCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private int TinhBSCNN(int a, int b) 
        {
            return (a * b) / TinhUSCLN(a, b);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void raUSCLN_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtA.Text.Trim());
                int b = int.Parse(txtB.Text.Trim());

                if (raUSCLN.Checked) 
                {
                    int uscln = TinhUSCLN(a, b);
                    txtKetQua.Text = "Ước số chung lớn nhất: " + uscln.ToString();
                }
                else if (raBSCNN.Checked)
                {
                    int bscnn = TinhBSCNN(a, b);
                    txtKetQua.Text = "Bội số chung nhỏ nhất: " + bscnn.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn USCLN hoặc BSCNN!");
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có thực sự muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }
    }
}
