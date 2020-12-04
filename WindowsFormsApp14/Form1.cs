using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = null;
        MySqlCommand sql = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "tagdij";
            sb.CharacterSet = "utf8";
            conn = new MySqlConnection(sb.ToString());

            try
            {
                conn.Open();
                sql = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            numericUpDown_SzuletesiEv.Maximum = DateTime.Today.Year;
            Ugyfellista_update();
        }

        private void Ugyfellista_update()
        {
            listBox_Ugyfel.Items.Clear();
            sql.CommandText = "SELECT `azon`,`nev`,`szulev`,`irszam`,`orsz` FROM `ugyfel` WHERE 1";
            using (MySqlDataReader dr = sql.ExecuteReader())
            {
                while (dr.Read())
                {
                    listBox_Ugyfel.Items.Add(new Ugyfel(dr.GetInt32("azon"), dr.GetString("nev"), dr.GetDecimal("irszam"), dr.GetDecimal("szulev"), dr.GetString("orsz")));
                }
            }
        }

        private void listBox_Ugyfel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Ugyfel.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztva ügyfél!");
                return;
            }
            Ugyfel kiv = (Ugyfel)listBox_Ugyfel.SelectedItem;
            textBox_id.Text = kiv.Azon.ToString();
            textBox_Nev.Text = kiv.Nev;
            numericUpDown_Iranyitoszam.Value = kiv.Irszam;
            numericUpDown_SzuletesiEv.Value = kiv.Szulev;
            textBox_Orszag.Text = kiv.Orszag;
        }

        private void button_insert_Click(object sender, EventArgs e)
        {

            if (adatlap_valid())
            {
                //-- Adatok vannak, rögzítjük az adatbázisban
                sql.CommandText = "INSERT INTO `ugyfel` (`azon`, `nev`, `szulev`, `irszam`, `orsz`) VALUES(NULL, '" + textBox_Nev.Text.Trim() + "', '" + numericUpDown_SzuletesiEv.Value.ToString() + "', '" + 
numericUpDown_Iranyitoszam.Value.ToString() + "', '" + textBox_Orszag.Text.Trim() + "');";
                try
                {
                    if (sql.ExecuteNonQuery() == 1)
                    {
                        reset_adatlap();
                        MessageBox.Show("Adatok sikeresen rögzítve!");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            Ugyfellista_update();
        }

        private void reset_adatlap()
        {
            textBox_id.Text = "";
            textBox_Nev.Text = "";
            textBox_Orszag.Text = "";
            numericUpDown_Iranyitoszam.Value = 0;
            numericUpDown_SzuletesiEv.Value = 1000;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (listBox_Ugyfel.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztott ügyfél!");
                return;
            }
            sql.CommandText = "delete from ugyfel where azon=" + textBox_id.Text;
            if (sql.ExecuteNonQuery() == 1)
            {
                reset_adatlap();
                MessageBox.Show("Sikeres törlés");
            }
            else
            {
                MessageBox.Show("A törlés sikertelen!");
            }
            Ugyfellista_update();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (adatlap_valid())
            {
                // adatok megfelelnek, módosíthatjuk
                sql.CommandText = "UPDATE `ugyfel` " +
                    "SET `nev`='" + textBox_Nev.Text.Trim() + "'," +
                    "`szulev`=" + numericUpDown_SzuletesiEv.Value + "," +
                    "`irszam`=" + numericUpDown_Iranyitoszam.Value + "," +
                    "`orsz`='" + textBox_Orszag.Text.Trim() + "' " +
                    "WHERE azon=" + textBox_id.Text;
                if (sql.ExecuteNonQuery() == 1)
                {
                    Ugyfellista_update();
                    MessageBox.Show("Módosítás sikeres");
                }
                else
                {
                    MessageBox.Show("A módosítás sikertelen");
                }
            }
        }

        private bool adatlap_valid()
        {
            if (string.IsNullOrWhiteSpace(textBox_Nev.Text) || textBox_Nev.Text.Trim().Length < 3)
            {
                MessageBox.Show("Nincs megadva név!");
                return false;
            }
            if (numericUpDown_Iranyitoszam.Value < 1000)
            {
                MessageBox.Show("Adja meg az irányítószámot");
                numericUpDown_Iranyitoszam.Focus();
                return false;
            }
            if (numericUpDown_SzuletesiEv.Value > DateTime.Today.Year || numericUpDown_SzuletesiEv.Value < DateTime.Today.Year - 150)
            {
                MessageBox.Show("Az évszám nem megfelelő");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox_Orszag.Text))
            {
                MessageBox.Show("nincs megadva ország!");
                return false;
            }
            return true;
        }
    }
}
