using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;
using MySql.Data.MySqlClient;


/* ----TO DO----
 * FIX SEARCH BAR
 * ADD API YEAR BUTTON
 * SET UP DATABASE COMMANDS
 * ADD FILE SAVE
 * ROTATE SCREEN
 */
 

namespace CervenecJustin_FinalProject
{

    public partial class Form1 : Form
    {
        DataTable theData = new DataTable();
        MySqlConnection conn = new MySqlConnection();

        int number;//vsriable for counting selected stock index
        //variables used during process
        WebClient aipConn = new WebClient();
        //string to hold start of API
     
        //string to hold completed API
        string apiEndPoint;
        List<Data> numbersList = new List<Data>();

        public Form1()
        {
            InitializeComponent();
            string connString = DbUtilities.BuildConnection();

            conn = DbUtilities.Connect(connString);
            HandleClientWindowSize();
        }
        //Place this inside the class space in the form you would like to size.
        //Call this method AFTER InitializeComponent() inside the form's constructor.
        void HandleClientWindowSize()
        {
            //Modify ONLY these float values
            float HeightValueToChange = 1.4f;
            float WidthValueToChange = 6.0f;

            //DO NOT MODIFY THIS CODE
            int height = Convert.ToInt32(Screen.PrimaryScreen.WorkingArea.Size.Height / HeightValueToChange);
            int width = Convert.ToInt32(Screen.PrimaryScreen.WorkingArea.Size.Width / WidthValueToChange);
            if (height < Size.Height)
                height = Size.Height;
            if (width < Size.Width)
                width = Size.Width;
            this.Size = new Size(width, height);
            this.Size = new Size(376, 720);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {//Exits the App when selected
            Application.Exit();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            //This gets math facts related to the random number genterated from API
            string startAPI = "http://numbersapi.com/random/math?json";
            //string to hold completed API
            string apiEndPoint;

            //Array for the  symbols from the listview
            string[] dataSymbols = new string[] { };
            numbersList.Clear();
            //array for selected to get
            int[] dataArray = new int[listBox1.SelectedItems.Count];


            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                dataArray[i] = listBox1.SelectedIndices[i];
            }
            string[] APisymbol = new string[dataArray.Length];

            for (int n = 0; n < dataArray.Length; n++)
            {
                APisymbol[n] = dataSymbols[dataArray[n]];
            }

            string[] arrayStock = APisymbol;

            string apiString = string.Join(",", APisymbol);

            apiEndPoint = startAPI + apiString;

            textInfo.Text = apiEndPoint;
            try
            {
               

                //Checks for internet connection
                var apiData = aipConn.DownloadString(apiEndPoint);

                //Object to parse Api data pulled for variables below
                JObject JSONOB = JObject.Parse(apiData);

               
                
                    Data numberData = new Data();
                    string number;
                    string info;
                  
                    //gets the json object for the data
                   
                    info = JSONOB["text"].ToString();
                  number = JSONOB["number"].ToString();

                    decimal num;
                    decimal.TryParse(number, out num);
                    numberData.Number = num;
                    numberData.Info = info;


               
                
                    //Adds data to Listbox from pulled Number API information.
                    numbersList.Add(numberData);
                listBox1.Items.Add(info);
                textNumber.Text = number;
              
            }
            catch
            {

            }

          

            //textInfo.Text = numbersList[0].Info;
            //numericUpDownNumber.Value = numbersList[0].Number;
        }

        private void btnRandomTrivia_Click(object sender, EventArgs e)
        {
            //This gets data of trivia related stuff from the random number generated
            string startAPI = "http://numbersapi.com/random/trivia?json";
            //string to hold completed API
            string apiEndPoint;

            //Array for the symbols from the listview
            string[] dataSymbols = new string[] { };
            numbersList.Clear();
            //array for  selected to get
            int[] dataArray = new int[listBox1.SelectedItems.Count];


            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                dataArray[i] = listBox1.SelectedIndices[i];
            }
            string[] APisymbol = new string[dataArray.Length];

            for (int n = 0; n < dataArray.Length; n++)
            {
                APisymbol[n] = dataSymbols[dataArray[n]];
            }

            string[] arrayStock = APisymbol;

            string apiString = string.Join(",", APisymbol);

            apiEndPoint = startAPI + apiString;

           textInfo.Text = apiEndPoint;
            try
            {


                //Checks for internet connection
                var apiData = aipConn.DownloadString(apiEndPoint);

                //Object to parse Api data pulled for variables below
                JObject JSONOB = JObject.Parse(apiData);



                Data numberData = new Data();
                string number;
                string info;

                //gets the json object for the data

                info = JSONOB["text"].ToString();
                number = JSONOB["number"].ToString();

                decimal num;
                decimal.TryParse(number, out num);
                numberData.Number = num;
                numberData.Info = info;




                //Adds data to Listbox from pulled Number api information.
                numbersList.Add(numberData);
                listBox1.Items.Add(info);
                textNumber.Text = number;
            }
            catch
            {

            }

        }

        private void btnRandomDate_Click(object sender, EventArgs e)
        {
            //This gets data of trivia related stuff from the random number generated
            string startAPI = "http://numbersapi.com/random/date?json";
            //string to hold completed API
            string apiEndPoint;

            //Array for the symbols from the listview
            string[] dataSymbols = new string[] { };
            numbersList.Clear();
            //array for  selected to get
            int[] dataArray = new int[listBox1.SelectedItems.Count];


            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                dataArray[i] = listBox1.SelectedIndices[i];
            }
            string[] APisymbol = new string[dataArray.Length];

            for (int n = 0; n < dataArray.Length; n++)
            {
                APisymbol[n] = dataSymbols[dataArray[n]];
            }

            string[] arrayStock = APisymbol;

            string apiString = string.Join(",", APisymbol);

            apiEndPoint = startAPI + apiString;

            // textInfo.Text = apiEndPoint;
            try
            {


                //Checks for internet connection
                var apiData = aipConn.DownloadString(apiEndPoint);

                //Object to parse Api data pulled for variables below
                JObject JSONOB = JObject.Parse(apiData);



                Data numberData = new Data();
                string number;
                string info;

                //gets the json object for the data

                info = JSONOB["text"].ToString();
                number = JSONOB["number"].ToString();

                decimal num;
                decimal.TryParse(number, out num);
                numberData.Number = num;
                numberData.Info = info;




                //Adds data to Listbox from pulled Number api information.
                numbersList.Add(numberData);
                listBox1.Items.Add(info);
                textNumber.Text = number;
            }
            catch
            {

            }
        }


        private void btnYear_Click(object sender, EventArgs e)
        {
            //This gets data of trivia related stuff from the random number generated
            string startAPI = "http://numbersapi.com/random/year?json";
            //string to hold completed API
            string apiEndPoint;

            //Array for the symbols from the listview
            string[] dataSymbols = new string[] { };
            numbersList.Clear();
            //array for  selected to get
            int[] dataArray = new int[listBox1.SelectedItems.Count];


            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                dataArray[i] = listBox1.SelectedIndices[i];
            }
            string[] APisymbol = new string[dataArray.Length];

            for (int n = 0; n < dataArray.Length; n++)
            {
                APisymbol[n] = dataSymbols[dataArray[n]];
            }

            string[] arrayStock = APisymbol;

            string apiString = string.Join(",", APisymbol);

            apiEndPoint = startAPI + apiString;

            // textInfo.Text = apiEndPoint;
            try
            {


                //Checks for internet connection
                var apiData = aipConn.DownloadString(apiEndPoint);

                //Object to parse Api data pulled for variables below
                JObject JSONOB = JObject.Parse(apiData);



                Data numberData = new Data();
                string number;
                string info;

                //gets the json object for the data

                info = JSONOB["text"].ToString();
                number = JSONOB["number"].ToString();

                decimal num;
                decimal.TryParse(number, out num);
                numberData.Number = num;
                numberData.Info = info;




                //Adds data to Listbox from pulled Number api information.
                numbersList.Add(numberData);
                listBox1.Items.Add(info);
                textNumber.Text = number;
            }
            catch
            {

            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

     
            if ( listBox1.FindString(textInfo.Text)!=-1)
            {
                listBox1.SelectedIndex = listBox1.FindString(textInfo.Text);
            }

            else
            {
                listBox1.SelectedItem = this;
                MessageBox.Show("Not Found");
            }
        }


        //private void UpdateMath(Data updatedData, Data oldData)
        //{
        //    //Method to update the database with any changed information
        //    Data dataToUpdate = updatedData;
        //    Data dataToCheck = oldData;

        //    try
        //    {

        //        conn.Open();


        //        string updateSql = $"Update Math SET Number = '{dataToUpdate.Number}', Info = '{dataToUpdate.Info}' where Number = '{dataToCheck.Number}';";


        //        MySqlCommand updatecmd = new MySqlCommand(updateSql, conn);
        //        MySqlDataReader reader1;

        //        reader1 = updatecmd.ExecuteReader();

        //        conn.Close();

        //    }
        //    catch (MySqlException e)

        //    {
        //        MessageBox.Show($"ah shoot\n\n {e}");
        //    }

    }

}

