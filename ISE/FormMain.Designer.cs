namespace ISE
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxActions = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxActionFrames = new System.Windows.Forms.ListBox();
            this.listBoxAllFrames = new System.Windows.Forms.ListBox();
            this.buttonRemoveFrameFromAction = new System.Windows.Forms.Button();
            this.buttonAddFrameToAction = new System.Windows.Forms.Button();
            this.buttonFrameUp = new System.Windows.Forms.Button();
            this.buttonFrameDown = new System.Windows.Forms.Button();
            this.buttonSaveData = new System.Windows.Forms.Button();
            this.buttonReadJSON = new System.Windows.Forms.Button();
            this.buttonNewAction = new System.Windows.Forms.Button();
            this.buttonDeleteAction = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonReadExport = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCurrentFrameOffsetX = new System.Windows.Forms.TextBox();
            this.textBoxCurrentFrameOffsetY = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxAllOffsetY = new System.Windows.Forms.TextBox();
            this.textBoxAllOffsetX = new System.Windows.Forms.TextBox();
            this.buttonRefreshOffeset = new System.Windows.Forms.Button();
            this.buttonDebug = new System.Windows.Forms.Button();
            this.buttonRenameAction = new System.Windows.Forms.Button();
            this.buttonPlayAction = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxFPS = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonClearAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.BackColor = System.Drawing.Color.Black;
            this.pictureBoxPreview.Location = new System.Drawing.Point(12, 24);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(235, 232);
            this.pictureBoxPreview.TabIndex = 0;
            this.pictureBoxPreview.TabStop = false;
            this.pictureBoxPreview.Click += new System.EventHandler(this.pictureBoxPreview_Click);
            this.pictureBoxPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxPreview_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "拖动或点击后使用方向键可以调整偏移值";
            // 
            // listBoxActions
            // 
            this.listBoxActions.FormattingEnabled = true;
            this.listBoxActions.ItemHeight = 12;
            this.listBoxActions.Location = new System.Drawing.Point(253, 24);
            this.listBoxActions.Name = "listBoxActions";
            this.listBoxActions.Size = new System.Drawing.Size(166, 232);
            this.listBoxActions.TabIndex = 3;
            this.listBoxActions.Click += new System.EventHandler(this.listBoxActions_SelectedIndexChanged);
            this.listBoxActions.SelectedIndexChanged += new System.EventHandler(this.listBoxActions_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Actions";
            // 
            // listBoxActionFrames
            // 
            this.listBoxActionFrames.FormattingEnabled = true;
            this.listBoxActionFrames.ItemHeight = 12;
            this.listBoxActionFrames.Location = new System.Drawing.Point(425, 24);
            this.listBoxActionFrames.Name = "listBoxActionFrames";
            this.listBoxActionFrames.Size = new System.Drawing.Size(174, 232);
            this.listBoxActionFrames.TabIndex = 5;
            this.listBoxActionFrames.SelectedIndexChanged += new System.EventHandler(this.listBoxActionFrames_SelectedIndexChanged);
            // 
            // listBoxAllFrames
            // 
            this.listBoxAllFrames.FormattingEnabled = true;
            this.listBoxAllFrames.ItemHeight = 12;
            this.listBoxAllFrames.Location = new System.Drawing.Point(684, 24);
            this.listBoxAllFrames.Name = "listBoxAllFrames";
            this.listBoxAllFrames.Size = new System.Drawing.Size(174, 232);
            this.listBoxAllFrames.TabIndex = 6;
            this.listBoxAllFrames.Click += new System.EventHandler(this.listBoxAllFrames_Click);
            this.listBoxAllFrames.SelectedIndexChanged += new System.EventHandler(this.listBoxAllFrames_SelectedIndexChanged);
            // 
            // buttonRemoveFrameFromAction
            // 
            this.buttonRemoveFrameFromAction.Location = new System.Drawing.Point(605, 220);
            this.buttonRemoveFrameFromAction.Name = "buttonRemoveFrameFromAction";
            this.buttonRemoveFrameFromAction.Size = new System.Drawing.Size(73, 36);
            this.buttonRemoveFrameFromAction.TabIndex = 7;
            this.buttonRemoveFrameFromAction.Text = "X";
            this.buttonRemoveFrameFromAction.UseVisualStyleBackColor = true;
            this.buttonRemoveFrameFromAction.Click += new System.EventHandler(this.buttonRemoveFrameFromAction_Click);
            // 
            // buttonAddFrameToAction
            // 
            this.buttonAddFrameToAction.Location = new System.Drawing.Point(605, 178);
            this.buttonAddFrameToAction.Name = "buttonAddFrameToAction";
            this.buttonAddFrameToAction.Size = new System.Drawing.Size(73, 36);
            this.buttonAddFrameToAction.TabIndex = 8;
            this.buttonAddFrameToAction.Text = "< -- ";
            this.buttonAddFrameToAction.UseVisualStyleBackColor = true;
            this.buttonAddFrameToAction.Click += new System.EventHandler(this.buttonAddFrameToAction_Click);
            // 
            // buttonFrameUp
            // 
            this.buttonFrameUp.Location = new System.Drawing.Point(605, 24);
            this.buttonFrameUp.Name = "buttonFrameUp";
            this.buttonFrameUp.Size = new System.Drawing.Size(73, 36);
            this.buttonFrameUp.TabIndex = 9;
            this.buttonFrameUp.Text = "▲";
            this.buttonFrameUp.UseVisualStyleBackColor = true;
            this.buttonFrameUp.Click += new System.EventHandler(this.buttonFrameUp_Click);
            // 
            // buttonFrameDown
            // 
            this.buttonFrameDown.Location = new System.Drawing.Point(605, 66);
            this.buttonFrameDown.Name = "buttonFrameDown";
            this.buttonFrameDown.Size = new System.Drawing.Size(73, 36);
            this.buttonFrameDown.TabIndex = 10;
            this.buttonFrameDown.Text = "▼";
            this.buttonFrameDown.UseVisualStyleBackColor = true;
            this.buttonFrameDown.Click += new System.EventHandler(this.buttonFrameDown_Click);
            // 
            // buttonSaveData
            // 
            this.buttonSaveData.Location = new System.Drawing.Point(776, 262);
            this.buttonSaveData.Name = "buttonSaveData";
            this.buttonSaveData.Size = new System.Drawing.Size(86, 31);
            this.buttonSaveData.TabIndex = 11;
            this.buttonSaveData.Text = "保存输出";
            this.buttonSaveData.UseVisualStyleBackColor = true;
            this.buttonSaveData.Click += new System.EventHandler(this.buttonSaveData_Click);
            // 
            // buttonReadJSON
            // 
            this.buttonReadJSON.Location = new System.Drawing.Point(776, 299);
            this.buttonReadJSON.Name = "buttonReadJSON";
            this.buttonReadJSON.Size = new System.Drawing.Size(87, 31);
            this.buttonReadJSON.TabIndex = 12;
            this.buttonReadJSON.Text = "读取JSON";
            this.buttonReadJSON.UseVisualStyleBackColor = true;
            this.buttonReadJSON.Click += new System.EventHandler(this.buttonLoadData_Click);
            // 
            // buttonNewAction
            // 
            this.buttonNewAction.Location = new System.Drawing.Point(253, 259);
            this.buttonNewAction.Name = "buttonNewAction";
            this.buttonNewAction.Size = new System.Drawing.Size(166, 31);
            this.buttonNewAction.TabIndex = 13;
            this.buttonNewAction.Text = "增加动作";
            this.buttonNewAction.UseVisualStyleBackColor = true;
            this.buttonNewAction.Click += new System.EventHandler(this.buttonNewAction_Click);
            // 
            // buttonDeleteAction
            // 
            this.buttonDeleteAction.Location = new System.Drawing.Point(337, 294);
            this.buttonDeleteAction.Name = "buttonDeleteAction";
            this.buttonDeleteAction.Size = new System.Drawing.Size(82, 31);
            this.buttonDeleteAction.TabIndex = 14;
            this.buttonDeleteAction.Text = "去除动作";
            this.buttonDeleteAction.UseVisualStyleBackColor = true;
            this.buttonDeleteAction.Click += new System.EventHandler(this.buttonDeleteAction_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "ActionFrames";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(682, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "AllFrames";
            // 
            // buttonLoadImage
            // 
            this.buttonLoadImage.Location = new System.Drawing.Point(683, 299);
            this.buttonLoadImage.Name = "buttonLoadImage";
            this.buttonLoadImage.Size = new System.Drawing.Size(87, 31);
            this.buttonLoadImage.TabIndex = 18;
            this.buttonLoadImage.Text = "读取大图";
            this.buttonLoadImage.UseVisualStyleBackColor = true;
            this.buttonLoadImage.Click += new System.EventHandler(this.buttonLoadImage_Click);
            // 
            // buttonReadExport
            // 
            this.buttonReadExport.Location = new System.Drawing.Point(684, 262);
            this.buttonReadExport.Name = "buttonReadExport";
            this.buttonReadExport.Size = new System.Drawing.Size(86, 31);
            this.buttonReadExport.TabIndex = 19;
            this.buttonReadExport.Text = "读取输出";
            this.buttonReadExport.UseVisualStyleBackColor = true;
            this.buttonReadExport.Click += new System.EventHandler(this.buttonReadExport_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "当前帧偏移:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 21;
            this.label6.Text = "整体偏移:";
            // 
            // textBoxCurrentFrameOffsetX
            // 
            this.textBoxCurrentFrameOffsetX.Location = new System.Drawing.Point(101, 259);
            this.textBoxCurrentFrameOffsetX.Name = "textBoxCurrentFrameOffsetX";
            this.textBoxCurrentFrameOffsetX.Size = new System.Drawing.Size(50, 21);
            this.textBoxCurrentFrameOffsetX.TabIndex = 22;
            // 
            // textBoxCurrentFrameOffsetY
            // 
            this.textBoxCurrentFrameOffsetY.Location = new System.Drawing.Point(183, 259);
            this.textBoxCurrentFrameOffsetY.Name = "textBoxCurrentFrameOffsetY";
            this.textBoxCurrentFrameOffsetY.Size = new System.Drawing.Size(50, 21);
            this.textBoxCurrentFrameOffsetY.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 24;
            this.label7.Text = "X:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 25;
            this.label8.Text = "Y:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(160, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 29;
            this.label9.Text = "Y:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(80, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 28;
            this.label10.Text = "X:";
            // 
            // textBoxAllOffsetY
            // 
            this.textBoxAllOffsetY.Location = new System.Drawing.Point(183, 283);
            this.textBoxAllOffsetY.Name = "textBoxAllOffsetY";
            this.textBoxAllOffsetY.Size = new System.Drawing.Size(50, 21);
            this.textBoxAllOffsetY.TabIndex = 27;
            // 
            // textBoxAllOffsetX
            // 
            this.textBoxAllOffsetX.Location = new System.Drawing.Point(101, 283);
            this.textBoxAllOffsetX.Name = "textBoxAllOffsetX";
            this.textBoxAllOffsetX.Size = new System.Drawing.Size(50, 21);
            this.textBoxAllOffsetX.TabIndex = 26;
            // 
            // buttonRefreshOffeset
            // 
            this.buttonRefreshOffeset.Location = new System.Drawing.Point(11, 310);
            this.buttonRefreshOffeset.Name = "buttonRefreshOffeset";
            this.buttonRefreshOffeset.Size = new System.Drawing.Size(105, 22);
            this.buttonRefreshOffeset.TabIndex = 30;
            this.buttonRefreshOffeset.Text = "FUCK THIS";
            this.buttonRefreshOffeset.UseVisualStyleBackColor = true;
            this.buttonRefreshOffeset.Click += new System.EventHandler(this.buttonRefreshOffeset_Click);
            // 
            // buttonDebug
            // 
            this.buttonDebug.Location = new System.Drawing.Point(605, 262);
            this.buttonDebug.Name = "buttonDebug";
            this.buttonDebug.Size = new System.Drawing.Size(72, 66);
            this.buttonDebug.TabIndex = 31;
            this.buttonDebug.Text = "DEBUG";
            this.buttonDebug.UseVisualStyleBackColor = true;
            this.buttonDebug.Click += new System.EventHandler(this.buttonDebug_Click);
            // 
            // buttonRenameAction
            // 
            this.buttonRenameAction.Location = new System.Drawing.Point(253, 294);
            this.buttonRenameAction.Name = "buttonRenameAction";
            this.buttonRenameAction.Size = new System.Drawing.Size(78, 31);
            this.buttonRenameAction.TabIndex = 32;
            this.buttonRenameAction.Text = "重命名";
            this.buttonRenameAction.UseVisualStyleBackColor = true;
            this.buttonRenameAction.Click += new System.EventHandler(this.buttonRenameAction_Click);
            // 
            // buttonPlayAction
            // 
            this.buttonPlayAction.Location = new System.Drawing.Point(424, 294);
            this.buttonPlayAction.Name = "buttonPlayAction";
            this.buttonPlayAction.Size = new System.Drawing.Size(175, 31);
            this.buttonPlayAction.TabIndex = 33;
            this.buttonPlayAction.Text = "PLAY!";
            this.buttonPlayAction.UseVisualStyleBackColor = true;
            this.buttonPlayAction.Click += new System.EventHandler(this.buttonPlayAction_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(425, 271);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 34;
            this.label11.Text = "FPS:";
            // 
            // textBoxFPS
            // 
            this.textBoxFPS.Location = new System.Drawing.Point(460, 265);
            this.textBoxFPS.Name = "textBoxFPS";
            this.textBoxFPS.Size = new System.Drawing.Size(139, 21);
            this.textBoxFPS.TabIndex = 35;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Location = new System.Drawing.Point(128, 310);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(105, 22);
            this.buttonClearAll.TabIndex = 36;
            this.buttonClearAll.Text = "CLEAR ALL";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 337);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.textBoxFPS);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonPlayAction);
            this.Controls.Add(this.buttonRenameAction);
            this.Controls.Add(this.buttonDebug);
            this.Controls.Add(this.buttonRefreshOffeset);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxAllOffsetY);
            this.Controls.Add(this.textBoxAllOffsetX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCurrentFrameOffsetY);
            this.Controls.Add(this.textBoxCurrentFrameOffsetX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonReadExport);
            this.Controls.Add(this.buttonLoadImage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonDeleteAction);
            this.Controls.Add(this.buttonNewAction);
            this.Controls.Add(this.buttonReadJSON);
            this.Controls.Add(this.buttonSaveData);
            this.Controls.Add(this.buttonFrameDown);
            this.Controls.Add(this.buttonFrameUp);
            this.Controls.Add(this.buttonAddFrameToAction);
            this.Controls.Add(this.buttonRemoveFrameFromAction);
            this.Controls.Add(this.listBoxAllFrames);
            this.Controls.Add(this.listBoxActionFrames);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxActions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxPreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "ISE - ImageSequenceEditor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxActions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxActionFrames;
        private System.Windows.Forms.ListBox listBoxAllFrames;
        private System.Windows.Forms.Button buttonRemoveFrameFromAction;
        private System.Windows.Forms.Button buttonAddFrameToAction;
        private System.Windows.Forms.Button buttonFrameUp;
        private System.Windows.Forms.Button buttonFrameDown;
        private System.Windows.Forms.Button buttonSaveData;
        private System.Windows.Forms.Button buttonReadJSON;
        private System.Windows.Forms.Button buttonNewAction;
        private System.Windows.Forms.Button buttonDeleteAction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonLoadImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button buttonReadExport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCurrentFrameOffsetX;
        private System.Windows.Forms.TextBox textBoxCurrentFrameOffsetY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxAllOffsetY;
        private System.Windows.Forms.TextBox textBoxAllOffsetX;
        private System.Windows.Forms.Button buttonRefreshOffeset;
        private System.Windows.Forms.Button buttonDebug;
        private System.Windows.Forms.Button buttonRenameAction;
        private System.Windows.Forms.Button buttonPlayAction;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxFPS;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonClearAll;
    }
}

