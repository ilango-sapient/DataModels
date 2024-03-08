using System.ComponentModel.DataAnnotations;

namespace DataModels
{
    public class MaterialsSearchResult
    {
        [Required(ErrorMessage = "MaterialId is required")]
        public int MaterialId { get; set; }
        public string MaterialName { get; set; }
        public string MaterialCode { get; set; }
        public string SourceSystem { get; set; }

    }
}
