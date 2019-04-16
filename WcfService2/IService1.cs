using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(CallbackContract =typeof(IServiceCallback))]
    public interface IService1
    {
        [OperationContract(IsOneWay = true)]
        void UselessFunction(int x);
    }
    public interface IServiceCallback
    {
        [OperationContract(IsOneWay =true)]
        void CallbackFunction(string message);
    }
  
    
}
