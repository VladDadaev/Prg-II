using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Teacher> teacher = new List<Teacher>();

        public Form1()
        {
            InitializeComponent();
        }

        private List<Teacher> CreateTeacher()
        {
            List<Teacher> teacher = new List<Teacher>();
            Address adr = new Address("Ukraine", "Kherson", "Ushakova", 15);

            Teacher t1 = new Teacher(165, "Olga", "Ivanchenka", 48, adr );
            Teacher t2 = new Teacher(103, "Igor", "Danilenko", 32, adr);
            Teacher t3 = new Teacher(174, "Maria", "Ivanova", 54, adr);

            teacher.Add(t1);
            teacher.Add(t2);
            teacher.Add(t3);

            Student s1 = new Student(165, "Oleg", "Ivanov", 18, adr, 5);
            Student s2 = new Student(103, "Danil", "Danilenko", 16, adr,2);
            Student s3 = new Student(174, "Vlad", "Dadaev", 18, adr, 4);
            Student s4 = new Student(813, "Ivan", "Tkach", 17, adr, 4);
            Student s5 = new Student(435, "Bogdan", "Grishan", 19, adr, 3);
            Student s6 = new Student(182, "Lena", "Golovaha", 17,  adr,5);

            teacher[0].AddStudent(s1);
            teacher[0].AddStudent(s2);
            teacher[1].AddStudent(s3);
            teacher[1].AddStudent(s4);
            teacher[2].AddStudent(s5);
            teacher[2].AddStudent(s6);

            return teacher;
        }
        private void DtCreate()
        {
            List<Teacher> teachers = CreateTeacher();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Surname");
            dt.Columns.Add("Age");
            dt.Columns.Add("Mark");
            dt.Columns.Add("Country");
            dt.Columns.Add("City");
            dt.Columns.Add("Street");
            dt.Columns.Add("House");

            for (int i = 0; i < teachers.Count; i++)
            {
                for (int j = 0; j < teachers[i].GetStudentList().Count; j++)
                {
                    List<Student> list = teachers[i].GetStudentList();
                    dt.Rows.Add(list[j].id, list[j].name, list[j].surname, list[j].age, list[j].marks, list[j].country, list[j].city, list[j].street, list[j].house);
                }
            }
            dataGridView2.DataSource = dt;

        }
        private void InitionalDatable()
        {
            List<Teacher> teachers = CreateTeacher();
            DataTable table = new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("Name");
            table.Columns.Add("Surname");
            table.Columns.Add("Age");
            table.Columns.Add("Country");
            table.Columns.Add("City");
            table.Columns.Add("Street");
            table.Columns.Add("House");
            foreach (Teacher i in teachers)
            {   
                table.Rows.Add(i.id, i.name, i.surname, i.age, i.country, i.city, i.street, i.house);
            }
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        private void InitionalChart()
        {
            List<Teacher> teachers = CreateTeacher();
            for (int i = 0; i< teachers.Count; i++)
                chart1.Series["Age"].Points.AddXY(teachers[i].name, teachers[i].age);
        }

        private void InitionalChartSt()
        {
            List<Teacher> teachers = CreateTeacher();
            for (int i = 0; i < teachers.Count; i++)
            {
                for (int j = 0; j < teachers[i].GetStudentList().Count; j++)
                {
                    List<Student> list = teachers[i].GetStudentList();
                    chart2.Series["Age"].Points.AddXY(list[j].name, list[j].age);
                }
            }
        }
        private void InitionaltreeView()
        {
            List<Teacher> teachers = CreateTeacher();
            TreeNode root = new TreeNode();
            root.Name = "rootName";
            root.Text = "Teachers";
            treeView1.Nodes.Add(root);
            for (int i = 0; i < teachers.Count; i++)
            {
                treeView1.Nodes[0].Nodes.Add(teachers[i].name + " " + teachers[i].surname);
                for (int j = 0; j<teachers[i].GetStudentList().Count; j++)
                {
                    List<Student> list = teachers[i].GetStudentList();
                    treeView1.Nodes[0].Nodes[i].Nodes.Add(list[j].name + " " + list[j].surname);
                }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InitionalDatable();
            InitionalChart();
            InitionaltreeView();
        }

        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void teacherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 AT2 = new Form2();
            AT2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitionalChartSt();
            DtCreate();
        }
    }
}
