using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mvc.web.Model;

namespace Mvc.web.Services
{
    public interface IRepotitery<T> where T : class
    {
        IEnumerable<T> GetAll();

        Student GetStudent(int id);
        T add(T student);
    }
}
