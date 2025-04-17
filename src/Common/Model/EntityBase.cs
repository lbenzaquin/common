using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Common.Model
{
    public class EntityBase
    {
        [Key]
        [JsonProperty("id")]
        public Guid? Id { get; set; }
    }
}
