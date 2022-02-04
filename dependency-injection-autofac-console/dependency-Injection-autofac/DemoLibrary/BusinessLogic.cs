using DemoLibrary.Utilities;
using System;

namespace DemoLibrary
{
    public class BusinessLogic : IBusinessLogic
    {
        ILogger _logger;
        IDataAccess _dataAccess;
        public BusinessLogic(IDataAccess dataAccess, ILogger logger)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }
        public void ProcesseData()
        {
            _logger.Log("Processing the data");
            Console.WriteLine("Processin the data");
            _dataAccess.LoadData();
            _dataAccess.SaveData("ProcessInfo");
            _logger.Log("Finished processing of the data.");
        }
    }
}
