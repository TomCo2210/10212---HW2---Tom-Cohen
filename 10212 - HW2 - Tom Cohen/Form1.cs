using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10212___HW2___Tom_Cohen
{
    public partial class Form1 : Form
    {
        private DataClassesDataContext DB = new DataClassesDataContext();
        private readonly BindingSource _tblsBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void DialogBTN_Click(object sender, EventArgs e)
        {
            using (Form2 form2 = new Form2())
            {
                if (form2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    _tblsBindingSource.DataSource = form2.QueryToExecute;
                    DB.SubmitChanges();
                }
            }
        }

        private void DeleteStudentBTN_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int rowId = dataGridView.SelectedRows[0].Index;
                dataGridView.Rows.RemoveAt(rowId);
                DB.SubmitChanges();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _tblsBindingSource.DataSource = DB.TblStudents;
            dataGridView.DataSource = _tblsBindingSource;
        }
        private void _tblsBindingSource_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.Escape)
            {
                dataGridView.Columns.Clear();
                _tblsBindingSource.DataSource = DB.TblStudents;
            }
        }
    }
}
