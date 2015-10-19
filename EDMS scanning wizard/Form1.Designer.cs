namespace EDMS_scanning_wizard
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.ScanningWizardPage = new System.Windows.Forms.TabControl();
			this.ScanningWizardtabPage = new System.Windows.Forms.TabPage();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.ManualScanningtabPage = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.ScanButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.HeadingLabel = new System.Windows.Forms.Label();
			this.TextLabel = new System.Windows.Forms.Label();
			this.ImportantInformationLabel = new System.Windows.Forms.Label();
			this.ScanningWizardPage.SuspendLayout();
			this.ScanningWizardtabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// ScanningWizardPage
			// 
			this.ScanningWizardPage.Controls.Add(this.ScanningWizardtabPage);
			this.ScanningWizardPage.Controls.Add(this.ManualScanningtabPage);
			this.ScanningWizardPage.Location = new System.Drawing.Point(-4, 2);
			this.ScanningWizardPage.Name = "ScanningWizardPage";
			this.ScanningWizardPage.SelectedIndex = 0;
			this.ScanningWizardPage.Size = new System.Drawing.Size(552, 352);
			this.ScanningWizardPage.TabIndex = 0;
			// 
			// ScanningWizardtabPage
			// 
			this.ScanningWizardtabPage.Controls.Add(this.panel2);
			this.ScanningWizardtabPage.Controls.Add(this.panel1);
			this.ScanningWizardtabPage.Controls.Add(this.pictureBox1);
			this.ScanningWizardtabPage.Location = new System.Drawing.Point(4, 22);
			this.ScanningWizardtabPage.Name = "ScanningWizardtabPage";
			this.ScanningWizardtabPage.Padding = new System.Windows.Forms.Padding(3);
			this.ScanningWizardtabPage.Size = new System.Drawing.Size(544, 326);
			this.ScanningWizardtabPage.TabIndex = 0;
			this.ScanningWizardtabPage.Text = "Scanning Wizard";
			this.ScanningWizardtabPage.UseVisualStyleBackColor = true;
			this.ScanningWizardtabPage.Click += new System.EventHandler(this.ScanningWizardtabPage_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(260, 287);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// ManualScanningtabPage
			// 
			this.ManualScanningtabPage.Location = new System.Drawing.Point(4, 22);
			this.ManualScanningtabPage.Name = "ManualScanningtabPage";
			this.ManualScanningtabPage.Padding = new System.Windows.Forms.Padding(3);
			this.ManualScanningtabPage.Size = new System.Drawing.Size(453, 293);
			this.ManualScanningtabPage.TabIndex = 1;
			this.ManualScanningtabPage.Text = "Manual Scanning";
			this.ManualScanningtabPage.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.ImportantInformationLabel);
			this.panel1.Controls.Add(this.TextLabel);
			this.panel1.Controls.Add(this.HeadingLabel);
			this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel1.Location = new System.Drawing.Point(257, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(276, 283);
			this.panel1.TabIndex = 1;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.LightGray;
			this.panel2.Controls.Add(this.CancelButton);
			this.panel2.Controls.Add(this.ScanButton);
			this.panel2.Location = new System.Drawing.Point(-1, 285);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(545, 45);
			this.panel2.TabIndex = 2;
			// 
			// ScanButton
			// 
			this.ScanButton.Location = new System.Drawing.Point(348, 12);
			this.ScanButton.Name = "ScanButton";
			this.ScanButton.Size = new System.Drawing.Size(75, 23);
			this.ScanButton.TabIndex = 0;
			this.ScanButton.Text = "Scan";
			this.ScanButton.UseVisualStyleBackColor = true;
			// 
			// CancelButton
			// 
			this.CancelButton.Location = new System.Drawing.Point(442, 12);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(75, 23);
			this.CancelButton.TabIndex = 1;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			// 
			// HeadingLabel
			// 
			this.HeadingLabel.AutoSize = true;
			this.HeadingLabel.Font = new System.Drawing.Font("Times New Roman", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HeadingLabel.Location = new System.Drawing.Point(9, 15);
			this.HeadingLabel.Name = "HeadingLabel";
			this.HeadingLabel.Size = new System.Drawing.Size(209, 17);
			this.HeadingLabel.TabIndex = 0;
			this.HeadingLabel.Text = "Welcome to DSD OMR Scanning";
			// 
			// TextLabel
			// 
			this.TextLabel.AutoSize = true;
			this.TextLabel.Location = new System.Drawing.Point(12, 57);
			this.TextLabel.Name = "TextLabel";
			this.TextLabel.Size = new System.Drawing.Size(35, 13);
			this.TextLabel.TabIndex = 1;
			this.TextLabel.Text = "label1";
			// 
			// ImportantInformationLabel
			// 
			this.ImportantInformationLabel.AutoSize = true;
			this.ImportantInformationLabel.Location = new System.Drawing.Point(12, 108);
			this.ImportantInformationLabel.Name = "ImportantInformationLabel";
			this.ImportantInformationLabel.Size = new System.Drawing.Size(35, 13);
			this.ImportantInformationLabel.TabIndex = 2;
			this.ImportantInformationLabel.Text = "label1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(533, 353);
			this.Controls.Add(this.ScanningWizardPage);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Omr Scanning Wizard";
			this.ScanningWizardPage.ResumeLayout(false);
			this.ScanningWizardtabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl ScanningWizardPage;
		private System.Windows.Forms.TabPage ScanningWizardtabPage;
		private System.Windows.Forms.TabPage ManualScanningtabPage;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.Button ScanButton;
		private System.Windows.Forms.Label HeadingLabel;
		private System.Windows.Forms.Label TextLabel;
		private System.Windows.Forms.Label ImportantInformationLabel;
	}
}

