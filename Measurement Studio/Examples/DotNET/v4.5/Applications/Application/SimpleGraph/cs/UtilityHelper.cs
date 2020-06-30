using System;
using System.Collections;
using System.Diagnostics;
using System.Windows.Forms;
using System.Resources;
using System.Text.RegularExpressions;

namespace NationalInstruments.Examples.SimpleGraph
{
    public class UtilityHelper
    {
        private Hashtable menuHelper;
        private ArrayList list;
        private string[] helperStrings;
        private string[] toolTips;
        private int helpIndex;

        public UtilityHelper()
        {
            menuHelper = new Hashtable();
            list = new ArrayList();
            helpIndex = 0;

            ResourceManager manager = new ResourceManager("NationalInstruments.Examples.SimpleGraph.Strings", typeof(MainForm).Assembly);
            helperStrings = ParseResource(manager.GetString("helperStrings"));
            toolTips = ParseResource(manager.GetString("toolTips"));
        }

        private string[] ParseResource(string temp)
        {
            Regex regex = new Regex(@"(\t| ){2,}");
            temp = regex.Replace(temp, "");
            return Regex.Split(temp, Environment.NewLine);
        }

        public void AddMenuString(object key)
        {
            Debug.Assert(helpIndex >= 0 && helpIndex < helperStrings.Length, "No menu helper string found for help index");
            menuHelper.Add(key, helperStrings[helpIndex]);
            helpIndex++;
        }

        public string GetMenuString(object key)
        {
            return menuHelper[key] as string;
        }

        public string GetToolTip(int index)
        {
            Debug.Assert(index >= 0 && index < toolTips.Length, "Specified index is not a valid tooltip index");
            return toolTips[index];
        }
        
        public void MapMenuAndToolBar(ToolBarButton button, MenuItem item)
        {
            list.Add(new Pair(button, item));
        }

        public MenuItem FromToolBarButton(ToolBarButton toolBarButton)
        {
            foreach(Pair pair in list)
            {
                if(pair.Button == toolBarButton)
                    return pair.Item;
            }

            Debug.Fail("Cannot find MenuItem from the ToolBarButton passed in");
            return null;
        }

        public ToolBarButton FromMenuItem(MenuItem menuItem)
        {
            foreach(Pair pair in list)
            {
                if(pair.Item == menuItem)
                    return pair.Button;
            }

            Debug.Fail("Cannot find ToolBarButton from the MenuItem passed in");
            return null;
        }
        
        private class Pair
        {
            private ToolBarButton _button;
            private MenuItem _item;

            public Pair(ToolBarButton button, MenuItem item)
            {
                _button = button;
                _item = item;
            }

            public ToolBarButton Button
            {
                get
                {
                    return _button;
                }
            }

            public MenuItem Item
            {
                get
                {
                    return _item;
                }
            }
        }
    }
}

