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
    ///The AddEntry recording.
    /// </summary>
    [TestModule("a71b5bc5-7de3-4a86-9da6-10b1e64f2025", ModuleType.Recording, 1)]
    public partial class AddEntry : ITestModule
    {
        /// <summary>
        /// Holds an instance of the DesktopRepository repository.
        /// </summary>
        public static DesktopRepository repo = DesktopRepository.Instance;

        static AddEntry instance = new AddEntry();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddEntry()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddEntry Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainForm.Database' at Center.", repo.MainForm.DatabaseInfo, new RecordItemIndex(0));
            repo.MainForm.Database.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainForm.Entry' at Center.", repo.MainForm.EntryInfo, new RecordItemIndex(1));
            repo.MainForm.Entry.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'KeePass.AddEntry' at Center.", repo.KeePass.AddEntryInfo, new RecordItemIndex(2));
            repo.KeePass.AddEntry.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'PwEntryForm.MBannerImage'.", repo.PwEntryForm.MBannerImageInfo, new RecordItemIndex(3));
            Validate.Exists(repo.PwEntryForm.MBannerImageInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PwEntryForm.MTabEntry1.Title' at Center.", repo.PwEntryForm.MTabEntry1.TitleInfo, new RecordItemIndex(4));
            repo.PwEntryForm.MTabEntry1.Title.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'PruebaWebinearDesktop' with focus on 'PwEntryForm.MTabEntry1.Title'.", repo.PwEntryForm.MTabEntry1.TitleInfo, new RecordItemIndex(5));
            repo.PwEntryForm.MTabEntry1.Title.PressKeys("PruebaWebinearDesktop");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PwEntryForm.MTabEntry1.UserName' at Center.", repo.PwEntryForm.MTabEntry1.UserNameInfo, new RecordItemIndex(6));
            repo.PwEntryForm.MTabEntry1.UserName.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'User Prueba' with focus on 'PwEntryForm.MTabEntry1.UserName'.", repo.PwEntryForm.MTabEntry1.UserNameInfo, new RecordItemIndex(7));
            repo.PwEntryForm.MTabEntry1.UserName.PressKeys("User Prueba");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PwEntryForm.MTabEntry1.MCbHidePassword' at Center.", repo.PwEntryForm.MTabEntry1.MCbHidePasswordInfo, new RecordItemIndex(8));
            repo.PwEntryForm.MTabEntry1.MCbHidePassword.Click();
            Delay.Milliseconds(200);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(9));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PwEntryForm.MTabEntry1.MBtnGenPw' at Center.", repo.PwEntryForm.MTabEntry1.MBtnGenPwInfo, new RecordItemIndex(10));
            repo.PwEntryForm.MTabEntry1.MBtnGenPw.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'KeePass.MenuItemAutomaticallyGeneratedPasswor' at Center.", repo.KeePass.MenuItemAutomaticallyGeneratedPassworInfo, new RecordItemIndex(11));
            repo.KeePass.MenuItemAutomaticallyGeneratedPasswor.Click();
            Delay.Milliseconds(200);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(12));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PwEntryForm.MTabEntry1.MCbHidePassword' at Center.", repo.PwEntryForm.MTabEntry1.MCbHidePasswordInfo, new RecordItemIndex(13));
            repo.PwEntryForm.MTabEntry1.MCbHidePassword.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PwEntryForm.AutoType' at Center.", repo.PwEntryForm.AutoTypeInfo, new RecordItemIndex(14));
            repo.PwEntryForm.AutoType.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PwEntryForm.MCbAutoTypeEnabled' at CenterLeft.", repo.PwEntryForm.MCbAutoTypeEnabledInfo, new RecordItemIndex(15));
            repo.PwEntryForm.MCbAutoTypeEnabled.Click(Location.CenterLeft);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PwEntryForm.MBtnOK' at Center.", repo.PwEntryForm.MBtnOKInfo, new RecordItemIndex(16));
            repo.PwEntryForm.MBtnOK.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}