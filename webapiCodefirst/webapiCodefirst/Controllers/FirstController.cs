using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapiCodefirst.DAL;
using webapiCodefirst.Models;
using webapiCodefirst.ViewMoles;

namespace webapiCodefirst.Controllers
{
    public class FirstController : ApiController
    {
        
        private AccountContext db = new AccountContext();
        private UnitOfWork unitOfWork = new UnitOfWork();
        [HttpGet]
        [ActionName("GetUsers")]
        public List<SysUser> GetUser()
        {
            var sysUsers = (unitOfWork.SysUserRepository.Get()).ToList();
            return sysUsers;
        }
        [ActionName("GetRoles")]
        public List<SysRole> GetRoles()
        {
            var sysRoles = (unitOfWork.SysRoleRepository.Get()).ToList();
            return sysRoles;
        }

    }
}
