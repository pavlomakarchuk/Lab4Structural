using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Structural
{
    public class Ribbon : BouquetDecorator
    {
        public Ribbon(Bouquet b) : base(b.Name + ", with ribbon with the brand name", b) { }
    }
}
