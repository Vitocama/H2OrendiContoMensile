namespace H20RendiContoMensile
{
    public partial class Form1 : Form
    {

        List<Button> buttons=new List<Button>();
        public Form1()
        {
            InitializeComponent();

            buttons = new List<Button>() {
            button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Button mese in buttons) {
                mese.ForeColor = Color.Red;
                if (mese == button1) 
                    continue;
                else mese.ForeColor = Color.Blue;

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Button mese in buttons)
            {
                mese.ForeColor = Color.Red;
                if (mese == button2)
                    continue;
                else mese.ForeColor = Color.Blue;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Button mese in buttons)
            {
                mese.ForeColor = Color.Red;
                if (mese == button3)
                    continue;
                else mese.ForeColor = Color.Blue;

            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Button mese in buttons)
            {
                mese.ForeColor = Color.Red;
                if (mese == button4)
                    continue;
                else mese.ForeColor = Color.Blue;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (Button mese in buttons)
            {
                mese.ForeColor = Color.Red;
                if (mese == button5)
                    continue;
                else mese.ForeColor = Color.Blue;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (Button mese in buttons)
            {
                mese.ForeColor = Color.Red;
                if (mese == button6)
                    continue;
                else mese.ForeColor = Color.Blue;

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (Button mese in buttons)
            {
                mese.ForeColor = Color.Red;
                if (mese == button7)
                    continue;
                else mese.ForeColor = Color.Blue;

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            foreach (Button mese in buttons)
            {
                mese.ForeColor = Color.Red;
                if (mese == button8)
                    continue;
                else mese.ForeColor = Color.Blue;

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            foreach (Button mese in buttons)
            {
                mese.ForeColor = Color.Red;
                if (mese == button9)
                    continue;
                else mese.ForeColor = Color.Blue;

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            foreach (Button mese in buttons)
            {
                mese.ForeColor = Color.Red;
                if (mese == button10)
                    continue;
                else mese.ForeColor = Color.Blue;

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            foreach (Button mese in buttons)
            {
                mese.ForeColor = Color.Red;
                if (mese == button11)
                    continue;
                else mese.ForeColor = Color.Blue;

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            foreach (Button mese in buttons)
            {
                mese.ForeColor = Color.Red;
                if (mese == button12)
                    continue;
                else mese.ForeColor = Color.Blue;

            }
        }
    }
}
