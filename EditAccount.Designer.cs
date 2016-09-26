namespace PasswordManage
{
    partial class EditAccount
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAccount));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAccountTitle = new System.Windows.Forms.TextBox();
            this.txtAccoutnName = new System.Windows.Forms.TextBox();
            this.txtAccountPwd = new System.Windows.Forms.TextBox();
            this.txtAccountWebsite = new System.Windows.Forms.TextBox();
            this.txtAccountRemark = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxTree = new PasswordManage.Code.ComboBoxTreeView();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "标题：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "用户名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "密码：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "备注：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "网址：";
            // 
            // txtAccountTitle
            // 
            this.txtAccountTitle.Location = new System.Drawing.Point(105, 34);
            this.txtAccountTitle.Name = "txtAccountTitle";
            this.txtAccountTitle.Size = new System.Drawing.Size(202, 21);
            this.txtAccountTitle.TabIndex = 1;
            // 
            // txtAccoutnName
            // 
            this.txtAccoutnName.Location = new System.Drawing.Point(105, 73);
            this.txtAccoutnName.Name = "txtAccoutnName";
            this.txtAccoutnName.Size = new System.Drawing.Size(202, 21);
            this.txtAccoutnName.TabIndex = 2;
            // 
            // txtAccountPwd
            // 
            this.txtAccountPwd.Location = new System.Drawing.Point(105, 114);
            this.txtAccountPwd.Name = "txtAccountPwd";
            this.txtAccountPwd.Size = new System.Drawing.Size(202, 21);
            this.txtAccountPwd.TabIndex = 3;
            // 
            // txtAccountWebsite
            // 
            this.txtAccountWebsite.Location = new System.Drawing.Point(105, 153);
            this.txtAccountWebsite.Name = "txtAccountWebsite";
            this.txtAccountWebsite.Size = new System.Drawing.Size(202, 21);
            this.txtAccountWebsite.TabIndex = 4;
            // 
            // txtAccountRemark
            // 
            this.txtAccountRemark.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAccountRemark.Location = new System.Drawing.Point(105, 228);
            this.txtAccountRemark.Multiline = true;
            this.txtAccountRemark.Name = "txtAccountRemark";
            this.txtAccountRemark.Size = new System.Drawing.Size(202, 126);
            this.txtAccountRemark.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 376);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 37);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(245, 376);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 37);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "关闭";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Location = new System.Drawing.Point(130, 376);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(102, 37);
            this.btnSaveClose.TabIndex = 6;
            this.btnSaveClose.Text = "保存并关闭";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "分组：";
            // 
            // cbxTree
            // 
            this.cbxTree.FormattingEnabled = true;
            this.cbxTree.Location = new System.Drawing.Point(105, 191);
            this.cbxTree.Name = "cbxTree";
            this.cbxTree.NodeCode = 0;
            this.cbxTree.ParentNode = 0;
            this.cbxTree.Size = new System.Drawing.Size(202, 20);
            this.cbxTree.TabIndex = 8;
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "7.ico");
            this.imgList.Images.SetKeyName(1, "9.ico");
            // 
            // EditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(360, 428);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxTree);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAccountPwd);
            this.Controls.Add(this.txtAccountRemark);
            this.Controls.Add(this.txtAccountWebsite);
            this.Controls.Add(this.txtAccoutnName);
            this.Controls.Add(this.txtAccountTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "编辑帐号信息";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditAccount_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAccountTitle;
        private System.Windows.Forms.TextBox txtAccoutnName;
        private System.Windows.Forms.TextBox txtAccountPwd;
        private System.Windows.Forms.TextBox txtAccountWebsite;
        private System.Windows.Forms.TextBox txtAccountRemark;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveClose;
        private Code.ComboBoxTreeView cbxTree;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ImageList imgList;
    }
}