using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.JavaScript;

namespace ERPWebAPI.Controllers
{
    public class POController : Controller
    {
        // GET: POController
        public ActionResult Index()
        {
            return View();
        }

        // GET: POController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: POController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: POController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: POController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: POController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: POController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: POController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public string POCreate([FromBody]POForm form)
        {
            try 
            {
                if (string.IsNullOrEmpty(form.po_id))
                {
                    throw new Exception("查無該單據資料");
                }
                //Do Something
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            return string.Format(@"取得ID：{0},現在傳入的是：{1},表單內容為：{2},即將對電子表單DB進行操作並產生表單。",form.po_id,form.po_name,form.po_content);
        }
    }
    public class POForm
    {
        public string? po_id {  get; set; }
        public string? po_name { get; set;}
        public string? po_content { get; set;}
    }
}
