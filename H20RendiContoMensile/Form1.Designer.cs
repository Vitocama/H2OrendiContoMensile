namespace H20RendiContoMensile
{
    partial class FormRicerca
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            panel4 = new Panel();
            comboBoxRicerca = new ComboBox();
            textBoxCerca = new TextBox();
            label1 = new Label();
            panel5 = new Panel();
            menuStrip1 = new MenuStrip();
            aggiungiDatiToolStripMenuItem = new ToolStripMenuItem();
            aggiungiDatiToolStripMenuItem1 = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            buttonLetturaDeiDati = new Button();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(3, 40);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Gennaio";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(91, 40);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Febbraio";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(181, 40);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Marzo";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(268, 40);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "Aprile";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(358, 40);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 4;
            button5.Text = "Maggio";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(449, 40);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 5;
            button6.Text = "Giugno";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(540, 40);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 6;
            button7.Text = "Luglio";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(627, 40);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 7;
            button8.Text = "Agosto";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(717, 40);
            button9.Name = "button9";
            button9.Size = new Size(94, 29);
            button9.TabIndex = 8;
            button9.Text = "Settembre";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(807, 40);
            button10.Name = "button10";
            button10.Size = new Size(94, 29);
            button10.TabIndex = 9;
            button10.Text = "Ottoblre";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(898, 40);
            button11.Name = "button11";
            button11.Size = new Size(94, 29);
            button11.TabIndex = 10;
            button11.Text = "Novembre";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Location = new Point(989, 40);
            button12.Name = "button12";
            button12.Size = new Size(94, 29);
            button12.TabIndex = 11;
            button12.Text = "Dicembre";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(comboBoxRicerca);
            panel4.Controls.Add(textBoxCerca);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(872, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(324, 61);
            panel4.TabIndex = 23;
            // 
            // comboBoxRicerca
            // 
            comboBoxRicerca.FormattingEnabled = true;
            comboBoxRicerca.Items.AddRange(new object[] { "Cmd", "Nome", "Cognome", "Data di Nascita", "Luogo di Nascita", "Residenza", "Email", "Contatto" });
            comboBoxRicerca.Location = new Point(173, 30);
            comboBoxRicerca.Name = "comboBoxRicerca";
            comboBoxRicerca.Size = new Size(151, 28);
            comboBoxRicerca.TabIndex = 28;
            comboBoxRicerca.SelectedIndexChanged += comboBoxRicerca_SelectedIndexChanged;
            // 
            // textBoxCerca
            // 
            textBoxCerca.Location = new Point(3, 31);
            textBoxCerca.Name = "textBoxCerca";
            textBoxCerca.Size = new Size(125, 27);
            textBoxCerca.TabIndex = 16;
            textBoxCerca.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 9);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 13;
            label1.Text = "Cerca";
            // 
            // panel5
            // 
            panel5.Controls.Add(button1);
            panel5.Controls.Add(button2);
            panel5.Controls.Add(button3);
            panel5.Controls.Add(button4);
            panel5.Controls.Add(button5);
            panel5.Controls.Add(button6);
            panel5.Controls.Add(button12);
            panel5.Controls.Add(button7);
            panel5.Controls.Add(button11);
            panel5.Controls.Add(button8);
            panel5.Controls.Add(button10);
            panel5.Controls.Add(button9);
            panel5.Location = new Point(94, 67);
            panel5.Name = "panel5";
            panel5.Size = new Size(1102, 77);
            panel5.TabIndex = 25;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aggiungiDatiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1505, 28);
            menuStrip1.TabIndex = 29;
            menuStrip1.Text = "menuStrip1";
            // 
            // aggiungiDatiToolStripMenuItem
            // 
            aggiungiDatiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aggiungiDatiToolStripMenuItem1 });
            aggiungiDatiToolStripMenuItem.Name = "aggiungiDatiToolStripMenuItem";
            aggiungiDatiToolStripMenuItem.Size = new Size(69, 24);
            aggiungiDatiToolStripMenuItem.Text = "pagine";
            // 
            // aggiungiDatiToolStripMenuItem1
            // 
            aggiungiDatiToolStripMenuItem1.Name = "aggiungiDatiToolStripMenuItem1";
            aggiungiDatiToolStripMenuItem1.Size = new Size(224, 26);
            aggiungiDatiToolStripMenuItem1.Text = "aggiungi dati";
            aggiungiDatiToolStripMenuItem1.Click += aggiungiDatiToolStripMenuItem1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(193, 173);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(921, 375);
            dataGridView1.TabIndex = 26;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonLetturaDeiDati
            // 
            buttonLetturaDeiDati.Location = new Point(12, 484);
            buttonLetturaDeiDati.Name = "buttonLetturaDeiDati";
            buttonLetturaDeiDati.Size = new Size(140, 64);
            buttonLetturaDeiDati.TabIndex = 34;
            buttonLetturaDeiDati.Text = "Lettura dei dati";
            buttonLetturaDeiDati.UseVisualStyleBackColor = true;
            // 
            // FormRicerca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(1505, 592);
            Controls.Add(buttonLetturaDeiDati);
            Controls.Add(dataGridView1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "FormRicerca";
            Text = "Lettura dat";
            Load += Form1_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Panel panel4;
        private TextBox textBoxCerca;
        private Label label1;
        private CheckedListBox checkedListBoxRicerca;
        private Panel panel5;
        private ComboBox comboBoxRicerca;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aggiungiDatiToolStripMenuItem;
        private ToolStripMenuItem aggiungiDatiToolStripMenuItem1;
        private DataGridView dataGridView1;
        private Button buttonLetturaDeiDati;
    }
}
