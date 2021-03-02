namespace minesweeper
{
    partial class customForm
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
            this.colLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.rawsCtor = new System.Windows.Forms.TextBox();
            this.mineLabel = new System.Windows.Forms.Label();
            this.colsCtor = new System.Windows.Forms.TextBox();
            this.mineCtor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // colLabel
            // 
            this.colLabel.AutoSize = true;
            this.colLabel.Location = new System.Drawing.Point(28, 28);
            this.colLabel.Name = "colLabel";
            this.colLabel.Size = new System.Drawing.Size(98, 17);
            this.colLabel.TabIndex = 0;
            this.colLabel.Text = "Кол-во строк:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Кол-во колонок:";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(136, 134);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(31, 134);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "ok";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // rawsCtor
            // 
            this.rawsCtor.Location = new System.Drawing.Point(162, 28);
            this.rawsCtor.Name = "rawsCtor";
            this.rawsCtor.Size = new System.Drawing.Size(49, 22);
            this.rawsCtor.TabIndex = 4;
            this.rawsCtor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rawsCtor_KeyPress);
            // 
            // mineLabel
            // 
            this.mineLabel.AutoSize = true;
            this.mineLabel.Location = new System.Drawing.Point(28, 98);
            this.mineLabel.Name = "mineLabel";
            this.mineLabel.Size = new System.Drawing.Size(86, 17);
            this.mineLabel.TabIndex = 5;
            this.mineLabel.Text = "Кол-во мин:";
            // 
            // colsCtor
            // 
            this.colsCtor.Location = new System.Drawing.Point(162, 63);
            this.colsCtor.Name = "colsCtor";
            this.colsCtor.Size = new System.Drawing.Size(49, 22);
            this.colsCtor.TabIndex = 6;
            // 
            // mineCtor
            // 
            this.mineCtor.Location = new System.Drawing.Point(162, 95);
            this.mineCtor.Name = "mineCtor";
            this.mineCtor.Size = new System.Drawing.Size(49, 22);
            this.mineCtor.TabIndex = 7;
            // 
            // customForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(234, 169);
            this.Controls.Add(this.mineCtor);
            this.Controls.Add(this.colsCtor);
            this.Controls.Add(this.mineLabel);
            this.Controls.Add(this.rawsCtor);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "customForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label colLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox rawsCtor;
        private System.Windows.Forms.Label mineLabel;
        private System.Windows.Forms.TextBox colsCtor;
        private System.Windows.Forms.TextBox mineCtor;
    }
}