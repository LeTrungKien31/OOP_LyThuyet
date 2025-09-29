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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtKetQua.Clear();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

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

        private void btnCong_Click(object sender, EventArgs e)
        {
            try

            {
                double a = Convert.ToDouble(txtA.Text.Trim());
                double b = Convert.ToDouble(txtB.Text.Trim());
                double tong = a + b;
                txtKetQua.Text = tong.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi!",

                MessageBoxButtons.OKCancel);

            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            try

            {
                double a = Convert.ToDouble(txtA.Text.Trim());
                double b = Convert.ToDouble(txtB.Text.Trim());
                double hieu = a - b;
                txtKetQua.Text = hieu.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi!",

                MessageBoxButtons.OKCancel);

            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            try

            {
                double a = Convert.ToDouble(txtA.Text.Trim());
                double b = Convert.ToDouble(txtB.Text.Trim());
                double tich = a * b;
                txtKetQua.Text = tich.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi!",

                MessageBoxButtons.OKCancel);

            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            try

            {
                double a = Convert.ToDouble(txtA.Text.Trim());
                double b = Convert.ToDouble(txtB.Text.Trim());
                double thuong = a / b;
                txtKetQua.Text = thuong.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi!",

                MessageBoxButtons.OKCancel);

            }
        }
    } 
}
