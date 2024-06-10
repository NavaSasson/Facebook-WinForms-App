using System;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class TitledListBox : UserControl
    {
        public TitledListBox()
        {
            InitializeComponent();
        }

        public event EventHandler SelectedIndexChanged;
        public event LinkLabelLinkClickedEventHandler LinkClicked;

        public string Title
        {
            get 
            { 
                return this.linkLabelTitle.Text; 
            }
            set 
            { 
                this.linkLabelTitle.Text = value; 
            }
        }

        public string LabelText
        {
            get 
            { 
                return this.label.Text; 
            }
            set 
            { 
                this.label.Text = value; 
            }
        }

        public Image Picture
        {
            get 
            { 
                return this.pictureBox.Image; 
            }
            set
            { 
                this.pictureBox.Image = value; 
            }
        }

        public object SelectedItem
        {
            get 
            { 
                return this.listBox.SelectedItem; 
            }
        }

        public string DisplayMember
        {
            get 
            { 
                return this.listBox.DisplayMember; 
            }
            set 
            { 
                this.listBox.DisplayMember = value; 
            }
        }

        public object Items
        {
            get 
            { 
                return this.listBox.Items; 
            }
        }

        public int ItemsCount
        {
            get 
            {
                return this.listBox.Items.Count; 
            }
        }

        public void LoadPicture(string i_PicURL)
        {
            pictureBox.LoadAsync(i_PicURL);
        }

        public void ItemsAdd(object i_ItemToAdd)
        {
            listBox.Items.Add(i_ItemToAdd);
        }

        public void ItemsClear()
        {
            listBox.Items.Clear();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndexChanged?.Invoke(this, EventArgs.Empty);
        }

        private void linkLabelTitle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkClicked?.Invoke(this, e);
        }
    }
}