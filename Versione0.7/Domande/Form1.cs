using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Net.Http;
using System.Diagnostics;
using System.Net;
using System.Drawing.Imaging;

namespace Domande
{
    public partial class Form1 : Form
    {
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
           
        }
        int number;

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Stop();

            if(checkBox21.Checked==true)
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
            for (int i = 0; i < 20; i++)
            {

               

                    



                
                number = generator.Next(1, 21);
                if (number == 1)
                {
                  
                        label1.Text = "1- "+textBox1.Text.ToString();
                   


                }
                
                if (number == 2)
                {

                    label1.Text = "2- "+textBox2.Text.ToString();



                }
                if (number == 3)
                {

                    label1.Text = "3- "+textBox3.Text.ToString();


                }
                if (number == 4)
                {

                    label1.Text = "4- "+textBox4.Text.ToString();


                }
                if (number == 5)
                {

                    label1.Text = "5- "+textBox5.Text.ToString();


                }

                if (number == 6)
                {

                    label1.Text = "6- " + textBox6.Text.ToString();


                }

                if (number == 7)
                {

                    label1.Text = "7- " + textBox7.Text.ToString();


                }
                if (number == 8)
                {

                    label1.Text = "8- " + textBox8.Text.ToString();


                }
                if (number == 9)
                {

                    label1.Text = "9- " + textBox9.Text.ToString();


                }
                if (number == 10)
                {

                    label1.Text = "10- " + textBox10.Text.ToString();


                }

                if (number == 11)
                {

                    label1.Text = "11- " + textBox11.Text.ToString();


                }
                if (number == 12)
                {

                    label1.Text = "12- " + textBox12.Text.ToString();


                }
                if (number == 13)
                {

                    label1.Text = "13- " + textBox13.Text.ToString();


                }
                if (number == 14)
                {

                    label1.Text = "14- " + textBox14.Text.ToString();


                }
                if (number == 15)
                {

                    label1.Text = "15- " + textBox15.Text.ToString();


                }
                if (number == 16)
                {

                    label1.Text = "16- " + textBox16.Text.ToString();


                }
                if (number == 17)
                {

                    label1.Text = "17- " + textBox17.Text.ToString();


                }
                if (number == 18)
                {

                    label1.Text = "18- " + textBox18.Text.ToString();


                }
                if (number == 19)
                {

                    label1.Text = "19- " + textBox19.Text.ToString();


                }
                if (number == 20)
                {

                    label1.Text = "20- " + textBox20.Text.ToString();


                }
                























            
            Console.Read();
            if (number == 1)
            {
                if (checkBox1.Checked == false)
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
                if (checkBox2.Checked == false)
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
                if (checkBox3.Checked == false)
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
                if (checkBox4.Checked == false)
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
                if (checkBox5.Checked == false)
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
                if (checkBox6.Checked == false)
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
                if (checkBox7.Checked == false)
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
                if (checkBox8.Checked == false)
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
                if (checkBox9.Checked == false)
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
                if (checkBox10.Checked == false)
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
                if (checkBox11.Checked == false)
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
                if (checkBox12.Checked == false)
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
                if (checkBox13.Checked == false)
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
                if (checkBox14.Checked == false)
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
                if (checkBox15.Checked == false)
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
                if (checkBox16.Checked == false)
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
                if (checkBox17.Checked == false)
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
                if (checkBox18.Checked == false)
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
                if (checkBox19.Checked == false)
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
                if (checkBox20.Checked == false)
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
                    HttpListenerContext context = listener.GetContext();
                    HttpListenerRequest request = context.Request;
                    HttpListenerResponse response2 = context.Response;

                    
                    byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);

                    response2.ContentLength64 = buffer.Length;
                    response2.OutputStream.Write(buffer, 0, buffer.Length);
                    response2.OutputStream.Close();
                }
            });

            serverThread.Start();





            string nomeTipoCarattere = Properties.Settings.Default.FontTipo;
            string PX = Properties.Settings.Default.FontPX;
            string colorePersonalizzato = Properties.Settings.Default.FontColor;
            string risposta = Properties.Settings.Default.Risposta;
            int posizioneInt = Convert.ToInt32(risposta);
            trackBar1.Value = posizioneInt;
            string posizione = Properties.Settings.Default.Posizione;
            int posizioneInt2 = Convert.ToInt32(posizione);
            trackBar3.Value = posizioneInt2;
            string[] valoriRGB = colorePersonalizzato.Split(',');
            int r = int.Parse(valoriRGB[0]);
            int g = int.Parse(valoriRGB[1]);
            int b = int.Parse(valoriRGB[2]);
            Color colore = Color.FromArgb(r, g, b);
            label1.ForeColor = colore;
            int dimensioneFont;

            if (int.TryParse(PX, out dimensioneFont))
            {
                label1.Font = new Font(nomeTipoCarattere, dimensioneFont);
            }
            timer1.Interval = trackBar1.Value;
            label3.Text = timer1.Interval.ToString() + " MS";
            label1.SetBounds(label1.Location.X, 28 - trackBar3.Value, label1.Width, label1.Height);
            label6.Text = "Posizione font di: " + label1.Location.Y + " PX";


            var httpClient = new HttpClient();
            var url = "http://torrentexe.altervista.org/versione.txt"; // inserire qui l'URL del sito da controllare
            var response = await httpClient.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            aggiornamento = "NO";
            if (double.TryParse(content, out double value) && value > 3)
            {
                aggiornamento = "SI";
                var result = MessageBox.Show($"È disponibile una nuova versione. Desideri installarla?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Process.Start("https://github.com/RicordiTV/CelebrationBot");
                }
            }


            string imagePath = @"image.png";
            if (File.Exists(imagePath))
            {
              
            }
            else
            {
                Image image = pictureBox2.Image;

                if (image != null)
                {
                    // Salva l'immagine nel percorso specificato
                    string filePath= @"image.png";
                    image.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
                }

            }






            string filePath3 = "image.png";

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

            string NomeFile1 = @"1.txt";
            StreamReader FileTesto1;
            try
            {
                FileTesto1 = new StreamReader(NomeFile1);
                textBox1.Text = FileTesto1.ReadLine();
                FileTesto1.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile2 = @"2.txt";
            StreamReader FileTesto2;
            try
            {
                FileTesto2 = new StreamReader(NomeFile2);
                textBox2.Text = FileTesto2.ReadLine();
                FileTesto2.Close();

            }
            catch (FileNotFoundException)
            {

            }

            string NomeFile3 = @"3.txt";
            StreamReader FileTesto3;
            try
            {
                FileTesto3 = new StreamReader(NomeFile3);
                textBox3.Text = FileTesto3.ReadLine();
                FileTesto3.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile4 = @"4.txt";
            StreamReader FileTesto4;
            try
            {
                FileTesto4 = new StreamReader(NomeFile4);
                textBox4.Text = FileTesto4.ReadLine();
                FileTesto4.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile5 = @"5.txt";
            StreamReader FileTesto5;
            try
            {
                FileTesto5 = new StreamReader(NomeFile5);
                textBox5.Text = FileTesto5.ReadLine();
                FileTesto5.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile6 = @"6.txt";
            StreamReader FileTesto6;
            try
            {
                FileTesto6 = new StreamReader(NomeFile6);
                textBox6.Text = FileTesto6.ReadLine();
                FileTesto6.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile7 = @"7.txt";
            StreamReader FileTesto7;
            try
            {
                FileTesto7 = new StreamReader(NomeFile7);
                textBox7.Text = FileTesto7.ReadLine();
                FileTesto7.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile8 = @"8.txt";
            StreamReader FileTesto8;
            try
            {
                FileTesto8 = new StreamReader(NomeFile8);
                textBox8.Text = FileTesto8.ReadLine();
                FileTesto8.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile9 = @"9.txt";
            StreamReader FileTesto9;
            try
            {
                FileTesto9 = new StreamReader(NomeFile9);
                textBox9.Text = FileTesto9.ReadLine();
                FileTesto9.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile10 = @"10.txt";
            StreamReader FileTesto10;
            try
            {
                FileTesto10 = new StreamReader(NomeFile10);
                textBox10.Text = FileTesto10.ReadLine();
                FileTesto10.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile11 = @"11.txt";
            StreamReader FileTesto11;
            try
            {
                FileTesto11 = new StreamReader(NomeFile11);
                textBox11.Text = FileTesto11.ReadLine();
                FileTesto11.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile12 = @"12.txt";
            StreamReader FileTesto12;
            try
            {
                FileTesto12 = new StreamReader(NomeFile12);
                textBox12.Text = FileTesto12.ReadLine();
                FileTesto12.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile13 = @"13.txt";
            StreamReader FileTesto13;
            try
            {
                FileTesto13 = new StreamReader(NomeFile13);
                textBox13.Text = FileTesto13.ReadLine();
                FileTesto13.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile14 = @"14.txt";
            StreamReader FileTesto14;
            try
            {
                FileTesto14 = new StreamReader(NomeFile14);
                textBox14.Text = FileTesto14.ReadLine();
                FileTesto14.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile15 = @"15.txt";
            StreamReader FileTesto15;
            try
            {
                FileTesto15 = new StreamReader(NomeFile15);
                textBox15.Text = FileTesto15.ReadLine();
                FileTesto15.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile16 = @"16.txt";
            StreamReader FileTesto16;
            try
            {
                FileTesto16 = new StreamReader(NomeFile16);
                textBox16.Text = FileTesto16.ReadLine();
                FileTesto16.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile17 = @"17.txt";
            StreamReader FileTesto17;
            try
            {
                FileTesto17 = new StreamReader(NomeFile17);
                textBox17.Text = FileTesto17.ReadLine();
                FileTesto17.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile18 = @"18.txt";
            StreamReader FileTesto18;
            try
            {
                FileTesto18 = new StreamReader(NomeFile18);
                textBox18.Text = FileTesto18.ReadLine();
                FileTesto18.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile19 = @"19.txt";
            StreamReader FileTesto19;
            try
            {
                FileTesto19 = new StreamReader(NomeFile19);
                textBox19.Text = FileTesto19.ReadLine();
                FileTesto19.Close();

            }
            catch (FileNotFoundException)
            {

            }
            string NomeFile20 = @"20.txt";
            StreamReader FileTesto20;
            try
            {
                FileTesto20 = new StreamReader(NomeFile20);
                textBox20.Text = FileTesto20.ReadLine();
                FileTesto20.Close();

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
     
        private void pictureBox4_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)
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
            if(avvio==1)
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
            if(fd.ShowDialog()==DialogResult.OK)
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
               
                Properties.Settings.Default.FontTipo = label1.Font.Name;
                Properties.Settings.Default.FontPX = Math.Round(label1.Font.Size, MidpointRounding.AwayFromZero).ToString();
                Color colore = label1.ForeColor;
                string coloreRGB = $"{colore.R},{colore.G},{colore.B}";
                Properties.Settings.Default.FontColor = coloreRGB;
                Properties.Settings.Default.Risposta = trackBar1.Value.ToString();
                Properties.Settings.Default.Posizione = trackBar3.Value.ToString();
                Properties.Settings.Default.Save();
                


                string text1 = @"1.txt";
                StreamWriter streamWriter1 = new StreamWriter(text1, false);
                streamWriter1.WriteLine(textBox1.Text.ToString());
                streamWriter1.Close();

                string text2 = @"2.txt";
                StreamWriter streamWriter2 = new StreamWriter(text2, false);
                streamWriter2.WriteLine(textBox2.Text.ToString());
                streamWriter2.Close();

                string text3 = @"3.txt";
                StreamWriter streamWriter3 = new StreamWriter(text3, false);
                streamWriter3.WriteLine(textBox3.Text.ToString());
                streamWriter3.Close();

                string text4 = @"4.txt";
                StreamWriter streamWriter4 = new StreamWriter(text4, false);
                streamWriter4.WriteLine(textBox4.Text.ToString());
                streamWriter4.Close();

                string text5 = @"5.txt";
                StreamWriter streamWriter5 = new StreamWriter(text5, false);
                streamWriter5.WriteLine(textBox5.Text.ToString());
                streamWriter5.Close();

                string text6 = @"6.txt";
                StreamWriter streamWriter6 = new StreamWriter(text6, false);
                streamWriter6.WriteLine(textBox6.Text.ToString());
                streamWriter6.Close();

                string text7 = @"7.txt";
                StreamWriter streamWriter7 = new StreamWriter(text7, false);
                streamWriter7.WriteLine(textBox7.Text.ToString());
                streamWriter7.Close();

                string text8 = @"8.txt";
                StreamWriter streamWriter8 = new StreamWriter(text8, false);
                streamWriter8.WriteLine(textBox8.Text.ToString());
                streamWriter8.Close();

                string text9 = @"9.txt";
                StreamWriter streamWriter9 = new StreamWriter(text9, false);
                streamWriter9.WriteLine(textBox9.Text.ToString());
                streamWriter9.Close();

                string text10 = @"10.txt";
                StreamWriter streamWriter10 = new StreamWriter(text10, false);
                streamWriter10.WriteLine(textBox10.Text.ToString());
                streamWriter10.Close();

                string text11 = @"11.txt";
                StreamWriter streamWriter11 = new StreamWriter(text11, false);
                streamWriter11.WriteLine(textBox11.Text.ToString());
                streamWriter11.Close();

                string text12 = @"12.txt";
                StreamWriter streamWriter12 = new StreamWriter(text12, false);
                streamWriter12.WriteLine(textBox12.Text.ToString());
                streamWriter12.Close();

                string text13 = @"13.txt";
                StreamWriter streamWriter13 = new StreamWriter(text13, false);
                streamWriter13.WriteLine(textBox13.Text.ToString());
                streamWriter13.Close();

                string text14 = @"14.txt";
                StreamWriter streamWriter14 = new StreamWriter(text14, false);
                streamWriter14.WriteLine(textBox14.Text.ToString());
                streamWriter14.Close();

                string text15 = @"15.txt";
                StreamWriter streamWriter15 = new StreamWriter(text15, false);
                streamWriter15.WriteLine(textBox15.Text.ToString());
                streamWriter15.Close();

                string text16 = @"16.txt";
                StreamWriter streamWriter16 = new StreamWriter(text16, false);
                streamWriter16.WriteLine(textBox16.Text.ToString());
                streamWriter16.Close();

                string text17 = @"17.txt";
                StreamWriter streamWriter17 = new StreamWriter(text17, false);
                streamWriter17.WriteLine(textBox17.Text.ToString());
                streamWriter17.Close();

                string text18 = @"18.txt";
                StreamWriter streamWriter18 = new StreamWriter(text18, false);
                streamWriter18.WriteLine(textBox18.Text.ToString());
                streamWriter18.Close();

                string text19 = @"19.txt";
                StreamWriter streamWriter19 = new StreamWriter(text19, false);
                streamWriter19.WriteLine(textBox19.Text.ToString());
                streamWriter19.Close();

                string text20 = @"20.txt";
                StreamWriter streamWriter20 = new StreamWriter(text20, false);
                streamWriter20.WriteLine(textBox20.Text.ToString());
                streamWriter20.Close();
              
            }
            else if (result == DialogResult.No)
            {

            }
            Image image = pictureBox2.Image;

            if (image != null)
            {
                // Salva l'immagine nel percorso specificato
                string filePath = @"image.png";
                image.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
            }


        }

        private void textBox1_TextChanged_3(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Vuoi davvero resettare le impostazioni originali?", "Alert", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
               

                Properties.Settings.Default.FontTipo = "Segoe Print";
                Properties.Settings.Default.FontPX = "15";
                label1.ForeColor = Color.Purple;
                Color colore = label1.ForeColor;
                string coloreRGB = $"{colore.R},{colore.G},{colore.B}";
                Properties.Settings.Default.FontColor = coloreRGB;
                Properties.Settings.Default.Risposta = "100";
                Properties.Settings.Default.Posizione = "5";
                Properties.Settings.Default.Save();



                string text1 = @"1.txt";
                StreamWriter streamWriter1 = new StreamWriter(text1, false);
                streamWriter1.WriteLine("Domanda numero 1");
                streamWriter1.Close();

                string text2 = @"2.txt";
                StreamWriter streamWriter2 = new StreamWriter(text2, false);
                streamWriter2.WriteLine("Domanda numero 2");
                streamWriter2.Close();

                string text3 = @"3.txt";
                StreamWriter streamWriter3 = new StreamWriter(text3, false);
                streamWriter3.WriteLine("Domanda numero 3");
                streamWriter3.Close();

                string text4 = @"4.txt";
                StreamWriter streamWriter4 = new StreamWriter(text4, false);
                streamWriter4.WriteLine("Domanda numero 4");
                streamWriter4.Close();

                string text5 = @"5.txt";
                StreamWriter streamWriter5 = new StreamWriter(text5, false);
                streamWriter5.WriteLine("Domanda numero 5");
                streamWriter5.Close();

                string text6 = @"6.txt";
                StreamWriter streamWriter6 = new StreamWriter(text6, false);
                streamWriter6.WriteLine("Domanda numero 6");
                streamWriter6.Close();

                string text7 = @"7.txt";
                StreamWriter streamWriter7 = new StreamWriter(text7, false);
                streamWriter7.WriteLine("Domanda numero 7");
                streamWriter7.Close();

                string text8 = @"8.txt";
                StreamWriter streamWriter8 = new StreamWriter(text8, false);
                streamWriter8.WriteLine("Domanda numero 8");
                streamWriter8.Close();

                string text9 = @"9.txt";
                StreamWriter streamWriter9 = new StreamWriter(text9, false);
                streamWriter9.WriteLine("Domanda numero 9");
                streamWriter9.Close();

                string text10 = @"10.txt";
                StreamWriter streamWriter10 = new StreamWriter(text10, false);
                streamWriter10.WriteLine("Domanda numero 10");
                streamWriter10.Close();

                string text11 = @"11.txt";
                StreamWriter streamWriter11 = new StreamWriter(text11, false);
                streamWriter11.WriteLine("Domanda numero 11");
                streamWriter11.Close();

                string text12 = @"12.txt";
                StreamWriter streamWriter12 = new StreamWriter(text12, false);
                streamWriter12.WriteLine("Domanda numero 12");
                streamWriter12.Close();

                string text13 = @"13.txt";
                StreamWriter streamWriter13 = new StreamWriter(text13, false);
                streamWriter13.WriteLine("Domanda numero 13");
                streamWriter13.Close();

                string text14 = @"14.txt";
                StreamWriter streamWriter14 = new StreamWriter(text14, false);
                streamWriter14.WriteLine("Domanda numero 14");
                streamWriter14.Close();

                string text15 = @"15.txt";
                StreamWriter streamWriter15 = new StreamWriter(text15, false);
                streamWriter15.WriteLine("Domanda numero 15");
                streamWriter15.Close();

                string text16 = @"16.txt";
                StreamWriter streamWriter16 = new StreamWriter(text16, false);
                streamWriter16.WriteLine("Domanda numero 16");
                streamWriter16.Close();

                string text17 = @"17.txt";
                StreamWriter streamWriter17 = new StreamWriter(text17, false);
                streamWriter17.WriteLine("Domanda numero 17");
                streamWriter17.Close();

                string text18 = @"18.txt";
                StreamWriter streamWriter18 = new StreamWriter(text18, false);
                streamWriter18.WriteLine("Domanda numero 18");
                streamWriter18.Close();

                string text19 = @"19.txt";
                StreamWriter streamWriter19 = new StreamWriter(text19, false);
                streamWriter19.WriteLine("Domanda numero 19");
                streamWriter19.Close();

                string text20 = @"20.txt";
                StreamWriter streamWriter20 = new StreamWriter(text20, false);
                streamWriter20.WriteLine("Domanda numero 20");
                streamWriter20.Close();
                string imagePath = @"image.png";
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
        int zero =1;

        private void timer3_Tick(object sender, EventArgs e)
        {
            zero = zero + 1;
            Random generator = new Random();
            for (int i = 0; i < 20; i++)
            {



                number = generator.Next(1, 21);
                if (number == 1)
                {

                    label1.Text = "1- " + textBox1.Text.ToString();



                }

                if (number == 2)
                {

                    label1.Text = "2- " + textBox2.Text.ToString();



                }
                if (number == 3)
                {

                    label1.Text = "3- " + textBox3.Text.ToString();


                }
                if (number == 4)
                {

                    label1.Text = "4- " + textBox4.Text.ToString();


                }
                if (number == 5)
                {

                    label1.Text = "5- " + textBox5.Text.ToString();


                }

                if (number == 6)
                {

                    label1.Text = "6- " + textBox6.Text.ToString();


                }

                if (number == 7)
                {

                    label1.Text = "7- " + textBox7.Text.ToString();


                }
                if (number == 8)
                {

                    label1.Text = "8- " + textBox8.Text.ToString();


                }
                if (number == 9)
                {

                    label1.Text = "9- " + textBox9.Text.ToString();


                }
                if (number == 10)
                {

                    label1.Text = "10- " + textBox10.Text.ToString();


                }

                if (number == 11)
                {

                    label1.Text = "11- " + textBox11.Text.ToString();


                }
                if (number == 12)
                {

                    label1.Text = "12- " + textBox12.Text.ToString();


                }
                if (number == 13)
                {

                    label1.Text = "13- " + textBox13.Text.ToString();


                }
                if (number == 14)
                {

                    label1.Text = "14- " + textBox14.Text.ToString();


                }
                if (number == 15)
                {

                    label1.Text = "15- " + textBox15.Text.ToString();


                }
                if (number == 16)
                {

                    label1.Text = "16- " + textBox16.Text.ToString();


                }
                if (number == 17)
                {

                    label1.Text = "17- " + textBox17.Text.ToString();


                }
                if (number == 18)
                {

                    label1.Text = "18- " + textBox18.Text.ToString();


                }
                if (number == 19)
                {

                    label1.Text = "19- " + textBox19.Text.ToString();


                }
                if (number == 20)
                {

                    label1.Text = "20- " + textBox20.Text.ToString();


                }
























            }
            Console.Read();
            if (zero==1000)
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
        string versione = "0.7";
        private void label5_Click_1(object sender, EventArgs e)
        {
            Process currentProcess = Process.GetCurrentProcess();

            // Ottiene il nome del processo corrente
            string processName = currentProcess.ProcessName;
            string filePath = processName+".exe"; // Inserisci il percorso del file qui

            FileInfo fileInfo = new FileInfo(filePath);
            long fileSizeInBytes = fileInfo.Length;

            // Converti il peso del file da byte ad altre unità di misura
            double fileSizeInKb = fileSizeInBytes;
            
            if(fileSizeInBytes== 478208)
            {
                convalidato = "SI";
            }else{
                convalidato = "NO";
            }
            string modifica = @"Domande.exe"; // Il percorso del file da controllare
            DateTime lastModified = File.GetLastWriteTime(modifica);
            string lastModifiedDate = lastModified.ToString("dd/MM/yyyy HH:mm:ss"); 

            string text1 = @"chat.html";
            StreamWriter streamWriter1 = new StreamWriter(text1, false);
            streamWriter1.WriteLine("Informazioni utili<br>Versione: "+versione.ToString()+"<br>File integro: "+convalidato.ToString()+"<br>Nuova versione disponibile: "+aggiornamento.ToString()+"<br>Ultimo aggiornamento: "+ lastModifiedDate.ToString()+ "<script>\r\n    (function(d, w, c) {\r\n        w.ChatraID = 'yZWbBFXX2nghPQFfX';\r\n        var s = d.createElement('script');\r\n        w[c] = w[c] || function() {\r\n            (w[c].q = w[c].q || []).push(arguments);\r\n        };\r\n        s.async = true;\r\n        s.src = 'https://call.chatra.io/chatra.js';\r\n        if (d.head) d.head.appendChild(s);\r\n    })(document, window, 'Chatra');\r\n</script>");
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
            if(comboBox1.Text=="HarryPotter")
            {
                
                string fileUrl = "http://torrentexe.altervista.org/Harry%20Potter.png";
               

              

                using (WebClient client = new WebClient())
                {
                    // Verifica se il file è scaricabile
                    try
                    {
                        client.OpenRead(fileUrl);
                    }
                    catch (WebException ex)
                    {
                        Console.WriteLine(ex.Message);
                        return;
                    }

                    // Download del file
                    string fileDest = @"image-download.png";
                    client.DownloadFile(fileUrl, fileDest);
                    button8.Visible = false;
                    comboBox1.Visible = false;

                }

                byte[] fileBytes = File.ReadAllBytes("image-download.png"); // Leggi il contenuto del file
                using (MemoryStream ms = new MemoryStream(fileBytes)) // Crea un MemoryStream dal contenuto del file
                {
                    pictureBox2.Image = Image.FromStream(ms); // Imposta l'immagine della PictureBox dal MemoryStream
                }


                label1.Font = new Font("Palatino Linotype", 15, FontStyle.Bold);
                label1.ForeColor = Color.White;
                textBox1.Text = "Qual è il titolo del primo libro della serie di Harry Potter?";
                textBox2.Text = "In quale casa di Hogwarts viene selezionato Harry Potter?";
                textBox3.Text = "Quali sono i nomi dei migliori amici di Harry a Hogwarts?";
                textBox4.Text = "Qual è la razza di Dobby, il piccolo elfo domestico che appare nei libri di Harry Potter?";
                textBox5.Text = "Qual è il nome del direttore di Hogwarts nel primo libro della serie?";
                textBox6.Text = "Quale è la materia preferita di Hermione a Hogwarts?";
                textBox7.Text = "Qual è la bacchetta magica di Harry Potter?";
                textBox8.Text = "Quale è il nome del gioco di magia giocato su una scopa volante?";
                textBox9.Text = "Qual è il nome della scuola di magia rivali di Hogwarts?";
                textBox10.Text = "Qual è il nome del malvagio stregone che è l'antagonista principale della serie di Harry Potter?";
                textBox11.Text = "Quale è la data di nascita di Harry Potter?";
                textBox12.Text = "Qual è il patronus di Hermione Granger?";
                textBox13.Text = "Qual è la forma animale dell'insegnante di Hogwarts, Remus Lupin, quando si trasforma in licantropo?";
                textBox14.Text = "Qual è il nome della squadra di Quidditch di Hogwarts a cui appartiene Harry Potter?";
                textBox15.Text = "Quale è il nome dell'infermiera di Hogwarts?";
                textBox16.Text = "Quale è il nome del fantasma che infesta la toilette femminile del secondo piano di Hogwarts?";
                textBox17.Text = "Qual è il nome del giovane mago che ha tradito i genitori di Harry Potter?";
                textBox18.Text = "Qual è il nome della persona che ha tenuto in ostaggio gli elfi domestici di Hogwarts nel sesto libro?";
                textBox19.Text = "Qual è il cognome della famiglia di Ron Weasley?";
                textBox20.Text = "Qual è il nome dell'elfo domestico di Hogwarts che aiuta Harry Potter e i suoi amici?";
                trackBar3.Value = 0;
                trackBar3.Value = trackBar3.Value + 1;
                trackBar3.Value = trackBar3.Value + 1;
                trackBar3.Value = trackBar3.Value + 1;
                trackBar3.Value = trackBar3.Value + 1;
                label6.Text="Posizione font di: 25 PX";
                label1.SetBounds(label1.Location.X, 28 - trackBar3.Value, label1.Width, label1.Height);

            }

            if (comboBox1.Text == "StarWars")
            {
                string fileUrl = "http://torrentexe.altervista.org/Star%20Wars.png";
                using (WebClient client = new WebClient())
                {
                    // Verifica se il file è scaricabile
                    try
                    {
                        client.OpenRead(fileUrl);
                    }
                    catch (WebException ex)
                    {
                        Console.WriteLine(ex.Message);
                        return;
                    }

                    // Download del file
                    string fileDest = @"image-download.png";
                    client.DownloadFile(fileUrl, fileDest);
                    button8.Visible = false;
                    comboBox1.Visible = false;
                }
                byte[] fileBytes = File.ReadAllBytes("image-download.png"); // Leggi il contenuto del file
                using (MemoryStream ms = new MemoryStream(fileBytes)) // Crea un MemoryStream dal contenuto del file
                {
                    pictureBox2.Image = Image.FromStream(ms); // Imposta l'immagine della PictureBox dal MemoryStream
                }
                label1.Font = new Font("Impact", 14, FontStyle.Bold);
                label1.ForeColor = Color.White;
                textBox1.Text = "Chi ha diretto il film Star Wars: Episodio IV - Una nuova speranza?";
                textBox2.Text = "Qual è il nome dell'astronave di Han Solo?";
                textBox3.Text = "Qual è il nome del cacciatore di taglie che cerca di catturare Han Solo in L'Impero colpisce ancora?";
                textBox4.Text = "Qual è il nome dell'attore che interpreta il personaggio di Darth Vader nella trilogia originale di Star Wars?";
                textBox5.Text = "Qual è il nome del pianeta natale di Yoda?";
                textBox6.Text = "Qual è il nome della banda di fuorilegge di cui fa parte il personaggio di Han Solo?";
                textBox7.Text = "Quale personaggio di Star Wars è noto per indossare una maschera di metallo nero?";
                textBox8.Text = "Qual è il nome della base ribelle attaccata dalle forze imperiali in Rogue One: A Star Wars Story?";
                textBox9.Text = "Qual è il nome della specie a cui appartiene il personaggio di Jabba the Hutt?";
                textBox10.Text = "Qual è il nome del droide astromeccanico che accompagna R2-D2 nella trilogia originale di Star Wars?";
                textBox11.Text = "Qual è il nome del pianeta desertico in cui vive Luke Skywalker?";
                textBox12.Text = "Quale attore interpreta il personaggio di Kylo Ren nella trilogia sequel di Star Wars?";
                textBox13.Text = "Qual è il nome del personaggio interpretato da Felicity Jones in \"Rogue One: A Star Wars Story\"?";
                textBox14.Text = "Qual è il nome del pianeta natale di Darth Maul?";
                textBox15.Text = "Qual è il nome del pianeta in cui si trova la Cittadella Jedi?";
                textBox16.Text = "Quale personaggio di Star Wars è noto per avere tre occhi?";
                textBox17.Text = "Qual è il nome del personaggio interpretato da Diego Luna in \"Rogue One: A Star Wars Story\"?";
                textBox18.Text = "Qual è il nome del personaggio interpretato da Forest Whitaker in \"Rogue One: A Star Wars Story\"?";
                textBox19.Text = "Qual è il nome del pianeta in cui si svolge gran parte dell'azione del film \"Gli ultimi Jedi\"?";
                textBox20.Text = "Qual è il nome del personaggio interpretato da Donald Glover in \"Solo: A Star Wars Story\"?";
            }

            if (comboBox1.Text == "8bit")
            {
                string fileUrl = "http://torrentexe.altervista.org/8bit.png";
                using (WebClient client = new WebClient())
                {
                    // Verifica se il file è scaricabile
                    try
                    {
                        client.OpenRead(fileUrl);
                    }
                    catch (WebException ex)
                    {
                        Console.WriteLine(ex.Message);
                        return;
                    }

                    // Download del file
                    string fileDest = @"image-download.png";
                    client.DownloadFile(fileUrl, fileDest);
                    button8.Visible = false;
                    comboBox1.Visible = false;
                }
                byte[] fileBytes = File.ReadAllBytes("image-download.png"); // Leggi il contenuto del file
                using (MemoryStream ms = new MemoryStream(fileBytes)) // Crea un MemoryStream dal contenuto del file
                {
                    pictureBox2.Image = Image.FromStream(ms); // Imposta l'immagine della PictureBox dal MemoryStream
                }
                label1.Font = new Font("MS Gothic", 20, FontStyle.Bold);
                label1.ForeColor = Color.White;
                textBox1.Text = "Qual è la tua console retro preferita?";
                textBox2.Text = "Quale è il tuo gioco retro preferito?";
                textBox3.Text = "Quale è il gioco retro più difficile che hai mai giocato?";
                textBox4.Text = "Qual è il tuo personaggio retro preferito?";
                textBox5.Text = "Qual è la tua colonna sonora retro preferita?";
                textBox6.Text = "Qual è il tuo genere di gioco retro preferito?";
                textBox7.Text = "Quale è il tuo controller retro preferito?";
                textBox8.Text = "Qual è il tuo gioco retro meno preferito?";
                textBox9.Text = "Qual è la tua console retro meno preferita?";
                textBox10.Text = "Quale gioco retro ti ha fatto piangere?";
                textBox11.Text = "Qual è il tuo boss retro preferito?";
                textBox12.Text = "Qual è il tuo livello retro preferito?";
                textBox13.Text = "Qual è la tua arma retro preferita?";
                textBox14.Text = "Qual è il tuo power-up retro preferito?";
                textBox15.Text = "Qual è il tuo stile grafico retro preferito?";
                textBox16.Text = "Qual è il tuo gioco retro preferito a più giocatori?";
                textBox17.Text = "Quale è il tuo gioco retro preferito del genere puzzle?";
                textBox18.Text = "Qual è il tuo gioco retro preferito del genere platform?";
                textBox19.Text = "Quale gioco retro vorresti vedere un remake?";
                textBox20.Text = "Quale gioco retro vorresti vedere una continuazione?";
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
            label7.Text = "Attesa fake: " + trackBar2.Value ;
        }
        int attesa = 0;
        private void timer3_Tick_1(object sender, EventArgs e)
        {
            attesa = attesa + 1;
            timer3.Interval = trackBar2.Value;
            if(attesa==100)
            {
                timer1.Start();
                attesa = 0;
                timer3.Stop();
            }else
            {
                label1.Text = attesa.ToString()+"%";
            }
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox21.Checked==true)
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

        private void timer4_Tick_1(object sender, EventArgs e)
        {
            
              Bitmap bitmap = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            pictureBox2.DrawToBitmap(bitmap, new Rectangle(0, 0, pictureBox2.Width, pictureBox2.Height));
            bitmap.Save("image2.jpg" ,System.Drawing.Imaging.ImageFormat.Jpeg);
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
            System.Diagnostics.Process.Start("http://localhost:8080/");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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
    }

