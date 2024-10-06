using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Serialization;
using static HackHelp.add_tool_form;

namespace HackHelp
{
    public partial class add_form : Form
    {

        string folderPath = @"\database";
        string toolsfilePath;

        public add_form()
        {
            toolsfilePath = folderPath + @"\tools";
            InitializeComponent();
        }

        public void UpdateAllData()
        {
            /* Обновление списка tools */
            try
            {
                tools_combobox.Text = "";
                tools_combobox.Items.Clear();

                SaveLoad.LoadToolsFromFile();

                for (int i = 0; i < Data.Tools.Count; i++)
                {
                    tools_combobox.Items.Add(Data.Tools[i].name);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка десериализации! Проверьте файл 'tools'.");
            }
            /* Обновление списка tools */
        }

        private void selectphoto_button_Click(object sender, EventArgs e)
        {

            // надо чтобы копировалось в директорию /images/

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files(*.PNG;*.JPG;*.GIF)|*.PNG;*.JPG;*.GIF|All files (*.*)|*.*";
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file_path = fileDialog.FileName;
                photodir_label.Text = file_path;
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(theme_textbox.Text) || string.IsNullOrEmpty(tools_combobox.Text) || string.IsNullOrEmpty(text_textbox.Text))
            {
                MessageBox.Show("Введите данные", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool est_ili_net = false;
                int idt = 0;
                for (int i = 0; i < Data.Tools.Count; i++)
                {
                    if (Data.Tools[i].name == tools_combobox.Text) { idt = i; est_ili_net = true; break; }
                }

                if (!est_ili_net)
                {
                    Functions.AddTool(Data.Tools, tools_combobox.Text);
                    UpdateAllData();
                    idt = Data.Tools.Count-1;
                }

                /* Фото */
                string file_path = photodir_label.Text;
                string end_path = "";
                if (!string.IsNullOrEmpty(file_path))
                {
                    string new_file_path = Path.GetFileName(file_path);

                    if (!Directory.Exists(Program.my_directory + Data.folderPath + @"\images\"))
                    {
                        Directory.CreateDirectory(Program.my_directory + Data.folderPath + @"\images\");
                    }

                    while (File.Exists(Program.my_directory + Data.folderPath + @"\images\" + new_file_path))
                    {
                        // уже существует
                        Random r = new Random();
                        int rand = r.Next(int.MaxValue);
                        new_file_path = rand.ToString() + new_file_path;
                    }

                    File.Copy(file_path, Program.my_directory + Data.folderPath + @"\images\" + new_file_path);
                    end_path = Data.folderPath + @"\images\" + new_file_path;
                }

                /* Фото */

                InfoContent cont = new InfoContent()
                {
                    text = text_textbox.Text,
                    photo_path = end_path,
                    line = line_check.Checked
                };

                if (Data.Tools[idt].info.Count > 0)
                {
                    int tools_count = Data.Tools[idt].info.Count;
                    for (int i = 0; i < tools_count; i++)
                    {
                        if (Data.Tools[idt].info[i].theme == theme_textbox.Text)
                        {
                            Data.Tools[idt].info[i].content.Add(cont);
                            break;
                        }
                        else
                        {
                            if (i == (tools_count-1))
                            {
                                // если последний эллемент и ничего не нашли - то создаем новую тему
                                InfoGlobal glob = new InfoGlobal()
                                {
                                    theme = theme_textbox.Text,
                                    content = new List<InfoContent>()
                                };
                                glob.content.Add(cont);
                                Data.Tools[idt].info.Add(glob);
                            }
                        }

                    }
                }
                else
                {
                    // нет тем у данной утилиты
                    InfoGlobal glob = new InfoGlobal()
                    {
                        theme = theme_textbox.Text,
                        content = new List<InfoContent>()
                    };
                    glob.content.Add(cont);
                    Data.Tools[idt].info.Add(glob);
                        
                }

                SaveLoad.SaveToolsInFile();

                list_input_info.Items.Add(Data.Tools[idt].name + " : " + theme_textbox.Text);
                

                theme_textbox.Text = "";
                tools_combobox.Text = "";
                text_textbox.Text = "";
                photodir_label.Text = "";
                line_check.Checked = false;
            }
        }

        private void save_info_button_Click(object sender, EventArgs e)
        {
            // доделать
        }

        private void add_tool_but_Click(object sender, EventArgs e)
        {
            add_tool_form _addtform = new add_tool_form();
            _addtform.Show();
        }

        private void add_form_Load(object sender, EventArgs e)
        {
            af = this;
            if (!Directory.Exists(Program.my_directory + folderPath))
            {
                // Директория не существует
                Directory.CreateDirectory(Program.my_directory + folderPath);
                Data.Tools = new List<Tool>();
            }

            // Файл tools
            if (!File.Exists(Program.my_directory + toolsfilePath))
            {
                // не существует
                Data.Tools = new List<Tool>();
            }

            UpdateAllData();
        }

        private void tools_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // здесь будут меняться данные в theme combobox в зависимости от tool
            // будут записываться данные которые есть у определенного tool
            theme_textbox.Items.Clear();

            foreach (Tool tool in Data.Tools)
            {
                if (tool.name == tools_combobox.Text) {
                    foreach (InfoGlobal inf in tool.info)
                    {
                        theme_textbox.Items.Add(inf.theme);
                    }
                    break;
                }
            }
        }

        private void add_form_SizeChanged(object sender, EventArgs e)
        {
            this.Size = new Size(1077, 561);
        }

        private void manager_themes_but_Click(object sender, EventArgs e)
        {
            themes_manager tm = new themes_manager();
            tm.Show();
        }

        private void tools_combobox_TextChanged(object sender, EventArgs e)
        {
            tools_combobox_SelectedIndexChanged(sender, e);
        }
    }
}
