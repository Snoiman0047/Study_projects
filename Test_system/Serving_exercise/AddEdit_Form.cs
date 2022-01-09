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
    public partial class AddEdit_Form : Form
    {
        public AddEdit_Form(string id, string Type)
        {
            InitializeComponent();
            this.Size = new Size(462, 356);
            if (Type == "Regular")
            { Test_id = id; Title.Text = "Add question"; Regular(); }
            if (Type == "American")
            { Test_id = id; Title.Text = "Add question"; American(); }
            if (Type == "Edit")
            { exe_id = id; Title.Text = "Edit question"; Edit(); }
        }

        string Test_id;
        string exe_id;

        private void Regular() 
        {
            this.Size = new Size(350, 370);
            Reg_panel.Visible = true;
        }
        private void American() 
        {
            this.Size = new Size(350, 520);
            Amer_panel.Location = Reg_panel.Location;
            Amer_panel.Visible = true;
        }


        private void Add_Click_1(object sender, EventArgs e) 
        {
            try
            {
                using (Test_Exercises db = new Test_Exercises())
                {
                    if (ExeId_ckeck() && (Point_check() != 0) && Question_check())
                    {
                        if (Reg_panel.Visible == true)
                        {
                            if (Answer_check() && Solution_check())
                            {
                                Exercise exe = new Exercise()
                                { Id = Exe_id.Text, Test_ID = Test_id, Points = Point_check(), _Exercise = Question.Text, Solution = Ans_sol.Text };
                                db.Exercise.Add(exe);
                                db.SaveChanges();
                                MessageBox.Show("Add successfully");
                            }
                        }
                        else
                        {
                            if (Amer_panel.Visible == true)
                            {
                                if (Sol1_check() && Sol2_check() && ASolution_check() != null)
                                {
                                    American_exercise Aexe = new American_exercise()
                                    {
                                        Id = Exe_id.Text,
                                        Test_ID = Test_id,
                                        Points = Point_check(),
                                        _Exercise = Question.Text,
                                        Solution_1 = Sol_1.Text,
                                        Solution_2 = Sol_2.Text
                                    };
                                    if (Sol3_Check())
                                    { Aexe.Solution_3 = Sol_3.Text; }
                                    Aexe.Solution = ASolution_check();
                                    db.American_exercise.Add(Aexe);
                                    db.SaveChanges();
                                    MessageBox.Show("Add successfully");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception exe)
            { MessageBox.Show(exe.Message); }
        }
        private void Edit() 
        {
            Add.Visible = false;
            Update.Visible = true;
            Update.Location = new Point(232, 12);
            using (Test_Exercises db = new Test_Exercises())
            {
                var q = db.Exercise.Where(o => o.Id == exe_id).ToList();
                Exercise ex = q[0];
                Exe_id.Text = ex.Id;
                Points.Text = ex.Points.ToString();
                Question.Text = ex._Exercise;
                if (ex is American_exercise)
                {
                    American();
                    Sol_1.Text = (ex as American_exercise).Solution_1;
                    Sol_2.Text = (ex as American_exercise).Solution_2;
                    if ((ex as American_exercise).Solution_3 != null)
                        Sol_3.Text = (ex as American_exercise).Solution_3;
                    if ((ex as American_exercise).Solution_1 == ex.Solution)
                        Sol.Text = "Solution 1";
                    if ((ex as American_exercise).Solution_2 == ex.Solution)
                        Sol.Text = "Solution 2";
                    if ((ex as American_exercise).Solution_3 == ex.Solution)
                        Sol.Text = "Solution 3";
                }
                else
                {
                    Regular();
                    Ans_sol.Text = ex.Solution;
                }
            }
        }

        #region integrity_check

        private bool Id_changed(string id)
        {
            if (Exe_id.Text == id)
                return true;
            return ExeId_ckeck();
        }
        private bool ExeId_ckeck() 
        {
            using (Test_Exercises db = new Test_Exercises())
            {
                var q = db.Exercise.Select(o => o).ToList();
                foreach (Exercise exercise in q)
                {
                    if (exercise.Id == Exe_id.Text)
                    {
                        MessageBox.Show("The exercise already exists");
                        return false;
                    }
                }
            }
            return true;
        }

        private bool Solution_check() 
        { return Question.Text != " "; }

        private double Point_check() 
        {
            if (Convert.ToDouble(Points.Text) >= 1 && Convert.ToDouble(Points.Text) <= 10)
                return Convert.ToDouble(Points.Text);
            return 0;
        }

        private bool Question_check() 
        { return Question.Text != " "; }

        private bool Answer_check() 
        { return Ans_sol.Text != " "; }

        private bool Sol1_check() 
        { return Sol_1.Text != " "; }

        private bool Sol2_check() 
        { return Sol_2.Text != " "; }

        private bool Sol3_Check() 
        { return Sol_3.Text != " "; }

        private string ASolution_check()
        {
            switch (Sol.SelectedIndex)
            {
                case 0:
                    {
                        if (Sol1_check())
                        { return Sol_1.Text; }
                        break;
                    }
                case 1:
                    {
                        if (Sol2_check())
                        { return Sol_2.Text; }
                        break;
                    }
                case 2:
                    {
                        if (Sol3_Check())
                        { return Sol_3.Text; }
                        break;
                    }
                default:
                    { return null; }
            }
            return null;
        }


        #endregion

        private void Back_Click(object sender, EventArgs e) 
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void Update_Click(object sender, EventArgs e) 
        {
            using (Test_Exercises db = new Test_Exercises())
            {
                var q = db.Exercise.Where(o => o.Id == exe_id).ToList();
                Exercise ex = q[0];
                if (Id_changed(ex.Id))
                    ex.Id = Exe_id.Text;
                if (Point_check() != 0)
                    ex.Points = Point_check();
                if (Question_check())
                    ex._Exercise = Question.Text;
                if (ex is American_exercise)
                {
                    if (Sol1_check())
                        (ex as American_exercise).Solution_1 = Sol_1.Text;
                    if (Sol2_check())
                        (ex as American_exercise).Solution_2 = Sol_2.Text;
                    if (Sol3_Check())
                        (ex as American_exercise).Solution_3 = Sol_3.Text;
                    ex.Solution = ASolution_check();
                }
                else
                {
                    if (Answer_check())
                    {
                        ex.Solution = Ans_sol.Text;
                    }
                }
                db.SaveChanges();
                MessageBox.Show("successfully updated");
            }
        }

    }
}
