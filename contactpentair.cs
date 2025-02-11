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
    ///The contactpentair recording.
    /// </summary>
    [TestModule("53726207-098c-4403-aeff-f2ba58d3bae6", ModuleType.Recording, 1)]
    public partial class contactpentair : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SSPC_iOS_BVTRepository repository.
        /// </summary>
        public static SSPC_iOS_BVTRepository repo = SSPC_iOS_BVTRepository.Instance;

        static contactpentair instance = new contactpentair();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public contactpentair()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static contactpentair Instance
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
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(1));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.SSPCtileClick' at Center", repo.ComPentairPentairhome.SSPCtileClickInfo, new RecordItemIndex(2));
            repo.ComPentairPentairhome.SSPCtileClick.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(3));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.Settingsicon' at Center", repo.ComPentairPentairhome.SettingsiconInfo, new RecordItemIndex(4));
            repo.ComPentairPentairhome.Settingsicon.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(5));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.ContactPentair' at Center", repo.ComPentairPentairhome.ContactPentairInfo, new RecordItemIndex(6));
            repo.ComPentairPentairhome.ContactPentair.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(7));
            Delay.Duration(2000, false);
            
            try {
                //Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 2m to exist. Associated repository item: 'ComPentairPentairhome.PentairSupport'", repo.ComPentairPentairhome.PentairSupportInfo, new ActionTimeout(120000), new RecordItemIndex(8));
                //repo.ComPentairPentairhome.PentairSupportInfo.WaitForExists(120000);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.ScheduleHealthTestDropDown' at Center", repo.ComPentairPentairhome.ScheduleHealthTestDropDownInfo, new RecordItemIndex(9));
            repo.ComPentairPentairhome.ScheduleHealthTestDropDown.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(10));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.DeviceSupport' at Center", repo.ComPentairPentairhome.DeviceSupportInfo, new RecordItemIndex(11));
            repo.ComPentairPentairhome.DeviceSupport.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(12));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.UIWindow.ContinueonProvisiom' at Center", repo.ComPentairPentairhome.UIWindow.ContinueonProvisiomInfo, new RecordItemIndex(13));
            repo.ComPentairPentairhome.UIWindow.ContinueonProvisiom.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(14));
            Delay.Duration(10000, false);
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComPentairPentairhome.AcceptCookies' at Center", repo.ComPentairPentairhome.AcceptCookiesInfo, new RecordItemIndex(15));
                repo.ComPentairPentairhome.AcceptCookies.Touch();
                Delay.Milliseconds(300);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(15)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 2s.", new RecordItemIndex(16));
                Delay.Duration(2000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(16)); }
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='WE'RE WAITING TO HEAR FROM YOU') on item 'ComPentairPentairhome.WEREWAITINGTOHEARFROMYOU'.", repo.ComPentairPentairhome.WEREWAITINGTOHEARFROMYOUInfo, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.ComPentairPentairhome.WEREWAITINGTOHEARFROMYOUInfo, "InnerText", "WE'RE WAITING TO HEAR FROM YOU");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(18));
            Delay.Duration(10000, false);
            
            //Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.ContactPentairBack' at Center", repo.ComPentairPentairhome.ContactPentairBackInfo, new RecordItemIndex(19));
            //repo.ComPentairPentairhome.ContactPentairBack.Touch();
            //Delay.Milliseconds(300);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(20));
            //Delay.Duration(10000, false);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 30s.", new RecordItemIndex(21));
            //Delay.Duration(30000, false);
            
            Report.Log(ReportLevel.Info, "Application", "Killing application containing item 'ComPentairPentairhome'.", repo.ComPentairPentairhome.SelfInfo, new RecordItemIndex(22));
            Host.Current.KillApplication(repo.ComPentairPentairhome.Self);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Application", "Run mobile app 'com.pentair.pentairhome' on device 'Jyotiâ€™s iPhone'.", new RecordItemIndex(23));
            Host.Local.RunMobileApp("Jyotiâ€™s iPhone", "com.pentair.pentairhome", false);
            Delay.Milliseconds(3500);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(24));
            Delay.Duration(10000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
