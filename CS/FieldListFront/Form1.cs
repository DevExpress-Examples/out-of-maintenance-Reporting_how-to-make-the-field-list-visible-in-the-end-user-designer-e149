using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UserDesigner;
// ...

namespace FieldListFront {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            // Create a new Design form.
            XRDesignForm designForm = new XRDesignForm();

            // Obtain the Field List and bring it to front.
            designForm.DesignDockManager[DesignDockPanelType.FieldList].Show();

            // Create a new blank report.
            designForm.OpenReport(new XtraReport1());

            // Show the Design form.
            designForm.ShowDialog();
        }

    }
}
