using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using XafDataAccess.Module.BusinessObjects;
using XafDataAccess.Module.BusinessObjects.Joins;

namespace XafDataAccess.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class DataAccessInCodeController : ViewController
    {
        public DataAccessInCodeController()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }

        private void CreateXafDataView_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            IList dataView = this.View.ObjectSpace.CreateDataView(typeof(Product), "Oid;Name;Orders.Count()", null, null);
            foreach (XpoDataViewRecord item in dataView)
            {
                Console.WriteLine($"{item[1]}-{item[2]}");
            }
        }

        private void CreateColletion_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var Collection = this.View.ObjectSpace.CreateCollection(typeof(Product),null);
            foreach (Product item in Collection)
            {
                Console.WriteLine(item.Name);
            }
        }

        private void CreateXpoView_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            Session session = (this.Application.CreateObjectSpace() as XPObjectSpace).Session;
            XPView ProductXpView = new XPView(session, typeof(Product));

            ProductXpView.Properties.AddRange(new ViewProperty[] { new ViewProperty("Product Name", SortDirection.None, "[Name]", true, true)});
            foreach (ViewRecord viewRecord in ProductXpView)
            {
                Console.WriteLine(viewRecord["Product Name"]);
            }

        }

        private void XafGetObjectQuery_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var Collection = this.View.ObjectSpace.GetObjectsQuery<Product>().Where(p => p.Oid != null);
            foreach (var item in Collection)
            {
                Console.WriteLine(item.Name);
            }
        }

        private void CreateXpoQuery_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            XPQuery<Product> ProductsQuery = new XPQuery<Product>((this.View.ObjectSpace as XPObjectSpace).Session);


            var list = from p in ProductsQuery
                       where (p.Name=="chai")
                      
                       select new { p.Name };


            foreach (var item in list)
            {
                Console.WriteLine(item.Name);
            }
        }

        private void WithPrefetch_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            Session session = (this.Application.CreateObjectSpace() as XPObjectSpace).Session;
            XPCollection<Person> people = new XPCollection<Person>(session);
            XPCollection<PhoneNumber> phoneNumbers = new XPCollection<PhoneNumber>(session);
            XPMemberInfo phoneNumbersInfo = session.GetClassInfo(typeof(Person)).GetMember(nameof(Person.PhoneNumbers));
            session.PreFetch(people, phoneNumbersInfo, phoneNumbers);
        }

        private void WithoutPrefetch_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            Session session = (this.Application.CreateObjectSpace() as XPObjectSpace).Session;
            XPCollection<Person> people = new XPCollection<Person>(session);
            foreach (Person person in people)
            {
                Console.WriteLine(person.FullName);
                foreach (PhoneNumber phoneNumber in person.PhoneNumbers)
                {
                    Console.WriteLine(phoneNumber.Number);
                }
            }

        }

        private void FreeJoinLinq_Execute(object sender, SimpleActionExecuteEventArgs args)
        {
            Session session = (this.Application.CreateObjectSpace() as XPObjectSpace).Session;
            XPQuery<Employee> employees = new XPQuery<Employee>(session);
            XPQuery<Order> orders = new XPQuery<Order>(session);
            var list = from e in employees
                       join o in orders on e.EmployeeID equals o.EmployeeID into query
                       where query.Count() > 5 
                       select e;
        }

        private void FreeJoinCriteria_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            Session session = (this.Application.CreateObjectSpace() as XPObjectSpace).Session;
            CriteriaOperator criteria =
            CriteriaOperator.Parse("[<Orders>][^.EmployeeID = EmployeeID].Count() > 5");
                    XPCollection<Employee> employees = new XPCollection<Employee>(session, criteria);
        }

        private void FreeJoinCompositeCriteria_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            Session session = (this.Application.CreateObjectSpace() as XPObjectSpace).Session;
            CriteriaOperator joinCriteria =
                new OperandProperty("^.EmployeeID") == new OperandProperty("EmployeeID");
                        JoinOperand joinOperand =
                            new JoinOperand("Orders", joinCriteria, Aggregate.Count, new OperandProperty("EmployeeID"));
                        BinaryOperator criteria =
                            new BinaryOperator(joinOperand, new OperandValue(50), BinaryOperatorType.Greater);
                        XPCollection<Employee> employees =
                            new XPCollection<Employee>(session, criteria);
        }
    }
}
