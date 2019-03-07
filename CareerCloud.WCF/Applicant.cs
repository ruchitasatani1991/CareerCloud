using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CareerCloud.ADODataAccessLayer;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;

namespace CareerCloud.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Applicant : IApplicant
    {
        private ApplicantEducationLogic _logic;
        private ApplicantJobApplicationLogic _applicantJobApplicationLogic;
        private ApplicantProfileLogic _applicantProfileLogic;
        private ApplicantResumeLogic _applicantResumeLogic;
        private ApplicantSkillLogic _applicantSkillLogic;
        private ApplicantWorkHistoryLogic _applicantWorkHistoryLogic;
        public Applicant()
        {
           // ApplicantEducationRepository repo = new ApplicantEducationRepository();
            EFGenericRepository<ApplicantEducationPoco> repo = new EFGenericRepository<ApplicantEducationPoco>(false);
            _logic = new ApplicantEducationLogic(repo);

            //ApplicantJobApplicationRepository Apprepo = new ApplicantJobApplicationRepository();
            EFGenericRepository<ApplicantJobApplicationPoco> Apprepo = new EFGenericRepository<ApplicantJobApplicationPoco>(false);
            _applicantJobApplicationLogic = new ApplicantJobApplicationLogic(Apprepo);

            //ApplicantProfileRepository Profilerepo = new ApplicantProfileRepository();
            EFGenericRepository<ApplicantProfilePoco> Profilerepo = new EFGenericRepository<ApplicantProfilePoco>(false);
            _applicantProfileLogic = new ApplicantProfileLogic(Profilerepo);

            //ApplicantResumeRepository Resumerepo = new ApplicantResumeRepository();
            EFGenericRepository<ApplicantResumePoco> Resumerepo = new EFGenericRepository<ApplicantResumePoco>(false);
            _applicantResumeLogic = new ApplicantResumeLogic(Resumerepo);

            //ApplicantSkillRepository Skillrepo = new ApplicantSkillRepository();
            EFGenericRepository<ApplicantSkillPoco> Skillrepo = new EFGenericRepository<ApplicantSkillPoco>(false);
            _applicantSkillLogic = new ApplicantSkillLogic(Skillrepo);

            //ApplicantWorkHistoryRepository Workrepo = new ApplicantWorkHistoryRepository();
            EFGenericRepository<ApplicantWorkHistoryPoco> Workrepo = new EFGenericRepository<ApplicantWorkHistoryPoco>(false);
            _applicantWorkHistoryLogic = new ApplicantWorkHistoryLogic(Workrepo);



        }
        public void AddApplicantEducation(ApplicantEducationPoco[] item)
        {
            _logic.Add(item);
        }

        public void AddApplicantJobApplication(ApplicantJobApplicationPoco[] item)
        {
            _applicantJobApplicationLogic.Add(item);
        }

        public void AddApplicantProfile(ApplicantProfilePoco[] item)
        {
            _applicantProfileLogic.Add(item);
        }

        public void AddApplicantResume(ApplicantResumePoco[] item)
        {
            _applicantResumeLogic.Add(item);
        }

        public void AddApplicantSkill(ApplicantSkillPoco[] item)
        {
            _applicantSkillLogic.Add(item);
        }

        public void AddApplicantWorkHistory(ApplicantWorkHistoryPoco[] item)
        {
            _applicantWorkHistoryLogic.Add(item);
        }

        public List<ApplicantEducationPoco> GetAllApplicantEducation()
        {
            return _logic.GetAll();
        }

        public List<ApplicantJobApplicationPoco> GetAllApplicantJobApplication()
        {
            return _applicantJobApplicationLogic.GetAll();
        }

        public List<ApplicantProfilePoco> GetAllApplicantProfile()
        {
            return _applicantProfileLogic.GetAll();
        }

        public List<ApplicantResumePoco> GetAllApplicantResume()
        {
            return _applicantResumeLogic.GetAll();
        }

        public List<ApplicantSkillPoco> GetAllApplicantSkill()
        {
            return _applicantSkillLogic.GetAll();
        }

        public List<ApplicantWorkHistoryPoco> GetAllApplicantWorkHistory()
        {
            return _applicantWorkHistoryLogic.GetAll();
        }

        public ApplicantEducationPoco GetSingleApplicantEducation(string Id)
        {
            return _logic.Get(Guid.Parse(Id));
        }

        public ApplicantJobApplicationPoco GetSingleApplicantJobApplication(string Id)
        {
            return _applicantJobApplicationLogic.Get(Guid.Parse(Id));
        }

        public ApplicantProfilePoco GetSingleApplicantProfile(string Id)
        {
            return _applicantProfileLogic.Get(Guid.Parse(Id));
        }

        public ApplicantResumePoco GetSingleApplicantResume(string Id)
        {
            return _applicantResumeLogic.Get(Guid.Parse(Id));
        }

        public ApplicantSkillPoco GetSingleApplicantSkill(string Id)
        {
            return _applicantSkillLogic.Get(Guid.Parse(Id));
        }

        public ApplicantWorkHistoryPoco GetSingleApplicantWorkHistory(string Id)
        {
            return _applicantWorkHistoryLogic.Get(Guid.Parse(Id));
        }

        public void RemoveApplicantEducation(ApplicantEducationPoco[] item)
        {
            _logic.Delete(item);
        }

        public void RemoveApplicantJobApplication(ApplicantJobApplicationPoco[] item)
        {
            _applicantJobApplicationLogic.Delete(item);
        }

        public void RemoveApplicantProfile(ApplicantProfilePoco[] item)
        {
            _applicantProfileLogic.Delete(item);
        }

        public void RemoveApplicantResume(ApplicantResumePoco[] item)
        {
            _applicantResumeLogic.Delete(item);
        }

        public void RemoveApplicantSkill(ApplicantSkillPoco[] item)
        {
            _applicantSkillLogic.Delete(item);
        }

        public void RemoveApplicantWorkHistory(ApplicantWorkHistoryPoco[] item)
        {
            _applicantWorkHistoryLogic.Delete(item);
        }

        public void UpdateApplicantEducation(ApplicantEducationPoco[] item)
        {
            _logic.Update(item);
        }

        public void UpdateApplicantJobApplication(ApplicantJobApplicationPoco[] item)
        {
            _applicantJobApplicationLogic.Update(item);
        }

        public void UpdateApplicantProfile(ApplicantProfilePoco[] item)
        {
            _applicantProfileLogic.Update(item);
        }

        public void UpdateApplicantResume(ApplicantResumePoco[] item)
        {
            _applicantResumeLogic.Update(item);
        }

        public void UpdateApplicantSkill(ApplicantSkillPoco[] item)
        {
            _applicantSkillLogic.Update(item);
        }

        public void UpdateApplicantWorkHistory(ApplicantWorkHistoryPoco[] item)
        {
            _applicantWorkHistoryLogic.Update(item);
        }
    }
}
