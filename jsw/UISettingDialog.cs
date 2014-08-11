/* PlayStation(R)Mobile SDK 2.00.00
 * Copyright (C) 2014 Sony Computer Entertainment Inc.
 * All Rights Reserved.
 */


using System;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.HighLevel.UI;
using System.Xml;

namespace jsw
{
    public partial class UISettingDialog : Dialog
    {

    	const string SAVE_FILE = "/Documents/jsw.xml";

		public UISettingDialog()
        {
            InitializeWidget();
			Button_OK.BackgroundFilterColor = new UIColor(0.2f,0.9f,0.0f,1f);
            Button_OK.ButtonAction += new EventHandler<TouchEventArgs>(Button_OK_ButtonAction);
			LoadSettings();
        }

        public string IP
        {
            get { return Text_IP.Text; }
            set { Text_IP.Text = value; }
        }


        void Button_OK_ButtonAction(object sender, TouchEventArgs e)
        {
            this.Hide();
			SaveSettings();
        }

		void SaveSettings ()
		{
			XmlWriterSettings settings = new XmlWriterSettings();
			settings.Indent = true;
			settings.OmitXmlDeclaration = true;
			XmlWriter write = XmlWriter.Create(SAVE_FILE, settings);
			write.WriteStartElement("Settings");
			write.WriteAttributeString("IP", IP);
			write.WriteEndElement();
			write.Close();
		}

		void LoadSettings ()
		{
	        XmlReaderSettings settings = new XmlReaderSettings();  
	        settings.IgnoreComments = true;  
	        settings.IgnoreWhitespace = true;  
	        try  
	        {  
	            using (XmlReader reader = XmlReader.Create(SAVE_FILE, settings))  
	            {  
	                while (reader.Read())  
	                {  
	                    if (reader.NodeType == XmlNodeType.Element)  
	                    {  
	                        if(reader.Name == "Settings")  
	                        {  
	                            if (reader.HasAttributes)  
	                            {  
	                                IP = reader.GetAttribute("IP").ToString();  
	                            }  
	                        }  
	                    }  
	                }  
	            }  
	        }  
	        catch (Exception )  
	        {  
			}
		}
    }
}
