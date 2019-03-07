using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.EntityFrameworkDataAccess
{
    public class CareerCloudContext:DbContext
    {
       
        public CareerCloudContext(bool createProxy = true) : base(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString)
        {
            Database.Log = l => System.Diagnostics.Debug.WriteLine(l);
            //Configuration.ProxyCreationEnabled = false;
            Configuration.ProxyCreationEnabled = createProxy;
        }
        //private void FixEfProviderServicesProblem()
        //{
        //    // The Entity Framework provider type 'System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer'
        //    // for the 'System.Data.SqlClient' ADO.NET provider could not be loaded. 
        //    // Make sure the provider assembly is available to the running application. 
        //    // See http://go.microsoft.com/fwlink/?LinkId=260882 for more information.
        //    var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        //}
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicantProfilePoco>().HasMany(a => a.ApplicantEducation).WithRequired(e => e.ApplicantProfile).
                HasForeignKey(e => e.Applicant);
            modelBuilder.Entity<ApplicantProfilePoco>().HasMany(a => a.ApplicantJobApplication).WithRequired(e => e.ApplicantProfile).
                HasForeignKey(e => e.Applicant);
            modelBuilder.Entity<ApplicantProfilePoco>().HasMany(a => a.ApplicantResume).
                WithRequired(e => e.ApplicantProfile).HasForeignKey(e => e.Applicant);
            modelBuilder.Entity<ApplicantProfilePoco>().HasMany(a => a.ApplicantSkill).
                WithRequired(e => e.ApplicantProfile).HasForeignKey(e => e.Applicant);
            modelBuilder.Entity<ApplicantProfilePoco>().HasMany(a => a.ApplicantWorkHistory).WithRequired(e => e.ApplicantProfile).
                HasForeignKey(e => e.Applicant);


            modelBuilder.Entity<CompanyJobPoco>().HasMany(c => c.ApplicantJobApplication).
                WithRequired(a => a.CompanyJob).HasForeignKey(a => a.Job);
            modelBuilder.Entity<CompanyJobPoco>().HasMany(c => c.CompanyJobDesscription).
                WithRequired(a => a.CompanyJob).HasForeignKey(a => a.Job);
            modelBuilder.Entity<CompanyJobPoco>().HasMany(c => c.CompanyJobEducation).
                WithRequired(a => a.CompanyJob).HasForeignKey(a => a.Job);
            modelBuilder.Entity<CompanyJobPoco>().HasMany(c => c.CompanyJobSkill).
                WithRequired(a => a.CompanyJob).HasForeignKey(a => a.Job);


            modelBuilder.Entity<CompanyProfilePoco>().HasMany(p => p.CompanyDescription).WithRequired(c => c.CompanyProfile).HasForeignKey(c => c.Company);
            modelBuilder.Entity<CompanyProfilePoco>().HasMany(p => p.CompanyJob).WithRequired(c => c.CompanyProfile).HasForeignKey(c => c.Company);
            modelBuilder.Entity<CompanyProfilePoco>().HasMany(p => p.CompanyLocation).WithRequired(c => c.CompanyProfile).HasForeignKey(c => c.Company);

            modelBuilder.Entity<SecurityLoginPoco>().HasMany(s => s.SecurityLoginsLog).WithRequired(a => a.SecurityLogin).HasForeignKey(a => a.Login);
            modelBuilder.Entity<SecurityLoginPoco>().HasMany(s => s.SecurityLoginsRole).WithRequired(a => a.SecurityLogin).HasForeignKey(a => a.Login);
            modelBuilder.Entity<SecurityLoginPoco>().HasMany(s => s.ApplicationProfile).WithRequired(a => a.SecurityLogin).HasForeignKey(a => a.Login);

            modelBuilder.Entity<SecurityRolePoco>().HasMany(s => s.SecurityLoginsRole).WithRequired(a => a.SecurityRole).HasForeignKey(a => a.Role);

            modelBuilder.Entity<SystemCountryCodePoco>().HasMany(s => s.ApplicationProfile).WithRequired(a => a.SystemCountryCode).HasForeignKey(a => a.Country);
            modelBuilder.Entity<SystemCountryCodePoco>().HasMany(s => s.ApplicantWorkHistory).WithRequired(a => a.SystemCountryCode).HasForeignKey(a => a.CountryCode);

            modelBuilder.Entity<SystemLanguageCodePoco>().HasMany(s => s.CompanyDescription).WithRequired(a => a.SystemLanguageCode).HasForeignKey(a => a.LanguageId);

        }
        public DbSet<ApplicantEducationPoco> ApplicantEducations { get; set; }
        public DbSet<ApplicantJobApplicationPoco> ApplicantJobApplications { get; set; }
        public DbSet<ApplicantProfilePoco> ApplicantProfiles { get; set; }
        public DbSet<ApplicantResumePoco> ApplicantResumes { get; set; }
        public DbSet<ApplicantSkillPoco> ApplicantSkills { get; set; }
        public DbSet<ApplicantWorkHistoryPoco> ApplicantWorkHistory { get; set; }
        public DbSet<CompanyDescriptionPoco> CompanyDescriptions { get; set; }
        public DbSet<CompanyJobDescriptionPoco> CompanyJobDescriptions { get; set; }
        public DbSet<CompanyJobEducationPoco> CompanyJobEducations { get; set; }
        public DbSet<CompanyJobPoco> CompanyJobs { get; set; }
        public DbSet<CompanyJobSkillPoco> CompanyJobSkills { get; set; }
        public DbSet<CompanyLocationPoco> CompanyLocations { get; set; }
        public DbSet<CompanyProfilePoco> CompanyProfiles { get; set; }
        public DbSet<SecurityLoginPoco> SecurityLogins { get; set; }
        public DbSet<SecurityLoginsLogPoco> SecurityLoginsLog { get; set; }
        public DbSet<SecurityLoginsRolePoco> SecurityLoginsRoles { get; set; }
        public DbSet<SecurityRolePoco> SecurityRoles { get; set; }
        public DbSet<SystemCountryCodePoco> SystemCountryCodes { get; set; }
        public DbSet<SystemLanguageCodePoco> SystemLanguageCodes { get; set; }
       
    }
}
