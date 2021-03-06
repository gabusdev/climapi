// Generated by https://quicktype.io
using climapi.Models.Current;
namespace climapi.Models.Forecast
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class ExternalForecast
    {
        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("current")]
        public Current Current { get; set; }

        [JsonProperty("forecast")]
        public ForecastClass ForecastForecast { get; set; }
    }

    public partial class Current
    {
        [JsonProperty("last_updated_epoch")]
        public long LastUpdatedEpoch { get; set; }

        [JsonProperty("last_updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("temp_c")]
        public double TempC { get; set; }

        [JsonProperty("temp_f")]
        public double TempF { get; set; }

        [JsonProperty("is_day")]
        public long IsDay { get; set; }

        [JsonProperty("condition")]
        public Condition Condition { get; set; }

        [JsonProperty("wind_mph")]
        public double WindMph { get; set; }

        [JsonProperty("wind_kph")]
        public double WindKph { get; set; }

        [JsonProperty("wind_degree")]
        public long WindDegree { get; set; }

        [JsonProperty("wind_dir")]
        public string WindDir { get; set; }

        [JsonProperty("pressure_mb")]
        public double PressureMb { get; set; }

        [JsonProperty("pressure_in")]
        public double PressureIn { get; set; }

        [JsonProperty("precip_mm")]
        public double PrecipMm { get; set; }

        [JsonProperty("precip_in")]
        public double PrecipIn { get; set; }

        [JsonProperty("humidity")]
        public long Humidity { get; set; }

        [JsonProperty("cloud")]
        public long Cloud { get; set; }

        [JsonProperty("feelslike_c")]
        public double FeelslikeC { get; set; }

        [JsonProperty("feelslike_f")]
        public double FeelslikeF { get; set; }

        [JsonProperty("vis_km")]
        public double VisKm { get; set; }

        [JsonProperty("vis_miles")]
        public double VisMiles { get; set; }

        [JsonProperty("uv")]
        public double Uv { get; set; }

        [JsonProperty("gust_mph")]
        public double GustMph { get; set; }

        [JsonProperty("gust_kph")]
        public double GustKph { get; set; }
    }

    /*public partial class Condition
    {
        [JsonProperty("text")]
        public Text Text { get; set; }

        [JsonProperty("icon")]
        public Icon Icon { get; set; }

        [JsonProperty("code")]
        public long Code { get; set; }
    }*/

    public partial class ForecastClass
    {
        [JsonProperty("forecastday")]
        public Forecastday[] Forecastday { get; set; }
    }

    public partial class Forecastday
    {
        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("date_epoch")]
        public long DateEpoch { get; set; }

        [JsonProperty("day")]
        public Day Day { get; set; }

        [JsonProperty("astro")]
        public Astro Astro { get; set; }

        [JsonProperty("hour")]
        public Hour[] Hour { get; set; }
    }

    public partial class Astro
    {
        [JsonProperty("sunrise")]
        public string Sunrise { get; set; }

        [JsonProperty("sunset")]
        public string Sunset { get; set; }

        [JsonProperty("moonrise")]
        public string Moonrise { get; set; }

        [JsonProperty("moonset")]
        public string Moonset { get; set; }

        [JsonProperty("moon_phase")]
        public string MoonPhase { get; set; }

        [JsonProperty("moon_illumination")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long MoonIllumination { get; set; }
    }

    public partial class Day
    {
        [JsonProperty("maxtemp_c")]
        public double MaxtempC { get; set; }

        [JsonProperty("maxtemp_f")]
        public double MaxtempF { get; set; }

        [JsonProperty("mintemp_c")]
        public double MintempC { get; set; }

        [JsonProperty("mintemp_f")]
        public double MintempF { get; set; }

        [JsonProperty("avgtemp_c")]
        public double AvgtempC { get; set; }

        [JsonProperty("avgtemp_f")]
        public double AvgtempF { get; set; }

        [JsonProperty("maxwind_mph")]
        public double MaxwindMph { get; set; }

        [JsonProperty("maxwind_kph")]
        public double MaxwindKph { get; set; }

        [JsonProperty("totalprecip_mm")]
        public double TotalprecipMm { get; set; }

        [JsonProperty("totalprecip_in")]
        public double TotalprecipIn { get; set; }

        [JsonProperty("avgvis_km")]
        public double AvgvisKm { get; set; }

        [JsonProperty("avgvis_miles")]
        public double AvgvisMiles { get; set; }

        [JsonProperty("avghumidity")]
        public double Avghumidity { get; set; }

        [JsonProperty("daily_will_it_rain")]
        public long DailyWillItRain { get; set; }

        [JsonProperty("daily_chance_of_rain")]
        public long DailyChanceOfRain { get; set; }

        [JsonProperty("daily_will_it_snow")]
        public long DailyWillItSnow { get; set; }

        [JsonProperty("daily_chance_of_snow")]
        public long DailyChanceOfSnow { get; set; }

        [JsonProperty("condition")]
        public Condition Condition { get; set; }

        [JsonProperty("uv")]
        public double Uv { get; set; }
    }

    public partial class Hour
    {
        [JsonProperty("time_epoch")]
        public long TimeEpoch { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("temp_c")]
        public double TempC { get; set; }

        [JsonProperty("temp_f")]
        public double TempF { get; set; }

        [JsonProperty("is_day")]
        public long IsDay { get; set; }

        [JsonProperty("condition")]
        public Condition Condition { get; set; }

        [JsonProperty("wind_mph")]
        public double WindMph { get; set; }

        [JsonProperty("wind_kph")]
        public double WindKph { get; set; }

        [JsonProperty("wind_degree")]
        public long WindDegree { get; set; }

        [JsonProperty("wind_dir")]
        public string WindDir { get; set; }

        [JsonProperty("pressure_mb")]
        public double PressureMb { get; set; }

        [JsonProperty("pressure_in")]
        public double PressureIn { get; set; }

        [JsonProperty("precip_mm")]
        public double PrecipMm { get; set; }

        [JsonProperty("precip_in")]
        public double PrecipIn { get; set; }

        [JsonProperty("humidity")]
        public long Humidity { get; set; }

        [JsonProperty("cloud")]
        public long Cloud { get; set; }

        [JsonProperty("feelslike_c")]
        public double FeelslikeC { get; set; }

        [JsonProperty("feelslike_f")]
        public double FeelslikeF { get; set; }

        [JsonProperty("windchill_c")]
        public double WindchillC { get; set; }

        [JsonProperty("windchill_f")]
        public double WindchillF { get; set; }

        [JsonProperty("heatindex_c")]
        public double HeatindexC { get; set; }

        [JsonProperty("heatindex_f")]
        public double HeatindexF { get; set; }

        [JsonProperty("dewpoint_c")]
        public double DewpointC { get; set; }

        [JsonProperty("dewpoint_f")]
        public double DewpointF { get; set; }

        [JsonProperty("will_it_rain")]
        public long WillItRain { get; set; }

        [JsonProperty("chance_of_rain")]
        public long ChanceOfRain { get; set; }

        [JsonProperty("will_it_snow")]
        public long WillItSnow { get; set; }

        [JsonProperty("chance_of_snow")]
        public long ChanceOfSnow { get; set; }

        [JsonProperty("vis_km")]
        public double VisKm { get; set; }

        [JsonProperty("vis_miles")]
        public double VisMiles { get; set; }

        [JsonProperty("gust_mph")]
        public double GustMph { get; set; }

        [JsonProperty("gust_kph")]
        public double GustKph { get; set; }

        [JsonProperty("uv")]
        public double Uv { get; set; }
    }

    /*public partial class Location
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("tz_id")]
        public string TzId { get; set; }

        [JsonProperty("localtime_epoch")]
        public long LocaltimeEpoch { get; set; }

        [JsonProperty("localtime")]
        public string Localtime { get; set; }
    }*/

    public enum Icon { CdnWeatherapiComWeather64X64Day113Png, CdnWeatherapiComWeather64X64Night113Png, CdnWeatherapiComWeather64X64Night116Png };

    public enum Text { Clear, PartlyCloudy, Sunny };

    // public enum WindDir { E, Ese, S, Se, Sse };

    public partial class ExternalForecast
    {
        public static ExternalForecast FromJson(string json) => JsonConvert.DeserializeObject<ExternalForecast>(json, climapi.Models.Forecast.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this ExternalForecast self) => JsonConvert.SerializeObject(self, climapi.Models.Forecast.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                IconConverter.Singleton,
                TextConverter.Singleton,
                // WindDirConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class IconConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Icon) || t == typeof(Icon?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "//cdn.weatherapi.com/weather/64x64/day/113.png":
                    return Icon.CdnWeatherapiComWeather64X64Day113Png;
                case "//cdn.weatherapi.com/weather/64x64/night/113.png":
                    return Icon.CdnWeatherapiComWeather64X64Night113Png;
                case "//cdn.weatherapi.com/weather/64x64/night/116.png":
                    return Icon.CdnWeatherapiComWeather64X64Night116Png;
            }
            throw new Exception("Cannot unmarshal type Icon");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Icon)untypedValue;
            switch (value)
            {
                case Icon.CdnWeatherapiComWeather64X64Day113Png:
                    serializer.Serialize(writer, "//cdn.weatherapi.com/weather/64x64/day/113.png");
                    return;
                case Icon.CdnWeatherapiComWeather64X64Night113Png:
                    serializer.Serialize(writer, "//cdn.weatherapi.com/weather/64x64/night/113.png");
                    return;
                case Icon.CdnWeatherapiComWeather64X64Night116Png:
                    serializer.Serialize(writer, "//cdn.weatherapi.com/weather/64x64/night/116.png");
                    return;
            }
            throw new Exception("Cannot marshal type Icon");
        }

        public static readonly IconConverter Singleton = new IconConverter();
    }

    internal class TextConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Text) || t == typeof(Text?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Clear":
                    return Text.Clear;
                case "Partly cloudy":
                    return Text.PartlyCloudy;
                case "Sunny":
                    return Text.Sunny;
            }
            throw new Exception("Cannot unmarshal type Text");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Text)untypedValue;
            switch (value)
            {
                case Text.Clear:
                    serializer.Serialize(writer, "Clear");
                    return;
                case Text.PartlyCloudy:
                    serializer.Serialize(writer, "Partly cloudy");
                    return;
                case Text.Sunny:
                    serializer.Serialize(writer, "Sunny");
                    return;
            }
            throw new Exception("Cannot marshal type Text");
        }

        public static readonly TextConverter Singleton = new TextConverter();
    }

    // internal class WindDirConverter : JsonConverter
    // {
    //     public override bool CanConvert(Type t) => t == typeof(WindDir) || t == typeof(WindDir?);

    //     public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    //     {
    //         if (reader.TokenType == JsonToken.Null) return null;
    //         var value = serializer.Deserialize<string>(reader);
    //         switch (value)
    //         {
    //             case "E":
    //                 return WindDir.E;
    //             case "ESE":
    //                 return WindDir.Ese;
    //             case "S":
    //                 return WindDir.S;
    //             case "SE":
    //                 return WindDir.Se;
    //             case "SSE":
    //                 return WindDir.Sse;
    //         }
    //         throw new Exception("Cannot unmarshal type WindDir");
    //     }

    //     // public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    //     // {
    //     //     if (untypedValue == null)
    //     //     {
    //     //         serializer.Serialize(writer, null);
    //     //         return;
    //     //     }
    //     //     var value = (WindDir)untypedValue;
    //     //     switch (value)
    //     //     {
    //     //         case WindDir.E:
    //     //             serializer.Serialize(writer, "E");
    //     //             return;
    //     //         case WindDir.Ese:
    //     //             serializer.Serialize(writer, "ESE");
    //     //             return;
    //     //         case WindDir.S:
    //     //             serializer.Serialize(writer, "S");
    //     //             return;
    //     //         case WindDir.Se:
    //     //             serializer.Serialize(writer, "SE");
    //     //             return;
    //     //         case WindDir.Sse:
    //     //             serializer.Serialize(writer, "SSE");
    //     //             return;
    //     //     }
    //     //     throw new Exception("Cannot marshal type WindDir");
    //     // }

    //     public static readonly WindDirConverter Singleton = new WindDirConverter();
    // }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}
