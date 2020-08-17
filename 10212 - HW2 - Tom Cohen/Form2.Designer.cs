namespace _10212___HW2___Tom_Cohen
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.ABTN = new System.Windows.Forms.Button();
            this.BBTN = new System.Windows.Forms.Button();
            this.CBTN = new System.Windows.Forms.Button();
            this.DBTN = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.OkBTN = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // ABTN
            // 
            this.ABTN.Location = new System.Drawing.Point(12, 12);
            this.ABTN.Name = "ABTN";
            this.ABTN.Size = new System.Drawing.Size(75, 23);
            this.ABTN.TabIndex = 0;
            this.ABTN.Text = "A";
            this.toolTip.SetToolTip(this.ABTN, "Query Courses by Lecturer\'s ID");
            this.ABTN.UseVisualStyleBackColor = true;
            this.ABTN.Click += new System.EventHandler(this.ABTN_Click);
            // 
            // BBTN
            // 
            this.BBTN.Location = new System.Drawing.Point(93, 12);
            this.BBTN.Name = "BBTN";
            this.BBTN.Size = new System.Drawing.Size(75, 23);
            this.BBTN.TabIndex = 1;
            this.BBTN.Text = "B";
            this.toolTip.SetToolTip(this.BBTN, "Query All Students by Name");
            this.BBTN.UseVisualStyleBackColor = true;
            this.BBTN.Click += new System.EventHandler(this.BBTN_Click);
            // 
            // CBTN
            // 
            this.CBTN.Location = new System.Drawing.Point(174, 12);
            this.CBTN.Name = "CBTN";
            this.CBTN.Size = new System.Drawing.Size(75, 23);
            this.CBTN.TabIndex = 2;
            this.CBTN.Text = "C";
            this.toolTip.SetToolTip(this.CBTN, "Query Studnets List by Courses Amount");
            this.CBTN.UseVisualStyleBackColor = true;
            this.CBTN.Click += new System.EventHandler(this.CBTN_Click);
            // 
            // DBTN
            // 
            this.DBTN.Location = new System.Drawing.Point(255, 12);
            this.DBTN.Name = "DBTN";
            this.DBTN.Size = new System.Drawing.Size(75, 23);
            this.DBTN.TabIndex = 3;
            this.DBTN.Text = "D";
            this.toolTip.SetToolTip(this.DBTN, "Query Studnets by Age");
            this.DBTN.UseVisualStyleBackColor = true;
            this.DBTN.Click += new System.EventHandler(this.DBTN_Click);
            // 
            // textBox
            // 
            this.textBox.Enabled = false;
            this.textBox.Location = new System.Drawing.Point(12, 41);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(318, 20);
            this.textBox.TabIndex = 4;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(12, 67);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(316, 21);
            this.comboBox.TabIndex = 5;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            this.comboBox.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
            // 
            // OkBTN
            // 
            this.OkBTN.Location = new System.Drawing.Point(133, 94);
            this.OkBTN.Name = "OkBTN";
            this.OkBTN.Size = new System.Drawing.Size(75, 23);
            this.OkBTN.TabIndex = 6;
            this.OkBTN.Text = "OK";
            this.OkBTN.UseVisualStyleBackColor = true;
            this.OkBTN.Click += new System.EventHandler(this.OkBTN_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 129);
            this.Controls.Add(this.OkBTN);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.DBTN);
            this.Controls.Add(this.CBTN);
            this.Controls.Add(this.BBTN);
            this.Controls.Add(this.ABTN);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ABTN;
        private System.Windows.Forms.Button BBTN;
        private System.Windows.Forms.Button CBTN;
        private System.Windows.Forms.Button DBTN;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button OkBTN;
        private System.Windows.Forms.ToolTip toolTip;
    }
}