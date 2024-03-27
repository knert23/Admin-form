
namespace IBiZI_lab3
{
    partial class BanUserForm
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.buttonBanUser = new System.Windows.Forms.Button();
            this.buttonUnbanUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUsername.Location = new System.Drawing.Point(33, 44);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(137, 29);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username:";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUserName.Location = new System.Drawing.Point(197, 41);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(208, 36);
            this.textBoxUserName.TabIndex = 1;
            // 
            // buttonBanUser
            // 
            this.buttonBanUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBanUser.Location = new System.Drawing.Point(163, 145);
            this.buttonBanUser.Name = "buttonBanUser";
            this.buttonBanUser.Size = new System.Drawing.Size(148, 43);
            this.buttonBanUser.TabIndex = 2;
            this.buttonBanUser.Text = "Ban User";
            this.buttonBanUser.UseVisualStyleBackColor = true;
            this.buttonBanUser.Click += new System.EventHandler(this.buttonBanUser_Click);
            // 
            // buttonUnbanUser
            // 
            this.buttonUnbanUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUnbanUser.Location = new System.Drawing.Point(368, 145);
            this.buttonUnbanUser.Name = "buttonUnbanUser";
            this.buttonUnbanUser.Size = new System.Drawing.Size(148, 43);
            this.buttonUnbanUser.TabIndex = 3;
            this.buttonUnbanUser.Text = "Unban User";
            this.buttonUnbanUser.UseVisualStyleBackColor = true;
            this.buttonUnbanUser.Click += new System.EventHandler(this.buttonUnbanUser_Click);
            // 
            // BanUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUnbanUser);
            this.Controls.Add(this.buttonBanUser);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelUsername);
            this.Name = "BanUserForm";
            this.Text = "BanUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Button buttonBanUser;
        private System.Windows.Forms.Button buttonUnbanUser;
    }
}