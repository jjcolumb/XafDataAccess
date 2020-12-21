namespace XafDataAccess.Module.Controllers
{
    partial class DataAccessInCodeController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CreateColletion = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.CreateXafDataView = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.CreateXpoView = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.CreateXpoQuery = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.XafGetObjectQuery = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.WithPrefetch = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.WithoutPrefetch = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.FreeJoinLinq = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.FreeJoinCriteria = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.FreeJoinCompositeCriteria = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // CreateColletion
            // 
            this.CreateColletion.Caption = "Create Collection";
            this.CreateColletion.ConfirmationMessage = null;
            this.CreateColletion.Id = "4e124cfa-dfdb-48f9-ac85-28406c989df8";
            this.CreateColletion.ToolTip = null;
            this.CreateColletion.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.CreateColletion_Execute);
            // 
            // CreateXafDataView
            // 
            this.CreateXafDataView.Caption = "Create XafDataView";
            this.CreateXafDataView.ConfirmationMessage = null;
            this.CreateXafDataView.Id = "c61b6efb-3162-4a7a-8e5a-2bed49bdbbc7";
            this.CreateXafDataView.ToolTip = null;
            this.CreateXafDataView.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.CreateXafDataView_Execute);
            // 
            // CreateXpoView
            // 
            this.CreateXpoView.Caption = "Create XPO View";
            this.CreateXpoView.ConfirmationMessage = null;
            this.CreateXpoView.Id = "da504497-86ab-4087-bc54-aa9122e40819";
            this.CreateXpoView.ToolTip = null;
            this.CreateXpoView.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.CreateXpoView_Execute);
            // 
            // CreateXpoQuery
            // 
            this.CreateXpoQuery.Caption = "Create Xpo Query";
            this.CreateXpoQuery.ConfirmationMessage = null;
            this.CreateXpoQuery.Id = "67b27bc9-243f-4316-9d6c-48040cd23747";
            this.CreateXpoQuery.ToolTip = null;
            this.CreateXpoQuery.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.CreateXpoQuery_Execute);
            // 
            // XafGetObjectQuery
            // 
            this.XafGetObjectQuery.Caption = "XAF get objects query";
            this.XafGetObjectQuery.ConfirmationMessage = null;
            this.XafGetObjectQuery.Id = "cd5e3ad8-c546-4b38-a875-cab939311a89";
            this.XafGetObjectQuery.ToolTip = null;
            this.XafGetObjectQuery.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.XafGetObjectQuery_Execute);
            // 
            // WithPrefetch
            // 
            this.WithPrefetch.Caption = "With Prefetch";
            this.WithPrefetch.ConfirmationMessage = null;
            this.WithPrefetch.Id = "f25d38dc-782f-42b9-82a1-c2405c37f1f1";
            this.WithPrefetch.ToolTip = null;
            this.WithPrefetch.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.WithPrefetch_Execute);
            // 
            // WithoutPrefetch
            // 
            this.WithoutPrefetch.Caption = "Without Prefetch";
            this.WithoutPrefetch.ConfirmationMessage = null;
            this.WithoutPrefetch.Id = "b03e6761-31cf-4cd3-9fef-91811df08c00";
            this.WithoutPrefetch.ToolTip = null;
            this.WithoutPrefetch.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.WithoutPrefetch_Execute);
            // 
            // FreeJoinLinq
            // 
            this.FreeJoinLinq.Caption = "Free Join Linq";
            this.FreeJoinLinq.ConfirmationMessage = null;
            this.FreeJoinLinq.Id = "e5ec5550-2a51-4cdb-bb15-1346ae32e0ce";
            this.FreeJoinLinq.ToolTip = null;
            this.FreeJoinLinq.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.FreeJoinLinq_Execute);
            // 
            // FreeJoinCriteria
            // 
            this.FreeJoinCriteria.Caption = "Free Join Criteria";
            this.FreeJoinCriteria.ConfirmationMessage = null;
            this.FreeJoinCriteria.Id = "46715c4f-eb59-4a9f-99ab-ee6cf474045c";
            this.FreeJoinCriteria.ToolTip = null;
            this.FreeJoinCriteria.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.FreeJoinCriteria_Execute);
            // 
            // FreeJoinCompositeCriteria
            // 
            this.FreeJoinCompositeCriteria.Caption = "Free Join Composite Criteria";
            this.FreeJoinCompositeCriteria.ConfirmationMessage = null;
            this.FreeJoinCompositeCriteria.Id = "00c075a7-7d0d-4c5f-abe6-8749fab73f81";
            this.FreeJoinCompositeCriteria.ToolTip = null;
            this.FreeJoinCompositeCriteria.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.FreeJoinCompositeCriteria_Execute);
            // 
            // DataAccessInCodeController
            // 
            this.Actions.Add(this.CreateColletion);
            this.Actions.Add(this.CreateXafDataView);
            this.Actions.Add(this.CreateXpoView);
            this.Actions.Add(this.CreateXpoQuery);
            this.Actions.Add(this.XafGetObjectQuery);
            this.Actions.Add(this.WithPrefetch);
            this.Actions.Add(this.WithoutPrefetch);
            this.Actions.Add(this.FreeJoinLinq);
            this.Actions.Add(this.FreeJoinCriteria);
            this.Actions.Add(this.FreeJoinCompositeCriteria);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction CreateColletion;
        private DevExpress.ExpressApp.Actions.SimpleAction CreateXafDataView;
        private DevExpress.ExpressApp.Actions.SimpleAction CreateXpoView;
        private DevExpress.ExpressApp.Actions.SimpleAction CreateXpoQuery;
        private DevExpress.ExpressApp.Actions.SimpleAction XafGetObjectQuery;
        private DevExpress.ExpressApp.Actions.SimpleAction WithPrefetch;
        private DevExpress.ExpressApp.Actions.SimpleAction WithoutPrefetch;
        private DevExpress.ExpressApp.Actions.SimpleAction FreeJoinLinq;
        private DevExpress.ExpressApp.Actions.SimpleAction FreeJoinCriteria;
        private DevExpress.ExpressApp.Actions.SimpleAction FreeJoinCompositeCriteria;
    }
}
