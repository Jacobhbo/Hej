using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecTilmeldning.Code
{
    internal sealed class Elev : Person
    {

        public Elev(string? fornavn, string? efternavn, DateTime fødselsdag) : base(fornavn, efternavn, fødselsdag)
        {
            string defaultInfo = ShowAllInfo2();
        }

        protected override string ShowAllInfo()
        {
            return $"{PersonInfo.Fornavn} {PersonInfo.Efternavn}";
        }

    }
}
