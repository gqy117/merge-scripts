using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using DevExpress.XtraNavBar;
using DevExpress.XtraBars;
using System.Text;
using System.IO;
using System.Windows.Forms;
using IniFileLibrary;

namespace MergeScripts
{
    public partial class Form_MergeScripts : Form
    {
        public ALl_Sql_File aLl_Sql_File;
        public File_List file_List;
        public Message_Interface message_Interface;
        public Point menuPoint = new Point(0, 0);
        private const string LoadPath = "LoadPath";

        public Form_MergeScripts()
        {
            InitializeComponent();
            file_List = new File_List(this);
            aLl_Sql_File = new ALl_Sql_File(this);
            message_Interface = new Message_Interface(this);
        }
        private void openFileDialog_Sql_FileOk(object sender, CancelEventArgs e)
        {
            file_List.Bind();
        }
        private void pictureBox_Save_Click(object sender, EventArgs e)
        {
            file_List.Save();
        }
        private void pictureBox_Open_Sql_Files_Click(object sender, EventArgs e)
        {
            Load_InitialDirectory();
            openFileDialog_Sql.ShowDialog();
            Save_InitialDirectory();
        }
        private void Form_MergeScripts_Load(object sender, EventArgs e)
        {
            //openFileDialog_Sql.ShowDialog();
        }
        private void nBar_FileList_DragOver(object sender, DragEventArgs e)
        {
            file_List.Clear_Selected();
        }
        private void pictureBox_Delete_Click(object sender, EventArgs e)
        {
            file_List.Clear();
        }
        private void pictureBox_Up_Click(object sender, EventArgs e)
        {
            file_List.Move(File_List.MoveAction.Up);
        }
        private void pictureBox_Down_Click(object sender, EventArgs e)
        {
            file_List.Move(File_List.MoveAction.Down);
        }
        private void nBar_FileList_MouseDown(object sender, MouseEventArgs e)
        {
            file_List.Show_Menu(e);
        }
        private void biDeleteLink_ItemClick(object sender, ItemClickEventArgs e)
        {
            file_List.Clear_Selected();
        }
        private void bi_Move_Top_Link_ItemClick(object sender, ItemClickEventArgs e)
        {
            file_List.Move(File_List.MoveAction.Top);
        }
        private void bi_Move_Bottom_Link_ItemClick(object sender, ItemClickEventArgs e)
        {
            file_List.Move(File_List.MoveAction.Bottom);
        }
        private void Load_InitialDirectory()
        {
            this.openFileDialog_Sql.InitialDirectory = Ini.IniReadValue(LoadPath);
        }
        private void Save_InitialDirectory()
        {
            string directoryName = Path.GetDirectoryName(this.openFileDialog_Sql.FileName);
            if (0 != directoryName.Length)
            {
                Ini.IniWriteValue(LoadPath, directoryName);
            }
        }

        private void pictureBoxCopy_Click(object sender, EventArgs e)
        {
            file_List.Copy();
        }
    }
    public class Interface_Form_MergeScripts
    {
        public Form_MergeScripts form_MergeScripts;
        public StreamReader sr_Sql_File;
        public StreamWriter sw_All_Sql_File;
    }
    public class Message_Interface : Interface_Form_MergeScripts
    {
        public Message_Interface(Form_MergeScripts form_MergeScripts1)
        {
            form_MergeScripts = form_MergeScripts1;
        }
        public void Alert_Message(string ex)
        {
            MessageBox.Show(ex, "Message:");
        }
        public void Alert_Message(Exception ex)
        {
            MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace, "Warning:");
        }
    }
    public class File_List : Interface_Form_MergeScripts
    {
        #region Attribute
        public enum MoveAction
        {
            Up,
            Down,
            Top,
            Bottom
        }
        private int _SelectIndex = 0;
        public int SelectIndex
        {
            get
            {
                _SelectIndex = form_MergeScripts.nBar_FileList.ActiveGroup.SelectedLinkIndex;
                return _SelectIndex;
            }
            set
            {
                _SelectIndex = value;
                form_MergeScripts.navBarGroup_FileList.SelectedLinkIndex = value;
            }
        }
        private int _ItemCount = 0;
        public int ItemCount
        {
            get
            {
                _ItemCount = form_MergeScripts.nBar_FileList.ActiveGroup.ItemLinks.Count;
                return _ItemCount;
            }
        }
        private int OldIndex = 0;
        private int NewIndex = 0;
        private const string SavePath = "SavePath";
        #endregion
        public File_List(Form_MergeScripts form_MergeScripts1)
        {
            form_MergeScripts = form_MergeScripts1;
        }
        public void Bind()
        {
            for (int i = 0; i < form_MergeScripts.openFileDialog_Sql.FileNames.Length; i++)
            {
                form_MergeScripts.navBarItem = new NavBarItem();
                form_MergeScripts.navBarItem.Caption = form_MergeScripts.openFileDialog_Sql.SafeFileNames[i];
                form_MergeScripts.navBarItem.Name = "navBarItem" + i.ToString();
                form_MergeScripts.navBarItem.Hint = form_MergeScripts.openFileDialog_Sql.FileNames[i];
                form_MergeScripts.navBarItem.SmallImage = ((Image)(form_MergeScripts.resources.GetObject("navBarGroup_FileList.SmallImage")));
                form_MergeScripts.navBarGroup_FileList.ItemLinks.AddRange(new NavBarItemLink[] { new NavBarItemLink(form_MergeScripts.navBarItem) });
            }
            form_MergeScripts.BringToFront();
            form_MergeScripts.nBar_FileList.Focus();
        }
        public void Move(MoveAction action)
        {
            switch (action)
            {
                case MoveAction.Up:
                    NewIndex = (this.SelectIndex - 1 >= 0) ? this.SelectIndex - 1 : 0;
                    break;
                case MoveAction.Down:
                    NewIndex = (this.SelectIndex + 1) < this.ItemCount ? (this.SelectIndex + 1) : this.SelectIndex;
                    break;
                case MoveAction.Top:
                    NewIndex = 0;
                    break;
                case MoveAction.Bottom:
                    NewIndex = this.ItemCount - 1;
                    break;
            }
            Set_NewIndex();
        }
        public void Clear_Selected()
        {
            if (form_MergeScripts.nBar_FileList.ActiveGroup.SelectedLink != null)
            {
                form_MergeScripts.nBar_FileList.ActiveGroup.SelectedLink.Dispose();
            }
        }
        public void Clear()
        {
            form_MergeScripts.navBarGroup_FileList.ItemLinks.Clear();
        }
        private void Set_NewIndex()
        {
            if (form_MergeScripts.nBar_FileList.ActiveGroup.SelectedLink != null)
            {
                OldIndex = this.SelectIndex;
                form_MergeScripts.navBarGroup_FileList.ItemLinks.Move(OldIndex, NewIndex);
                this.SelectIndex = NewIndex;
                form_MergeScripts.nBar_FileList.Focus();
            }
        }
        public void Save()
        {
            try
            {
                if (1 < form_MergeScripts.navBarGroup_FileList.ItemLinks.Count)
                {
                    Load_InitialDirectory();
                    if (DialogResult.OK == form_MergeScripts.saveFileDialog_Save_All_Sql.ShowDialog())
                    {
                        Save_InitialDirectory();
                        form_MergeScripts.aLl_Sql_File.Save();
                        form_MergeScripts.message_Interface.Alert_Message("Success!");
                    }
                }
                else
                {
                    form_MergeScripts.message_Interface.Alert_Message("Please open at least 2 sql file!");
                }
            }
            catch (Exception ex)
            {
                form_MergeScripts.message_Interface.Alert_Message(ex);
            }
        }
        public void Copy()
        {
            if (1 < form_MergeScripts.navBarGroup_FileList.ItemLinks.Count)
            {
                form_MergeScripts.aLl_Sql_File.Copy();
                form_MergeScripts.message_Interface.Alert_Message("Success!");
            }
            else
            {
                form_MergeScripts.message_Interface.Alert_Message("Please open at least 2 sql file!");
            }
        }
        private void Load_InitialDirectory()
        {
            form_MergeScripts.saveFileDialog_Save_All_Sql.InitialDirectory = Ini.IniReadValue(SavePath);
        }
        private void Save_InitialDirectory()
        {
            string directoryName = Path.GetDirectoryName(form_MergeScripts.saveFileDialog_Save_All_Sql.FileName);
            if (0 != directoryName.Length)
            {
                Ini.IniWriteValue(SavePath, directoryName);
            }
        }
        public void Show_Menu(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) { return; }
            NavBarHitInfo hi = form_MergeScripts.nBar_FileList.CalcHitInfo(new Point(e.X, e.Y));
            form_MergeScripts.menuPoint = form_MergeScripts.nBar_FileList.PointToScreen(new Point(e.X, e.Y));
            if (hi.InLink)
            {
                form_MergeScripts.nBar_FileList.ActiveGroup.SelectedLink = hi.Link;
                form_MergeScripts.pmItem.ShowPopup(form_MergeScripts.nBar_FileList.PointToScreen(new Point(e.X, e.Y)));
                return;
            }
        }
    }
    public class ALl_Sql_File : Interface_Form_MergeScripts
    {
        public StringBuilder sb_All_Sql = new StringBuilder();
        public ALl_Sql_File(Form_MergeScripts form_MergeScripts1)
        {
            form_MergeScripts = form_MergeScripts1;
        }
        public void Open()
        {
            if (0 != form_MergeScripts.navBarGroup_FileList.ItemLinks.Count)
            {
                sb_All_Sql = new StringBuilder();
                foreach (NavBarItemLink nbil in form_MergeScripts.navBarGroup_FileList.ItemLinks)
                {
                    sr_Sql_File = new StreamReader(nbil.Item.Hint, Encoding.GetEncoding("GB2312"));
                    sb_All_Sql.AppendLine(sr_Sql_File.ReadToEnd());
                    Append_Go();
                }
            }
        }
        private void Append_Go()
        {
            sb_All_Sql.AppendLine("GO");
        }
        public void Save()
        {
            Open();
            Save_Sql_File();
        }
        public void Copy()
        {
            Open();
            Copy_Clipboard();
        }
        private void Copy_Clipboard()
        {
            if (null != form_MergeScripts.saveFileDialog_Save_All_Sql.FileName && 0 != form_MergeScripts.saveFileDialog_Save_All_Sql.FileName.Length)
            {
                Clipboard.SetDataObject(sb_All_Sql.ToString());
                Dispose_All();
            }
        }
        private void Save_Sql_File()
        {
            if (null != form_MergeScripts.saveFileDialog_Save_All_Sql.FileName && 0 != form_MergeScripts.saveFileDialog_Save_All_Sql.FileName.Length)
            {
                sw_All_Sql_File = new StreamWriter(form_MergeScripts.saveFileDialog_Save_All_Sql.FileName, false, Encoding.UTF8);

                sw_All_Sql_File.WriteLine(sb_All_Sql.ToString());
                Dispose_All();
            }
        }
        private void Dispose_All()
        {
            sr_Sql_File.Dispose();
            if (sw_All_Sql_File != null)
            {
                sw_All_Sql_File.Flush();
                sw_All_Sql_File.Dispose();
            }
        }
    }
}