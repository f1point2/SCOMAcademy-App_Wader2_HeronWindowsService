
namespace App_Wader2_HeronWindowsService
{
    partial class AppWader2HeronService
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
            this.eventLogAppWader2HeronService = new System.Diagnostics.EventLog();
            ((System.ComponentModel.ISupportInitialize)(this.eventLogAppWader2HeronService)).BeginInit();
            // 
            // eventLogAppWader2HeronService
            // 
            this.eventLogAppWader2HeronService.Log = "Application";
            this.eventLogAppWader2HeronService.Source = "App Wader 2 Heron Service";
            // 
            // AppWader2HeronService
            // 
            this.AutoLog = false;
            this.CanHandlePowerEvent = true;
            this.CanHandleSessionChangeEvent = true;
            this.CanPauseAndContinue = true;
            this.CanShutdown = true;
            this.ServiceName = "AppWader2HeronService";
            ((System.ComponentModel.ISupportInitialize)(this.eventLogAppWader2HeronService)).EndInit();

        }

        #endregion

        private System.Diagnostics.EventLog eventLogAppWader2HeronService;
    }
}
