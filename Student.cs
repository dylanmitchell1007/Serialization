using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    class Student
    {
       
       private string mName;
       private int mAge;
       private int mID;

        public Student(){ }

        public Student(string name, int age, int id)
        {
            mName = name;
            mAge = age;
            mID = id;

        }
        
        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }
        public int AGE
        {
            get { return mAge; }
            set { mAge = value; }
        }
        public int ID
        {
            get { return mID; }
            set { mID = value; }
        }
    }
}
