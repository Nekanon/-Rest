using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Serenity.Models;

namespace Serenity.Interfaces
{
    public interface IAnyRepository
    {
        List<Any> GetAll();

        Any Get(Guid guid);

        Any Create(Any any);

        Any Update(Guid guid, Any any);

        Any Delete(Guid guid);
    }
}
