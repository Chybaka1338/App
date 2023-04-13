using DynamicStructure;
using System.ComponentModel;

namespace App
{
    public partial class MainWindow : Form
    {
        static bool isOpened = false;

        public MainWindow()
        {
            InitializeComponent();
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AuthorCard form = new AuthorCard();
            form.Show();
        }
    }
}