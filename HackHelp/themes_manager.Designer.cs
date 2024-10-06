namespace HackHelp
{
    partial class themes_manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(themes_manager));
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolname_text = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.themename_text = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.theme_delete_but = new System.Windows.Forms.Button();
            this.content_delete_but = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.content_text = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.theme_label = new System.Windows.Forms.Label();
            this.flow_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.tool_delete_but = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.toolname_text);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Calibri", 12F);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 36);
            this.panel2.TabIndex = 5;
            // 
            // toolname_text
            // 
            this.toolname_text.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolname_text.FormattingEnabled = true;
            this.toolname_text.Location = new System.Drawing.Point(80, 8);
            this.toolname_text.Name = "toolname_text";
            this.toolname_text.Size = new System.Drawing.Size(335, 23);
            this.toolname_text.TabIndex = 6;
            this.toolname_text.SelectedIndexChanged += new System.EventHandler(this.toolname_text_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Утилита: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.themename_text);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Calibri", 12F);
            this.panel1.Location = new System.Drawing.Point(12, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 36);
            this.panel1.TabIndex = 7;
            // 
            // themename_text
            // 
            this.themename_text.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.themename_text.FormattingEnabled = true;
            this.themename_text.Location = new System.Drawing.Point(80, 8);
            this.themename_text.Name = "themename_text";
            this.themename_text.Size = new System.Drawing.Size(335, 23);
            this.themename_text.TabIndex = 6;
            this.themename_text.SelectedIndexChanged += new System.EventHandler(this.themename_text_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тема: ";
            // 
            // theme_delete_but
            // 
            this.theme_delete_but.BackColor = System.Drawing.Color.IndianRed;
            this.theme_delete_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.theme_delete_but.FlatAppearance.BorderSize = 0;
            this.theme_delete_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.theme_delete_but.Location = new System.Drawing.Point(132, 19);
            this.theme_delete_but.Name = "theme_delete_but";
            this.theme_delete_but.Size = new System.Drawing.Size(120, 23);
            this.theme_delete_but.TabIndex = 8;
            this.theme_delete_but.Text = "Тему";
            this.theme_delete_but.UseVisualStyleBackColor = false;
            this.theme_delete_but.Click += new System.EventHandler(this.theme_delete_but_Click);
            // 
            // content_delete_but
            // 
            this.content_delete_but.BackColor = System.Drawing.Color.IndianRed;
            this.content_delete_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.content_delete_but.FlatAppearance.BorderSize = 0;
            this.content_delete_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.content_delete_but.Location = new System.Drawing.Point(258, 19);
            this.content_delete_but.Name = "content_delete_but";
            this.content_delete_but.Size = new System.Drawing.Size(120, 23);
            this.content_delete_but.TabIndex = 9;
            this.content_delete_but.Text = "Запись";
            this.content_delete_but.UseVisualStyleBackColor = false;
            this.content_delete_but.Click += new System.EventHandler(this.content_delete_but_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tool_delete_but);
            this.groupBox1.Controls.Add(this.content_delete_but);
            this.groupBox1.Controls.Add(this.theme_delete_but);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(19, 445);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 56);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Удалить";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.content_text);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Font = new System.Drawing.Font("Calibri", 12F);
            this.panel3.Location = new System.Drawing.Point(12, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(427, 36);
            this.panel3.TabIndex = 8;
            // 
            // content_text
            // 
            this.content_text.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.content_text.FormattingEnabled = true;
            this.content_text.Location = new System.Drawing.Point(80, 8);
            this.content_text.Name = "content_text";
            this.content_text.Size = new System.Drawing.Size(335, 23);
            this.content_text.TabIndex = 6;
            this.content_text.SelectedIndexChanged += new System.EventHandler(this.content_text_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F);
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(3, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Запись: ";
            // 
            // theme_label
            // 
            this.theme_label.AutoSize = true;
            this.theme_label.BackColor = System.Drawing.Color.Transparent;
            this.theme_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.theme_label.Location = new System.Drawing.Point(445, 13);
            this.theme_label.MaximumSize = new System.Drawing.Size(600, 0);
            this.theme_label.Name = "theme_label";
            this.theme_label.Size = new System.Drawing.Size(0, 19);
            this.theme_label.TabIndex = 12;
            this.theme_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flow_panel
            // 
            this.flow_panel.AutoScroll = true;
            this.flow_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flow_panel.Location = new System.Drawing.Point(445, 54);
            this.flow_panel.Name = "flow_panel";
            this.flow_panel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.flow_panel.Size = new System.Drawing.Size(604, 457);
            this.flow_panel.TabIndex = 11;
            this.flow_panel.WrapContents = false;
            // 
            // tool_delete_but
            // 
            this.tool_delete_but.BackColor = System.Drawing.Color.IndianRed;
            this.tool_delete_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tool_delete_but.FlatAppearance.BorderSize = 0;
            this.tool_delete_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tool_delete_but.Location = new System.Drawing.Point(6, 19);
            this.tool_delete_but.Name = "tool_delete_but";
            this.tool_delete_but.Size = new System.Drawing.Size(120, 23);
            this.tool_delete_but.TabIndex = 10;
            this.tool_delete_but.Text = "Утилиту";
            this.tool_delete_but.UseVisualStyleBackColor = false;
            this.tool_delete_but.Click += new System.EventHandler(this.tool_delete_but_Click);
            // 
            // themes_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1061, 522);
            this.Controls.Add(this.theme_label);
            this.Controls.Add(this.flow_panel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "themes_manager";
            this.Text = "HackHelp: Manager";
            this.Load += new System.EventHandler(this.themes_manager_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox toolname_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox themename_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button theme_delete_but;
        private System.Windows.Forms.Button content_delete_but;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox content_text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label theme_label;
        private System.Windows.Forms.FlowLayoutPanel flow_panel;
        private System.Windows.Forms.Button tool_delete_but;
    }
}