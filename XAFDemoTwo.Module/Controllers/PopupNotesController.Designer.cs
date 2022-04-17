
namespace XAFDemoTwo.Module.Controllers
{
    partial class PopupNotesController
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
            this.ShowNotesAction = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
            // 
            // ShowNotesAction
            // 
            this.ShowNotesAction.AcceptButtonCaption = null;
            this.ShowNotesAction.CancelButtonCaption = null;
            this.ShowNotesAction.Caption = "Show Notes";
            this.ShowNotesAction.Category = "Edit";
            this.ShowNotesAction.ConfirmationMessage = null;
            this.ShowNotesAction.Id = "ShowNotesAction";
            this.ShowNotesAction.ToolTip = null;
            this.ShowNotesAction.CustomizePopupWindowParams += new DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(this.ShowNotesAction_CustomizePopupWindowParams);
            this.ShowNotesAction.Execute += new DevExpress.ExpressApp.Actions.PopupWindowShowActionExecuteEventHandler(this.ShowNotesAction_Execute);
            // 
            // PopupNotesController
            // 
            this.Actions.Add(this.ShowNotesAction);
            this.TargetObjectType = typeof(XAFDemoTwo.Module.BusinessObjects.DemoTask);
            this.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;

        }

        #endregion

        private DevExpress.ExpressApp.Actions.PopupWindowShowAction ShowNotesAction;
    }
}
