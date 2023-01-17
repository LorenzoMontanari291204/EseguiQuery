using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eseguiquerysql
{
    class ClassQuery
    {
        public List<ClassQuery> query;
        public string titolo { get; set; }

        public string sql { get; set; }

        public ClassQuery(string t, string s)
        {
            query = new List<ClassQuery>();
            titolo = t;
            sql = s;
        }
    }
}
