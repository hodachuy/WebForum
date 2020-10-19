
namespace MvcForum.Core.Data.Mapping
{
    using System.Data.Entity.ModelConfiguration;
    using Models.Entities;

    public class PageMapping : EntityTypeConfiguration<Page>
    {
        public PageMapping()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).IsRequired();
            Property(x => x.Name).IsRequired();
            Property(x => x.Slug).IsOptional();
            Property(x => x.PageContent).IsOptional();
            Property(x => x.IsActive).IsOptional();
        }
    }
}
