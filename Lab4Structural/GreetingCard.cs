using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Structural
{
    internal class GreetingCard : BouquetDecorator
    {
        private string Inscription { get; }
        public GreetingCard(Bouquet b, string inscription) : base(b.Name + ", with inscription card: \"" + inscription + "\"", b)
        {
            Inscription = inscription;
        }
    }
}
