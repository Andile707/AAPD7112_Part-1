using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();

            //select default item
            cmbServices.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Confirm user wants to exit
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit Municipal Services?",
                "Exit Application",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            //if the user clicks yes
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (cmbServices.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please select a service.",
                    "Service Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string selectedService = cmbServices.SelectedItem.ToString();

            //if the user selects "Report an Issue" then show the form
            if (selectedService == "Report an Issue")
            {
                ReportIssueForm reportForm = new ReportIssueForm();

                this.Hide();
                reportForm.ShowDialog();
                this.Show();
            }
            else
            {
                //if the user selects the tasks that are currently unavailable
                MessageBox.Show(
                    "This service is not available yet.",
                    "Coming Soon",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
