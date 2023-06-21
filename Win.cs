using System.Windows.Forms;

namespace Tutgetch
{
    public partial class Win : Form
    {
        public Win()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
