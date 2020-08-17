using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10212___HW2___Tom_Cohen
{
    public partial class Form2 : Form
    {
        private DataClassesDataContext DB = new DataClassesDataContext();
        private readonly BindingSource _tblsBindingSource = new BindingSource();
        private string buttonSelected = "";
        public dynamic QueryToExecute { get; set; }
        public Form2()
        {
            InitializeComponent();
        }
        
        private void ABTN_Click(object sender, EventArgs e)
        {
            textBox.Enabled = true;
            textBox.Text = "Enter Lecturer ID...";
            textBox.SelectAll();
            buttonSelected = "A";
        }

        private void BBTN_Click(object sender, EventArgs e)
        {
            textBox.Enabled = false;
            QueryToExecute =
                (from student in DB.TblStudents
                    select new { NAME = student.Name }).Distinct();
            buttonSelected = "B";
        }

        private void CBTN_Click(object sender, EventArgs e)
        {
            textBox.Enabled = false;
            QueryToExecute =
                from student in DB.TblStudents
                join studentInCourse in DB.TblStudentsInCourses on student.Id equals studentInCourse.StudentId into studentsCourses
                from studentsCoursesDisplay in studentsCourses.DefaultIfEmpty()
                group studentsCoursesDisplay by new { student.Id, student.Name } into studentsCoursesCount
                select new {ID = studentsCoursesCount.Key.Id, NAME = studentsCoursesCount.Key.Name, Courses = studentsCoursesCount.Count(x => x != null)};
            buttonSelected = "C";
        }

        private void DBTN_Click(object sender, EventArgs e)
        {
            textBox.Enabled = false;
            QueryToExecute =
                (from student in DB.TblStudents
                 select new { ID = student.Id, NAME = student.Name, Age = YearsOfAge(student.Birthday) }).Distinct();
            buttonSelected = "D";
        }
        private void OkBTN_Click(object sender, EventArgs e)
        {
            switch (buttonSelected)
            {
                case "A":
                    int lecturerId = Int32.Parse(textBox.Text);
                    QueryToExecute =
                        from course in DB.TblCourses
                        join lecturesInCourse in DB.TblLecturesInCourses
                            on course.Id equals lecturesInCourse.CourseId
                        where lecturesInCourse.LectureId == lecturerId
                        let id = lecturesInCourse.CourseId
                        select new { id, course.CourseName, course.Credits };
                    break;
                case "B":
                    break;
                case "C":
                    break;
                case "D":
                    break;
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox.DataSource = DB.TblStudents.Select(s => s.Id + " " + s.Name).Distinct().OrderBy(id => id);
        }

        public int YearsOfAge(DateTime birthDate)
        {
            DateTime now = DateTime.Now;
            int age = now.Year - birthDate.Year;

            if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                return age - 1;

            return age;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int index = Int32.Parse(Regex.Match(comboBox.Text, @"\d+").Value);

            QueryToExecute =
                (from student in DB.TblStudents
                    from studentsInCourse in student.TblStudentsInCourses
                    from lecturer in DB.TblLecturers
                    from lecturesInCourse in lecturer.TblLecturesInCourses
                    where student.Id == index && student.Id == studentsInCourse.StudentId
                                        && studentsInCourse.CourseId == lecturesInCourse.CourseId && lecturer.Id == lecturesInCourse.LectureId
                    select new { NAME = lecturer.Name }).Distinct();
        }
    }
}

