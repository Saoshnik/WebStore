using WebEmptyTemplate.Data.Models.CsModels;
using WebEmptyTemplate.Data.Models.CsModels.Components;

namespace WebEmptyTemplate.Data.DataBase
{
    public static class DbManager
    {
        private static string _MOTHERBOARDS_PATH { get; } = $"Xml/Motherboards.xml";
        private static string _PROCESSORS_PATH { get; } = $"Xml/Processors.xml";
        private static string _RAMs_PATH { get; } = $"Xml/RAMs.xml";
        private static string _VIDEOCARDS_PATH { get; } = $"Xml/VideoCards.xml";

        public static List<Motherboard> Motherboards { get; set; }
        public static List<Processor> Processors { get; set; }
        public static List<RAM> RAMs { get; set; }
        public static List<VideoCard> VideoCards { get; set; }

        public static List<Part> Parts { get; set; } = new List<Part>();

        /*static DbManager()
        {
            List<Motherboard> motherboards = new();
            List<Processor> processors = new();
            List<RAM> rams = new();
            List<VideoCard> videocards = new();

            Serializer.Deserialize(_MOTHERBOARDS_PATH, ref motherboards);
            Serializer.Deserialize(_PROCESSORS_PATH, ref processors);
            Serializer.Deserialize(_RAMs_PATH, ref rams);
            Serializer.Deserialize(_VIDEOCARDS_PATH, ref videocards);


            *//* we can include some validation logic here -> *//*


            Motherboards = motherboards;
            Processors = processors;
            RAMs = rams;
            VideoCards = videocards;

            Parts.AddRange(Motherboards);
            Parts.AddRange(Processors);
            Parts.AddRange(RAMs);
            Parts.AddRange(VideoCards);
        }*/
    }
}
