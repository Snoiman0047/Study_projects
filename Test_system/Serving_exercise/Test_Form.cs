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
    public partial class Test_Form : Form
    {
        public Test_Form(string Topic) 
        {
            InitializeComponent();
            label1.Text = Topic + " test";
            SetTopic(Topic);
        }

        string topic = "";
        int Index = 0;
        double Score = 0;
        int Solutions = 0;
        List<Exercise> Exercises = null;
        Exercise Current = null;
   
        private void SetTopic(string t)
        { topic = t; }

        private void Start_Click(object sender, EventArgs e)
        {
            Start.Visible = false;
            Question.Visible = true;
            Next.Visible = true;
            Finish.Visible = true;
            using (Test_Exercises db = new Test_Exercises())
            {
                var q = db.Test.FirstOrDefault(o => o.Topic == topic);
               if (q != null)
                {
                    string Test_id = q.Id;
                    Exercises = (db.Exercise.Where(o => o.Test_ID == Test_id)).ToList();
                    if (Exercises.Count != 0)
                    { Question_Format(); }
                    label2.Text = Index.ToString() + " / " + Exercises.Count.ToString();
                }
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (Current is American_exercise)
            {
                if (American_checked() != null)
                {
                    if (American_checked() == Current.Solution)
                    {
                        Score += Current.Points;
                        Solutions++;
                    }
                }
            }
            else
            {
                if (Answer_text.Text == Current.Solution)
                {
                    Score += Current.Points;
                    Solutions++;
                }
            }
            Answer_text.Text = "";
            if (Index == Exercises.Count)
            { finish(); }
            else
            { Question_Format(); }
            label2.Text = Index.ToString() + " / " + Exercises.Count.ToString();
        }

        private void Finish_Click(object sender, EventArgs e)
        { finish(); }

        private void Regulae_q()
        {
            //Regular
            Regular_Panel.Visible = true;
            American_Panel.Visible = false;
            American_Panel.Location = new Point(30, 294);
        }

        private void American_q()
        {
            //American
            Regular_Panel.Visible = false;
            American_Panel.Visible = true;
            American_Panel.Location = new Point(30, 231);
        }

        private void Question_Format()
        {
            using (Test_Exercises db = new Test_Exercises())
            {
                if (Exercises[Index] is American_exercise)
                {
                    American_q();
                    Sol_1.Text = (Exercises[Index] as American_exercise).Solution_1;
                    Sol_2.Text = (Exercises[Index] as American_exercise).Solution_2;
                    if ((Exercises[Index] as American_exercise).Solution_3 != null)
                    { Sol_3.Text = (Exercises[Index] as American_exercise).Solution_3; }
                    else
                    { Sol_3.Visible = false; }
                }
                else
                { Regulae_q(); }
                Question.Text = Exercises[Index]._Exercise;
                Current = Exercises[Index];
                Index++;
            }
        }

        private void finish()
        {
            Score_display sd = new Score_display(Solutions, Score, Exercises.Count);
            sd.Show();
            this.Hide();
        }

        private string American_checked()
        {
            if (Sol_1.Checked)
                return Sol_1.Text;
            if (Sol_2.Checked)
                return Sol_2.Text;
            if (Sol_3.Checked)
                return Sol_3.Text;
            return null;
        }

       
    }
}
