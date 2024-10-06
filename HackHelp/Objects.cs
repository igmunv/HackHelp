using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HackHelp
{
    public struct InfoGlobal
    {
        public string theme;
        public List<InfoContent> content;
    }
    public struct InfoContent
    {
        public string text;
        public string photo_path;
        public bool line;
    }

    public struct Tool
    {
        public int id;
        public string name;
        public List<InfoGlobal> info;
    }

    public static class Data
    {
        public static string folderPath = @"\database";
        public static string toolsfilePath = folderPath + @"\tools";
        public static List<Tool> Tools = new List<Tool>();
    }

    public static class Functions
    {
        public static void AddTool(List<Tool> tools, string tool_name)
        {
            /* Добавление утилиты */
            Tool t = new Tool();
            t.name = tool_name;
            if (tools != null)
            {
                t.id = tools.Count;
            }
            else
            {

                t.id = 0;
            }

            t.info = new List<InfoGlobal>();
            tools.Add(t);

            XmlSerializer serializer = new XmlSerializer(typeof(List<Tool>));
            using (StreamWriter writer = new StreamWriter(Program.my_directory + Data.toolsfilePath))
            {
                serializer.Serialize(writer, tools);
            }
            /* Добавление утилиты */
        }
    }

    public static class SaveLoad
    {
        public static void SaveToolsInFile()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Tool>));
            using (StreamWriter writer = new StreamWriter(Program.my_directory + Data.toolsfilePath))
            {
                serializer.Serialize(writer, Data.Tools);
            }
        }
        public static void LoadToolsFromFile()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Tool>));
                using (StreamReader reader = new StreamReader(Program.my_directory + Data.toolsfilePath))
                {
                    Data.Tools = (List<Tool>)serializer.Deserialize(reader);
                }
            }
            catch{

            }
        }
    }
}
