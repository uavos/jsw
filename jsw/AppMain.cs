using System;
using System.Collections.Generic;

using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Graphics;
using Sce.PlayStation.Core.Input;
using Sce.PlayStation.HighLevel.UI;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;

using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
using System.Timers;


namespace jsw
{
    [Serializable]
    public class VitaInputData
    {
        public uint keyData;
        //left anologue
        public float lx;
        public float ly;
        //right anologue
        public float rx;
        public float ry;
		//sliders
		public float thr;
    };
	
	public class AppMain
	{
		private static UdpClient udp;

		static GraphicsContext graphics;
        static UIJswScene scene;
		private static Sce.PlayStation.HighLevel.GameEngine2D.Base.Timer timer = new Sce.PlayStation.HighLevel.GameEngine2D.Base.Timer();
		private static float previousTime = 0; 
		private static float timePassed = 0;

		public static bool loop = true;
		
		private static System.Timers.Timer udpTimer = new System.Timers.Timer(100);	//[ms] interval
		private static VitaInputData jsw_data = new VitaInputData();

		public static void Main (string[] args)
		{
			Initialize ();

			while (loop) {
				timePassed += (float)(timer.Milliseconds()) - previousTime; 
				previousTime = (float)timer.Milliseconds(); 
				if (timePassed > (1000/60)){	//60Hz
					timePassed = 0;
					previousTime = 0; 
					timer.Reset(); 

					SystemEvents.CheckEvents ();
					Update ();
					Render ();
				}
			}
			Term ();

		}
		
		/// terminate
		public static void Term()
		{
		    graphics.Dispose();
		}


		public static void Initialize ()
		{
			// Set up the graphics system
			graphics = new GraphicsContext ();
            UISystem.Initialize (graphics);
            // Create scene
			scene=new UIJswScene();
            UISystem.SetScene(scene);
			//UDP
			udp = new UdpClient();
	        udpTimer.Elapsed += OnUdpTimerEvent;
            udpTimer.Enabled = true;
		}

		public static void Update ()
		{
            // Query touch for current state
            List<TouchData> touchDataList = Touch.GetData (0);
            
            // Update UI Toolkit
            UISystem.Update(touchDataList);

			// Query gamepad for current state
			var gamePadData = GamePad.GetData (0);
			//fill serial data
			jsw_data.keyData = (uint)gamePadData.Buttons;
			jsw_data.lx = gamePadData.AnalogLeftX;
			jsw_data.ly = gamePadData.AnalogLeftY;
			jsw_data.rx = gamePadData.AnalogRightX;
			jsw_data.ry = gamePadData.AnalogRightY;
			jsw_data.thr = scene.Thr/100f;
			//info label
			scene.Info="{"+gamePadData.AnalogLeftX.ToString("+0.00;-0.00;00.00")+";"+gamePadData.AnalogLeftY.ToString("+0.00;-0.00;00.00")+"} "+
				"{"+gamePadData.AnalogRightX.ToString("+0.00;-0.00;00.00")+";"+gamePadData.AnalogRightY.ToString("+0.00;-0.00;00.00")+"} "+
				"{"+jsw_data.thr.ToString("0.00")+"} "+
					"{"+jsw_data.keyData.ToString()+"}";
					//"{"+gamePadData.Buttons.ToString()+"}";
			scene.Comm=scene.SettingDialog.IP;
		}
		
		private static void UdpSend()
	    {
			IFormatter formatter = new BinaryFormatter();
            MemoryStream stream = new MemoryStream();
            formatter.Serialize(stream, jsw_data);
			stream.Flush();
			stream.Close();
            byte[] buffer = stream.GetBuffer();
			udp.Send(buffer, buffer.Length,scene.SettingDialog.IP,9030);
	    }

		private static void OnUdpTimerEvent(Object source, ElapsedEventArgs e)
	    {
	        //Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime);
			UdpSend();
	    }


		public static void Render ()
		{
			// Clear the screen
			graphics.SetClearColor (0.0f, 0.0f, 0.0f, 0.0f);
			graphics.Clear ();
			
			// Render UI Toolkit
            UISystem.Render ();
 
			// Present the screen
			graphics.SwapBuffers ();
		}
	}
}
