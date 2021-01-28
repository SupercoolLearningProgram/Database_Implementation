
namespace FormUi
{
    partial class Dashboard
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
            this.PeopleFoundListBox = new System.Windows.Forms.ListBox();
            this.lastNameTextbox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.notify1 = new System.Windows.Forms.Label();
            this.FirstNameIns = new System.Windows.Forms.TextBox();
            this.LastNameIns = new System.Windows.Forms.TextBox();
            this.EmailIns = new System.Windows.Forms.TextBox();
            this.PhoneIns = new System.Windows.Forms.TextBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PeopleFoundListBox
            // 
            this.PeopleFoundListBox.FormattingEnabled = true;
            this.PeopleFoundListBox.ItemHeight = 25;
            this.PeopleFoundListBox.Location = new System.Drawing.Point(53, 86);
            this.PeopleFoundListBox.Name = "PeopleFoundListBox";
            this.PeopleFoundListBox.Size = new System.Drawing.Size(499, 254);
            this.PeopleFoundListBox.TabIndex = 0;
            // 
            // lastNameTextbox
            // 
            this.lastNameTextbox.Location = new System.Drawing.Point(64, 44);
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.Size = new System.Drawing.Size(499, 31);
            this.lastNameTextbox.TabIndex = 1;
            this.lastNameTextbox.Text = "Enter Lastname";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.searchButton.Location = new System.Drawing.Point(53, 371);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(499, 68);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // notify1
            // 
            this.notify1.AutoSize = true;
            this.notify1.BackColor = System.Drawing.SystemColors.WindowText;
            this.notify1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notify1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.notify1.Location = new System.Drawing.Point(744, 47);
            this.notify1.Name = "notify1";
            this.notify1.Size = new System.Drawing.Size(207, 25);
            this.notify1.TabIndex = 4;
            this.notify1.Text = "INSERT NEW USER";
            // 
            // FirstNameIns
            // 
            this.FirstNameIns.Location = new System.Drawing.Point(586, 114);
            this.FirstNameIns.Name = "FirstNameIns";
            this.FirstNameIns.Size = new System.Drawing.Size(499, 31);
            this.FirstNameIns.TabIndex = 5;
            this.FirstNameIns.Text = "First Name";
            // 
            // LastNameIns
            // 
            this.LastNameIns.Location = new System.Drawing.Point(586, 181);
            this.LastNameIns.Name = "LastNameIns";
            this.LastNameIns.Size = new System.Drawing.Size(499, 31);
            this.LastNameIns.TabIndex = 6;
            this.LastNameIns.Text = "Last Name";
            // 
            // EmailIns
            // 
            this.EmailIns.Location = new System.Drawing.Point(586, 245);
            this.EmailIns.Name = "EmailIns";
            this.EmailIns.Size = new System.Drawing.Size(499, 31);
            this.EmailIns.TabIndex = 7;
            this.EmailIns.Text = "Email Address";
            // 
            // PhoneIns
            // 
            this.PhoneIns.Location = new System.Drawing.Point(586, 309);
            this.PhoneIns.Name = "PhoneIns";
            this.PhoneIns.Size = new System.Drawing.Size(499, 31);
            this.PhoneIns.TabIndex = 8;
            this.PhoneIns.Text = "Phone Number";
            // 
            // InsertButton
            // 
            this.InsertButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.InsertButton.Location = new System.Drawing.Point(586, 371);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(499, 68);
            this.InsertButton.TabIndex = 9;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1097, 471);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.PhoneIns);
            this.Controls.Add(this.EmailIns);
            this.Controls.Add(this.LastNameIns);
            this.Controls.Add(this.FirstNameIns);
            this.Controls.Add(this.notify1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.lastNameTextbox);
            this.Controls.Add(this.PeopleFoundListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.Text = "SQL Data Access";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PeopleFoundListBox;
        private System.Windows.Forms.TextBox lastNameTextbox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label notify1;
        private System.Windows.Forms.TextBox FirstNameIns;
        private System.Windows.Forms.TextBox LastNameIns;
        private System.Windows.Forms.TextBox EmailIns;
        private System.Windows.Forms.TextBox PhoneIns;
        private System.Windows.Forms.Button InsertButton;
    }
}

