namespace WolfCMS.Entities.Concrete
{
    public class Customer : BaseClass
    {
        public string CustomerName { get; set; }
        public string ApplicationUrl { get; set; }
        public int IconId { get; set; }
        public int LogoId { get; set; }
        public int LanguageId { get; set; }
    }
}
