using IntegrationExample4.Interfaces;

namespace IntegrationExample4.Responses
{
    internal class SageClientResponse : IResponse
    {
        //We have to add all the fields from the response object here
        public string? response_Id { get; set; }
        public int companyId { get; set; }
        public string? CompanyName { get; set; }
        public string? Name { get; set; }
        public string? Reference { get; set; }
    }
}
