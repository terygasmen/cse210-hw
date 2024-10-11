public class Video {
        public string Title { get; set;}
        public string Author { get; set;}
        public int LengthInSeconds { get; set;}
        private List<Comment> Comments { get; set;}

        public Video(string title, string author, int length) {
                Title = title;
                Author = author;
                LengthInSeconds = length;
                Comments = new List<Comment>();
        }

        public void AddComment(Comment comment) {
                Comments.Add(comment);
        }
        public int GetCommentCount() {
                return Comments.Count;
        }

        public List<Comment> GetComments() {
                return Comments;
        }
}