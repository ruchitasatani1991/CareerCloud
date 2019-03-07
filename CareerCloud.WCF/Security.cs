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
    public class Security : ISecurity
    {
        private SecurityLoginLogic _securityLogin;
        private SecurityLoginsLogLogic _securityLoginsLog;
        private SecurityLoginsRoleLogic _securityLoginsRole;
        private SecurityRoleLogic _securityRole;

        public Security()
        {
            //SecurityLoginRepository Secrepo = new SecurityLoginRepository();
            EFGenericRepository<SecurityLoginPoco> Secrepo = new EFGenericRepository<SecurityLoginPoco>(false);
            _securityLogin = new SecurityLoginLogic(Secrepo);

            //SecurityLoginsLogRepository SecLoginrepo = new SecurityLoginsLogRepository();
            EFGenericRepository<SecurityLoginsLogPoco> SecLoginrepo = new EFGenericRepository<SecurityLoginsLogPoco>(false);
            _securityLoginsLog = new SecurityLoginsLogLogic(SecLoginrepo);

            //SecurityLoginsRoleRepository SecRolerepo = new SecurityLoginsRoleRepository();
            EFGenericRepository<SecurityLoginsRolePoco> SecRolerepo = new EFGenericRepository<SecurityLoginsRolePoco>(false);
            _securityLoginsRole = new SecurityLoginsRoleLogic(SecRolerepo);

            //SecurityRoleRepository Rolerepo = new SecurityRoleRepository();
            EFGenericRepository<SecurityRolePoco> Rolerepo = new EFGenericRepository<SecurityRolePoco>(false);
            _securityRole = new SecurityRoleLogic(Rolerepo);
        }
        public void AddSecurityLogin(SecurityLoginPoco[] item)
        {
            _securityLogin.Add(item);
        }

        public void AddSecurityLoginsLog(SecurityLoginsLogPoco[] item)
        {
            _securityLoginsLog.Add(item);
        }

        public void AddSecurityLoginsRole(SecurityLoginsRolePoco[] item)
        {
            _securityLoginsRole.Add(item);
        }

        public void AddSecurityRole(SecurityRolePoco[] item)
        {
            _securityRole.Add(item);
        }

        public List<SecurityLoginPoco> GetAllSecurityLogin()
        {
            return _securityLogin.GetAll();
        }

        public List<SecurityLoginsLogPoco> GetAllSecurityLoginsLog()
        {
            return _securityLoginsLog.GetAll();
        }

        public List<SecurityLoginsRolePoco> GetAllSecurityLoginsRole()
        {
            return _securityLoginsRole.GetAll();
        }

        public List<SecurityRolePoco> GetAllSecurityRole()
        {
            return _securityRole.GetAll();
        }

        public SecurityLoginPoco GetSingleSecurityLogin(string Id)
        {
            return _securityLogin.Get(Guid.Parse(Id));
        }

        public SecurityLoginsLogPoco GetSingleSecurityLoginsLog(string Id)
        {
            return _securityLoginsLog.Get(Guid.Parse(Id));
        }

        public SecurityLoginsRolePoco GetSingleSecurityLoginsRole(string Id)
        {
            return _securityLoginsRole.Get(Guid.Parse(Id));
        }

        public SecurityRolePoco GetSingleSecurityRole(string Id)
        {
            return _securityRole.Get(Guid.Parse(Id));
        }

        public void RemoveSecurityLogin(SecurityLoginPoco[] item)
        {
            _securityLogin.Delete(item);
        }

        public void RemoveSecurityLoginsLog(SecurityLoginsLogPoco[] item)
        {
            _securityLoginsLog.Delete(item);
        }

        public void RemoveSecurityLoginsRole(SecurityLoginsRolePoco[] item)
        {
            _securityLoginsRole.Delete(item);
        }

        public void RemoveSecurityRole(SecurityRolePoco[] item)
        {
            _securityRole.Delete(item);
        }

        public void UpdateSecurityLogin(SecurityLoginPoco[] item)
        {
            _securityLogin.Update(item);
        }

        public void UpdateSecurityLoginsLog(SecurityLoginsLogPoco[] item)
        {
            _securityLoginsLog.Update(item);
        }

        public void UpdateSecurityLoginsRole(SecurityLoginsRolePoco[] item)
        {
            _securityLoginsRole.Update(item);
        }

        public void UpdateSecurityRole(SecurityRolePoco[] item)
        {
            _securityRole.Update(item);
        }
    }
}
