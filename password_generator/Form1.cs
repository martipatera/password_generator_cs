namespace password_generator
{
    public partial class Password_Generator_Label : Form
    {
        public Password_Generator_Label()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            ExitApp.ExitAppForm(this);
        }
    }
}
