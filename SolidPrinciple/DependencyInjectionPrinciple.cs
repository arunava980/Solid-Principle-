using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
    public class BAL
    {
        private readonly IRepositoryLayer DAL;
        public BAL(IRepositoryLayer layer)
        {
            DAL =layer;
        }
        public void Save(Object details)
        {
            DAL.Save(details);

        }

    }
    public interface IRepositoryLayer
    {
        void Save(Object details);
    }
    public class DataAccessLayer: IRepositoryLayer
    {
      public  void Save(Object details)
        {
            //perform save
        }

    }
}
