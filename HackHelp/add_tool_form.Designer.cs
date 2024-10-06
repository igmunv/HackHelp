namespace HackHelp
{
    partial class add_tool_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_tool_form));
            this.add_tool_but = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rem_tool_but = new System.Windows.Forms.Button();
            this.toolname_text = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // add_tool_but
            // 
            this.add_tool_but.BackColor = System.Drawing.Color.LightGray;
            this.add_tool_but.FlatAppearance.BorderSize = 0;
            this.add_tool_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_tool_but.Location = new System.Drawing.Point(163, 100);
            this.add_tool_but.Name = "add_tool_but";
            this.add_tool_but.Size = new System.Drawing.Size(75, 23);
            this.add_tool_but.TabIndex = 0;
            this.add_tool_but.Text = "Добавить";
            this.add_tool_but.UseVisualStyleBackColor = false;
            this.add_tool_but.Click += new System.EventHandler(this.add_tool_but_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.toolname_text);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Calibri", 12F);
            this.panel2.Location = new System.Drawing.Point(12, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 36);
            this.panel2.TabIndex = 4;
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
            // rem_tool_but
            // 
            this.rem_tool_but.BackColor = System.Drawing.Color.IndianRed;
            this.rem_tool_but.FlatAppearance.BorderSize = 0;
            this.rem_tool_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rem_tool_but.Location = new System.Drawing.Point(244, 100);
            this.rem_tool_but.Name = "rem_tool_but";
            this.rem_tool_but.Size = new System.Drawing.Size(75, 23);
            this.rem_tool_but.TabIndex = 5;
            this.rem_tool_but.Text = "Удалить";
            this.rem_tool_but.UseVisualStyleBackColor = false;
            this.rem_tool_but.Click += new System.EventHandler(this.rem_tool_but_Click);
            // 
            // toolname_text
            // 
            this.toolname_text.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolname_text.FormattingEnabled = true;
            this.toolname_text.Location = new System.Drawing.Point(80, 8);
            this.toolname_text.Name = "toolname_text";
            this.toolname_text.Size = new System.Drawing.Size(372, 23);
            this.toolname_text.TabIndex = 6;
            // 
            // add_tool_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(492, 146);
            this.Controls.Add(this.rem_tool_but);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.add_tool_but);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "add_tool_form";
            this.Text = "HackHelp: Add Tool";
            this.Load += new System.EventHandler(this.add_tool_form_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_tool_but;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button rem_tool_but;
        private System.Windows.Forms.ComboBox toolname_text;
    }
}