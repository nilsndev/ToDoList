namespace ToDoListe.Forms
{
    partial class Add_Formcs
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
            this.description_textBox1 = new System.Windows.Forms.TextBox();
            this.title_label1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.save_button1 = new System.Windows.Forms.Button();
            this.canceL_button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.houer_numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houer_numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // description_textBox1
            // 
            this.description_textBox1.Location = new System.Drawing.Point(18, 185);
            this.description_textBox1.Multiline = true;
            this.description_textBox1.Name = "description_textBox1";
            this.description_textBox1.Size = new System.Drawing.Size(463, 250);
            this.description_textBox1.TabIndex = 0;
            this.description_textBox1.TextChanged += new System.EventHandler(this.description_textBox1_TextChanged);
            // 
            // title_label1
            // 
            this.title_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label1.Location = new System.Drawing.Point(219, 9);
            this.title_label1.Name = "title_label1";
            this.title_label1.Size = new System.Drawing.Size(262, 57);
            this.title_label1.TabIndex = 1;
            this.title_label1.Text = "Add Task";
            this.title_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title_label1.Click += new System.EventHandler(this.title_label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Task description";
            // 
            // save_button1
            // 
            this.save_button1.Location = new System.Drawing.Point(508, 225);
            this.save_button1.Name = "save_button1";
            this.save_button1.Size = new System.Drawing.Size(75, 55);
            this.save_button1.TabIndex = 3;
            this.save_button1.Text = "Save";
            this.save_button1.UseVisualStyleBackColor = true;
            this.save_button1.Click += new System.EventHandler(this.save_button1_Click);
            // 
            // canceL_button1
            // 
            this.canceL_button1.Location = new System.Drawing.Point(508, 321);
            this.canceL_button1.Name = "canceL_button1";
            this.canceL_button1.Size = new System.Drawing.Size(75, 55);
            this.canceL_button1.TabIndex = 4;
            this.canceL_button1.Text = "Cancel";
            this.canceL_button1.UseVisualStyleBackColor = true;
            this.canceL_button1.Click += new System.EventHandler(this.canceL_button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Task starts in";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(330, 92);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 22);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(386, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "minutes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(210, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "houers, and in";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // houer_numericUpDown2
            // 
            this.houer_numericUpDown2.Location = new System.Drawing.Point(154, 92);
            this.houer_numericUpDown2.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.houer_numericUpDown2.Name = "houer_numericUpDown2";
            this.houer_numericUpDown2.Size = new System.Drawing.Size(50, 22);
            this.houer_numericUpDown2.TabIndex = 9;
            this.houer_numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // Add_Formcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 457);
            this.Controls.Add(this.houer_numericUpDown2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.canceL_button1);
            this.Controls.Add(this.save_button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title_label1);
            this.Controls.Add(this.description_textBox1);
            this.Name = "Add_Formcs";
            this.Text = "Add_Formcs";
            this.Load += new System.EventHandler(this.Add_Formcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houer_numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox description_textBox1;
        private System.Windows.Forms.Label title_label1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save_button1;
        private System.Windows.Forms.Button canceL_button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown houer_numericUpDown2;
    }
}