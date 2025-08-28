namespace FractionCalculator
{
    public partial class FractionCalculator : Form
    {
        public FractionCalculator()
        {
            InitializeComponent();

            this.performOperation.Click += performOperation_Click;

            firstTop.KeyPress += TextBox_DigitsOnly_KeyPress;
            firstBottom.KeyPress += TextBox_DigitsOnly_KeyPress;
            secondTop.KeyPress += TextBox_DigitsOnly_KeyPress;
            secondBottom.KeyPress += TextBox_DigitsOnly_KeyPress;

            addition.CheckedChanged += RadioButton_CheckedChanged;
            subtraction.CheckedChanged += RadioButton_CheckedChanged;
            multiplication.CheckedChanged += RadioButton_CheckedChanged;
            division.CheckedChanged += RadioButton_CheckedChanged;

            // NEW: Dark mode + button wiring
            btnClear.Click += (_, __) => ClearAll();
            btnExit.Click += (_, __) => Close();
        }

        // digits only
        private void TextBox_DigitsOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        // Only auto-calc if all inputs exist; never show popups from here
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb && rb.Checked && HasAllInputs())
                DoCalculation(showWarnings: false);
        }

        private void performOperation_Click(object sender, EventArgs e)
        {
            DoCalculation(showWarnings: true); // show warning only if user pressed the button
        }

        private bool HasAllInputs()
            => !string.IsNullOrWhiteSpace(firstTop.Text)
            && !string.IsNullOrWhiteSpace(firstBottom.Text)
            && !string.IsNullOrWhiteSpace(secondTop.Text)
            && !string.IsNullOrWhiteSpace(secondBottom.Text);

        private void DoCalculation(bool showWarnings = true)
        {
            try
            {
                if (!HasAllInputs())
                {
                    if (showWarnings)
                        MessageBox.Show("Please fill in all fields.", "Invalid Input",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // silent if called from radio change
                }

                var f1 = new Fraction(firstTop.Text, firstBottom.Text);
                var f2 = new Fraction(secondTop.Text, secondBottom.Text);

                Fraction result = null;
                if (addition.Checked) result = f1 + f2;
                else if (subtraction.Checked) result = f1 - f2;
                else if (multiplication.Checked) result = f1 * f2;
                else if (division.Checked) result = f1 / f2;
                else
                {
                    if (showWarnings)
                        MessageBox.Show("Please select an operation.", "No Operation Selected",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Already simplified by Fraction class
                resultTop.Text = result.Top.ToString();
                resultBottom.Text = result.Bottom.ToString();
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Division by Zero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resultTop.Text = resultBottom.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resultTop.Text = resultBottom.Text = "";
            }
        }

        private void ClearAll()
        {
            firstTop.Clear(); firstBottom.Clear();
            secondTop.Clear(); secondBottom.Clear();
            resultTop.Clear(); resultBottom.Clear();
            addition.Checked = subtraction.Checked = multiplication.Checked = division.Checked = false;
            firstTop.Focus();
        }

        
    }
}
