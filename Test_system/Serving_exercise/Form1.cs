using Serving_exercise.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serving_exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (Test_Exercises db = new Test_Exercises())
            {
                if (!db.Database.Exists())
                {
                    try
                    {
                        Test t = new Test() { Id = "268944", Topic = "Essay exercises" };
                        Exercise e_1 = new Exercise() { Id = "0541", Test_ID = t.Id, _Exercise = "560 + 11 =", Solution = "571", Points = 1 };
                        Exercise e_2 = new Exercise() { Id = "0542", Test_ID = t.Id, _Exercise = "194 + 803 =", Solution = "997", Points = 1 };
                        American_exercise e_3 = new American_exercise() { Id = "0543", Test_ID = "268944", _Exercise = "124 + 258 =", Solution_1 = "381", Solution_2 = "382", Solution_3 = "383", Solution = "382", Points = 1 };
                        Exercise e_4 = new Exercise() { Id = "0544", Test_ID = t.Id, _Exercise = "588 + 266 = ", Solution = "854", Points = 1 };
                        Exercise e_5 = new Exercise() { Id = "0545", Test_ID = t.Id, _Exercise = "199 + 759 =", Solution = "958", Points = 1 };
                        Exercise e_6 = new Exercise() { Id = "0546", Test_ID = t.Id, _Exercise = "309 + 841 =", Solution = "1150", Points = 1 };
                        Exercise e_7 = new Exercise() { Id = "0547", Test_ID = t.Id, _Exercise = "468 + 367 =", Solution = "835", Points = 1 };
                        Exercise e_8 = new Exercise() { Id = "0548", Test_ID = t.Id, _Exercise = "248 + 279 =", Solution = "527", Points = 1 };
                        Exercise e_9 = new Exercise() { Id = "0549", Test_ID = t.Id, _Exercise = "447 + 495 =", Solution = "942", Points = 1 };
                        Exercise e_10 = new Exercise() { Id = "0550", Test_ID = t.Id, _Exercise = "687 + 468 =", Solution = "1155", Points = 1 };

                        Test T = new Test() { Id = "178624", Topic = "Subtraction exercises" };
                        Exercise e1 = new Exercise() { Id = "1741", Test_ID = T.Id, _Exercise = "159 - 45 =", Solution = "114", Points = 1.5 };
                        Exercise e2 = new Exercise() { Id = "1742", Test_ID = T.Id, _Exercise = "687 - 556 =", Solution = "131", Points = 1.5 };
                        Exercise e3 = new Exercise() { Id = "1743", Test_ID = T.Id, _Exercise = "899 - 199 =", Solution = "700", Points = 1 };
                        Exercise e4 = new Exercise() { Id = "1744", Test_ID = T.Id, _Exercise = "994 - 803 =", Solution = "191", Points = 2 };
                        Exercise e5 = new Exercise() { Id = "1745", Test_ID = T.Id, _Exercise = "555 - 43 =", Solution = "512", Points = 1 };
                        Exercise e6 = new Exercise() { Id = "1746", Test_ID = T.Id, _Exercise = "375 - 121 =", Solution = "254", Points = 1 };
                        American_exercise e7 = new American_exercise() { Id = "1747", Test_ID = T.Id, _Exercise = "234 - 122 =", Solution_1 = "112", Solution_2 = "122", Solution_3 = "212", Solution = "112", Points = 1 };
                        Exercise e8 = new Exercise() { Id = "1748", Test_ID = T.Id, _Exercise = "437 - 126 =", Solution = "311", Points = 1 };

                        Test tt = new Test() { Id = "148049", Topic = "Multiplication exercises" };
                        Exercise E_1 = new Exercise() { Id = "6411", Test_ID = tt.Id, _Exercise = "100 * 543 =", Solution = "54300", Points = 2 };
                        Exercise E_2 = new Exercise() { Id = "6412", Test_ID = tt.Id, _Exercise = "5 * 154 =", Solution = "770", Points = 2 };
                        Exercise E_3 = new Exercise() { Id = "6413", Test_ID = tt.Id, _Exercise = "85 * 11 =", Solution = "935", Points = 2 };
                        Exercise E_4 = new Exercise() { Id = "6414", Test_ID = tt.Id, _Exercise = "14 * 50 =", Solution = "700", Points = 2 };
                        Exercise E_5 = new Exercise() { Id = "6415", Test_ID = tt.Id, _Exercise = "6 * 23 =", Solution = "138", Points = 2 };

                        Test TT = new Test() { Id = "180414", Topic = "Divide exercises" };
                        Exercise E1 = new Exercise() { Id = "3750", Test_ID = TT.Id, _Exercise = "250 / 25 =", Solution = "10", Points = 2 };
                        Exercise E2 = new Exercise() { Id = "3751", Test_ID = TT.Id, _Exercise = "570 / 6 =", Solution = "95", Points = 2 };
                        Exercise E3 = new Exercise() { Id = "3752", Test_ID = TT.Id, _Exercise = "759 / 3 =", Solution = "253", Points = 2 };
                        Exercise E4 = new Exercise() { Id = "3753", Test_ID = TT.Id, _Exercise = "84 / 3 =", Solution = "84", Points = 2 };
                        Exercise E5 = new Exercise() { Id = "3754", Test_ID = TT.Id, _Exercise = "264 / 6 =", Solution = "44", Points = 2 };


                        db.Test.Add(t);
                        db.Test.Add(T);
                        db.Test.Add(tt);
                        db.Test.Add(TT);


                        db.Exercise.Add(e_1);
                        db.Exercise.Add(e_2);
                        db.Exercise.Add(e_3);
                        db.Exercise.Add(e_4);
                        db.Exercise.Add(e_5);
                        db.Exercise.Add(e_6);
                        db.Exercise.Add(e_7);
                        db.Exercise.Add(e_8);
                        db.Exercise.Add(e_9);
                        db.Exercise.Add(e_10);

                        db.Exercise.Add(e1);
                        db.Exercise.Add(e2);
                        db.Exercise.Add(e3);
                        db.Exercise.Add(e4);
                        db.Exercise.Add(e5);
                        db.Exercise.Add(e6);
                        db.Exercise.Add(e7);
                        db.Exercise.Add(e8);

                        db.Exercise.Add(E_1);
                        db.Exercise.Add(E_2);
                        db.Exercise.Add(E_3);
                        db.Exercise.Add(E_4);
                        db.Exercise.Add(E_5);

                        db.Exercise.Add(E1);
                        db.Exercise.Add(E2);
                        db.Exercise.Add(E3);
                        db.Exercise.Add(E4);
                        db.Exercise.Add(E5);

                        db.SaveChanges();
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.Message); }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            using (Test_Exercises db = new Test_Exercises())
            {
                if (Topic_comboBox.Items.Count == 0)
                {
                    var t = db.Test.ToList();
                    foreach (var item in t)
                    { Topic_comboBox.Items.Add(item.Topic); }
                }
            }
            First_panel.Visible = true;
            Techer_panel.Visible = false;
            Question_panel.Visible = false;
            this.Size = new Size(363, 395);
            label2.Location = new Point(111, 29);
            button2.Visible = false;
            label2.Text = "Wellcome";
        }

        private void Lets_start_Click(object sender, EventArgs e)
        {
            if (Topic_comboBox.SelectedIndex != -1 && Profil_comboBox.SelectedIndex != -1)
            {
                if (Profil_comboBox.Items[Profil_comboBox.SelectedIndex].ToString() == "Student")
                    Student(Topic_comboBox.Items[Topic_comboBox.SelectedIndex].ToString());

                if (Profil_comboBox.Items[Profil_comboBox.SelectedIndex].ToString() == "Teacher")
                    Teacher(Topic_comboBox.Items[Topic_comboBox.SelectedIndex].ToString());
            }
            else
                MessageBox.Show("Data invalid");
        }

        private void Student(string Topic)
        {
            Test_Form tf = new Test_Form(Topic);
            tf.Show();
            this.Hide();
        }
        private void Teacher(string Topic)
        {
            label2.Text = Topic;
            this.Size = new Size(800, 515);
            label2.Location = new Point(311, 23);
            First_panel.Visible = false;
            Techer_panel.Visible = true;
            Techer_panel.Location = new Point(21, 80);
            button2.Visible = true;
            using (Test_Exercises db = new Test_Exercises())
            {
                var q = (from top in db.Test
                         where top.Topic == Topic_comboBox.Text
                         select top).ToList();
                string test_id = q[0].Id;
                dataGridView1.DataSource = db.Exercise.Where(o => o.Test_ID == test_id).ToList();
            }
        }

        private void Delate_Click(object sender, EventArgs e)
        {
            using (Test_Exercises db = new Test_Exercises())
            {
                string x = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                Exercise ex = db.Exercise.FirstOrDefault(o => o.Id == x);
                if (ex is American_exercise)
                    db.American_exercise.Remove((ex as American_exercise));
                else
                    db.Exercise.Remove(ex);
                db.SaveChanges();
                MessageBox.Show("successfully delated");
                var q = (from top in db.Test
                         where top.Topic == Topic_comboBox.Text
                         select top).ToList();
                string test_id = q[0].Id;
                dataGridView1.DataSource = db.Exercise.Where(o => o.Test_ID == test_id).ToList();
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            label2.Text = "What kind of question \n do you want to add?";
            Question_panel.Visible = true;
            First_panel.Visible = false;
            Techer_panel.Visible = false;
            this.Size = new Size(380, 371);
            Question_panel.Location = new Point(20, 120);
            label2.Location = new Point(50, 60);
            button2.Location = new Point(5, 12);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                using (Test_Exercises db = new Test_Exercises())
                {
                    var ex = dataGridView1.SelectedRows[0].Cells[0].Value;
                    AddEdit_Form aed;
                    aed = new AddEdit_Form(ex.ToString(), "Edit");
                    aed.Show();
                    var q = (from top in db.Test
                             where top.Topic == Topic_comboBox.Text
                             select top).ToList();
                    string test_id = q[0].Id;
                    dataGridView1.DataSource = db.Exercise.Where(o => o.Test_ID == test_id).ToList();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string test_id = null;
            using (Test_Exercises db = new Test_Exercises())
            {
                var q = (from top in db.Test
                         where top.Topic == Topic_comboBox.Text
                         select top).ToList();
                test_id = q[0].Id;
                AddEdit_Form aed;
                if (Regular.Checked || American.Checked)
                {
                    if (Regular.Checked)
                    {
                        aed = new AddEdit_Form(test_id, "Regular");
                        aed.Show();
                        this.Hide();
                    }
                    if (American.Checked)
                    {
                        aed = new AddEdit_Form(test_id, "American");
                        aed.Show();
                        this.Hide();
                    }
                }
                else { MessageBox.Show("No exercise selection was adsorbed"); }
                dataGridView1.DataSource = db.Exercise.Where(o => o.Test_ID == test_id).ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        { Form1_Load(sender, e); }

    }
}
