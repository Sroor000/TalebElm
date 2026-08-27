

namespace TalebElm.Domain.Entities
{
    public  class Track :BaseEntity
    {
        public string Name { get; set; }=default!;
        public string Description { get; set; } = default!;
        public string Status { get; set; } = default!;
    }
}
