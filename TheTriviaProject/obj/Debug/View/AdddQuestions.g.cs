﻿#pragma checksum "..\..\..\View\AdddQuestions.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5B80552BE0955248DFED29C549DDE0C1411E79BD3F9FC4752D613FF1474BC86E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using TheTriviaProject.View;


namespace TheTriviaProject.View {
    
    
    /// <summary>
    /// AdddQuestions
    /// </summary>
    public partial class AdddQuestions : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\View\AdddQuestions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox QuestionTextBox;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\View\AdddQuestions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CorrectAnswerTextBox;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\View\AdddQuestions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox WrongAnswer1TextBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\View\AdddQuestions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox WrongAnswer2TextBox;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\View\AdddQuestions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox WrongAnswer3TextBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\View\AdddQuestions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CategoryTextBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TheTriviaProject;component/view/adddquestions.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\AdddQuestions.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.QuestionTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\..\View\AdddQuestions.xaml"
            this.QuestionTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.RemoveText);
            
            #line default
            #line hidden
            
            #line 23 "..\..\..\View\AdddQuestions.xaml"
            this.QuestionTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.AddText);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CorrectAnswerTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\..\View\AdddQuestions.xaml"
            this.CorrectAnswerTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.RemoveText);
            
            #line default
            #line hidden
            
            #line 26 "..\..\..\View\AdddQuestions.xaml"
            this.CorrectAnswerTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.AddText);
            
            #line default
            #line hidden
            return;
            case 3:
            this.WrongAnswer1TextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 29 "..\..\..\View\AdddQuestions.xaml"
            this.WrongAnswer1TextBox.GotFocus += new System.Windows.RoutedEventHandler(this.RemoveText);
            
            #line default
            #line hidden
            
            #line 29 "..\..\..\View\AdddQuestions.xaml"
            this.WrongAnswer1TextBox.LostFocus += new System.Windows.RoutedEventHandler(this.AddText);
            
            #line default
            #line hidden
            return;
            case 4:
            this.WrongAnswer2TextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\..\View\AdddQuestions.xaml"
            this.WrongAnswer2TextBox.GotFocus += new System.Windows.RoutedEventHandler(this.RemoveText);
            
            #line default
            #line hidden
            
            #line 32 "..\..\..\View\AdddQuestions.xaml"
            this.WrongAnswer2TextBox.LostFocus += new System.Windows.RoutedEventHandler(this.AddText);
            
            #line default
            #line hidden
            return;
            case 5:
            this.WrongAnswer3TextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\..\View\AdddQuestions.xaml"
            this.WrongAnswer3TextBox.GotFocus += new System.Windows.RoutedEventHandler(this.RemoveText);
            
            #line default
            #line hidden
            
            #line 35 "..\..\..\View\AdddQuestions.xaml"
            this.WrongAnswer3TextBox.LostFocus += new System.Windows.RoutedEventHandler(this.AddText);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CategoryTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\..\View\AdddQuestions.xaml"
            this.CategoryTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.RemoveText);
            
            #line default
            #line hidden
            
            #line 39 "..\..\..\View\AdddQuestions.xaml"
            this.CategoryTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.AddText);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 40 "..\..\..\View\AdddQuestions.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddQuestionButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 42 "..\..\..\View\AdddQuestions.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GObacktomain);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

