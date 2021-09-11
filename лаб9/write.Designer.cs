namespace лаб9
{
    partial class write
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(write));
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrior = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Записать";
            // 
            // textBoxPrior
            // 
            this.textBoxPrior.Location = new System.Drawing.Point(61, 55);
            this.textBoxPrior.MaxLength = 80;
            this.textBoxPrior.Name = "textBoxPrior";
            this.textBoxPrior.Size = new System.Drawing.Size(160, 22);
            this.textBoxPrior.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 33);
            this.button1.TabIndex = 29;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // write
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 183);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPrior);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "write";
            this.Text = "Ввести данные";
            this.Load += new System.EventHandler(this.write_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPrior;
        private System.Windows.Forms.Button button1;
    }
}