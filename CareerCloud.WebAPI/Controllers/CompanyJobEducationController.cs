﻿using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace CareerCloud.WebAPI.Controllers
{
    [RoutePrefix("api/careercloud/company/v1")]
    public class CompanyJobEducationController : ApiController
    {
        private CompanyJobEducationLogic _logic;

        public CompanyJobEducationController()
        {
            EFGenericRepository<CompanyJobEducationPoco> repo = new EFGenericRepository<CompanyJobEducationPoco>(false);
            _logic = new CompanyJobEducationLogic(repo);
        }

        [HttpGet]
        [Route("jobeducation/{companyJobEducationId}")]
        [ResponseType(typeof(CompanyJobEducationPoco))]
        public IHttpActionResult GetCompanyJobEducation(Guid companyJobEducationId)
        {
            try
            {
                CompanyJobEducationPoco poco = _logic.Get(companyJobEducationId);
                if (poco == null)
                {
                    return NotFound();
                }
                return Ok(poco);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpGet]
        [Route("jobeducation")]
        [ResponseType(typeof(List<CompanyJobEducationPoco>))]
        public IHttpActionResult GetAllCompanyJobEducation()
        {
            try
            {
                List<CompanyJobEducationPoco> pocos = _logic.GetAll();
                if (pocos == null)
                {
                    return NotFound();
                }
                return Ok(pocos);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpPost]
        [Route("jobeducation")]
        public IHttpActionResult PostCompanyJobEducation([FromBody] CompanyJobEducationPoco[] pocos)
        {
            try
            {
                _logic.Add(pocos);
                return Ok();
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpPut]
        [Route("jobeducation")]
        public IHttpActionResult PutCompanyJobEducation([FromBody] CompanyJobEducationPoco[] pocos)
        {
            try
            {
                _logic.Update(pocos);
                return Ok();
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpDelete]
        [Route("jobeducation")]
        public IHttpActionResult DeleteCompanyJobEducation([FromBody] CompanyJobEducationPoco[] pocos)
        {
            try
            {
                _logic.Delete(pocos);
                return Ok();
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }
    }
}
