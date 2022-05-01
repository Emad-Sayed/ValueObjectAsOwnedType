using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnTypeDemo.Db.Entity
{
    public class Hobby : ValueObject
    {
        public string Name { get; private set; }
        public int HobbyTypeId { get; private set; }
        public HobbyType HobbyType { get; private set; }
        public Hobby() { }

        public Hobby(string name, int type)
        {
            Name = name;
            HobbyTypeId = type;
        }


        protected override IEnumerable<object> GetEqualityComponents()
        {
            // Using a yield return statement to return each element one at a time
            yield return Name;
            yield return HobbyTypeId;
        }

    }
}
