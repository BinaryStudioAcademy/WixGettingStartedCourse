using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using log4net;
using Shared;

namespace MyApp
{
    public partial class MainForm : Form
    {
        private readonly ILog logger = LogManager.GetLogger(typeof(MainForm));

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            logger.Info("Loading assembly info...");
            uxProduct.Text = Assembly.GetEntryAssembly().GetCustomAttributes<AssemblyProductAttribute>().First().Product;
            logger.Info("Product = " + uxProduct.Text);
            uxVersion.Text = Assembly.GetEntryAssembly().GetName().Version.ToString();
            logger.Info("Version = " + uxVersion.Text);
            uxCompany.Text = Assembly.GetEntryAssembly().GetCustomAttributes<AssemblyCompanyAttribute>().First().Company;
            logger.Info("Company = " + uxCompany.Text);

            LoadModules();
            logger.Info("Loaded.");
        }

        private void LoadModules()
        {
            logger.Info("Loading modules...");
            foreach (var file in Directory.GetFiles(@"Modules", "*Module.dll"))
            {
                logger.Info("Loading file: " + file);
                try
                {
                    var asm = Assembly.LoadFile(Path.GetFullPath(file));
                    var type = asm.GetTypes().Single(x => typeof(IModule).IsAssignableFrom(x));
                    var module = (IModule)Activator.CreateInstance(type);
                    uxModules.Items.Add(module.WhoAreYou());
                    logger.Info("Loaded file: " + file);
                }
                catch (Exception e)
                {
                    logger.Error("Exception during file loading", e);
                }
            }
        }
    }
}