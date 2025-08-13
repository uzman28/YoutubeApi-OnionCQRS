using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeApi.Domain.Common
{
    public class EntityBase : IEntityBase
    {
        public int ID { get; set; }
        public DateTime CreatedTime { get; set; }: DateTime.now
        public bool IsDeleted { get; set; }
    }
}
