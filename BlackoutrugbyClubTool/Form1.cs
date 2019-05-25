using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
// Added to default visual studio template
using System.Net;
using System.Xml;
using System.Xml.Linq;
// Requirements for using the BR API
using System.Security.Cryptography;
using System.IO;
//Custom Namespaces
using BRAPI;


namespace BlackoutrugbyClubTool
{
    public partial class Form1 : Form
    {
        manager manager = new manager();
        team team = new team();
        player player = new player();



        public Form1()
        {

            InitializeComponent();
           



        }

        public string BRAPI_encrypt(string encrypt_Input)
        {

            // Assign the developer details to variables got from the UI textboxes
            string devID = "1038";
            string devKey = "2yysSrd2fZxuOu5y";
            string devIV = "sUMf1bNSzcaitday";
            

            #region CODE FROM BR Documentation - http://www.blackoutrugby.com/game/help.documentation.php#category=35
            // This is all from the Blackout Rugby documentation
            // only changes are variables instead of direct string input 

            // Create an unencrypted request as an array of bytes
            byte[] request = UTF8Encoding.UTF8.GetBytes(encrypt_Input);

            // Set the key and IV as arrays of bytes
            byte[] key = UTF8Encoding.UTF8.GetBytes(devKey);
            byte[] iv = UTF8Encoding.UTF8.GetBytes(devIV);

            // Create an instance of the AES Encryptor
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();

            // Set the key and IV
            aes.Key = key;
            aes.IV = iv;

            // Set the mode of the AES Encryptor
            aes.Mode = CipherMode.CBC;

            // Set the padding mode of the AES Encryptor
            aes.Padding = PaddingMode.Zeros;

            // Get the transformer from the AES Encryptor
            ICryptoTransform cTransform = aes.CreateEncryptor();

            // Use the transformer to encrypt our request
            byte[] result =
              cTransform.TransformFinalBlock(request, 0, request.Length);

            // Release resources held by AES Encryptor
            aes.Clear();

            // Encode to base64
            string encryptedRequest =
              Convert.ToBase64String(result, 0, result.Length);

            // Send request to API
            //string baseURL = "http://api.blackoutrugby.com/";
            string requestString = devID + "&er=" + encryptedRequest;
            //string response = getWebResponse(requestString); // Second function is called here <---

            #region WebRequest Code

            // Create a request for the URL.  
            WebRequest webRequest = WebRequest.Create("http://classic-api.blackoutrugby.com/?d=" + requestString);

            WebResponse Webresponse = webRequest.GetResponse();

            //Get the stream containing content returned by the server.
            Stream dataStream = Webresponse.GetResponseStream();

            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);

            // Read the content.
            string responseFromServer = reader.ReadToEnd();

            
            // Clean up the streams and the response.
            reader.Close();
            Webresponse.Close();

            #endregion



            return responseFromServer;


            #endregion CODE FROM BR Documentation 


        }

       public void updateUI()
        {
            //DEBUG CODE
            //richTextBox1.AppendText("----------" + manager.Season + "------------\r");
            //richTextBox1.AppendText("----------" + manager.Round + "------------\r");
            //richTextBox1.AppendText("----------" + manager.Day + "------------\r");
            //richTextBox1.AppendText("----------" + manager.Username + "------------\r");
            //richTextBox1.AppendText("----------" + manager.Id + "------------\r");
            //richTextBox1.AppendText("----------" + manager.MainTeamId + "------------\r");
            //richTextBox1.AppendText("----------" + team.Name + "------------\r");
            //richTextBox1.AppendText("----------" + team.CountryIso + "------------\r");

            team_name_label.Text = team.Name;
            season_date_label.Text = "Season : " + manager.Season + "  Round : " + manager.Round + "  Day : " + manager.Day;
            manager_name_label.Text = "Manager : " + manager.Username + " ( " + manager.Id + " )";
            country_iso_label.Text = team.CountryIso;

            average_stamina_label.Text = "Stamina : " + player.Stamina;
            average_attack_label.Text = "Attack : " + player.Attack;
            average_technique_label.Text = "Technique : " + player.Technique;
            average_jumping_label.Text = "Jumping : " + player.Jumping;
            average_agility_label.Text = "Agility : " + player.Agility;
            average_handling_label.Text = "Handling : " + player.Handling;
            average_defense_label.Text = "Defense : " + player.Defense;
            average_strength_label.Text = "Strength : " + player.Strength;
            average_speed_label.Text = "Speed : " + player.Speed;
            average_kicking_label.Text = "Kicking : " + player.Kicking;
            team_fatness_label.Text = "Team Fatness : " + player.Fatness;
            team_form_label.Text = "Team Form : " + player.Form;
            team_energy_label.Text = "Team Energy : " + player.Energy;

            


            //richTextBox1.AppendText("----------" + player[22].Name + "------------\r");
            //richTextBox1.AppendText("----------" + player[22].Csr + "------------\r");
            //richTextBox1.AppendText("----------" + player[22].Age + "------------\r");
            //richTextBox1.AppendText("----------" + player[21].Name + "------------\r");
            //richTextBox1.AppendText("----------" + player[21].Csr + "------------\r");
            //richTextBox1.AppendText("----------" + player[21].Age + "------------\r");


            //DEBUG CODE
        }


        private void button1_Click(object sender, EventArgs e)
        {

            // Access Key from the textbox, trimmed to fit the request format
            string trimedKey = textBox1.Text.Remove(0, 2);
            // Request string for memmber details
            string member_request = "&r=m&memberid=";

            //Sending request for encryption and in tern to the api
            string apiResponse = BRAPI_encrypt(member_request + trimedKey);

            //Create an XElement object and parse the api response
            XElement xmlResponse = XElement.Parse(apiResponse);

            //First Read of the response stores BR season and round
            var _info = from selected in xmlResponse.Descendants("blackoutrugby_api_response") select selected;

            manager.Season = (string)xmlResponse.Attribute("season");
            manager.Round = (string)xmlResponse.Attribute("round");
            manager.Day = (string)xmlResponse.Attribute("day");

            //Second read of response stores id, username and main team id
            var _info2 = from selected in xmlResponse.Elements("member") select selected;
            foreach (XElement el in _info2)
            {

                manager.Id = (string)el.Element("id");
                manager.Username = (string)el.Element("username");
                manager.MainTeamId = (string)el.Element("main_teamid");

            }


            //Get Club Data
            apiResponse = BRAPI_encrypt("&r=t&teamid=" + manager.MainTeamId);

           
            xmlResponse = XElement.Parse(apiResponse);

            _info = from selected in xmlResponse.Elements("team") select selected;
            foreach (XElement el in _info)
            {
                team.Name = (string)el.Element("name");
                team.CountryIso = team.countryList((string)el.Element("country_iso")); 
                team.RankingPoints = (string)el.Element("ranking_points");
                team.RegionId = (string)el.Element("region");
                team.StadiumName = (string)el.Element("stadium");
                team.RegionalRank = (string)el.Element("regional_rank");
                team.NationalRank = (string)el.Element("national_rank");
                team.WorldRank = (string)el.Element("world_rank");
                
                
                //Finish this !!!

            }

            // Get Team Data
            apiResponse = BRAPI_encrypt(textBox1.Text + "&r=p&teamid=" + manager.MainTeamId);

            xmlResponse = XElement.Parse(apiResponse);

            var write = xmlResponse.ToString();
            File.WriteAllText(@"Team.xml", write);

            _info = from selected in xmlResponse.Elements("player") select selected;

            dataGridView_main.Rows.Clear();
            int count = 0;

            string position;
            float player_fatness, average_fatness;


            foreach (XElement el in _info)
            {
                player.Stamina += (int)el.Element("stamina");
                player.Attack += (int)el.Element("attack");
                player.Technique += (int)el.Element("technique");
                player.Jumping += (int)el.Element("jumping");
                player.Agility += (int)el.Element("agility");
                player.Handling += (int)el.Element("handling");
                player.Defense += (int)el.Element("defense");
                player.Strength += (int)el.Element("strength");
                player.Speed += (int)el.Element("speed");
                player.Kicking += (int)el.Element("kicking");
                
                average_fatness = ((float)el.Element("weight") / (float)el.Element("height")) * 100;

                player.Fatness += average_fatness;
                player.Form += (int)el.Element("form");
                player.Energy += (int)el.Element("energy");

                count++;
                richTextBox1.AppendText(count.ToString() + "\r");

            }


            player.Stamina /= count;
            player.Attack /= count;
            player.Technique /= count;
            player.Jumping /= count;
            player.Agility /= count;
            player.Handling /= count;
            player.Defense /= count;
            player.Strength /= count;
            player.Speed /= count;
            player.Kicking /= count;
            player.Fatness /= count;
            player.Form /= count;
            player.Energy /= count;









            foreach (XElement el in _info)
            {
                dataGridView_main.Rows.Add((string)el.Element("name"),
                                        (int)el.Element("age"),
                                        (string)el.Element("birthday"),
                                        team.countryList((string)el.Element("nationality")),
                                        (int)el.Element("csr"),
                                        (float)el.Element("weight"),
                                        (float)el.Element("height"),
                                        (int)el.Element("form"),
                                        (int)el.Element("energy"),
                                        (int)el.Element("stamina"),
                                        (int)el.Element("attack"),
                                        (int)el.Element("technique"),
                                        (int)el.Element("jumping"),
                                        (int)el.Element("agility"),
                                        (int)el.Element("handling"),
                                        (int)el.Element("defense"),
                                        (int)el.Element("strength"),
                                        (int)el.Element("speed"),
                                        (int)el.Element("kicking")
                                        );

                player_fatness = ((float)el.Element("weight") / (float)el.Element("height")) * 100;

                if (player_fatness > 50)
                {
                    position = "Forward";
                }
                else
                {
                    position = "Back";
                }



                dataGridView_averages.Rows.Add((string)el.Element("name"), player_fatness, position);
            }


            
            updateUI();


        }

       

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.Delete(@"team.xml");
        }

        
    }

    

}




