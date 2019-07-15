using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Utildivide
{
    public partial class ImageUtilDivideRequestModel : PddRequestModel
    {
        /// <summary>
        /// "http://pfs.htj.yiran.com/open_platform/2018-10-21/a648bc89-3c92-4e7f-bc8a-fd91e28c776f.png"
        /// </summary>
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

    }

}
