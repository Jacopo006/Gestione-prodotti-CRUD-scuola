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
            this.SuspendLayout();
            // 
            // INSERISCI_
            // 
            this.INSERISCI_.Location = new System.Drawing.Point(12, 34);
            this.INSERISCI_.Name = "INSERISCI_";
            this.INSERISCI_.Size = new System.Drawing.Size(100, 20);
            this.INSERISCI_.TabIndex = 0;
            this.INSERISCI_.TextChanged += new System.EventHandler(this.INSERISCI__TextChanged);
            // 
            // NOME_PRODOTTO
            // 
            this.NOME_PRODOTTO.AutoSize = true;
            this.NOME_PRODOTTO.Location = new System.Drawing.Point(12, 18);
            this.NOME_PRODOTTO.Name = "NOME_PRODOTTO";
            this.NOME_PRODOTTO.Size = new System.Drawing.Size(103, 13);
            this.NOME_PRODOTTO.TabIndex = 1;
            this.NOME_PRODOTTO.Text = "NOME PRODOTTO";
            this.NOME_PRODOTTO.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PREZZO
            // 
            this.PREZZO.AutoSize = true;
            this.PREZZO.Location = new System.Drawing.Point(12, 57);
            this.PREZZO.Name = "PREZZO";
            this.PREZZO.Size = new System.Drawing.Size(51, 13);
            this.PREZZO.TabIndex = 2;
            this.PREZZO.Text = "PREZZO";
            // 
            // INSERISCI_PREZZO
            // 
            this.INSERISCI_PREZZO.Location = new System.Drawing.Point(12, 73);
            this.INSERISCI_PREZZO.Name = "INSERISCI_PREZZO";
            this.INSERISCI_PREZZO.Size = new System.Drawing.Size(100, 20);
            this.INSERISCI_PREZZO.TabIndex = 3;
            this.INSERISCI_PREZZO.TextChanged += new System.EventHandler(this.INSERISCI_PREZZO_TextChanged);
            // 
            // INSERISCI
            // 
            this.INSERISCI.Location = new System.Drawing.Point(146, 18);
            this.INSERISCI.Name = "INSERISCI";
            this.INSERISCI.Size = new System.Drawing.Size(103, 75);
            this.INSERISCI.TabIndex = 4;
            this.INSERISCI.Text = "INSERISCI NELL\'ELENCO";
            this.INSERISCI.UseVisualStyleBackColor = true;
            this.INSERISCI.Click += new System.EventHandler(this.INSERISCI_Click);
            // 
            // ELENCO
            // 
            this.ELENCO.HideSelection = false;
            this.ELENCO.Location = new System.Drawing.Point(598, 6);
            this.ELENCO.Name = "ELENCO";
            this.ELENCO.Size = new System.Drawing.Size(433, 561);
            this.ELENCO.TabIndex = 5;
            this.ELENCO.UseCompatibleStateImageBehavior = false;
            this.ELENCO.View = System.Windows.Forms.View.List;
            this.ELENCO.SelectedIndexChanged += new System.EventHandler(this.ELENCO_SelectedIndexChanged);
            // 
            // MODIFICA_PRODOTTO
            // 
            this.MODIFICA_PRODOTTO.Location = new System.Drawing.Point(284, 143);
            this.MODIFICA_PRODOTTO.Name = "MODIFICA_PRODOTTO";
            this.MODIFICA_PRODOTTO.Size = new System.Drawing.Size(103, 74);
            this.MODIFICA_PRODOTTO.TabIndex = 7;
            this.MODIFICA_PRODOTTO.Text = "MODIFICA PRODOTTO";
            this.MODIFICA_PRODOTTO.UseVisualStyleBackColor = true;
            this.MODIFICA_PRODOTTO.Click += new System.EventHandler(this.MODIFICA_PRODOTTO_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 159);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(103, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MODIFICAù
            // 
            this.MODIFICAù.AutoSize = true;
            this.MODIFICAù.Location = new System.Drawing.Point(12, 182);
            this.MODIFICAù.Name = "MODIFICAù";
            this.MODIFICAù.Size = new System.Drawing.Size(237, 13);
            this.MODIFICAù.TabIndex = 9;
            this.MODIFICAù.Text = "INSERISCI IL NUOVO NOME DEL PRODOTTO";
            this.MODIFICAù.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // modificadelprodotto
            // 
            this.modificadelprodotto.Location = new System.Drawing.Point(12, 198);
            this.modificadelprodotto.Name = "modificadelprodotto";
            this.modificadelprodotto.Size = new System.Drawing.Size(103, 20);
            this.modificadelprodotto.TabIndex = 10;
            this.modificadelprodotto.TextChanged += new System.EventHandler(this.modificadelprodotto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "INSERISCI NOME DEL PRODOTTO DA RICERCARE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 74);
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
            this.textBox2.Location = new System.Drawing.Point(9, 336);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(103, 20);
            this.textBox2.TabIndex = 16;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "TROVA L\'ELEMENTO DA CANCELLARE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 247);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(103, 20);
            this.textBox3.TabIndex = 18;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "INSERISCI IL NUOVO PREZZO DEL PRODOTTO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1037, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 74);
            this.button2.TabIndex = 20;
            this.button2.Text = "ORDINA IN MODO ALFABETICO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1563, 611);
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
    }
}

