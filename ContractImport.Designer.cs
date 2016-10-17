namespace WindowsFormsApplication1
{
    partial class ContractImport
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
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonImport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.companyList = new System.Windows.Forms.ComboBox();
            this.locationList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cNum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.locationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Location = new System.Drawing.Point(12, 199);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(115, 23);
            this.buttonSelectFile.TabIndex = 0;
            this.buttonSelectFile.Text = "Select File";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "No File Selected";
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(195, 199);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(115, 23);
            this.buttonImport.TabIndex = 2;
            this.buttonImport.Text = "Import";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Company";
            // 
            // companyList
            // 
            this.companyList.FormattingEnabled = true;
            this.companyList.Items.AddRange(new object[] {
            "testing",
            "testing2",
            "testing3"});
            this.companyList.Location = new System.Drawing.Point(98, 6);
            this.companyList.Name = "companyList";
            this.companyList.Size = new System.Drawing.Size(237, 21);
            this.companyList.TabIndex = 32;
            // 
            // locationList
            // 
            this.locationList.FormattingEnabled = true;
            this.locationList.Location = new System.Drawing.Point(98, 64);
            this.locationList.Name = "locationList";
            this.locationList.Size = new System.Drawing.Size(237, 108);
            this.locationList.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Customer Num";
            // 
            // cNum
            // 
            this.cNum.Location = new System.Drawing.Point(98, 37);
            this.cNum.Name = "cNum";
            this.cNum.Size = new System.Drawing.Size(61, 20);
            this.cNum.TabIndex = 35;
            this.cNum.TextChanged += new System.EventHandler(this.cnum_TextChanged);
            this.cNum.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(165, 40);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(79, 13);
            this.locationLabel.TabIndex = 37;
            this.locationLabel.Text = "Location Name";
            // 
            // ContractImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 293);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.locationList);
            this.Controls.Add(this.companyList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSelectFile);
            this.Name = "ContractImport";
            this.Text = "Contract Importing";
            this.Load += new System.EventHandler(this.ContractImport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox companyList;
        private System.Windows.Forms.ListBox locationList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label locationLabel;
    }
}