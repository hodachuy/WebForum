namespace MvcForum.Core.Models
{
    using Entities;
    using System.Collections.Generic;

    /// <summary>
    /// Used when listing Categories
    /// </summary>
    public class CategorySummary
    {
        public Category Category { get; set; }
        public int TopicCount { get; set; }
        public int PostCount { get; set; }
        public Topic MostRecentTopic { get; set; }
    }
}