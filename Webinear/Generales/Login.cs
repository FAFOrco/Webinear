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

namespace Webinear.Generales
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Login recording.
    /// </summary>
    [TestModule("f054724d-12aa-4b01-9e81-840fa659cb77", ModuleType.Recording, 1)]
    public partial class Login : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Webinear.WebinearRepository repository.
        /// </summary>
        public static global::Webinear.WebinearRepository repo = global::Webinear.WebinearRepository.Instance;

        static Login instance = new Login();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Login()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Login Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SomeDivTag.Email' at Center.", repo.ApplicationUnderTest.SomeDivTag.EmailInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.SomeDivTag.Email.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'fernando_figliola@itrsa.com.ar' with focus on 'ApplicationUnderTest.SomeDivTag.Email'.", repo.ApplicationUnderTest.SomeDivTag.EmailInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.SomeDivTag.Email.PressKeys("fernando_figliola@itrsa.com.ar");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SomeDivTag.Submit' at Center.", repo.ApplicationUnderTest.SomeDivTag.SubmitInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.SomeDivTag.Submit.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SomeDivTag.PersonalAccount' at Center.", repo.ApplicationUnderTest.SomeDivTag.PersonalAccountInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.SomeDivTag.PersonalAccount.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OneDrive.Passwd' at Center.", repo.OneDrive.PasswdInfo, new RecordItemIndex(4));
            repo.OneDrive.Passwd.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '●●●●●●●●●●●●●●' with focus on 'OneDrive.Passwd'.", repo.OneDrive.PasswdInfo, new RecordItemIndex(5));
            repo.OneDrive.Passwd.PressKeys("unaPass_123321");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OneDrive.IdSIButton9' at 45;16.", repo.OneDrive.IdSIButton9Info, new RecordItemIndex(6));
            repo.OneDrive.IdSIButton9.Click("45;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.MisArchivos'", repo.ApplicationUnderTest.MisArchivosInfo, new ActionTimeout(30000), new RecordItemIndex(7));
            repo.ApplicationUnderTest.MisArchivosInfo.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
