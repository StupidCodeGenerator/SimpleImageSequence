using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ISE
{
    public partial class FormRenameAction : Form
    {
        public string currentName;

        public FormRenameAction()
        {
            InitializeComponent();
            if (FormMain.instance.currentAction != null)
            {
                labelCurrentName.Text = FormMain.instance.currentAction.name;
                currentName = labelCurrentName.Text.ToString();
            }
            else
            {
                MessageBox.Show("当前动作为空!");
                this.Close();
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (FormMain.instance.currentAction != null)
            {
                // 重名名的过程: 修改键值和对象中的name
                // 得把对象先引用出来, 然后删掉刚才的键, 然后重新添加. 
                // 因为Key是不能换的......
                if (FormMain.instance.getActions().ContainsKey(currentName))
                {
                    string __newName = textBoxNewName.Text.ToString();
                    if (!FormMain.instance.getActions().ContainsKey(__newName))
                    {
                        ActionData __tempData = FormMain.instance.getActions()[currentName];
                        FormMain.instance.getActions().Remove(currentName);
                        FormMain.instance.getActions().Add(__newName, __tempData);
                        FormMain.instance.refreshActionListBox();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("新名字已经存在!");
                    }
                }
                else
                {
                    MessageBox.Show("出现未知错误!");
                }
            }
        }
    }
}
