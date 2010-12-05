using System;
using Csla;

namespace BrilliantFantastic.Podium.Model
{
    [Serializable()]
    public class Author : BusinessBase<Author>
    {
        private static PropertyInfo<int> IdProperty = RegisterProperty<int>(typeof(Author), new PropertyInfo<int>("Id"));
        private static PropertyInfo<string> NameProperty = RegisterProperty<string>(typeof(Author), new PropertyInfo<string>("Name"));
        private static PropertyInfo<string> EmailProperty = RegisterProperty<string>(typeof(Author), new PropertyInfo<string>("Email"));

        public int Id
        {
            get { return GetProperty<int>(IdProperty); }
        }

        public string Name
        {
            get { return GetProperty<string>(NameProperty); }
            set { SetProperty<string>(NameProperty, value); }
        }

        public string Email
        {
            get { return GetProperty<string>(EmailProperty); }
            set { SetProperty<string>(EmailProperty, value); }
        }

        private Author() { }
    }
}
