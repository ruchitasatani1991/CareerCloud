using CareerCloud.BusinessLogicLayer;
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
    [RoutePrefix("api/careercloud/system/v1")]
    public class SystemCountryCodeController : ApiController
    {
        private SystemCountryCodeLogic _logic;

        public SystemCountryCodeController()
        {
            EFGenericRepository<SystemCountryCodePoco> repo = new EFGenericRepository<SystemCountryCodePoco>(false);
            _logic = new SystemCountryCodeLogic(repo);
        }

        [HttpGet]
        [Route("countrycode/{systemCountryCodeId}")]
        [ResponseType(typeof(SystemCountryCodePoco))]
        public IHttpActionResult GetSystemCountryCode(string systemCountryCodeId)
        {
            try
            {
                SystemCountryCodePoco poco = _logic.Get(systemCountryCodeId);
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
        [Route("countrycode")]
        [ResponseType(typeof(List<SystemCountryCodePoco>))]
        public IHttpActionResult GetAllSystemCountryCode()
        {
            try
            {
                List<SystemCountryCodePoco> pocos = _logic.GetAll();
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
        [Route("countrycode")]
        public IHttpActionResult PostSystemCountryCode([FromBody] SystemCountryCodePoco[] pocos)
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
        [Route("countrycode")]
        public IHttpActionResult PutSystemCountryCode([FromBody] SystemCountryCodePoco[] pocos)
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
        [Route("countrycode")]
        public IHttpActionResult DeleteSystemCountryCode([FromBody] SystemCountryCodePoco[] pocos)
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
