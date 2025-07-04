namespace H20RendiContoMensile
{
    partial class FormAggiungiDati
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel10 = new Panel();
            textBoxNome = new TextBox();
            labelNome = new Label();
            panel3 = new Panel();
            dateTimePickerNascita = new DateTimePicker();
            labelDataNascita = new Label();
            panel2 = new Panel();
            textBoxCognome = new TextBox();
            labelCognome = new Label();
            panel1 = new Panel();
            textBoxCMD = new TextBox();
            labelCMD = new Label();
            panel7 = new Panel();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            panel8 = new Panel();
            textBoxResidenza = new TextBox();
            labelResidenza = new Label();
            panel9 = new Panel();
            textBoxLuogoNascita = new TextBox();
            labelLuogoDiNascita = new Label();
            panel6 = new Panel();
            textBoxContatto = new TextBox();
            labelContatto = new Label();
            menuStrip1 = new MenuStrip();
            aggiungiDatiToolStripMenuItem = new ToolStripMenuItem();
            letturaDatiToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            buttonLetturaDeiDati = new Button();
            sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            buttonClear = new Button();
            panel10.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel6.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel10
            // 
            panel10.Controls.Add(textBoxNome);
            panel10.Controls.Add(labelNome);
            panel10.Location = new Point(12, 152);
            panel10.Name = "panel10";
            panel10.Size = new Size(269, 67);
            panel10.TabIndex = 30;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(0, 34);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(256, 27);
            textBoxNome.TabIndex = 16;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(3, 11);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(50, 20);
            labelNome.TabIndex = 13;
            labelNome.Text = "Nome";
            // 
            // panel3
            // 
            panel3.Controls.Add(dateTimePickerNascita);
            panel3.Controls.Add(labelDataNascita);
            panel3.Location = new Point(12, 303);
            panel3.Name = "panel3";
            panel3.Size = new Size(269, 67);
            panel3.TabIndex = 32;
            // 
            // dateTimePickerNascita
            // 
            dateTimePickerNascita.Format = DateTimePickerFormat.Short;
            dateTimePickerNascita.Location = new Point(6, 37);
            dateTimePickerNascita.Name = "dateTimePickerNascita";
            dateTimePickerNascita.Size = new Size(250, 27);
            dateTimePickerNascita.TabIndex = 14;
            // 
            // labelDataNascita
            // 
            labelDataNascita.AutoSize = true;
            labelDataNascita.Location = new Point(0, 10);
            labelDataNascita.Name = "labelDataNascita";
            labelDataNascita.Size = new Size(111, 20);
            labelDataNascita.TabIndex = 13;
            labelDataNascita.Text = "Data di Nascita";
            // 
            // panel2
            // 
            panel2.Controls.Add(textBoxCognome);
            panel2.Controls.Add(labelCognome);
            panel2.Location = new Point(12, 226);
            panel2.Name = "panel2";
            panel2.Size = new Size(269, 71);
            panel2.TabIndex = 31;
            // 
            // textBoxCognome
            // 
            textBoxCognome.Location = new Point(0, 35);
            textBoxCognome.Name = "textBoxCognome";
            textBoxCognome.Size = new Size(256, 27);
            textBoxCognome.TabIndex = 16;
            // 
            // labelCognome
            // 
            labelCognome.AutoSize = true;
            labelCognome.Location = new Point(0, 12);
            labelCognome.Name = "labelCognome";
            labelCognome.Size = new Size(74, 20);
            labelCognome.TabIndex = 13;
            labelCognome.Text = "Cognome";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxCMD);
            panel1.Controls.Add(labelCMD);
            panel1.Location = new Point(12, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 67);
            panel1.TabIndex = 29;
            // 
            // textBoxCMD
            // 
            textBoxCMD.Location = new Point(0, 34);
            textBoxCMD.Name = "textBoxCMD";
            textBoxCMD.Size = new Size(256, 27);
            textBoxCMD.TabIndex = 16;
            textBoxCMD.TextChanged += textBoxCMD_TextChanged_1;
            // 
            // labelCMD
            // 
            labelCMD.AutoSize = true;
            labelCMD.Location = new Point(3, 11);
            labelCMD.Name = "labelCMD";
            labelCMD.Size = new Size(42, 20);
            labelCMD.TabIndex = 13;
            labelCMD.Text = "CMD";
            // 
            // panel7
            // 
            panel7.Controls.Add(textBoxEmail);
            panel7.Controls.Add(labelEmail);
            panel7.Location = new Point(1157, 235);
            panel7.Name = "panel7";
            panel7.Size = new Size(131, 66);
            panel7.TabIndex = 33;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(0, 34);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(125, 27);
            textBoxEmail.TabIndex = 16;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(3, 11);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 20);
            labelEmail.TabIndex = 13;
            labelEmail.Text = "Email";
            // 
            // panel8
            // 
            panel8.Controls.Add(textBoxResidenza);
            panel8.Controls.Add(labelResidenza);
            panel8.Location = new Point(1157, 157);
            panel8.Name = "panel8";
            panel8.Size = new Size(131, 66);
            panel8.TabIndex = 34;
            // 
            // textBoxResidenza
            // 
            textBoxResidenza.Location = new Point(0, 34);
            textBoxResidenza.Name = "textBoxResidenza";
            textBoxResidenza.Size = new Size(125, 27);
            textBoxResidenza.TabIndex = 16;
            // 
            // labelResidenza
            // 
            labelResidenza.AutoSize = true;
            labelResidenza.Location = new Point(3, 11);
            labelResidenza.Name = "labelResidenza";
            labelResidenza.Size = new Size(76, 20);
            labelResidenza.TabIndex = 13;
            labelResidenza.Text = "Residenza";
            // 
            // panel9
            // 
            panel9.Controls.Add(textBoxLuogoNascita);
            panel9.Controls.Add(labelLuogoDiNascita);
            panel9.Location = new Point(1157, 79);
            panel9.Name = "panel9";
            panel9.Size = new Size(131, 66);
            panel9.TabIndex = 35;
            // 
            // textBoxLuogoNascita
            // 
            textBoxLuogoNascita.Location = new Point(0, 34);
            textBoxLuogoNascita.Name = "textBoxLuogoNascita";
            textBoxLuogoNascita.Size = new Size(125, 27);
            textBoxLuogoNascita.TabIndex = 16;
            // 
            // labelLuogoDiNascita
            // 
            labelLuogoDiNascita.AutoSize = true;
            labelLuogoDiNascita.Location = new Point(3, 11);
            labelLuogoDiNascita.Name = "labelLuogoDiNascita";
            labelLuogoDiNascita.Size = new Size(121, 20);
            labelLuogoDiNascita.TabIndex = 13;
            labelLuogoDiNascita.Text = "Luogo di Nascita";
            // 
            // panel6
            // 
            panel6.Controls.Add(textBoxContatto);
            panel6.Controls.Add(labelContatto);
            panel6.Location = new Point(1157, 308);
            panel6.Name = "panel6";
            panel6.Size = new Size(131, 66);
            panel6.TabIndex = 36;
            // 
            // textBoxContatto
            // 
            textBoxContatto.Location = new Point(0, 34);
            textBoxContatto.Name = "textBoxContatto";
            textBoxContatto.Size = new Size(125, 27);
            textBoxContatto.TabIndex = 16;
            // 
            // labelContatto
            // 
            labelContatto.AutoSize = true;
            labelContatto.Location = new Point(3, 11);
            labelContatto.Name = "labelContatto";
            labelContatto.Size = new Size(67, 20);
            labelContatto.TabIndex = 13;
            labelContatto.Text = "Contatto";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aggiungiDatiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1582, 28);
            menuStrip1.TabIndex = 37;
            menuStrip1.Text = "menuStrip1";
            // 
            // aggiungiDatiToolStripMenuItem
            // 
            aggiungiDatiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { letturaDatiToolStripMenuItem });
            aggiungiDatiToolStripMenuItem.Name = "aggiungiDatiToolStripMenuItem";
            aggiungiDatiToolStripMenuItem.Size = new Size(69, 24);
            aggiungiDatiToolStripMenuItem.Text = "pagine";
            aggiungiDatiToolStripMenuItem.Click += aggiungiDatiToolStripMenuItem_Click;
            // 
            // letturaDatiToolStripMenuItem
            // 
            letturaDatiToolStripMenuItem.Name = "letturaDatiToolStripMenuItem";
            letturaDatiToolStripMenuItem.Size = new Size(168, 26);
            letturaDatiToolStripMenuItem.Text = "Lettura dati";
            letturaDatiToolStripMenuItem.Click += letturaDatiToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(297, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(806, 374);
            dataGridView1.TabIndex = 38;
            // 
            // buttonLetturaDeiDati
            // 
            buttonLetturaDeiDati.Location = new Point(297, 475);
            buttonLetturaDeiDati.Name = "buttonLetturaDeiDati";
            buttonLetturaDeiDati.Size = new Size(140, 64);
            buttonLetturaDeiDati.TabIndex = 40;
            buttonLetturaDeiDati.Text = "Inserimento dati";
            buttonLetturaDeiDati.UseVisualStyleBackColor = true;
            buttonLetturaDeiDati.Click += buttonLetturaDeiDati_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(963, 475);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(140, 64);
            buttonClear.TabIndex = 41;
            buttonClear.Text = "Clear Box";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // FormAggiungiDati
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(1582, 599);
            Controls.Add(buttonClear);
            Controls.Add(buttonLetturaDeiDati);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Controls.Add(panel7);
            Controls.Add(panel8);
            Controls.Add(panel9);
            Controls.Add(panel6);
            Controls.Add(panel10);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormAggiungiDati";
            Text = "aggiunta dati";
            Load += FormAggiungiDati_Load;
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel10;
        private TextBox textBoxNome;
        private Label labelNome;
        private Panel panel3;
        private Label labelDataNascita;
        private Panel panel2;
        private TextBox textBoxCognome;
        private Label labelCognome;
        private Panel panel1;
        private TextBox textBoxCMD;
        private Label labelCMD;
        private Panel panel7;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private Panel panel8;
        private TextBox textBoxResidenza;
        private Label labelResidenza;
        private Panel panel9;
        private TextBox textBoxLuogoNascita;
        private Label labelLuogoDiNascita;
        private Panel panel6;
        private TextBox textBoxContatto;
        private Label labelContatto;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aggiungiDatiToolStripMenuItem;
        private DataGridView dataGridView1;
        private ToolStripMenuItem letturaDatiToolStripMenuItem;
        private Button buttonLetturaDeiDati;
        private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private DateTimePicker dateTimePickerNascita;
        private Button buttonClear;
    }
}