
namespace XAFDemoTwo.Module.Controllers
{
    partial class ClearContactTasksController
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
            this.ClearTaskAction = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // ClearTaskAction
            // 
            this.ClearTaskAction.Caption = "Clear Tasks";
            this.ClearTaskAction.Category = "View";
            this.ClearTaskAction.ConfirmationMessage = "Are you sure you want to clear the Tasks list?";
            this.ClearTaskAction.Id = "ClearTasksAction";
            this.ClearTaskAction.ImageName = "Action_Clear";
            this.ClearTaskAction.ToolTip = null;
            this.ClearTaskAction.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.ClearTaskAction_Execute);
            // 
            // ClearContactTasksController
            // 
            this.Actions.Add(this.ClearTaskAction);
            this.TargetObjectType = typeof(XAFDemoTwo.Module.BusinessObjects.Contact);
            this.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.Activated += new System.EventHandler(this.ClearContactTasksController_Activated);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction ClearTaskAction;
    }
}
