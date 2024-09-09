using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using libHinhthang;

namespace webtinhdientich
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            double a, b, h;
            string errorMessage = "";

            // Kiểm tra và chuyển đổi giá trị nhập vào từ người dùng
            if (!double.TryParse(txtA.Text, out a) || a <= 0)
            {
                errorMessage += "Đáy lớn (a) phải là số dương. ";
            }
            if (!double.TryParse(txtB.Text, out b) || b <= 0)
            {
                errorMessage += "Đáy nhỏ (b) phải là số dương. ";
            }
            if (!double.TryParse(txtH.Text, out h) || h <= 0)
            {
                errorMessage += "Chiều cao (h) phải là số dương. ";
            }

            // Nếu có lỗi, hiển thị thông báo lỗi
            if (errorMessage != "")
            {
                lblResult.Text = "Lỗi: " + errorMessage;
            }
            else
            {
                // Tính diện tích hình thang sử dụng thư viện libHinhthang
                double area = dientichthang.dientich(a, b, h);
                lblResult.Text = $"Diện tích hình thang là: {area}";
            }
        }
    }
}