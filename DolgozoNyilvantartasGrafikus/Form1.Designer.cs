namespace DolgozoNyilvantartasGrafikus
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
            this.listBox_worker = new System.Windows.Forms.ListBox();
            this.groupBox_choseworker = new System.Windows.Forms.GroupBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_read = new System.Windows.Forms.Button();
            this.button_insert = new System.Windows.Forms.Button();
            this.numericUpDown_salary = new System.Windows.Forms.NumericUpDown();
            this.label_salary = new System.Windows.Forms.Label();
            this.label_position = new System.Windows.Forms.Label();
            this.textBox_position = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.groupBox_choseworker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_salary)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_worker
            // 
            this.listBox_worker.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_worker.FormattingEnabled = true;
            this.listBox_worker.Location = new System.Drawing.Point(0, 0);
            this.listBox_worker.Name = "listBox_worker";
            this.listBox_worker.Size = new System.Drawing.Size(195, 500);
            this.listBox_worker.TabIndex = 0;
            this.listBox_worker.SelectedIndexChanged += new System.EventHandler(this.listBox_Worker_SelectedIndexChanged);
            // 
            // groupBox_choseworker
            // 
            this.groupBox_choseworker.Controls.Add(this.textBox_name);
            this.groupBox_choseworker.Controls.Add(this.button_delete);
            this.groupBox_choseworker.Controls.Add(this.button_update);
            this.groupBox_choseworker.Controls.Add(this.button_read);
            this.groupBox_choseworker.Controls.Add(this.button_insert);
            this.groupBox_choseworker.Controls.Add(this.numericUpDown_salary);
            this.groupBox_choseworker.Controls.Add(this.label_salary);
            this.groupBox_choseworker.Controls.Add(this.label_position);
            this.groupBox_choseworker.Controls.Add(this.textBox_position);
            this.groupBox_choseworker.Controls.Add(this.label_name);
            this.groupBox_choseworker.Controls.Add(this.label_id);
            this.groupBox_choseworker.Controls.Add(this.textBox_id);
            this.groupBox_choseworker.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_choseworker.Location = new System.Drawing.Point(195, 0);
            this.groupBox_choseworker.Name = "groupBox_choseworker";
            this.groupBox_choseworker.Size = new System.Drawing.Size(305, 500);
            this.groupBox_choseworker.TabIndex = 1;
            this.groupBox_choseworker.TabStop = false;
            this.groupBox_choseworker.Text = "Kiválasztott dolgozó";
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(15, 449);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(73, 21);
            this.button_delete.TabIndex = 10;
            this.button_delete.Text = "törlés";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(15, 405);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(73, 21);
            this.button_update.TabIndex = 9;
            this.button_update.Text = "módósítás";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_read
            // 
            this.button_read.Location = new System.Drawing.Point(15, 360);
            this.button_read.Name = "button_read";
            this.button_read.Size = new System.Drawing.Size(73, 21);
            this.button_read.TabIndex = 8;
            this.button_read.Text = "olvasás";
            this.button_read.UseVisualStyleBackColor = true;
            this.button_read.Click += new System.EventHandler(this.button_read_Click);
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(15, 316);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(73, 21);
            this.button_insert.TabIndex = 7;
            this.button_insert.Text = "új";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // numericUpDown_salary
            // 
            this.numericUpDown_salary.Location = new System.Drawing.Point(19, 198);
            this.numericUpDown_salary.Name = "numericUpDown_salary";
            this.numericUpDown_salary.Size = new System.Drawing.Size(149, 20);
            this.numericUpDown_salary.TabIndex = 6;
            // 
            // label_salary
            // 
            this.label_salary.AutoSize = true;
            this.label_salary.Location = new System.Drawing.Point(16, 168);
            this.label_salary.Name = "label_salary";
            this.label_salary.Size = new System.Drawing.Size(37, 13);
            this.label_salary.TabIndex = 5;
            this.label_salary.Text = "fizetés";
            // 
            // label_position
            // 
            this.label_position.AutoSize = true;
            this.label_position.Location = new System.Drawing.Point(16, 243);
            this.label_position.Name = "label_position";
            this.label_position.Size = new System.Drawing.Size(42, 13);
            this.label_position.TabIndex = 3;
            this.label_position.Text = "pozicíó";
            // 
            // textBox_position
            // 
            this.textBox_position.Location = new System.Drawing.Point(19, 273);
            this.textBox_position.Name = "textBox_position";
            this.textBox_position.Size = new System.Drawing.Size(260, 20);
            this.textBox_position.TabIndex = 4;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(16, 81);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(25, 13);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "név";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(16, 28);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(15, 13);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "id";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(19, 44);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(106, 20);
            this.textBox_id.TabIndex = 0;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(21, 114);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(257, 20);
            this.textBox_name.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.groupBox_choseworker);
            this.Controls.Add(this.listBox_worker);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_choseworker.ResumeLayout(false);
            this.groupBox_choseworker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_salary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_worker;
        private System.Windows.Forms.GroupBox groupBox_choseworker;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label_position;
        private System.Windows.Forms.TextBox textBox_position;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_salary;
        private System.Windows.Forms.NumericUpDown numericUpDown_salary;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_read;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.TextBox textBox_name;
    }
}

