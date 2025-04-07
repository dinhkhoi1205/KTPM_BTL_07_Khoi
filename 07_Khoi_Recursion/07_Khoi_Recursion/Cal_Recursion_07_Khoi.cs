using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Khoi_Recursion
{
    public class Cal_Recursion_07_Khoi
    {
        public static double Power_07_Khoi(double x_07_Khoi, int n_07_Khoi)
        {
            //Kiểm tra điều kiện nếu x = 0 và n < 0
            if (x_07_Khoi == 0 && n_07_Khoi < 0)
            {
                throw new DivideByZeroException("Không thể tính 0 mũ âm");
            }

            //Nếu n = 0 thì trả về kết quả là 1.0
            if (n_07_Khoi == 0)
                return 1.0;
            // Nếu n > 0
            else if (n_07_Khoi > 0)
                return x_07_Khoi * Power_07_Khoi(x_07_Khoi, n_07_Khoi - 1);
            // Nếu n < 0
            else
                return Power_07_Khoi(x_07_Khoi, n_07_Khoi + 1) / x_07_Khoi;
        }

    }
}
