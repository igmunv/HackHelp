namespace HackHelp
{
    partial class main_form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.tools_list = new System.Windows.Forms.ListBox();
            this.theme_list = new System.Windows.Forms.ListBox();
            this.add_button = new System.Windows.Forms.Button();
            this.reload_button = new System.Windows.Forms.Button();
            this.flow_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.theme_label = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contex_menu_notify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseApp_contex_butt = new System.Windows.Forms.ToolStripMenuItem();
            this.contex_menu_text = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contex_menu_notify.SuspendLayout();
            this.contex_menu_text.SuspendLayout();
            this.SuspendLayout();
            // 
            // tools_list
            // 
            this.tools_list.BackColor = System.Drawing.Color.LightGray;
            this.tools_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tools_list.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tools_list.FormattingEnabled = true;
            this.tools_list.ItemHeight = 15;
            this.tools_list.Location = new System.Drawing.Point(12, 12);
            this.tools_list.Name = "tools_list";
            this.tools_list.Size = new System.Drawing.Size(187, 465);
            this.tools_list.TabIndex = 0;
            this.tools_list.SelectedIndexChanged += new System.EventHandler(this.tools_list_SelectedIndexChanged);
            // 
            // theme_list
            // 
            this.theme_list.BackColor = System.Drawing.Color.LightGray;
            this.theme_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.theme_list.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.theme_list.FormattingEnabled = true;
            this.theme_list.ItemHeight = 15;
            this.theme_list.Location = new System.Drawing.Point(205, 12);
            this.theme_list.Name = "theme_list";
            this.theme_list.Size = new System.Drawing.Size(234, 495);
            this.theme_list.TabIndex = 2;
            this.theme_list.SelectedIndexChanged += new System.EventHandler(this.theme_list_SelectedIndexChanged);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.LightGray;
            this.add_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_button.FlatAppearance.BorderSize = 0;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_button.Location = new System.Drawing.Point(12, 483);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(155, 24);
            this.add_button.TabIndex = 3;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // reload_button
            // 
            this.reload_button.BackColor = System.Drawing.Color.LightGray;
            this.reload_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.reload_button.FlatAppearance.BorderSize = 0;
            this.reload_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reload_button.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reload_button.Location = new System.Drawing.Point(173, 483);
            this.reload_button.Name = "reload_button";
            this.reload_button.Size = new System.Drawing.Size(26, 24);
            this.reload_button.TabIndex = 4;
            this.reload_button.Text = "↺";
            this.reload_button.UseVisualStyleBackColor = false;
            this.reload_button.Click += new System.EventHandler(this.reload_button_Click);
            // 
            // flow_panel
            // 
            this.flow_panel.AutoScroll = true;
            this.flow_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flow_panel.Location = new System.Drawing.Point(445, 50);
            this.flow_panel.Name = "flow_panel";
            this.flow_panel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.flow_panel.Size = new System.Drawing.Size(604, 457);
            this.flow_panel.TabIndex = 5;
            this.flow_panel.WrapContents = false;
            // 
            // theme_label
            // 
            this.theme_label.AutoSize = true;
            this.theme_label.BackColor = System.Drawing.Color.Transparent;
            this.theme_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.theme_label.Location = new System.Drawing.Point(445, 9);
            this.theme_label.MaximumSize = new System.Drawing.Size(600, 0);
            this.theme_label.Name = "theme_label";
            this.theme_label.Size = new System.Drawing.Size(0, 19);
            this.theme_label.TabIndex = 6;
            this.theme_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipTitle = "HackHelp";
            this.notifyIcon1.ContextMenuStrip = this.contex_menu_notify;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "HackHelp";
            this.notifyIcon1.Visible = true;
            // 
            // contex_menu_notify
            // 
            this.contex_menu_notify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.CloseApp_contex_butt});
            this.contex_menu_notify.Name = "contex_menu_notify";
            this.contex_menu_notify.Size = new System.Drawing.Size(122, 48);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // CloseApp_contex_butt
            // 
            this.CloseApp_contex_butt.BackColor = System.Drawing.SystemColors.Control;
            this.CloseApp_contex_butt.Name = "CloseApp_contex_butt";
            this.CloseApp_contex_butt.Size = new System.Drawing.Size(180, 22);
            this.CloseApp_contex_butt.Text = "Выйти";
            this.CloseApp_contex_butt.Click += new System.EventHandler(this.CloseApp_ToolStripMenuItem_Click);
            // 
            // contex_menu_text
            // 
            this.contex_menu_text.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem});
            this.contex_menu_text.Name = "contex_menu_text";
            this.contex_menu_text.ShowImageMargin = false;
            this.contex_menu_text.Size = new System.Drawing.Size(156, 48);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.CopyText_ToolStripMenuItem_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1061, 522);
            this.Controls.Add(this.theme_label);
            this.Controls.Add(this.flow_panel);
            this.Controls.Add(this.reload_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.theme_list);
            this.Controls.Add(this.tools_list);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "main_form";
            this.Text = "HackHelp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.main_form_SizeChanged);
            this.contex_menu_notify.ResumeLayout(false);
            this.contex_menu_text.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox tools_list;
        private System.Windows.Forms.ListBox theme_list;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button reload_button;
        private System.Windows.Forms.FlowLayoutPanel flow_panel;
        private System.Windows.Forms.Label theme_label;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contex_menu_notify;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseApp_contex_butt;
        private System.Windows.Forms.ContextMenuStrip contex_menu_text;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
    }
}

