using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace CalculatorServiceLibrary
{
    [ServiceContract]
    public interface ICalcRESTService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/addition?a={a}&b={b}", ResponseFormat = WebMessageFormat.Json)]
        int Addition(int a, int b);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/mul-rest", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        int Multiplicaton(DataRequest request);
    }

    [DataContract]
    public class DataRequest
    {
        [DataMember] 
        public int A { get; set; }
        [DataMember] 
        public int B { get; set; }
    }

}
