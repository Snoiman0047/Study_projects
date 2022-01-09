using Ef_cf__Apartment_brokerage_.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ef_cf__Apartment_brokerage_
{
    public partial class Detailes_Form : Form
    {

        
        
        public Detailes_Form(int apartContext, string Type) 
        {
            InitializeComponent();
            using (ApartContext db = new ApartContext())
            {
                try
                {
                    if (Type == "Rent")
                    {
                        var r = db.Aparts_ForRent.FirstOrDefault(o => o.Id == apartContext);
                        Id(apartContext);
                        if (r != null)
                            Rent_Apart();
                    }
                    else
                    {
                        var s = db.Aparts_ForSale.FirstOrDefault(o => o.Id == apartContext);
                        Id(apartContext);
                        if (s != null)
                            Sale_Apart();
                    }
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
        }

        int Apartid;
        private void Id(int id) 
        { Apartid = id; }

        private void Rent_Apart() 
        {
            Rent_panel.Visible = true;
            Save.Location = new Point(974, 12);
            label1.Location = new Point(377, 39);
            this.Size = new Size(1113, 628);

            using (ApartContext db = new ApartContext())
            {
                Apart_ForRent q = db.Aparts_ForRent.Where(o => o.Id == Apartid).FirstOrDefault();
                id.Text = q.Id.ToString();
                City.Text = q.Address.City;
                Street.Text = q.Address.Street;
                Floor.Text = q.Address.Floor.ToString();
                House.Text = q.Address.House_num.ToString();
                Rooms.Text = q.Num_rooms.ToString();
                Price.Text = q.Price.ToString();
                ContractPeriod.Text = q.Contract_period.ToString();
                North.Checked = q.North;
                South.Checked = q.South;
                East.Checked = q.East;
                West.Checked = q.West;

                var owner = db.Aparts_ForRent.Where(o => o.Id == Apartid).Select(k => k.Apart_Owners.Select(t => t.Tz).ToList()).ToList();
                if (owner.Count > 0)
                {
                    for (int i = 0; i < owner.Count; i++)
                    {
                        for (int j = 0; j < owner[i].Count; j++)
                        {
                            owners.Items.Add(owner[i][j]);
                        }
                    }
                }

                var fur = db.Aparts_ForRent.Where(o => o.Id == Apartid).Select(k => k.Furnitures.Select(t => t.Name).ToList()).ToList();
                if (fur.Count > 0)
                {
                    for (int i = 0; i < fur.Count; i++)
                    {
                        for (int j = 0; j < fur[i].Count; j++)
                        {
                            Furniture.Items.Add(fur[i][j]);
                        }
                    }
                }

                if (q.With_elevator == true)
                    elevator.Checked = true;
                if (q.With_airConditioning == true)
                    airConditioning.Checked = true;
                EducationDate.Value = Convert.ToDateTime(q.Evacuation_date);
            }
        }

        private void Sale_Apart() 
        {
            Sale_Panel.Visible = true; 
            Save.Location = new Point(398, 11);
            label1.Location = new Point(94, 48);
            this.Size = new Size(507, 725);

            using (ApartContext db = new ApartContext())
            {
                Apart_ForSale q = db.Aparts_ForSale.Where(o => o.Id == Apartid).FirstOrDefault();
                id.Text = q.Id.ToString();
                City.Text = q.Address.City;
                Street.Text = q.Address.Street;
                Floor.Text = q.Address.Floor.ToString();
                House.Text = q.Address.House_num.ToString();
                Rooms.Text = q.Num_rooms.ToString();
                Price.Text = q.Price.ToString();
                North.Checked = q.North;
                South.Checked = q.South;
                East.Checked = q.East;
                West.Checked = q.West;
                Common_taboo.Checked = Convert.ToBoolean(q.Common_taboo);
                if (q.Neighbors != null)
                    Neigbors.Text = q.Neighbors.ToString();
            }
        }

        private void Save_Click(object sender, EventArgs e) 
        {
            try
            {
                using (ApartContext db = new ApartContext())
                {
                    if (Rent_panel.Visible == true)
                    {
                        Apart_ForRent q = db.Aparts_ForRent.Where(o => o.Id == Apartid).FirstOrDefault();
                        if (city())
                            q.Address.City = City.Text;
                        if (street())
                            q.Address.Street = Street.Text;
                        if (floor())
                            q.Address.Floor = Convert.ToInt32(Floor.Text);
                    if (house_num())
                    { q.Address.House_num = Convert.ToInt32(House.Text); }
                    else
                    {
                        if (House.Text != "")
                            q.Address.House_num = null;
                    }

                    if (Rooms.Text == "")
                        q.Num_rooms = null;
                    else
                    {
                        if (rooms())
                            q.Num_rooms = Convert.ToInt32(Rooms.Text);
                    }

                    if (Price.Text == "")
                    { q.Price = null; }
                    else
                    {
                        if (price())
                            q.Price = Convert.ToInt32(Price.Text);
                    }
                    if (q.Furnitures.Count > 0)
                        {
                            q.Furnitures.ForEach(o => Furniture.Items.Add(o.Name));
                        }
                    if (contractPeriod())
                        q.Contract_period = Convert.ToInt32(ContractPeriod.Text);
                        q.With_elevator = elevator.Checked;
                        q.With_airConditioning = airConditioning.Checked;
                        q.Evacuation_date = EducationDate.Value;
                        q.North = North.Checked;
                        q.South = South.Checked;
                        q.East = East.Checked;
                        q.West = West.Checked;
                    }
                    else
                    {
                        if (Sale_Panel.Visible == true)
                        {
                            Apart_ForSale q = db.Aparts_ForSale.Where(o => o.Id == Apartid).FirstOrDefault();
                            if (city())
                                q.Address.City = City.Text;
                            if (street())
                                q.Address.Street = Street.Text;
                            if (floor())
                                q.Address.Floor = Convert.ToInt32(Floor.Text);
                            if (house_num())
                            { q.Address.House_num = Convert.ToInt32(House.Text); }
                            else
                            {
                                if (House.Text != "")
                                    q.Address.House_num = null;
                            }

                            if (Rooms.Text == "")
                                q.Num_rooms = null;
                            else
                            {
                                if (rooms())
                                    q.Num_rooms = Convert.ToInt32(Rooms.Text);
                            }

                            if (Price.Text == "")
                            { q.Price = null; }
                            else
                            {

                                if (price())
                                    q.Price = Convert.ToInt32(Price.Text);
                            }

                            q.Common_taboo = Common_taboo.Checked;

                            if (Neigbors.Text == "")
                            { q.Neighbors = null; }
                            else
                            {
                                if (neigbors())
                                    q.Neighbors = Convert.ToInt32(Neigbors.Text);
                            }
                        }
                    }
                    db.SaveChanges();
                    MessageBox.Show("Updated");
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        #region Check

        private bool city()
        { return City.Text != ""; }
        private bool street()
        { return Street.Text != ""; }
        private bool floor()
        {
            if (Floor.Text[0] == '-' || (Convert.ToInt32(Floor.Text[0]) >= 0 && Convert.ToInt32(Floor.Text[0]) <= 9))
            {
                for (int i = 1; i < Floor.Text.Length; i++)
                {
                    if (!char.IsDigit(Floor.Text[i]))
                        return false;
                }
                return true;
            }
            return false;
        }
        private bool house_num()
        {
            if (House.Text == "")
            { return false; }
            foreach (char ch in House.Text)
            {
                if (!char.IsDigit(ch))
                    return false;
            }
            return true;
        }
        private bool rooms()
        {
            foreach (char ch in Rooms.Text)
            {
                if (!char.IsDigit(ch))
                    return false;
            }
            return true;
        }
        private bool price()
        {
            foreach (char ch in Price.Text)
            {
                if (!char.IsDigit(ch))
                    return false;
            }
            return true;
        }
        private bool contractPeriod()
        {
            foreach (char ch in ContractPeriod.Text)
            {
                if (!char.IsDigit(ch))
                    return false;
            }
            return true;
        }
        private bool neigbors()
        {
            foreach (char ch in Neigbors.Text)
            {
                if (Convert.ToInt32(ch) < 0 || Convert.ToInt32(ch) > 9)
                    return false;
            }
            return true;
        }
        private void North_CheckedChanged(object sender, EventArgs e)
        { North.Checked = !(North.Checked); }
        private void South_CheckedChanged(object sender, EventArgs e)
        { South.Checked = !(South.Checked); }
        private void East_CheckedChanged(object sender, EventArgs e)
        { East.Checked = !(East.Checked); }
        private void West_CheckedChanged(object sender, EventArgs e)
        { West.Checked = !(West.Checked); }
        private bool tz()
        {
            if (owntz.Text != "" && owntz.Text.Length == 9)
            {
                return owntz.Text.All(char.IsNumber);
            }
            return false;
        }
        private bool Fname()
        { return fname.Text != ""; }
        private bool Lname()
        { return lname.Text != ""; }
        private bool MobilePhone()
        {
            if (mobilephone.Text == "")
            { return false; }
            return mobilephone.Text.All(char.IsDigit);
        }
        private bool Phone_number()
        {
            if (phone.Text == "")
            { return false; }
            return phone.Text.All(char.IsDigit);
        }

        #endregion

        private void Add_furniture_Click(object sender, EventArgs e)
        {
            using (ApartContext db = new ApartContext())
            {
                Apart_ForRent q = db.Aparts_ForRent.Where(o => o.Id == Apartid).FirstOrDefault();
                Furniture f = db.Furnitures.Where(o => o.Name == New_furniture.Text).FirstOrDefault();
                if (f == null)
                {
                    Furniture F = new Furniture();
                    F.Name = New_furniture.Text;
                    f = F;
                    db.Furnitures.Add(f);
                }           
                q.Furnitures.Add(f);
                db.SaveChanges();
                MessageBox.Show("Added");
                Furniture.Items.Add(f.Name);
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            using (ApartContext db = new ApartContext())
            {
                Apart_ForRent q = db.Aparts_ForRent.Where(o => o.Id == Apartid).FirstOrDefault();
                int x = Furniture.SelectedIndex;
                if (x >= 0)
                {
                    string name = Furniture.Items[x].ToString();
                    Furniture furniture = db.Furnitures.FirstOrDefault(o => o.Name == name);
                    db.Aparts_ForRent.Attach(q);
                    q.Furnitures.Remove(furniture);
                    db.SaveChanges();
                    MessageBox.Show("Removed");
                    Furniture.Items.Remove(Furniture.Items[Furniture.SelectedIndex]);
                    Furniture.SelectedIndex = -1;
                }
            }
        }

        private void AddOwner_Click(object sender, EventArgs e)
        {
            using (ApartContext db = new ApartContext())
            {
                if (tz() && Fname() && Lname() && MobilePhone())
                {
                    Owner_Details o;
                    Owner_Details w = db.Owner.Where(i => i.Tz == Tz.Text).FirstOrDefault();
                    if (w == null)
                        o = new Owner_Details() { Tz = owntz.Text, Fname = fname.Text, Lname = lname.Text, MobilePhone_number = mobilephone.Text };
                    else
                        o = w;
                    if (Phone_number())
                        o.Phone_number = phone.Text;
                    Apart_ForRent q = db.Aparts_ForRent.Where(p => p.Id == Apartid).FirstOrDefault();
                    db.Owner.Add(o);
                    o.Aparts.Add(q);
                    q.Apart_Owners.Add(o);
                    db.SaveChanges();
                    MessageBox.Show("Added");
                    owners.Items.Add(o.Tz);
                }
            }
        }

        private void Remove_owner_Click(object sender, EventArgs e)
        {
            using (ApartContext db = new ApartContext())
            {
                Apart_ForRent q = db.Aparts_ForRent.Where(o => o.Id == Apartid).FirstOrDefault();
                int x = owners.SelectedIndex;
                if (x >= 0)
                {
                    string tz = owners.Items[x].ToString();
                    Owner_Details owner = db.Owner.FirstOrDefault(o => o.Tz == tz);
                    db.Aparts_ForRent.Attach(q);
                    q.Apart_Owners.Remove(owner);
                    db.SaveChanges();
                    MessageBox.Show("Removed");
                    owners.Items.Remove(owners.Items[owners.SelectedIndex]);
                    owners.SelectedIndex = -1;
                }
            }
        }

    }
}
   
