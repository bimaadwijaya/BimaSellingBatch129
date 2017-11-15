using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selling.Model;
using Selling.ViewModel;

namespace Selling.Repo
{
    public class tblItemRepo //: iSellingRepo<Selling.ViewModel.tblItemViewModel>
    {
        private DataContext dataContext = new DataContext();
        public bool Create()
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
        public List<Selling.ViewModel.tblItemViewModel> GetAll()
        {
            List<Selling.ViewModel.tblItemViewModel> result = new List<ViewModel.tblItemViewModel>();
            result = (from item in dataContext.TblItem
                      select new Selling.ViewModel.tblItemViewModel
                      {
                          tblItemId = item.tblItemId,
                          ItemCode = item.ItemCode,
                          ItemName = item.ItemName,
                          BuyingPrice = item.BuyingPrice,
                          SellingPrice = item.SellingPrice,
                          ItemAmount = item.ItemAmount,
                          Pieces = item.Pieces
                      }).ToList();

            return result;
        }
        public Selling.ViewModel.tblItemViewModel GetById(int Id)
        {
            Selling.ViewModel.tblItemViewModel result = new Selling.ViewModel.tblItemViewModel();
            return result;
        }
    }
}
