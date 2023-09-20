using BusinessLayer.Asbtract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        //---------------Constructor metoduyla atama yaptığım field üzerinden ilgili interface lerdeki metaodalra erişim sağladık
        //Diğer ınterfaceden ınject ediyoruz------------------
        // Constructor method :Bir sınıftab tanımlanan metodun sınıfın ismiyle ayı şekilde tanımlanması olarak geçiyor.
        
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }
        //--------------- --------------------------------------------------------
        public void TAdd(About t)
        {
            _aboutDal.Insert(t);

        }

        public void TDelete(About t)
        {
            _aboutDal.Delete(t);
        }

        public void TUpdate(About t)
        {
            _aboutDal.Update(t);
        }

        public List<About> TGetList()
        {
          return   _aboutDal.GetList();
        }

        public About TGetByID(int id)
        {
            throw new NotImplementedException();
        //#Buraası sonra doldurulacak
        }
    }
}
