using System;
using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace jsw
{
    public partial class UIJswScene : Scene
    {
		//COLORS
		private UIColor cBlue 	= new UIColor(0.5f,0.9f,0.9f,1f);
		private UIColor cYellow = new UIColor(0.9f,0.9f,0.1f,1f);
		private UIColor cGreen 	= new UIColor(0.1f,0.9f,0.1f,1f);
		private UIColor cBrown 	= new UIColor(0.9f,0.5f,0.1f,1f);
		private UIColor cRed 	= new UIColor(0.9f,0.1f,0.1f,1f);
		//--------------
		
		private Hashtable btn_hash = new Hashtable();
		
        public UIJswScene()
        {
            InitializeWidget();
			//Label_Info.BackgroundColor = new UIColor(0.2f,0.2f,0.2f,1f);
			
			Button_prefs.BackgroundFilterColor = new UIColor(0.2f,0.9f,0.9f,1f);
			
			Init_Button(Button_1,cBlue,"set('wpidx',0)");
			Init_Button(Button_2,cBlue,"set('wpidx',1)");
			Init_Button(Button_3,cBlue,"set('wpidx',2)");
			Init_Button(Button_4,cBlue,"set('wpidx',3)");
			Init_Button(Button_5,cBlue,"set('wpidx',4)");
			Init_Button(Button_6,cBlue,"set('wpidx',5)");
			Init_Button(Button_7,cBlue,"set('wpidx',6)");
			Init_Button(Button_8,cBlue,"set('wpidx',7)");
			Init_Button(Button_9,cBlue,"set('wpidx',8)");
			Init_Button(Button_NXT,cBlue,"set('wpidx',wpidx+1)");
			
			Init_Button(Button_LD,cYellow,"set('mode',LANDING)");
			Init_Button(Button_TO,cYellow,"set('mode',TAKEOFF)");
			Init_Button(Button_Cancel,cGreen,"set('stage',100)");
			
			Init_Button(Button_STBY,cBlue,"set('mode',STBY)");

			Init_Button(Button_HOME,cBrown,"set('mode',HOME)");
			Init_Button(Button_UAV,cBrown,"set('mode',UAV)");
			Init_Button(Button_RPV,cBrown,"set('mode',RPV)");
			
			Init_Button(Button_EMG,cRed,"set('mode',EMG)");
			Init_Button(Button_IGN,cRed,"set('power_ignition',!power_ignition)");

			Init_Button(Button_OVR,cRed,"set('cmode_thrcut',!cmode_thrcut)");
			Init_Button(Button_CUT,cRed,"set('cmode_throvr',!cmode_throvr)");
            Slider_Thr.ValueChanged += new EventHandler<SliderValueChangeEventArgs>(Slider_Action);

			SettingDialog = new UISettingDialog();
            Button_prefs.ButtonAction += new EventHandler<TouchEventArgs>(Button_prefs_ButtonAction);
            Button_Quit.ButtonAction += new EventHandler<TouchEventArgs>(Button_Quit_ButtonAction);
        }
		
		void Init_Button(Button btn,UIColor color,string cmd="")
        {
			btn.BackgroundFilterColor=color;
			btn.ButtonAction += new EventHandler<TouchEventArgs>(Button_Action);
			btn_hash.Add(btn,cmd);
        }

        void Button_prefs_ButtonAction(object sender, TouchEventArgs e)
        {
            SettingDialog.SetSize(this.RootWidget.Width, this.RootWidget.Height);
            SettingDialog.Show();
        }
        void Button_Quit_ButtonAction(object sender, TouchEventArgs e)
        {
			AppMain.loop=false;
		}

		public UISettingDialog SettingDialog  {
            get;
            private set;
        }

        public string Info
        {
            set { Label_Info.Text = value; }
        }

		public string Comm
        {
            set { Label_Comm.Text = value; }
        }

		public uint Thr
        {
            get { return (uint)Slider_Thr.Value; }
        }

		void Button_Action(object sender, TouchEventArgs e)
        {
	        Console.WriteLine("Touch button {0}: {1}", ((Button)sender).Text, btn_hash[sender]);

        }

		void Slider_Action(object sender, SliderValueChangeEventArgs e)
        {
	        Console.WriteLine("Slider {0}", e.Value.ToString());

        }

	}
}
