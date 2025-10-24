namespace Calculator_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            string equation = equationBox.Text; // declared the text from equationBox as a variable "equation"
            string[] split = equation.Split(' '); // splits the equation using a space as the delimiter

            int num1 = Convert.ToInt32(split[0]); // using split[0] convert the first number to int
            int num2 = Convert.ToInt32(split[2]); // using split[2] convert the second number to int
            string op = split[1]; // using split[1] find the operator used by the user

            if (op == "+") // if statement for if user uses addition
            {
                int result = num1 + num2;
                resultBox.Text = Convert.ToString(result);
            }
            else if (op == "-") // if statement for if user uses subtraction
            {
                int result = num1 - num2;
                resultBox.Text = Convert.ToString(result);
            }
            else if (op == "*") // if statement for if user uses multiplication
            {
                int result = num1 * num2;
                resultBox.Text = Convert.ToString(result);
            }
            else if (op == "/") // if statement for if user uses division
            {
                int result = num1 / num2;
                resultBox.Text = Convert.ToString(result);
            }
            else if (op == "**") // if statement for if user uses power
            {
                int num3 = num1;
                for (int i = 0; i < num2; i++)
                {
                    num3 = num3 * num1;
                }
                resultBox.Text = Convert.ToString(num3);
            }
            else 
            {
                MessageBox.Show("Please input a valid equation using the operators +,-,*,/,**. ex:32 / 12");
            }



        }
    }
}
