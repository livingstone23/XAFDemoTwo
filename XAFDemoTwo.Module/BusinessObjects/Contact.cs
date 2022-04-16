using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace XAFDemoTwo.Module.BusinessObjects
{



    //[DefaultClassOptions]
    ////[ImageName("BO_Contact")]
    ////[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    ////[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    ////[Persistent("DatabaseTableName")]
    //// Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    //public class Contact : BaseObject
    //{ // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
    //    // Use CodeRush to create XPO classes and properties with a few keystrokes.
    //    // https://docs.devexpress.com/CodeRushForRoslyn/118557
    //    public Contact(Session session)
    //        : base(session)
    //    {
    //    }
    //    public override void AfterConstruction()
    //    {
    //        base.AfterConstruction();
    //        // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
    //    }
    //    //private string _PersistentProperty;
    //    //[XafDisplayName("My display name"), ToolTip("My hint message")]
    //    //[ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)]
    //    //[Persistent("DatabaseColumnName"), RuleRequiredField(DefaultContexts.Save)]
    //    //public string PersistentProperty {
    //    //    get { return _PersistentProperty; }
    //    //    set { SetPropertyValue(nameof(PersistentProperty), ref _PersistentProperty, value); }
    //    //}

    //    //[Action(Caption = "My UI Action", ConfirmationMessage = "Are you sure?", ImageName = "Attention", AutoCommit = true)]
    //    //public void ActionMethod() {
    //    //    // Trigger a custom business logic for the current record in the UI (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112619.aspx).
    //    //    this.PersistentProperty = "Paid";
    //    //}
    //}



    [DefaultClassOptions]
    public class Contact : Person
    {

        public Contact(Session session) : base(session) { }

        private string webPageAddress;
        public string WebPageAddress
        {
            get { return webPageAddress; }
            set { SetPropertyValue(nameof(WebPageAddress), ref webPageAddress, value); }
        }

        private string nickName;
        public string NickName
        {
            get { return nickName; }
            set { SetPropertyValue(nameof(NickName), ref nickName, value); }
        }

        private string spouseName;
        public string SpouseName
        {
            get { return spouseName; }
            set { SetPropertyValue(nameof(SpouseName), ref spouseName, value); }
        }

        private TitleOfCourtesy titleOfCourtesy;
        public TitleOfCourtesy TitleOfCourtesy
        {
            get { return titleOfCourtesy; }
            set { SetPropertyValue(nameof(TitleOfCourtesy), ref titleOfCourtesy, value); }
        }

        private DateTime anniversary;
        public DateTime Anniversary
        {
            get { return anniversary; }
            set { SetPropertyValue(nameof(Anniversary), ref anniversary, value); }
        }

        private string notes;
        [Size(4096)]
        public string Notes
        {
            get { return notes; }
            set { SetPropertyValue(nameof(Notes), ref notes, value); }
        }

    }



    public enum TitleOfCourtesy { Dr, Miss, Mr, Mrs, Ms };



}


