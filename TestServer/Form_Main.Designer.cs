﻿namespace TestServer
{
    partial class MainForm
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
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("General");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Users", 1, 1);
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Groups", 2, 2);
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Users & Groups", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Assign tests to users");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Review passed tests");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Users & Tests", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Load test");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Tests explorer");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Tests", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Reports");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Server", 3, 3);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.panelUsersAndGroups = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelUsers = new System.Windows.Forms.Panel();
            this.rbByGroup = new System.Windows.Forms.RadioButton();
            this.cbUsersFormGroup = new System.Windows.Forms.ComboBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbArhived = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.toolStrip5 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAddUserByCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEditUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDeleteUser = new System.Windows.Forms.ToolStripButton();
            this.label17 = new System.Windows.Forms.Label();
            this.dgvUsersForm_Users = new System.Windows.Forms.DataGridView();
            this.panelGroups = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.toolStrip7 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddUserToGroup = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRemoveUserFromGroup = new System.Windows.Forms.ToolStripButton();
            this.dgvGroupsForm_Users = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip6 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddGroup = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAddGroupByCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEditGroup = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDeleteGroup = new System.Windows.Forms.ToolStripButton();
            this.dgvGroupsForm_Groups = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsAdminGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label18 = new System.Windows.Forms.Label();
            this.panelUsersAndTests = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.panelAssignTestsToUsers = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.panelReviewPassedTests = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.panelTests = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.panelTestsExplorer = new System.Windows.Forms.Panel();
            this.dgvTestsExplorerForm_Folder1 = new System.Windows.Forms.DataGridView();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEditFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDeleteFolder = new System.Windows.Forms.ToolStripButton();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvTestsExplorerForm_Test2 = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvTestsExplorerForm_Folder2 = new System.Windows.Forms.DataGridView();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonMoveR = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMoveL = new System.Windows.Forms.ToolStripButton();
            this.dgvTestsExplorerForm_Test1 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.panelLoadTest = new System.Windows.Forms.Panel();
            this.pictureBoxWarningDone = new System.Windows.Forms.PictureBox();
            this.btnLoadTestForm_Clean = new System.Windows.Forms.Button();
            this.btnLoadTestForm_SaveTestToDB = new System.Windows.Forms.Button();
            this.btnLoadTestForm_LoadTest = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvLoadTestForm_Answers = new System.Windows.Forms.DataGridView();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Right = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.dgvLoadTestForm_Questions = new System.Windows.Forms.DataGridView();
            this.Questions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.numericUpDownMinPass = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMaxPointsForTest = new System.Windows.Forms.TextBox();
            this.tbCountOfQuestions = new System.Windows.Forms.TextBox();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.openXmlFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.bsLoadTestForm_Questions = new System.Windows.Forms.BindingSource(this.components);
            this.bsLoadTestForm_Answers = new System.Windows.Forms.BindingSource(this.components);
            this.bsTestsExplorerForm_Folder1 = new System.Windows.Forms.BindingSource(this.components);
            this.bsTestsExplorerForm_Test1 = new System.Windows.Forms.BindingSource(this.components);
            this.bsTestsExplorerForm_Folder2 = new System.Windows.Forms.BindingSource(this.components);
            this.bsTestsExplorerForm_Test2 = new System.Windows.Forms.BindingSource(this.components);
            this.bsUsersForm_Users = new System.Windows.Forms.BindingSource(this.components);
            this.bsGroupsForm_Groups = new System.Windows.Forms.BindingSource(this.components);
            this.bsGoupsForm_Users = new System.Windows.Forms.BindingSource(this.components);
            this.bsGroupsForm_Users = new System.Windows.Forms.BindingSource(this.components);
            this.panelGeneral.SuspendLayout();
            this.panelUsersAndGroups.SuspendLayout();
            this.panelUsers.SuspendLayout();
            this.toolStrip5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersForm_Users)).BeginInit();
            this.panelGroups.SuspendLayout();
            this.toolStrip7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupsForm_Users)).BeginInit();
            this.toolStrip6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupsForm_Groups)).BeginInit();
            this.panelUsersAndTests.SuspendLayout();
            this.panelAssignTestsToUsers.SuspendLayout();
            this.panelReviewPassedTests.SuspendLayout();
            this.panelTests.SuspendLayout();
            this.panelTestsExplorer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestsExplorerForm_Folder1)).BeginInit();
            this.toolStrip4.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestsExplorerForm_Test2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestsExplorerForm_Folder2)).BeginInit();
            this.toolStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestsExplorerForm_Test1)).BeginInit();
            this.panelLoadTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWarningDone)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadTestForm_Answers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadTestForm_Questions)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLoadTestForm_Questions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLoadTestForm_Answers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTestsExplorerForm_Folder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTestsExplorerForm_Test1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTestsExplorerForm_Folder2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTestsExplorerForm_Test2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsersForm_Users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGroupsForm_Groups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGoupsForm_Users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGroupsForm_Users)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 662);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1261, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1261, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1261, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 49);
            this.treeView1.Name = "treeView1";
            treeNode13.Name = "NodeGeneral";
            treeNode13.Text = "General";
            treeNode14.ImageIndex = 1;
            treeNode14.Name = "NodeUsers";
            treeNode14.SelectedImageIndex = 1;
            treeNode14.Text = "Users";
            treeNode15.ImageIndex = 2;
            treeNode15.Name = "NodeGroups";
            treeNode15.SelectedImageIndex = 2;
            treeNode15.Text = "Groups";
            treeNode16.ImageIndex = 0;
            treeNode16.Name = "NodeUsersAndGroups";
            treeNode16.SelectedImageIndex = 0;
            treeNode16.Text = "Users & Groups";
            treeNode17.Name = "NodeAssignTestsToUsers";
            treeNode17.Text = "Assign tests to users";
            treeNode18.Name = "NodeReviwPassedTests";
            treeNode18.Text = "Review passed tests";
            treeNode19.Name = "NodeUsersAndTests";
            treeNode19.Text = "Users & Tests";
            treeNode20.Name = "NodeLoadTest";
            treeNode20.Text = "Load test";
            treeNode21.Name = "NodeTestsExplorer";
            treeNode21.Text = "Tests explorer";
            treeNode22.Name = "NodeTests";
            treeNode22.Text = "Tests";
            treeNode23.Name = "NodeReports";
            treeNode23.Text = "Reports";
            treeNode24.ImageIndex = 3;
            treeNode24.Name = "NodeServer";
            treeNode24.SelectedImageIndex = 3;
            treeNode24.Text = "Server";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode16,
            treeNode19,
            treeNode22,
            treeNode23,
            treeNode24});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(214, 613);
            this.treeView1.TabIndex = 4;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "userAndGroup.png");
            this.imageList1.Images.SetKeyName(1, "user.png");
            this.imageList1.Images.SetKeyName(2, "group.png");
            this.imageList1.Images.SetKeyName(3, "server.png");
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(214, 49);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 613);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.label23);
            this.panelGeneral.Location = new System.Drawing.Point(254, 77);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(200, 100);
            this.panelGeneral.TabIndex = 9;
            this.panelGeneral.Visible = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(15, 5);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(73, 20);
            this.label23.TabIndex = 22;
            this.label23.Text = "General";
            this.label23.UseMnemonic = false;
            // 
            // panelUsersAndGroups
            // 
            this.panelUsersAndGroups.Controls.Add(this.label1);
            this.panelUsersAndGroups.Controls.Add(this.label3);
            this.panelUsersAndGroups.Controls.Add(this.label2);
            this.panelUsersAndGroups.Location = new System.Drawing.Point(254, 197);
            this.panelUsersAndGroups.Name = "panelUsersAndGroups";
            this.panelUsersAndGroups.Size = new System.Drawing.Size(200, 97);
            this.panelUsersAndGroups.TabIndex = 10;
            this.panelUsersAndGroups.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Users & Groups";
            this.label1.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // panelUsers
            // 
            this.panelUsers.Controls.Add(this.rbByGroup);
            this.panelUsers.Controls.Add(this.cbUsersFormGroup);
            this.panelUsers.Controls.Add(this.rbAll);
            this.panelUsers.Controls.Add(this.rbArhived);
            this.panelUsers.Controls.Add(this.rbActive);
            this.panelUsers.Controls.Add(this.toolStrip5);
            this.panelUsers.Controls.Add(this.label17);
            this.panelUsers.Controls.Add(this.dgvUsersForm_Users);
            this.panelUsers.Location = new System.Drawing.Point(492, 197);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(200, 97);
            this.panelUsers.TabIndex = 11;
            this.panelUsers.Visible = false;
            this.panelUsers.VisibleChanged += new System.EventHandler(this.panelUsers_VisibleChanged);
            // 
            // rbByGroup
            // 
            this.rbByGroup.AutoSize = true;
            this.rbByGroup.Location = new System.Drawing.Point(703, 34);
            this.rbByGroup.Name = "rbByGroup";
            this.rbByGroup.Size = new System.Drawing.Size(73, 19);
            this.rbByGroup.TabIndex = 36;
            this.rbByGroup.Text = "By group";
            this.rbByGroup.UseVisualStyleBackColor = true;
            this.rbByGroup.CheckedChanged += new System.EventHandler(this.rbByGroup_CheckedChanged);
            // 
            // cbUsersFormGroup
            // 
            this.cbUsersFormGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsersFormGroup.Enabled = false;
            this.cbUsersFormGroup.FormattingEnabled = true;
            this.cbUsersFormGroup.Location = new System.Drawing.Point(782, 33);
            this.cbUsersFormGroup.Name = "cbUsersFormGroup";
            this.cbUsersFormGroup.Size = new System.Drawing.Size(237, 23);
            this.cbUsersFormGroup.TabIndex = 35;
            this.cbUsersFormGroup.SelectedIndexChanged += new System.EventHandler(this.cbUsersFormGroup_SelectedIndexChanged);
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(644, 33);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(38, 19);
            this.rbAll.TabIndex = 34;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.Click += new System.EventHandler(this.UsersForm_RadioButtton_Click);
            // 
            // rbArhived
            // 
            this.rbArhived.AutoSize = true;
            this.rbArhived.Location = new System.Drawing.Point(546, 33);
            this.rbArhived.Name = "rbArhived";
            this.rbArhived.Size = new System.Drawing.Size(92, 19);
            this.rbArhived.TabIndex = 33;
            this.rbArhived.Text = "Only arhived";
            this.rbArhived.UseVisualStyleBackColor = true;
            this.rbArhived.Click += new System.EventHandler(this.UsersForm_RadioButtton_Click);
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Checked = true;
            this.rbActive.Location = new System.Drawing.Point(455, 33);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(85, 19);
            this.rbActive.TabIndex = 32;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Only actual";
            this.rbActive.UseVisualStyleBackColor = true;
            this.rbActive.Click += new System.EventHandler(this.UsersForm_RadioButtton_Click);
            // 
            // toolStrip5
            // 
            this.toolStrip5.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip5.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddUser,
            this.toolStripButtonAddUserByCopy,
            this.toolStripSeparator1,
            this.toolStripButtonEditUser,
            this.toolStripSeparator4,
            this.toolStripButtonDeleteUser});
            this.toolStrip5.Location = new System.Drawing.Point(19, 40);
            this.toolStrip5.Name = "toolStrip5";
            this.toolStrip5.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip5.Size = new System.Drawing.Size(115, 27);
            this.toolStrip5.TabIndex = 31;
            this.toolStrip5.Text = "toolStrip5";
            // 
            // toolStripButtonAddUser
            // 
            this.toolStripButtonAddUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddUser.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddUser.Image")));
            this.toolStripButtonAddUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddUser.Name = "toolStripButtonAddUser";
            this.toolStripButtonAddUser.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButtonAddUser.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonAddUser.ToolTipText = "Add user";
            this.toolStripButtonAddUser.Click += new System.EventHandler(this.toolStripButtonAddUser_Click);
            // 
            // toolStripButtonAddUserByCopy
            // 
            this.toolStripButtonAddUserByCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddUserByCopy.Enabled = false;
            this.toolStripButtonAddUserByCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddUserByCopy.Image")));
            this.toolStripButtonAddUserByCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddUserByCopy.Name = "toolStripButtonAddUserByCopy";
            this.toolStripButtonAddUserByCopy.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButtonAddUserByCopy.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonAddUserByCopy.ToolTipText = "Add user by copy";
            this.toolStripButtonAddUserByCopy.Click += new System.EventHandler(this.toolStripButtonAddUserByCopy_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonEditUser
            // 
            this.toolStripButtonEditUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditUser.Enabled = false;
            this.toolStripButtonEditUser.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEditUser.Image")));
            this.toolStripButtonEditUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditUser.Name = "toolStripButtonEditUser";
            this.toolStripButtonEditUser.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButtonEditUser.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonEditUser.ToolTipText = "Edit user";
            this.toolStripButtonEditUser.Click += new System.EventHandler(this.toolStripButtonEditUser_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonDeleteUser
            // 
            this.toolStripButtonDeleteUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDeleteUser.Enabled = false;
            this.toolStripButtonDeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDeleteUser.Image")));
            this.toolStripButtonDeleteUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteUser.Name = "toolStripButtonDeleteUser";
            this.toolStripButtonDeleteUser.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButtonDeleteUser.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonDeleteUser.ToolTipText = "Delete user";
            this.toolStripButtonDeleteUser.Click += new System.EventHandler(this.toolStripButtonDeleteUser_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(15, 5);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 20);
            this.label17.TabIndex = 19;
            this.label17.Text = "Users";
            this.label17.UseMnemonic = false;
            // 
            // dgvUsersForm_Users
            // 
            this.dgvUsersForm_Users.AllowUserToAddRows = false;
            this.dgvUsersForm_Users.AllowUserToDeleteRows = false;
            this.dgvUsersForm_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersForm_Users.Location = new System.Drawing.Point(19, 68);
            this.dgvUsersForm_Users.Name = "dgvUsersForm_Users";
            this.dgvUsersForm_Users.ReadOnly = true;
            this.dgvUsersForm_Users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsersForm_Users.Size = new System.Drawing.Size(1000, 523);
            this.dgvUsersForm_Users.TabIndex = 0;
            this.dgvUsersForm_Users.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsersForm_Users_CellDoubleClick);
            this.dgvUsersForm_Users.SelectionChanged += new System.EventHandler(this.dgvUsersForm_Users_SelectionChanged);
            // 
            // panelGroups
            // 
            this.panelGroups.Controls.Add(this.label26);
            this.panelGroups.Controls.Add(this.textBox1);
            this.panelGroups.Controls.Add(this.label25);
            this.panelGroups.Controls.Add(this.label24);
            this.panelGroups.Controls.Add(this.toolStrip7);
            this.panelGroups.Controls.Add(this.dgvGroupsForm_Users);
            this.panelGroups.Controls.Add(this.toolStrip6);
            this.panelGroups.Controls.Add(this.dgvGroupsForm_Groups);
            this.panelGroups.Controls.Add(this.label18);
            this.panelGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGroups.Location = new System.Drawing.Point(217, 49);
            this.panelGroups.Name = "panelGroups";
            this.panelGroups.Size = new System.Drawing.Size(1044, 613);
            this.panelGroups.TabIndex = 12;
            this.panelGroups.Visible = false;
            this.panelGroups.VisibleChanged += new System.EventHandler(this.panelGroups_VisibleChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(16, 576);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(116, 15);
            this.label26.TabIndex = 39;
            this.label26.Text = "Find group by name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 573);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(411, 21);
            this.textBox1.TabIndex = 38;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(883, 50);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(136, 15);
            this.label25.TabIndex = 37;
            this.label25.Text = "Users in selected group";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(502, 50);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(47, 15);
            this.label24.TabIndex = 36;
            this.label24.Text = "Groups";
            // 
            // toolStrip7
            // 
            this.toolStrip7.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip7.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip7.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddUserToGroup,
            this.toolStripSeparator9,
            this.toolStripButtonRemoveUserFromGroup});
            this.toolStrip7.Location = new System.Drawing.Point(569, 38);
            this.toolStrip7.Name = "toolStrip7";
            this.toolStrip7.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip7.Size = new System.Drawing.Size(59, 27);
            this.toolStrip7.TabIndex = 35;
            this.toolStrip7.Text = "toolStrip7";
            this.toolStrip7.Visible = false;
            // 
            // toolStripButtonAddUserToGroup
            // 
            this.toolStripButtonAddUserToGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddUserToGroup.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddUserToGroup.Image")));
            this.toolStripButtonAddUserToGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddUserToGroup.Name = "toolStripButtonAddUserToGroup";
            this.toolStripButtonAddUserToGroup.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButtonAddUserToGroup.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonAddUserToGroup.ToolTipText = "Add user to selected group";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonRemoveUserFromGroup
            // 
            this.toolStripButtonRemoveUserFromGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRemoveUserFromGroup.Enabled = false;
            this.toolStripButtonRemoveUserFromGroup.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRemoveUserFromGroup.Image")));
            this.toolStripButtonRemoveUserFromGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemoveUserFromGroup.Name = "toolStripButtonRemoveUserFromGroup";
            this.toolStripButtonRemoveUserFromGroup.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButtonRemoveUserFromGroup.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonRemoveUserFromGroup.ToolTipText = "Remove user from selected group";
            // 
            // dgvGroupsForm_Users
            // 
            this.dgvGroupsForm_Users.AllowUserToAddRows = false;
            this.dgvGroupsForm_Users.AllowUserToDeleteRows = false;
            this.dgvGroupsForm_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupsForm_Users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvGroupsForm_Users.Location = new System.Drawing.Point(569, 68);
            this.dgvGroupsForm_Users.MultiSelect = false;
            this.dgvGroupsForm_Users.Name = "dgvGroupsForm_Users";
            this.dgvGroupsForm_Users.ReadOnly = true;
            this.dgvGroupsForm_Users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroupsForm_Users.Size = new System.Drawing.Size(450, 523);
            this.dgvGroupsForm_Users.TabIndex = 34;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Login";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "First name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Last name";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // toolStrip6
            // 
            this.toolStrip6.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip6.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddGroup,
            this.toolStripButtonAddGroupByCopy,
            this.toolStripSeparator6,
            this.toolStripButtonEditGroup,
            this.toolStripSeparator7,
            this.toolStripButtonDeleteGroup});
            this.toolStrip6.Location = new System.Drawing.Point(19, 38);
            this.toolStrip6.Name = "toolStrip6";
            this.toolStrip6.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip6.Size = new System.Drawing.Size(115, 27);
            this.toolStrip6.TabIndex = 33;
            this.toolStrip6.Text = "toolStrip6";
            // 
            // toolStripButtonAddGroup
            // 
            this.toolStripButtonAddGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddGroup.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddGroup.Image")));
            this.toolStripButtonAddGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddGroup.Name = "toolStripButtonAddGroup";
            this.toolStripButtonAddGroup.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButtonAddGroup.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonAddGroup.ToolTipText = "Add group";
            this.toolStripButtonAddGroup.Click += new System.EventHandler(this.toolStripButtonAddGroup_Click);
            // 
            // toolStripButtonAddGroupByCopy
            // 
            this.toolStripButtonAddGroupByCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddGroupByCopy.Enabled = false;
            this.toolStripButtonAddGroupByCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddGroupByCopy.Image")));
            this.toolStripButtonAddGroupByCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddGroupByCopy.Name = "toolStripButtonAddGroupByCopy";
            this.toolStripButtonAddGroupByCopy.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButtonAddGroupByCopy.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonAddGroupByCopy.ToolTipText = "Add group by copy";
            this.toolStripButtonAddGroupByCopy.Click += new System.EventHandler(this.toolStripButtonAddGroupByCopy_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonEditGroup
            // 
            this.toolStripButtonEditGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditGroup.Enabled = false;
            this.toolStripButtonEditGroup.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEditGroup.Image")));
            this.toolStripButtonEditGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditGroup.Name = "toolStripButtonEditGroup";
            this.toolStripButtonEditGroup.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButtonEditGroup.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonEditGroup.ToolTipText = "Edit group";
            this.toolStripButtonEditGroup.Click += new System.EventHandler(this.toolStripButtonEditGroup_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonDeleteGroup
            // 
            this.toolStripButtonDeleteGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDeleteGroup.Enabled = false;
            this.toolStripButtonDeleteGroup.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDeleteGroup.Image")));
            this.toolStripButtonDeleteGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteGroup.Name = "toolStripButtonDeleteGroup";
            this.toolStripButtonDeleteGroup.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButtonDeleteGroup.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonDeleteGroup.ToolTipText = "Delete group";
            this.toolStripButtonDeleteGroup.Click += new System.EventHandler(this.toolStripButtonDeleteGroup_Click);
            // 
            // dgvGroupsForm_Groups
            // 
            this.dgvGroupsForm_Groups.AllowUserToAddRows = false;
            this.dgvGroupsForm_Groups.AllowUserToDeleteRows = false;
            this.dgvGroupsForm_Groups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupsForm_Groups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.GroupName,
            this.Description,
            this.IsAdminGroup});
            this.dgvGroupsForm_Groups.Location = new System.Drawing.Point(19, 68);
            this.dgvGroupsForm_Groups.MultiSelect = false;
            this.dgvGroupsForm_Groups.Name = "dgvGroupsForm_Groups";
            this.dgvGroupsForm_Groups.ReadOnly = true;
            this.dgvGroupsForm_Groups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroupsForm_Groups.Size = new System.Drawing.Size(530, 499);
            this.dgvGroupsForm_Groups.TabIndex = 32;
            this.dgvGroupsForm_Groups.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroupsForm_Groups_CellDoubleClick);
            this.dgvGroupsForm_Groups.SelectionChanged += new System.EventHandler(this.dgvGroupsForm_Groups_SelectionChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // GroupName
            // 
            this.GroupName.HeaderText = "GroupName";
            this.GroupName.Name = "GroupName";
            this.GroupName.ReadOnly = true;
            this.GroupName.Width = 140;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 190;
            // 
            // IsAdminGroup
            // 
            this.IsAdminGroup.HeaderText = "Admin group";
            this.IsAdminGroup.Name = "IsAdminGroup";
            this.IsAdminGroup.ReadOnly = true;
            this.IsAdminGroup.Width = 90;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(15, 5);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 20);
            this.label18.TabIndex = 19;
            this.label18.Text = "Groups";
            this.label18.UseMnemonic = false;
            // 
            // panelUsersAndTests
            // 
            this.panelUsersAndTests.Controls.Add(this.label19);
            this.panelUsersAndTests.Location = new System.Drawing.Point(254, 327);
            this.panelUsersAndTests.Name = "panelUsersAndTests";
            this.panelUsersAndTests.Size = new System.Drawing.Size(200, 100);
            this.panelUsersAndTests.TabIndex = 13;
            this.panelUsersAndTests.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(15, 5);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(122, 20);
            this.label19.TabIndex = 19;
            this.label19.Text = "Users & Tests";
            this.label19.UseMnemonic = false;
            // 
            // panelAssignTestsToUsers
            // 
            this.panelAssignTestsToUsers.Controls.Add(this.label20);
            this.panelAssignTestsToUsers.Location = new System.Drawing.Point(492, 327);
            this.panelAssignTestsToUsers.Name = "panelAssignTestsToUsers";
            this.panelAssignTestsToUsers.Size = new System.Drawing.Size(200, 100);
            this.panelAssignTestsToUsers.TabIndex = 14;
            this.panelAssignTestsToUsers.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(15, 5);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(169, 20);
            this.label20.TabIndex = 20;
            this.label20.Text = "Assign tests to user";
            this.label20.UseMnemonic = false;
            // 
            // panelReviewPassedTests
            // 
            this.panelReviewPassedTests.Controls.Add(this.label21);
            this.panelReviewPassedTests.Location = new System.Drawing.Point(732, 327);
            this.panelReviewPassedTests.Name = "panelReviewPassedTests";
            this.panelReviewPassedTests.Size = new System.Drawing.Size(200, 100);
            this.panelReviewPassedTests.TabIndex = 15;
            this.panelReviewPassedTests.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(15, 5);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(174, 20);
            this.label21.TabIndex = 21;
            this.label21.Text = "Review passed tests";
            this.label21.UseMnemonic = false;
            // 
            // panelTests
            // 
            this.panelTests.Controls.Add(this.label22);
            this.panelTests.Location = new System.Drawing.Point(254, 458);
            this.panelTests.Name = "panelTests";
            this.panelTests.Size = new System.Drawing.Size(200, 100);
            this.panelTests.TabIndex = 16;
            this.panelTests.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(15, 5);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 20);
            this.label22.TabIndex = 22;
            this.label22.Text = "Tests";
            this.label22.UseMnemonic = false;
            // 
            // panelTestsExplorer
            // 
            this.panelTestsExplorer.Controls.Add(this.dgvTestsExplorerForm_Folder1);
            this.panelTestsExplorer.Controls.Add(this.toolStrip4);
            this.panelTestsExplorer.Controls.Add(this.toolStrip2);
            this.panelTestsExplorer.Controls.Add(this.label16);
            this.panelTestsExplorer.Controls.Add(this.dgvTestsExplorerForm_Test2);
            this.panelTestsExplorer.Controls.Add(this.label15);
            this.panelTestsExplorer.Controls.Add(this.label14);
            this.panelTestsExplorer.Controls.Add(this.label13);
            this.panelTestsExplorer.Controls.Add(this.dgvTestsExplorerForm_Folder2);
            this.panelTestsExplorer.Controls.Add(this.toolStrip3);
            this.panelTestsExplorer.Controls.Add(this.dgvTestsExplorerForm_Test1);
            this.panelTestsExplorer.Controls.Add(this.label12);
            this.panelTestsExplorer.Location = new System.Drawing.Point(732, 458);
            this.panelTestsExplorer.Name = "panelTestsExplorer";
            this.panelTestsExplorer.Size = new System.Drawing.Size(200, 100);
            this.panelTestsExplorer.TabIndex = 18;
            this.panelTestsExplorer.Visible = false;
            this.panelTestsExplorer.VisibleChanged += new System.EventHandler(this.panelTestsExplorer_VisibleChanged);
            // 
            // dgvTestsExplorerForm_Folder1
            // 
            this.dgvTestsExplorerForm_Folder1.AllowUserToAddRows = false;
            this.dgvTestsExplorerForm_Folder1.AllowUserToDeleteRows = false;
            this.dgvTestsExplorerForm_Folder1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestsExplorerForm_Folder1.Location = new System.Drawing.Point(19, 56);
            this.dgvTestsExplorerForm_Folder1.MultiSelect = false;
            this.dgvTestsExplorerForm_Folder1.Name = "dgvTestsExplorerForm_Folder1";
            this.dgvTestsExplorerForm_Folder1.ReadOnly = true;
            this.dgvTestsExplorerForm_Folder1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTestsExplorerForm_Folder1.Size = new System.Drawing.Size(480, 216);
            this.dgvTestsExplorerForm_Folder1.TabIndex = 33;
            this.dgvTestsExplorerForm_Folder1.SelectionChanged += new System.EventHandler(this.dgvTestsExplorerForm_Folder1_SelectionChanged);
            // 
            // toolStrip4
            // 
            this.toolStrip4.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripSeparator5,
            this.toolStripButton6});
            this.toolStrip4.Location = new System.Drawing.Point(544, 291);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip4.Size = new System.Drawing.Size(66, 27);
            this.toolStrip4.TabIndex = 32;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Enabled = false;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton3.ToolTipText = "Edit question";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Enabled = false;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButton6.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton6.ToolTipText = "Delete question";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddFolder,
            this.toolStripSeparator2,
            this.toolStripButtonEditFolder,
            this.toolStripSeparator3,
            this.toolStripButtonDeleteFolder});
            this.toolStrip2.Location = new System.Drawing.Point(544, 28);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip2.Size = new System.Drawing.Size(96, 27);
            this.toolStrip2.TabIndex = 31;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButtonAddFolder
            // 
            this.toolStripButtonAddFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddFolder.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddFolder.Image")));
            this.toolStripButtonAddFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddFolder.Name = "toolStripButtonAddFolder";
            this.toolStripButtonAddFolder.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButtonAddFolder.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonAddFolder.ToolTipText = "Add folder";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonEditFolder
            // 
            this.toolStripButtonEditFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditFolder.Enabled = false;
            this.toolStripButtonEditFolder.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEditFolder.Image")));
            this.toolStripButtonEditFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditFolder.Name = "toolStripButtonEditFolder";
            this.toolStripButtonEditFolder.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButtonEditFolder.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonEditFolder.Text = "Edit question";
            this.toolStripButtonEditFolder.ToolTipText = "Edit folder";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonDeleteFolder
            // 
            this.toolStripButtonDeleteFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDeleteFolder.Enabled = false;
            this.toolStripButtonDeleteFolder.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDeleteFolder.Image")));
            this.toolStripButtonDeleteFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteFolder.Name = "toolStripButtonDeleteFolder";
            this.toolStripButtonDeleteFolder.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButtonDeleteFolder.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonDeleteFolder.Text = "Delete question";
            this.toolStripButtonDeleteFolder.ToolTipText = "Delete folder";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 303);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 15);
            this.label16.TabIndex = 28;
            this.label16.Text = "Tests";
            // 
            // dgvTestsExplorerForm_Test2
            // 
            this.dgvTestsExplorerForm_Test2.AllowUserToAddRows = false;
            this.dgvTestsExplorerForm_Test2.AllowUserToDeleteRows = false;
            this.dgvTestsExplorerForm_Test2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestsExplorerForm_Test2.Location = new System.Drawing.Point(544, 321);
            this.dgvTestsExplorerForm_Test2.MultiSelect = false;
            this.dgvTestsExplorerForm_Test2.Name = "dgvTestsExplorerForm_Test2";
            this.dgvTestsExplorerForm_Test2.ReadOnly = true;
            this.dgvTestsExplorerForm_Test2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTestsExplorerForm_Test2.Size = new System.Drawing.Size(480, 270);
            this.dgvTestsExplorerForm_Test2.TabIndex = 27;
            this.dgvTestsExplorerForm_Test2.SelectionChanged += new System.EventHandler(this.dgvTestsExplorerForm_Test2_SelectionChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(988, 303);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 15);
            this.label15.TabIndex = 26;
            this.label15.Text = "Tests";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(976, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 15);
            this.label14.TabIndex = 25;
            this.label14.Text = "Folders";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 15);
            this.label13.TabIndex = 24;
            this.label13.Text = "Folders";
            // 
            // dgvTestsExplorerForm_Folder2
            // 
            this.dgvTestsExplorerForm_Folder2.AllowUserToAddRows = false;
            this.dgvTestsExplorerForm_Folder2.AllowUserToDeleteRows = false;
            this.dgvTestsExplorerForm_Folder2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestsExplorerForm_Folder2.Location = new System.Drawing.Point(544, 56);
            this.dgvTestsExplorerForm_Folder2.MultiSelect = false;
            this.dgvTestsExplorerForm_Folder2.Name = "dgvTestsExplorerForm_Folder2";
            this.dgvTestsExplorerForm_Folder2.ReadOnly = true;
            this.dgvTestsExplorerForm_Folder2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTestsExplorerForm_Folder2.Size = new System.Drawing.Size(480, 216);
            this.dgvTestsExplorerForm_Folder2.TabIndex = 23;
            this.dgvTestsExplorerForm_Folder2.SelectionChanged += new System.EventHandler(this.dgvTestsExplorerForm_Folder2_SelectionChanged);
            // 
            // toolStrip3
            // 
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonMoveR,
            this.toolStripButtonMoveL});
            this.toolStrip3.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip3.Location = new System.Drawing.Point(510, 367);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(25, 65);
            this.toolStrip3.TabIndex = 22;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripButtonMoveR
            // 
            this.toolStripButtonMoveR.AutoSize = false;
            this.toolStripButtonMoveR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMoveR.Enabled = false;
            this.toolStripButtonMoveR.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMoveR.Image")));
            this.toolStripButtonMoveR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMoveR.Name = "toolStripButtonMoveR";
            this.toolStripButtonMoveR.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButtonMoveR.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonMoveR.ToolTipText = "Move test";
            this.toolStripButtonMoveR.Click += new System.EventHandler(this.toolStripButtonMoveR_Click);
            // 
            // toolStripButtonMoveL
            // 
            this.toolStripButtonMoveL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMoveL.Enabled = false;
            this.toolStripButtonMoveL.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMoveL.Image")));
            this.toolStripButtonMoveL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMoveL.Name = "toolStripButtonMoveL";
            this.toolStripButtonMoveL.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButtonMoveL.Size = new System.Drawing.Size(23, 24);
            this.toolStripButtonMoveL.ToolTipText = "Move test";
            this.toolStripButtonMoveL.Click += new System.EventHandler(this.toolStripButtonMoveL_Click);
            // 
            // dgvTestsExplorerForm_Test1
            // 
            this.dgvTestsExplorerForm_Test1.AllowUserToAddRows = false;
            this.dgvTestsExplorerForm_Test1.AllowUserToDeleteRows = false;
            this.dgvTestsExplorerForm_Test1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestsExplorerForm_Test1.Location = new System.Drawing.Point(19, 321);
            this.dgvTestsExplorerForm_Test1.MultiSelect = false;
            this.dgvTestsExplorerForm_Test1.Name = "dgvTestsExplorerForm_Test1";
            this.dgvTestsExplorerForm_Test1.ReadOnly = true;
            this.dgvTestsExplorerForm_Test1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTestsExplorerForm_Test1.Size = new System.Drawing.Size(480, 270);
            this.dgvTestsExplorerForm_Test1.TabIndex = 20;
            this.dgvTestsExplorerForm_Test1.SelectionChanged += new System.EventHandler(this.dgvTestsExplorerForm_Test1_SelectionChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(15, 5);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Tests explorer";
            // 
            // panelLoadTest
            // 
            this.panelLoadTest.Controls.Add(this.pictureBoxWarningDone);
            this.panelLoadTest.Controls.Add(this.btnLoadTestForm_Clean);
            this.panelLoadTest.Controls.Add(this.btnLoadTestForm_SaveTestToDB);
            this.panelLoadTest.Controls.Add(this.btnLoadTestForm_LoadTest);
            this.panelLoadTest.Controls.Add(this.label8);
            this.panelLoadTest.Controls.Add(this.groupBox2);
            this.panelLoadTest.Controls.Add(this.groupBox1);
            this.panelLoadTest.Location = new System.Drawing.Point(495, 458);
            this.panelLoadTest.Name = "panelLoadTest";
            this.panelLoadTest.Size = new System.Drawing.Size(197, 100);
            this.panelLoadTest.TabIndex = 17;
            this.panelLoadTest.Visible = false;
            // 
            // pictureBoxWarningDone
            // 
            this.pictureBoxWarningDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxWarningDone.Image = global::TestServer.Properties.Resources.warning;
            this.pictureBoxWarningDone.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxWarningDone.InitialImage")));
            this.pictureBoxWarningDone.Location = new System.Drawing.Point(837, 570);
            this.pictureBoxWarningDone.Name = "pictureBoxWarningDone";
            this.pictureBoxWarningDone.Size = new System.Drawing.Size(27, 27);
            this.pictureBoxWarningDone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWarningDone.TabIndex = 6;
            this.pictureBoxWarningDone.TabStop = false;
            this.pictureBoxWarningDone.Visible = false;
            // 
            // btnLoadTestForm_Clean
            // 
            this.btnLoadTestForm_Clean.Location = new System.Drawing.Point(930, 16);
            this.btnLoadTestForm_Clean.Name = "btnLoadTestForm_Clean";
            this.btnLoadTestForm_Clean.Size = new System.Drawing.Size(90, 27);
            this.btnLoadTestForm_Clean.TabIndex = 20;
            this.btnLoadTestForm_Clean.Text = "Clean form";
            this.btnLoadTestForm_Clean.UseVisualStyleBackColor = true;
            this.btnLoadTestForm_Clean.Click += new System.EventHandler(this.btnLoadTestForm_Clean_Click);
            // 
            // btnLoadTestForm_SaveTestToDB
            // 
            this.btnLoadTestForm_SaveTestToDB.Enabled = false;
            this.btnLoadTestForm_SaveTestToDB.Location = new System.Drawing.Point(870, 570);
            this.btnLoadTestForm_SaveTestToDB.Name = "btnLoadTestForm_SaveTestToDB";
            this.btnLoadTestForm_SaveTestToDB.Size = new System.Drawing.Size(122, 27);
            this.btnLoadTestForm_SaveTestToDB.TabIndex = 19;
            this.btnLoadTestForm_SaveTestToDB.Text = "Save test to DB";
            this.btnLoadTestForm_SaveTestToDB.UseVisualStyleBackColor = true;
            this.btnLoadTestForm_SaveTestToDB.Click += new System.EventHandler(this.btnLoadTestForm_SaveTestToDB_Click);
            // 
            // btnLoadTestForm_LoadTest
            // 
            this.btnLoadTestForm_LoadTest.Location = new System.Drawing.Point(645, 570);
            this.btnLoadTestForm_LoadTest.Name = "btnLoadTestForm_LoadTest";
            this.btnLoadTestForm_LoadTest.Size = new System.Drawing.Size(122, 27);
            this.btnLoadTestForm_LoadTest.TabIndex = 18;
            this.btnLoadTestForm_LoadTest.Text = "Load test from file";
            this.btnLoadTestForm_LoadTest.UseVisualStyleBackColor = true;
            this.btnLoadTestForm_LoadTest.Click += new System.EventHandler(this.btnLoadTestForm_LoadTest_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(15, 3);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Load test";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvLoadTestForm_Answers);
            this.groupBox2.Controls.Add(this.pictureBox);
            this.groupBox2.Controls.Add(this.dgvLoadTestForm_Questions);
            this.groupBox2.Location = new System.Drawing.Point(329, 49);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(691, 500);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Questions";
            // 
            // dgvLoadTestForm_Answers
            // 
            this.dgvLoadTestForm_Answers.AllowUserToAddRows = false;
            this.dgvLoadTestForm_Answers.AllowUserToDeleteRows = false;
            this.dgvLoadTestForm_Answers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoadTestForm_Answers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Answer,
            this.Right});
            this.dgvLoadTestForm_Answers.Location = new System.Drawing.Point(226, 287);
            this.dgvLoadTestForm_Answers.MultiSelect = false;
            this.dgvLoadTestForm_Answers.Name = "dgvLoadTestForm_Answers";
            this.dgvLoadTestForm_Answers.ReadOnly = true;
            this.dgvLoadTestForm_Answers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoadTestForm_Answers.Size = new System.Drawing.Size(447, 196);
            this.dgvLoadTestForm_Answers.TabIndex = 5;
            // 
            // Answer
            // 
            this.Answer.HeaderText = "Answer";
            this.Answer.Name = "Answer";
            this.Answer.ReadOnly = true;
            this.Answer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Answer.Width = 290;
            // 
            // Right
            // 
            this.Right.HeaderText = "Is right";
            this.Right.Name = "Right";
            this.Right.ReadOnly = true;
            this.Right.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Right.Width = 90;
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Image = global::TestServer.Properties.Resources.nophoto;
            this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
            this.pictureBox.Location = new System.Drawing.Point(16, 287);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(196, 196);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // dgvLoadTestForm_Questions
            // 
            this.dgvLoadTestForm_Questions.AllowUserToAddRows = false;
            this.dgvLoadTestForm_Questions.AllowUserToDeleteRows = false;
            this.dgvLoadTestForm_Questions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoadTestForm_Questions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Questions,
            this.Point});
            this.dgvLoadTestForm_Questions.Location = new System.Drawing.Point(16, 32);
            this.dgvLoadTestForm_Questions.MultiSelect = false;
            this.dgvLoadTestForm_Questions.Name = "dgvLoadTestForm_Questions";
            this.dgvLoadTestForm_Questions.ReadOnly = true;
            this.dgvLoadTestForm_Questions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoadTestForm_Questions.Size = new System.Drawing.Size(657, 242);
            this.dgvLoadTestForm_Questions.TabIndex = 3;
            this.dgvLoadTestForm_Questions.SelectionChanged += new System.EventHandler(this.dgvLoadTestForm_Questions_SelectionChanged);
            // 
            // Questions
            // 
            this.Questions.Frozen = true;
            this.Questions.HeaderText = "Question";
            this.Questions.Name = "Questions";
            this.Questions.ReadOnly = true;
            this.Questions.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Questions.Width = 500;
            // 
            // Point
            // 
            this.Point.Frozen = true;
            this.Point.HeaderText = "Point";
            this.Point.Name = "Point";
            this.Point.ReadOnly = true;
            this.Point.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Point.Width = 90;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTitle);
            this.groupBox1.Controls.Add(this.numericUpDownMinPass);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbMaxPointsForTest);
            this.groupBox1.Controls.Add(this.tbCountOfQuestions);
            this.groupBox1.Controls.Add(this.tbInfo);
            this.groupBox1.Controls.Add(this.tbDescription);
            this.groupBox1.Controls.Add(this.tbAuthor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(19, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(302, 500);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(89, 32);
            this.tbTitle.Multiline = true;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.ReadOnly = true;
            this.tbTitle.Size = new System.Drawing.Size(197, 50);
            this.tbTitle.TabIndex = 17;
            // 
            // numericUpDownMinPass
            // 
            this.numericUpDownMinPass.Location = new System.Drawing.Point(170, 462);
            this.numericUpDownMinPass.Name = "numericUpDownMinPass";
            this.numericUpDownMinPass.ReadOnly = true;
            this.numericUpDownMinPass.Size = new System.Drawing.Size(117, 21);
            this.numericUpDownMinPass.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 464);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Minimum passing percent";
            // 
            // tbMaxPointsForTest
            // 
            this.tbMaxPointsForTest.Location = new System.Drawing.Point(153, 434);
            this.tbMaxPointsForTest.Name = "tbMaxPointsForTest";
            this.tbMaxPointsForTest.ReadOnly = true;
            this.tbMaxPointsForTest.Size = new System.Drawing.Size(134, 21);
            this.tbMaxPointsForTest.TabIndex = 15;
            // 
            // tbCountOfQuestions
            // 
            this.tbCountOfQuestions.Location = new System.Drawing.Point(152, 407);
            this.tbCountOfQuestions.Name = "tbCountOfQuestions";
            this.tbCountOfQuestions.ReadOnly = true;
            this.tbCountOfQuestions.Size = new System.Drawing.Size(134, 21);
            this.tbCountOfQuestions.TabIndex = 14;
            // 
            // tbInfo
            // 
            this.tbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInfo.Location = new System.Drawing.Point(90, 261);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.Size = new System.Drawing.Size(197, 140);
            this.tbInfo.TabIndex = 13;
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDescription.Location = new System.Drawing.Point(89, 115);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.Size = new System.Drawing.Size(197, 140);
            this.tbDescription.TabIndex = 12;
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(89, 88);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.ReadOnly = true;
            this.tbAuthor.Size = new System.Drawing.Size(197, 21);
            this.tbAuthor.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 437);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Maximum point for test";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 410);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Count of questions";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(13, 264);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 39);
            this.label4.TabIndex = 6;
            this.label4.Text = "Info for test taker";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 118);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 35);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "Title";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 91);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "Author";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 684);
            this.Controls.Add(this.panelGroups);
            this.Controls.Add(this.panelUsers);
            this.Controls.Add(this.panelTestsExplorer);
            this.Controls.Add(this.panelLoadTest);
            this.Controls.Add(this.panelTests);
            this.Controls.Add(this.panelUsersAndGroups);
            this.Controls.Add(this.panelReviewPassedTests);
            this.Controls.Add(this.panelAssignTestsToUsers);
            this.Controls.Add(this.panelUsersAndTests);
            this.Controls.Add(this.panelGeneral);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelGeneral.ResumeLayout(false);
            this.panelGeneral.PerformLayout();
            this.panelUsersAndGroups.ResumeLayout(false);
            this.panelUsersAndGroups.PerformLayout();
            this.panelUsers.ResumeLayout(false);
            this.panelUsers.PerformLayout();
            this.toolStrip5.ResumeLayout(false);
            this.toolStrip5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersForm_Users)).EndInit();
            this.panelGroups.ResumeLayout(false);
            this.panelGroups.PerformLayout();
            this.toolStrip7.ResumeLayout(false);
            this.toolStrip7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupsForm_Users)).EndInit();
            this.toolStrip6.ResumeLayout(false);
            this.toolStrip6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupsForm_Groups)).EndInit();
            this.panelUsersAndTests.ResumeLayout(false);
            this.panelUsersAndTests.PerformLayout();
            this.panelAssignTestsToUsers.ResumeLayout(false);
            this.panelAssignTestsToUsers.PerformLayout();
            this.panelReviewPassedTests.ResumeLayout(false);
            this.panelReviewPassedTests.PerformLayout();
            this.panelTests.ResumeLayout(false);
            this.panelTests.PerformLayout();
            this.panelTestsExplorer.ResumeLayout(false);
            this.panelTestsExplorer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestsExplorerForm_Folder1)).EndInit();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestsExplorerForm_Test2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestsExplorerForm_Folder2)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestsExplorerForm_Test1)).EndInit();
            this.panelLoadTest.ResumeLayout(false);
            this.panelLoadTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWarningDone)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadTestForm_Answers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadTestForm_Questions)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLoadTestForm_Questions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLoadTestForm_Answers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTestsExplorerForm_Folder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTestsExplorerForm_Test1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTestsExplorerForm_Folder2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTestsExplorerForm_Test2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsersForm_Users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGroupsForm_Groups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGoupsForm_Users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGroupsForm_Users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.Panel panelUsersAndGroups;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelUsers;
        private System.Windows.Forms.Panel panelGroups;
        private System.Windows.Forms.Panel panelUsersAndTests;
        private System.Windows.Forms.Panel panelAssignTestsToUsers;
        private System.Windows.Forms.Panel panelReviewPassedTests;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvUsersForm_Users;
        private System.Windows.Forms.BindingSource bsLoadTestForm_Questions;
        private System.Windows.Forms.Panel panelTests;
        private System.Windows.Forms.Panel panelTestsExplorer;
        private System.Windows.Forms.Panel panelLoadTest;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvLoadTestForm_Answers;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.DataGridView dgvLoadTestForm_Questions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownMinPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMaxPointsForTest;
        private System.Windows.Forms.TextBox tbCountOfQuestions;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnLoadTestForm_LoadTest;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLoadTestForm_SaveTestToDB;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.OpenFileDialog openXmlFileDialog;
        private System.Windows.Forms.BindingSource bsLoadTestForm_Answers;
        private System.Windows.Forms.Button btnLoadTestForm_Clean;
        private System.Windows.Forms.DataGridViewTextBoxColumn Questions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Point;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Right;
        private System.Windows.Forms.PictureBox pictureBoxWarningDone;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.DataGridView dgvTestsExplorerForm_Test1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvTestsExplorerForm_Folder2;
        private System.Windows.Forms.BindingSource bsTestsExplorerForm_Folder1;
        private System.Windows.Forms.BindingSource bsTestsExplorerForm_Test1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvTestsExplorerForm_Test2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteFolder;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ToolStripButton toolStripButtonMoveR;
        private System.Windows.Forms.DataGridView dgvTestsExplorerForm_Folder1;
        private System.Windows.Forms.BindingSource bsTestsExplorerForm_Folder2;
        private System.Windows.Forms.BindingSource bsTestsExplorerForm_Test2;
        private System.Windows.Forms.ToolStripButton toolStripButtonMoveL;
        private System.Windows.Forms.RadioButton rbByGroup;
        private System.Windows.Forms.ComboBox cbUsersFormGroup;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbArhived;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.ToolStrip toolStrip5;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddUser;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddUserByCopy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteUser;
        private System.Windows.Forms.BindingSource bsUsersForm_Users;
        private System.Windows.Forms.ToolStrip toolStrip6;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddGroup;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddGroupByCopy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditGroup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteGroup;
        private System.Windows.Forms.DataGridView dgvGroupsForm_Groups;
        private System.Windows.Forms.DataGridView dgvGroupsForm_Users;
        private System.Windows.Forms.ToolStrip toolStrip7;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddUserToGroup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemoveUserFromGroup;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource bsGroupsForm_Groups;
        private System.Windows.Forms.BindingSource bsGoupsForm_Users;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsAdminGroup;
        private System.Windows.Forms.BindingSource bsGroupsForm_Users;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

