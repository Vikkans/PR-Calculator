namespace PR_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Forre_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double placement = double.Parse(textBox1.Text);


            if (placement <= 7500 && placement >= 2500)
            {
                placement = ((10000 - double.Parse(textBox1.Text)) / 500);
                ;

                Pr.Text = Math.Round(placement, 2).ToString();
            }

            else if (placement <= 1000 && placement >= 500)
            {
                placement = ((4000 - 3 * double.Parse(textBox1.Text)) / 50);

                Pr.Text = Math.Round(placement, 2).ToString();
            }

            else if (placement <= 2500 && placement >= 1000)
            {
                placement = ((7000 - double.Parse(textBox1.Text)) / 300);


                Pr.Text = Math.Round(placement, 2).ToString();
            }

            else if ((placement <= 500) && placement >= 400)
            {
                placement = ((600 - double.Parse(textBox1.Text)) / 2);

                Pr.Text = Math.Round(placement, 2).ToString();
            }

            else if ((placement <= 400) && placement >= 300)
            {
                placement = ((800 - double.Parse(textBox1.Text)) / 4);

                Pr.Text = Math.Round(placement, 2).ToString();
            }

            else if ((placement <= 300) && placement >= 100)
            {
                placement = ((550 - double.Parse(textBox1.Text)) / 2);

                Pr.Text = Math.Round(placement, 2).ToString();
            }

            else if ((placement <= 100) && placement >= 50)
            {
                placement = ((950 - 5 * double.Parse(textBox1.Text)) / 2);

                Pr.Text = Math.Round(placement, 2).ToString();
            }


            else if ((placement <= 50) && placement >= 40)
            {
                placement = ((600 - 5 * double.Parse(textBox1.Text)) / 1);

                Pr.Text = Math.Round(placement, 2).ToString();
            }


            else if ((placement <= 40) && placement >= 10)
            {
                placement = ((1400 - 15 * double.Parse(textBox1.Text)) / 2);

                Pr.Text = Math.Round(placement, 2).ToString();
            }

            else if ((placement <= 9) && placement >= 3)
            {
                placement = ((925 - 25 * double.Parse(textBox1.Text)) / 1);

                Pr.Text = Math.Round(placement, 2).ToString();
            }

            else if ((placement <= 3) && placement >= 2)
            {
                placement = ((1000 - 50 * double.Parse(textBox1.Text)) / 1);

                Pr.Text = Math.Round(placement, 2).ToString();
            }

            else if ((placement <= 2) && placement >= 1)
            {
                placement = ((1100 - 100 * double.Parse(textBox1.Text)) / 1);

                Pr.Text = Math.Round(placement, 2).ToString();
            }

            if (radioButton5.Checked == true && placement < 7500)
            {
                placement = placement * 2;
                Pr.Text = Math.Round(placement, 2).ToString();
            }


            else if (placement > 7500)
            {
                Pr.Text = "0";
            }


            if (radioButton2.Checked == true && placement < 7500)
            {
                placement = placement * 0.25;
                Pr.Text = Math.Round(placement, 2).ToString();

            }

        }

        private void Pr_Click(object sender, EventArgs e)
        {

        }
    }
}