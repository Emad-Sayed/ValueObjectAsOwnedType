using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnTypeDemo.Db
{
    public abstract class ValueObject
    {
        protected abstract IEnumerable<object> GetEqualityComponents();
        public bool EqualOperator(ValueObject right)
        {
            return (GetType()==right.GetType()&&GetEqualityComponents().SequenceEqual(right.GetEqualityComponents()));
        }
    }
}
