using System;
using Csla;

namespace BrilliantFantastic.Podium.Model
{
    [Serializable()]
    public class Blog : BusinessBase<Blog>
    {
        private static PropertyInfo<int> IdProperty = RegisterProperty<int>(typeof(Blog), new PropertyInfo<int>("Id"));
        private static PropertyInfo<string> TaglineProperty = RegisterProperty<string>(typeof(Blog), new PropertyInfo<string>("Tagline"));
        private static PropertyInfo<DateTime> CreatedAtProperty = RegisterProperty<DateTime>(typeof(Blog), new PropertyInfo<DateTime>("CreatedAt"));

        public int Id
        {
            get { return GetProperty<int>(IdProperty); }
        }

        public string Tagline
        {
            get { return GetProperty<string>(TaglineProperty); }
            set { SetProperty<string>(TaglineProperty, value); }
        }

        public DateTime CreatedAt
        {
            get { return GetProperty<DateTime>(CreatedAtProperty); }
        }

        private Blog() { }
    }
}
