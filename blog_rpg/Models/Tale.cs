﻿namespace blog_rpg.Models
{
    public class Tale
    {
        public Tale() { }
        public Tale(int id, User author, string title, string content, DateTime postDate, DateTime editDate) 
        {
            Id = id;
            Author = author;
            Title = title;
            Content = content;
            PostDate = postDate;
            EditDate = editDate;
        }

        public int Id { get; init; }
        public User Author { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        public DateTime PostDate { get; init; }
        public DateTime EditDate { get; private set; }
    }
}
