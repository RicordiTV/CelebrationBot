using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Windows.Input;
using System.Threading;
using System.Diagnostics.Eventing.Reader;
using CelebrationBot.Properties;
using System.Net.Http;
using Microsoft.Win32;
using System.Timers;
using System.Security.Policy;
using System.Diagnostics;

namespace Domande
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
            
        }
        int number;

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            timer1.Start();
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
       
        private async void Form1_Load(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var url = "http://torrentexe.altervista.org/versione.txt"; // inserire qui l'URL del sito da controllare
            var response = await httpClient.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            aggiornamento = "NO";
            if (double.TryParse(content, out double value) && value > 1)
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
                    string filePath = @"image.png";
                    image.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
                }

            }






            string filePath2 = @"image.png";

            if (File.Exists(filePath2))
            {

                  Bitmap bitmap = new Bitmap("image.png");
                Bitmap bitmap2 = new Bitmap(bitmap);
        // Imposta l'immagine nella PictureBox
        pictureBox2.Image = bitmap2;

               
            }
            else
            {
                Console.WriteLine("Il file non esiste!");
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
            label1.Location = new Point(label1.Location.X, 28-trackBar3.Value);
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
        string versione = "TEST1";
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
            
            if(fileSizeInBytes== 458240)
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
    }
}
