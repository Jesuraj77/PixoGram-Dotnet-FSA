using Pixogram.Entities;
using System;
using System.Linq;

using System.Collections.Generic;
using System.Text;

namespace Pixogram.DataLayer.NHibernate
{
    public interface IMapperSession
    {
        void BeginTransaction();
        System.Threading.Tasks.Task Commit();
        System.Threading.Tasks.Task Rollback();
        void CloseTransaction();
        System.Threading.Tasks.Task Save(List<Content> entity);
        System.Threading.Tasks.Task Delete(Content entity);
        IQueryable<Content> products { get; }
    }
}
