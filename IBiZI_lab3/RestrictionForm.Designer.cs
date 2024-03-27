
namespace IBiZI_lab3
{
    partial class RestrictionForm
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
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.checkBoxDigits = new System.Windows.Forms.CheckBox();
            this.checkBoxSymbols = new System.Windows.Forms.CheckBox();
            this.checkBoxUpperCase = new System.Windows.Forms.CheckBox();
            this.textBoxLenght = new System.Windows.Forms.TextBox();
            this.labelLength = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUsername.Location = new System.Drawing.Point(12, 21);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(137, 29);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Username:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUsername.Location = new System.Drawing.Point(172, 19);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(228, 36);
            this.textBoxUsername.TabIndex = 2;
            // 
            // checkBoxDigits
            // 
            this.checkBoxDigits.AutoSize = true;
            this.checkBoxDigits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDigits.Location = new System.Drawing.Point(33, 89);
            this.checkBoxDigits.Name = "checkBoxDigits";
            this.checkBoxDigits.Size = new System.Drawing.Size(93, 28);
            this.checkBoxDigits.TabIndex = 3;
            this.checkBoxDigits.Text = "Цифры";
            this.checkBoxDigits.UseVisualStyleBackColor = true;
            this.checkBoxDigits.CheckedChanged += new System.EventHandler(this.checkBoxDigits_CheckedChanged);
            // 
            // checkBoxSymbols
            // 
            this.checkBoxSymbols.AutoSize = true;
            this.checkBoxSymbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxSymbols.Location = new System.Drawing.Point(33, 149);
            this.checkBoxSymbols.Name = "checkBoxSymbols";
            this.checkBoxSymbols.Size = new System.Drawing.Size(162, 28);
            this.checkBoxSymbols.TabIndex = 4;
            this.checkBoxSymbols.Text = "Спец символы";
            this.checkBoxSymbols.UseVisualStyleBackColor = true;
            this.checkBoxSymbols.CheckedChanged += new System.EventHandler(this.checkBoxSymbols_CheckedChanged);
            // 
            // checkBoxUpperCase
            // 
            this.checkBoxUpperCase.AutoSize = true;
            this.checkBoxUpperCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxUpperCase.Location = new System.Drawing.Point(33, 210);
            this.checkBoxUpperCase.Name = "checkBoxUpperCase";
            this.checkBoxUpperCase.Size = new System.Drawing.Size(188, 28);
            this.checkBoxUpperCase.TabIndex = 5;
            this.checkBoxUpperCase.Text = "Заглавные буквы";
            this.checkBoxUpperCase.UseVisualStyleBackColor = true;
            this.checkBoxUpperCase.CheckedChanged += new System.EventHandler(this.checkBoxUpperCase_CheckedChanged);
            // 
            // textBoxLenght
            // 
            this.textBoxLenght.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLenght.Location = new System.Drawing.Point(33, 329);
            this.textBoxLenght.Name = "textBoxLenght";
            this.textBoxLenght.Size = new System.Drawing.Size(227, 28);
            this.textBoxLenght.TabIndex = 6;
            this.textBoxLenght.TextChanged += new System.EventHandler(this.textBoxLenght_TextChanged);
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLength.Location = new System.Drawing.Point(29, 276);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(519, 24);
            this.labelLength.TabIndex = 7;
            this.labelLength.Text = "Длина пароля (если не указано, то пароль любой длины)";
            // 
            // RestrictionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.textBoxLenght);
            this.Controls.Add(this.checkBoxUpperCase);
            this.Controls.Add(this.checkBoxSymbols);
            this.Controls.Add(this.checkBoxDigits);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelUsername);
            this.Name = "RestrictionForm";
            this.Text = "RestrictionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.CheckBox checkBoxDigits;
        private System.Windows.Forms.CheckBox checkBoxSymbols;
        private System.Windows.Forms.CheckBox checkBoxUpperCase;
        private System.Windows.Forms.TextBox textBoxLenght;
        private System.Windows.Forms.Label labelLength;
    }
}