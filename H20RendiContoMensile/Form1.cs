using Microsoft.Identity.Client;
using System.Data;

namespace H20RendiContoMensile;

public partial class Form1 : Form
{

      public  string connectionString = "Data Source=ACER\\SQLEXPRESS;Initial Catalog=MMI;Integrated Security=True;Encrypt=False;";

    List<Button> buttons = new List<Button>();
    public Form1()
    {
        InitializeComponent();
        buttons = new List<Button>() {
        button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12
        };
        foreach (Button mese in buttons)
        {
            mese.ForeColor = Color.Blue;

        }

        Color blueTenue = Color.FromArgb(191, 229, 255);
        comboBoxRicerca.SelectedItem = "Cmd";

    }

    private void button1_Click(object sender, EventArgs e)
    {
        foreach (Button mese in buttons)
        {
            mese.ForeColor = Color.Red;
            if (mese == button1)
            {
                mese.BackColor = Color.Yellow;
                continue;
            }
            else { mese.ForeColor = Color.Blue; mese.BackColor = Color.White; }

        }


    }

    private void button2_Click(object sender, EventArgs e)
    {
        foreach (Button mese in buttons)
        {
            mese.ForeColor = Color.Red;
            if (mese == button2)
            {

                mese.BackColor = Color.Yellow;
                continue;
            }
            else { mese.ForeColor = Color.Blue; mese.BackColor = Color.White; }
        }


    }








    private void button3_Click(object sender, EventArgs e)
    {
        foreach (Button mese in buttons)
        {
            {
                mese.ForeColor = Color.Red;
                if (mese == button3)
                {

                    mese.BackColor = Color.Yellow;
                    continue;
                }
                else { mese.ForeColor = Color.Blue; mese.BackColor = Color.White; }
            }

        }




    }

    private void button4_Click(object sender, EventArgs e)
    {
        foreach (Button mese in buttons)
        {
            {
                mese.ForeColor = Color.Red;
                if (mese == button4)
                {

                    mese.BackColor = Color.Yellow;
                    continue;
                }
                else { mese.ForeColor = Color.Blue; mese.BackColor = Color.White; }
            }
        }
    }

    private void button5_Click(object sender, EventArgs e)
    {
        foreach (Button mese in buttons)
        {
            {
                mese.ForeColor = Color.Red;
                if (mese == button5)
                {

                    mese.BackColor = Color.Yellow;
                    continue;
                }
                else { mese.ForeColor = Color.Blue; mese.BackColor = Color.White; }
            }
        }
    }

    private void button6_Click(object sender, EventArgs e)
    {
        foreach (Button mese in buttons)
        {
            {
                mese.ForeColor = Color.Red;
                if (mese == button6)
                {

                    mese.BackColor = Color.Yellow;
                    continue;
                }
                else { mese.ForeColor = Color.Blue; mese.BackColor = Color.White; }
            }

        }
    }

    private void button7_Click(object sender, EventArgs e)
    {
        foreach (Button mese in buttons)
        {
            {
                mese.ForeColor = Color.Red;
                if (mese == button7)
                {

                    mese.BackColor = Color.Yellow;
                    continue;
                }
                else { mese.ForeColor = Color.Blue; mese.BackColor = Color.White; }
            }

        }
    }

    private void button8_Click(object sender, EventArgs e)
    {
        foreach (Button mese in buttons)
        {
            {
                mese.ForeColor = Color.Red;
                if (mese == button8)
                {

                    mese.BackColor = Color.Yellow;
                    continue;
                }
                else { mese.ForeColor = Color.Blue; mese.BackColor = Color.White; }
            }

        }
    }

    private void button9_Click(object sender, EventArgs e)
    {
        foreach (Button mese in buttons)
        {
            {
                mese.ForeColor = Color.Red;
                if (mese == button9)
                {

                    mese.BackColor = Color.Yellow;
                    continue;
                }
                else { mese.ForeColor = Color.Blue; mese.BackColor = Color.White; }
            }

        }
    }

    private void button10_Click(object sender, EventArgs e)
    {
        foreach (Button mese in buttons)
        {
            {
                mese.ForeColor = Color.Red;
                if (mese == button10)
                {

                    mese.BackColor = Color.Yellow;
                    continue;
                }
                else { mese.ForeColor = Color.Blue; mese.BackColor = Color.White; }
            }

        }
    }

    private void button11_Click(object sender, EventArgs e)
    {
        foreach (Button mese in buttons)
        {
            {
                mese.ForeColor = Color.Red;
                if (mese == button11)
                {

                    mese.BackColor = Color.Yellow;
                    continue;
                }
                else { mese.ForeColor = Color.Blue; mese.BackColor = Color.White; }
            }

        }
    }

    private void button12_Click(object sender, EventArgs e)
    {
        foreach (Button mese in buttons)
        {
            {
                mese.ForeColor = Color.Red;
                if (mese == button12)
                {

                    mese.BackColor = Color.Yellow;
                    continue;
                }
                else { mese.ForeColor = Color.Blue; mese.BackColor = Color.White; }
            }

        }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        Color blueTenue = Color.FromArgb(191, 229, 255);
        this.BackColor = blueTenue;
    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {

    }

    private void groupBoxCMD_Enter(object sender, EventArgs e)
    {

    }

    private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {



    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void button13_Click(object sender, EventArgs e)
    {
        string query = "select *\r\nfrom dbo.gi_province";

        Connessione connessione=new Connessione();
        
        DataTable dt=   new DataTable();
            dt=connessione.connessioneTable(connectionString,query);
    }
}
