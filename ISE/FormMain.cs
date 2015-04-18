using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// ISE : Image Sequence Editor

namespace ISE
{
    // 等到了游戏中读取的时候再优化
    public partial class FormMain : Form
    {
        // 从JSON中获得的帧集合
        public Dictionary<string, FrameData> frameDatas = null;
        // TexturePacker生成的大图
        public Bitmap textureImage = null;
        // 动作组(动作名称, 动作数据)
        private Dictionary<string, ActionData> actionDatas = null;
        // 当前动作
        public ActionData currentAction = null;
        // 计时状态
        bool isTimerRunning;
        // 整体偏移
        public int offsetX, offsetY;

        // 预览图(大家一起来......)
        public Bitmap previewImage = null;
        public FrameData currentFrameData = null;


        public Dictionary<string, ActionData> getActions()
        {
            if (actionDatas == null)
                actionDatas = new Dictionary<string, ActionData>();
            return actionDatas;
        }

        public static FormMain instance = null;
        public FormMain()
        {
            instance = this;
            InitializeComponent();
            refreshAll();

            // 给一个默认的FPS
            textBoxFPS.Text = "30";
        }

        // 读取TexturePacker生成的一张大材质图
        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "TexturePacker输出的大图(*.png;*.PNG)|*.png;*.PNG";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textureImage = new Bitmap(openFileDialog.FileName);
                refreshAll();
            }
        }

        // 读取TexturePacker输出的JSON
        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "TexturePacker输出的JSON文件(*.json;*.JSON)|*.json;*.JSON";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string __jsonString = System.IO.File.ReadAllText(openFileDialog.FileName);
                frameDatas = new Dictionary<string, FrameData>();
                Hashtable __jsonData = (Hashtable)JSON.JsonDecode(__jsonString);
                Hashtable __jsonDataFrames = (Hashtable)__jsonData["frames"];
                foreach (System.Collections.DictionaryEntry item in __jsonDataFrames)
                    frameDatas.Add(item.Key.ToString(), new FrameData(item.Key.ToString(), (Hashtable)item.Value));
                refreshAll();
            }
        }

        // 当材质图和文件没有读取的时候, 其他的都是扯蛋, 所以材质图没读取的时候其他控件处于不可用状态
        public void refreshAll()
        {
            bool __enabled = (textureImage != null) && (frameDatas != null);

            textBoxAllOffsetX.Enabled = __enabled;
            textBoxAllOffsetY.Enabled = __enabled;
            textBoxCurrentFrameOffsetX.Enabled = __enabled;
            textBoxCurrentFrameOffsetY.Enabled = __enabled;
            buttonRefreshOffeset.Enabled = __enabled;
            buttonNewAction.Enabled = __enabled;
            buttonDeleteAction.Enabled = __enabled;
            buttonSaveData.Enabled = __enabled;
            buttonFrameUp.Enabled = __enabled;
            buttonFrameDown.Enabled = __enabled;
            buttonAddFrameToAction.Enabled = __enabled;
            buttonRemoveFrameFromAction.Enabled = __enabled;
            buttonRenameAction.Enabled = __enabled;
            listBoxAllFrames.Enabled = __enabled;
            listBoxActionFrames.Enabled = __enabled;
            listBoxActions.Enabled = __enabled;
            buttonPlayAction.Enabled = __enabled;
            buttonClearAll.Enabled = __enabled;

            refreshAllImageListBox();
            refreshActionListBox();
            refreshActionFramesListBox();
        }

        // 刷新帧列表
        public void refreshAllImageListBox()
        {
            if (frameDatas != null)
            {
                listBoxAllFrames.Items.Clear();
                string[] __frameKeys = frameDatas.Keys.ToArray<string>();
                __frameKeys = bubbleUp(__frameKeys);
                for (int i = 0; i < __frameKeys.Length; i++)
                    listBoxAllFrames.Items.Add(__frameKeys[i]);
            }
        }

        // 刷新动作列表
        public void refreshActionListBox()
        {
            if (actionDatas != null)
            {
                listBoxActions.Items.Clear();
                string[] __actionKeys = actionDatas.Keys.ToArray<string>();
                for (int i = 0; i < __actionKeys.Length; i++)
                    listBoxActions.Items.Add(__actionKeys[i]);
                buttonRenameAction.Enabled = (listBoxActions.SelectedItem != null);
            }
        }

        // 刷新当前动作的帧序列列表
        public void refreshActionFramesListBox()
        {
            if (listBoxActions.SelectedItem != null && actionDatas != null)
            {
                string __currentActionKey = listBoxActions.SelectedItem.ToString();
                listBoxActionFrames.Items.Clear();
                if (actionDatas.ContainsKey(__currentActionKey))
                {
                    currentAction = actionDatas[__currentActionKey];
                    string[] __actionFrames = currentAction.getFrames();
                    if (__actionFrames != null)
                    {
                        for (int i = 0; i < __actionFrames.Length; i++)
                        {
                            listBoxActionFrames.Items.Add(__actionFrames[i]);
                        }
                    }
                }
            }
            else
            {
                currentAction = null;
            }
            bool __enabled = listBoxActionFrames.SelectedItem != null;
            buttonRemoveFrameFromAction.Enabled = __enabled;
            buttonFrameUp.Enabled = __enabled;
            buttonFrameDown.Enabled = __enabled;
        }

        // 帧列表的点击过程
        void listBoxAllFrames_Click(object sender, System.EventArgs e)
        {
            if (listBoxAllFrames.SelectedItem != null)
            {
                currentFrameData = frameDatas[listBoxAllFrames.SelectedItem.ToString()];
                Rectangle __clipRect;
                if (currentFrameData.isRotated)
                {
                    __clipRect = new Rectangle(
                            currentFrameData.frameX,
                            currentFrameData.frameY,
                            currentFrameData.frameHeight,
                            currentFrameData.frameWidth
                        );
                }
                else
                {
                    __clipRect = new Rectangle(
                            currentFrameData.frameX,
                            currentFrameData.frameY,
                            currentFrameData.frameWidth,
                            currentFrameData.frameHeight
                        );
                }
                previewImage = textureImage.Clone(__clipRect, PixelFormat.DontCare);

                pictureBoxPreview.Refresh();

                textBoxAllOffsetX.Text = offsetX.ToString();
                textBoxAllOffsetY.Text = offsetY.ToString();
                textBoxCurrentFrameOffsetX.Text = currentFrameData.offsetX.ToString();
                textBoxCurrentFrameOffsetY.Text = currentFrameData.offsetY.ToString();
            }
        }
        private void listBoxAllFrames_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxAllFrames_Click(sender, e);
        }

        // 预览绘制的过程
        void pictureBoxPreview_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            if (previewImage != null && currentFrameData != null)
            {
                int __x = pictureBoxPreview.Width / 2 - currentFrameData.centerOffsetX + currentFrameData.offsetX + this.offsetX;
                int __y = pictureBoxPreview.Height / 2 - currentFrameData.centerOffsetY + currentFrameData.offsetY + this.offsetY;
                if (currentFrameData.isRotated)
                {
                    previewImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
                }
                e.Graphics.DrawImage(previewImage, __x, __y);
            }
        }

        private void buttonDebug_Click(object sender, EventArgs e)
        {
            new FormDebug().Show();
        }

        private void pictureBoxPreview_Click(object sender, EventArgs e)
        {
        }

       

        protected string[] bubbleUp(string[] Array)
        {
            for (int i = 0; i < Array.Length - 1; i++)
            {
                for (int j = 0; j < Array.Length - 1 - i; j++)
                {
                    //if (Array[j] > Array[j + 1])
                    if (String.Compare(Array[j], Array[j + 1]) > 0)
                    {
                        string temp = Array[j + 1];
                        Array[j + 1] = Array[j];
                        Array[j] = temp;
                    }
                }
            }
            return Array;
        }

        // 添加动作按钮按下
        private void buttonNewAction_Click(object sender, EventArgs e)
        {
            new FormCreateAction().Show();
        }

        // 添加一个动作
        public void addNewAction(string name)
        {
            if (actionDatas == null)
                actionDatas = new Dictionary<string, ActionData>();

            actionDatas.Add(name, new ActionData(name));
            refreshActionListBox();
        }

        private void buttonRenameAction_Click(object sender, EventArgs e)
        {
            new FormRenameAction().Show();
        }

        // 动作列表点击事件
        private void listBoxActions_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool __enable = (listBoxActions.SelectedItem != null);
            buttonRenameAction.Enabled = __enable;
            buttonAddFrameToAction.Enabled = __enable;
            buttonRemoveFrameFromAction.Enabled = __enable;
            buttonDeleteAction.Enabled = __enable;
            listBoxActionFrames.Enabled = __enable;
            if (__enable)
            {
                currentAction = actionDatas[listBoxActions.SelectedItem.ToString()];
                refreshActionFramesListBox();
            }
        }

        // 点击按钮向当前的动作添加帧
        private void buttonAddFrameToAction_Click(object sender, EventArgs e)
        {
            if (listBoxActions.SelectedItem != null && listBoxAllFrames.SelectedItem != null)
            {
                currentAction = actionDatas[listBoxActions.SelectedItem.ToString()];
                currentAction.addFrame(listBoxAllFrames.SelectedItem.ToString());
                refreshActionFramesListBox();
            }
        }

        // 删除当前动作的选定帧
        private void buttonRemoveFrameFromAction_Click(object sender, EventArgs e)
        {
            if (listBoxActions.SelectedItem != null && listBoxActionFrames.SelectedItem != null)
            {
                int __actionFrameIndex = listBoxActionFrames.SelectedIndex;
                currentAction = actionDatas[listBoxActions.SelectedItem.ToString()];
                if (currentAction.getFrames().Length > __actionFrameIndex)
                {
                    currentAction.removeFrame(__actionFrameIndex);
                    refreshActionFramesListBox();
                    if (__actionFrameIndex < currentAction.getNumOfFrames())
                        listBoxActionFrames.SelectedIndex = __actionFrameIndex;
                }
            }
        }

        private void listBoxActionFrames_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool __enabled = listBoxActionFrames.SelectedItem != null;
            buttonRemoveFrameFromAction.Enabled = __enabled;
            buttonFrameUp.Enabled = __enabled;
            buttonFrameDown.Enabled = __enabled;

            if (__enabled)
            {
                string __frameName = listBoxActionFrames.SelectedItem.ToString();
                currentFrameData = frameDatas[__frameName];
                Rectangle __clipRect;
                if (currentFrameData.isRotated)
                {
                    __clipRect = new Rectangle(
                            currentFrameData.frameX,
                            currentFrameData.frameY,
                            currentFrameData.frameHeight,
                            currentFrameData.frameWidth
                        );
                }
                else
                {
                    __clipRect = new Rectangle(
                            currentFrameData.frameX,
                            currentFrameData.frameY,
                            currentFrameData.frameWidth,
                            currentFrameData.frameHeight
                        );
                }
                previewImage = textureImage.Clone(__clipRect, PixelFormat.DontCare);

                pictureBoxPreview.Refresh();

                textBoxAllOffsetX.Text = offsetX.ToString();
                textBoxAllOffsetY.Text = offsetY.ToString();
                textBoxCurrentFrameOffsetX.Text = currentFrameData.offsetX.ToString();
                textBoxCurrentFrameOffsetY.Text = currentFrameData.offsetY.ToString();
            }
        }

        // 向上移动当前帧
        private void buttonFrameUp_Click(object sender, EventArgs e)
        {
            if (listBoxActionFrames.SelectedItem != null && currentAction != null && currentAction.getFrames() != null)
            {
                int __index = listBoxActionFrames.SelectedIndex;
                if (__index > 0 && __index < currentAction.getNumOfFrames())
                {
                    string __currentFrame = listBoxActionFrames.SelectedItem.ToString();
                    currentAction.removeFrame(__index);
                    currentAction.insertFrame(__currentFrame, __index - 1);
                    refreshActionFramesListBox();
                    listBoxActionFrames.SelectedIndex = __index - 1;
                }
            }
        }
        // 向下移动当前帧
        private void buttonFrameDown_Click(object sender, EventArgs e)
        {
            if (listBoxActionFrames.SelectedItem != null && currentAction != null && currentAction.getFrames() != null)
            {
                int __index = listBoxActionFrames.SelectedIndex;
                if (__index >= 0 && __index < currentAction.getNumOfFrames() - 1)
                {
                    string __currentFrame = listBoxActionFrames.SelectedItem.ToString();
                    currentAction.removeFrame(__index);
                    currentAction.insertFrame(__currentFrame, __index + 1);
                    refreshActionFramesListBox();
                    listBoxActionFrames.SelectedIndex = __index + 1;
                }
            }
        }

        private void buttonPlayAction_Click(object sender, EventArgs e)
        {
            if (!isTimerRunning)
            {
                try
                {
                    int __fps = int.Parse(textBoxFPS.Text.ToString());
                    timer.Interval = 1000 / __fps;
                    timer.Start();
                    buttonPlayAction.Text = "STOP!";
                    isTimerRunning = true;
                }
                catch
                {
                    MessageBox.Show("发生错误!(是否忘了设置FPS?)");
                }
            }
            else
            {
                buttonPlayAction.Text = "PLAY!";
                timer.Stop();
                isTimerRunning = false;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (listBoxActionFrames.Items.Count > 0)
            {
                if (listBoxActionFrames.SelectedItem == null)
                    listBoxActionFrames.SelectedIndex = 0;
                else
                {
                    int __count = listBoxActionFrames.Items.Count;
                    if (listBoxActionFrames.SelectedIndex < __count - 1)
                    {
                        listBoxActionFrames.SelectedIndex++;
                    }
                    else
                    {
                        listBoxActionFrames.SelectedIndex = 0;
                    }
                }
            }
        }

        private void buttonRefreshOffeset_Click(object sender, EventArgs e)
        {
            try
            {
                this.offsetX = int.Parse(textBoxAllOffsetX.Text.ToString());
                this.offsetY = int.Parse(textBoxAllOffsetY.Text.ToString());
                currentFrameData.offsetX = int.Parse(textBoxCurrentFrameOffsetX.Text.ToString());
                currentFrameData.offsetY = int.Parse(textBoxCurrentFrameOffsetY.Text.ToString());
            }
            catch
            {
                MessageBox.Show("请输入合法的偏移值");
            }

            pictureBoxPreview.Refresh();
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            if (frameDatas != null)
            {
                string[] __keys = frameDatas.Keys.ToArray<string>();
                for (int i = 0; i < __keys.Length; i++)
                {
                    frameDatas[__keys[i]].offsetX = 0;
                    frameDatas[__keys[i]].offsetY = 0;
                }
                this.offsetX = 0;
                this.offsetY = 0;
            }
        }

        // 就一张TextureImage, 所以暂时不需要复制资源. 在读取数据的时候, 需要大图的支持(但是不需要JSON数据的支持)
        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            // 输出数据
            string __dataString = getDataString();
            if (__dataString != null)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        System.IO.File.WriteAllText(saveFileDialog.FileName, __dataString, System.Text.Encoding.UTF8);
                        MessageBox.Show("数据导出到:" + saveFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("输出文件异常 : " + ex.Data);
                    }
                }
            }
        }

        private string getDataString()
        {
            string[] __frameDataKeys = frameDatas.Keys.ToArray<string>();
            string[] __actionDataKeys = actionDatas.Keys.ToArray<string>();

            try
            {
                string __result = "";

                __result += "<Global> \r\n";
                __result += "\toffsetX=" + this.offsetX + "\r\n";
                __result += "\toffsetY=" + this.offsetY + "\r\n";
                __result += "\thowManyFrames=" + __frameDataKeys.Length + "\r\n";
                __result += "\thowManyActions=" + __actionDataKeys.Length + "\r\n";
                __result += "</Global> \r\n";

                __result += "<FrameData> \r\n";

                for (int i = 0; i < __frameDataKeys.Length; i++)
                {
                    __result += frameDatas[__frameDataKeys[i]].getDataString(i);
                }
                __result += "</FrameData> \r\n";

                __result += "<ActionData> \r\n";

                for (int i = 0; i < __actionDataKeys.Length; i++)
                {
                    __result += actionDatas[__actionDataKeys[i]].getDataString(i);
                }
                __result += "</ActionData> \r\n";

                return __result;
            }
            catch
            {
                MessageBox.Show("不满足输出条件, 请检查数据完整性");
                return null;
            }
        }

        // 读取已经输出的文件
        private void buttonReadExport_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "数据文件(*.xml;*.txt;*.dat)|*.xml;*.txt;*.dat";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string __fileStuff = System.IO.File.ReadAllText(openFileDialog.FileName);
                string __globalStuff = getSubString(__fileStuff, "<Global>", "</Global>");
                string __frameStuff = getSubString(__fileStuff, "<FrameData>", "</FrameData>");
                string __actionStuff = getSubString(__fileStuff, "<ActionData>", "</ActionData>");

                Dictionary<string, string> __globalParas = analyseParas(__globalStuff);
                this.offsetX = int.Parse(__globalParas["offsetX"]);
                this.offsetY = int.Parse(__globalParas["offsetY"]);
                int __howManyFrames = int.Parse(__globalParas["howManyFrames"]);
                int __howManyActions = int.Parse(__globalParas["howManyActions"]);

                if (frameDatas == null)
                    frameDatas = new Dictionary<string, FrameData>();
                for (int i = 0; i < __howManyFrames; i++)
                {
                    string __frameString = getSubString(__frameStuff, "<Frame_" + i + ">", "</Frame_" + i + ">");
                    Dictionary<string, string>__frameParas = analyseParas(__frameString);
                    frameDatas.Add(__frameParas["name"], new FrameData(__frameParas));
                }

                if (actionDatas == null)
                    actionDatas = new Dictionary<string, ActionData>();
                for (int i = 0; i < __howManyActions; i++)
                {
                    string __actionString = getSubString(__actionStuff, "<Action_" + i + ">", "</Action_" + i + ">");
                    Dictionary<string, string>__actionParas = analyseParas(__actionString);
                    actionDatas.Add(__actionParas["name"], new ActionData(__actionParas));
                }

                refreshAll();
            }
        }

        // 通过两个标签截取一段字符串
        public static string getSubString(string str, string tagStart, string tagEnd)
        {
            int indexStart = str.IndexOf(tagStart) + tagStart.Length;
            int indexEnd = str.IndexOf(tagEnd);
            return str.Substring(indexStart, indexEnd - indexStart);
        }

        // 将一段字符串切割后变成一张键值表.
        public static Dictionary<string, string> analyseParas(string str)
        {
            Dictionary<string, string> __result = new Dictionary<string, string>();
            string[] para_values = str.Trim().Split(new char[] { '\n' });
            for (int i = 0; i < para_values.Length; i++)
            {
                string[] fuck = para_values[i].Trim().Split(new char[] { '=' });
                __result.Add(fuck[0], fuck[1]);
            }
            return __result;
        }

        private void buttonDeleteAction_Click(object sender, EventArgs e)
        {
            if (listBoxActions.SelectedItem != null)
            {
                actionDatas.Remove(listBoxActions.SelectedItem.ToString());
                refreshActionListBox();
                refreshActionFramesListBox();
            }
        }
    }
}
