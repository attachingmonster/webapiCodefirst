using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapiCodefirst.DAL;
using webapiCodefirst.Models;

namespace webapiCodefirst.Controllers
{
    public class FirstController : ApiController
    {
        
        private AccountContext db = new AccountContext();
        private UnitOfWork unitOfWork = new UnitOfWork();
        [HttpGet]
        [ActionName("GetSysRoles")]
        public List<SysRole> Get()
        {
            var sysRoles = (unitOfWork.SysRoleRepository.Get()).ToList();
            return sysRoles;
        }


    }
}
