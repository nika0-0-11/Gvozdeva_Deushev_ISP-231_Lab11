namespace Typing_Game
{
    partial class Form1
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
            this.correctLabel = new System.Windows.Forms.Label();
            this.incorrectLabel = new System.Windows.Forms.Label();
            this.textLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // correctLabel
            // 
            this.correctLabel.AutoSize = true;
            this.correctLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.correctLabel.Location = new System.Drawing.Point(33, 68);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(195, 25);
            this.correctLabel.TabIndex = 0;
            this.correctLabel.Text = "Правильных слов: 0";
            this.correctLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // incorrectLabel
            // 
            this.incorrectLabel.AutoSize = true;
            this.incorrectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.incorrectLabel.Location = new System.Drawing.Point(309, 68);
            this.incorrectLabel.Name = "incorrectLabel";
            this.incorrectLabel.Size = new System.Drawing.Size(216, 25);
            this.incorrectLabel.TabIndex = 1;
            this.incorrectLabel.Text = "Неправильных слов: 0";
            this.incorrectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLabel.Location = new System.Drawing.Point(229, 188);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(69, 25);
            this.textLabel.TabIndex = 2;
            this.textLabel.Text = "Слово";
            this.textLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(88, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(378, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Нажмите Enter чтобы ввести слово";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(161, 246);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(208, 20);
            this.inputBox.TabIndex = 4;
            this.inputBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 358);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.incorrectLabel);
            this.Controls.Add(this.correctLabel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Typing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label correctLabel;
        private System.Windows.Forms.Label incorrectLabel;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputBox;
    }
}

