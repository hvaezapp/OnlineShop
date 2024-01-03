using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Domain.Common
{
    public abstract class BaseDomainEntity<T> where T : struct
    {
        public T Id { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsDeleted { get; set; }


        public BaseDomainEntity()
        {
            IsDeleted = false;
            DateCreated = DateTime.Now;
        }


        public void Delete()
        {
            IsDeleted = true;
        }


    }
}
