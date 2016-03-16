using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [Serializable]
    public class class_person
    {
        public string id;
        public string name;
    }

    [Serializable]
    public struct struct_person
    {
        public string id;
        public string name;
    }
}
