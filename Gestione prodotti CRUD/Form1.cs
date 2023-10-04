﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gestione_prodotti_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
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

        //funzioni evento
        private void Aggiunta()
        {
            p[dim].nome = INSERISCI_.Text;
            p[dim].prezzo = float.Parse(INSERISCI_PREZZO.Text);
            dim++;
        }

        private void INSERISCI_Click(object sender, EventArgs e)
        {
            Aggiunta();
            Visualizza();
        }


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
        public void SommaPrezzo()
        {
            float PrezzoTotale = 0;
            for (int i = 0; i < dim; i++)
            {
                PrezzoTotale += p[i].prezzo;
            }
            MessageBox.Show("il prezzo totale è :" + PrezzoTotale.ToString());
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
    }
}

