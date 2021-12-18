using KutuphaneProg.Data.Model;
using KutuphaneProg.Data.UnitOfWork;
using System.Linq;
using System.Web.Mvc;

namespace KutuphaneProg.Controllers
{
    public class KategoriController : Controller
    {
        UnitOfWork unitOfWork;

        public KategoriController()
        {
            unitOfWork = new UnitOfWork();
        }
        // GET: Kategori
        public ActionResult Index()
        {
            var kategoriler = unitOfWork.GetRepository<Kategori>().GetAll();
      
            return View(kategoriler);
        }

        [HttpPost]
        public JsonResult EkleJson(string ktgAd)
        {
            Kategori ktgri = new Kategori();
            ktgri.Ad = ktgAd;
            var eklenenKtg = unitOfWork.GetRepository<Kategori>().Add(ktgri);
            unitOfWork.SaveChanges();
            return Json(
                new
                {
                    Result = new
                    {
                        eklenenKtg.Id,
                        eklenenKtg.Ad
                    },JsonRequestBehavior.AllowGet
                }
                );
        }
    }
}