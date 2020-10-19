using MvcForum.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcForum.Core.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using Utilities;
    public partial class Page : IBaseEntity
    {
        public Page()
        {
            Id = GuidComb.GenerateComb();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string PageContent { get; set; }
        public bool IsActive { get; set; }
    }
}
