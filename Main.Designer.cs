namespace PasswordManage
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCreateAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置开机密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.sContainer = new System.Windows.Forms.SplitContainer();
            this.tvNodes = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.标题 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountPwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountWebsite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.分组 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.添加时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gridUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.gridDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tvNodeAdd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tvMenuAddParentNode = new System.Windows.Forms.ToolStripMenuItem();
            this.tvMenuAddChildNode = new System.Windows.Forms.ToolStripMenuItem();
            this.tvNodeUpdateNode = new System.Windows.Forms.ToolStripMenuItem();
            this.tvNodeDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tvNodeAddParent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSetPwd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCollapsed = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sContainer)).BeginInit();
            this.sContainer.Panel1.SuspendLayout();
            this.sContainer.Panel2.SuspendLayout();
            this.sContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.gridMenu.SuspendLayout();
            this.tvNodeAdd.SuspendLayout();
            this.tvNodeAddParent.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.配置ToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1119, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCreateAccount,
            this.menuExit});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.文件FToolStripMenuItem.Text = "文件(F)";
            // 
            // menuCreateAccount
            // 
            this.menuCreateAccount.Image = ((System.Drawing.Image)(resources.GetObject("menuCreateAccount.Image")));
            this.menuCreateAccount.Name = "menuCreateAccount";
            this.menuCreateAccount.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuCreateAccount.Size = new System.Drawing.Size(153, 22);
            this.menuCreateAccount.Text = "新建(&N)";
            this.menuCreateAccount.Click += new System.EventHandler(this.menuCreateAccount_Click);
            // 
            // menuExit
            // 
            this.menuExit.Image = ((System.Drawing.Image)(resources.GetObject("menuExit.Image")));
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(153, 22);
            this.menuExit.Text = "退出(&X)";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // 配置ToolStripMenuItem
            // 
            this.配置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置开机密码ToolStripMenuItem});
            this.配置ToolStripMenuItem.Name = "配置ToolStripMenuItem";
            this.配置ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.配置ToolStripMenuItem.Text = "配置(&C)";
            // 
            // 设置开机密码ToolStripMenuItem
            // 
            this.设置开机密码ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("设置开机密码ToolStripMenuItem.Image")));
            this.设置开机密码ToolStripMenuItem.Name = "设置开机密码ToolStripMenuItem";
            this.设置开机密码ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.设置开机密码ToolStripMenuItem.Text = "设置开机密码(&P)";
            this.设置开机密码ToolStripMenuItem.Click += new System.EventHandler(this.tsbSetPwd_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAbout});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // tsmAbout
            // 
            this.tsmAbout.Image = ((System.Drawing.Image)(resources.GetObject("tsmAbout.Image")));
            this.tsmAbout.Name = "tsmAbout";
            this.tsmAbout.Size = new System.Drawing.Size(112, 22);
            this.tsmAbout.Text = "关于(&A)";
            this.tsmAbout.Click += new System.EventHandler(this.tsmAbout_Click);
            // 
            // sContainer
            // 
            this.sContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sContainer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sContainer.Location = new System.Drawing.Point(0, 49);
            this.sContainer.Name = "sContainer";
            // 
            // sContainer.Panel1
            // 
            this.sContainer.Panel1.Controls.Add(this.tvNodes);
            // 
            // sContainer.Panel2
            // 
            this.sContainer.Panel2.Controls.Add(this.dgvData);
            this.sContainer.Panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sContainer.Size = new System.Drawing.Size(1119, 549);
            this.sContainer.SplitterDistance = 168;
            this.sContainer.TabIndex = 2;
            // 
            // tvNodes
            // 
            this.tvNodes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvNodes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tvNodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvNodes.HideSelection = false;
            this.tvNodes.ImageIndex = 0;
            this.tvNodes.ImageList = this.imageList1;
            this.tvNodes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tvNodes.Location = new System.Drawing.Point(0, 0);
            this.tvNodes.Name = "tvNodes";
            this.tvNodes.SelectedImageIndex = 0;
            this.tvNodes.ShowPlusMinus = false;
            this.tvNodes.ShowRootLines = false;
            this.tvNodes.Size = new System.Drawing.Size(168, 549);
            this.tvNodes.TabIndex = 0;
            this.tvNodes.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvNodes_NodeMouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "4.ico");
            this.imageList1.Images.SetKeyName(1, "p2.ico");
            this.imageList1.Images.SetKeyName(2, "p3.ico");
            this.imageList1.Images.SetKeyName(3, "5.ico");
            this.imageList1.Images.SetKeyName(4, "7.ico");
            this.imageList1.Images.SetKeyName(5, "9.ico");
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.标题,
            this.AccountName,
            this.AccountPwd,
            this.AccountWebsite,
            this.AccountRemark,
            this.分组,
            this.添加时间});
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowTemplate.Height = 23;
            this.dgvData.Size = new System.Drawing.Size(947, 549);
            this.dgvData.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "AccountCode";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 50;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // 标题
            // 
            this.标题.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.标题.DataPropertyName = "AccountTitle";
            this.标题.HeaderText = "标题";
            this.标题.MinimumWidth = 60;
            this.标题.Name = "标题";
            this.标题.ReadOnly = true;
            // 
            // AccountName
            // 
            this.AccountName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AccountName.DataPropertyName = "AccountName";
            this.AccountName.HeaderText = "用户名";
            this.AccountName.MinimumWidth = 70;
            this.AccountName.Name = "AccountName";
            this.AccountName.ReadOnly = true;
            // 
            // AccountPwd
            // 
            this.AccountPwd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AccountPwd.DataPropertyName = "AccountPwd";
            this.AccountPwd.HeaderText = "密码";
            this.AccountPwd.MinimumWidth = 60;
            this.AccountPwd.Name = "AccountPwd";
            this.AccountPwd.ReadOnly = true;
            // 
            // AccountWebsite
            // 
            this.AccountWebsite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AccountWebsite.DataPropertyName = "AccountWebsite";
            this.AccountWebsite.HeaderText = "地址";
            this.AccountWebsite.MinimumWidth = 60;
            this.AccountWebsite.Name = "AccountWebsite";
            this.AccountWebsite.ReadOnly = true;
            // 
            // AccountRemark
            // 
            this.AccountRemark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AccountRemark.DataPropertyName = "AccountRemark";
            this.AccountRemark.HeaderText = "备注";
            this.AccountRemark.MinimumWidth = 60;
            this.AccountRemark.Name = "AccountRemark";
            this.AccountRemark.ReadOnly = true;
            // 
            // 分组
            // 
            this.分组.DataPropertyName = "AccountGroupCode";
            this.分组.HeaderText = "分组";
            this.分组.Name = "分组";
            this.分组.ReadOnly = true;
            this.分组.Visible = false;
            // 
            // 添加时间
            // 
            this.添加时间.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.添加时间.DataPropertyName = "AccountAddTime";
            this.添加时间.HeaderText = "添加时间";
            this.添加时间.MinimumWidth = 80;
            this.添加时间.Name = "添加时间";
            this.添加时间.ReadOnly = true;
            // 
            // gridMenu
            // 
            this.gridMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gridUpdate,
            this.gridDelete});
            this.gridMenu.Name = "gridMenu";
            this.gridMenu.Size = new System.Drawing.Size(95, 48);
            // 
            // gridUpdate
            // 
            this.gridUpdate.Image = ((System.Drawing.Image)(resources.GetObject("gridUpdate.Image")));
            this.gridUpdate.Name = "gridUpdate";
            this.gridUpdate.Size = new System.Drawing.Size(94, 22);
            this.gridUpdate.Text = "修改";
            this.gridUpdate.Click += new System.EventHandler(this.gridUpdate_Click);
            // 
            // gridDelete
            // 
            this.gridDelete.Image = ((System.Drawing.Image)(resources.GetObject("gridDelete.Image")));
            this.gridDelete.Name = "gridDelete";
            this.gridDelete.Size = new System.Drawing.Size(94, 22);
            this.gridDelete.Text = "删除";
            this.gridDelete.Click += new System.EventHandler(this.gridDelete_Click);
            // 
            // tvNodeAdd
            // 
            this.tvNodeAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tvMenuAddParentNode,
            this.tvMenuAddChildNode,
            this.tvNodeUpdateNode,
            this.tvNodeDelete});
            this.tvNodeAdd.Name = "tvNodeAdd";
            this.tvNodeAdd.Size = new System.Drawing.Size(143, 92);
            // 
            // tvMenuAddParentNode
            // 
            this.tvMenuAddParentNode.Image = ((System.Drawing.Image)(resources.GetObject("tvMenuAddParentNode.Image")));
            this.tvMenuAddParentNode.Name = "tvMenuAddParentNode";
            this.tvMenuAddParentNode.Size = new System.Drawing.Size(142, 22);
            this.tvMenuAddParentNode.Text = "添加分组";
            this.tvMenuAddParentNode.Click += new System.EventHandler(this.tvMenuAddParentNode_Click);
            // 
            // tvMenuAddChildNode
            // 
            this.tvMenuAddChildNode.Image = ((System.Drawing.Image)(resources.GetObject("tvMenuAddChildNode.Image")));
            this.tvMenuAddChildNode.Name = "tvMenuAddChildNode";
            this.tvMenuAddChildNode.Size = new System.Drawing.Size(142, 22);
            this.tvMenuAddChildNode.Text = "添加子分组";
            this.tvMenuAddChildNode.Click += new System.EventHandler(this.tvMenuAddChildNode_Click);
            // 
            // tvNodeUpdateNode
            // 
            this.tvNodeUpdateNode.Image = ((System.Drawing.Image)(resources.GetObject("tvNodeUpdateNode.Image")));
            this.tvNodeUpdateNode.Name = "tvNodeUpdateNode";
            this.tvNodeUpdateNode.Size = new System.Drawing.Size(142, 22);
            this.tvNodeUpdateNode.Text = "修改分组名称";
            this.tvNodeUpdateNode.Click += new System.EventHandler(this.tvNodeUpdateNode_Click);
            // 
            // tvNodeDelete
            // 
            this.tvNodeDelete.Image = ((System.Drawing.Image)(resources.GetObject("tvNodeDelete.Image")));
            this.tvNodeDelete.Name = "tvNodeDelete";
            this.tvNodeDelete.Size = new System.Drawing.Size(142, 22);
            this.tvNodeDelete.Text = "删除分组";
            this.tvNodeDelete.Click += new System.EventHandler(this.tvNodeDelete_Click);
            // 
            // tvNodeAddParent
            // 
            this.tvNodeAddParent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.tvNodeAddParent.Name = "tvNodeAdd";
            this.tvNodeAddParent.Size = new System.Drawing.Size(143, 48);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(142, 22);
            this.toolStripMenuItem2.Text = "添加子分组";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.tvMenuAddChildNode_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(142, 22);
            this.toolStripMenuItem3.Text = "修改分组名称";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.tvNodeUpdateNode_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.tsbSetPwd,
            this.toolStripSeparator2,
            this.tsbCollapsed,
            this.toolStripSeparator3,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1119, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "新建帐号信息";
            this.toolStripButton1.Click += new System.EventHandler(this.menuCreateAccount_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSetPwd
            // 
            this.tsbSetPwd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSetPwd.Image = ((System.Drawing.Image)(resources.GetObject("tsbSetPwd.Image")));
            this.tsbSetPwd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSetPwd.Name = "tsbSetPwd";
            this.tsbSetPwd.Size = new System.Drawing.Size(23, 22);
            this.tsbSetPwd.Text = "设置开机密码";
            this.tsbSetPwd.Click += new System.EventHandler(this.tsbSetPwd_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbCollapsed
            // 
            this.tsbCollapsed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCollapsed.Image = ((System.Drawing.Image)(resources.GetObject("tsbCollapsed.Image")));
            this.tsbCollapsed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCollapsed.Name = "tsbCollapsed";
            this.tsbCollapsed.Size = new System.Drawing.Size(23, 22);
            this.tsbCollapsed.Text = "收缩";
            this.tsbCollapsed.Click += new System.EventHandler(this.tsbCollapsed_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "退出";
            this.toolStripButton2.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "关于我们";
            this.toolStripButton3.Click += new System.EventHandler(this.tsmAbout_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 598);
            this.Controls.Add(this.sContainer);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "密码管理工具";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.sContainer.Panel1.ResumeLayout(false);
            this.sContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sContainer)).EndInit();
            this.sContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.gridMenu.ResumeLayout(false);
            this.tvNodeAdd.ResumeLayout(false);
            this.tvNodeAddParent.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.SplitContainer sContainer;
        private System.Windows.Forms.ToolStripMenuItem menuCreateAccount;
        private System.Windows.Forms.TreeView tvNodes;
        private System.Windows.Forms.ContextMenuStrip tvNodeAdd;
        private System.Windows.Forms.ToolStripMenuItem tvMenuAddParentNode;
        private System.Windows.Forms.ToolStripMenuItem tvMenuAddChildNode;
        private System.Windows.Forms.ToolStripMenuItem tvNodeUpdateNode;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem tvNodeDelete;
        private System.Windows.Forms.ContextMenuStrip tvNodeAddParent;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem 配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ContextMenuStrip gridMenu;
        private System.Windows.Forms.ToolStripMenuItem gridUpdate;
        private System.Windows.Forms.ToolStripMenuItem gridDelete;
        private System.Windows.Forms.ToolStripMenuItem 设置开机密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAbout;
        private System.Windows.Forms.ToolStripButton tsbSetPwd;
        private System.Windows.Forms.ToolStripButton tsbCollapsed;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 标题;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountPwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountWebsite;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn 分组;
        private System.Windows.Forms.DataGridViewTextBoxColumn 添加时间;
    }
}

