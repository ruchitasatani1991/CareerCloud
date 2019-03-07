using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.WCF
{
    [ServiceContract]
    public interface ISystem
    {
        //System Country Code
        [OperationContract]
        void AddSystemCountryCode(SystemCountryCodePoco[] item);

        [OperationContract]
        List<SystemCountryCodePoco> GetAllSystemCountryCode();

        [OperationContract]
        SystemCountryCodePoco GetSingleSystemCountryCode(string Id);

        [OperationContract]
        void RemoveSystemCountryCode(SystemCountryCodePoco[] item);

        [OperationContract]
        void UpdateSystemCountryCode(SystemCountryCodePoco[] item);

        //System LanguageCode
        [OperationContract]
        void AddSystemLanguageCode(SystemLanguageCodePoco[] item);

        [OperationContract]
        List<SystemLanguageCodePoco> GetAllSystemLanguageCode();

        [OperationContract]
        SystemLanguageCodePoco GetSingleSystemLanguageCode(string Id);

        [OperationContract]
        void RemoveSystemLanguageCode(SystemLanguageCodePoco[] item);

        [OperationContract]
        void UpdateSystemLanguageCode(SystemLanguageCodePoco[] item);
    }
}
