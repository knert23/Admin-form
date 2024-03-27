
namespace IBiZI_lab3
{
    partial class HackPassForm
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
            this.labelDictAttack = new System.Windows.Forms.Label();
            this.buttonDictHack = new System.Windows.Forms.Button();
            this.labelBruteForce = new System.Windows.Forms.Label();
            this.buttonBruteForceHack = new System.Windows.Forms.Button();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelDictAttack
            // 
            this.labelDictAttack.AutoSize = true;
            this.labelDictAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDictAttack.Location = new System.Drawing.Point(22, 24);
            this.labelDictAttack.Name = "labelDictAttack";
            this.labelDictAttack.Size = new System.Drawing.Size(443, 29);
            this.labelDictAttack.TabIndex = 0;
            this.labelDictAttack.Text = "Подбор пароля с помощью словаря:";
            // 
            // buttonDictHack
            // 
            this.buttonDictHack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDictHack.Location = new System.Drawing.Point(27, 78);
            this.buttonDictHack.Name = "buttonDictHack";
            this.buttonDictHack.Size = new System.Drawing.Size(152, 31);
            this.buttonDictHack.TabIndex = 1;
            this.buttonDictHack.Text = "Hack";
            this.buttonDictHack.UseVisualStyleBackColor = true;
            this.buttonDictHack.Click += new System.EventHandler(this.buttonDictHack_Click);
            // 
            // labelBruteForce
            // 
            this.labelBruteForce.AutoSize = true;
            this.labelBruteForce.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBruteForce.Location = new System.Drawing.Point(22, 149);
            this.labelBruteForce.Name = "labelBruteForce";
            this.labelBruteForce.Size = new System.Drawing.Size(467, 29);
            this.labelBruteForce.TabIndex = 2;
            this.labelBruteForce.Text = "Подбор пароля с помощью brute force:";
            // 
            // buttonBruteForceHack
            // 
            this.buttonBruteForceHack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBruteForceHack.Location = new System.Drawing.Point(27, 207);
            this.buttonBruteForceHack.Name = "buttonBruteForceHack";
            this.buttonBruteForceHack.Size = new System.Drawing.Size(152, 31);
            this.buttonBruteForceHack.TabIndex = 3;
            this.buttonBruteForceHack.Text = "Hack";
            this.buttonBruteForceHack.UseVisualStyleBackColor = true;
            this.buttonBruteForceHack.Click += new System.EventHandler(this.buttonBruteForceHack_Click);
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPass.Location = new System.Drawing.Point(22, 296);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(273, 29);
            this.labelPass.TabIndex = 4;
            this.labelPass.Text = "Подобранный пароль:";
            // 
            // textBoxPass
            // 
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPass.Location = new System.Drawing.Point(27, 351);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(242, 36);
            this.textBoxPass.TabIndex = 5;
            // 
            // HackPassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.buttonBruteForceHack);
            this.Controls.Add(this.labelBruteForce);
            this.Controls.Add(this.buttonDictHack);
            this.Controls.Add(this.labelDictAttack);
            this.Name = "HackPassForm";
            this.Text = "HackPassForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HackPassForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDictAttack;
        private System.Windows.Forms.Button buttonDictHack;
        private System.Windows.Forms.Label labelBruteForce;
        private System.Windows.Forms.Button buttonBruteForceHack;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textBoxPass;
    }
}