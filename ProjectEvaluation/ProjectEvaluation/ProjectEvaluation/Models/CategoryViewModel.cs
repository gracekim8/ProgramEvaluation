namespace ProjectEvaluation.Models
{
    public class CategoryViewModel
    {
        public string CatType { get; set; }

        public CategoryViewModel(string Type)
        {
            CatType = Type;
        }
    }
}
