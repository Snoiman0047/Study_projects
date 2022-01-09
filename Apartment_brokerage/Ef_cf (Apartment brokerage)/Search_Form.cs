using Ef_cf__Apartment_brokerage_.Class;
using NPOI.SS.Formula.Functions;
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
    public partial class Search_Form : Form
    {
        public Search_Form() 
        {
            InitializeComponent();
            using (ApartContext db = new ApartContext())
            {
                if (!db.Database.Exists())
                {
                    try
                    {
                        #region Furnitures

                        Furniture f = new Furniture() { Name = "Chair" };
                        Furniture F = new Furniture() { Name = "Table" };
                        Furniture ff = new Furniture() { Name = "Bed" };
                        Furniture FF = new Furniture() { Name = "Closet" };
                        Furniture fF = new Furniture() { Name = "Shelf" };
                        Furniture Ff = new Furniture() { Name = "Sofa" };

                        #endregion

                        #region Owners

                        Owner_Details o = new Owner_Details() { Tz = "315673491", Fname = "Avi", Lname = "Levi", MobilePhone_number = "0536674543", Phone_number = "039090774" };
                        Owner_Details O = new Owner_Details() { Tz = "028565697", Fname = "Tzvika", Lname = "Kohen", Phone_number = "069425655", MobilePhone_number = "058952410" };
                        Owner_Details oo = new Owner_Details() { Tz = "204562177", Fname = "Israel", Lname = "Fried", MobilePhone_number = "053-758-4415", Phone_number = "064517751" };
                        Owner_Details OO = new Owner_Details() { Tz = "208440717", Fname = "Yossi", Lname = "Meir", MobilePhone_number = "052-574-9913", Phone_number = "029847151" };

                        #endregion

                        #region Apart_Rent

                        Apart_ForRent r1 = new Apart_ForRent()
                        {
                            Address = new Apart_Address() { City = "Petah Tikva", Street = "Jerusalem", Floor = 3 },
                            Num_rooms = 2,
                            East = true,
                            Contract_period = 12,
                            Evacuation_date = DateTime.Now.AddYears(1),
                            With_airConditioning = true,
                            With_elevator = false,
                            Price = 5200
                        };

                        Apart_ForRent r2 = new Apart_ForRent()
                        {
                            Address = new Apart_Address() { City = "Elad", Street = "Rabbi Meir", Floor = 1, House_num = 101 },
                            Num_rooms = 4,
                            East = true,
                            North = true,
                            Contract_period = 18,
                            Evacuation_date = DateTime.Now.AddYears(2),
                            With_airConditioning = true,
                            With_elevator = true,
                            Price = 6000
                        };

                        Apart_ForRent r3 = new Apart_ForRent()
                        {
                            Address = new Apart_Address() { City = "Tel Aviv", Street = "Dizengoff", Floor = 7, House_num = 59 },
                            Num_rooms = 5,
                            West = true,
                            North = true,
                            Contract_period = 24,
                            Evacuation_date = DateTime.Now.AddYears(2),
                            With_airConditioning = true,
                            With_elevator = true,
                            Price = 8000
                        };

                        Apart_ForRent r4 = new Apart_ForRent()
                        {
                            Address = new Apart_Address() { City = "Tel Aviv", Street = "Alenbi", Floor = 3 },
                            West = true,
                            North = true,
                            Contract_period = 24,
                            Evacuation_date = DateTime.Now.AddMonths(6),
                            With_airConditioning = false,
                            With_elevator = false,
                            Price = 9500
                        };

                        #endregion

                        #region Apart_Sale

                        Apart_ForSale s1 = new Apart_ForSale()
                        {
                            Address = new Apart_Address() { City = "Ashdod", Street = "Ben Yehuda", Floor = 0, House_num = 103 },
                            Num_rooms = 4,
                            South = true,
                            East = true,
                            North = true,
                            Common_taboo = false,
                            Neighbors = 4,
                            Price = 1450000
                        };

                        Apart_ForSale s2 = new Apart_ForSale()
                        {
                            Address = new Apart_Address() { City = "Kiryat Gat", Street = "Rashi", Floor = 3 },
                            Common_taboo = true,
                            Num_rooms = 1,
                            West = true,
                            North = true,
                            Neighbors = 12,
                            Price = 75000
                        };

                        Apart_ForSale s3 = new Apart_ForSale()
                        {
                            Address = new Apart_Address() { City = "Jerusalem", Street = "Yafo", Floor = 4 },
                            Num_rooms = 5,
                            South = true,
                            East = true,
                            North = true,
                            Common_taboo = false,
                            Neighbors = 10,
                            Price = 2750000
                        };

                        #endregion

                        #region Add_to_db

                        db.Furnitures.Add(f);
                        db.Furnitures.Add(F);
                        db.Furnitures.Add(ff);
                        db.Furnitures.Add(FF);
                        db.Furnitures.Add(fF);
                        db.Furnitures.Add(Ff);

                        db.Owner.Add(o);
                        db.Owner.Add(O);
                        db.Owner.Add(oo);
                        db.Owner.Add(OO);

                        db.Aparts_ForRent.Add(r1);
                        db.Aparts_ForRent.Add(r2);
                        db.Aparts_ForRent.Add(r3);
                        db.Aparts_ForRent.Add(r4);

                        db.Aparts_ForSale.Add(s1);
                        db.Aparts_ForSale.Add(s2);
                        db.Aparts_ForSale.Add(s3);

                        #endregion

                        #region Relationship

                        r3.Furnitures.Add(ff);
                        r4.Furnitures.Add(f);
                        r2.Furnitures.Add(F);

                        r1.Apart_Owners.Add(o);
                        r2.Apart_Owners.Add(oo);
                        r3.Apart_Owners.Add(OO);
                        r4.Apart_Owners.Add(O);

                        #endregion

                        db.SaveChanges();
                        //MessageBox.Show("Create db");
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.Message); }
                }
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string s;
            if (sender is Button)
            {
                s = (sender as Button).Text;
            }
            else
                s = "Search";
            switch (ByType.Text)
                {
                    case "Apartment's for rent":
                        {
                            Rent_aparts(s);
                            break;
                        }
                    case "Apartment's for sale":
                        {
                            Sale_aparts(s);
                            break;
                        }
                    default:
                        {
                            ByType.SelectedIndex = 0;
                            All_aparts(s);
                            break;
                        }
                }
        }   
        private void Delate_Click(object sender, EventArgs e)
        {
            using (ApartContext db = new ApartContext())
            {
                string x = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                Apart_ForSale s = db.Aparts_ForSale.FirstOrDefault(p => p.Id.ToString() == x);
                if (s == null)
                {
                    Apart_ForRent r = db.Aparts_ForRent.FirstOrDefault(p => p.Id.ToString() == x);
                    if (r == null)
                    { return; }
                    else
                    {
                        var owner = db.Aparts_ForRent.Where(o => o.Id == r.Id).Select(k => k.Apart_Owners).ToList();
                        if (owner.Count > 0)
                        {
                            for (int i = 0; i < owner.Count; i++)
                            {
                                for (int j = 0; j < owner[i].Count; j++)
                                {
                                    r.Apart_Owners.Remove(owner[i][j]);
                                }
                            }
                        }
                        var furnitures = db.Aparts_ForRent.Where(o => o.Id == r.Id).Select(k => k.Furnitures).ToList();
                        if (furnitures.Count > 0)
                        {
                            for (int i = 0; i < furnitures.Count; i++)
                            {
                                for (int j = 0; j < furnitures[i].Count; j++)
                                {
                                    r.Furnitures.Remove(furnitures[i][j]);
                                }
                            }
                        }
                        db.Aparts_ForRent.Remove(r);
                    }
                }
                else
                { db.Aparts_ForSale.Remove(s); }
                db.SaveChanges();
                MessageBox.Show("Removed");
                Search_Click(sender, e);
            }
        }
        private void New_Click(object sender, EventArgs e)
        {
            using (ApartContext db = new ApartContext())
            {
                Detailes_Form df;
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
               
                if (ByType.Items[ByType.SelectedIndex] == "All apartment's")
                {
                    if (dataGridView1.SelectedRows[0].Cells[dataGridView1.SelectedRows[0].Cells.Count-1].Value.ToString() == "Sale")
                    {
                        df = new Detailes_Form(id, "Sale");
                        df.Show();
                    }
                    else
                    {
                        df = new Detailes_Form(id, "Rent");
                        df.Show();
                    }
                }
                if (ByType.Items[ByType.SelectedIndex] == "Apartment's for rent")
                {
                    if (id > 5 || id <= 0)
                        id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[4].Value);
                    df = new Detailes_Form(id, "Rent");
                    df.Show();
                }
                if (ByType.Items[ByType.SelectedIndex] == "Apartment's for sale")
                {
                    if (id > 7 || id < 5)
                        id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value);
                    df = new Detailes_Form(id, "Sale");
                    df.Show();
                }
            }
        }


        #region Apart_type

        private void All_aparts(string Sender = "Show all")
        {
            using (ApartContext db = new ApartContext())
            {
                var r = db.Aparts_ForRent.Select(o => new { o.Id, o.Address.City, o.Address.Street, o.South, o.West, o.North, o.East, o.Num_rooms, o.Price, Type = "Rent" });
                var s = db.Aparts_ForSale.Select(o => new { o.Id, o.Address.City, o.Address.Street, o.South, o.West, o.North, o.East, o.Num_rooms, o.Price, Type = "Sale" });
                var q = r.ToList().Union(s.ToList());


                if (Apart_City())
                {
                    q = q.Where(o => o.City == ByCity.Text);
                    var num = q.Count();
                    var min = q.Where(o => o.Price != null && o.Price >= 0).Min(o => o.Price);
                    var max = q.Where(o => o.Price != null && o.Price >= 0).Max(o => o.Price);
                    RentResults.Text = "Total apartment's found : " + num +
                                       "    Max price: " + max +
                                       "  Min price: " + min;
                }
                else
                { RentResults.Text = ""; }

                if (Apart_Street())
                { q = q.Where(o => o.Street == ByStreet.Text); }

                if (Owner_Tz() || With_Furniture())
                {
                    Rent_aparts(Sender);
                }
                else
                {
                    if (Price())
                    {
                        int price = Apart_Price();
                        q = q.Where(o => o.Price <= price);
                    }
                    if (Sender == "Search")
                    { dataGridView1.DataSource = q.Select(o => new { o.Id, o.City, o.Street, o.Num_rooms, o.Price, o.Type }).ToList(); }
                    else
                    { dataGridView1.DataSource = q.ToList(); }
                }
            }
        }

        private void Rent_aparts(string Sender = "Show all")
        {
            using (ApartContext db = new ApartContext())
            {
                var q = db.Aparts_ForRent.Select(o => o);

                if (Apart_City())
                {
                    q = q.Where(o => o.Address.City == ByCity.Text);
                    var num = q.Count();
                    var min = q.Where(o => o.Price != null && o.Price >= 0).Min(o => o.Price);
                    var max = q.Where(o => o.Price != null && o.Price >= 0).Max(o => o.Price);
                    RentResults.Text = "Total apartment's found : " + num +
                                       "    Max price: " + max +
                                       "  Min price: " + min;
                }
                else
                { RentResults.Text = ""; }

                if (Apart_Street())
                { q = q.Where(o => o.Address.Street == ByStreet.Text); }

                if (Owner_Tz())
                { q = q.Where(j => j.Apart_Owners.Any(p => p.Tz == ByTz.Text)); }

                if (With_Furniture())
                { q = q.Where(o => o.Furnitures.Count > 0); }

                if(Price())
                {
                    int price = Apart_Price();
                    q = q.Where(o => o.Price <= price); 
                }

                if (Sender == "Search")
                {
                    dataGridView1.DataSource = q.Select(o => new { o.Id, o.Address.City, o.Address.Street, o.Address.Floor, o.Address.House_num, o.Num_rooms, o.Price }).ToList();
                }
                else
                { dataGridView1.DataSource = q.ToList(); }
            }
        }

        private void Sale_aparts(string Sender = "Show all")
        {
            using (ApartContext db = new ApartContext())
            {
                var q = db.Aparts_ForSale.Select(o => o);

                if (Apart_City())
                {
                    q = q.Where(o => o.Address.City == ByCity.Text);
                    var num = q.Count();
                    var min = q.Where(o => o.Price != null && o.Price >= 0).Min(o => o.Price);
                    var max = q.Where(o => o.Price != null && o.Price >= 0).Max(o => o.Price);
                    RentResults.Text = "Total apartment's found : " + num +
                                       "    Max price: " + max +
                                       "  Min price: " + min;
                }
                else
                { RentResults.Text = ""; }

                if (Apart_Street())
                { q = q.Where(o => o.Address.Street == ByStreet.Text); }

                if (Owner_Tz())
                {
                    Rent_aparts(Sender);
                }
                else
                {
                    if (Price())
                    {
                        int price = Apart_Price();
                        q = q.Where(o => o.Price <= price);
                    }

                    if (Sender == "Search")
                    {
                        var p = q.Select(o => new { o.Id, o.Address.City, o.Address.Street, o.Address.Floor, o.Num_rooms, o.Price });
                        dataGridView1.DataSource = p.ToList();
                    }
                    else
                    { dataGridView1.DataSource = q.ToList(); }
                }
            }
        }

        #endregion


        #region Tests

        private bool With_Furniture()
        { return byFurnitures.Checked; }

        private bool Apart_City()
        { return ByCity.Text != "Search by city" && ByCity.Text != ""; }

        private bool Apart_Street()
        { return ByStreet.Text != "Search by street" && ByStreet.Text != ""; }

        private bool Owner_Tz()
        { return ByTz.Text != "Search by owner tz" && ByTz.Text != ""; }

        private bool Price()
        { return ByPrice.Checked; }

        private int Apart_Price()
        {
                switch (ByType.Text)
                {
                    case "Apartment's for rent":
                        {
                            return Calc_rentAVG();
                        }
                    case "Apartment's for sale":
                        {
                            return Calc_saleAVG();
                        }
                    default:
                        {
                            return Calc_apartAVG();
                        }
                }
            return 0;
        }

        private int Calc_rentAVG()
        {
           using(ApartContext db = new ApartContext ())
            {
                var price = db.Aparts_ForRent.Where(o => o.Price != null && o.Price >= 0).Sum(o => o.Price);
                var count = db.Aparts_ForRent.Count();
                if (price != null)
                    return int.Parse(price.ToString()) / count;
                return 0;
            }
        }

        private int Calc_saleAVG()
        {
            using (ApartContext db = new ApartContext())
            {
                var price = db.Aparts_ForSale.Where(o => o.Price != null && o.Price >= 0).Sum(o => o.Price);
                var count = db.Aparts_ForSale.Count();
                if (price != null)
                    return int.Parse(price.ToString()) / count;
                return 0;
            }
        }

        private int Calc_apartAVG()
        {
            using (ApartContext db = new ApartContext())
            {
                var r = db.Aparts_ForRent.Select(o => new { o.Id, o.Address.City, o.Address.Street, o.South, o.West, o.North, o.East, o.Num_rooms, o.Price, Type = "Rent" });
                var s = db.Aparts_ForSale.Select(o => new { o.Id, o.Address.City, o.Address.Street, o.South, o.West, o.North, o.East, o.Num_rooms, o.Price, Type = "Sale" });
                var q = r.ToList().Union(s.ToList());

                var price = q.Where(o => o.Price != null && o.Price >= 0).Sum(o => o.Price);
                var count = q.Count();
                if (price != null)
                    return int.Parse(price.ToString()) / count;
                return 0;
            }
        }

        #endregion

        private void Refresh_Click(object sender, EventArgs e)
        { Search_Click(sender, e); }
    }
}

