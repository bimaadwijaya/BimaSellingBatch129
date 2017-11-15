using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selling.ViewModel;

namespace Selling.Repo
{
    interface iSellingRepo<Sellings>
    {
        bool Create(tblOfficerViewModel model);
        void Update();
        void Delete();
        List<Sellings> GetAll();
        Sellings GetById(int Id);
    }
}
