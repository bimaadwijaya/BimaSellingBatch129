using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selling.Model;
using Selling.ViewModel;

namespace Selling.Repo
{
    public class tblSellingRepo : iSellingRepo<Selling.ViewModel.tblSellingViewModel>
    {
        private DataContext dataContext = new DataContext();
        public bool Create(tblOfficerViewModel model)
        {
            bool result = true;
            return result;
        }
        public void Update()
        {

        }
        public void Delete()
        {

        }

        public List<tblSellingViewModel> GetAll()
        {
            List<tblSellingViewModel> result = new List<tblSellingViewModel>();
            result = (from Selling in dataContext.TblSelling
                      select new tblSellingViewModel
                      {
                          tblSellingID = Selling.tblSellingID,
                          InvoiceDate = Selling.InvoiceDate,
                          Invoice = Selling.Invoice,
                          Item = Selling.Item,
                          OfficerCode = Selling.OfficerCode,
                          Paid = Selling.Paid,
                          Return = Selling.Return,
                          Total = Selling.Total
                      }).ToList();
            return result;
        }

        public Selling.ViewModel.tblSellingViewModel GetById(int Id)
        {
            Selling.ViewModel.tblSellingViewModel result = new tblSellingViewModel();
            return result;
        }

    }
}
