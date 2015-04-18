using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace ISE
{
    public class FrameData
    {
        public string name;
        public int frameX, frameY, frameWidth, frameHeight;
        public bool isRotated;
        public bool isTrimmed;
        public int spriteSourceX, spriteSourceY, spriteSourceWidth, spriteSourceHeight;
        public int sourceWidth, sourceHeight;

        // 手动增加的偏移值, 用来对准中心. 默认的中心位置定义为第一帧的图片中心
        public int offsetX, offsetY;
        // 中心点偏移值. 原图中心点在此图块中的位置.
        // 当前坐标减去此偏移值, 然后以左上角点绘制, 绘制的结果就是将中心绘制在当前坐标位置
        public int centerOffsetX, centerOffsetY;

        public FrameData(string _name, Hashtable _frameData)
        {
            Hashtable __frame = (Hashtable)_frameData["frame"];
            Hashtable __spriteSourceSize = (Hashtable)_frameData["spriteSourceSize"];
            Hashtable __sourceSize = (Hashtable)_frameData["sourceSize"];

            this.name = _name;

            // 这个地方必须先转double再转int才可以
            this.frameX = (int)(double)__frame["x"];
            this.frameY = (int)(double)__frame["y"];
            this.frameWidth = (int)(double)__frame["w"];
            this.frameHeight = (int)(double)__frame["h"];

            this.isRotated = (bool)_frameData["rotated"];
            this.isTrimmed = (bool)_frameData["trimmed"];

            this.spriteSourceX = (int)(double)__spriteSourceSize["x"];
            this.spriteSourceY = (int)(double)__spriteSourceSize["y"];
            this.spriteSourceWidth = (int)(double)__spriteSourceSize["w"];
            this.spriteSourceHeight = (int)(double)__spriteSourceSize["h"];

            this.sourceWidth = (int)(double)__sourceSize["w"];
            this.sourceHeight = (int)(double)__sourceSize["h"];

            // 手动偏移值默认归零
            offsetX = 0; offsetY = 0;

            // 计算中心点位置偏移值
            centerOffsetX = sourceWidth / 2 - spriteSourceX;
            centerOffsetY = sourceHeight / 2 - spriteSourceY;
        }

        public FrameData(Dictionary<string, string> _frameData)
        {
            this.name = _frameData["name"];
            this.frameX = int.Parse(_frameData["frameX"]);
            this.frameY = int.Parse(_frameData["frameY"]);
            this.frameWidth = int.Parse(_frameData["frameWidth"]);
            this.frameHeight = int.Parse(_frameData["frameHeight"]);
            this.isRotated = getStringBool(_frameData["isRotated"]);
            this.isTrimmed = getStringBool(_frameData["isTrimmed"]);
            this.spriteSourceX = int.Parse(_frameData["spriteSourceX"]);
            this.spriteSourceY = int.Parse(_frameData["spriteSourceY"]);
            this.spriteSourceWidth = int.Parse(_frameData["spriteSourceWidth"]);
            this.spriteSourceHeight = int.Parse(_frameData["spriteSourceHeight"]);
            this.sourceWidth = int.Parse(_frameData["sourceWidth"]);
            this.sourceHeight = int.Parse(_frameData["sourceHeight"]);
            this.offsetX = int.Parse(_frameData["offsetX"]);
            this.offsetY = int.Parse(_frameData["offsetY"]);
            this.centerOffsetX = int.Parse(_frameData["centerOffsetX"]);
            this.centerOffsetY = int.Parse(_frameData["centerOffsetY"]);
        }

        public string getDataString(int _index)
        {
            string __result = "";

            __result += "\t<Frame_" + _index + ">\r\n";

            __result += "\t\tname=" + name + "\r\n";

            __result += "\t\tframeX=" + frameX + "\r\n";
            __result += "\t\tframeY=" + frameY + "\r\n";
            __result += "\t\tframeWidth=" + frameWidth + "\r\n";
            __result += "\t\tframeHeight=" + frameHeight + "\r\n";
            __result += "\t\tisRotated=" + getBoolString(isRotated) + "\r\n";
            __result += "\t\tisTrimmed=" + getBoolString(isTrimmed) + "\r\n";
            __result += "\t\tspriteSourceX=" + spriteSourceX + "\r\n";
            __result += "\t\tspriteSourceY=" + spriteSourceY + "\r\n";
            __result += "\t\tspriteSourceWidth=" + spriteSourceWidth + "\r\n";
            __result += "\t\tspriteSourceHeight=" + spriteSourceHeight + "\r\n";
            __result += "\t\tsourceWidth=" + sourceWidth + "\r\n";
            __result += "\t\tsourceHeight=" + sourceHeight + "\r\n";
            __result += "\t\toffsetX=" + offsetX + "\r\n";
            __result += "\t\toffsetY=" + offsetY + "\r\n";
            __result += "\t\tcenterOffsetX=" + centerOffsetX + "\r\n";
            __result += "\t\tcenterOffsetY=" + centerOffsetY + "\r\n";

            __result += "\t</Frame_" + _index + ">\r\n";

            return __result;
        }

        private string getBoolString(bool _value)
        {
            return _value ? "true" : "false";
        }

        private bool getStringBool(string _value)
        {
            return _value.ToLower().Equals("true");
        }
    }
}
