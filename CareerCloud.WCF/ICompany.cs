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
    public interface ICompany
    {
        //Company Description
        [OperationContract]
        void AddCompanyDescription(CompanyDescriptionPoco[] item);

        [OperationContract]
        List<CompanyDescriptionPoco> GetAllCompanyDescription();

        [OperationContract]
        CompanyDescriptionPoco GetSingleCompanyDescription(string Id);

        [OperationContract]
        void RemoveCompanyDescription(CompanyDescriptionPoco[] item);

        [OperationContract]
        void UpdateCompanyDescription(CompanyDescriptionPoco[] item);


        //Company JobDescription
        [OperationContract]
        void AddCompanyJobDescription(CompanyJobDescriptionPoco[] item);

        [OperationContract]
        List<CompanyJobDescriptionPoco> GetAllCompanyJobDescription();

        [OperationContract]
        CompanyJobDescriptionPoco GetSingleCompanyJobDescription(string Id);

        [OperationContract]
        void RemoveCompanyJobDescription(CompanyJobDescriptionPoco[] item);

        [OperationContract]
        void UpdateCompanyJobDescription(CompanyJobDescriptionPoco[] item);

        //Company JobEducation
        [OperationContract]
        void AddCompanyJobEducation(CompanyJobEducationPoco[] item);

        [OperationContract]
        List<CompanyJobEducationPoco> GetAllCompanyJobEducation();

        [OperationContract]
        CompanyJobEducationPoco GetSingleCompanyJobEducation(string Id);

        [OperationContract]
        void RemoveCompanyJobEducation(CompanyJobEducationPoco[] item);

        [OperationContract]
        void UpdateCompanyJobEducation(CompanyJobEducationPoco[] item);


        //CompanyJob
        [OperationContract]
        void AddCompanyJob(CompanyJobPoco[] item);

        [OperationContract]
        List<CompanyJobPoco> GetAllCompanyJob();

        [OperationContract]
        CompanyJobPoco GetSingleCompanyJob(string Id);

        [OperationContract]
        void RemoveCompanyJob(CompanyJobPoco[] item);

        [OperationContract]
        void UpdateCompanyJob(CompanyJobPoco[] item);

        //Compnay JobSkill
        [OperationContract]
        void AddCompanyJobSkill(CompanyJobSkillPoco[] item);

        [OperationContract]
        List<CompanyJobSkillPoco> GetAllCompanyJobSkill();

        [OperationContract]
        CompanyJobSkillPoco GetSingleCompanyJobSkill(string Id);

        [OperationContract]
        void RemoveCompanyJobSkill(CompanyJobSkillPoco[] item);

        [OperationContract]
        void UpdateCompanyJobSkill(CompanyJobSkillPoco[] item);


        //Company Location
        [OperationContract]
        void AddCompanyLocation(CompanyLocationPoco[] item);

        [OperationContract]
        List<CompanyLocationPoco> GetAllCompanyLocation();

        [OperationContract]
        CompanyLocationPoco GetSingleCompanyLocation(string Id);

        [OperationContract]
        void RemoveCompanyLocation(CompanyLocationPoco[] item);

        [OperationContract]
        void UpdateCompanyLocation(CompanyLocationPoco[] item);


        //Company Profile
        [OperationContract]
        void AddCompanyProfile(CompanyProfilePoco[] item);

        [OperationContract]
        List<CompanyProfilePoco> GetAllCompanyProfile();

        [OperationContract]
        CompanyProfilePoco GetSingleCompanyProfile(string Id);

        [OperationContract]
        void RemoveCompanyProfile(CompanyProfilePoco[] item);

        [OperationContract]
        void UpdateCompanyProfile(CompanyProfilePoco[] item);


    }
}
