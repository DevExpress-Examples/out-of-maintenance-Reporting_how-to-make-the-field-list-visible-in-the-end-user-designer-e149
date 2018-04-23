using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UserDesigner;

namespace docEUDFieldListBringToFront {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            // Create a new design form.
            XRDesignFormEx designForm = new XRDesignFormEx();

            // Obtain the Field List and bring it to front.
            designForm.DesignDockManager[DesignDockPanelType.FieldList].Show();

            // Create a new blank report.
            designForm.DesignPanel.ExecCommand(ReportCommand.NewReport);

            // Show the design form.
            designForm.ShowDialog();
        }
    }
}