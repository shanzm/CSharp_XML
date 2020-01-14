#region
// ===============================================================================
// Project Name        :    XMl_3文件对象模型
// Project Description :   
// ===============================================================================
// Class Name          :    Person
// Class Version       :    v1.0.0.0
// Class Description   :   
// Author              :    shanzm
// Create Time         :    2018-6-2 19:51:22
// Update Time         :    2018-6-2 19:51:22
// ===============================================================================
// Copyright © SHANZM-PC 2018 . All rights reserved.
// ===============================================================================
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMl_3文件对象模型
{
    public  class Person
    {
        public Person(string  id, string name, int age, char gender)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public Person()
            //注意一旦你自己写了构造函数，原来的默认无参数的构造函数就被覆盖了，你要是需要就得重写
        {

        }

        private string  _id;

        public string  Id
        {
            get { return _id; }
            set { _id = value; }
        }


        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }



        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }



        public char Gender
        {
            set;
            get;
        }


         
        public override bool Equals(object obj)//本身类中就有Equals这个函数，但是不是我们想要的，所以我们重写了这个函数
            
        {
            Person p = obj as Person;
            if (p.Id ==this.Id &&p.Name ==this.Name &&p.Gender ==this.Gender &&p.Age ==this.Age )
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
