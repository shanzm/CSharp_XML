using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Winform_创建xm文档l
{
    class Program
    {
        static void Main(string[] args)
        {
            //代码创建一个Xml文档
            //------------------------------------------------1.添加命名空间using System.Xml;
            //------------------------------------------------1.1创建XmlDocument对象
            XmlDocument doc = new XmlDocument();
           
            //------------------------------------------------2.添加Xml文档的第一行描述信息
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);

            //-------------------------------------------------3.创建一个根节点
            XmlElement Books = doc.CreateElement("Books");
            doc.AppendChild(Books);


            //-------------------------------------------------4.为根节点Books添加一个book1子节点
            XmlElement book1 = doc.CreateElement("BooK1");
            Books.AppendChild(book1);


            //--------------------------------------------------5.为book1节点添加一个name子节点
            XmlElement name1 = doc.CreateElement("Name");
            book1.AppendChild(name1);
            name1.InnerText = "C#入门经典";
            //---------------------------------------------------注意使用name1.InnerXml="C#入门经典"也可以;
            //---------------------------------------------------当你所插入的内容包含Html中的标签时，只能使用InnerXml，建议任何时候都使用InnerXml


            //为book1节点添加一个price子节点
            XmlElement price1 = doc.CreateElement("Price");
            book1.AppendChild(price1);
            price1.InnerText = "98";

            XmlElement auther1 = doc.CreateElement("Auther");
            //---------------------------------------------------6.标签中属性的添加方式
            auther1.SetAttribute("性别", "男");
            book1.AppendChild(auther1);
            auther1.InnerText = "莎士比亚";

            //为book1节点添加一个evaluate子节点
            XmlElement evaluate1 = doc.CreateElement("Evalute");
            book1.AppendChild(evaluate1);
            evaluate1.InnerText = "★★★☆☆";


            #region 为根节点Books添加一个book2子节点,及为book2子节点添加节点
            //为根节点Books添加一个book2子节点
            XmlElement book2 = doc.CreateElement("BooK2");
            Books.AppendChild(book2);

            //为book2节点添加一个name子节点
            XmlElement name2 = doc.CreateElement("Name");
            book2.AppendChild(name2);
            name2.InnerText = "C#高级编程";

            //为book2节点添加一个price子节点
            XmlElement price2 = doc.CreateElement("Price");
            book2.AppendChild(price2);
            price2.InnerText = "99";

            //为book2节点添加一个auther子节点
            XmlElement auther2 = doc.CreateElement("Auther");
            //标签中属性的添加方式
            auther2.SetAttribute("性别", "男");
            book2.AppendChild(auther2);
            auther2.InnerText = "柏拉图";


            //为book2节点添加一个evaluate子节点
            XmlElement evaluate2 = doc.CreateElement("Evalute");
            book2.AppendChild(evaluate2);
            evaluate2.InnerText = "★★★☆☆"; 
            #endregion



            doc.Save("Books.xml");
            Console.WriteLine("保存成功");
            Console.ReadKey ();




        }
    }
}
