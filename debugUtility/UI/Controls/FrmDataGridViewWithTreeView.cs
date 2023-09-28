using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebugUtility.UI.Controls
{
    public partial class FrmDataGridViewWithTreeView : Form
    {
        public FrmDataGridViewWithTreeView()
        {
            InitializeComponent();
            InitialControlsStyle();
        }

        #region vary

        // 创建一个DataTable作为示例数据
        DataTable dataTable = new DataTable();

        Panel panel = new Panel();
       
        DataGridView dataGridView = new DataGridView();
      
        #endregion

        void InitialControlsStyle()
        {

            // 创建一个TreeView控件
            TreeView treeView = new TreeView();
            treeView.Dock = DockStyle.Left;
            treeView.Width = 200;

            // 创建一个DataGridView控件
            DataGridView dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;

            // 创建一个DataTable作为示例数据
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Category");
            dataTable.Columns.Add("Product");
            dataTable.Columns.Add("Price");
            dataTable.Rows.Add("Electronics", "TV", 1000);
            dataTable.Rows.Add("Electronics", "Phone", 800);
            dataTable.Rows.Add("Electronics", "Laptop", 1500);
            dataTable.Rows.Add("Clothing", "Shirt", 50);
            dataTable.Rows.Add("Clothing", "Pants", 70);
            dataTable.Rows.Add("Clothing", "Dress", 100);

            // 添加根节点
            TreeNode rootNode = new TreeNode("Categories");
            treeView.Nodes.Add(rootNode);

            // 添加子节点，并将DataTable作为节点的Tag属性保存
            TreeNode electronicsNode = new TreeNode("Electronics");
            electronicsNode.Tag = dataTable.Select("Category = 'Electronics'");
            rootNode.Nodes.Add(electronicsNode);

            TreeNode clothingNode = new TreeNode("Clothing");
            clothingNode.Tag = dataTable.Select("Category = 'Clothing'");
            rootNode.Nodes.Add(clothingNode);

            // 在TreeView的节点点击事件中，根据节点的展开状态更新DataGridView的内容
            treeView.NodeMouseClick += (sender, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (e.Node.IsExpanded)
                    {
                        // 节点已展开，隐藏子节点
                        e.Node.Collapse();
                    }
                    else
                    {
                        // 节点未展开，显示子节点
                        e.Node.Expand();
                    }

                    // 更新DataGridView的内容
                    if (e.Node.Tag != null && e.Node.Tag is DataRow[])
                    {
                        dataGridView.DataSource = ((DataRow[])e.Node.Tag).CopyToDataTable();
                    }
                    else
                    {
                        dataGridView.DataSource = null;
                    }
                }
            };

            // 将TreeView和DataGridView添加到窗体中
            this.Controls.Add(treeView);
            this.Controls.Add(dataGridView);


        }


        //private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        //{
        //    if (e.Node != null)
        //    {
        //        // 根据选择的节点显示或隐藏Panel和DataGridView
        //        if (e.Node.Tag != null && e.Node.Tag is DataTable)
        //        {
        //            dataGridView.DataSource = (DataTable)e.Node.Tag;
        //            panel.Visible = true;
        //        }
        //        else
        //        {
        //            panel.Visible = false;
        //        }
        //    }
        //}
    }
}
