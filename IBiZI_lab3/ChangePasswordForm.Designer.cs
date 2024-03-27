
namespace IBiZI_lab3
{
    partial class ChangePasswordForm
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
            this.labelOldPass = new System.Windows.Forms.Label();
            this.textBoxOldPass = new System.Windows.Forms.TextBox();
            this.textBoxNewPass = new System.Windows.Forms.TextBox();
            this.labelNewPass = new System.Windows.Forms.Label();
            this.textBoxConfirmPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonChangePass = new System.Windows.Forms.Button();
            this.buttonCalcPassStrength = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelOldPass
            // 
            this.labelOldPass.AutoSize = true;
            this.labelOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOldPass.Location = new System.Drawing.Point(40, 46);
            this.labelOldPass.Name = "labelOldPass";
            this.labelOldPass.Size = new System.Drawing.Size(177, 29);
            this.labelOldPass.TabIndex = 0;
            this.labelOldPass.Text = "Old Password:";
            // 
            // textBoxOldPass
            // 
            this.textBoxOldPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOldPass.Location = new System.Drawing.Point(251, 44);
            this.textBoxOldPass.Name = "textBoxOldPass";
            this.textBoxOldPass.Size = new System.Drawing.Size(212, 36);
            this.textBoxOldPass.TabIndex = 1;
            // 
            // textBoxNewPass
            // 
            this.textBoxNewPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNewPass.Location = new System.Drawing.Point(251, 113);
            this.textBoxNewPass.Name = "textBoxNewPass";
            this.textBoxNewPass.Size = new System.Drawing.Size(212, 36);
            this.textBoxNewPass.TabIndex = 3;
            // 
            // labelNewPass
            // 
            this.labelNewPass.AutoSize = true;
            this.labelNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNewPass.Location = new System.Drawing.Point(40, 115);
            this.labelNewPass.Name = "labelNewPass";
            this.labelNewPass.Size = new System.Drawing.Size(188, 29);
            this.labelNewPass.TabIndex = 2;
            this.labelNewPass.Text = "New Password:";
            // 
            // textBoxConfirmPass
            // 
            this.textBoxConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxConfirmPass.Location = new System.Drawing.Point(293, 180);
            this.textBoxConfirmPass.Name = "textBoxConfirmPass";
            this.textBoxConfirmPass.Size = new System.Drawing.Size(212, 36);
            this.textBoxConfirmPass.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Confirm Password:";
            // 
            // buttonChangePass
            // 
            this.buttonChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangePass.Location = new System.Drawing.Point(313, 292);
            this.buttonChangePass.Name = "buttonChangePass";
            this.buttonChangePass.Size = new System.Drawing.Size(202, 41);
            this.buttonChangePass.TabIndex = 6;
            this.buttonChangePass.Text = "Change Password";
            this.buttonChangePass.UseVisualStyleBackColor = true;
            this.buttonChangePass.Click += new System.EventHandler(this.buttonChangePass_Click);
            // 
            // buttonCalcPassStrength
            // 
            this.buttonCalcPassStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalcPassStrength.Location = new System.Drawing.Point(581, 101);
            this.buttonCalcPassStrength.Name = "buttonCalcPassStrength";
            this.buttonCalcPassStrength.Size = new System.Drawing.Size(202, 62);
            this.buttonCalcPassStrength.TabIndex = 7;
            this.buttonCalcPassStrength.Text = "Calculate Password Strength";
            this.buttonCalcPassStrength.UseVisualStyleBackColor = true;
            this.buttonCalcPassStrength.Click += new System.EventHandler(this.buttonCalcPassStrength_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(812, 464);
            this.Controls.Add(this.buttonCalcPassStrength);
            this.Controls.Add(this.buttonChangePass);
            this.Controls.Add(this.textBoxConfirmPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNewPass);
            this.Controls.Add(this.labelNewPass);
            this.Controls.Add(this.textBoxOldPass);
            this.Controls.Add(this.labelOldPass);
            this.Name = "ChangePasswordForm";
            this.Text = "ChangePasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOldPass;
        private System.Windows.Forms.TextBox textBoxOldPass;
        private System.Windows.Forms.TextBox textBoxNewPass;
        private System.Windows.Forms.Label labelNewPass;
        private System.Windows.Forms.TextBox textBoxConfirmPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonChangePass;
        private System.Windows.Forms.Button buttonCalcPassStrength;
    }
}