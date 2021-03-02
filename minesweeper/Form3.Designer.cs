namespace minesweeper
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.beginerLabel = new System.Windows.Forms.Label();
            this.intermediateLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.proffesionalLabel = new System.Windows.Forms.Label();
            this.beginerTime = new System.Windows.Forms.Label();
            this.intermediateTime = new System.Windows.Forms.Label();
            this.profTime = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сложность";
            // 
            // beginerLabel
            // 
            this.beginerLabel.AutoSize = true;
            this.beginerLabel.Location = new System.Drawing.Point(12, 63);
            this.beginerLabel.Name = "beginerLabel";
            this.beginerLabel.Size = new System.Drawing.Size(64, 17);
            this.beginerLabel.TabIndex = 1;
            this.beginerLabel.Text = "Новичок";
            // 
            // intermediateLabel
            // 
            this.intermediateLabel.AutoSize = true;
            this.intermediateLabel.Location = new System.Drawing.Point(12, 98);
            this.intermediateLabel.Name = "intermediateLabel";
            this.intermediateLabel.Size = new System.Drawing.Size(74, 17);
            this.intermediateLabel.TabIndex = 2;
            this.intermediateLabel.Text = "Любитель";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(127, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Время";
            // 
            // proffesionalLabel
            // 
            this.proffesionalLabel.AutoSize = true;
            this.proffesionalLabel.Location = new System.Drawing.Point(12, 133);
            this.proffesionalLabel.Name = "proffesionalLabel";
            this.proffesionalLabel.Size = new System.Drawing.Size(100, 17);
            this.proffesionalLabel.TabIndex = 4;
            this.proffesionalLabel.Text = "Професионал";
            // 
            // beginerTime
            // 
            this.beginerTime.AutoSize = true;
            this.beginerTime.Location = new System.Drawing.Point(138, 63);
            this.beginerTime.Name = "beginerTime";
            this.beginerTime.Size = new System.Drawing.Size(84, 17);
            this.beginerTime.TabIndex = 5;
            this.beginerTime.Text = "beginerTimr";
            // 
            // intermediateTime
            // 
            this.intermediateTime.AutoSize = true;
            this.intermediateTime.Location = new System.Drawing.Point(138, 98);
            this.intermediateTime.Name = "intermediateTime";
            this.intermediateTime.Size = new System.Drawing.Size(117, 17);
            this.intermediateTime.TabIndex = 6;
            this.intermediateTime.Text = "intermediateTime";
            // 
            // profTime
            // 
            this.profTime.AutoSize = true;
            this.profTime.Location = new System.Drawing.Point(138, 134);
            this.profTime.Name = "profTime";
            this.profTime.Size = new System.Drawing.Size(104, 17);
            this.profTime.TabIndex = 7;
            this.profTime.Text = "profesionaltime";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Сбросить рекорды";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 183);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.profTime);
            this.Controls.Add(this.intermediateTime);
            this.Controls.Add(this.beginerTime);
            this.Controls.Add(this.proffesionalLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.intermediateLabel);
            this.Controls.Add(this.beginerLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label beginerLabel;
        private System.Windows.Forms.Label intermediateLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label proffesionalLabel;
        private System.Windows.Forms.Label beginerTime;
        private System.Windows.Forms.Label intermediateTime;
        private System.Windows.Forms.Label profTime;
        private System.Windows.Forms.Button button1;
    }
}