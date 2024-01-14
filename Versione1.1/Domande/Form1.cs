using Pico.Twitch;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Media;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domande
{

    public partial class Form1 : Form
    {


        static string oauth = "oauth:8nat9vw03g9eecmv7wjsds11nixxxo";
        TwitchChatHandle chat = new TwitchChatHandle(oauth, "");




        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; // Impedisci la chiusura della finestra
                Application.Exit(); // Chiudi completamente l'applicazione
            }
        }


        public Form1()
        {
         
            InitializeComponent();




            












            string processName = "Domande";

            int count = CountProcesses(processName);
            if (count >= 2)
            {
                count = 0;
                Close();
            }





        }
        int number;
        int broswer;

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox22.Text == "")
            {


            }
            else
            {
                SoundPlayer player = new SoundPlayer(textBox22.Text);

                player.PlayLooping();

            }







            timer4.Start();
            timer2.Stop();

            if (checkBox21.Checked == true)
            {
                timer3.Start();

            }
            else
            {
                timer1.Start();
            }



            Label label1 = new Label();
            label1.BackColor = Color.Transparent;

        }
        private void timer1_Tick(object sender, EventArgs e)
        {






            Random generator = new Random();
            for (int i = 0; i < 40; i++)
            {








                number = generator.Next(1, 41);
                if (number == 1)
                {

                    label1.Text = "1- " + Domanda1.Text.ToString();



                }

                if (number == 2)
                {

                    label1.Text = "2- " + Domanda2.Text.ToString();



                }
                if (number == 3)
                {

                    label1.Text = "3- " + Domanda3.Text.ToString();


                }
                if (number == 4)
                {

                    label1.Text = "4- " + Domanda4.Text.ToString();


                }
                if (number == 5)
                {

                    label1.Text = "5- " + Domanda5.Text.ToString();


                }

                if (number == 6)
                {

                    label1.Text = "6- " + Domanda6.Text.ToString();


                }

                if (number == 7)
                {

                    label1.Text = "7- " + Domanda7.Text.ToString();


                }
                if (number == 8)
                {

                    label1.Text = "8- " + Domanda8.Text.ToString();


                }
                if (number == 9)
                {

                    label1.Text = "9- " + Domanda9.Text.ToString();


                }
                if (number == 10)
                {

                    label1.Text = "10- " + Domanda10.Text.ToString();


                }

                if (number == 11)
                {

                    label1.Text = "11- " + Domanda11.Text.ToString();


                }
                if (number == 12)
                {

                    label1.Text = "12- " + Domanda12.Text.ToString();


                }
                if (number == 13)
                {

                    label1.Text = "13- " + Domanda13.Text.ToString();


                }
                if (number == 14)
                {

                    label1.Text = "14- " + Domanda14.Text.ToString();


                }
                if (number == 15)
                {

                    label1.Text = "15- " + Domanda15.Text.ToString();


                }
                if (number == 16)
                {

                    label1.Text = "16- " + Domanda16.Text.ToString();


                }
                if (number == 17)
                {

                    label1.Text = "17- " + Domanda17.Text.ToString();


                }
                if (number == 18)
                {

                    label1.Text = "18- " + Domanda18.Text.ToString();


                }
                if (number == 19)
                {

                    label1.Text = "19- " + Domanda19.Text.ToString();


                }
                if (number == 20)
                {

                    label1.Text = "20- " + Domanda20.Text.ToString();


                }




                if (number == 21)
                {

                    label1.Text = "21- " + Domanda21.Text.ToString();



                }

                if (number == 22)
                {

                    label1.Text = "22- " + Domanda22.Text.ToString();



                }
                if (number == 23)
                {

                    label1.Text = "23- " + Domanda23.Text.ToString();


                }
                if (number == 24)
                {

                    label1.Text = "24- " + Domanda24.Text.ToString();


                }
                if (number == 25)
                {

                    label1.Text = "25- " + Domanda25.Text.ToString();


                }

                if (number == 26)
                {

                    label1.Text = "26- " + Domanda26.Text.ToString();


                }

                if (number == 27)
                {

                    label1.Text = "27- " + Domanda27.Text.ToString();


                }
                if (number == 28)
                {

                    label1.Text = "28- " + Domanda28.Text.ToString();


                }
                if (number == 29)
                {

                    label1.Text = "29- " + Domanda29.Text.ToString();


                }
                if (number == 30)
                {

                    label1.Text = "30- " + Domanda30.Text.ToString();


                }

                if (number == 31)
                {

                    label1.Text = "31- " + Domanda31.Text.ToString();


                }
                if (number == 32)
                {

                    label1.Text = "32- " + Domanda32.Text.ToString();


                }
                if (number == 33)
                {

                    label1.Text = "33- " + Domanda33.Text.ToString();


                }
                if (number == 34)
                {

                    label1.Text = "34- " + Domanda34.Text.ToString();


                }
                if (number == 35)
                {

                    label1.Text = "35- " + Domanda35.Text.ToString();


                }
                if (number == 36)
                {

                    label1.Text = "36- " + Domanda36.Text.ToString();


                }
                if (number == 37)
                {

                    label1.Text = "37- " + Domanda37.Text.ToString();


                }
                if (number == 38)
                {

                    label1.Text = "38- " + Domanda38.Text.ToString();


                }
                if (number == 39)
                {

                    label1.Text = "39- " + Domanda39.Text.ToString();


                }
                if (number == 40)
                {

                    label1.Text = "40- " + Domanda40.Text.ToString();


                }


               





                Console.Read();
                if (number == 1)
                {







                    if (check1.Checked == false)
                    {

                        timer1.Stop();

                    }
                    else
                    {
                        label1.Text = "Attendere [.............................................]";

                        timer1.Start();


                    }
                }

                if (number == 2)
                {
                    if (check2.Checked == false)
                    {
                        timer1.Stop();

                    }
                    else
                    {
                        label1.Text = "Attendere [.........................................]";
                        timer1.Start();

                    }
                }

                if (number == 3)
                {
                    if (check3.Checked == false)
                    {
                        timer1.Stop();

                    }
                    else
                    {
                        label1.Text = "Attendere [............................................]";

                        timer1.Start();
                    }
                }
                if (number == 4)
                {
                    if (check4.Checked == false)
                    {
                        timer1.Stop();

                    }
                    else
                    {

                        label1.Text = "Attendere [...............................................]";

                        timer1.Start();
                    }
                }
                if (number == 5)
                {
                    if (check5.Checked == false)
                    {
                        timer1.Stop();

                    }
                    else
                    {
                        label1.Text = "Attendere [.......................................]";

                        timer1.Start();
                    }
                }
                if (number == 6)
                {
                    if (check6.Checked == false)
                    {
                        timer1.Stop();
                    }
                    else
                    {
                        label1.Text = "Attendere [.....................................................]";

                        timer1.Start();
                    }
                }
                if (number == 7)
                {
                    if (check7.Checked == false)
                    {
                        timer1.Stop();
                    }
                    else
                    {
                        label1.Text = "Attendere [..............................................]";


                        timer1.Start();
                    }
                }
                if (number == 8)
                {
                    if (check8.Checked == false)
                    {
                        timer1.Stop();

                    }
                    else
                    {

                        label1.Text = "Attendere [................................................]";

                        timer1.Start();
                    }
                }
                if (number == 9)
                {
                    if (check9.Checked == false)
                    {
                        timer1.Stop();
                    }
                    else
                    {

                        label1.Text = "Attendere [...........................................]";

                        timer1.Start();
                    }
                }
                if (number == 10)
                {
                    if (check10.Checked == false)
                    {
                        timer1.Stop();
                    }
                    else
                    {
                        label1.Text = "Attendere [.........................................]";

                        timer1.Start();
                    }
                }
                if (number == 11)
                {
                    if (check11.Checked == false)
                    {
                        timer1.Stop();
                    }
                    else
                    {

                        label1.Text = "Attendere [.....................................]";


                        timer1.Start();
                    }
                }
                if (number == 12)
                {
                    if (check12.Checked == false)
                    {
                        timer1.Stop();
                    }
                    else
                    {
                        label1.Text = "Attendere [............................................]";
                        timer1.Start();
                    }
                }
                if (number == 13)
                {
                    if (check13.Checked == false)
                    {
                        timer1.Stop();
                    }
                    else
                    {

                        label1.Text = "Attendere [........................................]";


                        timer1.Start();
                    }
                }
                if (number == 14)
                {
                    if (check14.Checked == false)
                    {
                        timer1.Stop();
                    }
                    else
                    {
                        label1.Text = "Attendere [.................................]";

                        timer1.Start();
                    }
                }
                if (number == 15)
                {
                    if (check15.Checked == false)
                    {
                        timer1.Stop();
                    }
                    else
                    {
                        label1.Text = "Attendere [..........................................]";

                        timer1.Start();
                    }
                }
                if (number == 16)
                {
                    if (check16.Checked == false)
                    {
                        timer1.Stop();
                    }
                    else
                    {
                        label1.Text = "Attendere [.............................................]";

                        timer1.Start();
                    }
                }
                if (number == 17)
                {
                    if (check17.Checked == false)
                    {
                        timer1.Stop();
                    }
                    else
                    {
                        label1.Text = "Attendere [...........................................]";

                        timer1.Start();
                    }
                }
                if (number == 18)
                {
                    if (check18.Checked == false)
                    {
                        timer1.Stop();
                    }
                    else
                    {
                        label1.Text = "Attendere [...........................................]";

                        timer1.Start();
                    }
                }
                if (number == 19)
                {
                    if (check19.Checked == false)
                    {
                        timer1.Stop();
                    }
                    else
                    {
                        label1.Text = "Attendere [......................................]";

                        timer1.Start();
                    }
                }
                if (number == 20)
                {
                    if (check20.Checked == false)
                    {
                        timer1.Stop();
                    }
                    else
                    {
                        label1.Text = "Attendere [.............................................]";

                        timer1.Start();
                    }
                }




                if (number == 21)
                {







                    if (check21.Checked == false)
                    {

                        timer1.Stop();

                    }
                    else
                    {
                        label1.Text = "Attendere [.............................................]";

                        timer1.Start();


                    }
                }

                if (number == 22)
                {
                    if (check22.Checked == false)
                    {
                        timer1.Stop();

                    }
                    else
                    {
                        label1.Text = "Attendere [.........................................]";
                        timer1.Start();

                    }
                }

                if (number == 23)
                {
                    if (check23.Checked == false)
                    {
                        timer1.Stop();

                    }
                    else
                    {
                        label1.Text = "Attendere [............................................]";

                        timer1.Start();
                    }
                }
                if (number == 24)
                {
                    if (check24.Checked == false)
                    {
                        timer1.Stop();

                    }
                    else
                    {

                        label1.Text = "Attendere [...............................................]";

                        timer1.Start();
                    }
                }
                if (number == 25)
                {
                    if (check25.Checked == false)
                    {
                        timer1.Stop();

                    }
                    else
                    {
                        label1.Text = "Attendere [.......................................]";

                        timer1.Start();
                    }
                }
                if (number == 26)
                {
                    if (check26.Checked == false)
                    {
                        timer1.Stop();
                    }
                    else
                    {
                        label1.Text = "Attendere [.....................................................]";

                        timer1.Start();
                    }
                }
                if (number == 27)
                {
                    if (check27.Checked == false)
                    {
                        timer1.Stop();
                    }
                    else
                    {
                        label1.Text = "Attendere [..............................................]";


                        timer1.Start();
                    }
                }
                if (number == 28)
                {
                    if (check28.Checked == false)
                    {
                        timer1.Stop();

                    }
                    else
                    {

                        label1.Text = "Attendere [................................................]";

                        timer1.Start();
                    }
                }
                if (number == 29)
                {
                    if (check29.Checked == false)
                    {
                        timer1.Stop();
                    }
                    else
                    {

                        label1.Text = "Attendere [...........................................]";

                        timer1.Start();
                    }
                }
                if (number == 30)
                {
                    if (check30.Checked == false)
                    {
                        timer1.Stop();
                    }
                    else
                    {
                        label1.Text = "Attendere [.........................................]";

                        timer1.Start();
                    }
                }
                if (number == 31)
                {
                    if (check31.Checked == false)
                    {
                        timer1.Stop();
                    }
                    else
                    {

                        label1.Text = "Attendere [.....................................]";


                        timer1.Start();
                    }
                }
                if (number == 32)
                {
                    if (check32.Checked == false)
                    {
                        timer1.Stop();
                    }
                    else
                    {
                        label1.Text = "Attendere [............................................]";
                        timer1.Start();
                    }
                }
                if (number == 33)
                {
                    if (check33.Checked == false)
                    {
                        timer1.Stop();
                    }
                    else
                    {

                        label1.Text = "Attendere [........................................]";


                        timer1.Start();
                    }
                }
                if (number == 34)
                {
                    if (check34.Checked == false)
                    {
                        timer1.Stop();
                    }
                    else
                    {
                        label1.Text = "Attendere [.................................]";

                        timer1.Start();
                    }
                }
                if (number == 35)
                {
                    if (check35.Checked == false)
                    {
                        timer1.Stop();
                    }
                    else
                    {
                        label1.Text = "Attendere [..........................................]";

                        timer1.Start();
                    }
                }
                if (number == 36)
                {
                    if (check36.Checked == false)
                    {
                        timer1.Stop();
                    }
                    else
                    {
                        label1.Text = "Attendere [.............................................]";

                        timer1.Start();
                    }
                }
                if (number == 37)
                {
                    if (check37.Checked == false)
                    {
                        timer1.Stop();
                    }
                    else
                    {
                        label1.Text = "Attendere [...........................................]";

                        timer1.Start();
                    }
                }
                if (number == 38)
                {
                    if (check38.Checked == false)
                    {
                        timer1.Stop();
                    }
                    else
                    {
                        label1.Text = "Attendere [...........................................]";

                        timer1.Start();
                    }
                }
                if (number == 39)
                {
                    if (check39.Checked == false)
                    {
                        timer1.Stop();
                    }
                    else
                    {
                        label1.Text = "Attendere [......................................]";

                        timer1.Start();
                    }
                }
                if (number == 40)
                {
                    if (check40.Checked == false)
                    {
                        timer1.Stop();
                    }
                    else
                    {
                        label1.Text = "Attendere [.............................................]";

                        timer1.Start();
                    }
                }









                




                zero = 0;



            }










        }




















        private void button2_Click(object sender, EventArgs e)
        {




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        string responseString = "";







        private async void Form1_Load(object sender, EventArgs e)
        {
         



            string server = "http://localhost:8080/";
            HttpListener listener = new HttpListener();
            listener.Prefixes.Add(server);
            listener.Start();

            Console.WriteLine("Server running on {0}", server);

            Thread serverThread = new Thread(() =>
            {
                while (true)
                {
                    try
                    {
                        HttpListenerContext context = listener.GetContext();
                        HttpListenerRequest request = context.Request;
                        HttpListenerResponse response2 = context.Response;


                        byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);

                        response2.ContentLength64 = buffer.Length;
                        response2.OutputStream.Write(buffer, 0, buffer.Length);
                        response2.OutputStream.Close();
                    }
                    catch (HttpListenerException ex)
                    {
                        // Gestisci l'eccezione specifica del listener
                        Console.WriteLine("Errore del listener HTTP: " + ex.Message);
                        Console.WriteLine("Tentativo di riconnessione...");
                        Thread.Sleep(1000); // Attendere per 1 secondo prima di tentare di riconnessione
                        continue; // Riprendi con la prossima iterazione del ciclo
                    }
                    catch (Exception ex)
                    {
                        // Gestisci altre eccezioni
                        Console.WriteLine("Errore durante l'esecuzione del server: " + ex.Message);
                        break; // Esci dal ciclo while in caso di errore generico
                    }
                }
            });

            serverThread.Start();


            string percorsoCartella = "profili/Profilo1";

            // Verifica se la cartella esiste già
            if (!Directory.Exists(percorsoCartella))
            {
                // Crea la cartella
                Directory.CreateDirectory(percorsoCartella);
                Console.WriteLine("Cartella creata con successo!");
            }
            else
            {
                Console.WriteLine("La cartella esiste già.");
            }




            string directoryPath = "profili"; // Sostituisci con il percorso desiderato

            try
            {
                // Leggi l'elenco delle cartelle presenti nella directory specificata
                string[] directories = Directory.GetDirectories(directoryPath);

                // Rimuovi "profili/" dai nomi delle cartelle
                string[] folderNames = new string[directories.Length];
                for (int i = 0; i < directories.Length; i++)
                {
                    folderNames[i] = directories[i].Replace(directoryPath + "\\", "");
                }

                // Popola la ComboBox con l'elenco dei nomi delle cartelle
                comboBox1.Items.AddRange(folderNames);
            }
            catch (Exception ex)
            {
                // Gestisci eventuali eccezioni, ad esempio la mancanza di accesso alla directory
                MessageBox.Show("Si è verificato un errore: " + ex.Message);
            }

















            string filePath = "profili/" + comboBox1.Text + "/impostazioni.json";
            if (File.Exists(filePath))
            {
                try
                {
                    // Lettura del contenuto del file
                    string json = File.ReadAllText(filePath);

                    MySettings settings = JsonSerializer.Deserialize<MySettings>(json);

                    // Accesso ai dati dell'oggetto dinamico
                    string User = settings.User;
                    string ColoreSfondo = settings.ColoreSfondo;
                    string FontTipo = settings.FontTipo;
                    string FontPX = settings.FontPX;
                    string FontColor = settings.FontColor;
                    string Risposta = settings.Risposta;
                    string Posizione = settings.Posizione;
                    string BOX1 = settings.BOX1;
                    string BOX2 = settings.BOX2;
                    string BOX3 = settings.BOX3;
                    string BOX4 = settings.BOX4;
                    string BOX5 = settings.BOX5;
                    string BOX6 = settings.BOX6;
                    string BOX7 = settings.BOX7;
                    string BOX8 = settings.BOX8;
                    string BOX9 = settings.BOX9;
                    string BOX10 = settings.BOX10;
                    string BOX11 = settings.BOX11;
                    string BOX12 = settings.BOX12;
                    string BOX13 = settings.BOX13;
                    string BOX14 = settings.BOX14;
                    string BOX15 = settings.BOX15;
                    string BOX16 = settings.BOX16;
                    string BOX17 = settings.BOX17;
                    string BOX18 = settings.BOX18;
                    string BOX19 = settings.BOX19;
                    string BOX20 = settings.BOX20;
                    string BOX21 = settings.BOX21;
                    string BOX22 = settings.BOX22;
                    string BOX23 = settings.BOX23;
                    string BOX24 = settings.BOX24;
                    string BOX25 = settings.BOX25;
                    string BOX26 = settings.BOX26;
                    string BOX27 = settings.BOX27;
                    string BOX28 = settings.BOX28;
                    string BOX29 = settings.BOX29;
                    string BOX30 = settings.BOX30;
                    string BOX31 = settings.BOX31;
                    string BOX32 = settings.BOX32;
                    string BOX33 = settings.BOX33;
                    string BOX34 = settings.BOX34;
                    string BOX35 = settings.BOX35;
                    string BOX36 = settings.BOX36;
                    string BOX37 = settings.BOX37;
                    string BOX38 = settings.BOX38;
                    string BOX39 = settings.BOX39;
                    string BOX40 = settings.BOX40;
                    string User0 = settings.User;


                    string coloreHtml = ColoreSfondo;

                    Color mioColore = ColorTranslator.FromHtml(coloreHtml); // Convert the HTML color string to a Color object

                    this.BackColor = mioColore; // Set the background color of the control

                    Twitch_User.Text = User0.ToString();
                    string nomeTipoCarattere = FontTipo;
                    string PX = FontPX;
                    string colorePersonalizzato = FontColor;
                    string risposta = Risposta;
                    int posizioneInt = Convert.ToInt32(risposta);
                    trackBar1.Value = posizioneInt;
                    string posizione = Posizione;

                    if (BOX1 == "true")
                    {
                        check1.Checked = true;
                    }
                    if (BOX2 == "true")
                    {
                        check2.Checked = true;
                    }
                    if (BOX3 == "true")
                    {
                        check3.Checked = true;
                    }
                    if (BOX4 == "true")
                    {
                        check4.Checked = true;
                    }
                    if (BOX5 == "true")
                    {
                        check5.Checked = true;
                    }
                    if (BOX6 == "true")
                    {
                        check6.Checked = true;
                    }
                    if (BOX7 == "true")
                    {
                        check7.Checked = true;
                    }
                    if (BOX8 == "true")
                    {
                        check8.Checked = true;
                    }
                    if (BOX9 == "true")
                    {
                        check9.Checked = true;
                    }
                    if (BOX10 == "true")
                    {
                        check10.Checked = true;
                    }

                    if (BOX11 == "true")
                    {
                        check11.Checked = true;
                    }
                    if (BOX12 == "true")
                    {
                        check12.Checked = true;
                    }
                    if (BOX13 == "true")
                    {
                        check13.Checked = true;
                    }
                    if (BOX14 == "true")
                    {
                        check14.Checked = true;
                    }
                    if (BOX15 == "true")
                    {
                        check15.Checked = true;
                    }
                    if (BOX16 == "true")
                    {
                        check16.Checked = true;
                    }
                    if (BOX17 == "true")
                    {
                        check17.Checked = true;
                    }
                    if (BOX18 == "true")
                    {
                        check18.Checked = true;
                    }
                    if (BOX19 == "true")
                    {
                        check19.Checked = true;
                    }
                    if (BOX20 == "true")
                    {
                        check20.Checked = true;
                    }

                    if (BOX21 == "true")
                    {
                        check21.Checked = true;
                    }
                    if (BOX22 == "true")
                    {
                        check22.Checked = true;
                    }
                    if (BOX23 == "true")
                    {
                        check23.Checked = true;
                    }
                    if (BOX24 == "true")
                    {
                        check24.Checked = true;
                    }
                    if (BOX25 == "true")
                    {
                        check25.Checked = true;
                    }
                    if (BOX26 == "true")
                    {
                        check26.Checked = true;
                    }
                    if (BOX27 == "true")
                    {
                        check27.Checked = true;
                    }
                    if (BOX28 == "true")
                    {
                        check28.Checked = true;
                    }
                    if (BOX29 == "true")
                    {
                        check29.Checked = true;
                    }
                    if (BOX30 == "true")
                    {
                        check30.Checked = true;
                    }

                    if (BOX31 == "true")
                    {
                        check31.Checked = true;
                    }
                    if (BOX32 == "true")
                    {
                        check32.Checked = true;
                    }
                    if (BOX33 == "true")
                    {
                        check33.Checked = true;
                    }
                    if (BOX34 == "true")
                    {
                        check34.Checked = true;
                    }
                    if (BOX35 == "true")
                    {
                        check35.Checked = true;
                    }
                    if (BOX36 == "true")
                    {
                        check36.Checked = true;
                    }
                    if (BOX37 == "true")
                    {
                        check37.Checked = true;
                    }
                    if (BOX38 == "true")
                    {
                        check38.Checked = true;
                    }
                    if (BOX39 == "true")
                    {
                        check39.Checked = true;
                    }
                    if (BOX40 == "true")
                    {
                        check40.Checked = true;
                    }























                    int posizioneInt2 = Convert.ToInt32(posizione);
                    trackBar3.Value = posizioneInt2;
                    string[] valoriRGB = colorePersonalizzato.Split(',');
                    int r, g, b;
                    if (valoriRGB.Length != 3 || !int.TryParse(valoriRGB[0], out r) || !int.TryParse(valoriRGB[1], out g) || !int.TryParse(valoriRGB[2], out b) || r < 0 || r > 255 || g < 0 || g > 255 || b < 0 || b > 255)
                    {
                        // gestione dell'errore: i valori RGB non sono validi
                    }
                    else
                    {
                        // creazione del colore
                        Color colore = Color.FromArgb(r, g, b);
                        label1.ForeColor = colore;
                        // utilizzo del colore
                        // ...
                    }


                    int dimensioneFont;

                    if (int.TryParse(PX, out dimensioneFont))
                    {
                        label1.Font = new Font(nomeTipoCarattere, dimensioneFont);
                    }
                    timer1.Interval = trackBar1.Value;
                    label3.Text = timer1.Interval.ToString() + " MS";
                    label1.SetBounds(label1.Location.X, 28 - trackBar3.Value, label1.Width, label1.Height);
                    label6.Text = "Posizione font di: " + label1.Location.Y + " PX";









                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Errore durante la lettura o la deserializzazione del file JSON: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Il file impostazioni.json non esiste.");
            }












            var httpClient = new HttpClient();
            var url = "http://torrentexe.altervista.org/versione.txt"; // inserire qui l'URL del sito da controllare
            var response = await httpClient.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            aggiornamento = "NO";
            if (double.TryParse(content, out double value) && value > 10)
            {
                aggiornamento = "SI";
                var result = MessageBox.Show($"È disponibile una nuova versione. Desideri installarla?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Process.Start("https://github.com/RicordiTV/CelebrationBot");
                }
            }


            string imagePath = "profili/" + comboBox1.Text + "/image.png";
            if (File.Exists(imagePath))
            {

            }
            else
            {
                Image image = pictureBox2.Image;

                if (image != null)
                {
                    // Salva l'immagine nel percorso specificato
                    string filePath2 = "profili/" + comboBox1.Text + "/image.png";
                    image.Save(filePath2, System.Drawing.Imaging.ImageFormat.Png);
                }

            }






            string filePath3 = "profili/" + comboBox1.Text + "/image.png";

            if (File.Exists(filePath3))
            {
                try
                {
                    using (var fileStream = new FileStream(filePath3, FileMode.Open, FileAccess.Read))
                    {
                        // Crea un oggetto Bitmap dall'immagine nel file stream
                        var bitmap = new Bitmap(fileStream);

                        // Verifica se l'oggetto Bitmap è valido
                        if (bitmap.Width > 0 && bitmap.Height > 0)
                        {
                            // Imposta l'immagine nella PictureBox
                            pictureBox2.Image = bitmap;
                        }
                        else
                        {
                            Console.WriteLine("Il file immagine non è valido!");
                        }
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Errore durante la lettura del file immagine: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Il file immagine non esiste!");
            }




            label1.Parent = pictureBox2;
            label1.BackColor = Color.Transparent;

            foreach (FontFamily font in FontFamily.Families)
            {


            }

            string NomeFile1 = "profili/" + comboBox1.Text + "/1.txt";
            StreamReader FileTesto1;
            try
            {
                FileTesto1 = new StreamReader(NomeFile1);
                Domanda1.Text = FileTesto1.ReadLine();
                FileTesto1.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile2 = "profili/" + comboBox1.Text + "/2.txt";
            StreamReader FileTesto2;
            try
            {
                FileTesto2 = new StreamReader(NomeFile2);
                Domanda2.Text = FileTesto2.ReadLine();
                FileTesto2.Close();

            }
            catch (FileNotFoundException)
            {

            }

            string NomeFile3 = "profili/" + comboBox1.Text + "/3.txt";
            StreamReader FileTesto3;
            try
            {
                FileTesto3 = new StreamReader(NomeFile3);
                Domanda3.Text = FileTesto3.ReadLine();
                FileTesto3.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile4 = "profili/" + comboBox1.Text + "/4.txt";
            StreamReader FileTesto4;
            try
            {
                FileTesto4 = new StreamReader(NomeFile4);
                Domanda4.Text = FileTesto4.ReadLine();
                FileTesto4.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile5 = "profili/" + comboBox1.Text + "/5.txt";
            StreamReader FileTesto5;
            try
            {
                FileTesto5 = new StreamReader(NomeFile5);
                Domanda5.Text = FileTesto5.ReadLine();
                FileTesto5.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile6 = "profili/" + comboBox1.Text + "/6.txt";
            StreamReader FileTesto6;
            try
            {
                FileTesto6 = new StreamReader(NomeFile6);
                Domanda6.Text = FileTesto6.ReadLine();
                FileTesto6.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile7 = "profili/" + comboBox1.Text + "/7.txt";
            StreamReader FileTesto7;
            try
            {
                FileTesto7 = new StreamReader(NomeFile7);
                Domanda7.Text = FileTesto7.ReadLine();
                FileTesto7.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile8 = "profili/" + comboBox1.Text + "/8.txt";
            StreamReader FileTesto8;
            try
            {
                FileTesto8 = new StreamReader(NomeFile8);
                Domanda8.Text = FileTesto8.ReadLine();
                FileTesto8.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile9 = "profili/" + comboBox1.Text + "/9.txt";
            StreamReader FileTesto9;
            try
            {
                FileTesto9 = new StreamReader(NomeFile9);
                Domanda9.Text = FileTesto9.ReadLine();
                FileTesto9.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile10 = "profili/" + comboBox1.Text + "/10.txt";
            StreamReader FileTesto10;
            try
            {
                FileTesto10 = new StreamReader(NomeFile10);
                Domanda10.Text = FileTesto10.ReadLine();
                FileTesto10.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile11 = "profili/" + comboBox1.Text + "/11.txt";
            StreamReader FileTesto11;
            try
            {
                FileTesto11 = new StreamReader(NomeFile11);
                Domanda11.Text = FileTesto11.ReadLine();
                FileTesto11.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile12 = "profili/" + comboBox1.Text + "/12.txt";
            StreamReader FileTesto12;
            try
            {
                FileTesto12 = new StreamReader(NomeFile12);
                Domanda12.Text = FileTesto12.ReadLine();
                FileTesto12.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile13 = "profili/" + comboBox1.Text + "/13.txt";
            StreamReader FileTesto13;
            try
            {
                FileTesto13 = new StreamReader(NomeFile13);
                Domanda13.Text = FileTesto13.ReadLine();
                FileTesto13.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile14 = "profili/" + comboBox1.Text + "/14.txt";
            StreamReader FileTesto14;
            try
            {
                FileTesto14 = new StreamReader(NomeFile14);
                Domanda14.Text = FileTesto14.ReadLine();
                FileTesto14.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile15 = "profili/" + comboBox1.Text + "/15.txt";
            StreamReader FileTesto15;
            try
            {
                FileTesto15 = new StreamReader(NomeFile15);
                Domanda15.Text = FileTesto15.ReadLine();
                FileTesto15.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile16 = "profili/" + comboBox1.Text + "/16.txt";
            StreamReader FileTesto16;
            try
            {
                FileTesto16 = new StreamReader(NomeFile16);
                Domanda16.Text = FileTesto16.ReadLine();
                FileTesto16.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile17 = "profili/" + comboBox1.Text + "/17.txt";
            StreamReader FileTesto17;
            try
            {
                FileTesto17 = new StreamReader(NomeFile17);
                Domanda17.Text = FileTesto17.ReadLine();
                FileTesto17.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile18 = "profili/" + comboBox1.Text + "/18.txt";
            StreamReader FileTesto18;
            try
            {
                FileTesto18 = new StreamReader(NomeFile18);
                Domanda18.Text = FileTesto18.ReadLine();
                FileTesto18.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile19 = "profili/" + comboBox1.Text + "/19.txt";
            StreamReader FileTesto19;
            try
            {
                FileTesto19 = new StreamReader(NomeFile19);
                Domanda19.Text = FileTesto19.ReadLine();
                FileTesto19.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile20 = "profili/" + comboBox1.Text + "/20.txt";
            StreamReader FileTesto20;
            try
            {
                FileTesto20 = new StreamReader(NomeFile20);
                Domanda20.Text = FileTesto20.ReadLine();
                FileTesto20.Close();

            }
            catch (FileNotFoundException)
            {

            }


            string NomeFile21 = "profili/" + comboBox1.Text + "/21.txt";
            StreamReader FileTesto21;
            try
            {
                FileTesto21 = new StreamReader(NomeFile21);
                Domanda21.Text = FileTesto21.ReadLine();
                FileTesto21.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile22 = "profili/" + comboBox1.Text + "/22.txt";
            StreamReader FileTesto22;
            try
            {
                FileTesto22 = new StreamReader(NomeFile22);
                Domanda22.Text = FileTesto22.ReadLine();
                FileTesto22.Close();

            }
            catch (FileNotFoundException)
            {

            }

            string NomeFile23 = "profili/" + comboBox1.Text + "/23.txt";
            StreamReader FileTesto23;
            try
            {
                FileTesto23 = new StreamReader(NomeFile23);
                Domanda23.Text = FileTesto23.ReadLine();
                FileTesto23.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile24 = "profili/" + comboBox1.Text + "/24.txt";
            StreamReader FileTesto24;
            try
            {
                FileTesto24 = new StreamReader(NomeFile24);
                Domanda24.Text = FileTesto24.ReadLine();
                FileTesto24.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile25 = "profili/" + comboBox1.Text + "/25.txt";
            StreamReader FileTesto25;
            try
            {
                FileTesto25 = new StreamReader(NomeFile25);
                Domanda25.Text = FileTesto25.ReadLine();
                FileTesto25.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile26 = "profili/" + comboBox1.Text + "/26.txt";
            StreamReader FileTesto26;
            try
            {
                FileTesto26 = new StreamReader(NomeFile26);
                Domanda26.Text = FileTesto26.ReadLine();
                FileTesto26.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile27 = "profili/" + comboBox1.Text + "/27.txt";
            StreamReader FileTesto27;
            try
            {
                FileTesto27 = new StreamReader(NomeFile27);
                Domanda27.Text = FileTesto27.ReadLine();
                FileTesto27.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile28 = "profili/" + comboBox1.Text + "/28.txt";
            StreamReader FileTesto28;
            try
            {
                FileTesto28 = new StreamReader(NomeFile28);
                Domanda28.Text = FileTesto28.ReadLine();
                FileTesto28.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile29 = "profili/" + comboBox1.Text + "/29.txt";
            StreamReader FileTesto29;
            try
            {
                FileTesto29 = new StreamReader(NomeFile29);
                Domanda29.Text = FileTesto29.ReadLine();
                FileTesto29.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile30 = "profili/" + comboBox1.Text + "/30.txt";
            StreamReader FileTesto30;
            try
            {
                FileTesto30 = new StreamReader(NomeFile30);
                Domanda30.Text = FileTesto30.ReadLine();
                FileTesto30.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile31 = "profili/" + comboBox1.Text + "/31.txt";
            StreamReader FileTesto31;
            try
            {
                FileTesto31 = new StreamReader(NomeFile31);
                Domanda31.Text = FileTesto31.ReadLine();
                FileTesto31.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile32 = "profili/" + comboBox1.Text + "/32.txt";
            StreamReader FileTesto32;
            try
            {
                FileTesto32 = new StreamReader(NomeFile32);
                Domanda32.Text = FileTesto32.ReadLine();
                FileTesto32.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile33 = "profili/" + comboBox1.Text + "/33.txt";
            StreamReader FileTesto33;
            try
            {
                FileTesto33 = new StreamReader(NomeFile33);
                Domanda33.Text = FileTesto33.ReadLine();
                FileTesto33.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile34 = "profili/" + comboBox1.Text + "/34.txt";
            StreamReader FileTesto34;
            try
            {
                FileTesto34 = new StreamReader(NomeFile34);
                Domanda34.Text = FileTesto34.ReadLine();
                FileTesto34.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile35 = "profili/" + comboBox1.Text + "/35.txt";
            StreamReader FileTesto35;
            try
            {
                FileTesto35 = new StreamReader(NomeFile35);
                Domanda35.Text = FileTesto35.ReadLine();
                FileTesto35.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile36 = "profili/" + comboBox1.Text + "/36.txt";
            StreamReader FileTesto36;
            try
            {
                FileTesto36 = new StreamReader(NomeFile36);
                Domanda36.Text = FileTesto36.ReadLine();
                FileTesto36.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile37 = "profili/" + comboBox1.Text + "/37.txt";
            StreamReader FileTesto37;
            try
            {
                FileTesto37 = new StreamReader(NomeFile37);
                Domanda37.Text = FileTesto37.ReadLine();
                FileTesto37.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile38 = "profili/" + comboBox1.Text + "/38.txt";
            StreamReader FileTesto38;
            try
            {
                FileTesto38 = new StreamReader(NomeFile38);
                Domanda38.Text = FileTesto38.ReadLine();
                FileTesto38.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile39 = "profili/" + comboBox1.Text + "/39.txt";
            StreamReader FileTesto39;
            try
            {
                FileTesto39 = new StreamReader(NomeFile39);
                Domanda39.Text = FileTesto39.ReadLine();
                FileTesto39.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile40 = "profili/" + comboBox1.Text + "/40.txt";
            StreamReader FileTesto40;
            try
            {
                FileTesto40 = new StreamReader(NomeFile40);
                Domanda40.Text = FileTesto40.ReadLine();
                FileTesto40.Close();

            }
            catch (FileNotFoundException)
            {

            }

















            foreach (Control control in Controls)
            {
                control.Enabled = false;
            }

            // Aspetta un secondo
            await Task.Delay(1000);

            // Riabilita tutti i controlli del form dopo un secondo
            foreach (Control control in Controls)
            {
                control.Enabled = true;
            }


        }


        class MySettings
        {
            public string ColoreSfondo { get; set; }
            public string FontTipo { get; set; }
            public string FontPX { get; set; }
            public string FontColor { get; set; }
            public string Risposta { get; set; }
            public string Posizione { get; set; }
            public string BOX1 { get; set; }
            public string BOX2 { get; set; }
            public string BOX3 { get; set; }
            public string BOX4 { get; set; }
            public string BOX5 { get; set; }
            public string BOX6 { get; set; }
            public string BOX7 { get; set; }
            public string BOX8 { get; set; }
            public string BOX9 { get; set; }
            public string BOX10 { get; set; }
            public string BOX11 { get; set; }
            public string BOX12 { get; set; }
            public string BOX13 { get; set; }
            public string BOX14 { get; set; }
            public string BOX15 { get; set; }
            public string BOX16 { get; set; }
            public string BOX17 { get; set; }
            public string BOX18 { get; set; }
            public string BOX19 { get; set; }
            public string BOX20 { get; set; }
            public string BOX21 { get; set; }
            public string BOX22 { get; set; }
            public string BOX23 { get; set; }
            public string BOX24 { get; set; }
            public string BOX25 { get; set; }
            public string BOX26 { get; set; }
            public string BOX27 { get; set; }
            public string BOX28 { get; set; }
            public string BOX29 { get; set; }
            public string BOX30 { get; set; }
            public string BOX31 { get; set; }
            public string BOX32 { get; set; }
            public string BOX33 { get; set; }
            public string BOX34 { get; set; }
            public string BOX35 { get; set; }
            public string BOX36 { get; set; }
            public string BOX37 { get; set; }
            public string BOX38 { get; set; }
            public string BOX39 { get; set; }
            public string BOX40 { get; set; }
            public string User { get; set; }


        }








        static int CountProcesses(string processName)
        {
            int count = 0;

            // Ottiene tutti i processi attivi sul sistema
            Process[] processes = Process.GetProcesses();

            // Conta quanti processi corrispondono al nome specificato
            foreach (Process process in processes)
            {
                if (process.ProcessName.Equals(processName, StringComparison.OrdinalIgnoreCase))
                {
                    count++;
                }

            }

            return count;

        }



        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                timer1.Stop();

            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                timer1.Stop();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        int avvio = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {

            avvio = avvio + 1;
            if (avvio == 1)
            {
                label1.Text = "In attesa";
            }
            if (avvio == 2)
            {
                label1.Text = "In attesa.";
            }
            if (avvio == 3)
            {
                label1.Text = "In attesa..";
            }
            if (avvio == 4)
            {
                label1.Text = "In attesa...";
                avvio = 0;
            }
            if (avvio == 5)
            {
                label1.Text = "In attesa";
                avvio = 0;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }








        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
            label3.Text = timer1.Interval.ToString() + " MS";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e, string imageFolderPath)
        {
            string[] imageFiles = Directory.GetFiles(imageFolderPath, "");

            // Carica l'immagine dal primo file trovato nella cartella
            if (imageFiles.Length > 0)
            {
                Image newImage = Image.FromFile(imageFiles[0]);

                // Imposta l'immagine nel PictureBox
                pictureBox2.Image = newImage;

                // Rilascia le risorse utilizzate dalla vecchia immagine, se presente
                if (pictureBox2.Image != null)
                {
                    pictureBox2.Image.Dispose();
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {


            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png;";
            ofd.Multiselect = false;
            ofd.Title = "Seleziona un'immagine";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (Image image = Image.FromFile(ofd.FileName))
                    {
                        pictureBox2.Image = new Bitmap(image);
                    }
                }
                catch (OutOfMemoryException)
                {
                    MessageBox.Show("L'immagine selezionata è corrotta o non è un'immagine valida.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {

            // Mostra un selettore di colore all'utente










        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {



            timer2.Stop();
            label1.Text = textBox21.Text.ToString();
            Bitmap bitmap = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            pictureBox2.DrawToBitmap(bitmap, new Rectangle(0, 0, pictureBox2.Width, pictureBox2.Height));
            bitmap.Save("image2.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] imageBytes = File.ReadAllBytes("image2.jpg");
            string base64String = Convert.ToBase64String(imageBytes);

            responseString = "<html><div id=\"image\">\r\n<img src='data:image/jpg;base64," + base64String + "'>  <!-- Qui va inserito il codice HTML che deve essere aggiornato -->\r\n</div>\r\n\r\n<script>\r\n  // Replace \"dataUrl\" with the URL of your data source\r\n  const dataUrl = \"http://localhost:8080/\";\r\n\r\n  function updateData() {\r\n    fetch(dataUrl)\r\n      .then(response => response.text())\r\n      .then(data => {\r\n        // Replace \"image\" with the ID of the <div> element to update\r\n        const imageDiv = document.getElementById(\"image\");\r\n        imageDiv.innerHTML = data;\r\n      })\r\n      .catch(error => {\r\n        console.error(error);\r\n      });\r\n  }\r\n\r\n  // Update the data every 50 ms\r\n  setInterval(updateData,50);\r\n</script></html>";

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // Imposta il colore selezionato come colore della Label
                label1.ForeColor = dialog.Color;
            }
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label1.SetBounds(label1.Location.X, 28 - trackBar3.Value, label1.Width, label1.Height);
            label6.Text = "Posizione font di: " + label1.Location.Y + " PX";



        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                label1.Font = fd.Font;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Vuoi davvero salvare le modifiche?", "Alert", MessageBoxButtons.YesNo);


            if (result == DialogResult.Yes)
            {
                if (label50.Text == "Profilo: " + comboBox1.Text)
                {

                    Color mioColore = Color.FromArgb(this.BackColor.ToArgb()); // Il tuo colore ARGB
                    string coloreHtml = ColorTranslator.ToHtml(mioColore); // Convert the color to its HTML representation
                    Properties.Settings.Default.ColoreSfondo = coloreHtml.ToString();
                    Properties.Settings.Default.FontTipo = label1.Font.Name;
                    Properties.Settings.Default.FontPX = Math.Round(label1.Font.Size, MidpointRounding.AwayFromZero).ToString();
                    Color colore = label1.ForeColor;
                    string coloreRGB = $"{colore.R},{colore.G},{colore.B}";
                    Properties.Settings.Default.FontColor = coloreRGB;
                    Properties.Settings.Default.Risposta = trackBar1.Value.ToString();
                    Properties.Settings.Default.Posizione = trackBar3.Value.ToString();
                    Properties.Settings.Default.User = Twitch_User.Text;


                    if (check1.Checked)
                    {
                        Properties.Settings.Default.BOX1 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX1 = "false";
                    }
                    if (check2.Checked)
                    {
                        Properties.Settings.Default.BOX2 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX2 = "false";
                    }
                    if (check3.Checked)
                    {
                        Properties.Settings.Default.BOX3 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX3 = "false";
                    }
                    if (check4.Checked)
                    {
                        Properties.Settings.Default.BOX4 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX4 = "false";
                    }
                    if (check5.Checked)
                    {
                        Properties.Settings.Default.BOX5 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX5 = "false";
                    }
                    if (check6.Checked)
                    {
                        Properties.Settings.Default.BOX6 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX6 = "false";
                    }
                    if (check7.Checked)
                    {
                        Properties.Settings.Default.BOX7 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX7 = "false";
                    }
                    if (check8.Checked)
                    {
                        Properties.Settings.Default.BOX8 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX8 = "false";
                    }
                    if (check9.Checked)
                    {
                        Properties.Settings.Default.BOX9 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX9 = "false";
                    }
                    if (check10.Checked)
                    {
                        Properties.Settings.Default.BOX10 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX10 = "false";
                    }
                    if (check11.Checked)
                    {
                        Properties.Settings.Default.BOX11 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX11 = "false";
                    }
                    if (check12.Checked)
                    {
                        Properties.Settings.Default.BOX12 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX12 = "false";
                    }
                    if (check13.Checked)
                    {
                        Properties.Settings.Default.BOX13 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX13 = "false";
                    }
                    if (check14.Checked)
                    {
                        Properties.Settings.Default.BOX14 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX14 = "false";
                    }
                    if (check15.Checked)
                    {
                        Properties.Settings.Default.BOX15 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX15 = "false";
                    }
                    if (check16.Checked)
                    {
                        Properties.Settings.Default.BOX16 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX16 = "false";
                    }
                    if (check17.Checked)
                    {
                        Properties.Settings.Default.BOX17 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX17 = "false";
                    }
                    if (check18.Checked)
                    {
                        Properties.Settings.Default.BOX18 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX18 = "false";
                    }
                    if (check19.Checked)
                    {
                        Properties.Settings.Default.BOX19 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX19 = "false";
                    }
                    if (check20.Checked)
                    {
                        Properties.Settings.Default.BOX20 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX20 = "false";
                    }
                    if (check21.Checked)
                    {
                        Properties.Settings.Default.BOX21 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX21 = "false";
                    }
                    if (check22.Checked)
                    {
                        Properties.Settings.Default.BOX22 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX22 = "false";
                    }
                    if (check23.Checked)
                    {
                        Properties.Settings.Default.BOX23 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX23 = "false";
                    }
                    if (check24.Checked)
                    {
                        Properties.Settings.Default.BOX24 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX24 = "false";
                    }
                    if (check25.Checked)
                    {
                        Properties.Settings.Default.BOX25 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX25 = "false";
                    }
                    if (check26.Checked)
                    {
                        Properties.Settings.Default.BOX26 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX26 = "false";
                    }
                    if (check27.Checked)
                    {
                        Properties.Settings.Default.BOX27 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX27 = "false";
                    }
                    if (check28.Checked)
                    {
                        Properties.Settings.Default.BOX28 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX28 = "false";
                    }
                    if (check29.Checked)
                    {
                        Properties.Settings.Default.BOX29 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX29 = "false";
                    }
                    if (check30.Checked)
                    {
                        Properties.Settings.Default.BOX30 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX30 = "false";
                    }
                    if (check31.Checked)
                    {
                        Properties.Settings.Default.BOX31 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX31 = "false";
                    }
                    if (check32.Checked)
                    {
                        Properties.Settings.Default.BOX32 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX32 = "false";
                    }
                    if (check33.Checked)
                    {
                        Properties.Settings.Default.BOX33 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX33 = "false";
                    }
                    if (check34.Checked)
                    {
                        Properties.Settings.Default.BOX34 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX34 = "false";
                    }
                    if (check35.Checked)
                    {
                        Properties.Settings.Default.BOX35 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX35 = "false";
                    }
                    if (check36.Checked)
                    {
                        Properties.Settings.Default.BOX36 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX36 = "false";
                    }
                    if (check37.Checked)
                    {
                        Properties.Settings.Default.BOX37 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX37 = "false";
                    }
                    if (check38.Checked)
                    {
                        Properties.Settings.Default.BOX38 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX38 = "false";
                    }
                    if (check39.Checked)
                    {
                        Properties.Settings.Default.BOX39 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX39 = "false";
                    }
                    if (check40.Checked)
                    {
                        Properties.Settings.Default.BOX40 = "true";
                    }
                    else
                    {
                        Properties.Settings.Default.BOX40 = "false";
                    }





                    Properties.Settings.Default.Save();



                    string text1 = "profili/" + comboBox1.Text + "/1.txt";
                    StreamWriter streamWriter1 = new StreamWriter(text1, false);
                    streamWriter1.WriteLine(Domanda1.Text.ToString());
                    streamWriter1.Close();

                    string text2 = "profili/" + comboBox1.Text + "/2.txt";
                    StreamWriter streamWriter2 = new StreamWriter(text2, false);
                    streamWriter2.WriteLine(Domanda2.Text.ToString());
                    streamWriter2.Close();

                    string text3 = "profili/" + comboBox1.Text + "/3.txt";
                    StreamWriter streamWriter3 = new StreamWriter(text3, false);
                    streamWriter3.WriteLine(Domanda3.Text.ToString());
                    streamWriter3.Close();

                    string text4 = "profili/" + comboBox1.Text + "/4.txt";
                    StreamWriter streamWriter4 = new StreamWriter(text4, false);
                    streamWriter4.WriteLine(Domanda4.Text.ToString());
                    streamWriter4.Close();

                    string text5 = "profili/" + comboBox1.Text + "/5.txt";
                    StreamWriter streamWriter5 = new StreamWriter(text5, false);
                    streamWriter5.WriteLine(Domanda5.Text.ToString());
                    streamWriter5.Close();

                    string text6 = "profili/" + comboBox1.Text + "/6.txt";
                    StreamWriter streamWriter6 = new StreamWriter(text6, false);
                    streamWriter6.WriteLine(Domanda6.Text.ToString());
                    streamWriter6.Close();

                    string text7 = "profili/" + comboBox1.Text + "/7.txt";
                    StreamWriter streamWriter7 = new StreamWriter(text7, false);
                    streamWriter7.WriteLine(Domanda7.Text.ToString());
                    streamWriter7.Close();

                    string text8 = "profili/" + comboBox1.Text + "/8.txt";
                    StreamWriter streamWriter8 = new StreamWriter(text8, false);
                    streamWriter8.WriteLine(Domanda8.Text.ToString());
                    streamWriter8.Close();

                    string text9 = "profili/" + comboBox1.Text + "/9.txt";
                    StreamWriter streamWriter9 = new StreamWriter(text9, false);
                    streamWriter9.WriteLine(Domanda9.Text.ToString());
                    streamWriter9.Close();

                    string text10 = "profili/" + comboBox1.Text + "/10.txt";
                    StreamWriter streamWriter10 = new StreamWriter(text10, false);
                    streamWriter10.WriteLine(Domanda10.Text.ToString());
                    streamWriter10.Close();

                    string text11 = "profili/" + comboBox1.Text + "/11.txt";
                    StreamWriter streamWriter11 = new StreamWriter(text11, false);
                    streamWriter11.WriteLine(Domanda11.Text.ToString());
                    streamWriter11.Close();

                    string text12 = "profili/" + comboBox1.Text + "/12.txt";
                    StreamWriter streamWriter12 = new StreamWriter(text12, false);
                    streamWriter12.WriteLine(Domanda12.Text.ToString());
                    streamWriter12.Close();

                    string text13 = "profili/" + comboBox1.Text + "/13.txt";
                    StreamWriter streamWriter13 = new StreamWriter(text13, false);
                    streamWriter13.WriteLine(Domanda13.Text.ToString());
                    streamWriter13.Close();

                    string text14 = "profili/" + comboBox1.Text + "/14.txt";
                    StreamWriter streamWriter14 = new StreamWriter(text14, false);
                    streamWriter14.WriteLine(Domanda14.Text.ToString());
                    streamWriter14.Close();

                    string text15 = "profili/" + comboBox1.Text + "/15.txt";
                    StreamWriter streamWriter15 = new StreamWriter(text15, false);
                    streamWriter15.WriteLine(Domanda15.Text.ToString());
                    streamWriter15.Close();

                    string text16 = "profili/" + comboBox1.Text + "/16.txt";
                    StreamWriter streamWriter16 = new StreamWriter(text16, false);
                    streamWriter16.WriteLine(Domanda16.Text.ToString());
                    streamWriter16.Close();

                    string text17 = "profili/" + comboBox1.Text + "/17.txt";
                    StreamWriter streamWriter17 = new StreamWriter(text17, false);
                    streamWriter17.WriteLine(Domanda17.Text.ToString());
                    streamWriter17.Close();

                    string text18 = "profili/" + comboBox1.Text + "/18.txt";
                    StreamWriter streamWriter18 = new StreamWriter(text18, false);
                    streamWriter18.WriteLine(Domanda18.Text.ToString());
                    streamWriter18.Close();

                    string text19 = "profili/" + comboBox1.Text + "/19.txt";
                    StreamWriter streamWriter19 = new StreamWriter(text19, false);
                    streamWriter19.WriteLine(Domanda19.Text.ToString());
                    streamWriter19.Close();

                    string text20 = "profili/" + comboBox1.Text + "/20.txt";
                    StreamWriter streamWriter20 = new StreamWriter(text20, false);
                    streamWriter20.WriteLine(Domanda20.Text.ToString());
                    streamWriter20.Close();

                    string text21 = "profili/" + comboBox1.Text + "/21.txt";
                    StreamWriter streamWriter21 = new StreamWriter(text21, false);
                    streamWriter21.WriteLine(Domanda21.Text.ToString());
                    streamWriter21.Close();

                    string text22 = "profili/" + comboBox1.Text + "/22.txt";
                    StreamWriter streamWriter22 = new StreamWriter(text22, false);
                    streamWriter22.WriteLine(Domanda22.Text.ToString());
                    streamWriter22.Close();

                    string text23 = "profili/" + comboBox1.Text + "/23.txt";
                    StreamWriter streamWriter23 = new StreamWriter(text23, false);
                    streamWriter23.WriteLine(Domanda23.Text.ToString());
                    streamWriter23.Close();

                    string text24 = "profili/" + comboBox1.Text + "/24.txt";
                    StreamWriter streamWriter24 = new StreamWriter(text24, false);
                    streamWriter24.WriteLine(Domanda24.Text.ToString());
                    streamWriter24.Close();

                    string text25 = "profili/" + comboBox1.Text + "/25.txt";
                    StreamWriter streamWriter25 = new StreamWriter(text25, false);
                    streamWriter25.WriteLine(Domanda25.Text.ToString());
                    streamWriter25.Close();

                    string text26 = "profili/" + comboBox1.Text + "/26.txt";
                    StreamWriter streamWriter26 = new StreamWriter(text26, false);
                    streamWriter26.WriteLine(Domanda26.Text.ToString());
                    streamWriter26.Close();

                    string text27 = "profili/" + comboBox1.Text + "/27.txt";
                    StreamWriter streamWriter27 = new StreamWriter(text27, false);
                    streamWriter27.WriteLine(Domanda27.Text.ToString());
                    streamWriter27.Close();

                    string text28 = "profili/" + comboBox1.Text + "/28.txt";
                    StreamWriter streamWriter28 = new StreamWriter(text28, false);
                    streamWriter28.WriteLine(Domanda28.Text.ToString());
                    streamWriter28.Close();

                    string text29 = "profili/" + comboBox1.Text + "/29.txt";
                    StreamWriter streamWriter29 = new StreamWriter(text29, false);
                    streamWriter29.WriteLine(Domanda29.Text.ToString());
                    streamWriter29.Close();

                    string text30 = "profili/" + comboBox1.Text + "/30.txt";
                    StreamWriter streamWriter30 = new StreamWriter(text30, false);
                    streamWriter30.WriteLine(Domanda30.Text.ToString());
                    streamWriter30.Close();

                    string text31 = "profili/" + comboBox1.Text + "/31.txt";
                    StreamWriter streamWriter31 = new StreamWriter(text31, false);
                    streamWriter31.WriteLine(Domanda31.Text.ToString());
                    streamWriter31.Close();

                    string text32 = "profili/" + comboBox1.Text + "/32.txt";
                    StreamWriter streamWriter32 = new StreamWriter(text32, false);
                    streamWriter32.WriteLine(Domanda32.Text.ToString());
                    streamWriter32.Close();

                    string text33 = "profili/" + comboBox1.Text + "/33.txt";
                    StreamWriter streamWriter33 = new StreamWriter(text33, false);
                    streamWriter33.WriteLine(Domanda33.Text.ToString());
                    streamWriter33.Close();

                    string text34 = "profili/" + comboBox1.Text + "/34.txt";
                    StreamWriter streamWriter34 = new StreamWriter(text34, false);
                    streamWriter34.WriteLine(Domanda34.Text.ToString());
                    streamWriter34.Close();

                    string text35 = "profili/" + comboBox1.Text + "/35.txt";
                    StreamWriter streamWriter35 = new StreamWriter(text35, false);
                    streamWriter35.WriteLine(Domanda35.Text.ToString());
                    streamWriter35.Close();

                    string text36 = "profili/" + comboBox1.Text + "/36.txt";
                    StreamWriter streamWriter36 = new StreamWriter(text36, false);
                    streamWriter36.WriteLine(Domanda36.Text.ToString());
                    streamWriter36.Close();

                    string text37 = "profili/" + comboBox1.Text + "/37.txt";
                    StreamWriter streamWriter37 = new StreamWriter(text37, false);
                    streamWriter37.WriteLine(Domanda37.Text.ToString());
                    streamWriter37.Close();

                    string text38 = "profili/" + comboBox1.Text + "/38.txt";
                    StreamWriter streamWriter38 = new StreamWriter(text38, false);
                    streamWriter38.WriteLine(Domanda38.Text.ToString());
                    streamWriter38.Close();

                    string text39 = "profili/" + comboBox1.Text + "/39.txt";
                    StreamWriter streamWriter39 = new StreamWriter(text39, false);
                    streamWriter39.WriteLine(Domanda39.Text.ToString());
                    streamWriter39.Close();

                    string text40 = "profili/" + comboBox1.Text + "/40.txt";
                    StreamWriter streamWriter40 = new StreamWriter(text40, false);
                    streamWriter40.WriteLine(Domanda40.Text.ToString());
                    streamWriter40.Close();
                    Image image = pictureBox2.Image;

                    if (image != null)
                    {
                        // Salva l'immagine nel percorso specificato
                        string filePath2 = "profili/" + comboBox1.Text + "/image.png";
                        image.Save(filePath2, System.Drawing.Imaging.ImageFormat.Png);
                    }




                    // Impostazioni da salvare
                    var settings = new
                    {
                        ColoreSfondo = Properties.Settings.Default.ColoreSfondo,
                        FontTipo = Properties.Settings.Default.FontTipo,
                        FontPX = Properties.Settings.Default.FontPX,
                        FontColor = Properties.Settings.Default.FontColor,
                        Risposta = Properties.Settings.Default.Risposta,
                        Posizione = Properties.Settings.Default.Posizione,
                        BOX1 = Properties.Settings.Default.BOX1,
                        BOX2 = Properties.Settings.Default.BOX2,
                        BOX3 = Properties.Settings.Default.BOX3,
                        BOX4 = Properties.Settings.Default.BOX4,
                        BOX5 = Properties.Settings.Default.BOX5,
                        BOX6 = Properties.Settings.Default.BOX6,
                        BOX7 = Properties.Settings.Default.BOX7,
                        BOX8 = Properties.Settings.Default.BOX8,
                        BOX9 = Properties.Settings.Default.BOX9,
                        BOX10 = Properties.Settings.Default.BOX10,
                        BOX11 = Properties.Settings.Default.BOX11,
                        BOX12 = Properties.Settings.Default.BOX12,
                        BOX13 = Properties.Settings.Default.BOX13,
                        BOX14 = Properties.Settings.Default.BOX14,
                        BOX15 = Properties.Settings.Default.BOX15,
                        BOX16 = Properties.Settings.Default.BOX16,
                        BOX17 = Properties.Settings.Default.BOX17,
                        BOX18 = Properties.Settings.Default.BOX18,
                        BOX19 = Properties.Settings.Default.BOX19,
                        BOX20 = Properties.Settings.Default.BOX20,
                        BOX21 = Properties.Settings.Default.BOX21,
                        BOX22 = Properties.Settings.Default.BOX22,
                        BOX23 = Properties.Settings.Default.BOX23,
                        BOX24 = Properties.Settings.Default.BOX24,
                        BOX25 = Properties.Settings.Default.BOX25,
                        BOX26 = Properties.Settings.Default.BOX26,
                        BOX27 = Properties.Settings.Default.BOX27,
                        BOX28 = Properties.Settings.Default.BOX28,
                        BOX29 = Properties.Settings.Default.BOX29,
                        BOX30 = Properties.Settings.Default.BOX30,
                        BOX31 = Properties.Settings.Default.BOX31,
                        BOX32 = Properties.Settings.Default.BOX32,
                        BOX33 = Properties.Settings.Default.BOX33,
                        BOX34 = Properties.Settings.Default.BOX34,
                        BOX35 = Properties.Settings.Default.BOX35,
                        BOX36 = Properties.Settings.Default.BOX36,
                        BOX37 = Properties.Settings.Default.BOX37,
                        BOX38 = Properties.Settings.Default.BOX38,
                        BOX39 = Properties.Settings.Default.BOX39,
                        BOX40 = Properties.Settings.Default.BOX40,
                        User = Properties.Settings.Default.User
                    };

                    // Percorso del file di salvataggio
                    string filePath = "profili/" + comboBox1.Text + "/impostazioni.json";

                    // Serializzazione delle impostazioni in formato JSON
                    string json = JsonSerializer.Serialize(settings);

                    // Scrittura del JSON sul file
                    File.WriteAllText(filePath, json);

                    Console.WriteLine("Impostazioni salvate correttamente.");












                }
                else
                {
                    MessageBox.Show("Non hai caricato ancora il profilo che vuoi salvare", "Messaggio");
                }









            }
            else if (result == DialogResult.No)
            {

            }


















        }




        static bool IsProcessRunning(string processName)
        {
            // Ottiene tutti i processi attivi sul sistema
            Process[] processes = Process.GetProcesses();

            // Verifica se il processo specificato è presente tra i processi attivi
            foreach (Process process in processes)
            {
                if (process.ProcessName.Equals(processName, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }









        private void textBox1_TextChanged_3(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            string percorsoCartella = "profili/" + comboBox1.Text;

            // Verifica se la cartella esiste già
            if (!Directory.Exists(percorsoCartella))
            {
                // Crea la cartella
                Directory.CreateDirectory(percorsoCartella);
                Console.WriteLine("Cartella creata con successo!");
            }
            else
            {
                Console.WriteLine("La cartella esiste già.");
            }



            DialogResult result = MessageBox.Show("Vuoi davvero resettare le impostazioni originali?", "Alert", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {








                Properties.Settings.Default.ColoreSfondo = "#00C000";
                Properties.Settings.Default.FontTipo = "Segoe Print";
                Properties.Settings.Default.FontPX = "15";
                label1.ForeColor = Color.Purple;
                Color colore = label1.ForeColor;
                string coloreRGB = $"{colore.R},{colore.G},{colore.B}";
                Properties.Settings.Default.FontColor = coloreRGB;
                Properties.Settings.Default.Risposta = "100";
                Properties.Settings.Default.Posizione = "5";
                Properties.Settings.Default.BOX1 = "";
                Properties.Settings.Default.BOX2 = "";
                Properties.Settings.Default.BOX3 = "";
                Properties.Settings.Default.BOX4 = "";
                Properties.Settings.Default.BOX5 = "";
                Properties.Settings.Default.BOX6 = "";
                Properties.Settings.Default.BOX7 = "";
                Properties.Settings.Default.BOX8 = "";
                Properties.Settings.Default.BOX9 = "";
                Properties.Settings.Default.BOX10 = "";
                Properties.Settings.Default.BOX11 = "";
                Properties.Settings.Default.BOX12 = "";
                Properties.Settings.Default.BOX13 = "";
                Properties.Settings.Default.BOX14 = "";
                Properties.Settings.Default.BOX15 = "";
                Properties.Settings.Default.BOX16 = "";
                Properties.Settings.Default.BOX17 = "";
                Properties.Settings.Default.BOX18 = "";
                Properties.Settings.Default.BOX19 = "";
                Properties.Settings.Default.BOX20 = "";
                Properties.Settings.Default.BOX21 = "";
                Properties.Settings.Default.BOX22 = "";
                Properties.Settings.Default.BOX23 = "";
                Properties.Settings.Default.BOX24 = "";
                Properties.Settings.Default.BOX25 = "";
                Properties.Settings.Default.BOX26 = "";
                Properties.Settings.Default.BOX27 = "";
                Properties.Settings.Default.BOX28 = "";
                Properties.Settings.Default.BOX29 = "";
                Properties.Settings.Default.BOX30 = "";
                Properties.Settings.Default.BOX31 = "";
                Properties.Settings.Default.BOX32 = "";
                Properties.Settings.Default.BOX33 = "";
                Properties.Settings.Default.BOX34 = "";
                Properties.Settings.Default.BOX35 = "";
                Properties.Settings.Default.BOX36 = "";
                Properties.Settings.Default.BOX37 = "";
                Properties.Settings.Default.BOX38 = "";
                Properties.Settings.Default.BOX39 = "";
                Properties.Settings.Default.BOX40 = "";
                Properties.Settings.Default.Save();



                string text1 = "profili/" + comboBox1.Text + "/1.txt";
                StreamWriter streamWriter1 = new StreamWriter(text1, false);
                streamWriter1.WriteLine("Domanda numero 1");
                streamWriter1.Close();

                string text2 = "profili/" + comboBox1.Text + "/2.txt";
                StreamWriter streamWriter2 = new StreamWriter(text2, false);
                streamWriter2.WriteLine("Domanda numero 2");
                streamWriter2.Close();

                string text3 = "profili/" + comboBox1.Text + "/3.txt";
                StreamWriter streamWriter3 = new StreamWriter(text3, false);
                streamWriter3.WriteLine("Domanda numero 3");
                streamWriter3.Close();

                string text4 = "profili/" + comboBox1.Text + "/4.txt";
                StreamWriter streamWriter4 = new StreamWriter(text4, false);
                streamWriter4.WriteLine("Domanda numero 4");
                streamWriter4.Close();

                string text5 = "profili/" + comboBox1.Text + "/5.txt";
                StreamWriter streamWriter5 = new StreamWriter(text5, false);
                streamWriter5.WriteLine("Domanda numero 5");
                streamWriter5.Close();

                string text6 = "profili/" + comboBox1.Text + "/6.txt";
                StreamWriter streamWriter6 = new StreamWriter(text6, false);
                streamWriter6.WriteLine("Domanda numero 6");
                streamWriter6.Close();

                string text7 = "profili/" + comboBox1.Text + "/7.txt";
                StreamWriter streamWriter7 = new StreamWriter(text7, false);
                streamWriter7.WriteLine("Domanda numero 7");
                streamWriter7.Close();

                string text8 = "profili/" + comboBox1.Text + "/8.txt";
                StreamWriter streamWriter8 = new StreamWriter(text8, false);
                streamWriter8.WriteLine("Domanda numero 8");
                streamWriter8.Close();

                string text9 = "profili/" + comboBox1.Text + "/9.txt";
                StreamWriter streamWriter9 = new StreamWriter(text9, false);
                streamWriter9.WriteLine("Domanda numero 9");
                streamWriter9.Close();

                string text10 = "profili/" + comboBox1.Text + "/10.txt";
                StreamWriter streamWriter10 = new StreamWriter(text10, false);
                streamWriter10.WriteLine("Domanda numero 10");
                streamWriter10.Close();

                string text11 = "profili/" + comboBox1.Text + "/11.txt";
                StreamWriter streamWriter11 = new StreamWriter(text11, false);
                streamWriter11.WriteLine("Domanda numero 11");
                streamWriter11.Close();

                string text12 = "profili/" + comboBox1.Text + "/12.txt";
                StreamWriter streamWriter12 = new StreamWriter(text12, false);
                streamWriter12.WriteLine("Domanda numero 12");
                streamWriter12.Close();

                string text13 = "profili/" + comboBox1.Text + "/13.txt";
                StreamWriter streamWriter13 = new StreamWriter(text13, false);
                streamWriter13.WriteLine("Domanda numero 13");
                streamWriter13.Close();

                string text14 = "profili/" + comboBox1.Text + "/14.txt";
                StreamWriter streamWriter14 = new StreamWriter(text14, false);
                streamWriter14.WriteLine("Domanda numero 14");
                streamWriter14.Close();

                string text15 = "profili/" + comboBox1.Text + "/15.txt";
                StreamWriter streamWriter15 = new StreamWriter(text15, false);
                streamWriter15.WriteLine("Domanda numero 15");
                streamWriter15.Close();

                string text16 = "profili/" + comboBox1.Text + "/16.txt";
                StreamWriter streamWriter16 = new StreamWriter(text16, false);
                streamWriter16.WriteLine("Domanda numero 16");
                streamWriter16.Close();

                string text17 = "profili/" + comboBox1.Text + "/17.txt";
                StreamWriter streamWriter17 = new StreamWriter(text17, false);
                streamWriter17.WriteLine("Domanda numero 17");
                streamWriter17.Close();

                string text18 = "profili/" + comboBox1.Text + "/18.txt";
                StreamWriter streamWriter18 = new StreamWriter(text18, false);
                streamWriter18.WriteLine("Domanda numero 18");
                streamWriter18.Close();

                string text19 = "profili/" + comboBox1.Text + "/19.txt";
                StreamWriter streamWriter19 = new StreamWriter(text19, false);
                streamWriter19.WriteLine("Domanda numero 19");
                streamWriter19.Close();

                string text20 = "profili/" + comboBox1.Text + "/20.txt";
                StreamWriter streamWriter20 = new StreamWriter(text20, false);
                streamWriter20.WriteLine("Domanda numero 20");
                streamWriter20.Close();


                string text21 = "profili/" + comboBox1.Text + "/21.txt";
                StreamWriter streamWriter21 = new StreamWriter(text21, false);
                streamWriter21.WriteLine("Domanda numero 21");
                streamWriter21.Close();

                string text22 = "profili/" + comboBox1.Text + "/22.txt";
                StreamWriter streamWriter22 = new StreamWriter(text22, false);
                streamWriter22.WriteLine("Domanda numero 22");
                streamWriter22.Close();

                string text23 = "profili/" + comboBox1.Text + "/23.txt";
                StreamWriter streamWriter23 = new StreamWriter(text23, false);
                streamWriter23.WriteLine("Domanda numero 23");
                streamWriter23.Close();

                string text24 = "profili/" + comboBox1.Text + "/24.txt";
                StreamWriter streamWriter24 = new StreamWriter(text24, false);
                streamWriter24.WriteLine("Domanda numero 24");
                streamWriter24.Close();

                string text25 = "profili/" + comboBox1.Text + "/25.txt";
                StreamWriter streamWriter25 = new StreamWriter(text25, false);
                streamWriter25.WriteLine("Domanda numero 25");
                streamWriter25.Close();

                string text26 = "profili/" + comboBox1.Text + "/26.txt";
                StreamWriter streamWriter26 = new StreamWriter(text26, false);
                streamWriter26.WriteLine("Domanda numero 26");
                streamWriter26.Close();

                string text27 = "profili/" + comboBox1.Text + "/27.txt";
                StreamWriter streamWriter27 = new StreamWriter(text27, false);
                streamWriter27.WriteLine("Domanda numero 27");
                streamWriter27.Close();

                string text28 = "profili/" + comboBox1.Text + "/28.txt";
                StreamWriter streamWriter28 = new StreamWriter(text28, false);
                streamWriter28.WriteLine("Domanda numero 28");
                streamWriter28.Close();

                string text29 = "profili/" + comboBox1.Text + "/29.txt";
                StreamWriter streamWriter29 = new StreamWriter(text29, false);
                streamWriter29.WriteLine("Domanda numero 29");
                streamWriter29.Close();

                string text30 = "profili/" + comboBox1.Text + "/30.txt";
                StreamWriter streamWriter30 = new StreamWriter(text30, false);
                streamWriter30.WriteLine("Domanda numero 30");
                streamWriter30.Close();

                string text31 = "profili/" + comboBox1.Text + "/31.txt";
                StreamWriter streamWriter31 = new StreamWriter(text31, false);
                streamWriter31.WriteLine("Domanda numero 31");
                streamWriter31.Close();

                string text32 = "profili/" + comboBox1.Text + "/32.txt";
                StreamWriter streamWriter32 = new StreamWriter(text32, false);
                streamWriter32.WriteLine("Domanda numero 32");
                streamWriter32.Close();

                string text33 = "profili/" + comboBox1.Text + "/33.txt";
                StreamWriter streamWriter33 = new StreamWriter(text33, false);
                streamWriter33.WriteLine("Domanda numero 33");
                streamWriter33.Close();

                string text34 = "profili/" + comboBox1.Text + "/34.txt";
                StreamWriter streamWriter34 = new StreamWriter(text34, false);
                streamWriter34.WriteLine("Domanda numero 34");
                streamWriter34.Close();

                string text35 = "profili/" + comboBox1.Text + "/35.txt";
                StreamWriter streamWriter35 = new StreamWriter(text35, false);
                streamWriter35.WriteLine("Domanda numero 35");
                streamWriter35.Close();

                string text36 = "profili/" + comboBox1.Text + "/36.txt";
                StreamWriter streamWriter36 = new StreamWriter(text36, false);
                streamWriter36.WriteLine("Domanda numero 36");
                streamWriter36.Close();

                string text37 = "profili/" + comboBox1.Text + "/37.txt";
                StreamWriter streamWriter37 = new StreamWriter(text37, false);
                streamWriter37.WriteLine("Domanda numero 37");
                streamWriter37.Close();

                string text38 = "profili/" + comboBox1.Text + "/38.txt";
                StreamWriter streamWriter38 = new StreamWriter(text38, false);
                streamWriter38.WriteLine("Domanda numero 38");
                streamWriter38.Close();

                string text39 = "profili/" + comboBox1.Text + "/39.txt";
                StreamWriter streamWriter39 = new StreamWriter(text39, false);
                streamWriter39.WriteLine("Domanda numero 39");
                streamWriter39.Close();

                string text40 = "profili/" + comboBox1.Text + "/40.txt";
                StreamWriter streamWriter40 = new StreamWriter(text40, false);
                streamWriter40.WriteLine("Domanda numero 40");
                streamWriter40.Close();



                string imagePath = "profili/" + comboBox1.Text + "/image.png";
                if (File.Exists(imagePath))
                {
                    File.Delete(imagePath);
                }

                this.Close();
            }
            else if (result == DialogResult.No)
            {

            }

        }
        int zero = 1;

        private void timer3_Tick(object sender, EventArgs e)
        {
            zero = zero + 1;
            Random generator = new Random();
            for (int i = 0; i < 20; i++)
            {



                number = generator.Next(1, 21);
                if (number == 1)
                {

                    label1.Text = "1- " + Domanda1.Text.ToString();



                }

                if (number == 2)
                {

                    label1.Text = "2- " + Domanda2.Text.ToString();



                }
                if (number == 3)
                {

                    label1.Text = "3- " + Domanda3.Text.ToString();


                }
                if (number == 4)
                {

                    label1.Text = "4- " + Domanda4.Text.ToString();


                }
                if (number == 5)
                {

                    label1.Text = "5- " + Domanda5.Text.ToString();


                }

                if (number == 6)
                {

                    label1.Text = "6- " + Domanda6.Text.ToString();


                }

                if (number == 7)
                {

                    label1.Text = "7- " + Domanda7.Text.ToString();


                }
                if (number == 8)
                {

                    label1.Text = "8- " + Domanda8.Text.ToString();


                }
                if (number == 9)
                {

                    label1.Text = "9- " + Domanda9.Text.ToString();


                }
                if (number == 10)
                {

                    label1.Text = "10- " + Domanda10.Text.ToString();


                }

                if (number == 11)
                {

                    label1.Text = "11- " + Domanda11.Text.ToString();


                }
                if (number == 12)
                {

                    label1.Text = "12- " + Domanda12.Text.ToString();


                }
                if (number == 13)
                {

                    label1.Text = "13- " + Domanda13.Text.ToString();


                }
                if (number == 14)
                {

                    label1.Text = "14- " + Domanda14.Text.ToString();


                }
                if (number == 15)
                {

                    label1.Text = "15- " + Domanda15.Text.ToString();


                }
                if (number == 16)
                {

                    label1.Text = "16- " + Domanda16.Text.ToString();


                }
                if (number == 17)
                {

                    label1.Text = "17- " + Domanda17.Text.ToString();


                }
                if (number == 18)
                {

                    label1.Text = "18- " + Domanda18.Text.ToString();


                }
                if (number == 19)
                {

                    label1.Text = "19- " + Domanda19.Text.ToString();


                }
                if (number == 20)
                {

                    label1.Text = "20- " + Domanda20.Text.ToString();


                }
























            }
            Console.Read();
            if (zero == 1000)
            {
                timer1.Start();
            }



        }

        private void button9_Click(object sender, EventArgs e)
        {

            this.BackColor = Color.FromArgb(0, 192, 0);


        }
        string aggiornamento = "";
        string convalidato;
        string versione = "1.1";
        private void label5_Click_1(object sender, EventArgs e)
        {
            Process currentProcess = Process.GetCurrentProcess();

            // Ottiene il nome del processo corrente
            string processName = currentProcess.ProcessName;
            string filePath = processName + ".exe"; // Inserisci il percorso del file qui

            FileInfo fileInfo = new FileInfo(filePath);
            long fileSizeInBytes = fileInfo.Length;

            // Converti il peso del file da byte ad altre unità di misura
            double fileSizeInKb = fileSizeInBytes;

            if (fileSizeInBytes == 553472)
            {
                convalidato = "SI";
            }
            else
            {
                convalidato = "NO";
            }
            string modifica = @"Domande.exe"; // Il percorso del file da controllare
            DateTime lastModified = File.GetLastWriteTime(modifica);
            string lastModifiedDate = lastModified.ToString("dd/MM/yyyy HH:mm:ss");

            string text1 = @"chat.html";
            StreamWriter streamWriter1 = new StreamWriter(text1, false);
            streamWriter1.WriteLine("Informazioni utili<br>Versione: " + versione.ToString() + "<br>File integro: " + convalidato.ToString() + "<br>Nuova versione disponibile: " + aggiornamento.ToString() + "<br>Ultimo aggiornamento: " + lastModifiedDate.ToString() + "<br> Manuale Bot: " + "<br> !start per generale la domanda [Streamer]" + "<br> !domanda per inserire la domanda (es. !domanda come sta la Nonna?) [Tutti]" + "<br> !personalizzata per generale una domanda personalizzata (es. !personalizzata come sta Zia?) [Streamer]"+"<br>!profilo per cambiare profilo (es. !profilo HarryPotter) [Streamer]" + "<br>MIT License<br><br>Copyright (c) 2023 Nextvision<br><br>Permission is hereby granted, free of charge, to any person obtaining a copy\r\nof this software and associated documentation files (the \"Software\"), to deal\r\nin the Software without restriction, including without limitation the rights\r\nto use, copy, modify, merge, publish, distribute, sublicense, and/or sell\r\ncopies of the Software, and to permit persons to whom the Software is\r\nfurnished to do so, subject to the following conditions:\r\n\r\nThe above copyright notice and this permission notice shall be included in all\r\ncopies or substantial portions of the Software.<br><br>THE SOFTWARE IS PROVIDED \"AS IS\", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR\r\nIMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,\r\nFITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE\r\nAUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER\r\nLIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,\r\nOUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE\r\nSOFTWARE.");
            streamWriter1.Close();



            string currentDirectory = Environment.CurrentDirectory;
            // Costruisce il percorso completo del file desiderato
            string filePath3 = Path.Combine(currentDirectory, @"chat.html");
            Process.Start(filePath3.ToString());



        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_MouseEnter(object sender, EventArgs e)
        {
        }

        private void textBox22_Click(object sender, EventArgs e)
        {

            comboBox1.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label50.Text = "Profilo: " + comboBox1.Text;

            string percorsoCartella = "profili/" + comboBox1.Text;

            // Verifica se la cartella esiste già
            if (!Directory.Exists(percorsoCartella))
            {
                // Crea la cartella
                Directory.CreateDirectory(percorsoCartella);
                Console.WriteLine("Cartella creata con successo!");
            }
            else
            {
                Console.WriteLine("La cartella esiste già.");
            }









            timer2.Start();
            check1.Checked = false;
            check2.Checked = false;
            check3.Checked = false;
            check4.Checked = false;
            check5.Checked = false;
            check6.Checked = false;
            check7.Checked = false;
            check8.Checked = false;
            check9.Checked = false;
            check10.Checked = false;
            check11.Checked = false;
            check12.Checked = false;
            check13.Checked = false;
            check14.Checked = false;
            check15.Checked = false;
            check16.Checked = false;
            check17.Checked = false;
            check18.Checked = false;
            check19.Checked = false;
            check20.Checked = false;
            check21.Checked = false;
            check22.Checked = false;
            check23.Checked = false;
            check24.Checked = false;
            check25.Checked = false;
            check26.Checked = false;
            check27.Checked = false;
            check28.Checked = false;
            check29.Checked = false;
            check30.Checked = false;
            check31.Checked = false;
            check32.Checked = false;
            check33.Checked = false;
            check34.Checked = false;
            check35.Checked = false;
            check36.Checked = false;
            check37.Checked = false;
            check38.Checked = false;
            check39.Checked = false;
            check40.Checked = false;




            string filePath = "profili/" + comboBox1.Text + "/impostazioni.json";

            // Lettura del contenuto del file

            if (File.Exists(filePath))
            {
                try
                {

                    string json = File.ReadAllText(filePath);

                    MySettings settings = JsonSerializer.Deserialize<MySettings>(json);

                    // Accesso ai dati dell'oggetto dinamico
                    string ColoreSfondo = settings.ColoreSfondo;
                    string FontTipo = settings.FontTipo;
                    string FontPX = settings.FontPX;
                    string FontColor = settings.FontColor;
                    string Risposta = settings.Risposta;
                    string Posizione = settings.Posizione;
                    string BOX1 = settings.BOX1;
                    string BOX2 = settings.BOX2;
                    string BOX3 = settings.BOX3;
                    string BOX4 = settings.BOX4;
                    string BOX5 = settings.BOX5;
                    string BOX6 = settings.BOX6;
                    string BOX7 = settings.BOX7;
                    string BOX8 = settings.BOX8;
                    string BOX9 = settings.BOX9;
                    string BOX10 = settings.BOX10;
                    string BOX11 = settings.BOX11;
                    string BOX12 = settings.BOX12;
                    string BOX13 = settings.BOX13;
                    string BOX14 = settings.BOX14;
                    string BOX15 = settings.BOX15;
                    string BOX16 = settings.BOX16;
                    string BOX17 = settings.BOX17;
                    string BOX18 = settings.BOX18;
                    string BOX19 = settings.BOX19;
                    string BOX20 = settings.BOX20;
                    string BOX21 = settings.BOX21;
                    string BOX22 = settings.BOX22;
                    string BOX23 = settings.BOX23;
                    string BOX24 = settings.BOX24;
                    string BOX25 = settings.BOX25;
                    string BOX26 = settings.BOX26;
                    string BOX27 = settings.BOX27;
                    string BOX28 = settings.BOX28;
                    string BOX29 = settings.BOX29;
                    string BOX30 = settings.BOX30;
                    string BOX31 = settings.BOX31;
                    string BOX32 = settings.BOX32;
                    string BOX33 = settings.BOX33;
                    string BOX34 = settings.BOX34;
                    string BOX35 = settings.BOX35;
                    string BOX36 = settings.BOX36;
                    string BOX37 = settings.BOX37;
                    string BOX38 = settings.BOX38;
                    string BOX39 = settings.BOX39;
                    string BOX40 = settings.BOX40;
                    string User = settings.User;












                    string coloreHtml = ColoreSfondo;

                    Color mioColore = ColorTranslator.FromHtml(coloreHtml); // Convert the HTML color string to a Color object

                    this.BackColor = mioColore; // Set the background color of the control


                    string nomeTipoCarattere = FontTipo;
                    string PX = FontPX;
                    string colorePersonalizzato = FontColor;
                    string risposta = Risposta;
                    int posizioneInt = Convert.ToInt32(risposta);
                    trackBar1.Value = posizioneInt;
                    string posizione = Posizione;
                    Twitch_User.Text = User;
                    if (BOX1 == "true")
                    {
                        check1.Checked = true;
                    }
                    if (BOX2 == "true")
                    {
                        check2.Checked = true;
                    }
                    if (BOX3 == "true")
                    {
                        check3.Checked = true;
                    }
                    if (BOX4 == "true")
                    {
                        check4.Checked = true;
                    }
                    if (BOX5 == "true")
                    {
                        check5.Checked = true;
                    }
                    if (BOX6 == "true")
                    {
                        check6.Checked = true;
                    }
                    if (BOX7 == "true")
                    {
                        check7.Checked = true;
                    }
                    if (BOX8 == "true")
                    {
                        check8.Checked = true;
                    }
                    if (BOX9 == "true")
                    {
                        check9.Checked = true;
                    }
                    if (BOX10 == "true")
                    {
                        check10.Checked = true;
                    }

                    if (BOX11 == "true")
                    {
                        check11.Checked = true;
                    }
                    if (BOX12 == "true")
                    {
                        check12.Checked = true;
                    }
                    if (BOX13 == "true")
                    {
                        check13.Checked = true;
                    }
                    if (BOX14 == "true")
                    {
                        check14.Checked = true;
                    }
                    if (BOX15 == "true")
                    {
                        check15.Checked = true;
                    }
                    if (BOX16 == "true")
                    {
                        check16.Checked = true;
                    }
                    if (BOX17 == "true")
                    {
                        check17.Checked = true;
                    }
                    if (BOX18 == "true")
                    {
                        check18.Checked = true;
                    }
                    if (BOX19 == "true")
                    {
                        check19.Checked = true;
                    }
                    if (BOX20 == "true")
                    {
                        check20.Checked = true;
                    }

                    if (BOX21 == "true")
                    {
                        check21.Checked = true;
                    }
                    if (BOX22 == "true")
                    {
                        check22.Checked = true;
                    }
                    if (BOX23 == "true")
                    {
                        check23.Checked = true;
                    }
                    if (BOX24 == "true")
                    {
                        check24.Checked = true;
                    }
                    if (BOX25 == "true")
                    {
                        check25.Checked = true;
                    }
                    if (BOX26 == "true")
                    {
                        check26.Checked = true;
                    }
                    if (BOX27 == "true")
                    {
                        check27.Checked = true;
                    }
                    if (BOX28 == "true")
                    {
                        check28.Checked = true;
                    }
                    if (BOX29 == "true")
                    {
                        check29.Checked = true;
                    }
                    if (BOX30 == "true")
                    {
                        check30.Checked = true;
                    }

                    if (BOX31 == "true")
                    {
                        check31.Checked = true;
                    }
                    if (BOX32 == "true")
                    {
                        check32.Checked = true;
                    }
                    if (BOX33 == "true")
                    {
                        check33.Checked = true;
                    }
                    if (BOX34 == "true")
                    {
                        check34.Checked = true;
                    }
                    if (BOX35 == "true")
                    {
                        check35.Checked = true;
                    }
                    if (BOX36 == "true")
                    {
                        check36.Checked = true;
                    }
                    if (BOX37 == "true")
                    {
                        check37.Checked = true;
                    }
                    if (BOX38 == "true")
                    {
                        check38.Checked = true;
                    }
                    if (BOX39 == "true")
                    {
                        check39.Checked = true;
                    }
                    if (BOX40 == "true")
                    {
                        check40.Checked = true;
                    }























                    int posizioneInt2 = Convert.ToInt32(posizione);
                    trackBar3.Value = posizioneInt2;
                    string[] valoriRGB = colorePersonalizzato.Split(',');
                    int r, g, b;
                    if (valoriRGB.Length != 3 || !int.TryParse(valoriRGB[0], out r) || !int.TryParse(valoriRGB[1], out g) || !int.TryParse(valoriRGB[2], out b) || r < 0 || r > 255 || g < 0 || g > 255 || b < 0 || b > 255)
                    {
                        // gestione dell'errore: i valori RGB non sono validi
                    }
                    else
                    {
                        // creazione del colore
                        Color colore = Color.FromArgb(r, g, b);
                        label1.ForeColor = colore;
                        // utilizzo del colore
                        // ...
                    }


                    int dimensioneFont;

                    if (int.TryParse(PX, out dimensioneFont))
                    {
                        label1.Font = new Font(nomeTipoCarattere, dimensioneFont);
                    }
                    timer1.Interval = trackBar1.Value;
                    label3.Text = timer1.Interval.ToString() + " MS";
                    label1.SetBounds(label1.Location.X, 28 - trackBar3.Value, label1.Width, label1.Height);
                    label6.Text = "Posizione font di: " + label1.Location.Y + " PX";



                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Errore durante la lettura o la deserializzazione del file JSON: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Hai selezionato un profilo che non esiste ancora modificalo e premi salva.");
            }










            string imagePath = "profili/" + comboBox1.Text + "/image.png";
            if (File.Exists(imagePath))
            {

            }
            else
            {
                Image image = pictureBox2.Image;

                if (image != null)
                {
                    // Salva l'immagine nel percorso specificato
                    string filePath2 = "profili/" + comboBox1.Text + "/image.png";
                    image.Save(filePath2, System.Drawing.Imaging.ImageFormat.Png);
                }

            }






            string filePath3 = "profili/" + comboBox1.Text + "/image.png";

            if (File.Exists(filePath3))
            {
                try
                {
                    using (var fileStream = new FileStream(filePath3, FileMode.Open, FileAccess.Read))
                    {
                        // Crea un oggetto Bitmap dall'immagine nel file stream
                        var bitmap = new Bitmap(fileStream);

                        // Verifica se l'oggetto Bitmap è valido
                        if (bitmap.Width > 0 && bitmap.Height > 0)
                        {
                            // Imposta l'immagine nella PictureBox
                            pictureBox2.Image = bitmap;
                        }
                        else
                        {
                            Console.WriteLine("Il file immagine non è valido!");
                        }
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Errore durante la lettura del file immagine: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Il file immagine non esiste!");
            }




            label1.Parent = pictureBox2;
            label1.BackColor = Color.Transparent;

            foreach (FontFamily font in FontFamily.Families)
            {


            }

            string NomeFile1 = "profili/" + comboBox1.Text + "/1.txt";
            StreamReader FileTesto1;
            try
            {
                FileTesto1 = new StreamReader(NomeFile1);
                Domanda1.Text = FileTesto1.ReadLine();
                FileTesto1.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile2 = "profili/" + comboBox1.Text + "/2.txt";
            StreamReader FileTesto2;
            try
            {
                FileTesto2 = new StreamReader(NomeFile2);
                Domanda2.Text = FileTesto2.ReadLine();
                FileTesto2.Close();

            }
            catch (FileNotFoundException)
            {

            }

            string NomeFile3 = "profili/" + comboBox1.Text + "/3.txt";
            StreamReader FileTesto3;
            try
            {
                FileTesto3 = new StreamReader(NomeFile3);
                Domanda3.Text = FileTesto3.ReadLine();
                FileTesto3.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile4 = "profili/" + comboBox1.Text + "/4.txt";
            StreamReader FileTesto4;
            try
            {
                FileTesto4 = new StreamReader(NomeFile4);
                Domanda4.Text = FileTesto4.ReadLine();
                FileTesto4.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile5 = "profili/" + comboBox1.Text + "/5.txt";
            StreamReader FileTesto5;
            try
            {
                FileTesto5 = new StreamReader(NomeFile5);
                Domanda5.Text = FileTesto5.ReadLine();
                FileTesto5.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile6 = "profili/" + comboBox1.Text + "/6.txt";
            StreamReader FileTesto6;
            try
            {
                FileTesto6 = new StreamReader(NomeFile6);
                Domanda6.Text = FileTesto6.ReadLine();
                FileTesto6.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile7 = "profili/" + comboBox1.Text + "/7.txt";
            StreamReader FileTesto7;
            try
            {
                FileTesto7 = new StreamReader(NomeFile7);
                Domanda7.Text = FileTesto7.ReadLine();
                FileTesto7.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile8 = "profili/" + comboBox1.Text + "/8.txt";
            StreamReader FileTesto8;
            try
            {
                FileTesto8 = new StreamReader(NomeFile8);
                Domanda8.Text = FileTesto8.ReadLine();
                FileTesto8.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile9 = "profili/" + comboBox1.Text + "/9.txt";
            StreamReader FileTesto9;
            try
            {
                FileTesto9 = new StreamReader(NomeFile9);
                Domanda9.Text = FileTesto9.ReadLine();
                FileTesto9.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile10 = "profili/" + comboBox1.Text + "/10.txt";
            StreamReader FileTesto10;
            try
            {
                FileTesto10 = new StreamReader(NomeFile10);
                Domanda10.Text = FileTesto10.ReadLine();
                FileTesto10.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile11 = "profili/" + comboBox1.Text + "/11.txt";
            StreamReader FileTesto11;
            try
            {
                FileTesto11 = new StreamReader(NomeFile11);
                Domanda11.Text = FileTesto11.ReadLine();
                FileTesto11.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile12 = "profili/" + comboBox1.Text + "/12.txt";
            StreamReader FileTesto12;
            try
            {
                FileTesto12 = new StreamReader(NomeFile12);
                Domanda12.Text = FileTesto12.ReadLine();
                FileTesto12.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile13 = "profili/" + comboBox1.Text + "/13.txt";
            StreamReader FileTesto13;
            try
            {
                FileTesto13 = new StreamReader(NomeFile13);
                Domanda13.Text = FileTesto13.ReadLine();
                FileTesto13.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile14 = "profili/" + comboBox1.Text + "/14.txt";
            StreamReader FileTesto14;
            try
            {
                FileTesto14 = new StreamReader(NomeFile14);
                Domanda14.Text = FileTesto14.ReadLine();
                FileTesto14.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile15 = "profili/" + comboBox1.Text + "/15.txt";
            StreamReader FileTesto15;
            try
            {
                FileTesto15 = new StreamReader(NomeFile15);
                Domanda15.Text = FileTesto15.ReadLine();
                FileTesto15.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile16 = "profili/" + comboBox1.Text + "/16.txt";
            StreamReader FileTesto16;
            try
            {
                FileTesto16 = new StreamReader(NomeFile16);
                Domanda16.Text = FileTesto16.ReadLine();
                FileTesto16.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile17 = "profili/" + comboBox1.Text + "/17.txt";
            StreamReader FileTesto17;
            try
            {
                FileTesto17 = new StreamReader(NomeFile17);
                Domanda17.Text = FileTesto17.ReadLine();
                FileTesto17.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile18 = "profili/" + comboBox1.Text + "/18.txt";
            StreamReader FileTesto18;
            try
            {
                FileTesto18 = new StreamReader(NomeFile18);
                Domanda18.Text = FileTesto18.ReadLine();
                FileTesto18.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile19 = "profili/" + comboBox1.Text + "/19.txt";
            StreamReader FileTesto19;
            try
            {
                FileTesto19 = new StreamReader(NomeFile19);
                Domanda19.Text = FileTesto19.ReadLine();
                FileTesto19.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile20 = "profili/" + comboBox1.Text + "/20.txt";
            StreamReader FileTesto20;
            try
            {
                FileTesto20 = new StreamReader(NomeFile20);
                Domanda20.Text = FileTesto20.ReadLine();
                FileTesto20.Close();

            }
            catch (FileNotFoundException)
            {

            }


            string NomeFile21 = "profili/" + comboBox1.Text + "/21.txt";
            StreamReader FileTesto21;
            try
            {
                FileTesto21 = new StreamReader(NomeFile21);
                Domanda21.Text = FileTesto21.ReadLine();
                FileTesto21.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile22 = "profili/" + comboBox1.Text + "/22.txt";
            StreamReader FileTesto22;
            try
            {
                FileTesto22 = new StreamReader(NomeFile22);
                Domanda22.Text = FileTesto22.ReadLine();
                FileTesto22.Close();

            }
            catch (FileNotFoundException)
            {

            }

            string NomeFile23 = "profili/" + comboBox1.Text + "/23.txt";
            StreamReader FileTesto23;
            try
            {
                FileTesto23 = new StreamReader(NomeFile23);
                Domanda23.Text = FileTesto23.ReadLine();
                FileTesto23.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile24 = "profili/" + comboBox1.Text + "/24.txt";
            StreamReader FileTesto24;
            try
            {
                FileTesto24 = new StreamReader(NomeFile24);
                Domanda24.Text = FileTesto24.ReadLine();
                FileTesto24.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile25 = "profili/" + comboBox1.Text + "/25.txt";
            StreamReader FileTesto25;
            try
            {
                FileTesto25 = new StreamReader(NomeFile25);
                Domanda25.Text = FileTesto25.ReadLine();
                FileTesto25.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile26 = "profili/" + comboBox1.Text + "/26.txt";
            StreamReader FileTesto26;
            try
            {
                FileTesto26 = new StreamReader(NomeFile26);
                Domanda26.Text = FileTesto26.ReadLine();
                FileTesto26.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile27 = "profili/" + comboBox1.Text + "/27.txt";
            StreamReader FileTesto27;
            try
            {
                FileTesto27 = new StreamReader(NomeFile27);
                Domanda27.Text = FileTesto27.ReadLine();
                FileTesto27.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile28 = "profili/" + comboBox1.Text + "/28.txt";
            StreamReader FileTesto28;
            try
            {
                FileTesto28 = new StreamReader(NomeFile28);
                Domanda28.Text = FileTesto28.ReadLine();
                FileTesto28.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile29 = "profili/" + comboBox1.Text + "/29.txt";
            StreamReader FileTesto29;
            try
            {
                FileTesto29 = new StreamReader(NomeFile29);
                Domanda29.Text = FileTesto29.ReadLine();
                FileTesto29.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile30 = "profili/" + comboBox1.Text + "/30.txt";
            StreamReader FileTesto30;
            try
            {
                FileTesto30 = new StreamReader(NomeFile30);
                Domanda30.Text = FileTesto30.ReadLine();
                FileTesto30.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile31 = "profili/" + comboBox1.Text + "/31.txt";
            StreamReader FileTesto31;
            try
            {
                FileTesto31 = new StreamReader(NomeFile31);
                Domanda31.Text = FileTesto31.ReadLine();
                FileTesto31.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile32 = "profili/" + comboBox1.Text + "/32.txt";
            StreamReader FileTesto32;
            try
            {
                FileTesto32 = new StreamReader(NomeFile32);
                Domanda32.Text = FileTesto32.ReadLine();
                FileTesto32.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile33 = "profili/" + comboBox1.Text + "/33.txt";
            StreamReader FileTesto33;
            try
            {
                FileTesto33 = new StreamReader(NomeFile33);
                Domanda33.Text = FileTesto33.ReadLine();
                FileTesto33.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile34 = "profili/" + comboBox1.Text + "/34.txt";
            StreamReader FileTesto34;
            try
            {
                FileTesto34 = new StreamReader(NomeFile34);
                Domanda34.Text = FileTesto34.ReadLine();
                FileTesto34.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile35 = "profili/" + comboBox1.Text + "/35.txt";
            StreamReader FileTesto35;
            try
            {
                FileTesto35 = new StreamReader(NomeFile35);
                Domanda35.Text = FileTesto35.ReadLine();
                FileTesto35.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile36 = "profili/" + comboBox1.Text + "/36.txt";
            StreamReader FileTesto36;
            try
            {
                FileTesto36 = new StreamReader(NomeFile36);
                Domanda36.Text = FileTesto36.ReadLine();
                FileTesto36.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile37 = "profili/" + comboBox1.Text + "/37.txt";
            StreamReader FileTesto37;
            try
            {
                FileTesto37 = new StreamReader(NomeFile37);
                Domanda37.Text = FileTesto37.ReadLine();
                FileTesto37.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile38 = "profili/" + comboBox1.Text + "/38.txt";
            StreamReader FileTesto38;
            try
            {
                FileTesto38 = new StreamReader(NomeFile38);
                Domanda38.Text = FileTesto38.ReadLine();
                FileTesto38.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile39 = "profili/" + comboBox1.Text + "/39.txt";
            StreamReader FileTesto39;
            try
            {
                FileTesto39 = new StreamReader(NomeFile39);
                Domanda39.Text = FileTesto39.ReadLine();
                FileTesto39.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile40 = "profili/" + comboBox1.Text + "/40.txt";
            StreamReader FileTesto40;
            try
            {
                FileTesto40 = new StreamReader(NomeFile40);
                Domanda40.Text = FileTesto40.ReadLine();
                FileTesto40.Close();

            }
            catch (FileNotFoundException)
            {

            }





        }

        private void textBox22_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Esegui qui il codice per premere il pulsante
                button8.PerformClick();
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {








        }

        private void trackBar2_Scroll_1(object sender, EventArgs e)
        {
            label7.Text = "Attesa fake: " + trackBar2.Value;
        }
        int attesa = 0;
        private void timer3_Tick_1(object sender, EventArgs e)
        {

            attesa = attesa + 1;
            timer3.Interval = trackBar2.Value;
            if (attesa == 100)
            {
                timer1.Start();
                attesa = 0;
                timer3.Stop();
            }
            else
            {
                label1.Text = attesa.ToString() + "%";
            }
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked == true)
            {
                checkBox21.Text = "Attesa fake: Attiva";
            }
            else
            {
                checkBox21.Text = "Attesa fake: Non attiva";
            }
        }

        private void button9_Click_2(object sender, EventArgs e)
        {



        }

        private void button9_Click_3(object sender, EventArgs e)
        {





        }

        private void timer4_Tick(object sender, EventArgs e)
        {

        }
        int x = 1;
        private void timer4_Tick_1(object sender, EventArgs e)
        {




            Bitmap bitmap = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            pictureBox2.DrawToBitmap(bitmap, new Rectangle(0, 0, pictureBox2.Width, pictureBox2.Height));
            bitmap.Save("image2.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] imageBytes = File.ReadAllBytes("image2.jpg");
            string base64String = Convert.ToBase64String(imageBytes);

            responseString = "<html><div id=\"image\">\r\n<img src='data:image/jpg;base64," + base64String + "'>  <!-- Qui va inserito il codice HTML che deve essere aggiornato -->\r\n</div>\r\n\r\n<script>\r\n  // Replace \"dataUrl\" with the URL of your data source\r\n  const dataUrl = \"http://localhost:8080/\";\r\n\r\n  function updateData() {\r\n    fetch(dataUrl)\r\n      .then(response => response.text())\r\n      .then(data => {\r\n        // Replace \"image\" with the ID of the <div> element to update\r\n        const imageDiv = document.getElementById(\"image\");\r\n        imageDiv.innerHTML = data;\r\n      })\r\n      .catch(error => {\r\n        console.error(error);\r\n      });\r\n  }\r\n\r\n  // Update the data every 50 ms\r\n  setInterval(updateData,50);\r\n</script></html>";



        }


        private static ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            ImageCodecInfo[] encoders = ImageCodecInfo.GetImageEncoders();
            foreach (ImageCodecInfo encoder in encoders)
            {
                if (encoder.MimeType == mimeType)
                {
                    return encoder;
                }
            }
            return null;
        }

        private void button9_Click_4(object sender, EventArgs e)
        {




        }

        private void button9_Click_5(object sender, EventArgs e)
        {

        }

        private void button10_Click_2(object sender, EventArgs e)
        {

        }

        private void button9_Click_6(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Vuoi attivare la versione web?", "Alert", MessageBoxButtons.YesNo);


            if (result == DialogResult.Yes)
            {
                timer4.Start();
                System.Diagnostics.Process.Start("http://localhost:8080/");

            }
            else if (result == DialogResult.No)
            {
                timer4.Stop();
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Stai chiudendo CelebrationBot se non hai salvato le domande andranno perse vuoi procedere?", "Conferma Uscita", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                // Annulla la chiusura dell'applicazione
                e.Cancel = true;
            }
            if (result == DialogResult.Yes)
            {
                Process currentProcess = Process.GetCurrentProcess();


                string processName = currentProcess.ProcessName;
                Process[] processes = Process.GetProcessesByName(processName);

                foreach (Process process in processes)
                {
                    process.Kill();
                }
            }

         




        }

        private void timer5_Tick(object sender, EventArgs e)
        {



        }

        private void textBox22_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button10_Click_3(object sender, EventArgs e)
        {
            // Creazione di un'istanza del controllo OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Impostazione delle proprietà del dialogo file
            openFileDialog.Title = "Seleziona un file audio";
            openFileDialog.Filter = "File audio (*.wav, *.mp3)|*.wav;*.mp3";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Ottiene il percorso del file audio selezionato
                string audioFilePath = openFileDialog.FileName;

                // Creazione di un'istanza della classe SoundPlayer
                SoundPlayer player = new SoundPlayer(audioFilePath);

                try
                {
                    // Riproduzione dell'audio
                    player.Play();


                    textBox22.Text = audioFilePath;


                    // Attende la fine della riproduzione dell'audio
                    while (player.IsLoadCompleted == false) ;

                    // L'audio ha finito di riprodursi
                    Console.WriteLine("Riproduzione audio completata.");
                }
                catch (Exception ex)
                {
                    // Si è verificato un errore durante la riproduzione dell'audio
                    Console.WriteLine("Si è verificato un errore durante la riproduzione dell'audio: " + ex.Message);
                }
                finally
                {
                    // Rilascia le risorse utilizzate dalla classe SoundPlayer
                    player.Dispose();
                }
            }
            else
            {
                // Nessun file audio selezionato
                Console.WriteLine("Nessun file audio selezionato.");
            }















        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (textBox22.Text == "")
            {

            }
            else
            {
                SoundPlayer player = new SoundPlayer(textBox22.Text);
                player.Stop();
            }





        }

        private void label1_TextChanged(object sender, EventArgs e)
        {









        }

        private void button12_Click(object sender, EventArgs e)
        {






            textBox22.Text = "";
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Ottieni il colore selezionato
                Color selectedColor = colorDialog.Color;

                // Imposta lo sfondo del form
                this.BackColor = selectedColor;

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click_1(object sender, EventArgs e)
        {




        }

        private void timer5_Tick_1(object sender, EventArgs e)
        {




        }

        private void button14_Click_2(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click_3(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button14_Click_4(object sender, EventArgs e)
        {
            string folderPath = "profili/" + comboBox1.Text; // Replace this with the path to your folder

            if (Directory.Exists(folderPath))
            {
                try
                {
                    Directory.Delete(folderPath, true); // The 'true' parameter means to delete the folder recursively, including all files and subdirectories.
                    Console.WriteLine("Folder deleted successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error deleting folder: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("The folder does not exist.");
            }
            Close();














        }

        private void check1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click_1(object sender, EventArgs e)
        {

        }
        int intero = 0;
        string xa = "";
        string MyUser = "";
        string uno = "";

        private async void MetodoPerLeggereChatAsync()
        {
            TwitchChatHandle chat = new TwitchChatHandle(oauth, Twitch_User.Text);
            // Avvia il metodo chat.Read() in un nuovo thread e attendi il risultato
            var chatEntry = await Task.Run(() => chat.Read());

            MyUser = chatEntry.sender;
            
       
                xa = chatEntry.message;



        }


    











        string variabile = "";
        private bool button1Clicked = false;
        private void timer5_Tick_2(object sender, EventArgs e)
        {

            Thread thread = new Thread(new ThreadStart(MetodoPerLeggereChatAsync));

            thread.Start();
           
           

            if (xa.Contains("!start"))
            {
                
                if(Twitch_User.Text==MyUser)
                {
                   
                        button1.PerformClick();
                    


              

                }

            }

            if (xa.Contains("!profilo"))
            {

                if (Twitch_User.Text == MyUser)
                {
                    xa = xa.Replace("!profilo", "").Trim();
                    comboBox1.Text = xa;
                    button8.PerformClick();

                }

            }

            if (xa.Contains("!personalizzata"))
            {

                if (Twitch_User.Text == MyUser)
                {
                    xa = xa.Replace("!personalizzata", "").Trim();
                   textBox21.Text = xa;
                    button4.PerformClick();

                }

            }







            if (xa.Contains("!domanda"))
            {
              
                xa = xa.Replace("!domanda", ""); 
                if (Domanda1.Text == "Domanda numero 1")
                {
                    Domanda1.Text = xa;

                }
                else
                {
                    if (Domanda2.Text == "Domanda numero 2")
                    {
                        Domanda2.Text = xa;
                    }
                    else
                    {
                        if (Domanda3.Text == "Domanda numero 3")
                        {
                            Domanda3.Text = xa;
                        }
                        else
                        {
                            if (Domanda4.Text == "Domanda numero 4")
                            {
                                Domanda4.Text = xa;
                            }
                            else
                            {
                                if (Domanda5.Text == "Domanda numero 5")
                                {
                                    Domanda5.Text = xa;
                                }
                                else
                                {
                                    if (Domanda6.Text == "Domanda numero 6")
                                    {
                                        Domanda6.Text = xa;
                                    }
                                    else
                                    {
                                        if (Domanda7.Text == "Domanda numero 7")
                                        {
                                            Domanda7.Text = xa;
                                        }
                                        else
                                        {
                                            if (Domanda8.Text == "Domanda numero 8")
                                            {
                                                Domanda8.Text = xa;
                                            }
                                            else
                                            {
                                                if (Domanda9.Text == "Domanda numero 9")
                                                {
                                                    Domanda9.Text = xa;
                                                }
                                                else
                                                {
                                                    if (Domanda10.Text == "Domanda numero 10")
                                                    {
                                                        Domanda10.Text = xa;
                                                    }
                                                    else
                                                    {
                                                        if (Domanda11.Text == "Domanda numero 11")
                                                        {
                                                            Domanda11.Text = xa;
                                                        }
                                                        else
                                                        {
                                                            if (Domanda12.Text == "Domanda numero 12")
                                                            {
                                                                Domanda12.Text = xa;
                                                            }
                                                            else
                                                            {
                                                                if (Domanda13.Text == "Domanda numero 13")
                                                                {
                                                                    Domanda13.Text = xa;
                                                                }
                                                                else
                                                                {
                                                                    if (Domanda14.Text == "Domanda numero 14")
                                                                    {
                                                                        Domanda14.Text = xa;
                                                                    }
                                                                    else
                                                                    {
                                                                        if (Domanda15.Text == "Domanda numero 15")
                                                                        {
                                                                            Domanda15.Text = xa;
                                                                        }
                                                                        else
                                                                        {
                                                                            if (Domanda16.Text == "Domanda numero 16")
                                                                            {
                                                                                Domanda16.Text = xa;
                                                                            }
                                                                            else
                                                                            {
                                                                                if (Domanda17.Text == "Domanda numero 17")
                                                                                {
                                                                                    Domanda17.Text = xa;
                                                                                }
                                                                                else
                                                                                {
                                                                                    if (Domanda18.Text == "Domanda numero 18")
                                                                                    {
                                                                                        Domanda18.Text = xa;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        if (Domanda19.Text == "Domanda numero 19")
                                                                                        {
                                                                                            Domanda19.Text = xa;
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            if (Domanda20.Text == "Domanda numero 20")
                                                                                            {
                                                                                                Domanda20.Text = xa;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                if (Domanda21.Text == "Domanda numero 21")
                                                                                                {
                                                                                                    Domanda21.Text = xa;
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    if (Domanda22.Text == "Domanda numero 22")
                                                                                                    {
                                                                                                        Domanda22.Text = xa;
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        if (Domanda23.Text == "Domanda numero 23")
                                                                                                        {
                                                                                                            Domanda23.Text = xa;
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            if (Domanda24.Text == "Domanda numero 24")
                                                                                                            {
                                                                                                                Domanda24.Text = xa;
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                if (Domanda25.Text == "Domanda numero 25")
                                                                                                                {
                                                                                                                    Domanda25.Text = xa;
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    if (Domanda26.Text == "Domanda numero 26")
                                                                                                                    {
                                                                                                                        Domanda26.Text = xa;
                                                                                                                    }
                                                                                                                    else
                                                                                                                    {
                                                                                                                        if (Domanda27.Text == "Domanda numero 27")
                                                                                                                        {
                                                                                                                            Domanda27.Text = xa;
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            if (Domanda28.Text == "Domanda numero 28")
                                                                                                                            {
                                                                                                                                Domanda28.Text = xa;
                                                                                                                            }
                                                                                                                            else
                                                                                                                            {
                                                                                                                                if (Domanda29.Text == "Domanda numero 29")
                                                                                                                                {
                                                                                                                                    Domanda29.Text = xa;
                                                                                                                                }
                                                                                                                                else
                                                                                                                                {
                                                                                                                                    if (Domanda30.Text == "Domanda numero 30")
                                                                                                                                    {
                                                                                                                                        Domanda30.Text = xa;
                                                                                                                                    }
                                                                                                                                    else
                                                                                                                                    {
                                                                                                                                        if (Domanda31.Text == "Domanda numero 31")
                                                                                                                                        {
                                                                                                                                            Domanda31.Text = xa;
                                                                                                                                        }
                                                                                                                                        else
                                                                                                                                        {

                                                                                                                                            if (Domanda32.Text == "Domanda numero 32")
                                                                                                                                            {
                                                                                                                                                Domanda32.Text = xa;
                                                                                                                                            }
                                                                                                                                            else
                                                                                                                                            {
                                                                                                                                                if (Domanda33.Text == "Domanda numero 33")
                                                                                                                                                {
                                                                                                                                                    Domanda33.Text = xa;
                                                                                                                                                }
                                                                                                                                                else
                                                                                                                                                {
                                                                                                                                                    if (Domanda34.Text == "Domanda numero 34")
                                                                                                                                                    {
                                                                                                                                                        Domanda34.Text = xa;
                                                                                                                                                    }
                                                                                                                                                    else
                                                                                                                                                    {
                                                                                                                                                        if (Domanda35.Text == "Domanda numero 35")
                                                                                                                                                        {
                                                                                                                                                            Domanda35.Text = xa;
                                                                                                                                                        }
                                                                                                                                                        else
                                                                                                                                                        {
                                                                                                                                                            if (Domanda36.Text == "Domanda numero 36")
                                                                                                                                                            {
                                                                                                                                                                Domanda36.Text = xa;
                                                                                                                                                            }
                                                                                                                                                            else
                                                                                                                                                            {

                                                                                                                                                                if (Domanda37.Text == "Domanda numero 37")
                                                                                                                                                                {
                                                                                                                                                                    Domanda37.Text = xa;
                                                                                                                                                                }
                                                                                                                                                                else
                                                                                                                                                                {
                                                                                                                                                                    if (Domanda38.Text == "Domanda numero 38")
                                                                                                                                                                    {
                                                                                                                                                                        Domanda38.Text = xa;
                                                                                                                                                                    }
                                                                                                                                                                    else
                                                                                                                                                                    {

                                                                                                                                                                        if (Domanda39.Text == "Domanda numero 39")
                                                                                                                                                                        {
                                                                                                                                                                            Domanda39.Text = xa;
                                                                                                                                                                        }
                                                                                                                                                                        else
                                                                                                                                                                        {
                                                                                                                                                                            if (Domanda40.Text == "Domanda numero 40")
                                                                                                                                                                            {
                                                                                                                                                                                Domanda40.Text = xa;
                                                                                                                                                                            }
                                                                                                                                                                            else
                                                                                                                                                                            {

                                                                                                                                                                            }
                                                                                                                                                                        }
                                                                                                                                                                    }
                                                                                                                                                                }
                                                                                                                                                            }
                                                                                                                                                        }
                                                                                                                                                    }

                                                                                                                                                }
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                }
                                                                                                                            }
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }


                                                                                        }
                                                                                    }


                                                                                }
                                                                            }


                                                                        }
                                                                    }


                                                                }
                                                            }


                                                        }
                                                    }


                                                }
                                            }


                                        }

                                    }


                                }
                            }


                        }
                    }


                }
            }
            xa = "";

        }

        private void button15_Click_2(object sender, EventArgs e)
        {

        }

        private void button15_Click_3(object sender, EventArgs e)
        {
            string oauth = "oauth:8nat9vw03g9eecmv7wjsds11nixxxo";
            string channelName = Twitch_User.Text; // Leggi il nome del canale dall'input dell'utente

            if (!string.IsNullOrWhiteSpace(channelName))
            {
                TwitchChatHandle chat = new TwitchChatHandle(oauth, channelName);

                // Ora puoi utilizzare 'chat' con il nome del canale inserito dall'utente.
            }
            else
            {
                MessageBox.Show("Inserisci un nome di canale valido.");
            }
        }

        private void textBox1_TextChanged_4(object sender, EventArgs e)
        {

        }

        private void Twitch_User_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            uno = xa;
        }
    }

}

