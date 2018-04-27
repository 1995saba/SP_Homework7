using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP_Homework7
{
    public partial class MainForm : Form
    {
        RegistryKey currentUserKey = Registry.CurrentUser;
        //RegistryKey localMachineKey = Registry.LocalMachine;
        //RegistryKey classesRootKey = Registry.ClassesRoot;
        string currentUserPath = @"HKEY_CURRENT_USER\";
        public MainForm()
        {
            InitializeComponent();
            Load += new EventHandler(MainForm_Load);
        }
        void MainForm_Load(object sender, EventArgs e)
        {
            TreeNode currUserNode = new TreeNode(currentUserKey.Name) { Tag = currentUserKey };
            BuildChildNodes(currUserNode);
            keysTreeView.Nodes.Add(currUserNode);

            //TreeNode localMachineNode = new TreeNode(localMachineKey.Name) { Tag = localMachineKey };
            //BuildChildNodes(localMachineNode);
            //keysTreeView.Nodes.Add(localMachineNode);

            //TreeNode classesRootNode = new TreeNode(classesRootKey.Name) { Tag = classesRootKey };
            //BuildChildNodes(classesRootNode);
            //keysTreeView.Nodes.Add(classesRootNode);
        }

        private void BuildChildNodes(TreeNode tn)
        {
            RegistryKey key = (RegistryKey)tn.Tag;
            foreach (var name in key.GetSubKeyNames())
            {
                TreeNode child = new TreeNode(name) { Tag = key.OpenSubKey(name) };
                tn.Nodes.Add(child);
            }
        }

        private void KeysTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            foreach (var childNode in e.Node.Nodes.Cast<TreeNode>())
            {
                if (childNode.Nodes.Count == 0)
                {
                    BuildChildNodes(childNode);
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void KeysTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            valuesListView.Clear();
            valuesListView.Columns.Add("N");
            valuesListView.Columns.Add("Values");
            valuesListView.Columns.Add("Type");

            try
            {
                string regKeyName = e.Node.FullPath.Replace(currentUserPath, "");
                RegistryKey regSubKey = currentUserKey.OpenSubKey(regKeyName);
                string[] valuesStr = regSubKey.GetValueNames();
                int i = 0;
                foreach (string str in valuesStr)
                {
                    RegistryValueKind kind = regSubKey.GetValueKind(str);
                    ListViewItem item = valuesListView.Items.Add(i++.ToString());
                    item.SubItems.Add(str);
                    item.SubItems.Add(kind.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            valuesListView.Columns[0].AutoResize(
                ColumnHeaderAutoResizeStyle.ColumnContent);
            valuesListView.Columns[1].AutoResize(
                ColumnHeaderAutoResizeStyle.ColumnContent);
            valuesListView.Columns[2].AutoResize(
                ColumnHeaderAutoResizeStyle.ColumnContent);
        }
    }
}