using LouVuiDateCode;
using System;
using System.Globalization;

namespace LearnProject.LouVuiDateCode
{
    public static class CountryParser
    {
        public static Country[] GetCountry(string factoryLocationCode)
        {
            if (factoryLocationCode is null || factoryLocationCode.Length == 0)
            {
                throw new ArgumentNullException(nameof(factoryLocationCode));
            }

            char[] separators = { ' ', ',' };
            string[] france = "A0, A1, A2, AA, AAS, AH, AN, AR, AS, BA, BJ, BU, DR, DU, DR, DT, CO, CT, CX, ET, FL, LW, MB, MI, NO, RA, RI, SD, SF, SL, SN, SP, SR, TJ, TH, TR, TS, VI, VX".Split(separators);
            string[] germany = "LP, OL".Split(separators);
            string[] italy = "BC, BO, CE, FO, MA, OB, RC, RE, SA, TD".Split(separators);
            string[] spain = "CA, LO, LB, LM, LW, GI".Split(separators);
            string[] switzerland = "DI, FA".Split(separators);
            string[] usa = "FC, FH, LA, OS, SD, FL".Split(separators);

            if (factoryLocationCode.ToUpper(CultureInfo.CurrentCulture) == "LW")
            {
                return new[] { Country.France, Country.Spain };
            }

            if (factoryLocationCode.ToUpper(CultureInfo.CurrentCulture) == "FL" || factoryLocationCode.ToUpper(CultureInfo.CurrentCulture) == "SD")
            {
                return new[] { Country.France, Country.USA };
            }

            foreach (var item in france)
            {
                if (item == factoryLocationCode.ToUpper(CultureInfo.CurrentCulture))
                {
                    return new[] { Country.France };
                }
            }

            foreach (var item in germany)
            {
                if (item == factoryLocationCode.ToUpper(CultureInfo.CurrentCulture))
                {
                    return new[] { Country.Germany };
                }
            }

            foreach (var item in italy)
            {
                if (item == factoryLocationCode.ToUpper(CultureInfo.CurrentCulture))
                {
                    return new[] { Country.Italy };
                }
            }

            foreach (var item in spain)
            {
                if (item == factoryLocationCode.ToUpper(CultureInfo.CurrentCulture))
                {
                    return new[] { Country.Spain };
                }
            }

            foreach (var item in switzerland)
            {
                if (item == factoryLocationCode.ToUpper(CultureInfo.CurrentCulture))
                {
                    return new[] { Country.Switzerland };
                }
            }

            foreach (var item in usa)
            {
                if (item == factoryLocationCode.ToUpper(CultureInfo.CurrentCulture))
                {
                    return new[] { Country.USA };
                }
            }

            return Array.Empty<Country>();
        }
    }
}
