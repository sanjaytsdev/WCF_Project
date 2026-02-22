namespace CalculatorServiceLibrary
{
    public class CalcService : ICalcRESTService, ICalcSOAPService
    {
        public int Add(int a, int b) {  return a + b; }
        public int Addition(int a, int b) { return a + b; }
        public int Multiplicaton(DataRequest request)
        {
            return request.A * request.B;
        }
    }
}
