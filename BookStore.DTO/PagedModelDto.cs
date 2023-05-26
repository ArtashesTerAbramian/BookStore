using System.Collections.Generic;

namespace BookStore.DTO
{
    public class PagedModelDto<T>
    {
        public List<T> Entities { get; set; }
        public int Count { get; set; }
        public Dictionary<string, string> AdditionalInfo { get; set; }
    }
}
