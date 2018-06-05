using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace Winform_XMl_2追加xml文档
{
    class Program
    {
        /// <summary>
        /// 对xml文档内容经行追加
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //不论是否已经存在Xml文档，我们都是首先获得根节点
            //在后的根节点后再做后面的操作---在根节点上添加节点
            XmlDocument doc = new XmlDocument();
            XmlElement Books = null;

            //先判断该文件是否已经存在
            if (File.Exists ("Book1.xml"))
            {
                //如果存在，则先把该文件加载出来
                doc.Load("Book1.xml");
                //获取根节点
                 Books = doc.DocumentElement;

            }

            else
            {
                //xml文档部存在则添加文档的第一行
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
                doc.AppendChild(dec);

                //创建根节点
                 Books = doc.CreateElement("Books");
                doc.AppendChild(Books);

            }


            #region 为根节点Books添加一个book2子节点,及为book2子节点添加节点
            //为根节点Books添加一个book3子节点
            XmlElement book3 = doc.CreateElement("BooK3");
            Books.AppendChild(book3);

            //为book2节点添加一个name子节点
            XmlElement name3 = doc.CreateElement("Name");
            book3.AppendChild(name3);
            name3.InnerText = "C#图解";

            //为book2节点添加一个price子节点
            XmlElement price3 = doc.CreateElement("Price");
            book3.AppendChild(price3);
            price3.InnerText = "100";

            //为book2节点添加一个auther子节点
            XmlElement auther3 = doc.CreateElement("Auther");
            //标签中属性的添加方式
            auther3.SetAttribute("性别", "男");
            book3.AppendChild(auther3);
            auther3.InnerText = "亚伯拉罕~林肯";


            //为book3节点添加一个evaluate子  节点
            XmlElement evaluate3 = doc.CreateElement("Evalute");
            book3.AppendChild(evaluate3);
            evaluate3.InnerText = "★★★★☆";
            #endregion

            doc.Save("Book1.xml");
            Console.WriteLine("写入成功");
            Console.ReadKey();
        }
    }
}
