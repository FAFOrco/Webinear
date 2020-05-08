﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace PruebaOneDrive.CheckPoints
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The FolderCheckPoint recording.
    /// </summary>
    [TestModule("380bf142-e477-4b2a-939c-f9a4581f571d", ModuleType.Recording, 1)]
    public partial class FolderCheckPoint : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::PruebaOneDrive.PruebaOneDriveRepository repository.
        /// </summary>
        public static global::PruebaOneDrive.PruebaOneDriveRepository repo = global::PruebaOneDrive.PruebaOneDriveRepository.Instance;

        static FolderCheckPoint instance = new FolderCheckPoint();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FolderCheckPoint()
        {
            P_CHKFOLDER = "NULL";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static FolderCheckPoint Instance
        {
            get { return instance; }
        }

#region Variables

        string _P_CHKFOLDER;

        /// <summary>
        /// Gets or sets the value of variable P_CHKFOLDER.
        /// </summary>
        [TestVariable("b7368723-0dec-408d-82d3-3201fbc90afb")]
        public string P_CHKFOLDER
        {
            get { return _P_CHKFOLDER; }
            set { _P_CHKFOLDER = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            try {
                Report.Log(ReportLevel.Info, "Get Value", "(Optional Action)\r\nGetting attribute 'InnerText' from item 'SignInMicrosoftOneDriver_COF.Copy_of_PruebaWebinear' and assigning its value to variable 'P_CHKFOLDER'.", repo.SignInMicrosoftOneDriver_COF.Copy_of_PruebaWebinearInfo, new RecordItemIndex(0));
                P_CHKFOLDER = repo.SignInMicrosoftOneDriver_COF.Copy_of_PruebaWebinear.Element.GetAttributeValueText("InnerText");
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
            Report.Log(ReportLevel.Info, "User", P_CHKFOLDER, new RecordItemIndex(1));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
