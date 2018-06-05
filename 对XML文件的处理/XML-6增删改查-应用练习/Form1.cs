using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace XML_6增删改查
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ///这几个属性的设置都可直接在设计窗口的属性栏直接选择设置，
            dataGridView1.RowHeadersVisible = false;//默认的第一列不显示
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//选择则选中整列
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }




        /// <summary>
        /// 把xml文档的数据加载到list，再传给DataGridView
        /// 这个函数一开始我们也没有就定义为这样一个函数，也是考虑到重复使用右键重构新建方法而来
        /// </summary>
        private void LoadData()
        {
            XmlDocument doc = new XmlDocument();

            doc.Load("Users.xml");

            XmlElement user = doc.DocumentElement;

            XmlNodeList xnl = user.ChildNodes;

            List<User> listUser = new List<User>();


            foreach (XmlNode item in xnl)
            {
                User u = new User();
                //使用xml文件的数据初始化对象u
                u.ID = item.Attributes["id"].Value;
                u.Name = item["name"].InnerXml;
                u.Age = Convert.ToInt32(item["age"].InnerXml);
                u.Gender = item["gender"].InnerXml[0];
                u.Password = item["password"].InnerXml;

                listUser.Add(u);//----------------------------------将Xml的数据存储到了集合list    
            }

            dataGridView1.DataSource = listUser;


        }


        /// <summary>
        /// 往xml文档添加新的内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();

            doc.Load("Users.xml");

            XmlElement root = doc.DocumentElement;

            XmlElement user = doc.CreateElement("user");
            user.SetAttribute("id", txtID.Text.Trim());
            root.AppendChild(user);


            XmlElement name = doc.CreateElement("name");
            name.InnerXml = txtName.Text.Trim();
            user.AppendChild(name);

            XmlElement age = doc.CreateElement("age");
            age.InnerXml = txtAge.Text.Trim();
            user.AppendChild(age);

            XmlElement gender = doc.CreateElement("gender");
            gender.InnerXml = rdoMan.Checked ? "男" : "女";
            user.AppendChild(gender);

            XmlElement password = doc.CreateElement("password");
            password.InnerXml = txtPsw.Text.Trim();
            user.AppendChild(password);

            doc.Save("Users.xml");

            LoadData();//----------------------------------------刷新集合list，显示在DataGridView中
            MessageBox.Show("注册成功");
        }


        /// <summary>
        /// DataGridView右键删除
        /// 注意当你为一个控件添加右键菜单时，使用ContentMenuStrip控件
        /// 注意将二者联系起来的属性在原控件中，而不是在ContentMenuStrip中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();

            doc.Load("Users.xml");

            XmlElement Users = doc.DocumentElement;


            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            //dataGridView1.SelectedRows是指选中的所有行组成的数列，哪怕你选中一行也是存在数列中，故使用索引
            //Cells表示当行的单元格

            XmlElement deleteP = (XmlElement)doc.SelectSingleNode("/Users/user[@id= '" + id + "']");//注意尤其是字符串和字符在引号中时一定不要随便加空格
            //注意此处XPath路径的写法，.SelectSingleNode（）的整个参数是节点路径，但是一个字符串的形式，所以为了使用 string id，使用了字符串的加法

            Users.RemoveChild(deleteP);
            //注意你若是使用deleteP.RemoveAll()就是删除了子节点，但自己还在，最终还会在Xml文档中剩下一对空的<deleteP></deleteP>

            doc.Save("Users.xml");

            LoadData();

            MessageBox.Show("删除成功");

        }


        /// <summary>
        /// 单击DataGridView的单元格，使之单元格的内容显示在修改窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUpdataID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtUpdataName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtUpdataAge.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtUpdataPsw.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

            string gender = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            if (gender == "男")
            {
                rdoUpdataMan.Checked = true;
            }
            else
            {
                rdoUpdataWoman.Checked = true;
            }
        }


        /// <summary>
        /// 修改内容
        /// 根据id ，找到这个节点，作修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpData_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();

            doc.Load("Users.xml");

            string id = txtUpdataID.Text;

            XmlElement user =(XmlElement)doc.SelectSingleNode("/Users/user[@id='"+id+"']");

            user["name"].InnerXml  = txtUpdataName.Text;
            user["age"].InnerXml = txtUpdataAge.Text;
            user["password"].InnerXml  = txtUpdataPsw.Text;

            string gender = rdoUpdataMan.Checked ? "男" : "女";
            user["gender"].InnerXml = gender;

            doc.Save("Users.xml");

            LoadData();

            MessageBox.Show("修改成功");


        }




    }
}
