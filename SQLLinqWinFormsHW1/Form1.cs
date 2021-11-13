using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLLinqWinFormsHW1
{
    public partial class Form1 : Form
    {
        private readonly GeolocationDataContext db;
        DataTable data;
        public Form1()
        {
            InitializeComponent();
            db = new GeolocationDataContext();
            CreateDB(db);
            data = new DataTable();
            dgData.DataSource = data;
        }

        public void CreateDB(GeolocationDataContext context)
        {
            if (context.DatabaseExists())
            {
                MessageBox.Show("Database already exists");
            }
            else
            {
                context.CreateDatabase();
                InsertData(context);
                MessageBox.Show("Database has been created");
            }
        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            data = new DataTable();
            dgData.DataSource = null;
            int index = comboBoxTables.SelectedIndex;
            
            if(index == 0)
            {
                dgData.DataSource = db.Cities.OrderBy(x=>x.Id);
            }
            else if (index == 1)
            {
                dgData.DataSource = db.Countries.OrderBy(x => x.Id);
            }
            else if (index == 2)
            {
                dgData.DataSource = db.Continents.OrderBy(x => x.Id);
            }
        }
        private void btnUpdTable_Click(object sender, EventArgs e)
        {
            db.SubmitChanges();
        }
        private void comboBoxQueries_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxList.SelectedIndex = -1;
            comboBoxList.Items.Clear();
            comboBoxList.Enabled = true;
            if (comboBoxQueries.SelectedIndex == 0)
            {
                foreach (var item in db.Continents)
                {
                    comboBoxList.Items.Add(item.Name);
                }
            }
            else if (comboBoxQueries.SelectedIndex == 1)
            {
                foreach (var item in db.Countries)
                {
                    comboBoxList.Items.Add(item.Name);
                }
            }
            else
            {
                comboBoxList.Enabled = false;
            }
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            data = new DataTable();
            dgData.DataSource = null;
            int index = comboBoxQueries.SelectedIndex;

            switch (index)
            {
                case 0:
                    if (comboBoxList.SelectedIndex != -1)
                    {
                        dgData.DataSource = db.Countries
                            .Where(x => x.Continent.Name == comboBoxList.SelectedItem.ToString())
                            .OrderBy(x => x.Id);
                    }
                    break;
                case 1:
                    if (comboBoxList.SelectedIndex != -1)
                    {
                        dgData.DataSource = db.Cities
                        .Where(x => x.Country.Name == comboBoxList.SelectedItem.ToString())
                        .OrderBy(x => x.Id);
                    }
                    break;
                case 2:
                    dgData.DataSource = db.Cities
                        .Where(x => x.IsCapital == true)
                        .OrderBy(x => x.Id);
                    break;
                case 3:
                    dgData.DataSource = db.Countries
                        .OrderByDescending(x => x.Area)
                        .Take(5);
                    break;
                case 4:
                    dgData.DataSource = db.Countries
                        .OrderByDescending(x => x.Cities.Sum
                        (y => y.Population))
                        .Take(5);
                    break;
                case 5:
                    dgData.DataSource = db.Cities
                        .OrderByDescending(x => x.Population)
                        .Take(5);
                    break;
                case 6:
                    dgData.DataSource = db.Continents
                        .OrderByDescending(x => x.Countries.Sum
                        (y => y.Area))
                        .Take(3);
                    break;
                case 7:
                    dgData.DataSource = db.Continents
                        .OrderByDescending(x => x.Countries.Sum
                        (y => y.Cities.Sum
                        (z => z.Population)))
                        .Take(3);
                    break;
                default:
                    break;
            }
        }

        public void InsertData(GeolocationDataContext context)
        {
            Continent[] continents =
            {
                new Continent{Name = "North America"},
                new Continent{Name = "South America"},
                new Continent{Name = "Africa"},
                new Continent{Name = "Europe"},
                new Continent{Name = "Asia"},
                new Continent{Name = "Australia"}
            };

            foreach (var continent in continents)
            {
                context.Continents.InsertOnSubmit(continent);
            }

            Country[] countries =
            {
                new Country{Name = "USA", Area = 9834000, ContinentId = 1},
                new Country{Name = "Canada", Area = 9985000, ContinentId = 1},
                new Country{Name = "Mexico", Area = 1973000, ContinentId = 1},

                new Country{Name = "Brazil", Area = 8516000, ContinentId = 2},
                new Country{Name = "Peru", Area = 1285000, ContinentId = 2},
                new Country{Name = "Venezuela", Area = 916000, ContinentId = 2},

                new Country{Name = "Algeria", Area = 2381000, ContinentId = 3},
                new Country{Name = "RSA", Area = 1220000, ContinentId = 3},
                new Country{Name = "Madagascar", Area = 587000, ContinentId = 3},

                new Country{Name = "UK", Area = 242000, ContinentId = 4},
                new Country{Name = "France", Area = 632000, ContinentId = 4},
                new Country{Name = "Germany", Area = 357000, ContinentId = 4},

                new Country{Name = "Japan", Area = 378000, ContinentId = 5},
                new Country{Name = "South Korea", Area = 100000, ContinentId = 5},
                new Country{Name = "China", Area = 10596000, ContinentId = 5},

                new Country{Name = "Australia", Area = 7692000, ContinentId = 6}
            };

            foreach (var country in countries)
            {
                context.Countries.InsertOnSubmit(country);
            }


            City[] cities =
            {
                new City{Name = "Washington", CountryId=1, IsCapital = true, Population = 692683},
                new City{Name = "New-York", CountryId=1, IsCapital = false, Population = 8419000},
                new City{Name = "Ottawa", CountryId=2, IsCapital = true, Population = 934243 },
                new City{Name = "Toronto", CountryId=2, IsCapital = false, Population = 2503281},
                new City{Name = "Mexico City", CountryId=3, IsCapital=true, Population=9100000},

                new City{Name = "Brasilia", CountryId=4, IsCapital=true, Population=4291577},
                new City{Name = "Rio de Janeiro", CountryId=4, IsCapital=false, Population=12280702},
                new City{Name = "Lima", CountryId=5, IsCapital=true, Population=9735587},
                new City{Name = "Caracas", CountryId=6, IsCapital=true, Population=2245744},

                new City{Name = "Algeries", CountryId=7, IsCapital=true, Population=7896923},
                new City{Name = "Pretoria", CountryId=8, IsCapital=true, Population=2921488},
                new City{Name = "Cape Town", CountryId=8, IsCapital=true, Population=3740026},
                new City{Name = "Bloemfontein", CountryId=8, IsCapital=true, Population=747431},
                new City{Name = "Johannesburg", CountryId=8, IsCapital=false, Population=10500000},
                new City{Name = "Antananarivo", CountryId=9, IsCapital=true, Population=1275207},

                new City{Name = "London", CountryId=10, IsCapital=true, Population=1234567},
                new City{Name = "Paris", CountryId=11, IsCapital=true, Population=1000000},
                new City{Name = "Berlin", CountryId=12, IsCapital=true, Population=9999999},

                new City{Name = "Tokyo", CountryId=13, IsCapital=true, Population=37468000},
                new City{Name = "Seoul", CountryId=14, IsCapital=true, Population=9500000},
                new City{Name = "Beijing", CountryId=15, IsCapital=true, Population=21450000},

                new City{Name = "Canberra", CountryId=15, IsCapital=true, Population=5367206},
                new City{Name = "Sydney", CountryId=15, IsCapital=false, Population=21450000}
            };

            foreach (var city in cities)
            {
                context.Cities.InsertOnSubmit(city);
            }

            context.SubmitChanges();
        }

    }
}
