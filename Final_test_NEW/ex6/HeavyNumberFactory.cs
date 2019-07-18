using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    public static class HeavyNumberFactory
    {
        private static Dictionary<string, VeryHeavyNumber> heavyNumbers = new Dictionary<string, VeryHeavyNumber>();
        
        public static VeryHeavyNumber GetVeryHeavynumber(string key)
        {
            if (heavyNumbers.TryGetValue(key, out VeryHeavyNumber result))
            {
                return result;
            }
            else
            {
                string[] HeavyNumComp = key.Split(',');
                heavyNumbers.Add(key, new VeryHeavyNumber(Convert.ToInt32(HeavyNumComp[0]), Convert.ToInt32(HeavyNumComp[1])));
                return heavyNumbers[key];
            }
        }

    }
}
