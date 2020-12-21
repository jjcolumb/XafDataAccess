using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Linq;

namespace XafDataAccess.Module.BusinessObjects
{
    [DefaultClassOptions()]
    public class Order : BaseObject
    {
        public Order(Session session) : base(session) { }
        private string fDescription;
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue("Description", ref fDescription, value); }
        }
        string employeeID;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string EmployeeID
        {
            get => employeeID;
            set => SetPropertyValue(nameof(EmployeeID), ref employeeID, value);
        }
        private Product fProduct;
        [ExplicitLoading()]
        [Association("Product-Orders")]
        public Product Product
        {
            get { return fProduct; }
            set
            {
                Product oldProduct = fProduct;
                bool modified = SetPropertyValue("Product", ref fProduct, value);
               
            }
        }
    }
}