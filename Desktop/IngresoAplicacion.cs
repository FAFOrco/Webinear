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

namespace Desktop
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The IngresoAplicacion recording.
    /// </summary>
    [TestModule("f231a01e-97b5-47e2-8675-5e95480f2f7e", ModuleType.Recording, 1)]
    public partial class IngresoAplicacion : ITestModule
    {
        /// <summary>
        /// Holds an instance of the DesktopRepository repository.
        /// </summary>
        public static DesktopRepository repo = DesktopRepository.Instance;

        static IngresoAplicacion instance = new IngresoAplicacion();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public IngresoAplicacion()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static IngresoAplicacion Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'KeyPromptForm.Text' at CenterLeft.", repo.KeyPromptForm.TextInfo, new RecordItemIndex(0));
            repo.KeyPromptForm.Text.Click(Location.CenterLeft);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '●●●●●●●●' with focus on 'KeyPromptForm.Text'.", repo.KeyPromptForm.TextInfo, new RecordItemIndex(1));
            repo.KeyPromptForm.Text.PressKeys("M3ng4n0!");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'KeyPromptForm.MBtnOK' at Center.", repo.KeyPromptForm.MBtnOKInfo, new RecordItemIndex(2));
            repo.KeyPromptForm.MBtnOK.Click();
            Delay.Milliseconds(200);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(3));
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'MainForm.Database'", repo.MainForm.DatabaseInfo, new ActionTimeout(30000), new RecordItemIndex(4));
            repo.MainForm.DatabaseInfo.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
