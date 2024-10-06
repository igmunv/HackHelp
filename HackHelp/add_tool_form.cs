using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using static HackHelp.add_tool_form;

namespace HackHelp
{
    public partial class add_tool_form : Form
    {

        public static add_form af;

        public add_tool_form()
        {
            InitializeComponent();
        }
        
        private void add_tool_but_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(toolname_text.Text))
            {
                MessageBox.Show("Введите данные", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool povtor = false;
                for (int i = 0; i < Data.Tools.Count; i++)
                {
                    if (Data.Tools[i].name == toolname_text.Text) { povtor = true; break; }
                }
                if (povtor)
                {
                    MessageBox.Show("Такая утилита уже записана!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Functions.AddTool(Data.Tools, toolname_text.Text);
                    UpdateInformationInComboBox();
                    af.UpdateAllData();

                    MessageBox.Show("Утилита добавлена", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }

        private void add_tool_form_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(Program.my_directory + Data.folderPath))
            { 
                // Директория не существует
                Directory.CreateDirectory(Program.my_directory + Data.folderPath);
                Data.Tools = new List<Tool>();
            }
            if (!File.Exists(Program.my_directory + Data.toolsfilePath))
            {
                // не существует
                Data.Tools =  new List<Tool>();
            }
            else
            {
                UpdateInformationInComboBox();
            }
            
            
        }

        private void rem_tool_but_Click(object sender, EventArgs e)
        {
            bool est_ili_net = false;
            for (int i = 0; i < Data.Tools.Count; i++)
            {
                if (Data.Tools[i].name == toolname_text.Text) 
                {
                    est_ili_net = true;
                    Data.Tools.Remove(Data.Tools[i]);

                    for (int j = 0; j < Data.Tools.Count; j++)
                    {
                        Tool temp_tool = Data.Tools[j];
                        temp_tool.id = j;
                        Data.Tools[j] = temp_tool;
                    }

                    SaveLoad.SaveToolsInFile();
                    UpdateInformationInComboBox();
                    af.UpdateAllData();

                    MessageBox.Show("Утилита удалена", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break; 
                }
            }
            if (!est_ili_net) { 
                MessageBox.Show("Такой утилиты нет!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateInformationInComboBox()
        {
            try
            {
                toolname_text.Text = "";
                toolname_text.Items.Clear();
                SaveLoad.LoadToolsFromFile();

                for (int i = 0; i < Data.Tools.Count; i++)
                {
                    toolname_text.Items.Add(Data.Tools[i].name);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка десериализации! Проверьте файл 'tools'.");
            }
        }
    }
}
