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
            char[] delimiter = { ' ' }; // sets a space as the delimiter to split the equation
            string[] split = equation.Split(delimiter); // splits the equation using the above delimiter

            int num1 = Convert.ToInt32(split[0]); // using split[0] convert the first number to int
            int num2 = Convert.ToInt32(split[2]); // using split[2] convert the second number to int
            string op = split[1]; // using split[1] find the operator used by the user




        }
    }
}
