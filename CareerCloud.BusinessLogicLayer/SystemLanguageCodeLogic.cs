﻿using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.BusinessLogicLayer
{
    public class SystemLanguageCodeLogic
    {
        protected IDataRepository<SystemLanguageCodePoco> _repository;
        public SystemLanguageCodeLogic(IDataRepository<SystemLanguageCodePoco> repository) 
        {
            _repository = repository;

        }
        public SystemLanguageCodePoco Get(string LanguageID)
        {
            return _repository.GetSingle(c => c.LanguageID == LanguageID);
        }

        public List<SystemLanguageCodePoco> GetAll()
        {
            return _repository.GetAll().ToList();
        }
        public void Add(SystemLanguageCodePoco[] pocos)
        {

            Verify(pocos);
            
            _repository.Add(pocos);

        }

        public void Update(SystemLanguageCodePoco[] pocos)
        {
            Verify(pocos);
            _repository.Update(pocos);
        }
        protected void Verify(SystemLanguageCodePoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();


            foreach (var poco in pocos)
            {
                if (string.IsNullOrEmpty(poco.LanguageID))
                {
                    exceptions.Add(new ValidationException(1000, $"LanguageID for SystemLanguageCode {poco.LanguageID} cannot be null"));
                }

                if (string.IsNullOrEmpty(poco.Name))
                {
                    exceptions.Add(new ValidationException(1001, $"Name for SystemLanguageCode {poco.LanguageID} cannot be null"));
                }
                if (string.IsNullOrEmpty(poco.NativeName))
                {
                    exceptions.Add(new ValidationException(1002, $"NativeName for SystemLanguageCode {poco.LanguageID} cannot be null"));
                }
            }

            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }
        }

        public void Delete(SystemLanguageCodePoco[] pocos)
        {
            _repository.Remove(pocos);
        }
    }
}
