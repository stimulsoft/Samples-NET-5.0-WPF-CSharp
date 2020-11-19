﻿using Stimulsoft.Report;
using Stimulsoft.Report.Design;
using Stimulsoft.Report.WpfDesign;
using System.Windows;

namespace Edit_Report_in_the_Designer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);

            InitializeComponent();

            StiWpfDesigner.SavingReport += new StiSavingObjectEventHandler(GlobalEvents_SaveReport);
        }

        private void GlobalEvents_SaveReport(object sender, StiSavingObjectEventArgs e)
        {
            var report = ((IStiDesignerBase)sender).Report;

            // How to Save
            //report.Save("Report.mrt");
            //report.SaveToJson("Report.mrt");
            //var xml = report.SaveToString();
            //var json = report.SaveToJsonString();
        }

        private void ButtonNew_Click(object sender, RoutedEventArgs e)
        {
            var report = new StiReport();
            report.DesignV2WithWpf();
        }

        private void ButtonV1_Click(object sender, RoutedEventArgs e)
        {
            var report = new StiReport();
            report.Load(@"Reports\SimpleList.mrt");
            report.DesignWithWpf();
        }

        private void ButtonV2_Click(object sender, RoutedEventArgs e)
        {
            var report = new StiReport();
            report.Load(@"Reports\SimpleList.mrt");
            report.DesignV2WithWpf();
        }

        private void ButtonControl_Click(object sender, RoutedEventArgs e)
        {
            var designerWindow = new DesignerWindow();
            designerWindow.ShowDialog();
        }
    }
}