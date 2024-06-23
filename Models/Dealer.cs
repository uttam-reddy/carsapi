using Newtonsoft.Json;

namespace carsapi.Models
{
    public class Dealer
    {
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class _161992655
    {
        public string about { get; set; }
        public bool anonymous { get; set; }
        public string avatar_id { get; set; }
        public List<Badge> badges { get; set; }
        public DateTime created_at { get; set; }
        public Dealer dealer { get; set; }
        public bool has_phone { get; set; }
        public string id { get; set; }
        public List<object> images { get; set; }
        public bool is_banned { get; set; }
        public bool is_business { get; set; }
        public bool is_phone_visible { get; set; }
        public string lang { get; set; }
        public List<Location> locations { get; set; }
        public string name { get; set; }
        public bool name_provided { get; set; }
        public object phone { get; set; }
        public ShowroomAddress showroom_address { get; set; }
        public string verification_status { get; set; }
    }

    public class Badge
    {
        public string name { get; set; }
        public bool status { get; set; }
        public string type { get; set; }
    }

    public class Big
    {
        public int width { get; set; }
        public int height { get; set; }
        public string url { get; set; }
    }

    public class Car
    {
        public string dealer_type { get; set; }
        public Metadata metadata { get; set; }
    }

    public class Currency
    {
        public string pre { get; set; }
        public string post { get; set; }
        public string iso_4217 { get; set; }
        public string locale { get; set; }
    }

    public class Data
    {
        public bool leadEnabledCategories { get; set; }
        public object monetizationInfo { get; set; }
        public string id { get; set; }
        public int revision { get; set; }
        public DateTime created_at { get; set; }
        public DateTime created_at_first { get; set; }
        public object republish_date { get; set; }
        public DateTime valid_to { get; set; }
        public DateTime valid_from { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string category_id { get; set; }
        public Favorites favorites { get; set; }
        public Status status { get; set; }
        public List<Location> locations { get; set; }
        public List<Image> images { get; set; }
        public string user_id { get; set; }
        public Price price { get; set; }
        public List<Parameter> parameters { get; set; }
        public object views { get; set; }
        public object replies { get; set; }
        public object calls { get; set; }
        public bool isLeadAvailable { get; set; }
        public string main_info { get; set; }
        public string location_source { get; set; }
        public List<object> extra_parameters { get; set; }
        public object inspection_info { get; set; }
        public object booking_info { get; set; }
        public bool is_inspection_centre_available { get; set; }
    }
    


    public class Favorites
    {
        public int count { get; set; }
        public string count_label { get; set; }
        public string count_label_next { get; set; }
        public string count_label_prev { get; set; }
    }

    public class Filters
    {
        public List<Status> status { get; set; }
    }

    public class Flags
    {
        public bool @new { get; set; }
        public bool hot { get; set; }
    }

    public class Full
    {
        public int width { get; set; }
        public int height { get; set; }
        public string url { get; set; }
    }

    public class Image
    {
        public string id { get; set; }
        public string external_id { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string url { get; set; }
        public Full full { get; set; }
        public Big big { get; set; }
        public Medium medium { get; set; }
        public Small small { get; set; }
    }

    public class Links
    {
        public string postingGuidelines { get; set; }
    }

    public class Location
    {
        public double lat { get; set; }
        public double lon { get; set; }
        public string region_id { get; set; }
        public string subregion_id { get; set; }
        public string city_id { get; set; }
        public string district_id { get; set; }
    }

    public class Medium
    {
        public int width { get; set; }
        public int height { get; set; }
        public string url { get; set; }
    }

    public class Metadata
    {
        public object update { get; set; }
        public Filters filters { get; set; }
        public Links links { get; set; }
        public string cursor { get; set; }
        public int total { get; set; }
        public bool showDownloadLeads { get; set; }
        public int unfiltered_total { get; set; }
        public Users users { get; set; }
        public string status { get; set; }
    }

    public class Parameter
    {
        public string type { get; set; }
        public string key { get; set; }
        public string key_name { get; set; }
        public string value { get; set; }
        public string value_name { get; set; }
        public string formatted_value { get; set; }
    }

    public class Price
    {
        public string key { get; set; }
        public string key_name { get; set; }
        public Value value { get; set; }
    }

    public class CarDealerApi
    {
        public List<Data> data { get; set; }
        public Metadata metadata { get; set; }
    }

    public class ShowroomAddress
    {
        public List<object> operatingdetails { get; set; }
    }

    public class Small
    {
        public int width { get; set; }
        public int height { get; set; }
        public string url { get; set; }
    }

    public class Status
    {
        public string status { get; set; }
        public object link { get; set; }
        public object message { get; set; }
        public bool allow_edit { get; set; }
        public bool allow_deactivate { get; set; }
        public string display { get; set; }
        public string translated_display { get; set; }
        public Flags flags { get; set; }
        public object ban_reason_id { get; set; }
        public string key { get; set; }
        public string label { get; set; }
        public int count { get; set; }
    }

    public class Users
    {
        [JsonProperty("161992655")]
        public _161992655 _161992655 { get; set; }
    }

    public class Value
    {
        public int raw { get; set; }
        public string display { get; set; }
        public Currency currency { get; set; }
    }


}
