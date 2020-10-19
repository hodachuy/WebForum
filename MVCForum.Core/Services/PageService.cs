namespace MvcForum.Core.Services
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Threading.Tasks;
    using Constants;
    using Interfaces;
    using Interfaces.Services;
    using Models.Entities;
    using Models.General;
    using Utilities;
    public partial class PageService : IPageService
    {
        private IMvcForumContext _context;

        public PageService(IMvcForumContext context)
        {
            _context = context;
        }

        public void RefreshContext(IMvcForumContext context)
        {
            _context = context;
        }

        public async Task<int> SaveChanges()
        {
            return await _context.SaveChangesAsync();
        }

        public Page Add(Page page)
        {
            page.Name = StringUtils.SafePlainText(page.Name);
            return _context.Page.Add(page);
        }

        public void Delete(Page page)
        {
            _context.Page.Remove(page);
        }

        public Page Get(Guid id)
        {
            return _context.Page.FirstOrDefault(x => x.Id == id);

        }

        public async Task<PaginatedList<Page>> GetAllPaged(int pageIndex, int pageSize)
        {
            var query = _context.Page.OrderByDescending(x => x.Name);
            return await PaginatedList<Page>.CreateAsync(query.AsNoTracking(), pageIndex, pageSize);
        }

        public async Task<PaginatedList<Page>> GetAllPaged(string search, int pageIndex, int pageSize)
        {
            search = StringUtils.SafePlainText(search);

            var query = _context.Page
                .Where(x => x.Name.ToLower().Contains(search.ToLower()))
                .OrderByDescending(x => x.Name);
            return await PaginatedList<Page>.CreateAsync(query.AsNoTracking(), pageIndex, pageSize);
        }

        public IEnumerable<Page> GetAll()
        {
            return _context.Page
                    .AsNoTracking()
                    .OrderBy(x => x.Name)
                    .ToList();
        }
    }
}
