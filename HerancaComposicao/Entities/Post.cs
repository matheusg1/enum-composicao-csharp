using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaComposicao.Entities
{
    public class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();
        public int Likes { get; set; }

        public Post()
        {
        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void addComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void removeComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" likes - ");
            sb.AppendLine(Moment.ToString());
            sb.AppendLine(Content);

            foreach (Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();

        }
    }
}
