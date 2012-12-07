namespace MergeScripts
{
    using System.ComponentModel;
    using DevExpress.XtraNavBar;
    using System.Drawing;
    using DevExpress.XtraNavBar.ViewInfo;
    using System.Windows.Forms;
    using DevExpress.XtraBars;
    partial class Form_MergeScripts
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
        public ComponentResourceManager resources;
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MergeScripts));
            this.nBar_FileList = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup_FileList = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem_Deleted_Items = new DevExpress.XtraNavBar.NavBarItem();
            this.openFileDialog_Sql = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_Save_All_Sql = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox_Save = new System.Windows.Forms.PictureBox();
            this.pmItem = new DevExpress.XtraBars.PopupMenu(this.components);
            this.biDeleteLink = new DevExpress.XtraBars.BarButtonItem();
            this.bi_Move_Top_Link = new DevExpress.XtraBars.BarButtonItem();
            this.bi_Move_Bottom_Link = new DevExpress.XtraBars.BarButtonItem();
            this.barManager_pmItem = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.pictureBox_Open_Sql_Files = new System.Windows.Forms.PictureBox();
            this.pictureBox_Delete = new System.Windows.Forms.PictureBox();
            this.pictureBox_Up = new System.Windows.Forms.PictureBox();
            this.pictureBox_Down = new System.Windows.Forms.PictureBox();
            this.pictureBoxCopy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nBar_FileList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager_pmItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Open_Sql_Files)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCopy)).BeginInit();
            this.SuspendLayout();
            // 
            // nBar_FileList
            // 
            this.nBar_FileList.ActiveGroup = this.navBarGroup_FileList;
            this.nBar_FileList.AllowSelectedLink = true;
            this.nBar_FileList.Appearance.ItemPressed.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.nBar_FileList.Appearance.ItemPressed.Options.UseForeColor = true;
            this.nBar_FileList.BackColor = System.Drawing.Color.Transparent;
            this.nBar_FileList.ContentButtonHint = null;
            this.nBar_FileList.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup_FileList});
            this.nBar_FileList.Location = new System.Drawing.Point(22, 61);
            this.nBar_FileList.LookAndFeel.SkinName = "Black";
            this.nBar_FileList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.nBar_FileList.Name = "nBar_FileList";
            this.nBar_FileList.OptionsNavPane.ExpandedWidth = 140;
            this.nBar_FileList.Size = new System.Drawing.Size(408, 492);
            this.nBar_FileList.TabIndex = 0;
            this.nBar_FileList.Text = "nBar_FileList";
            this.nBar_FileList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nBar_FileList_MouseDown);
            this.nBar_FileList.DragOver += new System.Windows.Forms.DragEventHandler(this.nBar_FileList_DragOver);
            // 
            // navBarGroup_FileList
            // 
            this.navBarGroup_FileList.Caption = "File List";
            this.navBarGroup_FileList.Expanded = true;
            this.navBarGroup_FileList.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.navBarGroup_FileList.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText;
            this.navBarGroup_FileList.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup_FileList.LargeImage")));
            this.navBarGroup_FileList.Name = "navBarGroup_FileList";
            this.navBarGroup_FileList.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup_FileList.SmallImage")));
            // 
            // navBarItem
            // 
            this.navBarItem.Caption = "File List";
            this.navBarItem.Enabled = false;
            this.navBarItem.Name = "navBarItem";
            this.navBarItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem.SmallImage")));
            // 
            // navBarItem_Deleted_Items
            // 
            this.navBarItem_Deleted_Items.Caption = "Deleted Items";
            this.navBarItem_Deleted_Items.Enabled = false;
            this.navBarItem_Deleted_Items.Name = "navBarItem_Deleted_Items";
            this.navBarItem_Deleted_Items.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem_Deleted_Items.SmallImage")));
            // 
            // openFileDialog_Sql
            // 
            this.openFileDialog_Sql.FileName = "*.sql";
            this.openFileDialog_Sql.Filter = "SQL files|*.sql|All files|*.*";
            this.openFileDialog_Sql.Multiselect = true;
            this.openFileDialog_Sql.Title = "Please open .sql files...";
            this.openFileDialog_Sql.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_Sql_FileOk);
            // 
            // saveFileDialog_Save_All_Sql
            // 
            this.saveFileDialog_Save_All_Sql.FileName = "All.sql";
            this.saveFileDialog_Save_All_Sql.Filter = "SQL files|*.sql|All files|*.*";
            // 
            // pictureBox_Save
            // 
            this.pictureBox_Save.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Save.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Save.Image")));
            this.pictureBox_Save.InitialImage = null;
            this.pictureBox_Save.Location = new System.Drawing.Point(187, 11);
            this.pictureBox_Save.Name = "pictureBox_Save";
            this.pictureBox_Save.Size = new System.Drawing.Size(56, 52);
            this.pictureBox_Save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Save.TabIndex = 3;
            this.pictureBox_Save.TabStop = false;
            this.pictureBox_Save.Click += new System.EventHandler(this.pictureBox_Save_Click);
            // 
            // pmItem
            // 
            this.pmItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.biDeleteLink),
            new DevExpress.XtraBars.LinkPersistInfo(this.bi_Move_Top_Link),
            new DevExpress.XtraBars.LinkPersistInfo(this.bi_Move_Bottom_Link)});
            this.pmItem.Manager = this.barManager_pmItem;
            this.pmItem.Name = "pmItem";
            // 
            // biDeleteLink
            // 
            this.biDeleteLink.Caption = "Delete";
            this.biDeleteLink.Id = 0;
            this.biDeleteLink.Name = "biDeleteLink";
            this.biDeleteLink.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biDeleteLink_ItemClick);
            // 
            // bi_Move_Top_Link
            // 
            this.bi_Move_Top_Link.Caption = "Move To Top";
            this.bi_Move_Top_Link.Id = 1;
            this.bi_Move_Top_Link.Name = "bi_Move_Top_Link";
            this.bi_Move_Top_Link.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bi_Move_Top_Link_ItemClick);
            // 
            // bi_Move_Bottom_Link
            // 
            this.bi_Move_Bottom_Link.Caption = "Move To Bottom";
            this.bi_Move_Bottom_Link.Id = 2;
            this.bi_Move_Bottom_Link.Name = "bi_Move_Bottom_Link";
            this.bi_Move_Bottom_Link.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bi_Move_Bottom_Link_ItemClick);
            // 
            // barManager_pmItem
            // 
            this.barManager_pmItem.DockControls.Add(this.barDockControlTop);
            this.barManager_pmItem.DockControls.Add(this.barDockControlBottom);
            this.barManager_pmItem.DockControls.Add(this.barDockControlLeft);
            this.barManager_pmItem.DockControls.Add(this.barDockControlRight);
            this.barManager_pmItem.Form = this;
            this.barManager_pmItem.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.biDeleteLink,
            this.bi_Move_Top_Link,
            this.bi_Move_Bottom_Link});
            this.barManager_pmItem.MaxItemId = 0;
            // 
            // pictureBox_Open_Sql_Files
            // 
            this.pictureBox_Open_Sql_Files.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Open_Sql_Files.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Open_Sql_Files.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Open_Sql_Files.Image")));
            this.pictureBox_Open_Sql_Files.Location = new System.Drawing.Point(47, 11);
            this.pictureBox_Open_Sql_Files.Name = "pictureBox_Open_Sql_Files";
            this.pictureBox_Open_Sql_Files.Size = new System.Drawing.Size(48, 44);
            this.pictureBox_Open_Sql_Files.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Open_Sql_Files.TabIndex = 4;
            this.pictureBox_Open_Sql_Files.TabStop = false;
            this.pictureBox_Open_Sql_Files.Click += new System.EventHandler(this.pictureBox_Open_Sql_Files_Click);
            // 
            // pictureBox_Delete
            // 
            this.pictureBox_Delete.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Delete.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Delete.Image")));
            this.pictureBox_Delete.InitialImage = null;
            this.pictureBox_Delete.Location = new System.Drawing.Point(117, 11);
            this.pictureBox_Delete.Name = "pictureBox_Delete";
            this.pictureBox_Delete.Size = new System.Drawing.Size(48, 44);
            this.pictureBox_Delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Delete.TabIndex = 6;
            this.pictureBox_Delete.TabStop = false;
            this.pictureBox_Delete.Click += new System.EventHandler(this.pictureBox_Delete_Click);
            // 
            // pictureBox_Up
            // 
            this.pictureBox_Up.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Up.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Up.Image")));
            this.pictureBox_Up.InitialImage = null;
            this.pictureBox_Up.Location = new System.Drawing.Point(443, 222);
            this.pictureBox_Up.Name = "pictureBox_Up";
            this.pictureBox_Up.Size = new System.Drawing.Size(32, 30);
            this.pictureBox_Up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Up.TabIndex = 8;
            this.pictureBox_Up.TabStop = false;
            this.pictureBox_Up.Click += new System.EventHandler(this.pictureBox_Up_Click);
            // 
            // pictureBox_Down
            // 
            this.pictureBox_Down.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Down.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Down.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Down.Image")));
            this.pictureBox_Down.InitialImage = null;
            this.pictureBox_Down.Location = new System.Drawing.Point(443, 270);
            this.pictureBox_Down.Name = "pictureBox_Down";
            this.pictureBox_Down.Size = new System.Drawing.Size(32, 30);
            this.pictureBox_Down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Down.TabIndex = 9;
            this.pictureBox_Down.TabStop = false;
            this.pictureBox_Down.Click += new System.EventHandler(this.pictureBox_Down_Click);
            // 
            // pictureBoxCopy
            // 
            this.pictureBoxCopy.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCopy.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCopy.Image")));
            this.pictureBoxCopy.InitialImage = null;
            this.pictureBoxCopy.Location = new System.Drawing.Point(269, 11);
            this.pictureBoxCopy.Name = "pictureBoxCopy";
            this.pictureBoxCopy.Size = new System.Drawing.Size(56, 52);
            this.pictureBoxCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCopy.TabIndex = 10;
            this.pictureBoxCopy.TabStop = false;
            this.pictureBoxCopy.Click += new System.EventHandler(this.pictureBoxCopy_Click);
            // 
            // Form_MergeScripts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 571);
            this.Controls.Add(this.pictureBoxCopy);
            this.Controls.Add(this.pictureBox_Down);
            this.Controls.Add(this.pictureBox_Up);
            this.Controls.Add(this.pictureBox_Delete);
            this.Controls.Add(this.pictureBox_Open_Sql_Files);
            this.Controls.Add(this.nBar_FileList);
            this.Controls.Add(this.pictureBox_Save);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_MergeScripts";
            this.Text = "Merge Scripts";
            this.Load += new System.EventHandler(this.Form_MergeScripts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nBar_FileList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager_pmItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Open_Sql_Files)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCopy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public NavBarControl nBar_FileList;
        public NavBarItem navBarItem;
        public NavBarGroup navBarGroup_FileList;
        public NavBarItem navBarItem_Deleted_Items;
        public System.Windows.Forms.OpenFileDialog openFileDialog_Sql;
        public System.Windows.Forms.SaveFileDialog saveFileDialog_Save_All_Sql;
        private System.Windows.Forms.PictureBox pictureBox_Save;
        private System.Windows.Forms.PictureBox pictureBox_Open_Sql_Files;
        public BarButtonItem biDeleteLink;
        public BarButtonItem bi_Move_Top_Link;
        public BarButtonItem bi_Move_Bottom_Link;
        public PopupMenu pmItem;
        public BarManager barManager_pmItem;
        private PictureBox pictureBox_Delete;
        private PictureBox pictureBox_Up;
        private PictureBox pictureBox_Down;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private PictureBox pictureBoxCopy;
    }
}

