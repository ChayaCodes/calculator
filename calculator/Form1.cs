namespace calculator
{

	//define enum for operations
	enum Operation
	{
		None,
		Add,
		Subtract,
		Multiply,
		Divide
	}
    enum Emode
    {
        regular,
        programmer
    }
    public partial class Form1 : Form
    {

        double num1 = 0;
        double num2 = 0;
        Operation operation = Operation.None;
        bool start = true;

        Emode mode = Emode.regular;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }



        private void zero_Click(object sender, EventArgs e)
        {
            if (solve.Text == "0" || start)
                solve.Text = "";
            if (solve.Text.Length < 9)
                solve.Text = solve.Text + "0";
            start = false;
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (solve.Text == "0" || start)
                solve.Text = "";
            if (solve.Text.Length < 9)
                solve.Text = solve.Text + "1";
            start = false;

        }

        private void two_Click(object sender, EventArgs e)
        {
            if (solve.Text == "0" || start)
                solve.Text = "";
            if (solve.Text.Length < 9)
                solve.Text = solve.Text + "2";
            start = false;

        }

        private void three_Click(object sender, EventArgs e)
        {
            if (solve.Text == "0" || start)
                solve.Text = "";
            if (solve.Text.Length < 9)
                solve.Text = solve.Text + "3";
            start = false;

        }

        private void four_Click(object sender, EventArgs e)
        {
            if (solve.Text == "0" || start)
                solve.Text = "";
            if (solve.Text.Length < 9)
                solve.Text = solve.Text + "4";
            start = false;

        }

        private void five_Click(object sender, EventArgs e)
        {
            if (solve.Text == "0" || start)
                solve.Text = "";
            if (solve.Text.Length < 9)
                solve.Text = solve.Text + "5";
            start = false;

        }

        private void six_Click(object sender, EventArgs e)
        {
            if (solve.Text == "0" || start)
                solve.Text = "";
            if (solve.Text.Length < 9)
                solve.Text = solve.Text + "6";
            start = false;

        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (solve.Text == "0" || start)
                solve.Text = "";
            if (solve.Text.Length < 9)
                solve.Text = solve.Text + "7";
            start = false;

        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (solve.Text == "0" || start)
                solve.Text = "";
            if (solve.Text.Length < 9)
                solve.Text = solve.Text + "8";
            start = false;

        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (solve.Text == "0" || start)
                solve.Text = "";
            if (solve.Text.Length < 9)
                solve.Text = solve.Text + "9";
            start = false;
        }
        private Boolean isOnlyDigits(string str)
        {
            try
            {
                 Convert.ToDouble(str);
            }catch(Exception e)
            {
                return false;
            }
            return true;

        }
        private void dot_Click(object sender, EventArgs e)
        {
            //only if there is no dot.
            if (!solve.Text.Contains(".")&&isOnlyDigits(solve.Text))
            {
                solve.Text += ".";
                start = false;
            }


        }

        private void add_Click(object sender, EventArgs e)
        {
            if(!isOnlyDigits(solve.Text))
            {
                solve.Text = "0";
                start = true;
                return;
            }
            solution.Text = solve.Text + " + ";
            num1 = Convert.ToDouble(solve.Text);
            operation = Operation.Add;
            solve.Text = "0";
        }

        private void sub_Click(object sender, EventArgs e)
        {
            if (!isOnlyDigits(solve.Text))
            {
                solve.Text = "0";
                start = true;
                return;
            }
            solution.Text = solve.Text + "-";
            num1 = Convert.ToDouble(solve.Text);
            operation = Operation.Subtract;
            solve.Text = "0";
        }

        private void multi_Click(object sender, EventArgs e)
        {
            if(!isOnlyDigits(solve.Text))
            {
                solve.Text = "0";
                start = true;
                return;
            }
            solution.Text = solve.Text + " x ";
            num1 = Convert.ToDouble(solve.Text);
            operation = Operation.Multiply;
            solve.Text = "0";

        }

        private void devide_Click(object sender, EventArgs e)
        {
            if (!isOnlyDigits(solve.Text))
            {
                solve.Text = "0";
                start = true;
                return;
            }
            solution.Text = solve.Text + " / ";
            num1 = Convert.ToDouble(solve.Text);
            operation = Operation.Divide;
            solve.Text = "0";
        }

        private void equals_Click(object sender, EventArgs e)
        {
            if (!isOnlyDigits(solve.Text))
            {
                solve.Text = "0";
                start = true;
                return;
            }
            if (operation != Operation.None)
            {
                num2 = Convert.ToDouble(solve.Text);
                switch (operation)
                {
                    case Operation.Add:
                        solve.Text = Convert.ToString(num1 + num2);
                        break;
                    case Operation.Subtract:
                        solve.Text = Convert.ToString(num1 - num2);
                        break;
                    case Operation.Multiply:
                        solve.Text = Convert.ToString(num1 * num2);
                        break;
                    case Operation.Divide:
                        if (num2 == 0)
                        {
                            solve.Text = "לא לחלק באפס";
                            start = true;
                            return;

                        }
                        solve.Text = Convert.ToString(num1 / num2);
                        break;
                }
                operation = Operation.None;
                num1 = Convert.ToDouble(solve.Text);
                solution.Text = "";
                start = true;
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (solve.Text.Length > 0 && solve.Text != "0")
            {
                solve.Text = solve.Text.Remove(solve.Text.Length - 1, 1);
            }
            if(solve.Text.Length == 0)
            {
                solve.Text = "0";
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            solve.Text = "0";
            solution.Text = "";
        }

        private void precent_Click(object sender, EventArgs e)
        {
            if (!isOnlyDigits(solve.Text))
            {
                solve.Text = "0";
                start = true;
                return;
            }
            solve.Text = Convert.ToString(Convert.ToDouble(solve.Text) / 100);

        }

        private void clearE_Click(object sender, EventArgs e)
        {
            solve.Text = "0";
        }

        private void oneDevide_Click(object sender, EventArgs e)
        {
            if (!isOnlyDigits(solve.Text))
            {
                solve.Text = "0";
                start = true;
                return;
            }
            if (solve.Text == "0")
            {
                solve.Text = "לא לחלק באפס";
                start = true;
            }
            else if (solve.Text != "לא לחלק באפס")
                solve.Text = Convert.ToString(1 / Convert.ToDouble(solve.Text));
        }

        private void pow_Click(object sender, EventArgs e)
        {
            if (!isOnlyDigits(solve.Text))
            {
                solve.Text = "0";
                start = true;
                return;
            }
            solution.Text = solve.Text + "^" + "2";
            solve.Text = Convert.ToString(Math.Pow(Convert.ToDouble(solve.Text), 2));
            start = true;

        }

        private void root_Click(object sender, EventArgs e)
        {
            if (!isOnlyDigits(solve.Text))
            {
                solve.Text = "0";
                start = true;
                return;
            }
            if (Convert.ToDouble(solve.Text) < 0)
            {
                solve.Text = "לא ניתן להפעיל שורש על מספר שלילי";
                start = true;
                return;
            }
            solution.Text = "sqrt(" + solve.Text + ")";
            solve.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(solve.Text)));
            start = true;
        }

        private void openMenue_Click(object sender, EventArgs e)
        {
            menue.Visible = !menue.Visible;
        }

        private void proggremer_Click(object sender, EventArgs e)
        {
            mode = Emode.programmer;
            menue.Visible = false;
            changeToProggremmer();
        }

        private void changeToProggremmer()
        {
            

        }


    }
}
