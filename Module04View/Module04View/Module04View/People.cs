using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Module04View
{
    public class People
    {
        public string Name { get; set; }
        public string Occupation { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
        public string Image { get; set; }
    }

    public static class DataModel
    {
        public static ObservableCollection<People> PeopleCollection { get; } = new ObservableCollection<People>();
    }
}
