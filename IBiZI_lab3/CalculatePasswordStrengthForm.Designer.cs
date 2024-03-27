
namespace IBiZI_lab3
{
    partial class CalculatePasswordStrengthForm
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
            this.labelSpeed = new System.Windows.Forms.Label();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.labelAttemptsThreshold = new System.Windows.Forms.Label();
            this.textBoxAttemptsThreshold = new System.Windows.Forms.TextBox();
            this.labelDelay = new System.Windows.Forms.Label();
            this.textBoxDelay = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpeed.Location = new System.Drawing.Point(12, 25);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(371, 29);
            this.labelSpeed.TabIndex = 0;
            this.labelSpeed.Text = "Скорость перебора в секунду:";
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSpeed.Location = new System.Drawing.Point(17, 70);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(189, 36);
            this.textBoxSpeed.TabIndex = 1;
            // 
            // labelAttemptsThreshold
            // 
            this.labelAttemptsThreshold.AutoSize = true;
            this.labelAttemptsThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAttemptsThreshold.Location = new System.Drawing.Point(12, 146);
            this.labelAttemptsThreshold.Name = "labelAttemptsThreshold";
            this.labelAttemptsThreshold.Size = new System.Drawing.Size(430, 29);
            this.labelAttemptsThreshold.TabIndex = 2;
            this.labelAttemptsThreshold.Text = "Количество неправильных попыток";
            // 
            // textBoxAttemptsThreshold
            // 
            this.textBoxAttemptsThreshold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAttemptsThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAttemptsThreshold.Location = new System.Drawing.Point(17, 190);
            this.textBoxAttemptsThreshold.Name = "textBoxAttemptsThreshold";
            this.textBoxAttemptsThreshold.Size = new System.Drawing.Size(189, 36);
            this.textBoxAttemptsThreshold.TabIndex = 3;
            // 
            // labelDelay
            // 
            this.labelDelay.AutoSize = true;
            this.labelDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDelay.Location = new System.Drawing.Point(12, 264);
            this.labelDelay.Name = "labelDelay";
            this.labelDelay.Size = new System.Drawing.Size(578, 29);
            this.labelDelay.TabIndex = 4;
            this.labelDelay.Text = "Пауза после неправильного ввода (в секундах):";
            // 
            // textBoxDelay
            // 
            this.textBoxDelay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDelay.Location = new System.Drawing.Point(17, 317);
            this.textBoxDelay.Name = "textBoxDelay";
            this.textBoxDelay.Size = new System.Drawing.Size(189, 36);
            this.textBoxDelay.TabIndex = 5;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.Location = new System.Drawing.Point(562, 376);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(169, 39);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // CalculatePasswordStrengthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxDelay);
            this.Controls.Add(this.labelDelay);
            this.Controls.Add(this.textBoxAttemptsThreshold);
            this.Controls.Add(this.labelAttemptsThreshold);
            this.Controls.Add(this.textBoxSpeed);
            this.Controls.Add(this.labelSpeed);
            this.Name = "CalculatePasswordStrengthForm";
            this.Text = "CalculatePasswordStrengthForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.Label labelAttemptsThreshold;
        private System.Windows.Forms.TextBox textBoxAttemptsThreshold;
        private System.Windows.Forms.Label labelDelay;
        private System.Windows.Forms.TextBox textBoxDelay;
        private System.Windows.Forms.Button buttonCalculate;
    }
}