// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace jsw
{
    partial class UIJswScene
    {
        Panel sceneBackgroundPanel;
        Button Button_1;
        Button Button_2;
        Button Button_3;
        Button Button_4;
        Button Button_5;
        Button Button_6;
        Button Button_7;
        Button Button_8;
        Button Button_9;
        Button Button_LD;
        Button Button_EMG;
        Button Button_RPV;
        Button Button_prefs;
        Slider Slider_Thr;
        Button Button_NXT;
        Button Button_STBY;
        Button Button_TO;
        Button Button_Cancel;
        Button Button_Quit;
        Button Button_OVR;
        Button Button_CUT;
        Button Button_IGN;
        Button Button_UAV;
        Button Button_HOME;
        Label Label_Comm;
        Label Label_Info;
        PagePanel PagePanel_1;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            sceneBackgroundPanel = new Panel();
            sceneBackgroundPanel.Name = "sceneBackgroundPanel";
            Button_1 = new Button();
            Button_1.Name = "Button_1";
            Button_2 = new Button();
            Button_2.Name = "Button_2";
            Button_3 = new Button();
            Button_3.Name = "Button_3";
            Button_4 = new Button();
            Button_4.Name = "Button_4";
            Button_5 = new Button();
            Button_5.Name = "Button_5";
            Button_6 = new Button();
            Button_6.Name = "Button_6";
            Button_7 = new Button();
            Button_7.Name = "Button_7";
            Button_8 = new Button();
            Button_8.Name = "Button_8";
            Button_9 = new Button();
            Button_9.Name = "Button_9";
            Button_LD = new Button();
            Button_LD.Name = "Button_LD";
            Button_EMG = new Button();
            Button_EMG.Name = "Button_EMG";
            Button_RPV = new Button();
            Button_RPV.Name = "Button_RPV";
            Button_prefs = new Button();
            Button_prefs.Name = "Button_prefs";
            Slider_Thr = new Slider();
            Slider_Thr.Name = "Slider_Thr";
            Button_NXT = new Button();
            Button_NXT.Name = "Button_NXT";
            Button_STBY = new Button();
            Button_STBY.Name = "Button_STBY";
            Button_TO = new Button();
            Button_TO.Name = "Button_TO";
            Button_Cancel = new Button();
            Button_Cancel.Name = "Button_Cancel";
            Button_Quit = new Button();
            Button_Quit.Name = "Button_Quit";
            Button_OVR = new Button();
            Button_OVR.Name = "Button_OVR";
            Button_CUT = new Button();
            Button_CUT.Name = "Button_CUT";
            Button_IGN = new Button();
            Button_IGN.Name = "Button_IGN";
            Button_UAV = new Button();
            Button_UAV.Name = "Button_UAV";
            Button_HOME = new Button();
            Button_HOME.Name = "Button_HOME";
            Label_Comm = new Label();
            Label_Comm.Name = "Label_Comm";
            Label_Info = new Label();
            Label_Info.Name = "Label_Info";
            PagePanel_1 = new PagePanel();
            PagePanel_1.Name = "PagePanel_1";

            // sceneBackgroundPanel
            sceneBackgroundPanel.BackgroundColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);

            // UIJswScene
            this.RootWidget.AddChildLast(sceneBackgroundPanel);
            this.RootWidget.AddChildLast(Button_1);
            this.RootWidget.AddChildLast(Button_2);
            this.RootWidget.AddChildLast(Button_3);
            this.RootWidget.AddChildLast(Button_4);
            this.RootWidget.AddChildLast(Button_5);
            this.RootWidget.AddChildLast(Button_6);
            this.RootWidget.AddChildLast(Button_7);
            this.RootWidget.AddChildLast(Button_8);
            this.RootWidget.AddChildLast(Button_9);
            this.RootWidget.AddChildLast(Button_LD);
            this.RootWidget.AddChildLast(Button_EMG);
            this.RootWidget.AddChildLast(Button_RPV);
            this.RootWidget.AddChildLast(Button_prefs);
            this.RootWidget.AddChildLast(Slider_Thr);
            this.RootWidget.AddChildLast(Button_NXT);
            this.RootWidget.AddChildLast(Button_STBY);
            this.RootWidget.AddChildLast(Button_TO);
            this.RootWidget.AddChildLast(Button_Cancel);
            this.RootWidget.AddChildLast(Button_Quit);
            this.RootWidget.AddChildLast(Button_OVR);
            this.RootWidget.AddChildLast(Button_CUT);
            this.RootWidget.AddChildLast(Button_IGN);
            this.RootWidget.AddChildLast(Button_UAV);
            this.RootWidget.AddChildLast(Button_HOME);
            this.RootWidget.AddChildLast(Label_Comm);
            this.RootWidget.AddChildLast(Label_Info);
            this.RootWidget.AddChildLast(PagePanel_1);

            // Button_1
            Button_1.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Button_1.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // Button_2
            Button_2.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Button_2.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // Button_3
            Button_3.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Button_3.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // Button_4
            Button_4.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Button_4.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // Button_5
            Button_5.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Button_5.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // Button_6
            Button_6.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Button_6.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // Button_7
            Button_7.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Button_7.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // Button_8
            Button_8.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Button_8.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // Button_9
            Button_9.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Button_9.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // Button_LD
            Button_LD.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Button_LD.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // Button_EMG
            Button_EMG.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Button_EMG.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // Button_RPV
            Button_RPV.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Button_RPV.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // Button_prefs
            Button_prefs.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Button_prefs.TextFont = new UIFont(FontAlias.System, 15, FontStyle.Regular);

            // Slider_Thr
            Slider_Thr.Orientation = SliderOrientation.Vertical;
            Slider_Thr.MinValue = 0;
            Slider_Thr.MaxValue = 100;
            Slider_Thr.Value = 0;
            Slider_Thr.Step = 1;

            // Button_NXT
            Button_NXT.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Button_NXT.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // Button_STBY
            Button_STBY.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Button_STBY.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // Button_TO
            Button_TO.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Button_TO.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // Button_Cancel
            Button_Cancel.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Button_Cancel.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // Button_Quit
            Button_Quit.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Button_Quit.TextFont = new UIFont(FontAlias.System, 15, FontStyle.Regular);

            // Button_OVR
            Button_OVR.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Button_OVR.TextFont = new UIFont(FontAlias.System, 20, FontStyle.Regular);

            // Button_CUT
            Button_CUT.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Button_CUT.TextFont = new UIFont(FontAlias.System, 20, FontStyle.Regular);

            // Button_IGN
            Button_IGN.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Button_IGN.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // Button_UAV
            Button_UAV.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Button_UAV.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // Button_HOME
            Button_HOME.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Button_HOME.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // Label_Comm
            Label_Comm.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Label_Comm.Font = new UIFont(FontAlias.System, 15, FontStyle.Regular);
            Label_Comm.LineBreak = LineBreak.Character;
            Label_Comm.HorizontalAlignment = HorizontalAlignment.Right;

            // Label_Info
            Label_Info.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Label_Info.Font = new UIFont(FontAlias.System, 10, FontStyle.Regular);
            Label_Info.LineBreak = LineBreak.Character;

            // PagePanel_1
            PagePanel_1.AddPage(new Panel_PFD());
            PagePanel_1.AddPage(new Panel_MNT());

            SetWidgetLayout(orientation);

            UpdateLanguage();
        }

        private LayoutOrientation _currentLayoutOrientation;
        public void SetWidgetLayout(LayoutOrientation orientation)
        {
            switch (orientation)
            {
                case LayoutOrientation.Vertical:
                    this.DesignWidth = 544;
                    this.DesignHeight = 960;

                    sceneBackgroundPanel.SetPosition(0, 0);
                    sceneBackgroundPanel.SetSize(544, 960);
                    sceneBackgroundPanel.Anchors = Anchors.Top | Anchors.Bottom | Anchors.Left | Anchors.Right;
                    sceneBackgroundPanel.Visible = true;

                    Button_1.SetPosition(633, 274);
                    Button_1.SetSize(214, 56);
                    Button_1.Anchors = Anchors.None;
                    Button_1.Visible = true;

                    Button_2.SetPosition(633, 274);
                    Button_2.SetSize(214, 56);
                    Button_2.Anchors = Anchors.None;
                    Button_2.Visible = true;

                    Button_3.SetPosition(633, 274);
                    Button_3.SetSize(214, 56);
                    Button_3.Anchors = Anchors.None;
                    Button_3.Visible = true;

                    Button_4.SetPosition(633, 274);
                    Button_4.SetSize(214, 56);
                    Button_4.Anchors = Anchors.None;
                    Button_4.Visible = true;

                    Button_5.SetPosition(633, 274);
                    Button_5.SetSize(214, 56);
                    Button_5.Anchors = Anchors.None;
                    Button_5.Visible = true;

                    Button_6.SetPosition(633, 274);
                    Button_6.SetSize(214, 56);
                    Button_6.Anchors = Anchors.None;
                    Button_6.Visible = true;

                    Button_7.SetPosition(633, 274);
                    Button_7.SetSize(214, 56);
                    Button_7.Anchors = Anchors.None;
                    Button_7.Visible = true;

                    Button_8.SetPosition(633, 274);
                    Button_8.SetSize(214, 56);
                    Button_8.Anchors = Anchors.None;
                    Button_8.Visible = true;

                    Button_9.SetPosition(633, 274);
                    Button_9.SetSize(214, 56);
                    Button_9.Anchors = Anchors.None;
                    Button_9.Visible = true;

                    Button_LD.SetPosition(633, 274);
                    Button_LD.SetSize(214, 56);
                    Button_LD.Anchors = Anchors.None;
                    Button_LD.Visible = true;

                    Button_EMG.SetPosition(633, 274);
                    Button_EMG.SetSize(214, 56);
                    Button_EMG.Anchors = Anchors.None;
                    Button_EMG.Visible = true;

                    Button_RPV.SetPosition(633, 274);
                    Button_RPV.SetSize(214, 56);
                    Button_RPV.Anchors = Anchors.None;
                    Button_RPV.Visible = true;

                    Button_prefs.SetPosition(633, 274);
                    Button_prefs.SetSize(214, 56);
                    Button_prefs.Anchors = Anchors.None;
                    Button_prefs.Visible = true;

                    Slider_Thr.SetPosition(511, 308);
                    Slider_Thr.SetSize(362, 58);
                    Slider_Thr.Anchors = Anchors.Height;
                    Slider_Thr.Visible = true;

                    Button_NXT.SetPosition(633, 274);
                    Button_NXT.SetSize(214, 56);
                    Button_NXT.Anchors = Anchors.None;
                    Button_NXT.Visible = true;

                    Button_STBY.SetPosition(633, 274);
                    Button_STBY.SetSize(214, 56);
                    Button_STBY.Anchors = Anchors.None;
                    Button_STBY.Visible = true;

                    Button_TO.SetPosition(633, 274);
                    Button_TO.SetSize(214, 56);
                    Button_TO.Anchors = Anchors.None;
                    Button_TO.Visible = true;

                    Button_Cancel.SetPosition(633, 274);
                    Button_Cancel.SetSize(214, 56);
                    Button_Cancel.Anchors = Anchors.None;
                    Button_Cancel.Visible = true;

                    Button_Quit.SetPosition(633, 274);
                    Button_Quit.SetSize(214, 56);
                    Button_Quit.Anchors = Anchors.None;
                    Button_Quit.Visible = true;

                    Button_OVR.SetPosition(633, 274);
                    Button_OVR.SetSize(214, 56);
                    Button_OVR.Anchors = Anchors.None;
                    Button_OVR.Visible = true;

                    Button_CUT.SetPosition(633, 274);
                    Button_CUT.SetSize(214, 56);
                    Button_CUT.Anchors = Anchors.None;
                    Button_CUT.Visible = true;

                    Button_IGN.SetPosition(633, 274);
                    Button_IGN.SetSize(214, 56);
                    Button_IGN.Anchors = Anchors.None;
                    Button_IGN.Visible = true;

                    Button_UAV.SetPosition(633, 274);
                    Button_UAV.SetSize(214, 56);
                    Button_UAV.Anchors = Anchors.None;
                    Button_UAV.Visible = true;

                    Button_HOME.SetPosition(633, 274);
                    Button_HOME.SetSize(214, 56);
                    Button_HOME.Anchors = Anchors.None;
                    Button_HOME.Visible = true;

                    Label_Comm.SetPosition(0, 508);
                    Label_Comm.SetSize(214, 36);
                    Label_Comm.Anchors = Anchors.None;
                    Label_Comm.Visible = true;

                    Label_Info.SetPosition(0, 508);
                    Label_Info.SetSize(214, 36);
                    Label_Info.Anchors = Anchors.None;
                    Label_Info.Visible = true;

                    PagePanel_1.SetPosition(584, 227);
                    PagePanel_1.SetSize(100, 50);
                    PagePanel_1.Anchors = Anchors.None;
                    PagePanel_1.Visible = true;

                    break;

                default:
                    this.DesignWidth = 960;
                    this.DesignHeight = 544;

                    sceneBackgroundPanel.SetPosition(0, 0);
                    sceneBackgroundPanel.SetSize(960, 544);
                    sceneBackgroundPanel.Anchors = Anchors.Top | Anchors.Bottom | Anchors.Left | Anchors.Right;
                    sceneBackgroundPanel.Visible = true;

                    Button_1.SetPosition(0, 0);
                    Button_1.SetSize(130, 54);
                    Button_1.Anchors = Anchors.None;
                    Button_1.Visible = true;

                    Button_2.SetPosition(0, 54);
                    Button_2.SetSize(130, 54);
                    Button_2.Anchors = Anchors.None;
                    Button_2.Visible = true;

                    Button_3.SetPosition(0, 108);
                    Button_3.SetSize(130, 54);
                    Button_3.Anchors = Anchors.None;
                    Button_3.Visible = true;

                    Button_4.SetPosition(0, 162);
                    Button_4.SetSize(130, 54);
                    Button_4.Anchors = Anchors.None;
                    Button_4.Visible = true;

                    Button_5.SetPosition(0, 216);
                    Button_5.SetSize(130, 54);
                    Button_5.Anchors = Anchors.None;
                    Button_5.Visible = true;

                    Button_6.SetPosition(0, 270);
                    Button_6.SetSize(130, 54);
                    Button_6.Anchors = Anchors.None;
                    Button_6.Visible = true;

                    Button_7.SetPosition(0, 324);
                    Button_7.SetSize(130, 54);
                    Button_7.Anchors = Anchors.None;
                    Button_7.Visible = true;

                    Button_8.SetPosition(0, 378);
                    Button_8.SetSize(130, 54);
                    Button_8.Anchors = Anchors.None;
                    Button_8.Visible = true;

                    Button_9.SetPosition(0, 432);
                    Button_9.SetSize(130, 54);
                    Button_9.Anchors = Anchors.None;
                    Button_9.Visible = true;

                    Button_LD.SetPosition(142, 0);
                    Button_LD.SetSize(180, 108);
                    Button_LD.Anchors = Anchors.None;
                    Button_LD.Visible = true;

                    Button_EMG.SetPosition(213, 429);
                    Button_EMG.SetSize(109, 54);
                    Button_EMG.Anchors = Anchors.None;
                    Button_EMG.Visible = true;

                    Button_RPV.SetPosition(142, 339);
                    Button_RPV.SetSize(180, 80);
                    Button_RPV.Anchors = Anchors.None;
                    Button_RPV.Visible = true;

                    Button_prefs.SetPosition(879, 0);
                    Button_prefs.SetSize(84, 54);
                    Button_prefs.Anchors = Anchors.None;
                    Button_prefs.Visible = true;

                    Slider_Thr.SetPosition(902, 144);
                    Slider_Thr.SetSize(58, 339);
                    Slider_Thr.Anchors = Anchors.Top | Anchors.Bottom | Anchors.Height;
                    Slider_Thr.Visible = true;

                    Button_NXT.SetPosition(0, 490);
                    Button_NXT.SetSize(130, 54);
                    Button_NXT.Anchors = Anchors.None;
                    Button_NXT.Visible = true;

                    Button_STBY.SetPosition(142, 117);
                    Button_STBY.SetSize(180, 80);
                    Button_STBY.Anchors = Anchors.None;
                    Button_STBY.Visible = true;

                    Button_TO.SetPosition(568, 0);
                    Button_TO.SetSize(180, 54);
                    Button_TO.Anchors = Anchors.None;
                    Button_TO.Visible = true;

                    Button_Cancel.SetPosition(336, 0);
                    Button_Cancel.SetSize(180, 108);
                    Button_Cancel.Anchors = Anchors.None;
                    Button_Cancel.Visible = true;

                    Button_Quit.SetPosition(795, 0);
                    Button_Quit.SetSize(84, 54);
                    Button_Quit.Anchors = Anchors.None;
                    Button_Quit.Visible = true;

                    Button_OVR.SetPosition(876, 82);
                    Button_OVR.SetSize(84, 54);
                    Button_OVR.Anchors = Anchors.None;
                    Button_OVR.Visible = true;

                    Button_CUT.SetPosition(876, 490);
                    Button_CUT.SetSize(84, 54);
                    Button_CUT.Anchors = Anchors.None;
                    Button_CUT.Visible = true;

                    Button_IGN.SetPosition(213, 490);
                    Button_IGN.SetSize(109, 54);
                    Button_IGN.Anchors = Anchors.None;
                    Button_IGN.Visible = true;

                    Button_UAV.SetPosition(142, 277);
                    Button_UAV.SetSize(180, 54);
                    Button_UAV.Anchors = Anchors.None;
                    Button_UAV.Visible = true;

                    Button_HOME.SetPosition(142, 205);
                    Button_HOME.SetSize(180, 54);
                    Button_HOME.Anchors = Anchors.None;
                    Button_HOME.Visible = true;

                    Label_Comm.SetPosition(795, 54);
                    Label_Comm.SetSize(165, 15);
                    Label_Comm.Anchors = Anchors.Bottom | Anchors.Left | Anchors.Right;
                    Label_Comm.Visible = true;

                    Label_Info.SetPosition(532, 107);
                    Label_Info.SetSize(335, 10);
                    Label_Info.Anchors = Anchors.Bottom | Anchors.Left | Anchors.Right;
                    Label_Info.Visible = true;

                    PagePanel_1.SetPosition(336, 118);
                    PagePanel_1.SetSize(530, 426);
                    PagePanel_1.Anchors = Anchors.None;
                    PagePanel_1.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            this.Title = "JSW";

            Button_1.Text = "1";

            Button_2.Text = "2";

            Button_3.Text = "3";

            Button_4.Text = "4";

            Button_5.Text = "5";

            Button_6.Text = "6";

            Button_7.Text = "7";

            Button_8.Text = "8";

            Button_9.Text = "9";

            Button_LD.Text = "LANDING";

            Button_EMG.Text = "EMG";

            Button_RPV.Text = "RPV";

            Button_prefs.Text = "Prefs";

            Button_NXT.Text = "NXT";

            Button_STBY.Text = "STBY";

            Button_TO.Text = "TAKEOFF";

            Button_Cancel.Text = "Cancel";

            Button_Quit.Text = "Quit";

            Button_OVR.Text = "OVR";

            Button_CUT.Text = "CUT";

            Button_IGN.Text = "IGN";

            Button_UAV.Text = "UAV";

            Button_HOME.Text = "HOME";

            Label_Comm.Text = "Comm";

            Label_Info.Text = "Info";
        }

        private void onShowing(object sender, EventArgs e)
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                    break;

                default:
                    break;
            }
        }

        private void onShown(object sender, EventArgs e)
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                    break;

                default:
                    break;
            }
        }

    }
}
