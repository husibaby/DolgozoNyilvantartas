using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using DolgozoNyilvantartasGrafikus;

namespace DolgozoNyilvantartasGrafikus
{
    public partial class Form1 : Form
    {

        string endPoint = ReadSetting("endPoint");
        HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listaFrissitese();
        }
        private async void listaFrissitese()
        {
            listBox_worker.Items.Clear();
            try
            {
                HttpResponseMessage response = await client.GetAsync(endPoint);
                if (response.IsSuccessStatusCode)
                {
                    // Válasz szöveg beolvasása JSON formátumban
                    string jsonResponse = await response.Content.ReadAsStringAsync();

                    var dolgozok = Worker.FromJson(jsonResponse);

                    foreach (Worker item in dolgozok)
                    {
                        listBox_worker.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("Sikertelen API kérés: " + response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Sikertelen API kérés: " + ex.Message);
            }
        }


        static string ReadSetting(string key)
        {
            string result = string.Empty;
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                result = appSettings[key] ?? "Not Found";
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
            return result;
        }
        private void listBox_Worker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Worker worker = (Worker)listBox_worker.SelectedItem;
            textBox_id.Text = worker.Id.ToString();
            textBox_name.Text = worker.Name.ToString();
            textBox_position.Text = worker.Position.ToString();
            numericUpDown_salary.Value = worker.Salary;
        }
        private void button_read_Click(object sender, EventArgs e)
        {
            listaFrissitese();
        }
        private void button_update_Click(object sender, EventArgs e)
        {
            //-- Update a dolgozó adatait a PUT metódussal frissítjük a REST API-n keresztül
            Worker worker = new Worker();
            worker.Id = Convert.ToInt32(textBox_id.Text);
            if (worker.Id > 0)
            {
                if (string.IsNullOrEmpty(textBox_name.Text) || string.IsNullOrEmpty(textBox_position.Text))
                {
                    MessageBox.Show("Név és pozició mezők kitöltése kötelező");
                    return;
                }
                worker.Name = textBox_name.Text;
                worker.Position = textBox_position.Text;
                worker.Salary = Convert.ToInt32(numericUpDown_salary.Value);
                var json = JsonConvert.SerializeObject(worker);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                var response = client.PutAsync(endPoint + "/" + worker.Id, data).Result;
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Sikeres frissítés");
                    listaFrissitese();
                }
                else
                {
                    MessageBox.Show("Sikertelen frissítés: " + response.ReasonPhrase);
                }
            }
            bevitelimezokKiuritese();
        }
        private void bevitelimezokKiuritese()
        {
            textBox_position.Text = "";
            textBox_id.Text = "";
            textBox_name.Text = "";
            numericUpDown_salary.Value = numericUpDown_salary.Minimum;
        }
        private void button_insert_Click(object sender, EventArgs e)
        {
            //-- Új dolgozó adatainak felvitele a REST API-n keresztül
            Worker worker = new Worker();
            if (string.IsNullOrEmpty(textBox_name.Text) || string.IsNullOrEmpty(textBox_position.Text))
            {
                MessageBox.Show("Név és pozició mezők kitöltése kötelező");
                return;
            }
            worker.Name = textBox_name.Text;
            worker.Position = textBox_position.Text;
            worker.Salary = Convert.ToInt32(numericUpDown_salary.Value);
            var json = JsonConvert.SerializeObject(worker);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = client.PostAsync(endPoint, data).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Sikeres felvitel");
                listaFrissitese();
            }
            else
            {
                MessageBox.Show("Sikertelen felvitel: " + response.ReasonPhrase);
            }
            bevitelimezokKiuritese();
            listaFrissitese();
        }
        private void button_delete_Click(object sender, EventArgs e)
        {
            //-- Dolgozó törlése a REST API-n keresztül
            Worker worker = (Worker)listBox_worker.SelectedItem;
            if (worker != null)
            {
                var response = client.DeleteAsync(endPoint + "/" + worker.Id).Result;
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Sikeres törlés");
                    listaFrissitese();
                }
                else
                {
                    MessageBox.Show("Sikertelen törlés: " + response.ReasonPhrase);
                }
            }
            bevitelimezokKiuritese();
            listaFrissitese();
        }
    }
}
