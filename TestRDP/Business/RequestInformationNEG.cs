using TestRDP.Models;

namespace TestRDP.Business
{
    public class RequestInformationNEG
    {
        public Boolean ReceptRequestInformation(RequestInformation pRequest, Response pResponse)
        {
            var ResponseVar = new Response();
            ResponseVar.CardId = pRequest.CardId;

            return (pRequest.Token == pResponse.Token);

        }
    }
}
