using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents
{
    public class WriterNotificationViewComponent : ViewComponent
    {
        readonly NotificationManager nm = new(new EfNotificationRepository());
        public IViewComponentResult Invoke()
        {
            var values = nm.TGetList();
            return View(values);
        }
    }
}
