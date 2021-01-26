
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
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PeopleFoundListBox
            // 
            this.PeopleFoundListBox.FormattingEnabled = true;
            this.PeopleFoundListBox.ItemHeight = 25;
            this.PeopleFoundListBox.Location = new System.Drawing.Point(192, 256);
            this.PeopleFoundListBox.Name = "PeopleFoundListBox";
            this.PeopleFoundListBox.Size = new System.Drawing.Size(337, 254);
            this.PeopleFoundListBox.TabIndex = 0;
            // 
            // lastNameTextbox
            // 
            this.lastNameTextbox.Location = new System.Drawing.Point(314, 204);
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.Size = new System.Drawing.Size(215, 31);
            this.lastNameTextbox.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(187, 207);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(109, 25);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "LastName";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(192, 531);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(337, 42);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 585);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.lastNameLabel);
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
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button searchButton;
    }
}

