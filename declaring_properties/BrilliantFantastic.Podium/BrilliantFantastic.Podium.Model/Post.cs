using System;
using Csla;

namespace BrilliantFantastic.Podium.Model
{
    [Serializable()]
    public class Post : BusinessBase<Post>
    {
        private static PropertyInfo<int> IdProperty = RegisterProperty<int>(typeof(Post), new PropertyInfo<int>("Id"));
        private static PropertyInfo<string> TitleProperty = RegisterProperty<string>(typeof(Post), new PropertyInfo<string>("Title"));
        private static PropertyInfo<string> BodyProperty = RegisterProperty<string>(typeof(Post), new PropertyInfo<string>("Body"));
        private static PropertyInfo<Author> AuthorProperty = RegisterProperty<Author>(typeof(Post), new PropertyInfo<Author>("Author"));
        private static PropertyInfo<DateTime> PublishedAtProperty = RegisterProperty<DateTime>(typeof(Post), new PropertyInfo<DateTime>("PublishedAt"));
        private static PropertyInfo<Uri> UrlProperty = RegisterProperty<Uri>(typeof(Post), new PropertyInfo<Uri>("Url"));
        private static PropertyInfo<CommentCollection> CommentsProperty = RegisterProperty<CommentCollection>(typeof(Post), new PropertyInfo<CommentCollection>("Comments"));

        public int Id
        {
            get { return GetProperty<int>(IdProperty); }
        }

        public string Title
        {
            get { return GetProperty<string>(TitleProperty); }
            set { SetProperty<string>(TitleProperty, value); }
        }

        public string Body
        {
            get { return GetProperty<string>(BodyProperty); }
            set { SetProperty<string>(BodyProperty, value); }
        }

        public Author Author
        {
            get { return GetProperty<Author>(AuthorProperty); }
            set { SetProperty<Author>(AuthorProperty, value); }
        }

        public DateTime PublishedAt
        {
            get { return GetProperty<DateTime>(PublishedAtProperty); }
        }

        public Uri Url
        {
            get { return GetProperty<Uri>(UrlProperty); }
        }

        public CommentCollection Comments
        {
            get { return GetProperty<CommentCollection>(CommentsProperty); }
        }

        private Post() { }
    }
}
