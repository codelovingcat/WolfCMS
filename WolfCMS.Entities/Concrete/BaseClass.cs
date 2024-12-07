namespace WolfCMS.Entities.Concrete
{
    public class BaseClass
    {
        public int Id { get; set; }
        public bool IsPermanentlyDeleted { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserId { get; set; }
        public int ModifiedByUserId { get; set; }
        public int DeletedByUserId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public DateTime IsDeletedOn { get; set; }
    }
}