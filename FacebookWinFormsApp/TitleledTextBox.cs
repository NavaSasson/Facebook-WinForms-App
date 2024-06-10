using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class TitleledTextBox : UserControl
    {
        public TitleledTextBox()
        {
            InitializeComponent();
        }

        public string Title
        {
            get 
            {
                return this.labelTitle.Text; 
            }
            set 
            { 
                this.labelTitle.Text = value;
            }
        }

        public string UserText
        {
            get 
            { 
                return this.textBox.Text; 
            }
            set 
            { 
                this.textBox.Text = value;
            }
        }
    }
}