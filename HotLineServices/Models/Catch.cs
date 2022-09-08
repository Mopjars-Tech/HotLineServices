﻿using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace HotLineServices.Models
{
    public class Catch
    {
        public string? User {  get; set; }
        [Required]
        public string Species { get; set; }
        [Required]
        public float TempFarenheit { get; set; }
        [Required]
        public WeatherCondition WeatherCondition { get; set; }
        [Required]
        public DateTime Created { get; set; }
        [Required]
        public DateTime CatchTime { get; set; }
        [Required]
        public float? WeightLbs { get; set; }
        public float? Length { get; set; }

    }

    public enum WeatherCondition
    {
        Sunny, Cloudy, Rainy
    }
}