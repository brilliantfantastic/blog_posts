using System;
using Csla;

namespace BrilliantFantastic.Podium.Model
{
    [Serializable()]
    public class CommentCollection : BusinessListBase<CommentCollection, Comment>
    {
        private CommentCollection() { }
    }
}
