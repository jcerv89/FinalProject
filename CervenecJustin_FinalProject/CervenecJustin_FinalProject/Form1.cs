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
        string startAPI = "http://numbersapi.com/random/math?json";
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

        private void btnRandom_Click(object sender, EventArgs e)
        {
            //string startAPI = "http://numbersapi.com/random/math?json";
            //string to hold completed API
            string apiEndPoint;

            //Array for the Stock symbols from the listview
            string[] dataSymbols = new string[] { };
            numbersList.Clear();
            //array for stocks selected to get
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


               
                
                    //Adds data to List from pulled stock information.
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
    }
}

