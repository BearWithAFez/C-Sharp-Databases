using Globals;
using System;
using System.Collections.Generic;

namespace Data
{
    public interface IDataGetter
    {
        Tuple<List<Player>, List<Game>, List<Score>> ReadDatabase();
    }
}
