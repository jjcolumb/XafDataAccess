using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XafDataAccess.Module.BusinessObjects.NonPersistent
{

    [NavigationItem("Non persistent")]
    [DefaultClassOptions()]
    [DomainComponent]
    public class MyNonPersistentObject : NonPersistentBaseObject
    {
        private String name;
        private String description;

        public MyNonPersistentObject()
        {

        }

        public MyNonPersistentObject(Guid oid) : base(oid)
        {

        }

        public override void OnSaving()
        {
            base.OnSaving();
            // ...
        }
        public String Name
        {
            get { return name; }
            set { SetPropertyValue(ref name, value); }
        }
        public String Description
        {
            get { return description; }
            set { SetPropertyValue(ref description, value); }
        }
    }
}
