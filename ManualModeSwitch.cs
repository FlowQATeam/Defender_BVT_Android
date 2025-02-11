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
    ///The ManualModeSwitch recording.
    /// </summary>
    [TestModule("9beb82ba-3528-4f58-ba25-fa0744e44877", ModuleType.Recording, 1)]
    public partial class ManualModeSwitch : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SSPC_iOS_BVTRepository repository.
        /// </summary>
        public static SSPC_iOS_BVTRepository repo = SSPC_iOS_BVTRepository.Instance;

        static ManualModeSwitch instance = new ManualModeSwitch();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ManualModeSwitch()
        {
            ManualFrequency = "1";
            ManualDuration = "15";
            ManualWaitTime = "75s";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ManualModeSwitch Instance
        {
            get { return instance; }
        }

#region Variables

        string _ManualFrequency;

        /// <summary>
        /// Gets or sets the value of variable ManualFrequency.
        /// </summary>
        [TestVariable("064ca38d-9e0a-4427-8bba-c3aa76a06bd5")]
        public string ManualFrequency
        {
            get { return _ManualFrequency; }
            set { _ManualFrequency = value; }
        }

        string _ManualDuration;

        /// <summary>
        /// Gets or sets the value of variable ManualDuration.
        /// </summary>
        [TestVariable("db7ffbd6-1dba-431c-8ea0-b146a25ed169")]
        public string ManualDuration
        {
            get { return _ManualDuration; }
            set { _ManualDuration = value; }
        }

        string _ManualWaitTime;

        /// <summary>
        /// Gets or sets the value of variable ManualWaitTime.
        /// </summary>
        [TestVariable("09939601-0caa-4c3b-9ee7-076fd28a27d2")]
        public string ManualWaitTime
        {
            get { return _ManualWaitTime; }
            set { _ManualWaitTime = value; }
        }

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
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.Manual' at Center", repo.ComPentairPentairhome.ManualInfo, new RecordItemIndex(4));
            repo.ComPentairPentairhome.Manual.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Touch gestures", "Swipe gesture with direction 'Up (270°)' starting from 'Center' with distance '.5' with swipe duration'500ms' and step count '0' on item 'ComPentairPentairhome.ManualScrollUp'.", repo.ComPentairPentairhome.ManualScrollUpInfo, new RecordItemIndex(5));
            repo.ComPentairPentairhome.ManualScrollUp.Swipe(Location.Center, ValueConverter.ArgumentFromString<Ranorex.Core.Recorder.Touch.GestureDirection>("SwipeDirection", "Up (270°)"), ValueConverter.ArgumentFromString<Ranorex.Core.Distance>("Distance", ".5"), ValueConverter.ArgumentFromString<Ranorex.Duration>("SwipeDuration", "500ms"), 0);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '$ManualFrequency' on item 'ComPentairPentairhome.Manual_frequency'.", repo.ComPentairPentairhome.Manual_frequencyInfo, new RecordItemIndex(6));
            repo.ComPentairPentairhome.Manual_frequency.Element.SetAttributeValue("Text", ManualFrequency);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(7));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '$ManualDuration' on item 'ComPentairPentairhome.Manula_Duration'.", repo.ComPentairPentairhome.Manula_DurationInfo, new RecordItemIndex(8));
            repo.ComPentairPentairhome.Manula_Duration.Element.SetAttributeValue("Text", ManualDuration);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(9));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.StartManual' at Center", repo.ComPentairPentairhome.StartManualInfo, new RecordItemIndex(10));
            repo.ComPentairPentairhome.StartManual.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for time from variable $ManualWaitTime.", new RecordItemIndex(11));
            Delay.Duration(Duration.Parse(ManualWaitTime), false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
