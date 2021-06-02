namespace API.Errors
{
    public class ApiException : ApiResponse
    {
       public ApiException(int statusCode, string message = null, string details = null) : base(statusCode, message)
        {
            // We're setting "Details" based on what's inside the parameter
            Details = details;
        }

        public string Details { get; set; } 
    }
}