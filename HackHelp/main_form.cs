using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackHelp
{ 
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTools();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            add_form _addform = new add_form();
            _addform.Show();
        }

        private void LoadTools()
        {
            SaveLoad.LoadToolsFromFile();
            tools_list.Items.Clear();
            theme_list.Items.Clear();
            flow_panel.Controls.Clear();
            theme_label.Text = "";
            for (int i = 0; i < Data.Tools.Count; i++)
            {
                tools_list.Items.Add(Data.Tools[i].name);
            }
        }

        private void render_information_in_panel(List<InfoContent> contents)
        {
            flow_panel.Controls.Clear();
            foreach (InfoContent content in contents)
            {
                Label label = new Label();
                label.Text = content.text;
                label.AutoSize = true;
                label.Font = new Font("Calibri", 14, FontStyle.Regular);
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Margin = new Padding(0, 10, 0, 10);
                label.ContextMenuStrip = contex_menu_text;

                PictureBox pictureBox = new PictureBox();
                if (!string.IsNullOrEmpty(content.photo_path))
                {
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Size = new Size(580, 580);
                    pictureBox.ImageLocation = Program.my_directory + content.photo_path;
                }

                Panel line = new Panel();
                if (content.line)
                {
                    line.BackColor = Color.LightGray;
                    line.Size = new Size(580, 1);
                }

                if (content.line) flow_panel.Controls.Add(line);
                flow_panel.Controls.Add(label);
                if (!string.IsNullOrEmpty(content.photo_path)) flow_panel.Controls.Add(pictureBox);
                if (content.line) flow_panel.Controls.Add(line);
            }
        }

        private void tools_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            theme_list.Items.Clear();
            foreach (Tool tool in Data.Tools)
            {
                if (tool.name == tools_list.Text)
                {
                    foreach (InfoGlobal inf in tool.info)
                    {
                        theme_list.Items.Add(inf.theme);
                    }
                    break;
                }
            }
        }

        private void theme_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveLoad.LoadToolsFromFile();
            foreach (Tool tool in Data.Tools)
            {
                if(tool.name == tools_list.Text)
                {
                    foreach (InfoGlobal inf in tool.info)
                    {
                        if (inf.theme == theme_list.Text)
                        {
                            theme_label.Text = inf.theme;
                            render_information_in_panel(inf.content);
                            break;
                        }
                    }
                    break;
                }
            }
        }

        private void main_form_SizeChanged(object sender, EventArgs e)
        {
            this.Size = new Size(1077, 561);
        }

        private void reload_button_Click(object sender, EventArgs e)
        {
            LoadTools();
        }

        private void CloseApp_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CopyText_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem item = sender as ToolStripItem;

            if (item.Owner is ContextMenuStrip)
            {
                ContextMenuStrip menuStrip = item.Owner as ContextMenuStrip;

                Control parentControl = menuStrip.SourceControl;

                if (parentControl is Label)
                {
                    Label label = parentControl as Label;
                    Clipboard.SetText(label.Text);
                }
            }
        }
    }
}
