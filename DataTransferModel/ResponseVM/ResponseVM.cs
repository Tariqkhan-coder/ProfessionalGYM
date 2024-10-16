namespace ProfessionalGYM.DataTransferModel.ResponseVM
{
    public sealed class ResponseVM
    {
        private static ResponseVM instance = null;

        private ResponseVM()
        {
        }
        public static class ResponseCode
        {
            public const int Success = 200;
            public const int BadRequest = 400;
            public const int InternalServerError = 500;
            public const int UnAuthorized = 401;
            public const int NotFound = 404;

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
