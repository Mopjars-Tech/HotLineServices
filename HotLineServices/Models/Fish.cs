using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;

namespace HotLineServices.Models
{
    public class Fish
    {
        [Key]
        [JsonIgnore]
        public int? Id { get; set; }
        [Required]
        public string? User {  get; set; }
        [Required]
        public string? Species { get; set; }
        [Required]
        public float TempFarenheit { get; set; }
        [Required]
        public WeatherCondition WeatherCondition { get; set; }
        [Required]
        public DateTime Created { get; set; }
        [Required]
        public DateTime FishTime { get; set; }
        [Required]
        public float? WeightLbs { get; set; }
        public float? Length { get; set; }

    }

    public enum WeatherCondition
    {
        Sunny, Cloudy, Rainy
    }
}
