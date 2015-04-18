using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISE
{
    public class ActionData
    {
        public string name;
        private List<string> actionFrames;

        public List<string> getActionFrames()
        {
            if (actionFrames == null)
                actionFrames = new List<string>();
            return actionFrames;
        }

        public string getDataString(int _index)
        {
            string __result = "";

            __result += "\t<Action_" + _index + "> \r\n";

            __result += "\t\tname=" + name + "\r\n";
            __result += "\t\tactionFrames=" + getActionFramesString() + "\r\n";

            __result += "\t</Action_" + _index + "> \r\n";

            return __result;
        }

        private string getActionFramesString()
        {
            if (actionFrames != null)
            {
                string __result = "";
                string[] __frames = actionFrames.ToArray<string>();
                for (int i = 0; i < __frames.Length; i++)
                {
                    __result += __frames[i];
                    if (i < __frames.Length - 1)
                        __result += "|";
                }
                return __result;
            }
            else
            {
                return "";
            }
        }

        public ActionData(Dictionary<string, string> _actionData)
        {
            this.name = _actionData["name"];
            string __framesString = _actionData["actionFrames"];
            string[] __frames = __framesString.Split(new char[] { '|' });
            actionFrames = new List<string>(__frames);
        }

        public ActionData(string _name)
        {
            name = _name; 
        }

        public void addFrame(string frameName)
        {
            getActionFrames().Add(frameName);
        }

        public int getNumOfFrames()
        {
            return getActionFrames().Count();
        }
        
        public void insertFrame(string frameName, int index)
        {
            getActionFrames().Insert(index, frameName);
        }

        public void removeFrame(int index)
        {
            getActionFrames().RemoveAt(index);
        }

        public string[] getFrames()
        {
            string[] __result = null;
            if (actionFrames != null)
            {
                __result = actionFrames.ToArray<string>();
            }
            return __result;
        }
    }
}
