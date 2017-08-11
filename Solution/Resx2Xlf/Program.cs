using Microsoft.Multilingual.Xliff;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Multilingual.Utilities;
using System.IO;

namespace Resx2Xlf
{
    class Program
    {
        static DirectoryInfo SourceDir = new DirectoryInfo(@"D:\GitHub\Dnn.Platform.Persian\Solution\DNN\Website_v9.1.1\");
        static DirectoryInfo DestinationDir = new DirectoryInfo(@"D:\GitHub\Dnn.Platform.Persian\Solution\Resources\Website\");

        static void Main(string[] args)
        {
            ConvertResx2Xlf(SourceDir);
        }

        static void ConvertResx2Xlf(DirectoryInfo Path)
        {
            foreach (var File in Path.GetFiles("*.resx"))
            {
                var RelativeFilePath = File.FullName.Replace(SourceDir.FullName, "").Replace(File.Extension, "");

                var xliffSources = XliffDocument.ReadFromResource(SourceDir.FullName + RelativeFilePath + ".resx", new CultureInfo("en-US"), string.Empty, ResourceType.Resx);
                xliffSources[0].FileInfos[0].TargetCulture = new CultureInfo("fa-IR");
                xliffSources[0].Save(DestinationDir.FullName + RelativeFilePath + ".fa-IR.xlf");
            }

            foreach (var Dir in Path.GetDirectories())
                ConvertResx2Xlf(Dir);
        }
    }
}
