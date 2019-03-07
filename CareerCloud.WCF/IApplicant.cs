using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CareerCloud.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IApplicant
    {
        //Applicant Education
        [OperationContract]
        void AddApplicantEducation(ApplicantEducationPoco[] item);

        [OperationContract]
        List<ApplicantEducationPoco> GetAllApplicantEducation();

        [OperationContract]
        ApplicantEducationPoco GetSingleApplicantEducation(string Id);

        [OperationContract]
        void RemoveApplicantEducation(ApplicantEducationPoco[] item);

        [OperationContract]
        void UpdateApplicantEducation(ApplicantEducationPoco[] item);


        //Apllicant JobApplication
        [OperationContract]
        void AddApplicantJobApplication(ApplicantJobApplicationPoco[] item);

        [OperationContract]
        List<ApplicantJobApplicationPoco> GetAllApplicantJobApplication();

        [OperationContract]
        ApplicantJobApplicationPoco GetSingleApplicantJobApplication(string Id);

        [OperationContract]
        void RemoveApplicantJobApplication(ApplicantJobApplicationPoco[] item);

        [OperationContract]
        void UpdateApplicantJobApplication(ApplicantJobApplicationPoco[] item);


        //Applicant Profile
        [OperationContract]
        void AddApplicantProfile(ApplicantProfilePoco[] item);

        [OperationContract]
        List<ApplicantProfilePoco> GetAllApplicantProfile();

        [OperationContract]
        ApplicantProfilePoco GetSingleApplicantProfile(string Id);

        [OperationContract]
        void RemoveApplicantProfile(ApplicantProfilePoco[] item);

        [OperationContract]
        void UpdateApplicantProfile(ApplicantProfilePoco[] item);


        //Applicant Resume
        [OperationContract]
        void AddApplicantResume(ApplicantResumePoco[] item);

        [OperationContract]
        List<ApplicantResumePoco> GetAllApplicantResume();

        [OperationContract]
        ApplicantResumePoco GetSingleApplicantResume(string Id);

        [OperationContract]
        void RemoveApplicantResume(ApplicantResumePoco[] item);

        [OperationContract]
        void UpdateApplicantResume(ApplicantResumePoco[] item);


        //Applicant Skill
        [OperationContract]
        void AddApplicantSkill(ApplicantSkillPoco[] item);

        [OperationContract]
        List<ApplicantSkillPoco> GetAllApplicantSkill();

        [OperationContract]
        ApplicantSkillPoco GetSingleApplicantSkill(string Id);

        [OperationContract]
        void RemoveApplicantSkill(ApplicantSkillPoco[] item);

        [OperationContract]
        void UpdateApplicantSkill(ApplicantSkillPoco[] item);


        //Applicant WorkHistory
        [OperationContract]
        void AddApplicantWorkHistory(ApplicantWorkHistoryPoco[] item);

        [OperationContract]
        List<ApplicantWorkHistoryPoco> GetAllApplicantWorkHistory();

        [OperationContract]
        ApplicantWorkHistoryPoco GetSingleApplicantWorkHistory(string Id);

        [OperationContract]
        void RemoveApplicantWorkHistory(ApplicantWorkHistoryPoco[] item);

        [OperationContract]
        void UpdateApplicantWorkHistory(ApplicantWorkHistoryPoco[] item);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "CareerCloud.WCF.ContractType".
   
}
