
namespace XAFDemoTwo.Module.Controllers
{
    partial class TaskActionsController
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
            this.SetTaskAction = new DevExpress.ExpressApp.Actions.SingleChoiceAction(this.components);
            // 
            // SetTaskAction
            // 
            this.SetTaskAction.Caption = "Set Task";
            this.SetTaskAction.Category = "Edit";
            this.SetTaskAction.ConfirmationMessage = null;
            this.SetTaskAction.Id = "SetTaskAction";
            this.SetTaskAction.ItemType = DevExpress.ExpressApp.Actions.SingleChoiceActionItemType.ItemIsOperation;
            this.SetTaskAction.ToolTip = null;
            // 
            // TaskActionsController
            // 
            this.Actions.Add(this.SetTaskAction);
            this.TargetObjectType = typeof(XAFDemoTwo.Module.BusinessObjects.DemoTask);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SingleChoiceAction SetTaskAction;
    }
}
