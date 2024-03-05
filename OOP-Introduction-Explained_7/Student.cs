using System;
using OOP_Introduction_Explained_7;

namespace OOP_Introduction_Explained_7
{

    // Here we can either write or read data to this class
    class Student : Person
    {
        // private field (backing field) hold any data assigned Name property
        private string _name;

        public Student()
        {
            _name = "";
        }
        // This is the Name Property
        public string Name
        {
            // use the Get accessor to read data from the class
            get
            {
                return _name;
            }
            set
            {
                // The value property of the set accessor is automatically created by the compiler
                _name = value;
            }
        }
    }
}

