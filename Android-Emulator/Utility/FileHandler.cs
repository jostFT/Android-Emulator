using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Android_Emulator.Utility
{
    public static class FileHandler
    {
        public static void SaveInteger(string path, int value)
        {
            File.WriteAllText(path, value.ToString());
        }

        public static void Save(string path, BindingList<string> list)
        {
            File.WriteAllLines("commands.txt", list.ToArray());
        }

        public static void SaveGroup(string path, BindingList<string> headers, List<BindingList<string>> list)
        {
            if (headers.Count != list.Count)
                return;

            string final = "";
            for(int i = 0; i < headers.Count; i++)
            {
                final += headers[i];
                for(int j = 0; j < list[i].Count; j++)
                    final += "¦" + list[i][j];
                final += "\n";
            }
            File.WriteAllText(path, final);
        }

        public static bool LoadGroup(string path, out BindingList<string> headers, out List<BindingList<string>> lists)
        {
            lists = new List<BindingList<string>>();
            headers = new BindingList<string>();

            if (!File.Exists(path))
                return false;
            try
            {
                string[] presets = File.ReadAllLines(path);
                for(int i = 0; i < presets.Length; i++)
                {
                    string[] presetData = presets[i].Split('¦');
                    if (presetData.Length < 1)
                        continue;

                    headers.Add(presetData[0]);
                    lists.Add(new BindingList<string>());
                    for (int j = 1; j < presetData.Length; j++)
                        lists[i].Add(presetData[j]);
                }
                return true;
            } catch(Exception error)
            {
                Debug.WriteLine("FILE_HANDLER_ERROR: ", error);
                return false;
            }
        }

        public static int LoadInteger(string path, int defaultValue = 0)
        {
            int value = defaultValue;

            if (!File.Exists(path))
                return value;
            try
            {
                string[] data = File.ReadAllLines(path);
                if (data.Length > 0)
                    value = int.Parse(data[0]);
            }
            catch (Exception error)
            {
                Debug.WriteLine("FILE_HANDLER_ERROR: ", error);
            }
            return value;
        }

        public static bool Load(string path, out BindingList<string> list)
        {
            list = new BindingList<string>();

            if (!File.Exists(path))
                return false;
            try
            {
                string[] data = File.ReadAllLines(path);
                foreach (string d in data)
                    list.Add(d);
                return true;
            }catch(Exception error)
            {
                Debug.WriteLine("FILE_HANDLER_ERROR: ", error);
                return false;
            }
        }
    }
}
