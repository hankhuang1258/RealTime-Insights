﻿#pragma checksum "C:\Users\chuhuan\Project\microsoft\RealTime-Insights\Controls\FaceIdentificationBorder.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D16E95F238F9C7A7B4C46FC66BAC55B1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IntelligentKioskSample.Controls
{
    partial class FaceIdentificationBorder : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.userControl = (global::Windows.UI.Xaml.Controls.UserControl)(target);
                }
                break;
            case 2:
                {
                    this.faceRectangle = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 3:
                {
                    this.captionCanvas = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 15 "..\..\..\Controls\FaceIdentificationBorder.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)this.captionCanvas).SizeChanged += this.OnCaptionSizeChanged;
                    #line default
                }
                break;
            case 4:
                {
                    this.genderAgeGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 5:
                {
                    this.emotionGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 6:
                {
                    this.emotionPolyline = (global::Windows.UI.Xaml.Shapes.Polyline)(target);
                }
                break;
            case 7:
                {
                    this.emotionGridBackground = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 8:
                {
                    this.emotionFeedbackGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 9:
                {
                    this.emotionFeedbackImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 10:
                {
                    this.emotionFeedbackTextBackground = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 11:
                {
                    this.emotionFeedbackText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12:
                {
                    this.emotionFeedbackBitmap = (global::Windows.UI.Xaml.Media.Imaging.BitmapImage)(target);
                }
                break;
            case 13:
                {
                    this.genderIcon = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

