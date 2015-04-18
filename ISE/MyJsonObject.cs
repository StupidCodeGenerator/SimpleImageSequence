using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISE
{
    // C# 的JSON不好用!!

    // 将{}视为一个整体的策略: 从前找第一个'{', 然后从后找第一个'}', 然后将中间的截取下来作为一个字符串.
    // TexturePacker输出的JSON包含一个最外层的"{}", 要去掉.

    public class MyJsonObject
    {
        Dictionary<string, string> keyValuePair;

        public MyJsonObject(string _jsonString)
        {
            
        }

        public string removeOutsideBrackets()
        {
            return null;
        }
    }
}
