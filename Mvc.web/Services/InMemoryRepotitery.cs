using Mvc.web.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.web.Services
{
    public  class InMemoryRepotitery :IRepotitery<Student>
    {
        public IEnumerable<Student> GetAll()
        {
            return new List<Student> {
                new Student {
                            Id=1,
                            FristName="wang",
                            LastName="Jc",
                            BirthDay=new DateTime(1997,1,12)


            }

                ,
             new Student {
                            Id=2,
                            FristName="wang",
                            LastName="J",
                            BirthDay=new DateTime(1998,1,12)


            }
             ,
              new Student {
                            Id=3,
                            FristName="wang",
                            LastName="mt",
                            BirthDay=new DateTime(1999,1,12)


            }
            };
        }
     

    }
}
