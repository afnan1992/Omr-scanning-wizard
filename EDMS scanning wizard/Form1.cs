using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDMS_scanning_wizard
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			TextLabel.Text = "Welcome to DSD Omr Scanning, please click on Next" + Environment.NewLine
				+ " to begin the sheet scanning process.Press cancel to " + Environment.NewLine + " close this operation.";
			ImportantInformationLabel.Text = "It is important that you close all running applications." + Environment.NewLine
				+ "Also make sure that you have a working internet" + Environment.NewLine + "connection before starting this process";
		}

		private void ScanningWizardtabPage_Click(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
