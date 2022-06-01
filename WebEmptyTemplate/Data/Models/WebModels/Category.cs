using WebEmptyTemplate.Data.Models.CsModels;

namespace WebEmptyTemplate.Data.Models.Web
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        // public string Description { get; set; }

        public List<Part> Parts { get; set; }
    }
}
