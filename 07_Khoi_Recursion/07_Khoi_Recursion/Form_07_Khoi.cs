using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_Khoi_Recursion
{
    public partial class Form_07_Khoi : Form
    {
        public Form_07_Khoi()
        {
            InitializeComponent();
        }

        private void btnTinhToan_07_Khoi_Click(object sender, EventArgs e)
        {
            double x_07_Khoi;
            int n_07_Khoi;

            // Kiểm tra giá trị nhập vào
            if (!double.TryParse(txtNhapX_07_Khoi.Text, out x_07_Khoi))
            {
                MessageBox.Show("Giá trị x không hợp lệ. Vui lòng nhập số thực.");
                return;
            }

            if (!int.TryParse(txtNhapN_07_Khoi.Text, out n_07_Khoi))
            {
                MessageBox.Show("Giá trị n không hợp lệ. Vui lòng nhập số nguyên.");
                return;
            }


            try
            {
                double result_07_Khoi = Cal_Recursion_07_Khoi.Power_07_Khoi(x_07_Khoi, n_07_Khoi);
                txtKetQua_07_Khoi.Text = result_07_Khoi.ToString();
            } catch (DivideByZeroException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
