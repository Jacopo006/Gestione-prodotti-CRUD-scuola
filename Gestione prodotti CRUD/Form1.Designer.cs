﻿namespace Gestione_prodotti_CRUD
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.INSERISCI_ = new System.Windows.Forms.TextBox();
            this.NOME_PRODOTTO = new System.Windows.Forms.Label();
            this.PREZZO = new System.Windows.Forms.Label();
            this.INSERISCI_PREZZO = new System.Windows.Forms.TextBox();
            this.INSERISCI = new System.Windows.Forms.Button();
            this.ELENCO = new System.Windows.Forms.ListView();
            this.MODIFICA_PRODOTTO = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MODIFICAù = new System.Windows.Forms.Label();
            this.modificadelprodotto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // INSERISCI_
            // 
            this.INSERISCI_.Location = new System.Drawing.Point(12, 61);
            this.INSERISCI_.Name = "INSERISCI_";
            this.INSERISCI_.Size = new System.Drawing.Size(100, 20);
            this.INSERISCI_.TabIndex = 0;
            this.INSERISCI_.TextChanged += new System.EventHandler(this.INSERISCI__TextChanged);
            // 
            // NOME_PRODOTTO
            // 
            this.NOME_PRODOTTO.AutoSize = true;
            this.NOME_PRODOTTO.Location = new System.Drawing.Point(12, 45);
            this.NOME_PRODOTTO.Name = "NOME_PRODOTTO";
            this.NOME_PRODOTTO.Size = new System.Drawing.Size(103, 13);
            this.NOME_PRODOTTO.TabIndex = 1;
            this.NOME_PRODOTTO.Text = "NOME PRODOTTO";
            this.NOME_PRODOTTO.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PREZZO
            // 
            this.PREZZO.AutoSize = true;
            this.PREZZO.Location = new System.Drawing.Point(12, 84);
            this.PREZZO.Name = "PREZZO";
            this.PREZZO.Size = new System.Drawing.Size(51, 13);
            this.PREZZO.TabIndex = 2;
            this.PREZZO.Text = "PREZZO";
            // 
            // INSERISCI_PREZZO
            // 
            this.INSERISCI_PREZZO.Location = new System.Drawing.Point(12, 100);
            this.INSERISCI_PREZZO.Name = "INSERISCI_PREZZO";
            this.INSERISCI_PREZZO.Size = new System.Drawing.Size(100, 20);
            this.INSERISCI_PREZZO.TabIndex = 3;
            this.INSERISCI_PREZZO.TextChanged += new System.EventHandler(this.INSERISCI_PREZZO_TextChanged);
            // 
            // INSERISCI
            // 
            this.INSERISCI.Location = new System.Drawing.Point(121, 61);
            this.INSERISCI.Name = "INSERISCI";
            this.INSERISCI.Size = new System.Drawing.Size(256, 59);
            this.INSERISCI.TabIndex = 4;
            this.INSERISCI.Text = "INSERISCI NELL\'ELENCO";
            this.INSERISCI.UseVisualStyleBackColor = true;
            this.INSERISCI.Click += new System.EventHandler(this.INSERISCI_Click);
            // 
            // ELENCO
            // 
            this.ELENCO.HideSelection = false;
            this.ELENCO.Location = new System.Drawing.Point(402, 22);
            this.ELENCO.Name = "ELENCO";
            this.ELENCO.Size = new System.Drawing.Size(495, 577);
            this.ELENCO.TabIndex = 5;
            this.ELENCO.UseCompatibleStateImageBehavior = false;
            this.ELENCO.View = System.Windows.Forms.View.List;
            this.ELENCO.SelectedIndexChanged += new System.EventHandler(this.ELENCO_SelectedIndexChanged);
            // 
            // MODIFICA_PRODOTTO
            // 
            this.MODIFICA_PRODOTTO.Location = new System.Drawing.Point(282, 225);
            this.MODIFICA_PRODOTTO.Name = "MODIFICA_PRODOTTO";
            this.MODIFICA_PRODOTTO.Size = new System.Drawing.Size(95, 124);
            this.MODIFICA_PRODOTTO.TabIndex = 7;
            this.MODIFICA_PRODOTTO.Text = "MODIFICA PRODOTTO";
            this.MODIFICA_PRODOTTO.UseVisualStyleBackColor = true;
            this.MODIFICA_PRODOTTO.Click += new System.EventHandler(this.MODIFICA_PRODOTTO_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 241);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MODIFICAù
            // 
            this.MODIFICAù.AutoSize = true;
            this.MODIFICAù.Location = new System.Drawing.Point(9, 264);
            this.MODIFICAù.Name = "MODIFICAù";
            this.MODIFICAù.Size = new System.Drawing.Size(237, 13);
            this.MODIFICAù.TabIndex = 9;
            this.MODIFICAù.Text = "INSERISCI IL NUOVO NOME DEL PRODOTTO";
            this.MODIFICAù.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // modificadelprodotto
            // 
            this.modificadelprodotto.Location = new System.Drawing.Point(10, 280);
            this.modificadelprodotto.Name = "modificadelprodotto";
            this.modificadelprodotto.Size = new System.Drawing.Size(236, 20);
            this.modificadelprodotto.TabIndex = 10;
            this.modificadelprodotto.TextChanged += new System.EventHandler(this.modificadelprodotto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "INSERISCI NOME DEL PRODOTTO DA MODIFICARE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 59);
            this.button1.TabIndex = 12;
            this.button1.Text = "CANCELLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 13;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(21, 492);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(202, 20);
            this.textBox2.TabIndex = 16;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "INSERISCI IL NOME DEL PRODOTTO DA CANCELLARE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(10, 329);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(236, 20);
            this.textBox3.TabIndex = 18;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "INSERISCI IL NUOVO PREZZO DEL PRODOTTO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(928, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 74);
            this.button2.TabIndex = 20;
            this.button2.Text = "ORDINA IN MODO ALFABETICO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1037, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 74);
            this.button3.TabIndex = 21;
            this.button3.Text = "TOTALE PREZZO";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(928, 61);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(103, 20);
            this.textBox4.TabIndex = 22;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(928, 87);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 69);
            this.button4.TabIndex = 23;
            this.button4.Text = "SOTTRAI PERCENTUALE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1037, 87);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 69);
            this.button5.TabIndex = 24;
            this.button5.Text = "SOMMA PERCENTUALE";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(925, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "INSERISCI UNA PERCENTUALE";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(928, 259);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 74);
            this.button6.TabIndex = 26;
            this.button6.Text = "SALVA SU FILE";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1037, 259);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 74);
            this.button7.TabIndex = 27;
            this.button7.Text = "LEGGI DA FILE";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(928, 170);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(212, 74);
            this.button8.TabIndex = 28;
            this.button8.Text = "TROVA IL MAGGIORE E IL MINORE";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1563, 611);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modificadelprodotto);
            this.Controls.Add(this.MODIFICAù);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MODIFICA_PRODOTTO);
            this.Controls.Add(this.ELENCO);
            this.Controls.Add(this.INSERISCI);
            this.Controls.Add(this.INSERISCI_PREZZO);
            this.Controls.Add(this.PREZZO);
            this.Controls.Add(this.NOME_PRODOTTO);
            this.Controls.Add(this.INSERISCI_);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox INSERISCI_;
        private System.Windows.Forms.Label NOME_PRODOTTO;
        private System.Windows.Forms.Label PREZZO;
        private System.Windows.Forms.TextBox INSERISCI_PREZZO;
        private System.Windows.Forms.Button INSERISCI;
        private System.Windows.Forms.ListView ELENCO;
        private System.Windows.Forms.Button MODIFICA_PRODOTTO;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label MODIFICAù;
        private System.Windows.Forms.TextBox modificadelprodotto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

