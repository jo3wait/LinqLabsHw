using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqLabsHw
{
    public partial class FrmHw3 : Form
    {
        public FrmHw3()
        {
            InitializeComponent();

            students_scores = new List<Student>()
                              {
                                  new Student{ Name = "aaa", Class = "CS_101", Gender = "Male", Chi = 80, Eng = 80, Math = 50 },
                                  new Student{ Name = "bbb", Class = "CS_102", Gender = "Male", Chi = 80, Eng = 80, Math = 100 },
                                  new Student{ Name = "ccc", Class = "CS_101", Gender = "Female", Chi = 60, Eng = 50, Math = 75 },
                                  new Student{ Name = "ddd", Class = "CS_102", Gender = "Female" , Chi = 80, Eng = 70, Math = 85},
                                  new Student{ Name = "eee", Class = "CS_101", Gender = "Female" , Chi = 80, Eng = 80, Math = 50},
                                  new Student{ Name = "fff", Class = "CS_102", Gender = "Female" , Chi = 80, Eng = 80, Math = 80},

                              };
        }        

        List<Student> students_scores;

        private void btnGroup_Click(object sender, EventArgs e)
        {
            // split=> 數學成績 分成 三群 '待加強'(60~69) '佳'(70~89) '優良'(90~100) 
        }

        private void btnScoreAll_Click(object sender, EventArgs e)
        {
            // 共幾個 學員成績 ?						
            int c = students_scores.Count();
            MessageBox.Show("共" + c + "個學員成績\n");
            // 找出 前面三個 的學員所有科目成績	
            var q1 = from s in students_scores
                     orderby s.Chi + s.Eng + s.Math descending
                     select s;
            this.dataGridView1.DataSource = q1.Take(3).ToList();

            // 找出 後面兩個 的學員所有科目成績		
            var q2 = from s in students_scores
                     orderby s.Chi + s.Eng + s.Math
                     select s;
            this.dataGridView1.DataSource = q2.Take(2).ToList();

            //找出 Name 'aaa','bbb','ccc' 的學成績
            var q3 = from s in students_scores
                     where s.Name == "aaa" || s.Name == "bbb" || s.Name == "ccc"
                     select s;
            this.dataGridView1.DataSource = q3.ToList();
            //找出學員 'bbb' 的成績
            var q4 = from s in students_scores
                     where s.Name == "bbb"
                     select s;
            this.dataGridView1.DataSource = q4.ToList();
            //找出除了 'bbb' 學員的學員的所有成績('bbb' 退學)
            var q5 = from s in students_scores
                     where s.Name != "bbb"
                     select s;
            this.dataGridView1.DataSource = q5.ToList();

            //數學不及格... 是誰
            var q6 = from s in students_scores
                     where s.Math < 60
                     select s;
            this.dataGridView1.DataSource = q6.ToList();
        }

        private void btnScoreStu_Click(object sender, EventArgs e)
        {
            //找出'aaa', 'bbb', 'ccc'學員 國文數學兩科 科目成績
            var q1 = students_scores.Where(s => s.Name == "aaa" || s.Name == "bbb" || s.Name == "ccc").Select(s => new { s.Name, s.Chi, s.Math });
            this.dataGridView1.DataSource = q1.ToList();

            //個人 所有科的 sum, min, max, avg
            var q2 = students_scores.Select(s => new
            {
                s.Name,
                s.Class,
                s.Chi,
                s.Eng,
                s.Math,
                Total = s.Chi + s.Eng + s.Math,
                Average = (s.Chi + s.Eng + s.Math) / 3,
                Max = Math.Max(Math.Max(s.Chi, s.Eng), s.Math),
                Min = Math.Min(Math.Min(s.Chi, s.Eng), s.Math)
            });
            this.dataGridView1.DataSource = q2.ToList();
        }
    }
    public class Student
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string Gender { get; set; }
        public int Chi { get; set; }
        public int Eng { get; internal set; }
        public int Math { get; set; }
    }
}
