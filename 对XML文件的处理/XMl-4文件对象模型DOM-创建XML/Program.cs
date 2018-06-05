using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace XMl_3文件对象模型
{
    class Program
    {
        //关于C#读写XML文件的两种方式：流模型SAX  和   文档对象模型DOM
        //https://blog.csdn.net/watkinsong/article/details/8701191
        //https://www.cnblogs.com/netlzl/p/4328418.html
        static void Main(string[] args)
        {
           
            Person p1 = new Person("001", "张三", 25, '男');
            Person p2 = new Person("002", "李四", 25, '女');
            Person p3 = new Person("003", "王五", 25, '男');
            Person p4 = new Person("004", "小明", 25, '女');
            Person p5 = new Person("005", "小亮", 25, '男');
            List<Person> pList = new List<Person>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);
            pList.Add(p5);


            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec= doc.CreateXmlDeclaration("1.0", "utf-8", null);

            doc.AppendChild (dec);

            XmlElement person = doc.CreateElement ("Person");
            doc.AppendChild(person);

            for (int i = 0; i < pList .Count ; i++)
            {
                XmlElement student = doc.CreateElement ("Student");
                student.SetAttribute("ID", pList[i].Id);
                person.AppendChild(student);

                XmlElement name = doc.CreateElement ("Name");
                name.InnerXml = pList[i].Name.ToString();
                student.AppendChild(name);

                XmlElement age = doc.CreateElement ("Age");
                age.InnerXml = pList[i].Age.ToString();
                student.AppendChild(age);

                XmlElement gender =doc.CreateElement ("Gender");
                gender.InnerXml=  pList[i].Gender.ToString();
                student .AppendChild (gender);
            }

            doc.Save("Person.xml");
            Console.WriteLine("保存成功");
            Console.ReadKey();


        }
    }
}
