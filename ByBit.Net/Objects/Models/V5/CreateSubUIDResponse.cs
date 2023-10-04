namespace Bybit.Net.Objects.Models.V5
{
    public class CreateSubUIDResponse
    {
        /// <summary>
        /// The order id
        /// </summary>
        public string uid { get; set; } = string.Empty;
        /// <summary>
        /// Client order id
        /// </summary>
        public string username { get; set; } = string.Empty;

        public string memberType { get; set; } = string.Empty;
    }
}