using System.Diagnostics.Eventing.Reader;

namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        string currentInput = "";
        double results = 0;
        string operation = "";
        bool operationPending = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (operationPending)
            {
                Evaluate();
            }
            Button button = (Button)sender;
            operation = button.Text;
            results = double.Parse(currentInput);
            currentInput = "";
            operationPending = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (operationPending)
            {
                Evaluate();
            }
            Button button = (Button)sender;
            operation = button.Text;
            results = double.Parse(currentInput);
            currentInput = "";
            operationPending = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }
        private void Evaluate()
        {
            if (operationPending)
            {
                double secondNumber = double.Parse(currentInput);

                switch (operation)
                {
                    case "+":
                        results += secondNumber;
                        break;
                    case "-":
                        results -= secondNumber;
                        break;
                    case "*":
                        results *= secondNumber;
                        break;
                    case "/":
                        if (secondNumber != 0)
                            results /= secondNumber;
                        break;
                }
            }
            else
            {
                textBox1.Text = "Error";
                return;
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (operationPending)
            {
                Evaluate();
            }
            Button button = (Button)sender;
            operation = button.Text;
            results = double.Parse(currentInput);
            currentInput = "";
            operationPending = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (operationPending)
            {
                Evaluate();
            }
            Button button = (Button)sender;
            operation = button.Text;
            results = double.Parse(currentInput);
            currentInput = "";
            operationPending = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            currentInput = "";
            results = 0;
            operationPending = false;
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Evaluate();
            textBox1.Text = results.ToString();
            currentInput = "";
            operationPending = false;
        }
    }
}
