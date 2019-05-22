using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

namespace Android_Emulator.Utility
{
    class PresetPool
    {
        private List<BindingList<string>> mPresets;
        public BindingList<string> Names { get; private set; }
        public int IndexOfCurrentPreset { get; private set; }
        public BindingList<string> ActivePreset => mPresets[IndexOfCurrentPreset];

        public PresetPool(string filePath)
        {
            FileHandler.LoadGroup(filePath, out BindingList<string> names, out mPresets);
            Names = names;

            if (mPresets.Count < 1)
            {
                mPresets.Add(new BindingList<string>());
                Names.Add("Default");
            }

            int index = FileHandler.LoadInteger("active.txt");
            SetActivePreset(index, false);
        }

        public bool AddToActivePreset(string name)
        {
            BindingList<string> active = ActivePreset;
            if (name == "" || active.Contains(name))
                return false;

            active.Add(name);
            FileHandler.SaveGroup("presets.txt", Names, mPresets);
            return true;
        }

        public bool RemoveFromActivePreset(int index)
        {
            BindingList<string> active = ActivePreset;
            if (index > active.Count - 1 || index < 0)
                return false;
            ActivePreset.RemoveAt(index);

            FileHandler.SaveGroup("presets.txt", Names, mPresets);
            return true;
        }

        public bool CreatePreset(string name, BindingList<string> items = null)
        {
            if (Names.Contains(name))
                return false;

            if (items == null)
                items = new BindingList<string>();

            Names.Add(name);
            mPresets.Add(items);

            SetActivePreset(Names.Count - 1);

            FileHandler.SaveGroup("presets.txt", Names, mPresets);
            return true;
        }

        public bool DeletePreset(string name)
        {
            if (Names.Count < 2)
                return false;

            int index = Names.IndexOf(name);
            if (index < 0)
                return false;

            Names.RemoveAt(index);
            mPresets.RemoveAt(index);

            SetActivePreset(Names.Count - 1);

            FileHandler.SaveGroup("presets.txt", Names, mPresets);
            return true;
        }

        public bool SetActivePreset(int index, bool save = true)
        {
            if (index < 0 || index > Names.Count - 1)
                return false;

            IndexOfCurrentPreset = index;
            if(save)
                FileHandler.SaveInteger("active.txt", IndexOfCurrentPreset);
            return true;
        }

    }
}
