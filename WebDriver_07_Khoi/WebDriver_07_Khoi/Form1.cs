using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Keys = OpenQA.Selenium.Keys;

namespace WebDriver_07_Khoi
{
    public partial class Form_07_Khoi : Form
    {
        public Form_07_Khoi()
        {
            InitializeComponent();
        }

        private void btnLogIn_07_Khoi_Click(object sender, EventArgs e)
        {
            //Test case 1: Đăng nhập thành công 
            //IWebDriver driver_07_Khoi = new ChromeDriver();
            //driver_07_Khoi.Navigate().GoToUrl("https://auth.wikimedia.org/viwiki/wiki/%C4%90%E1%BA%B7c_bi%E1%BB%87t:%C4%90%C4%83ng_nh%E1%BA%ADp");
            //driver_07_Khoi.FindElement(By.Id("wpName1")).SendKeys("UnknowUser1205");
            //driver_07_Khoi.FindElement(By.Id("wpPassword1")).SendKeys("Sieuthongminh123");
            //driver_07_Khoi.FindElement(By.Id("wpLoginAttempt")).Click();

            //Test case 2: Đăng nhập với tên tài khoản không đúng
            //IWebDriver driver_07_Khoi = new ChromeDriver();
            //driver_07_Khoi.Navigate().GoToUrl("https://auth.wikimedia.org/viwiki/wiki/%C4%90%E1%BA%B7c_bi%E1%BB%87t:%C4%90%C4%83ng_nh%E1%BA%ADp");
            //driver_07_Khoi.FindElement(By.Id("wpName1")).SendKeys("UnknowUser");
            //driver_07_Khoi.FindElement(By.Id("wpPassword1")).SendKeys("Sieuthongminh123");
            //driver_07_Khoi.FindElement(By.Id("wpLoginAttempt")).Click();

            //Test case 3: Đăng nhập với mật khẩu không đúng
            //IWebDriver driver_07_Khoi = new ChromeDriver();
            //driver_07_Khoi.Navigate().GoToUrl("https://auth.wikimedia.org/viwiki/wiki/%C4%90%E1%BA%B7c_bi%E1%BB%87t:%C4%90%C4%83ng_nh%E1%BA%ADp");
            //driver_07_Khoi.FindElement(By.Id("wpName1")).SendKeys("UnknowUser1205");
            //driver_07_Khoi.FindElement(By.Id("wpPassword1")).SendKeys("Sieuthongminh");
            //driver_07_Khoi.FindElement(By.Id("wpLoginAttempt")).Click();

            //Test case 4: Đăng nhập khi không nhập thông tin
            IWebDriver driver_07_Khoi = new ChromeDriver();
            driver_07_Khoi.Navigate().GoToUrl("https://auth.wikimedia.org/viwiki/wiki/%C4%90%E1%BA%B7c_bi%E1%BB%87t:%C4%90%C4%83ng_nh%E1%BA%ADp");
            driver_07_Khoi.FindElement(By.Id("wpName1")).SendKeys("");
            driver_07_Khoi.FindElement(By.Id("wpPassword1")).SendKeys("");
            driver_07_Khoi.FindElement(By.Id("wpLoginAttempt")).Click();

        }


        private void btnSignUpAccount_07_Khoi_Click(object sender, EventArgs e)
        {
            //Test case 1: Điền đầy đủ thông tin
            //IWebDriver driver_07_Khoi = new ChromeDriver();
            //driver_07_Khoi.Navigate().GoToUrl("https://auth.wikimedia.org/enwiki/wiki/Special:CreateAccount?useformat=desktop&usesul3=1&returnto=Main_Page&centralauthLoginToken=98ed09989d4c40e109177c13846809bd");

            //driver_07_Khoi.FindElement(By.Id("wpName2")).SendKeys("TestUser1205");
            //driver_07_Khoi.FindElement(By.Id("wpPassword2")).SendKeys("TestPassword123!");
            //driver_07_Khoi.FindElement(By.Id("wpRetype")).SendKeys("TestPassword123!");
            //driver_07_Khoi.FindElement(By.Id("wpEmail")).SendKeys("test@example.com");

            //driver_07_Khoi.FindElement(By.Id("wpCreateaccount")).Click();

            //Test case 2: Bỏ trống các trường
            //IWebDriver driver_07_Khoi = new ChromeDriver();
            //driver_07_Khoi.Navigate().GoToUrl("https://auth.wikimedia.org/enwiki/wiki/Special:CreateAccount?useformat=desktop&usesul3=1&returnto=Main_Page&centralauthLoginToken=98ed09989d4c40e109177c13846809bd");

            //driver_07_Khoi.FindElement(By.Id("wpName2")).SendKeys("");
            //driver_07_Khoi.FindElement(By.Id("wpPassword2")).SendKeys("");
            //driver_07_Khoi.FindElement(By.Id("wpRetype")).SendKeys("");
            //driver_07_Khoi.FindElement(By.Id("wpEmail")).SendKeys("");
            //driver_07_Khoi.FindElement(By.Id("wpCreateaccount")).Click();

            //Test case 3: Nhập mật khẩu không trùng nhau
            //IWebDriver driver_07_Khoi = new ChromeDriver();
            //driver_07_Khoi.Navigate().GoToUrl("https://auth.wikimedia.org/enwiki/wiki/Special:CreateAccount?useformat=desktop&usesul3=1&returnto=Main_Page&centralauthLoginToken=98ed09989d4c40e109177c13846809bd");

            //driver_07_Khoi.FindElement(By.Id("wpName2")).SendKeys("TestUser1205");
            //driver_07_Khoi.FindElement(By.Id("wpPassword2")).SendKeys("TestPassword123!");
            //driver_07_Khoi.FindElement(By.Id("wpRetype")).SendKeys("TestPassword!");
            //driver_07_Khoi.FindElement(By.Id("wpEmail")).SendKeys("test@example.com");

            //driver_07_Khoi.FindElement(By.Id("wpCreateaccount")).Click();

            //Test case 4: Tên người dùng tồn tại
            //IWebDriver driver_07_Khoi = new ChromeDriver();
            //driver_07_Khoi.Navigate().GoToUrl("https://auth.wikimedia.org/enwiki/wiki/Special:CreateAccount?useformat=desktop&usesul3=1&returnto=Main_Page&centralauthLoginToken=98ed09989d4c40e109177c13846809bd");

            //driver_07_Khoi.FindElement(By.Id("wpName2")).SendKeys("TestUser1234567");
            //driver_07_Khoi.FindElement(By.Id("wpPassword2")).SendKeys("TestPassword123!");
            //driver_07_Khoi.FindElement(By.Id("wpRetype")).SendKeys("TestPassword123!");
            //driver_07_Khoi.FindElement(By.Id("wpEmail")).SendKeys("test@example.com");

            //driver_07_Khoi.FindElement(By.Id("wpCreateaccount")).Click();

            //Test case 5: Email sai định dạng
            //IWebDriver driver_07_Khoi = new ChromeDriver();
            //driver_07_Khoi.Navigate().GoToUrl("https://auth.wikimedia.org/enwiki/wiki/Special:CreateAccount?useformat=desktop&usesul3=1&returnto=Main_Page&centralauthLoginToken=98ed09989d4c40e109177c13846809bd");

            //driver_07_Khoi.FindElement(By.Id("wpName2")).SendKeys("TestUser1205");
            //driver_07_Khoi.FindElement(By.Id("wpPassword2")).SendKeys("TestPassword123!");
            //driver_07_Khoi.FindElement(By.Id("wpRetype")).SendKeys("TestPassword123!");
            //driver_07_Khoi.FindElement(By.Id("wpEmail")).SendKeys("TestUser");

            //driver_07_Khoi.FindElement(By.Id("wpCreateaccount")).Click();
        }
    }
}
