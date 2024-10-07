namespace ProfessionalGYM.DataTransferModel.ResponseVM
{
    public sealed class ResponseVM
    {
        private static ResponseVM instance = null;

        private ResponseVM()
        {
        }

        public static ResponseVM Instance
        {
            get
            {
                //if (instance == null)
                {
                    instance = new ResponseVM();
                }
                return instance;
            }
        }
        public int responseCode { get; set; }
        public string errorMessage { get; set; } = "";
        public string responseMessage { get; set; } = "";
        public dynamic data { get; set; }
    }
}
