using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Shared;

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

            LoadModules();
        }

        private void LoadModules()
        {
            foreach (var file in Directory.GetFiles(".", "*Module.dll"))
            {
                var asm = Assembly.LoadFile(Path.GetFullPath(file));
                var type = asm.GetTypes().Single(x => typeof(IModule).IsAssignableFrom(x));
                var module = (IModule)Activator.CreateInstance(type);
                uxModules.Items.Add(module.WhoAreYou());
            }
        }
    }
}