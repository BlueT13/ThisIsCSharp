using System;

namespace Chapter03
{
    class MainApp
    {
        static void Main(string[] args)
        {
            IntegralTypes.PrintIntegralTypes(args);
            BoxingUnboxing.PrintBoxingUnboxing(args);
            StringNumberConverion.PrintStringNumberConverion(args);
            Enum.PrintEnum(args);
            StringSearch.PrintStringSearch(args);
            StringFormatDatetime.PrintStringFormatDatetime(args);
        }
    }
}
