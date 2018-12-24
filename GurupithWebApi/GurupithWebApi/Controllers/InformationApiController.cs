using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GurupithWebApi.Entity;
using GurupithWebApi.Models;
using System.Threading.Tasks;

namespace GurupithWebApi.Controllers
{
    public class InformationApiController : ApiController
    {

        GurupithEntities _db = new GurupithEntities();


        #region Search Person Information By Name

        [HttpPost]
        public async Task<ProjectResult> SearchPersonalInfo(personal_information model)
        {
            try
            {
                var result = _db.personal_information.Where(psd => psd.nameofperson==model.nameofperson).ToList(); 

                return new ProjectResult { Message="Success",Status=1,Response=result};

            }
            catch (Exception exp)
            {
                return new ProjectResult { Message=exp.ToString(),Status=0,Response=null};
            }
        }

        #endregion


        #region Select All Person Information

        [HttpGet]
        public async Task<ProjectResult> PersonalInfo()
        {
            try
            {
                var result = _db.personal_information.ToList(); 

                return new ProjectResult { Message = "Success", Status = 1, Response = result };

            }
            catch (Exception exp)
            {
                return new ProjectResult { Message = exp.ToString(), Status = 0, Response = null };
            }
        }

        #endregion

        #region Select All tblReg Information

        [HttpGet]
        public async Task<ProjectResult> RegInfo()
        {
            try
            {
                var result = _db.tblregs.ToList();

                return new ProjectResult { Message = "Success", Status = 1, Response = result };

            }
            catch (Exception exp)
            {
                return new ProjectResult { Message = exp.ToString(), Status = 0, Response = null };
            }
        }


        #endregion


        #region Search Person Information By Name and City

        [HttpPost]
        public async Task<ProjectResult> SearchInfoCityName(personal_information model)
        {
            try
            {
                if(model.city!=null && model.nameofperson!=null)
                {
                    var result = _db.personal_information.Where(psd => psd.city==model.city && psd.nameofperson==model.nameofperson).ToList();

                    return new ProjectResult { Message = "Success", Status = 1, Response = result };


                }else if(model.nameofperson!=null)
                {
                    var result = _db.personal_information.Where(psd => psd.nameofperson == model.nameofperson).ToList();

                    return new ProjectResult { Message = "Success", Status = 1, Response = result };

                }
                else
                {
                    var result = _db.personal_information.Where(psd => psd.city == model.city).ToList();

                    return new ProjectResult { Message = "Success", Status = 1, Response = result };

                }


            }
            catch(Exception exp)
            {
                return new ProjectResult { Message=exp.ToString(),Status=0,Response=null};
            }
        }

        #endregion

    }
}
