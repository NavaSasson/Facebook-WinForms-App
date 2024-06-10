namespace BasicFacebookFeatures
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonFilterFriends = new System.Windows.Forms.Button();
            this.titledListBoxEvents = new BasicFacebookFeatures.TitledListBox();
            this.titledListBoxGroups = new BasicFacebookFeatures.TitledListBox();
            this.titledListBoxAlbums = new BasicFacebookFeatures.TitledListBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.textBoxAppID = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.titledDataLabelMaleLikes = new BasicFacebookFeatures.TitledDataLabel();
            this.titledDataLabelFemaleLikes = new BasicFacebookFeatures.TitledDataLabel();
            this.titledDataLabelLikes = new BasicFacebookFeatures.TitledDataLabel();
            this.titledDataLabelComments = new BasicFacebookFeatures.TitledDataLabel();
            this.titleledTextBoxPost = new BasicFacebookFeatures.TitleledTextBox();
            this.buttonSetStatus = new System.Windows.Forms.Button();
            this.labelUserInstructions = new System.Windows.Forms.Label();
            this.buttonShowStatistics = new System.Windows.Forms.Button();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.linkLabelFetchPosts = new System.Windows.Forms.LinkLabel();
            this.buttonSaveStatistics = new System.Windows.Forms.Button();
            this.labelPostStatistic = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLogin.Location = new System.Drawing.Point(18, 17);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(268, 32);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLogout.Location = new System.Drawing.Point(18, 57);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(268, 32);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 26);
            this.label1.TabIndex = 53;
            this.label1.Text = "AppID:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1243, 697);
            this.tabControl1.TabIndex = 54;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonFilterFriends);
            this.tabPage1.Controls.Add(this.titledListBoxEvents);
            this.tabPage1.Controls.Add(this.titledListBoxGroups);
            this.tabPage1.Controls.Add(this.titledListBoxAlbums);
            this.tabPage1.Controls.Add(this.pictureBoxProfile);
            this.tabPage1.Controls.Add(this.textBoxAppID);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonLogout);
            this.tabPage1.Controls.Add(this.buttonLogin);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1235, 658);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonFilterFriends
            // 
            this.buttonFilterFriends.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonFilterFriends.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonFilterFriends.Location = new System.Drawing.Point(839, 147);
            this.buttonFilterFriends.Name = "buttonFilterFriends";
            this.buttonFilterFriends.Size = new System.Drawing.Size(350, 40);
            this.buttonFilterFriends.TabIndex = 59;
            this.buttonFilterFriends.Text = "Filter friends and create group\r\n";
            this.buttonFilterFriends.UseVisualStyleBackColor = false;
            this.buttonFilterFriends.Click += new System.EventHandler(this.buttonFilterFriends_Click);
            // 
            // titledListBoxEvents
            // 
            this.titledListBoxEvents.DisplayMember = "";
            this.titledListBoxEvents.LabelText = "Event location:";
            this.titledListBoxEvents.Location = new System.Drawing.Point(839, 283);
            this.titledListBoxEvents.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.titledListBoxEvents.Name = "titledListBoxEvents";
            this.titledListBoxEvents.Picture = null;
            this.titledListBoxEvents.Size = new System.Drawing.Size(334, 235);
            this.titledListBoxEvents.TabIndex = 58;
            this.titledListBoxEvents.Title = "Fetch Events";
            this.titledListBoxEvents.SelectedIndexChanged += new System.EventHandler(this.titledListBoxEvents_SelectedIndexChanged);
            this.titledListBoxEvents.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.titledListBoxEvents_LinkClicked);
            // 
            // titledListBoxGroups
            // 
            this.titledListBoxGroups.DisplayMember = "";
            this.titledListBoxGroups.LabelText = "Group privacy:";
            this.titledListBoxGroups.Location = new System.Drawing.Point(430, 283);
            this.titledListBoxGroups.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.titledListBoxGroups.Name = "titledListBoxGroups";
            this.titledListBoxGroups.Picture = null;
            this.titledListBoxGroups.Size = new System.Drawing.Size(344, 235);
            this.titledListBoxGroups.TabIndex = 57;
            this.titledListBoxGroups.Title = "Fetch Groups";
            this.titledListBoxGroups.SelectedIndexChanged += new System.EventHandler(this.titledListBoxGroups_SelectedIndexChanged);
            this.titledListBoxGroups.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.titledListBoxGroups_LinkClicked);
            // 
            // titledListBoxAlbums
            // 
            this.titledListBoxAlbums.DisplayMember = "";
            this.titledListBoxAlbums.LabelText = "Creation Date:";
            this.titledListBoxAlbums.Location = new System.Drawing.Point(14, 283);
            this.titledListBoxAlbums.Margin = new System.Windows.Forms.Padding(4);
            this.titledListBoxAlbums.Name = "titledListBoxAlbums";
            this.titledListBoxAlbums.Picture = null;
            this.titledListBoxAlbums.Size = new System.Drawing.Size(341, 235);
            this.titledListBoxAlbums.TabIndex = 56;
            this.titledListBoxAlbums.Title = "Fetch Albums";
            this.titledListBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.titledListBoxAlbums_SelectedIndexChanged);
            this.titledListBoxAlbums.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.titledListBoxAlbums_LinkClicked);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(326, 17);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(79, 78);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            // 
            // textBoxAppID
            // 
            this.textBoxAppID.Location = new System.Drawing.Point(517, 38);
            this.textBoxAppID.Name = "textBoxAppID";
            this.textBoxAppID.Size = new System.Drawing.Size(209, 32);
            this.textBoxAppID.TabIndex = 54;
            this.textBoxAppID.Text = "963027758369875";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.titledDataLabelMaleLikes);
            this.tabPage2.Controls.Add(this.titledDataLabelFemaleLikes);
            this.tabPage2.Controls.Add(this.titledDataLabelLikes);
            this.tabPage2.Controls.Add(this.titledDataLabelComments);
            this.tabPage2.Controls.Add(this.titleledTextBoxPost);
            this.tabPage2.Controls.Add(this.buttonSetStatus);
            this.tabPage2.Controls.Add(this.labelUserInstructions);
            this.tabPage2.Controls.Add(this.buttonShowStatistics);
            this.tabPage2.Controls.Add(this.listBoxPosts);
            this.tabPage2.Controls.Add(this.linkLabelFetchPosts);
            this.tabPage2.Controls.Add(this.buttonSaveStatistics);
            this.tabPage2.Controls.Add(this.labelPostStatistic);
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1235, 658);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Posts";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // titledDataLabelMaleLikes
            // 
            this.titledDataLabelMaleLikes.DataText = "0";
            this.titledDataLabelMaleLikes.Location = new System.Drawing.Point(865, 335);
            this.titledDataLabelMaleLikes.Margin = new System.Windows.Forms.Padding(4);
            this.titledDataLabelMaleLikes.Name = "titledDataLabelMaleLikes";
            this.titledDataLabelMaleLikes.Size = new System.Drawing.Size(318, 29);
            this.titledDataLabelMaleLikes.TabIndex = 11;
            this.titledDataLabelMaleLikes.Title = "Male\'s Likes:";
            // 
            // titledDataLabelFemaleLikes
            // 
            this.titledDataLabelFemaleLikes.DataText = "0";
            this.titledDataLabelFemaleLikes.Location = new System.Drawing.Point(865, 292);
            this.titledDataLabelFemaleLikes.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.titledDataLabelFemaleLikes.Name = "titledDataLabelFemaleLikes";
            this.titledDataLabelFemaleLikes.Size = new System.Drawing.Size(318, 34);
            this.titledDataLabelFemaleLikes.TabIndex = 10;
            this.titledDataLabelFemaleLikes.Title = "Female\'s Likes:";
            // 
            // titledDataLabelLikes
            // 
            this.titledDataLabelLikes.DataText = "0";
            this.titledDataLabelLikes.Location = new System.Drawing.Point(865, 244);
            this.titledDataLabelLikes.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.titledDataLabelLikes.Name = "titledDataLabelLikes";
            this.titledDataLabelLikes.Size = new System.Drawing.Size(318, 38);
            this.titledDataLabelLikes.TabIndex = 9;
            this.titledDataLabelLikes.Title = "Likes:";
            // 
            // titledDataLabelComments
            // 
            this.titledDataLabelComments.DataText = "0";
            this.titledDataLabelComments.Location = new System.Drawing.Point(865, 381);
            this.titledDataLabelComments.Margin = new System.Windows.Forms.Padding(4);
            this.titledDataLabelComments.Name = "titledDataLabelComments";
            this.titledDataLabelComments.Size = new System.Drawing.Size(318, 29);
            this.titledDataLabelComments.TabIndex = 8;
            this.titledDataLabelComments.Title = "Comments:";
            // 
            // titleledTextBoxPost
            // 
            this.titleledTextBoxPost.Location = new System.Drawing.Point(36, 33);
            this.titleledTextBoxPost.Margin = new System.Windows.Forms.Padding(4);
            this.titleledTextBoxPost.Name = "titleledTextBoxPost";
            this.titleledTextBoxPost.Size = new System.Drawing.Size(539, 59);
            this.titleledTextBoxPost.TabIndex = 7;
            this.titleledTextBoxPost.Title = "Post Status:";
            this.titleledTextBoxPost.UserText = "";
            // 
            // buttonSetStatus
            // 
            this.buttonSetStatus.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSetStatus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSetStatus.Location = new System.Drawing.Point(624, 47);
            this.buttonSetStatus.Name = "buttonSetStatus";
            this.buttonSetStatus.Size = new System.Drawing.Size(75, 34);
            this.buttonSetStatus.TabIndex = 6;
            this.buttonSetStatus.Text = "Post";
            this.buttonSetStatus.UseVisualStyleBackColor = false;
            this.buttonSetStatus.Click += new System.EventHandler(this.buttonSetStatus_Click);
            // 
            // labelUserInstructions
            // 
            this.labelUserInstructions.AutoSize = true;
            this.labelUserInstructions.Location = new System.Drawing.Point(128, 449);
            this.labelUserInstructions.Name = "labelUserInstructions";
            this.labelUserInstructions.Size = new System.Drawing.Size(682, 26);
            this.labelUserInstructions.TabIndex = 5;
            this.labelUserInstructions.Text = "Select a post from the list and click the button to see statistics about it";
            // 
            // buttonShowStatistics
            // 
            this.buttonShowStatistics.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonShowStatistics.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonShowStatistics.Location = new System.Drawing.Point(292, 518);
            this.buttonShowStatistics.Name = "buttonShowStatistics";
            this.buttonShowStatistics.Size = new System.Drawing.Size(181, 39);
            this.buttonShowStatistics.TabIndex = 4;
            this.buttonShowStatistics.Text = "Show Statistics";
            this.buttonShowStatistics.UseVisualStyleBackColor = false;
            this.buttonShowStatistics.Click += new System.EventHandler(this.buttonShowStatistics_Click);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 26;
            this.listBoxPosts.Location = new System.Drawing.Point(36, 198);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(663, 212);
            this.listBoxPosts.TabIndex = 3;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // linkLabelFetchPosts
            // 
            this.linkLabelFetchPosts.AutoSize = true;
            this.linkLabelFetchPosts.Location = new System.Drawing.Point(31, 144);
            this.linkLabelFetchPosts.Name = "linkLabelFetchPosts";
            this.linkLabelFetchPosts.Size = new System.Drawing.Size(133, 26);
            this.linkLabelFetchPosts.TabIndex = 2;
            this.linkLabelFetchPosts.TabStop = true;
            this.linkLabelFetchPosts.Text = "Fetch Posts:";
            this.linkLabelFetchPosts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFetchPosts_LinkClicked);
            // 
            // buttonSaveStatistics
            // 
            this.buttonSaveStatistics.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSaveStatistics.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSaveStatistics.Location = new System.Drawing.Point(935, 470);
            this.buttonSaveStatistics.Name = "buttonSaveStatistics";
            this.buttonSaveStatistics.Size = new System.Drawing.Size(178, 45);
            this.buttonSaveStatistics.TabIndex = 1;
            this.buttonSaveStatistics.Text = "Save Statistics";
            this.buttonSaveStatistics.UseVisualStyleBackColor = false;
            this.buttonSaveStatistics.Click += new System.EventHandler(this.buttonSavePostStatistics_Click);
            // 
            // labelPostStatistic
            // 
            this.labelPostStatistic.AutoSize = true;
            this.labelPostStatistic.Location = new System.Drawing.Point(963, 198);
            this.labelPostStatistic.Name = "labelPostStatistic";
            this.labelPostStatistic.Size = new System.Drawing.Size(150, 26);
            this.labelPostStatistic.TabIndex = 0;
            this.labelPostStatistic.Text = "Post Statistics";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 697);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxAppID;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.LinkLabel linkLabelFetchPosts;
        private System.Windows.Forms.Button buttonSaveStatistics;
        private System.Windows.Forms.Label labelPostStatistic;
        private System.Windows.Forms.Label labelUserInstructions;
        private System.Windows.Forms.Button buttonShowStatistics;
        private System.Windows.Forms.Button buttonSetStatus;
        private TitledDataLabel titledDataLabelComments;
        private TitleledTextBox titleledTextBoxPost;
        private TitledDataLabel titledDataLabelMaleLikes;
        private TitledDataLabel titledDataLabelFemaleLikes;
        private TitledDataLabel titledDataLabelLikes;
        private TitledListBox titledListBoxAlbums;
        private System.Windows.Forms.Button buttonFilterFriends;
        private TitledListBox titledListBoxEvents;
        private TitledListBox titledListBoxGroups;
    }
}

