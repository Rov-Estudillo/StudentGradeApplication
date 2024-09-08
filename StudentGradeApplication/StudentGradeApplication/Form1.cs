namespace StudentGradeApplication
{
    public partial class frmStudentGradeProgram : Form
    {
        public frmStudentGradeProgram()
        {
            InitializeComponent();
        }

        private void button_Generate_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(textBox_name.Text) ||
                    !double.TryParse(textBox_English.Text, out double subEnglish) ||
                    !double.TryParse(textBox_Filipino.Text, out double subFilipino) ||
                    !double.TryParse(textBox_History.Text, out double subHistory) ||
                    !double.TryParse(textBox_Math.Text, out double subMath) ||
                    !double.TryParse(textBox_Science.Text, out double subScience))
            {
                MessageBox.Show("Please Enter avlid data for all the fields.", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            double average = (subEnglish + subFilipino + subHistory + subMath + subScience) / 5.0;

            string result = average >= 75.0 ? "Passed" : "Failed";

            label_Show.Text = $"The student {result}.\nThe general average of {textBox_name.Text} is {average:F2}%.";
        }
    }
}
