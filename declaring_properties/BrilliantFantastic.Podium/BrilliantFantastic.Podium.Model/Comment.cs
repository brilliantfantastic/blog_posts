using System;
using Csla;

namespace BrilliantFantastic.Podium.Model
{
    [Serializable()]
    public class Comment : BusinessBase<Comment>
    {
        private static PropertyInfo<int> IdProperty = RegisterProperty<int>(typeof(Comment), new PropertyInfo<int>("Id"));
        private static PropertyInfo<string> BodyProperty = RegisterProperty<string>(typeof(Comment), new PropertyInfo<string>("Body"));
        private static PropertyInfo<string> AuthorProperty = RegisterProperty<string>(typeof(Comment), new PropertyInfo<string>("Author"));
        private static PropertyInfo<DateTime> PublishedAtProperty = RegisterProperty<DateTime>(typeof(Comment), new PropertyInfo<DateTime>("PublishedAt"));

        public int Id
        {
            get { return GetProperty<int>(IdProperty); }
        }

        public string Body
        {
            get { return GetProperty<string>(BodyProperty); }
            set { SetProperty<string>(BodyProperty, value); }
        }

        public string Author
        {
            get { return GetProperty<string>(AuthorProperty); }
            set { SetProperty<string>(AuthorProperty, value); }
        }

        public DateTime PublishedAt
        {
            get { return GetProperty<DateTime>(PublishedAtProperty); }
        }

        private Comment() { }
    }
}
