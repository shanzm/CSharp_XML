using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Winform_XMl_3_读取xml文件
{
    class Program
    {
        //-------------------------------------------切记读取xml文件一定要注意文档中的节点名称的大小写
        static void Main(string[] args)
        {

            //-------------------------------------------------------1.新建XmlDocument对象
            XmlDocument doc = new XmlDocument();

            //-------------------------------------------------------2.加载文件
            //-------------------------------------------------------------------注意xml文件名不区分大小写
            doc.Load("Book1.xml");

            //-------------------------------------------------------3.获取根节点
            XmlElement Books = doc.DocumentElement;



            #region 获取所有节点的内容


            //-------------------------------------------------------4.获所有子节点
            XmlNodeList xnl = Books.ChildNodes;
            //------------------------------------------------------------------注意ChildNodes返回值类型XmlNodeList，这是一个排序的节点集

            foreach (XmlNode item in xnl)
            {
                Console.WriteLine(item.InnerText);
                //------------------------------------------------------------会把该节点的所有子节点的所有内容输出
            }
            #endregion



            #region 法一 获取某个二级节点下的所有节点的内容

            XmlElement book2 = Books["Book2"];
            XmlNodeList xnl2 = book2.ChildNodes;

            foreach (XmlNode item in xnl2)
            {
                Console.WriteLine(item.InnerText);

            }
            #endregion



            #region 法二 XPath 获取某个二级节点下的所有节点的内容

            XmlElement book3 = Books["Book3"];

            //------------------------------------------------------------注意doc.SelectNodes的返回值是一个XmlNodeList
            //------------------------------------------------------------而doc.SelectSingleNode返回值是一个Node，我们要把它强转成Element 
            XmlNodeList xnl3 = doc.SelectNodes("/Books/Book3");

            foreach (XmlNode item in xnl2)
            {
                Console.WriteLine(item.InnerText);     //----------------XmlText 只包括内容
                Console.ReadKey();
                Console.WriteLine(item.InnerXml);      //----------------InnerXml 包括标签
            }

            #endregion



            #region 法一.获取xml中的某个节点，并作修改

            XmlElement book1 = Books["Book1"];
            //------------------------------------------------------------☆☆☆☆☆由根节点获取某个节点的方式
            XmlElement name = book1["Name"];
            //------------------------------------------------------------☆☆☆☆☆由节点获取自己内部节点
            name.InnerXml = "C#入门经典--第七版";
            //------------------------------------------------------------☆☆☆☆☆对节点的内容做修改 
            #endregion



            #region 法二XPath 获取xml中的某个节点，并作修改

            XmlElement book4 = (XmlElement)doc.SelectSingleNode("/Books/Book4");

            XmlElement name4 = book4["Name"];

            name4.InnerXml = "C#高级编程--第四版";

            #endregion



            #region 当某一节点下面存在多个属性不同但名字相同的子节点，使用XPath查询的方式

            XmlElement test1 = (XmlElement)doc.SelectSingleNode("/Books/Test/Auther[@id='001']");
            //注意使用根节点也可以调用 函数SelectSingleNode，效果一样的
            //注意SelectSingleNode返回值是节点XmlNode而不是元素XmlElement，我们把它强转了
            //因为节点包含元素，就是XmlElement继承于XmlNode。所以XmlNode的很多方法和XmlElement的一样

            test1.Attributes["性别"].Value = "女";
            Console.WriteLine("当某一节点下面存在多个属性不同但名字相同的子节点，使用XPath查询的方式d----:");
            Console.WriteLine(test1.InnerXml.ToString());


            #endregion



            #region 获取某个节点，并对他的属性修改

            XmlElement test = Books["Test"];

            XmlNodeList xnl4 = test.ChildNodes;


            foreach (XmlNode item in xnl4)
            {
                Console.WriteLine(item.Attributes["性别"].Value);

                if (item.Attributes["性别"].Value == "男")
                {
                    //-------------------------------------------对节点属性值做了修改，一定要保存到文件
                    item.Attributes["id"].Value = "0000";
                }
            }
            #endregion



            #region 删除XML文档的内容
            //----------------------------------------------------删除某个节点的所有内容
            //Books.RemoveAll();//删除根节点的所有节点
            //RemoveAll 删除了Books的所有子节点，但最后还剩<Books></Books>
            

            //----------------------------------------------------删除某一个节点的方法，首先找到他的上一级节点
            XmlElement book4s = Books["Book4"];
            XmlElement auther4s = doc.DocumentElement ["Book4"]["Auther"];
            ///---------------------------------------------------注意直接找某个节点可以这样写，此处就相当于下面这三句
            /// XmlElement Books = doc.DocumentElement;
            /// XmlElement book4s = Books["Book4"];
            /// Element auther4s =book4s["Auther"];
            ///也可以使用:
            ///XPath：XmlElement auther4s = (XmlElement ) doc.SelectSingleNode("/Books/Book4/Auther");


            //------------------------------------------------------删除子节点；删除Book4的Auther节点
            book4s.RemoveChild(auther4s);
            //根据提示我们发现RemoveChild()的参数是xmlNode类型的，但是此处我们给了一个XmlElement类型的对象，就是因为节点包含元素，xmlElement继承于XmlNode


            //-----------------------------------------------------删除某一个节点的某个属性
            book4s.SetAttribute("num", "001");//我先为Book4--------添加了一个属性
            book4s.Attributes.RemoveNamedItem("num");

          




            #endregion
             


            doc.Save("Book1.xml");

            Console.WriteLine("保存成功");

            Console.ReadKey();
        }
    }
}
