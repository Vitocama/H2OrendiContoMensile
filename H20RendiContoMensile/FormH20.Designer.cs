namespace H20RendiContoMensile
{
    partial class FormH20
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
            components = new System.ComponentModel.Container();
            monthCalendarH20 = new MonthCalendar();
            panel1 = new Panel();
            textBoxCMDH20 = new TextBox();
            labelCMD = new Label();
            buttonCalcoloBottoglie = new Button();
            panel2 = new Panel();
            textBoxGiorniDiFerie = new TextBox();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            inserimToolStripMenuItem = new ToolStripMenuItem();
            inserimentoDatiToolStripMenuItem = new ToolStripMenuItem();
            letturaDatiToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // monthCalendarH20
            // 
            monthCalendarH20.Location = new Point(958, 52);
            monthCalendarH20.MaxDate = new DateTime(2025, 7, 4, 0, 0, 0, 0);
            monthCalendarH20.MaxSelectionCount = 365;
            monthCalendarH20.MinDate = new DateTime(2020, 1, 5, 0, 0, 0, 0);
            monthCalendarH20.Name = "monthCalendarH20";
            monthCalendarH20.ShowToday = false;
            monthCalendarH20.TabIndex = 0;
            monthCalendarH20.TrailingForeColor = Color.PowderBlue;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxCMDH20);
            panel1.Controls.Add(labelCMD);
            panel1.Location = new Point(12, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 67);
            panel1.TabIndex = 30;
            // 
            // textBoxCMDH20
            // 
            textBoxCMDH20.Location = new Point(0, 34);
            textBoxCMDH20.Name = "textBoxCMDH20";
            textBoxCMDH20.Size = new Size(256, 27);
            textBoxCMDH20.TabIndex = 16;
            textBoxCMDH20.TextChanged += textBoxCMD_TextChanged;
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
            // buttonCalcoloBottoglie
            // 
            buttonCalcoloBottoglie.Location = new Point(12, 239);
            buttonCalcoloBottoglie.Name = "buttonCalcoloBottoglie";
            buttonCalcoloBottoglie.Size = new Size(140, 64);
            buttonCalcoloBottoglie.TabIndex = 37;
            buttonCalcoloBottoglie.Text = "Colcolo Bottiglie";
            buttonCalcoloBottoglie.UseVisualStyleBackColor = true;
            buttonCalcoloBottoglie.Click += buttonAnagrafe_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBoxGiorniDiFerie);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 141);
            panel2.Name = "panel2";
            panel2.Size = new Size(269, 67);
            panel2.TabIndex = 38;
            // 
            // textBoxGiorniDiFerie
            // 
            textBoxGiorniDiFerie.AccessibleDescription = "";
            textBoxGiorniDiFerie.Location = new Point(0, 34);
            textBoxGiorniDiFerie.Name = "textBoxGiorniDiFerie";
            textBoxGiorniDiFerie.Size = new Size(256, 27);
            textBoxGiorniDiFerie.TabIndex = 16;
            textBoxGiorniDiFerie.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 13;
            label1.Text = "Giorni di ferie";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inserimToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1234, 28);
            menuStrip1.TabIndex = 41;
            menuStrip1.Text = "menuStrip1";
            // 
            // inserimToolStripMenuItem
            // 
            inserimToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inserimentoDatiToolStripMenuItem, letturaDatiToolStripMenuItem });
            inserimToolStripMenuItem.Name = "inserimToolStripMenuItem";
            inserimToolStripMenuItem.Size = new Size(67, 24);
            inserimToolStripMenuItem.Text = "Pagina";
            // 
            // inserimentoDatiToolStripMenuItem
            // 
            inserimentoDatiToolStripMenuItem.Name = "inserimentoDatiToolStripMenuItem";
            inserimentoDatiToolStripMenuItem.Size = new Size(200, 26);
            inserimentoDatiToolStripMenuItem.Text = "Inserimento dati";
            inserimentoDatiToolStripMenuItem.Click += inserimentoDatiToolStripMenuItem_Click;
            // 
            // letturaDatiToolStripMenuItem
            // 
            letturaDatiToolStripMenuItem.Name = "letturaDatiToolStripMenuItem";
            letturaDatiToolStripMenuItem.Size = new Size(200, 26);
            letturaDatiToolStripMenuItem.Text = "Lettura dati";
            letturaDatiToolStripMenuItem.Click += letturaDatiToolStripMenuItem_Click;
            // 
            // FormH20
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(1234, 450);
            Controls.Add(menuStrip1);
            Controls.Add(panel2);
            Controls.Add(buttonCalcoloBottoglie);
            Controls.Add(panel1);
            Controls.Add(monthCalendarH20);
            Name = "FormH20";
            Text = "H20";
            Load += FormH20_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendarH20;
        private Panel panel1;
        private TextBox textBoxCMDH20;
        private Label labelCMD;
        private Button buttonCalcoloBottoglie;
        private Panel panel2;
        private TextBox textBoxGiorniDiFerie;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem inserimToolStripMenuItem;
        private ToolStripMenuItem inserimentoDatiToolStripMenuItem;
        private ToolStripMenuItem letturaDatiToolStripMenuItem;
    }
}