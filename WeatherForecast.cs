namespace carsapi
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);



    
    public class Metadatalogin
    {
        public string? deviceInfo { get; set; }
    }

    public class Loginobj
    {
        public string grantType { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string language { get; set; }
        public Metadatalogin metadata { get; set; }
    }


    public class AppliedFilter
    {
        public string id { get; set; }
        public bool is_relaxed { get; set; }
        public List<Value> values { get; set; }
        public long display_order { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public string render_as { get; set; }
    }

    public class AppliedSorting
    {
        public string key { get; set; }
    }

    public class Big
    {
        public long width { get; set; }
        public long height { get; set; }
        public string url { get; set; }
    }

    public class Child
    {
        public string id { get; set; }
        public string name { get; set; }
        public long level { get; set; }
        public long count { get; set; }
        public List<Child> children { get; set; }
        public long display_order { get; set; }
        public long? parent_id { get; set; }
        public double? latitude { get; set; }
        public long? location_id { get; set; }
        public string location_type { get; set; }
        public double? longitude { get; set; }
    }

    public class Currency
    {
        public string iso_4217 { get; set; }
        public string pre { get; set; }
        public string locale { get; set; }
    }

    public class CustomConfiguration
    {
        public string label { get; set; }
        public string selection_type { get; set; }
    }

    public class Datum
    {
        public string id { get; set; }
        public double score { get; set; }
        public Spell spell { get; set; }
        public Status status { get; set; }
        public string category_id { get; set; }
        public string ad_id { get; set; }
        public Favorites favorites { get; set; }
        public bool has_phone_param { get; set; }
        public string description { get; set; }
        public DateTime created_at { get; set; }
        public InspectionInfo inspection_info { get; set; }
        public object package_id { get; set; }
        public string title { get; set; }
        public object multi_location { get; set; }
        public string car_body_type { get; set; }
        public object partner_id { get; set; }
        public string user_type { get; set; }
        public Price price { get; set; }
        public object partner_code { get; set; }
        public MonetizationInfo monetizationInfo { get; set; }
        public List<Image> images { get; set; }
        public bool certified_car { get; set; }
        public bool is_kyc_verified_user { get; set; }
        public LocationsResolved locations_resolved { get; set; }
        public object deal_price { get; set; }
        public string business_platform { get; set; }
        public string main_info { get; set; }
        public bool artificial_boost { get; set; }
        public DateTime display_date { get; set; }
        public bool isSpinViewAvailable { get; set; }
        public string user_id { get; set; }
        public object installment { get; set; }
        public DateTime created_at_first { get; set; }
        public List<Location> locations { get; set; }
        public List<Parameter> parameters { get; set; }
        public List<string> vasTags { get; set; }
        public object platform { get; set; }


        public override bool Equals(Object? obj)
        {
            if(ad_id == ((Datum)obj).ad_id)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return ad_id.GetHashCode();
        }
    }

    public class Favorites
    {
        public long count { get; set; }
        public string count_label_next { get; set; }
        public string count_label { get; set; }
        public string count_label_prev { get; set; }
    }

    public class Filter
    {
        public string id { get; set; }
        public List<Value> values { get; set; }
        public long display_order { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public string render_as { get; set; }
        public bool? tag_visible { get; set; }
        public bool? hidden { get; set; }
        public bool? is_hidden { get; set; }
        public CustomConfiguration custom_configuration { get; set; }
        public string section_name { get; set; }
        public PopularValuesConfiguration popular_values_configuration { get; set; }
        public SearchConfiguration search_configuration { get; set; }
        public List<Range> range { get; set; }
    }

    public class Flags
    {
        public bool @new { get; set; }
        public bool hot { get; set; }
    }

    public class Full
    {
        public long width { get; set; }
        public long height { get; set; }
        public string url { get; set; }
    }

    public class Image
    {
        public string id { get; set; }
        public string external_id { get; set; }
        public long width { get; set; }
        public long height { get; set; }
        public string url { get; set; }
        public Full full { get; set; }
        public Big big { get; set; }
        public Medium medium { get; set; }
        public Small small { get; set; }
    }

    public class InspectionInfo
    {
        public string inspection_id { get; set; }
        public string group { get; set; }
    }

    public class Location
    {
        public double lat { get; set; }
        public double lon { get; set; }
        public string region_id { get; set; }
        public string district_id { get; set; }
        public string city_id { get; set; }
    }

    public class LocationsResolved
    {
        public string COUNTRY_id { get; set; }
        public string COUNTRY_name { get; set; }
        public string ADMIN_LEVEL_1_id { get; set; }
        public string ADMIN_LEVEL_1_name { get; set; }
        public string ADMIN_LEVEL_3_id { get; set; }
        public string ADMIN_LEVEL_3_name { get; set; }
        public string SUBLOCALITY_LEVEL_1_id { get; set; }
        public string SUBLOCALITY_LEVEL_1_name { get; set; }
    }

    public class Medium
    {
        public long width { get; set; }
        public long height { get; set; }
        public string url { get; set; }
    }

    public class Metadata
    {
        public List<Section> sections { get; set; }
        public string feed_version { get; set; }
        public long total_ads { get; set; }
        public long total_suggested_ads { get; set; }
        public long total_similar_ads { get; set; }
        public long ads_on_page { get; set; }
        public long total_pages { get; set; }
        public string resultset_id { get; set; }
        public List<object> suggested_sections { get; set; }
        public string modified_term { get; set; }
        public List<Filter> filters { get; set; }
        public List<object> applicable_suggestions { get; set; }
        public List<AppliedFilter> applied_filters { get; set; }
        public List<object> relaxed_filters { get; set; }
        public AppliedSorting applied_sorting { get; set; }
        public string next_page_url { get; set; }
        public ModifiedFilters modified_filters { get; set; }
    }

    public class ModifiedFilters
    {
    }

    public class MonetizationInfo
    {
        public string adId { get; set; }
        public DateTime lastBoosted { get; set; }
    }

    public class Parameter
    {
        public string type { get; set; }
        public string key { get; set; }
        public string value_name { get; set; }
        public string value { get; set; }
        public string key_name { get; set; }
        public string formatted_value { get; set; }
    }

    public class PopularValuesConfiguration
    {
        public string label { get; set; }
        public string selection_type { get; set; }
        public List<Value> values { get; set; }
    }

    public class Price
    {
        public Value value { get; set; }
        public string key_name { get; set; }
        public string key { get; set; }
    }

    public class Range
    {
        public long min { get; set; }
        public long max { get; set; }
        public string id { get; set; }
        public string description { get; set; }
        public long min_value { get; set; }
        public long max_value { get; set; }
    }

    public class Carsdata
    {
        public string version { get; set; }
        public List<Datum> data { get; set; }
        public Metadata metadata { get; set; }
        public bool empty { get; set; }
        public bool not_empty { get; set; }
        public List<object> suggested_data { get; set; }
        public List<object> similarads_data { get; set; }
    }

    public class SearchConfiguration
    {
        public string label { get; set; }
    }

    public class Section
    {
        public long id { get; set; }
        public long offset { get; set; }
        public string criterion { get; set; }
        public long distance { get; set; }
        public string relaxation_type { get; set; }
    }

    public class Small
    {
        public long width { get; set; }
        public long height { get; set; }
        public string url { get; set; }
    }

    public class Spell
    {
        public long id { get; set; }
        public string key { get; set; }
        public string version { get; set; }
        public bool main { get; set; }
        public bool facet_disabled { get; set; }
        public string default_sorting { get; set; }
    }

    public class Status
    {
        public string status { get; set; }
        public bool allow_edit { get; set; }
        public object ban_reason_id { get; set; }
        public string display { get; set; }
        public string translated_display { get; set; }
        public object link { get; set; }
        public Flags flags { get; set; }
        public object message { get; set; }
        public bool allow_deactivate { get; set; }
    }

    public class Value
    {
        public double raw { get; set; }
        public Currency currency { get; set; }
        public string display { get; set; }
    }

    public class Value2
    {
        public string id { get; set; }
        public string name { get; set; }
        public long level { get; set; }
        public long count { get; set; }
        public List<Child> children { get; set; }
        public long display_order { get; set; }
        public double? latitude { get; set; }
        public long? location_id { get; set; }
        public string location_type { get; set; }
        public double? longitude { get; set; }
        public string value { get; set; }
        public Range range { get; set; }
        public string icon_url { get; set; }
    }











    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Badge
    {
        public string name { get; set; }
        public bool status { get; set; }
        public string type { get; set; }
    }

    public class LoginLocation
    {
        public string cityId { get; set; }
        public string districtId { get; set; }
        public long lat { get; set; }
        public long lon { get; set; }
        public string regionId { get; set; }
        public string subregionId { get; set; }
    }

    public class Afterloglongoken
    {
        public string status { get; set; }
        public Loginneduser user { get; set; }
        public string refreshToken { get; set; }
        public string accessToken { get; set; }
        public string notificationHubId { get; set; }
        public string chatToken { get; set; }
    }

    public class Loginneduser
    {
        public string about { get; set; }
        public bool anonymous { get; set; }
        public string avatarId { get; set; }
        public List<Badge> badges { get; set; }
        public DateTime createdAt { get; set; }
        public bool hasPhone { get; set; }
        public string id { get; set; }
        public List<object> images { get; set; }
        public bool isBanned { get; set; }
        public bool isBusiness { get; set; }
        public bool isPhoneVisible { get; set; }
        public string lang { get; set; }
        public List<LoginLocation> locations { get; set; }
        public string name { get; set; }
        public bool nameProvided { get; set; }
        public object phone { get; set; }
        public string verificationStatus { get; set; }
    }




}