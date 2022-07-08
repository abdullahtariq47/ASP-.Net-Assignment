

using System.ComponentModel.DataAnnotations;

namespace assign1.Models
{
    public class information_customer
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public int age { get; set; }
        public string email { get; set; }
        public int phone { get; set; }
        public string gender { get; set; }
        public string dep { get; set; }
        public string message { get; set; }
    }
}
