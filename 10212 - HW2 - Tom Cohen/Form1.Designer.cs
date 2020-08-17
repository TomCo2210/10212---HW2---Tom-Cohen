namespace _10212___HW2___Tom_Cohen
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
            this.components = new System.ComponentModel.Container();
            this.DialogBTN = new System.Windows.Forms.Button();
            this.DeleteStudentBTN = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DialogBTN
            // 
            this.DialogBTN.Location = new System.Drawing.Point(12, 12);
            this.DialogBTN.Name = "DialogBTN";
            this.DialogBTN.Size = new System.Drawing.Size(120, 53);
            this.DialogBTN.TabIndex = 0;
            this.DialogBTN.Text = "Dialog";
            this.toolTip.SetToolTip(this.DialogBTN, "View Options Dialog");
            this.DialogBTN.UseVisualStyleBackColor = true;
            this.DialogBTN.Click += new System.EventHandler(this.DialogBTN_Click);
            // 
            // DeleteStudentBTN
            // 
            this.DeleteStudentBTN.Location = new System.Drawing.Point(12, 71);
            this.DeleteStudentBTN.Name = "DeleteStudentBTN";
            this.DeleteStudentBTN.Size = new System.Drawing.Size(120, 53);
            this.DeleteStudentBTN.TabIndex = 1;
            this.DeleteStudentBTN.Text = "Delete Student";
            this.toolTip.SetToolTip(this.DeleteStudentBTN, "Delete Selected Student");
            this.DeleteStudentBTN.UseVisualStyleBackColor = true;
            this.DeleteStudentBTN.Click += new System.EventHandler(this.DeleteStudentBTN_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(12, 135);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(776, 268);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._tblsBindingSource_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.DeleteStudentBTN);
            this.Controls.Add(this.DialogBTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DialogBTN;
        private System.Windows.Forms.Button DeleteStudentBTN;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

