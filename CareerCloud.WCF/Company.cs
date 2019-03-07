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
    public class Company : ICompany
    {
        private CompanyDescriptionLogic _companyDescription;
        private CompanyJobDescriptionLogic _companyJobDescription;
        private CompanyJobEducationLogic _companyJobEducation;
        private CompanyJobLogic _companyJob;
        private CompanyJobSkillLogic _companyJobSkill;
        private CompanyLocationLogic _companyLocation;
        private CompanyProfileLogic _companyProfile;

        public Company()
        {
            //CompanyDescriptionRepository Desrepo = new CompanyDescriptionRepository();
            EFGenericRepository<CompanyDescriptionPoco> Desrepo = new EFGenericRepository<CompanyDescriptionPoco>(false);
            _companyDescription = new CompanyDescriptionLogic(Desrepo);

            //CompanyJobDescriptionRepository DesJobrepo = new CompanyJobDescriptionRepository();
            EFGenericRepository<CompanyJobDescriptionPoco> DesJobrepo = new EFGenericRepository<CompanyJobDescriptionPoco>(false);
            _companyJobDescription = new CompanyJobDescriptionLogic(DesJobrepo);

            //CompanyJobEducationRepository JobEdurepo = new CompanyJobEducationRepository();
            EFGenericRepository<CompanyJobEducationPoco> JobEdurepo = new EFGenericRepository<CompanyJobEducationPoco>(false);
            _companyJobEducation = new CompanyJobEducationLogic(JobEdurepo);

            //CompanyJobRepository Jobrepo = new CompanyJobRepository();
            EFGenericRepository<CompanyJobPoco> Jobrepo = new EFGenericRepository<CompanyJobPoco>(false);
            _companyJob = new CompanyJobLogic(Jobrepo);

            //CompanyJobSkillRepository JobSkillrepo = new CompanyJobSkillRepository();
            EFGenericRepository<CompanyJobSkillPoco> JobSkillrepo = new EFGenericRepository<CompanyJobSkillPoco>(false);
            _companyJobSkill = new CompanyJobSkillLogic(JobSkillrepo);

            //CompanyLocationRepository Locationrepo = new CompanyLocationRepository();
            EFGenericRepository<CompanyLocationPoco> Locationrepo = new EFGenericRepository<CompanyLocationPoco>(false);
            _companyLocation = new CompanyLocationLogic(Locationrepo);

            //CompanyProfileRepository Profilerepo = new CompanyProfileRepository();
            EFGenericRepository<CompanyProfilePoco> Profilerepo = new EFGenericRepository<CompanyProfilePoco>(false);
            _companyProfile = new CompanyProfileLogic(Profilerepo);


        }
        public void AddCompanyDescription(CompanyDescriptionPoco[] item)
        {
            _companyDescription.Add(item);
        }

        public void AddCompanyJob(CompanyJobPoco[] item)
        {
            _companyJob.Add(item);
        }

        public void AddCompanyJobDescription(CompanyJobDescriptionPoco[] item)
        {
            _companyJobDescription.Add(item);
        }

        public void AddCompanyJobEducation(CompanyJobEducationPoco[] item)
        {
            _companyJobEducation.Add(item);
        }

        public void AddCompanyJobSkill(CompanyJobSkillPoco[] item)
        {
            _companyJobSkill.Add(item);
        }

        public void AddCompanyLocation(CompanyLocationPoco[] item)
        {
            _companyLocation.Add(item);
        }

        public void AddCompanyProfile(CompanyProfilePoco[] item)
        {
            _companyProfile.Add(item);
        }

        public List<CompanyDescriptionPoco> GetAllCompanyDescription()
        {
            return _companyDescription.GetAll();
        }

        public List<CompanyJobPoco> GetAllCompanyJob()
        {
            return _companyJob.GetAll();
        }

        public List<CompanyJobDescriptionPoco> GetAllCompanyJobDescription()
        {
            return _companyJobDescription.GetAll();
        }

        public List<CompanyJobEducationPoco> GetAllCompanyJobEducation()
        {
            return _companyJobEducation.GetAll();
        }

        public List<CompanyJobSkillPoco> GetAllCompanyJobSkill()
        {
            return _companyJobSkill.GetAll();
        }

        public List<CompanyLocationPoco> GetAllCompanyLocation()
        {
            return _companyLocation.GetAll();
        }

        public List<CompanyProfilePoco> GetAllCompanyProfile()
        {
            return _companyProfile.GetAll();
        }

        public CompanyDescriptionPoco GetSingleCompanyDescription(string Id)
        {
            return _companyDescription.Get(Guid.Parse(Id));
        }

        public CompanyJobPoco GetSingleCompanyJob(string Id)
        {
            return _companyJob.Get(Guid.Parse(Id));
        }

        public CompanyJobDescriptionPoco GetSingleCompanyJobDescription(string Id)
        {
            return _companyJobDescription.Get(Guid.Parse(Id));
        }

        public CompanyJobEducationPoco GetSingleCompanyJobEducation(string Id)
        {
            return _companyJobEducation.Get(Guid.Parse(Id));
        }

        public CompanyJobSkillPoco GetSingleCompanyJobSkill(string Id)
        {
            return _companyJobSkill.Get(Guid.Parse(Id));
        }

        public CompanyLocationPoco GetSingleCompanyLocation(string Id)
        {
            return _companyLocation.Get(Guid.Parse(Id));
        }

        public CompanyProfilePoco GetSingleCompanyProfile(string Id)
        {
            return _companyProfile.Get(Guid.Parse(Id));
        }

        public void RemoveCompanyDescription(CompanyDescriptionPoco[] item)
        {
            _companyDescription.Delete(item);
        }

        public void RemoveCompanyJob(CompanyJobPoco[] item)
        {
            _companyJob.Delete(item);
        }

        public void RemoveCompanyJobDescription(CompanyJobDescriptionPoco[] item)
        {
            _companyJobDescription.Delete(item);
        }

        public void RemoveCompanyJobEducation(CompanyJobEducationPoco[] item)
        {
            _companyJobEducation.Delete(item);
        }

        public void RemoveCompanyLocation(CompanyLocationPoco[] item)
        {
            _companyLocation.Delete(item);
        }

        public void RemoveCompanyProfile(CompanyProfilePoco[] item)
        {
            _companyProfile.Delete(item);
        }

        public void RemoveCompanyJobSkill(CompanyJobSkillPoco[] item)
        {
            _companyJobSkill.Delete(item);
        }

        public void UpdateCompanyDescription(CompanyDescriptionPoco[] item)
        {
            _companyDescription.Update(item);
        }

        public void UpdateCompanyJob(CompanyJobPoco[] item)
        {
            _companyJob.Update(item);
        }

        public void UpdateCompanyJobDescription(CompanyJobDescriptionPoco[] item)
        {
            _companyJobDescription.Update(item);
        }

        public void UpdateCompanyJobEducation(CompanyJobEducationPoco[] item)
        {
            _companyJobEducation.Update(item);
        }

        public void UpdateCompanyJobSkill(CompanyJobSkillPoco[] item)
        {
            _companyJobSkill.Update(item);
        }

        public void UpdateCompanyLocation(CompanyLocationPoco[] item)
        {
            _companyLocation.Update(item);
        }

        public void UpdateCompanyProfile(CompanyProfilePoco[] item)
        {
            _companyProfile.Update(item);
        }
    }
}
