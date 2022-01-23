using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace AsyncNamedParameters
{
    class CohartDetails
    {
        public static void Main(string[] args)
        {
            GetCohortDetails("DF014", 30, "OBL", ".Net", "c#");
            GetCohortDetails("PARC", 30, "DF014", "java ", "java");
            GetCohortDetails(cohortname: "DF014", Mode: "OBL", Track: ".Net", gencCount: 15, currentModule: ".net core");
        }
        public static void GetCohortDetails(string cohortname, int gencCount, string Mode, string Track, string currentModule)
        {
            Console.WriteLine($"It is {cohortname} with {gencCount} Gencs undergoing training for {Track} through {Mode}. The Current module of training is {currentModule}");
            Thread.Sleep(5000);


        }
    }
}
