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
    public partial class themes_manager : Form
    {
        public themes_manager()
        {
            InitializeComponent();
        }

        private void themes_manager_Load(object sender, EventArgs e)
        {
            SaveLoad.LoadToolsFromFile();
            themename_text.Items.Clear();
            toolname_text.Items.Clear();
            content_text.Items.Clear();
            themename_text.Text = "";
            toolname_text.Text = "";
            content_text.Text = "";
            flow_panel.Controls.Clear();

            foreach (Tool tool in Data.Tools)
            {
                toolname_text.Items.Add(tool.name);
            }
        }

        private void toolname_text_SelectedIndexChanged(object sender, EventArgs e)
        {
            themename_text.Items.Clear();
            themename_text.Text = "";
            content_text.Items.Clear();
            content_text.Text = "";
            foreach (Tool tool in Data.Tools)
            {
                if (tool.name == toolname_text.Text)
                {
                    foreach(InfoGlobal ig in tool.info)
                    {
                        themename_text.Items.Add(ig.theme);
                    }
                    break;
                }
            }
        }

        private void themename_text_SelectedIndexChanged(object sender, EventArgs e)
        {
            content_text.Items.Clear();
            content_text.Text = "";
            foreach (Tool tool in Data.Tools)
            {
                if (tool.name == toolname_text.Text)
                {
                    foreach (InfoGlobal ig in tool.info)
                    {
                        if (ig.theme == themename_text.Text)
                        {
                            foreach(InfoContent ic in ig.content)
                            {
                                content_text.Items.Add(ig.content.IndexOf(ic));
                            }
                            break;
                        }
                    }
                    break;
                }
            }
        }

        private void content_text_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Tool tool in Data.Tools)
            {
                if (tool.name == toolname_text.Text)
                {
                    foreach (InfoGlobal ig in tool.info)
                    {
                        if (ig.theme == themename_text.Text)
                        {
                            foreach (InfoContent ic in ig.content)
                            {
                                if (ig.content.IndexOf(ic) == content_text.SelectedIndex)
                                {
                                    render_information_in_panel(ig.content[content_text.SelectedIndex]);
                                    break;
                                }
                            }
                            break;
                        }
                    }
                    break;
                }
            }
            
        }
        private void render_information_in_panel(InfoContent content)
        {
            flow_panel.Controls.Clear();
            Label label = new Label();
            label.Text = content.text;
            label.AutoSize = true;
            label.Font = new Font("Calibri", 14, FontStyle.Regular);
            label.TextAlign = ContentAlignment.MiddleLeft;
            label.Margin = new Padding(0, 10, 0, 10);

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

        private void theme_delete_but_Click(object sender, EventArgs e)
        {
            InfoGlobal info_del = new InfoGlobal();
            foreach (Tool tool in Data.Tools)
            {
                if (tool.name == toolname_text.Text)
                {
                    foreach (InfoGlobal ig in tool.info)
                    {
                        if (ig.theme == themename_text.Text)
                        {
                            info_del = ig;
                            break;
                        }
                    }
                    break;
                }
            }

            for(int i = 0; i < Data.Tools.Count; i++)
            {
                if (Data.Tools[i].name == toolname_text.Text)
                {
                    Data.Tools[i].info.Remove(info_del);
                    break;
                }
            }
            SaveLoad.SaveToolsInFile();
            toolname_text_SelectedIndexChanged(new object(), new EventArgs());
        }

        private void content_delete_but_Click(object sender, EventArgs e)
        {
            InfoContent info_del = new InfoContent();
            foreach (Tool tool in Data.Tools)
            {
                if (tool.name == toolname_text.Text)
                {
                    foreach (InfoGlobal ig in tool.info)
                    {
                        if (ig.theme == themename_text.Text)
                        {
                            foreach (InfoContent ic in ig.content)
                            {
                                info_del = ic;
                            }
                            break;
                        }
                    }
                    break;
                }
            }

            for (int i = 0; i < Data.Tools.Count; i++)
            {
                if (Data.Tools[i].name == toolname_text.Text)
                {
                    for (int j = 0; j < Data.Tools[i].info.Count; j++)
                    {
                        if (Data.Tools[i].info[j].theme == themename_text.Text)
                        {
                            Data.Tools[i].info[j].content.Remove(info_del);
                            break;
                        }
                    }
                    break;
                }
            }
            SaveLoad.SaveToolsInFile();
            flow_panel.Controls.Clear();
            themename_text_SelectedIndexChanged(new object(), new EventArgs());
        }

        private void tool_delete_but_Click(object sender, EventArgs e)
        {
            Tool tool_del = new Tool();
            foreach (Tool tool in Data.Tools)
            {
                if (tool.name == toolname_text.Text)
                {
                    tool_del = tool;
                    break;
                }
            }
            Data.Tools.Remove(tool_del);
            SaveLoad.SaveToolsInFile();
            themes_manager_Load(new object(), new EventArgs());
        }
    }
}
