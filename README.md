**🧮 Calculator WCF Service (SOAP + REST)**
A simple WCF-based calculator service that exposes the same business logic through both SOAP and REST endpoints.
This project demonstrates how one service can support multiple communication styles using different bindings.

**📌 What This Project Demonstrates**
    WCF service hosting
    SOAP vs REST comparison
    Contract-based design
    DataContract usage
    Multi-endpoint configuration

**🔹 Layers**
1. Service Host
    Console application
    Configures endpoints
    Starts and stops the service

2. Service Contracts
    ICalcSOAPService  
    ICalcRESTService

3. Service Implementation
    CalcService 
    Contains shared business logic

4. Data Contract
    DataRequest (used for REST POST)

**🌐 Endpoints
🔵 SOAP Endpoint**
Binding: BasicHttpBinding
Format: XML
http://localhost:5000/CalculatorService/CalcSOAP

**🟢 REST Endpoints**
Binding: WebHttpBinding
Format: JSON
Addition (GET)
http://localhost:5000/CalculatorService/CalcREST/addition?a=5&b=3
Multiplication (POST)
http://localhost:5000/CalculatorService//CalcREST/mul-rest
Body :
{
  "A": 4,
  "B": 6
}

**🚀 How to Run**
Open solution in Visual Studio
Set CalculatorServiceHost as startup project
Run the application
Press Enter to stop the service
