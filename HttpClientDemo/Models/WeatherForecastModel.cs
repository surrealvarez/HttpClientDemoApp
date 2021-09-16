﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HttpClientDemo.Models
{
    public class WeatherForecastModel
    {
        public DayForecastModel[] consolidated_weather { get; set; }
        public DateTime Sun_rise { get; set; } // sunRise -> SunRise (json to C#)
        public DateTime Sun_set { get; set; }
        public string Title { get; set; }
        public string Timezone { get; set; }
    }


}
