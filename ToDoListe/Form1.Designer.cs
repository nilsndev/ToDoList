namespace ToDoListe
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.title_label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.HeaderToDo_panel = new System.Windows.Forms.Panel();
            this.toDO_header_label2 = new System.Windows.Forms.Label();
            this.clear_button3 = new System.Windows.Forms.Button();
            this.form_header_panel1 = new System.Windows.Forms.Panel();
            this.minimize_button1 = new System.Windows.Forms.Button();
            this.exit_button1 = new System.Windows.Forms.Button();
            this.load_button = new System.Windows.Forms.Button();
            this.add_button1 = new System.Windows.Forms.Button();
            this.HeaderToDo_panel.SuspendLayout();
            this.form_header_panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(377, 376);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(1164, 554);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // title_label1
            // 
            this.title_label1.Font = new System.Drawing.Font("MV Boli", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label1.Location = new System.Drawing.Point(13, 9);
            this.title_label1.Name = "title_label1";
            this.title_label1.Size = new System.Drawing.Size(616, 80);
            this.title_label1.TabIndex = 2;
            this.title_label1.Text = "World Best ToDoList App";
            this.title_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // HeaderToDo_panel
            // 
            this.HeaderToDo_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeaderToDo_panel.Controls.Add(this.toDO_header_label2);
            this.HeaderToDo_panel.Location = new System.Drawing.Point(377, 327);
            this.HeaderToDo_panel.Name = "HeaderToDo_panel";
            this.HeaderToDo_panel.Size = new System.Drawing.Size(1164, 49);
            this.HeaderToDo_panel.TabIndex = 1;
            this.HeaderToDo_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.HeaderToDo_panel_Paint);
            // 
            // toDO_header_label2
            // 
            this.toDO_header_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDO_header_label2.Location = new System.Drawing.Point(27, 0);
            this.toDO_header_label2.Name = "toDO_header_label2";
            this.toDO_header_label2.Size = new System.Drawing.Size(1284, 45);
            this.toDO_header_label2.TabIndex = 0;
            this.toDO_header_label2.Text = "test";
            this.toDO_header_label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clear_button3
            // 
            this.clear_button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button3.Image = global::ToDoListe.Properties.Resources.clear_image;
            this.clear_button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.clear_button3.Location = new System.Drawing.Point(633, 212);
            this.clear_button3.Name = "clear_button3";
            this.clear_button3.Size = new System.Drawing.Size(112, 95);
            this.clear_button3.TabIndex = 7;
            this.clear_button3.Text = "Clear";
            this.clear_button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.clear_button3.UseVisualStyleBackColor = true;
            this.clear_button3.Click += new System.EventHandler(this.clear_button3_Click);
            // 
            // form_header_panel1
            // 
            this.form_header_panel1.BackColor = System.Drawing.Color.Black;
            this.form_header_panel1.Controls.Add(this.minimize_button1);
            this.form_header_panel1.Controls.Add(this.exit_button1);
            this.form_header_panel1.Controls.Add(this.title_label1);
            this.form_header_panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.form_header_panel1.ForeColor = System.Drawing.Color.White;
            this.form_header_panel1.Location = new System.Drawing.Point(0, 0);
            this.form_header_panel1.Name = "form_header_panel1";
            this.form_header_panel1.Size = new System.Drawing.Size(1938, 100);
            this.form_header_panel1.TabIndex = 10;
            // 
            // minimize_button1
            // 
            this.minimize_button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize_button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.minimize_button1.BackgroundImage = global::ToDoListe.Properties.Resources.minimize_image;
            this.minimize_button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimize_button1.ForeColor = System.Drawing.Color.Black;
            this.minimize_button1.Location = new System.Drawing.Point(1778, 28);
            this.minimize_button1.Name = "minimize_button1";
            this.minimize_button1.Size = new System.Drawing.Size(53, 42);
            this.minimize_button1.TabIndex = 9;
            this.minimize_button1.UseVisualStyleBackColor = false;
            this.minimize_button1.Click += new System.EventHandler(this.minimize_button1_Click);
            // 
            // exit_button1
            // 
            this.exit_button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_button1.BackgroundImage = global::ToDoListe.Properties.Resources.exit_image;
            this.exit_button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_button1.ForeColor = System.Drawing.Color.Black;
            this.exit_button1.Location = new System.Drawing.Point(1849, 28);
            this.exit_button1.Name = "exit_button1";
            this.exit_button1.Size = new System.Drawing.Size(66, 42);
            this.exit_button1.TabIndex = 8;
            this.exit_button1.UseVisualStyleBackColor = true;
            this.exit_button1.Click += new System.EventHandler(this.exit_button1_Click);
            // 
            // load_button
            // 
            this.load_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_button.Image = global::ToDoListe.Properties.Resources.refresh_image;
            this.load_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.load_button.Location = new System.Drawing.Point(506, 212);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(112, 95);
            this.load_button.TabIndex = 5;
            this.load_button.Text = "Load";
            this.load_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // add_button1
            // 
            this.add_button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button1.Image = global::ToDoListe.Properties.Resources.add_image;
            this.add_button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.add_button1.Location = new System.Drawing.Point(377, 212);
            this.add_button1.Name = "add_button1";
            this.add_button1.Size = new System.Drawing.Size(112, 95);
            this.add_button1.TabIndex = 3;
            this.add_button1.Text = "Add";
            this.add_button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.add_button1.UseVisualStyleBackColor = true;
            this.add_button1.Click += new System.EventHandler(this.add_button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1938, 1048);
            this.Controls.Add(this.form_header_panel1);
            this.Controls.Add(this.clear_button3);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.HeaderToDo_panel);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.add_button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.HeaderToDo_panel.ResumeLayout(false);
            this.form_header_panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label title_label1;
        private System.Windows.Forms.Button add_button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.Panel HeaderToDo_panel;
        private System.Windows.Forms.Label toDO_header_label2;
        private System.Windows.Forms.Button clear_button3;
        private System.Windows.Forms.Button exit_button1;
        private System.Windows.Forms.Button minimize_button1;
        private System.Windows.Forms.Panel form_header_panel1;
    }
}

