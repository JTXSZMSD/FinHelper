namespace FinHelper
{
    public partial class Form1 : Form
    {

        private double currentMoney = 0;
        private int time = 0;
        private double percent = 0;
        private double inflation = 0;
        private double futureMoney = 0;
        private double profit = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CurrentMoneyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void TimeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void PercentTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void InflationTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void CurrentMoneyTextBox_TextChanged(object sender, EventArgs e)
        {
            currentMoney = Convert.ToDouble(CurrentMoneyTextBox.Text);
            CalculateInvestitions();
        }

        private void TimeTextBox_TextChanged(object sender, EventArgs e)
        {
            time = Convert.ToInt32(TimeTextBox.Text);
            CalculateInvestitions();
        }

        private void PercentTextBox_TextChanged(object sender, EventArgs e)
        {
            percent = Convert.ToDouble(PercentTextBox.Text) / 100;
            CalculateInvestitions();
        }

        private void InflationTextBox_TextChanged(object sender, EventArgs e)
        {
            inflation = Convert.ToDouble(InflationTextBox.Text) / 100;
            CalculateInvestitions();
        }

        private void CalculateInvestitions()
        {
            int tempTime = time;

            double futureMoney = currentMoney;
            double tempPercent = percent / (12);
            

            if (tempTime <= 2400 && tempTime > 0 && tempPercent > 0)
            {
                while(tempTime > 0) 
                {
                    futureMoney += futureMoney * tempPercent;
                    tempTime -= 1;
                }

                String FutureMoney = futureMoney.ToString();
                FutureMoneyTextBox.Text = FutureMoney;
            }


            //double temp1;
            //temp1 = (1 + percent / 12);

            //int temp2 = 12 * time;

            //while (temp2 > 0)
            //{
            //    temp1 = temp1 * temp1;
            //    temp2 -= 1;
            //}

        }


    }
}