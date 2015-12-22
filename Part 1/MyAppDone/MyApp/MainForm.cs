using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace MyApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            uxProduct.Text = Assembly.GetEntryAssembly().GetCustomAttributes<AssemblyProductAttribute>().First().Product;
            uxVersion.Text = Assembly.GetEntryAssembly().GetName().Version.ToString();
            uxCompany.Text = Assembly.GetEntryAssembly().GetCustomAttributes<AssemblyCompanyAttribute>().First().Company;
        }
    }
}