using WebEmptyTemplate.Data.Models.CsModels;
using WebEmptyTemplate.Data.Models.CsModels.Components;

namespace WebEmptyTemplate.Data.DataBase
{
    public static class DbManager
    {
        /* bin/Debug/net6.0/ */
        public static string MOTHERBOARDS_PATH { get; } = $"bin/Debug/net6.0/DataBase/Xml/Motherboards.xml";
        public static string PROCESSORS_PATH { get; } = $"bin/Debug/net6.0/DataBase/Xml/Processors.xml";
        public static string RAMs_PATH { get; } = $"bin/Debug/net6.0/DataBase/Xml/RAMs.xml";
        public static string VIDEOCARDS_PATH { get; } = $"bin/Debug/net6.0/DataBase/Xml/VideoCards.xml";

        public static List<Motherboard> Motherboards { get; set; }
        public static List<Processor> Processors { get; set; }
        public static List<RAM> RAMs { get; set; }
        public static List<VideoCard> VideoCards { get; set; }

        public static List<Part> Parts { get; set; } = new List<Part>();

        public static void Nothing()
        {
            var val = 0;
        }

        static DbManager()
        {
            List<Motherboard> motherboards = new();
            List<Processor> processors = new();
            List<RAM> rams = new();
            List<VideoCard> videocards = new();

            Serializer.Deserialize(MOTHERBOARDS_PATH, ref motherboards);
            Serializer.Deserialize(PROCESSORS_PATH, ref processors);
            Serializer.Deserialize(RAMs_PATH, ref rams);
            Serializer.Deserialize(VIDEOCARDS_PATH, ref videocards);


            /* we can include some validation logic here-> */


           Motherboards = motherboards;
            Processors = processors;
            RAMs = rams;
            VideoCards = videocards;

            Parts.AddRange(Motherboards);
            Parts.AddRange(Processors);
            Parts.AddRange(RAMs);
            Parts.AddRange(VideoCards);
        }
    }
}
