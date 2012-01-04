using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Raven.Client;

namespace ContactManager.Controllers
{
    public class AbstractController<T> : Controller
    {

        public IDocumentSession Session { get; set; }

        protected override void  OnActionExecuting(ActionExecutingContext filterContext)
        {
            if(filterContext.IsChildAction)
                return;
            this.Session = DataDocumentStore.Instance.OpenSession();
 	        base.OnActionExecuting(filterContext);
        }

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (filterContext.IsChildAction)
                return;
            if (this.Session != null && filterContext.Exception == null)
                this.Session.SaveChanges();
            this.Session.Dispose();
            base.OnActionExecuted(filterContext);
        }

        public void Add(T entity)
        {
            this.Session.Store(entity);
            this.Session.SaveChanges();
        }

        public void Edit(T entity)
        {
            this.Session.Store(entity);
            this.Session.SaveChanges();
        }
    }
}
