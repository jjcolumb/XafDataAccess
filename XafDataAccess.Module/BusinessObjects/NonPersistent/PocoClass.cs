using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using System;
using System.Linq;

namespace XafDataAccess.Module.BusinessObjects.NonPersistent
{
    [NavigationItem("Non persistent")]
    [DefaultClassOptions()]
    [DomainComponent]
    public class PocoClass
    {

        public PocoClass()
        {

        }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
