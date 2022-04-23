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


        //private Department department;
        //public Department Department
        //{
        //    get { return department; }
        //    set { SetPropertyValue(nameof(Department), ref department, value); }
        //}
        private Position position;
        public Position Position
        {
            get { return position; }
            set { SetPropertyValue(nameof(Position), ref position, value); }
        }


        //...Set a Many-to-Many Relationship (XPO)
        [Association("Contact-DemoTask")]
        public XPCollection<DemoTask> Tasks
        {
            get
            {
                return GetCollection<DemoTask>(nameof(Tasks));
            }
        }


        //...Set a One-to-Many Relationship (XPO)
        //private Department department;
        //[Association("Department-Contacts")]
        //public Department Department
        //{
        //    get { return department; }
        //    set { SetPropertyValue(nameof(Department), ref department, value); }
        //}


        //Filter Lookup Editor Data Source
        private Department department;
        [Association("Department-Contacts", typeof(Department)), ImmediatePostData]
        public Department Department
        {
            get { return department; }
            set
            {
                SetPropertyValue(nameof(Department), ref department, value);
                if (!IsLoading)
                {
                    Position = null;
                    if (Manager != null && Manager.Department != value)
                    {
                        Manager = null;
                    }
                }
            }
        }


        //Implement Dependent Reference Properties (XPO)
        //private Contact manager;
        //[DataSourceProperty("Department.Contacts")]
        //public Contact Manager
        //{
        //    get { return manager; }
        //    set { SetPropertyValue(nameof(Manager), ref manager, value); }
        //}

        //Implement Dependent Reference Properties (XPO)
        //private Contact manager;
        //[DataSourceProperty("Department.Contacts")]
        //[DataSourceCriteria("Position.Title = 'Manager' AND Oid != '@This.Oid'")]
        //public Contact Manager
        //{
        //    get { return manager; }
        //    set { SetPropertyValue(nameof(Manager), ref manager, value); }
        //}


        //Implement Dependent Reference Properties (XPO)
        private Contact manager;
        [DataSourceProperty("Department.Contacts", DataSourcePropertyIsNullMode.SelectAll)]
        [DataSourceCriteria("Position.Title = 'Manager' AND Oid != '@This.Oid'")]
        public Contact Manager
        {
            get { return manager; }
            set { SetPropertyValue(nameof(Manager), ref manager, value); }
        }



    }



    public enum TitleOfCourtesy { Dr, Miss, Mr, Mrs, Ms };



    [DefaultClassOptions]
    [System.ComponentModel.DefaultProperty(nameof(Title))]
    public class Department : BaseObject
    {
        public Department(Session session) : base(session) { }
        private string title;
        public string Title
        {
            get { return title; }
            set { SetPropertyValue(nameof(Title), ref title, value); }
        }
        private string office;
        public string Office
        {
            get { return office; }
            set { SetPropertyValue(nameof(Office), ref office, value); }
        }


        //Set a One-to-Many Relationship (XPO)
        [Association("Department-Contacts")]
        public XPCollection<Contact> Contacts
        {
            get
            {
                return GetCollection<Contact>(nameof(Contacts));
            }
        }


        //Filter Lookup Editor Data Source
        [Association("Departments-Positions")]
        public XPCollection<Position> Positions
        {
            get { return GetCollection<Position>(nameof(Positions)); }
        }

    }



    [DefaultClassOptions]
    [System.ComponentModel.DefaultProperty(nameof(Title))]
    public class Position : BaseObject
    {
        //public Position(Session session) : base(session) { }
        //private string title;
        //public string Title
        //{
        //    get { return title; }
        //    set { SetPropertyValue(nameof(Title), ref title, value); }
        //}



        public Position(Session session) : base(session) { }
        private string title;
        //Implement Property Value Validation in Code (XPO)
        [RuleRequiredField(DefaultContexts.Save)]
        public string Title
        {
            get { return title; }
            set { SetPropertyValue(nameof(Title), ref title, value); }
        }



        //Filter Lookup Editor Data Source
        [Association("Departments-Positions")]
        public XPCollection<Department> Departments
        {
            get { return GetCollection<Department>(nameof(Departments)); }
        }


    }



    [DefaultClassOptions]
    [ModelDefault("Caption", "Task")]
    public class DemoTask : Task
    {
        //Initialize a Property After Creating an Object (XPO)
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            Priority = Priority.Normal;
        }



        public DemoTask(Session session) : base(session) { }
        [Association("Contact-DemoTask")]
        public XPCollection<Contact> Contacts
        {
            get
            {
                return GetCollection<Contact>(nameof(Contacts));
            }
        }


        // Initialize a Property After Creating an Object (XPO)
        private Priority priority;
        public Priority Priority
        {
            get { return priority; }
            set
            {
                SetPropertyValue(nameof(Priority), ref priority, value);
            }
        }


        //Add a Simple Action using an Attribute -1.1
        [Action(ToolTip = "Postpone the task to the next day")]
        public void Postpone()
        {
            if (DueDate == DateTime.MinValue)
            {
                DueDate = DateTime.Now;
            }
            DueDate = DueDate + TimeSpan.FromDays(1);
        }

    }

    public enum Priority
    {
        Low = 0,
        Normal = 1,
        High = 2
    }



}


