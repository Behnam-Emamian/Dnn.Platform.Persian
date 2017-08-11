using Microsoft.Multilingual.Xliff;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Multilingual.Utilities;

namespace Resx2Xlf
{
    class Program
    {
        static void Main(string[] args)
        {
            var SourcePath = @"D:\GitHub\Dnn.Platform.Persian\Solution\DNN\Website_v9.1.1\";
            var DestinationPath = @"D:\GitHub\Dnn.Platform.Persian\Solution\Resources\Website\";

            


            var ResourceFilePath = @"D:\GitHub\Dnn.Platform.Persian\Solution\DNN\Website_v9.1.1\Install\App_LocalResources\Installwizard.aspx.resx";

            var xliffSources = XliffDocument.ReadFromResource(ResourceFilePath, new CultureInfo("en-US"), string.Empty, ResourceType.Resx);

            //xliffSources[0].SaveAs(@"D:\GitHub\Dnn.Platform.Persian\Solution\Resources\Website\Install\App_LocalResources\Installwizard.aspx.xlf", ResourceType.Xliff20);
            xliffSources[0].FileInfos[0].TargetCulture = new CultureInfo("fa-IR");
            xliffSources[0].Save(@"D:\GitHub\Dnn.Platform.Persian\Solution\Resources\Website\Install\App_LocalResources\Installwizard.aspx.xlf");

        }
    }
}
