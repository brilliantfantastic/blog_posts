using System;

namespace BrilliantFantastic.Podium.Model
{
    [Serializable()]
    public class PostCollection : Csla.BusinessListBase<PostCollection, Post>
    {
        private PostCollection() { }
    }
}
