// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace jsw
{
    partial class UISettingDialog
    {
        Button Button_OK;
        Label Label_1;
        EditableText Text_IP;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            Button_OK = new Button();
            Button_OK.Name = "Button_OK";
            Label_1 = new Label();
            Label_1.Name = "Label_1";
            Text_IP = new EditableText();
            Text_IP.Name = "Text_IP";

            // UISettingDialog
            this.BackgroundStyle = DialogBackgroundStyle.Custom;
            this.CustomBackgroundImage = null;
            this.CustomBackgroundNinePatchMargin = new NinePatchMargin(34, 34, 34, 34);
            this.CustomBackgroundColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            this.BackgroundFilterColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            this.AddChildLast(Button_OK);
            this.AddChildLast(Label_1);
            this.AddChildLast(Text_IP);
            this.ShowEffect = new SlideInEffect()
            {
                MoveDirection = FourWayDirection.Up,
            };
            this.HideEffect = new TiltDropEffect();

            // Button_OK
            Button_OK.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Button_OK.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // Label_1
            Label_1.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Label_1.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Label_1.LineBreak = LineBreak.Character;
            Label_1.HorizontalAlignment = HorizontalAlignment.Right;

            // Text_IP
            Text_IP.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Text_IP.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Text_IP.LineBreak = LineBreak.Character;

            SetWidgetLayout(orientation);

            UpdateLanguage();
        }

        private LayoutOrientation _currentLayoutOrientation;
        public void SetWidgetLayout(LayoutOrientation orientation)
        {
            switch (orientation)
            {
                case LayoutOrientation.Vertical:
                    this.SetPosition(1, 1);
                    this.SetSize(400, 640);
                    this.Anchors = Anchors.None;

                    Button_OK.SetPosition(144, 310);
                    Button_OK.SetSize(214, 56);
                    Button_OK.Anchors = Anchors.None;
                    Button_OK.Visible = true;

                    Label_1.SetPosition(23, 36);
                    Label_1.SetSize(214, 36);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    Text_IP.SetPosition(250, 28);
                    Text_IP.SetSize(360, 56);
                    Text_IP.Anchors = Anchors.None;
                    Text_IP.Visible = true;

                    break;

                default:
                    this.SetPosition(1, 1);
                    this.SetSize(960, 544);
                    this.Anchors = Anchors.None;

                    Button_OK.SetPosition(766, 397);
                    Button_OK.SetSize(193, 146);
                    Button_OK.Anchors = Anchors.None;
                    Button_OK.Visible = true;

                    Label_1.SetPosition(23, 36);
                    Label_1.SetSize(214, 36);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    Text_IP.SetPosition(268, 27);
                    Text_IP.SetSize(209, 54);
                    Text_IP.Anchors = Anchors.None;
                    Text_IP.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            Button_OK.Text = "OK";

            Label_1.Text = "IP address";

            Text_IP.DefaultText = "192.168.0.";
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
