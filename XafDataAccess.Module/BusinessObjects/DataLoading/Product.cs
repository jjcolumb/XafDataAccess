using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace XafDataAccess.Module.BusinessObjects
{
  
    public class Product : BaseObject
    {
        public Product(Session session) : base(session) { }
        string description;
        private string fName;
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue("Name", ref fName, value); }
        }
        
        
        [Size(SizeAttribute.Unlimited)]
        public string Description
        {
            get => description;
            set => SetPropertyValue(nameof(Description), ref description, value);
        }
        //[DevExpress.Xpo.Aggregated()]
        [Association("Product-Orders")]
        public XPCollection<Order> Orders
        {
            get { return GetCollection<Order>("Orders"); }
        }
       
      
    }
}