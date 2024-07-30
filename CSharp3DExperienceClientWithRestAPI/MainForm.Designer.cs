namespace CSharp3DExperienceClientWithRestAPI
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panLogin = new System.Windows.Forms.Panel();
            this.grSecurityContext = new System.Windows.Forms.GroupBox();
            this.lbSecurityContext = new System.Windows.Forms.Label();
            this.cmbSecurityContext = new System.Windows.Forms.ComboBox();
            this.grLogin = new System.Windows.Forms.GroupBox();
            this.ckRememberMe = new System.Windows.Forms.CheckBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbSearchBox = new System.Windows.Forms.Label();
            this.btnSearchEngObj = new System.Windows.Forms.Button();
            this.btnSearchDrawing = new System.Windows.Forms.Button();
            this.myTabs = new System.Windows.Forms.TabControl();
            this.tabExternal = new System.Windows.Forms.TabPage();
            this.link3 = new System.Windows.Forms.LinkLabel();
            this.link2 = new System.Windows.Forms.LinkLabel();
            this.link1 = new System.Windows.Forms.LinkLabel();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.tabLearn = new System.Windows.Forms.TabPage();
            this.linkLearn = new System.Windows.Forms.LinkLabel();
            this.linkUQL = new System.Windows.Forms.LinkLabel();
            this.linkDevelepoer = new System.Windows.Forms.LinkLabel();
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTotalItem = new System.Windows.Forms.Label();
            this.rightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rightClickERP = new System.Windows.Forms.ToolStripMenuItem();
            this.rightClickMES = new System.Windows.Forms.ToolStripMenuItem();
            this.creation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panLogin.SuspendLayout();
            this.grSecurityContext.SuspendLayout();
            this.grLogin.SuspendLayout();
            this.myTabs.SuspendLayout();
            this.tabExternal.SuspendLayout();
            this.tabSearch.SuspendLayout();
            this.tabLearn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.rightClickMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("3DS V2", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(733, 14);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(173, 57);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Connect to 3DEXPERIENCE";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(12, 39);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(255, 22);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Tag = "";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(291, 39);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(255, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // panLogin
            // 
            this.panLogin.Controls.Add(this.grLogin);
            this.panLogin.Controls.Add(this.btnLogin);
            this.panLogin.Controls.Add(this.grSecurityContext);
            this.panLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panLogin.Location = new System.Drawing.Point(0, 0);
            this.panLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panLogin.Name = "panLogin";
            this.panLogin.Size = new System.Drawing.Size(919, 86);
            this.panLogin.TabIndex = 3;
            // 
            // grSecurityContext
            // 
            this.grSecurityContext.Controls.Add(this.lbSecurityContext);
            this.grSecurityContext.Controls.Add(this.cmbSecurityContext);
            this.grSecurityContext.Location = new System.Drawing.Point(8, 4);
            this.grSecurityContext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grSecurityContext.Name = "grSecurityContext";
            this.grSecurityContext.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grSecurityContext.Size = new System.Drawing.Size(717, 75);
            this.grSecurityContext.TabIndex = 4;
            this.grSecurityContext.TabStop = false;
            // 
            // lbSecurityContext
            // 
            this.lbSecurityContext.AutoSize = true;
            this.lbSecurityContext.Font = new System.Drawing.Font("3DS V2", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSecurityContext.Location = new System.Drawing.Point(105, 33);
            this.lbSecurityContext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSecurityContext.Name = "lbSecurityContext";
            this.lbSecurityContext.Size = new System.Drawing.Size(216, 20);
            this.lbSecurityContext.TabIndex = 4;
            this.lbSecurityContext.Text = "Please select Security Context:";
            // 
            // cmbSecurityContext
            // 
            this.cmbSecurityContext.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSecurityContext.Font = new System.Drawing.Font("3DS V2", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSecurityContext.FormattingEnabled = true;
            this.cmbSecurityContext.Location = new System.Drawing.Point(368, 28);
            this.cmbSecurityContext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSecurityContext.Name = "cmbSecurityContext";
            this.cmbSecurityContext.Size = new System.Drawing.Size(329, 30);
            this.cmbSecurityContext.TabIndex = 4;
            this.cmbSecurityContext.SelectedIndexChanged += new System.EventHandler(this.cmbSecurityContext_SelectedIndexChanged);
            // 
            // grLogin
            // 
            this.grLogin.Controls.Add(this.ckRememberMe);
            this.grLogin.Controls.Add(this.lbUsername);
            this.grLogin.Controls.Add(this.txtPassword);
            this.grLogin.Controls.Add(this.lbPassword);
            this.grLogin.Controls.Add(this.txtUsername);
            this.grLogin.Location = new System.Drawing.Point(8, 0);
            this.grLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grLogin.Name = "grLogin";
            this.grLogin.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grLogin.Size = new System.Drawing.Size(717, 79);
            this.grLogin.TabIndex = 4;
            this.grLogin.TabStop = false;
            // 
            // ckRememberMe
            // 
            this.ckRememberMe.AutoSize = true;
            this.ckRememberMe.Checked = true;
            this.ckRememberMe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckRememberMe.Location = new System.Drawing.Point(572, 43);
            this.ckRememberMe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckRememberMe.Name = "ckRememberMe";
            this.ckRememberMe.Size = new System.Drawing.Size(122, 21);
            this.ckRememberMe.TabIndex = 6;
            this.ckRememberMe.Text = "Remember Me";
            this.ckRememberMe.UseVisualStyleBackColor = true;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(8, 20);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(86, 17);
            this.lbUsername.TabIndex = 4;
            this.lbUsername.Text = "Username:";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(287, 20);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(82, 17);
            this.lbPassword.TabIndex = 5;
            this.lbPassword.Text = "Password:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("3DS V2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(29, 47);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(468, 30);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.Text = "[ds6w:isLastRevision]:true";
            // 
            // lbSearchBox
            // 
            this.lbSearchBox.AutoSize = true;
            this.lbSearchBox.Font = new System.Drawing.Font("3DS V2", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearchBox.Location = new System.Drawing.Point(44, 23);
            this.lbSearchBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSearchBox.Name = "lbSearchBox";
            this.lbSearchBox.Size = new System.Drawing.Size(130, 20);
            this.lbSearchBox.TabIndex = 5;
            this.lbSearchBox.Text = "Search something:";
            // 
            // btnSearchEngObj
            // 
            this.btnSearchEngObj.Font = new System.Drawing.Font("3DS V2", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEngObj.Location = new System.Drawing.Point(543, 36);
            this.btnSearchEngObj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchEngObj.Name = "btnSearchEngObj";
            this.btnSearchEngObj.Size = new System.Drawing.Size(155, 57);
            this.btnSearchEngObj.TabIndex = 6;
            this.btnSearchEngObj.Text = "Search in Engineering Object";
            this.btnSearchEngObj.UseVisualStyleBackColor = true;
            this.btnSearchEngObj.Click += new System.EventHandler(this.btnSearchEngObj_Click);
            // 
            // btnSearchDrawing
            // 
            this.btnSearchDrawing.Font = new System.Drawing.Font("3DS V2", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDrawing.Location = new System.Drawing.Point(726, 36);
            this.btnSearchDrawing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchDrawing.Name = "btnSearchDrawing";
            this.btnSearchDrawing.Size = new System.Drawing.Size(155, 57);
            this.btnSearchDrawing.TabIndex = 7;
            this.btnSearchDrawing.Text = "Search in Drawings";
            this.btnSearchDrawing.UseVisualStyleBackColor = true;
            this.btnSearchDrawing.Click += new System.EventHandler(this.btnSearchDrawing_Click);
            // 
            // myTabs
            // 
            this.myTabs.Controls.Add(this.tabExternal);
            this.myTabs.Controls.Add(this.tabSearch);
            this.myTabs.Controls.Add(this.tabLearn);
            this.myTabs.Location = new System.Drawing.Point(0, 94);
            this.myTabs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.myTabs.Name = "myTabs";
            this.myTabs.SelectedIndex = 0;
            this.myTabs.Size = new System.Drawing.Size(919, 541);
            this.myTabs.TabIndex = 8;
            // 
            // tabExternal
            // 
            this.tabExternal.Controls.Add(this.link3);
            this.tabExternal.Controls.Add(this.link2);
            this.tabExternal.Controls.Add(this.link1);
            this.tabExternal.Location = new System.Drawing.Point(4, 25);
            this.tabExternal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabExternal.Name = "tabExternal";
            this.tabExternal.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabExternal.Size = new System.Drawing.Size(911, 512);
            this.tabExternal.TabIndex = 0;
            this.tabExternal.Text = "ERP, MES Rules";
            this.tabExternal.UseVisualStyleBackColor = true;
            // 
            // link3
            // 
            this.link3.AutoSize = true;
            this.link3.Font = new System.Drawing.Font("3DS V2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link3.Location = new System.Drawing.Point(23, 126);
            this.link3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.link3.Name = "link3";
            this.link3.Size = new System.Drawing.Size(157, 27);
            this.link3.TabIndex = 2;
            this.link3.TabStop = true;
            this.link3.Text = "3 - More rules....";
            // 
            // link2
            // 
            this.link2.AutoSize = true;
            this.link2.Font = new System.Drawing.Font("3DS V2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link2.Location = new System.Drawing.Point(23, 76);
            this.link2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.link2.Name = "link2";
            this.link2.Size = new System.Drawing.Size(581, 27);
            this.link2.TabIndex = 1;
            this.link2.TabStop = true;
            this.link2.Text = "2 - Find Drawings which are latest revision then send to External";
            this.link2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link2_LinkClicked);
            // 
            // link1
            // 
            this.link1.AutoSize = true;
            this.link1.Font = new System.Drawing.Font("3DS V2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link1.Location = new System.Drawing.Point(23, 31);
            this.link1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.link1.Name = "link1";
            this.link1.Size = new System.Drawing.Size(753, 27);
            this.link1.TabIndex = 0;
            this.link1.TabStop = true;
            this.link1.Text = "1 - Find SOLIDWORKS datas which are latest revision and released then send to ERP" +
    "";
            this.link1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link1_LinkClicked);
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.lbTotalItem);
            this.tabSearch.Controls.Add(this.dataTable);
            this.tabSearch.Controls.Add(this.btnSearchDrawing);
            this.tabSearch.Controls.Add(this.txtSearch);
            this.tabSearch.Controls.Add(this.btnSearchEngObj);
            this.tabSearch.Controls.Add(this.lbSearchBox);
            this.tabSearch.Location = new System.Drawing.Point(4, 25);
            this.tabSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabSearch.Size = new System.Drawing.Size(911, 512);
            this.tabSearch.TabIndex = 1;
            this.tabSearch.Text = "Search";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // tabLearn
            // 
            this.tabLearn.Controls.Add(this.linkDevelepoer);
            this.tabLearn.Controls.Add(this.linkUQL);
            this.tabLearn.Controls.Add(this.linkLearn);
            this.tabLearn.Location = new System.Drawing.Point(4, 25);
            this.tabLearn.Name = "tabLearn";
            this.tabLearn.Padding = new System.Windows.Forms.Padding(3);
            this.tabLearn.Size = new System.Drawing.Size(911, 512);
            this.tabLearn.TabIndex = 2;
            this.tabLearn.Text = "Learn More";
            this.tabLearn.UseVisualStyleBackColor = true;
            // 
            // linkLearn
            // 
            this.linkLearn.AutoSize = true;
            this.linkLearn.Font = new System.Drawing.Font("3DS V2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLearn.Location = new System.Drawing.Point(43, 57);
            this.linkLearn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLearn.Name = "linkLearn";
            this.linkLearn.Size = new System.Drawing.Size(374, 27);
            this.linkLearn.TabIndex = 1;
            this.linkLearn.TabStop = true;
            this.linkLearn.Text = "1 -Pro Tip: reveal 3DSearch query syntax";
            this.linkLearn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLearn_LinkClicked);
            // 
            // linkUQL
            // 
            this.linkUQL.AutoSize = true;
            this.linkUQL.Font = new System.Drawing.Font("3DS V2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkUQL.Location = new System.Drawing.Point(47, 131);
            this.linkUQL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkUQL.Name = "linkUQL";
            this.linkUQL.Size = new System.Drawing.Size(373, 27);
            this.linkUQL.TabIndex = 2;
            this.linkUQL.TabStop = true;
            this.linkUQL.Text = "2 -UQL (User Query Language) examples";
            this.linkUQL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkUQL_LinkClicked);
            // 
            // linkDevelepoer
            // 
            this.linkDevelepoer.AutoSize = true;
            this.linkDevelepoer.Font = new System.Drawing.Font("3DS V2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkDevelepoer.Location = new System.Drawing.Point(48, 200);
            this.linkDevelepoer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkDevelepoer.Name = "linkDevelepoer";
            this.linkDevelepoer.Size = new System.Drawing.Size(231, 27);
            this.linkDevelepoer.TabIndex = 3;
            this.linkDevelepoer.TabStop = true;
            this.linkDevelepoer.Text = "3 - Developer Assistance";
            this.linkDevelepoer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDevelepoer_LinkClicked);
            // 
            // dataTable
            // 
            this.dataTable.AllowUserToOrderColumns = true;
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.type,
            this.title,
            this.revision,
            this.state,
            this.description,
            this.owner,
            this.cs,
            this.creation,
            this.modified});
            this.dataTable.ContextMenuStrip = this.rightClickMenu;
            this.dataTable.Location = new System.Drawing.Point(29, 109);
            this.dataTable.Name = "dataTable";
            this.dataTable.RowTemplate.Height = 24;
            this.dataTable.Size = new System.Drawing.Size(852, 380);
            this.dataTable.TabIndex = 8;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.HeaderText = "NAME";
            this.name.Name = "name";
            // 
            // type
            // 
            this.type.HeaderText = "TYPE";
            this.type.Name = "type";
            // 
            // title
            // 
            this.title.HeaderText = "TITLE";
            this.title.Name = "title";
            // 
            // revision
            // 
            this.revision.HeaderText = "REVISION";
            this.revision.Name = "revision";
            // 
            // state
            // 
            this.state.HeaderText = "MATURITY STATE";
            this.state.Name = "state";
            // 
            // description
            // 
            this.description.HeaderText = "DESCRIPTION";
            this.description.Name = "description";
            // 
            // owner
            // 
            this.owner.HeaderText = "OWNER";
            this.owner.Name = "owner";
            // 
            // cs
            // 
            this.cs.HeaderText = "COLLABORATIVE SPACE";
            this.cs.Name = "cs";
            // 
            // lbTotalItem
            // 
            this.lbTotalItem.AutoSize = true;
            this.lbTotalItem.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbTotalItem.Location = new System.Drawing.Point(34, 492);
            this.lbTotalItem.Name = "lbTotalItem";
            this.lbTotalItem.Size = new System.Drawing.Size(86, 17);
            this.lbTotalItem.TabIndex = 9;
            this.lbTotalItem.Text = "Total Item: 0";
            // 
            // rightClickMenu
            // 
            this.rightClickMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rightClickERP,
            this.rightClickMES});
            this.rightClickMenu.Name = "rightClickMenu";
            this.rightClickMenu.Size = new System.Drawing.Size(211, 80);
            // 
            // rightClickERP
            // 
            this.rightClickERP.Name = "rightClickERP";
            this.rightClickERP.Size = new System.Drawing.Size(210, 24);
            this.rightClickERP.Text = "Send to ERP";
            this.rightClickERP.Click += new System.EventHandler(this.rightClickERP_Click);
            // 
            // rightClickMES
            // 
            this.rightClickMES.Name = "rightClickMES";
            this.rightClickMES.Size = new System.Drawing.Size(210, 24);
            this.rightClickMES.Text = "Send to MES";
            this.rightClickMES.Click += new System.EventHandler(this.rightClickMES_Click);
            // 
            // creation
            // 
            this.creation.HeaderText = "CREATION DATE";
            this.creation.Name = "creation";
            // 
            // modified
            // 
            this.modified.HeaderText = "LAST MODIFICATION";
            this.modified.Name = "modified";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 631);
            this.Controls.Add(this.myTabs);
            this.Controls.Add(this.panLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSharp3DExperienceClientWithRestAPI";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panLogin.ResumeLayout(false);
            this.grSecurityContext.ResumeLayout(false);
            this.grSecurityContext.PerformLayout();
            this.grLogin.ResumeLayout(false);
            this.grLogin.PerformLayout();
            this.myTabs.ResumeLayout(false);
            this.tabExternal.ResumeLayout(false);
            this.tabExternal.PerformLayout();
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
            this.tabLearn.ResumeLayout(false);
            this.tabLearn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.rightClickMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panLogin;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.CheckBox ckRememberMe;
        private System.Windows.Forms.GroupBox grLogin;
        private System.Windows.Forms.GroupBox grSecurityContext;
        private System.Windows.Forms.ComboBox cmbSecurityContext;
        private System.Windows.Forms.Label lbSecurityContext;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lbSearchBox;
        private System.Windows.Forms.Button btnSearchEngObj;
        private System.Windows.Forms.Button btnSearchDrawing;
        private System.Windows.Forms.TabControl myTabs;
        private System.Windows.Forms.TabPage tabExternal;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.LinkLabel link1;
        private System.Windows.Forms.LinkLabel link2;
        private System.Windows.Forms.LinkLabel link3;
        private System.Windows.Forms.TabPage tabLearn;
        private System.Windows.Forms.LinkLabel linkLearn;
        private System.Windows.Forms.LinkLabel linkUQL;
        private System.Windows.Forms.LinkLabel linkDevelepoer;
        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn revision;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn cs;
        private System.Windows.Forms.Label lbTotalItem;
        private System.Windows.Forms.ContextMenuStrip rightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem rightClickERP;
        private System.Windows.Forms.ToolStripMenuItem rightClickMES;
        private System.Windows.Forms.DataGridViewTextBoxColumn creation;
        private System.Windows.Forms.DataGridViewTextBoxColumn modified;
    }
}

