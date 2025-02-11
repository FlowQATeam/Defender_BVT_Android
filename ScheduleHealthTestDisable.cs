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

namespace SSPC_iOS
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ScheduleHealthTestDisable recording.
    /// </summary>
    [TestModule("590beac9-a152-4e13-a7ee-56991be6c19b", ModuleType.Recording, 1)]
    public partial class ScheduleHealthTestDisable : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SSPC_iOS_BVTRepository repository.
        /// </summary>
        public static SSPC_iOS_BVTRepository repo = SSPC_iOS_BVTRepository.Instance;

        static ScheduleHealthTestDisable instance = new ScheduleHealthTestDisable();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ScheduleHealthTestDisable()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ScheduleHealthTestDisable Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Nickname.
        /// </summary>
        [TestVariable("15db34cc-b901-4dc4-b385-f561e02f4c65")]
        public string Nickname
        {
            get { return repo.Nickname; }
            set { repo.Nickname = value; }
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
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.HomeIcon' at Center", repo.ComPentairPentairhome.HomeIconInfo, new RecordItemIndex(0));
            repo.ComPentairPentairhome.HomeIcon.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(1));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.SSPCtileClick' at Center", repo.ComPentairPentairhome.SSPCtileClickInfo, new RecordItemIndex(2));
            repo.ComPentairPentairhome.SSPCtileClick.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(3));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.FrequencySelection' at Center", repo.ComPentairPentairhome.FrequencySelectionInfo, new RecordItemIndex(4));
            repo.ComPentairPentairhome.FrequencySelection.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(5));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.ScheduleHealthTestDropDown' at Center", repo.ComPentairPentairhome.ScheduleHealthTestDropDownInfo, new RecordItemIndex(6));
            repo.ComPentairPentairhome.ScheduleHealthTestDropDown.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(7));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.ScheduleHTDisableSelect' at Center", repo.ComPentairPentairhome.ScheduleHTDisableSelectInfo, new RecordItemIndex(8));
            repo.ComPentairPentairhome.ScheduleHTDisableSelect.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(9));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.ScheduleSave' at Center", repo.ComPentairPentairhome.ScheduleSaveInfo, new RecordItemIndex(10));
            repo.ComPentairPentairhome.ScheduleSave.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 20s.", new RecordItemIndex(11));
            Delay.Duration(20000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.ComPentairPentairhome.UIWindow.ScreenShot, false, new RecordItemIndex(12));
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(13));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
