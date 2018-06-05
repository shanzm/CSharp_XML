using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml; 
using XMl_3文件对象模型;

namespace XMl_5应用_判断登录
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 已经存在了Person.xml 文档，我们要根据文档来判断输入的内容可不可以登录
        /// 什么意思呢？就是我们把可以登录的人员的数据存储在一个Person.xml文件中，当用户登录时
        /// 我们把用户输入的数据与文档中的数据对比，如果文档中有这个数据，就判断问可以登录
        /// 那又怎么对比呢？
        /// 因为文档内容是按照一个Person类存储的（见XMl-4文件对象模型DOM-创建XML），
        /// 所以我们也要在该项目中建一个Person类
        /// 此处我们调用（XMl-4文件对象模型DOM-创建XML）中的Person类
        /// 所有我们要把文档的内容先读取出来，存储为一个个Person类的对象
        /// 然后把这些对象存储在一个集合list,这样就放在了内存中，可以随时使用
        /// 接着把Form窗口中的数据读取，存储为一个Person类的对象
        /// 判断就变为了看集合list中存不存在这个对象了
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        List<Person> list = new List<Person>();
        private void Form1_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();

            doc.Load("Person.xml");

            XmlElement person = doc.DocumentElement;

            XmlNodeList xnl = person.ChildNodes;

           
            foreach (XmlNode item in xnl)
            {
                Person p = new Person();
                p.Id = item.Attributes["ID"].Value;
                p.Name = item["Name"].InnerXml;
                p.Age = Convert.ToInt32(item["Age"].InnerXml);
                p.Gender = item["Gender"].InnerXml[0];
                //换一种写法：
                //p.Gender=Convert.ToChar(item["Gender"].InnerXml);
                //p.Gender = item["Gender"].InnerXml.ToCharArray()[0];
                
                list.Add(p);            

            }

           




        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person loginPerson = new Person();

            loginPerson.Id = txtID.Text;
            loginPerson.Name = txtName.Text;
            loginPerson.Age = Convert.ToInt32(txtAge.Text);
            loginPerson.Gender = rdoMan.Checked ? '男' : '女';


            bool isLogin = false;//-----------------------------------------注意这种定义一个布尔类型的变量作标记的方法
            foreach (Person item in list)
            {
                if (item.Equals(loginPerson))
                //注意.net 自带的Equals比较的是引用类型的地址，而不是内容
                //所以我们在Person类中重写这个方法
                {
                    MessageBox.Show("登录成功");
                    isLogin = true;//----------------------------------------登录成功，标记改为成功
                }
            
            }

            if (isLogin==false)//--------------------------------------------标记未被修改为成功，则执行下面代码
            {
                MessageBox.Show("登录失败");
            }
        }
    }
}
