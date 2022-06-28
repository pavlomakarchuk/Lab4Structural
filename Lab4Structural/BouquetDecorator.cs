using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Structural
{
    public abstract class BouquetDecorator : Bouquet
    {
        protected Bouquet bouquet;
        public BouquetDecorator(string name, Bouquet bouquet) : base(name)
        {
            this.bouquet = bouquet;
        }
    }
}
