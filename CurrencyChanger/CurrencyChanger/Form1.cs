using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyChanger
{
    public partial class CurrencyForm : Form
    {
        public CurrencyForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com/search?q=currency+converter&oq=curreny+conver&aqs=chrome.1.69i57j0i10i433j0i10l6.8544j1j9&sourceid=chrome&ie=UTF-8");
        }
    }
}
