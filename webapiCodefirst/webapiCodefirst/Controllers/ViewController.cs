using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapiCodefirst.DAL;
using webapiCodefirst.ViewMoles;

namespace webapiCodefirst.Controllers
{
    public class ViewController : ApiController
    {
        
        private AccountContext db = new AccountContext();
        private UnitOfWork unitOfWork = new UnitOfWork();
        [HttpGet]
        [ActionName("GetViewModels")]
        public List<ViewModel> GetViewModels()
        {

            var viewModel = (from u in unitOfWork.SysUserRepository.Get()
                             join ur in unitOfWork.SysUserRoleRepository.Get() on u.ID equals ur.SysUserID
                             join r in unitOfWork.SysRoleRepository.Get() on ur.SysRoleID equals r.ID

                             select new ViewModel{ ViewUserAccount = u.UserAccount, ViewRoleName = r.RoleName, ViewRoleDec = r.RoleDec }).ToList();
                                  

            return viewModel;
        }
    }
}
