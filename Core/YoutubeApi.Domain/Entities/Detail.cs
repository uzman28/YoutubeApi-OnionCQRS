using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Domain.Common;

namespace YoutubeApi.Domain.Entities
{
    public class Detail:EntityBase
    {

        public Detail()
        {
            
        }

        public Detail(string Description,string Title,int CategoryId)
        {
            this.Description = Description;
            this.Title = Title;
            this.CategoryId = CategoryId;
        }




        public required string Description{ get; set; }
        public  required string Title { get; set; }
        public  required int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
