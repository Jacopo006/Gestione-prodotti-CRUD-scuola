using System;
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
            Modifica();
        }


        public void Visualizza()
        {
            ELENCO.Items.Clear();
            for (int i = 0; i < dim; i++)
            {
                ELENCO.Items.Add($" {p[i].nome} {p[i].prezzo}");
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
        }

        public void Modifica()
        {
            string a = textBox1.Text;

            for (int i = 0; i < dim; i++)
            {
                if (p[i].nome == a)
                {
                    p[i].nome = modificadelprodotto.Text;
                    //
                }
            }

        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void modificadelprodotto_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}

