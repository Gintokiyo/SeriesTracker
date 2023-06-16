using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.HelpFunctions
{
    public static class HelpFunctions
    {
        public static int FindFirstEntry(int page)
        {
            int result = page - 1 == 0 ? 1 : 1 + (20 * (page - 1));

            return result;
        }
    }
}
