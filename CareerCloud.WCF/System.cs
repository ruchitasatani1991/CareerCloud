using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareerCloud.ADODataAccessLayer;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;

namespace CareerCloud.WCF
{
    public class System : ISystem
    {
        private SystemCountryCodeLogic _systemCountryCodeLogic;
        private SystemLanguageCodeLogic _systemLanguageCodeLogic;

        public System()
        {
            //SystemCountryCodeRepository Sysrepo = new SystemCountryCodeRepository();
            EFGenericRepository<SystemCountryCodePoco> Sysrepo = new EFGenericRepository<SystemCountryCodePoco>(false);
            _systemCountryCodeLogic = new SystemCountryCodeLogic(Sysrepo);

            //SystemLanguageCodeRepository SysLanguagerepo = new SystemLanguageCodeRepository();
            EFGenericRepository<SystemLanguageCodePoco> SysLanguagerepo = new EFGenericRepository<SystemLanguageCodePoco>(false);
            _systemLanguageCodeLogic = new SystemLanguageCodeLogic(SysLanguagerepo);
        }
        public void AddSystemCountryCode(SystemCountryCodePoco[] item)
        {
            _systemCountryCodeLogic.Add(item);
        }

        public void AddSystemLanguageCode(SystemLanguageCodePoco[] item)
        {
            _systemLanguageCodeLogic.Add(item);
        }

        public List<SystemCountryCodePoco> GetAllSystemCountryCode()
        {
            return _systemCountryCodeLogic.GetAll();
        }

        public List<SystemLanguageCodePoco> GetAllSystemLanguageCode()
        {
            return _systemLanguageCodeLogic.GetAll();
        }

        public SystemCountryCodePoco GetSingleSystemCountryCode(string Id)
        {
            return _systemCountryCodeLogic.Get(Id);
        }

        public SystemLanguageCodePoco GetSingleSystemLanguageCode(string Id)
        {
            return _systemLanguageCodeLogic.Get(Id);
        }

        public void RemoveSystemCountryCode(SystemCountryCodePoco[] item)
        {
            _systemCountryCodeLogic.Delete(item);
        }

        public void RemoveSystemLanguageCode(SystemLanguageCodePoco[] item)
        {
            _systemLanguageCodeLogic.Delete(item);
        }

        public void UpdateSystemCountryCode(SystemCountryCodePoco[] item)
        {
            _systemCountryCodeLogic.Update(item);
        }

        public void UpdateSystemLanguageCode(SystemLanguageCodePoco[] item)
        {
            _systemLanguageCodeLogic.Update(item);
        }
    }
}
