namespace лаб9
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

         #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Tom = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.record = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add = new System.Windows.Forms.Button();
            this.read = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.write = new System.Windows.Forms.Button();
            this.live = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(Tom)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.record)).BeginInit();
            this.SuspendLayout();
            // 
            // Tom
            // 

            Tom.AllowUserToAddRows = false;
            Tom.AllowUserToDeleteRows = false;
            Tom.AllowUserToResizeColumns = false;
            Tom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            Tom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Tom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Column1,
            Column4,
            col,
            Column2});
            Tom.Location = new System.Drawing.Point(773, 46);
            Tom.MultiSelect = false;
            Tom.Name = "Tom";
            Tom.RowHeadersVisible = false;
            Tom.RowHeadersWidth = 51;
            Tom.RowTemplate.Height = 24;
            Tom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            Tom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            Tom.ShowEditingIcon = false;
            Tom.Size = new System.Drawing.Size(345, 498);
            Tom.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 9.625671F;
            this.Column1.HeaderText = "Адрес";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 77;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 280.7487F;
            this.Column4.HeaderText = "Содержимое";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // col
            // 
            this.col.FillWeight = 9.625671F;
            this.col.HeaderText = "Use";
            this.col.MinimumWidth = 6;
            this.col.Name = "col";
            this.col.ReadOnly = true;
            this.col.Width = 62;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "№ MFT";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(817, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "TOM";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.Location = new System.Drawing.Point(118, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "$MFT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 41);
            this.button2.TabIndex = 9;
            this.button2.Text = " ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(210, 41);
            this.button3.TabIndex = 10;
            this.button3.Text = " ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 97);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(210, 41);
            this.button4.TabIndex = 11;
            this.button4.Text = " ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 144);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(210, 41);
            this.button5.TabIndex = 12;
            this.button5.Text = "   ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(3, 191);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(210, 41);
            this.button6.TabIndex = 13;
            this.button6.Text = " ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 238);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(210, 41);
            this.button7.TabIndex = 14;
            this.button7.Text = " ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(3, 285);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(210, 41);
            this.button8.TabIndex = 15;
            this.button8.Text = " ";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(3, 332);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(210, 41);
            this.button9.TabIndex = 16;
            this.button9.Text = " ";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Controls.Add(this.button7);
            this.flowLayoutPanel1.Controls.Add(this.button8);
            this.flowLayoutPanel1.Controls.Add(this.button9);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(118, 137);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(228, 381);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(71, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(200, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 31);
            this.label3.TabIndex = 19;
            this.label3.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(71, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 31);
            this.label4.TabIndex = 20;
            this.label4.Text = "23";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(71, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 31);
            this.label5.TabIndex = 21;
            this.label5.Text = "22";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(71, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 31);
            this.label6.TabIndex = 22;
            this.label6.Text = "21";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(71, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 31);
            this.label7.TabIndex = 23;
            this.label7.Text = "20";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(71, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 31);
            this.label8.TabIndex = 24;
            this.label8.Text = "19";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(71, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 31);
            this.label9.TabIndex = 25;
            this.label9.Text = "18";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(71, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 31);
            this.label10.TabIndex = 26;
            this.label10.Text = "17";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(71, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 31);
            this.label11.TabIndex = 27;
            this.label11.Text = "16";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(73, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 24);
            this.label12.TabIndex = 28;
            this.label12.Text = "MFT";
            // 
            // record
            // 
            this.record.AllowUserToAddRows = false;
            this.record.AllowUserToDeleteRows = false;
            this.record.AllowUserToResizeColumns = false;
            this.record.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.record.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.record.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.record.Location = new System.Drawing.Point(375, 46);
            this.record.MultiSelect = false;
            this.record.Name = "record";
            this.record.ReadOnly = true;
            this.record.RowHeadersVisible = false;
            this.record.RowHeadersWidth = 51;
            this.record.RowTemplate.Height = 24;
            this.record.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.record.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.record.ShowEditingIcon = false;
            this.record.Size = new System.Drawing.Size(378, 266);
            this.record.TabIndex = 29;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Атрибут";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Значение";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(173, 539);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(90, 30);
            this.add.TabIndex = 30;
            this.add.Text = "добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // read
            // 
            this.read.Location = new System.Drawing.Point(375, 404);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(90, 30);
            this.read.TabIndex = 31;
            this.read.Text = "открыть";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(663, 404);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(90, 30);
            this.delete.TabIndex = 32;
            this.delete.Text = "удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(567, 404);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(90, 30);
            this.change.TabIndex = 33;
            this.change.Text = "изменить";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // write
            // 
            this.write.Location = new System.Drawing.Point(471, 404);
            this.write.Name = "write";
            this.write.Size = new System.Drawing.Size(90, 30);
            this.write.TabIndex = 34;
            this.write.Text = "записать";
            this.write.UseVisualStyleBackColor = true;
            this.write.Click += new System.EventHandler(this.write_Click);
            // 
            // live
            // 
            this.live.Location = new System.Drawing.Point(501, 440);
            this.live.Name = "live";
            this.live.Size = new System.Drawing.Size(125, 30);
            this.live.TabIndex = 35;
            this.live.Text = "восстановить";
            this.live.UseVisualStyleBackColor = true;
            this.live.Click += new System.EventHandler(this.live_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(372, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 17);
            this.label13.TabIndex = 36;
            this.label13.Text = "ЗАПИСЬ MFT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 606);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.live);
            this.Controls.Add(this.write);
            this.Controls.Add(this.change);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.read);
            this.Controls.Add(this.add);
            this.Controls.Add(this.record);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(Tom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "NTFS";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(Tom)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.record)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView record;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button read;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button write;
        private System.Windows.Forms.Button live;
        private System.Windows.Forms.Label label13;
        public static System.Windows.Forms.DataGridView Tom;
    }
}

