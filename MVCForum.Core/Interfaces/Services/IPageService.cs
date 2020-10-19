
namespace MvcForum.Core.Interfaces.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Models.Activity;
    using Models.Entities;
    using Models.General;
    public partial interface IPageService : IContextService
    {
        IEnumerable<Page> GetAll();
        Task<PaginatedList<Page>> GetAllPaged(int pageIndex, int pageSize);
        Task<PaginatedList<Page>> GetAllPaged(string search, int pageIndex, int pageSize);
        Page Add(Page page);
        void Delete(Page page);
        Page Get(Guid id);
    }
}
