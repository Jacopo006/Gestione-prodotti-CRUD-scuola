using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gestione_prodotti_CRUD
{
    public partial class Form1 : Form
    {
        public string file;


        public Form1()
        {
            InitializeComponent();
            file = @"file.csv"; //inizializzi il file (nel caso il file non fosse presente te lo crea lui)
        }

        // Definizione della struttura Prodotti
        public struct Prodotti
        {
            public string nome;
            public float prezzo;
        }


        public Prodotti[] p; // array di strutture di tipo struct che contiene Nome e Prezzo 
        public int dim; //dichiarazione variabile intera dimensione
      


        private void Form1_Load(object sender, EventArgs e)
        {
            p = new Prodotti[100];
            dim = 0;
        }

        private void INSERISCI__TextChanged(object sender, EventArgs e)
        {

        }

        private void INSERISCI_PREZZO_TextChanged(object sender, EventArgs e)
        {

        }

        // Funzione per aggiungere un prodotto
        private void Aggiunta()
        {
            p[dim].nome = INSERISCI_.Text;
            float prezzo;
            if (float.TryParse(INSERISCI_PREZZO.Text, out prezzo)) //Inserimento del prezzo con controllo sul valore numerico
            {
                p[dim].prezzo = prezzo;
                dim++;
            }
            else
            {
                MessageBox.Show("Il carattere inserito non è un numero");
            }

        }

        private void INSERISCI_Click(object sender, EventArgs e)
        {
            Aggiunta();
            Visualizza();
        }

        // Funzione per visualizzare i prodotti
        public void Visualizza()
        {
            ELENCO.Items.Clear();
            for (int i = 0; i < dim; i++)
            {
                ELENCO.Items.Add($"il nome è: {p[i].nome} e il prezzo è: {p[i].prezzo}");
            }
        }

        private void ELENCO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VISUALIZZA_LISTA_Click(object sender, EventArgs e)
        {
            Visualizza();
        }

        private void MODIFICA_PRODOTTO_Click(object sender, EventArgs e)
        {
            Modifica();
            Visualizza();
        }


        // Funzione per modificare un prodotto
        public void Modifica()
        {
            string a = textBox1.Text;

            for (int i = 0; i < dim; i++)
            {
                if (p[i].nome == a)
                {
                    p[i].nome = modificadelprodotto.Text;
                    p[i].prezzo = float.Parse(textBox3.Text);
                }
            }

        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void modificadelprodotto_TextChanged(object sender, EventArgs e)
        {
          
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Visualizza();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Visualizza();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Cancella();
            Visualizza();
        }

        // Funzione per cancellare un prodotto
        public void Cancella()
        {
            bool trovato= false;
            string B = textBox2.Text;
            int i = 0;
            while(trovato==false) // Ciclo while per cercare l'oggetto nella struct p
            {
                if (p[i].nome == B)
                {
                    trovato = true;
                }
                i++;
            }
            if (trovato == true) // Se l'oggetto è stato trovato, lo rimuove dall'array
            {
                for (int k = i-1; k < dim; k++)
                {
                    p[k].nome = p[k + 1].nome;
                    p[k].prezzo = p[k + 1].prezzo;
                }
                
                dim--;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        // Funzione per ordinare i prodotti in ordine alfabetico
        private void Alfabetico()
        {
            for (int i = 0; i < dim; i++)
            {
                for (int j = i + 1; j < dim; j++)
                {
                    if (string.Compare(p[i].nome, p[j].nome) > 0)
                    {
                        // Scambia i prodotti e i prezzi
                        string a = p[i].nome;
                        float b = p[i].prezzo;

                        p[i].nome = p[j].nome;
                        p[i].prezzo = p[j].prezzo;

                        p[j].nome = a;
                        p[j].prezzo = b;
                    }
                }
            }
        }

        // Funzione per calcolare la somma dei prezzi
        public void SommaPrezzo()
        {
            float PrezzoTotale = 0;
            for (int i = 0; i < dim; i++)
            {
                PrezzoTotale += p[i].prezzo;
            }
            MessageBox.Show("Il prezzo totale è :" + PrezzoTotale.ToString());
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            Alfabetico(); 
            Visualizza();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SommaPrezzo();
            Visualizza();
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        // Funzione per applicare uno sconto percentuale
        private void button4_Click(object sender, EventArgs e)
        {
            SommaPerCent();
        }

        // Funzione per applicare un aumento percentuale
        private void button5_Click(object sender, EventArgs e)
        {
            SottPercent();
        }

        private void SommaPerCent()
        {
            float sconto = float.Parse(textBox4.Text);
            float prezzoscontato;
            // prezzo : 100 =  x : sconto
            for (int i = 0; i < dim; i++)
            {
                prezzoscontato = ((p[i].prezzo) * (sconto)) / 100;
                p[i].prezzo = p[i].prezzo - prezzoscontato;
            }
            Visualizza();
        }


        private void SottPercent()
        {
            float sconto = float.Parse(textBox4.Text);
            float prezzoscontato;
            for (int i = 0; i < dim; i++)
            {
                prezzoscontato = ((p[i].prezzo) * (sconto)) / 100;
                p[i].prezzo = p[i].prezzo + prezzoscontato;
            }
            Visualizza();

        }


        // Funzione per salvare la lista su un file di testo
        private void button6_Click(object sender, EventArgs e)
        {
            SalvaFile();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Letturadafile();
        }


        private void button8_Click(object sender, EventArgs e)
        {
            MaxMin();
        }



        private void MaxMin()
        {
            float min = 1000000; 
            float max = 0;       

            for (int i = 0; i < dim; i++)
            {
                if (p[i].prezzo < min)
                {
                    min = p[i].prezzo;
                }
                else if (p[i].prezzo > max)
                {
                    max = p[i].prezzo;
                }
            }
            MessageBox.Show($"il prezzo minimo è: {min} e il massimo è {max}");
        }


        public void SalvaFile()
        {
            using (StreamWriter sw = new StreamWriter(file, append: true))
            {
                for (int i = 0; i < dim; i++)
                {
                    sw.WriteLine($"Nome:{p[i].nome};Prezzo:{p[i].prezzo}");
                }
                sw.Close();

            }

        }
        public void Letturadafile()
        {
            ELENCO.Items.Clear();//Pulisci la listbox

            using (StreamReader gg = new StreamReader(file))
            {
                for (int i = 0; i < p.Length; i++)
                {
                    string a = gg.ReadLine();
                    ELENCO.Items.Add(a);
                }
                gg.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

