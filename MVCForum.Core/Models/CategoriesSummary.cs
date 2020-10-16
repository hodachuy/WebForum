namespace MvcForum.Core.Models
{
    using Entities;
    using MvcForum.Core.Models.General;
    using System.Collections.Generic;

    /// <summary>
    /// Used when listing Categories
    /// </summary>
    public class CategorySummary
    {
        public Category Category { get; set; }
        public Dictionary<Category, PermissionSet> SubCategoriesAllPermissionSets { get; set; }
        public int TopicCount { get; set; }
        public int PostCount { get; set; }
        public Topic MostRecentTopic { get; set; }
    }
}