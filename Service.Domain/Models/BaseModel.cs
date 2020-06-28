using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Domain.Models
{
    public abstract class BaseModel
    {
        public BaseModel()
        {
            CreatedDate = DateTime.UtcNow;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
