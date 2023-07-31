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


        //Правило ввода только цифр в поля
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


        //Обработчик введенных данных
        private void CurrentMoneyTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                currentMoney = Convert.ToDouble(CurrentMoneyTextBox.Text);
                CalculateInvestitions();
            }
            catch 
            { 
                
            }
        }

        private void TimeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                time = Convert.ToInt32(TimeTextBox.Text);
                CalculateInvestitions();
            }
            catch  
            { 
                
            }
        }

        private void PercentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                percent = Convert.ToDouble(PercentTextBox.Text) / 100;
                CalculateInvestitions();
            }
            catch
            {

            }
        }

        private void InflationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                inflation = Convert.ToDouble(InflationTextBox.Text) / 100;
                CalculateInvestitions();
            }
            catch
            { 
                
            }
        }


        //функция рассчёта итоговой суммы
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

        }


    }
}