namespace ISE
{
    partial class FormRenameAction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCurrentName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCurrentName
            // 
            this.labelCurrentName.AutoSize = true;
            this.labelCurrentName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCurrentName.Location = new System.Drawing.Point(12, 9);
            this.labelCurrentName.Name = "labelCurrentName";
            this.labelCurrentName.Size = new System.Drawing.Size(55, 21);
            this.labelCurrentName.TabIndex = 0;
            this.labelCurrentName.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "新名称";
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Location = new System.Drawing.Point(59, 49);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(183, 21);
            this.textBoxNewName.TabIndex = 2;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(248, 40);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(108, 36);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "FUCK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormRenameAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 97);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxNewName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCurrentName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormRenameAction";
            this.Text = "FormRenameAction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.Button buttonOK;
    }
}