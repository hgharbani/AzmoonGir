using nucs.JsonSettings;
using nucs.JsonSettings.Fluent;
using System;
using System.Windows.Forms;

namespace AzmoonGir
{
    public partial class Form1 : Form
    {
        private SettingsBag settings { get; } =
            JsonSettings.Construct<SettingsBag>(AppConfigration.FileName+@"\Config.json").EnableAutosave().LoadNow();

        public Form1()
        {
            InitializeComponent();
            settings["azmoongir"] = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}