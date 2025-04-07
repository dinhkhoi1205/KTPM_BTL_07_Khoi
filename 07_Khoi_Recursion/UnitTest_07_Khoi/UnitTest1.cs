using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _07_Khoi_Recursion;

namespace UnitTest_07_Khoi
{
    [TestClass]
    public class UnitTest1_07_Khoi
    {
        
        [TestMethod]
        //TestCase1_NhapXvaNDuong_07_Khoi cho x = 2 và n = 3 cho ra kq = 8
        public void TestCase1_NhapXvaNDuong_07_Khoi()
        {
            double expected_07_Khoi = 8.0;
            double actual_07_Khoi = Cal_Recursion_07_Khoi.Power_07_Khoi(2, 3);
            Assert.AreEqual(expected_07_Khoi, actual_07_Khoi);
        }

        [TestMethod]
        //TestCase2_NhapXvaNAm_07_Khoi cho x = 2 và n = -3 cho ra kq = 0.125
        public void TestCase2_NhapXvaNAm_07_Khoi()
        {
            double expected_07_Khoi = 0.125;
            double actual_07_Khoi = Cal_Recursion_07_Khoi.Power_07_Khoi(2, -3);
            Assert.AreEqual(expected_07_Khoi, actual_07_Khoi);
        }

        [TestMethod]
        //TestCase3_NhapNLa0_07_Khoi cho x = 2 và n = 0 cho ra kq = 1
        public void TestCase3_NhapNLa0_07_Khoi()
        {
            double expected_07_Khoi = 1.0;
            double actual_07_Khoi = Cal_Recursion_07_Khoi.Power_07_Khoi(2, 0);
            Assert.AreEqual(expected_07_Khoi, actual_07_Khoi);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        //TestCase4_NhapNLa0_07_Khoi cho x = 0 và n = -2 cho ra kq = DivideByZeroException
        public void TestCase4_TruongHopNgoaiLe_07_Khoi()
        {
            Cal_Recursion_07_Khoi.Power_07_Khoi(0, -2);
        }


        //TestCase5_DocFile_07_Khoi: Đọc file csv để test cột dữ dữ liệu gồm x_07_Khoi, n_07_Khoi, expected_07_Khoi
        public TestContext TestContext {get; set;}

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"D:\BTL_KTPM_07_Khoi\07_Khoi_Recursion\UnitTest_07_Khoi\Data_07_Khoi\TestData_07_Khoi.csv", "TestData_07_Khoi#csv",
            DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestCase5_DocFile_07_Khoi()
        {
            double x = Convert.ToDouble(TestContext.DataRow[0]);
            int n = Convert.ToInt32(TestContext.DataRow[1]);
            string expected = TestContext.DataRow[2].ToString();

            double actual = Cal_Recursion_07_Khoi.Power_07_Khoi(x, n);
            Assert.AreEqual(double.Parse(expected), actual);
        }
    }
}
