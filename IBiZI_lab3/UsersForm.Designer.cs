
namespace IBiZI_lab3
{
    partial class UsersForm
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
            this.UsersList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // UsersList
            // 
            this.UsersList.BackColor = System.Drawing.Color.White;
            this.UsersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersList.FormattingEnabled = true;
            this.UsersList.ItemHeight = 22;
            this.UsersList.Location = new System.Drawing.Point(0, 0);
            this.UsersList.Name = "UsersList";
            this.UsersList.Size = new System.Drawing.Size(1026, 594);
            this.UsersList.TabIndex = 0;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(821, 475);
            this.Controls.Add(this.UsersList);
            this.Name = "Users";
            this.Text = "Users";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox UsersList;
    }
}