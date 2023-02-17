namespace forms_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string number1;
        string number2;
        char sign = ' ';
        int result;
       
        
       


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void one_Click(object sender, EventArgs e)
        {
            dzialanie(1);
        }

        private void two_Click(object sender, EventArgs e)
        {
            dzialanie(2);
        }

        private void three_Click(object sender, EventArgs e)
        {
            dzialanie(3);
        }

        private void minus_Click(object sender, EventArgs e)
        {
            sign = '-';
            tb.Text = null;

        }

        private void four_Click(object sender, EventArgs e)
        {
            dzialanie(4);
        }

        private void five_Click(object sender, EventArgs e)
        {
            dzialanie(5);
        }

        private void six_Click(object sender, EventArgs e)
        {
            dzialanie(6);
        }

        private void plus_Click(object sender, EventArgs e)
        {
            sign = '+';
            tb.Text = " ";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            dzialanie(7);
        }

        private void eight_Click(object sender, EventArgs e)
        {
            dzialanie(8);
        }

        private void nine_Click(object sender, EventArgs e)
        {
            dzialanie(9);
        }

        private void suma_Click(object sender, EventArgs e)
        {
            
            
                switch (sign)
                {
                    case '+':
                        result = (int.Parse(number1) + int.Parse(number2));
                        tb.Text = result.ToString();
                        break;
                    case '-':
                        result = (int.Parse(number1) - int.Parse(number2));
                        tb.Text = result.ToString();
                        break;
                    case '/':
                        result = (int.Parse(number1) / int.Parse(number2));
                        tb.Text = result.ToString();
                        break;
                    case '*':
                        result = (int.Parse(number1) * int.Parse(number2));
                        tb.Text = result.ToString();
                        break;

                }

          
         
                

        }

        private void mn_Click(object sender, EventArgs e)
        {
            sign = '*';
            tb.Text = " ";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            dzialanie(0);
        }

        private void dz_Click(object sender, EventArgs e)
        {
            sign = '/';
            tb.Text = " ";
        }
        private void dzialanie (int a)
        {
            if (sign == ' ')
            {
                number1 += a;
                tb.Text = number1;

            }
            else
            {
                
                number2 += a;
                tb.Text = number2;
            }
        
        }

        private void clear_Click(object sender, EventArgs e)
        {
            number1 = null;
            number2 = null;
            sign = ' ';
            tb.Text = " ";

        

        }
    }
}