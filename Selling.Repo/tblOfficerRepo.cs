using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selling.ViewModel;
using Selling.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Selling.Repo
{
    public class tblOfficerRepo : iSellingRepo<tblOfficerViewModel>
    {
        private DataContext dataContext = new DataContext();
        public bool Create(tblOfficerViewModel model)
        {
            bool result = true;
            tblOfficer modelOfficer = new tblOfficer();
            modelOfficer.tblOfficerId = model.tblOfficerId;
            modelOfficer.OfficerCode = model.OfficerCode;
            modelOfficer.OfficerName = model.OfficerName;
            modelOfficer.OfficerPassword = modelOfficer.OfficerPassword;
            modelOfficer.OfficerStatus = modelOfficer.OfficerStatus;
            return result;
        }
        public void Update()
        {

        }
        public void Delete()
        {

        }
        public tblOfficerViewModel GetById(int Id)
        {
            tblOfficerViewModel result = new tblOfficerViewModel();
            return result;
        }
        public List<tblOfficerViewModel> GetAll()
        {
            List<tblOfficerViewModel> result=new List<tblOfficerViewModel>();
            result = (from officer in dataContext.TblOfficer
                      select new tblOfficerViewModel {
                      tblOfficerId= officer.tblOfficerId,
                      OfficerCode= officer.OfficerCode,
                      OfficerName= officer.OfficerName,
                      OfficerPassword= officer.OfficerPassword,
                      OfficerStatus= officer.OfficerStatus
                      }).ToList();
            return result;
        }

        public bool Create()
        {
            throw new NotImplementedException();
        }
    }
}
