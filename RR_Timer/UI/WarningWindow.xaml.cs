﻿using System;

namespace RR_Timer.UI
{
    /// <summary>
    /// Interaction logic for WarningWindow.xaml
    /// </summary>
    public partial class WarningWindow
    {
        public const int ApiLinkWarning = 0;
        public const int ListLinkWarning = 1;
        public const int TimeWarning = 2;

        /// <summary>
        /// When one of the constants is passed this constructor will be called
        /// </summary>
        /// <param name="type">Type of message</param>
        public WarningWindow(int type)
        {
            InitializeComponent();
            SetLabel(type);
        }

        /// <summary>
        /// When message is passed, this constructor will be called
        /// </summary>
        /// <param name="message">Message to show as warning</param>
        public WarningWindow(string message)
        {
            InitializeComponent();
            WarningLabel.Content = message;
        }

        /// <summary>
        /// If constant is passed to constructor, this method sets the message to show
        /// </summary>
        /// <param name="type">Type of message</param>
        private void SetLabel(int type)
        {
            WarningLabel.Content = type switch
            {
                0 => "API link was not entered or incorrect!\nClosing the timer window!",
                1 => "List link was not entered or incorrect!\nMaking the timer smaller is now manual",
                2 => "Time was not entered or incorrect!\nClosing the timer window!",
                _ => WarningLabel.Content
            };
        }

        private void CloseWindow(object sender, EventArgs e)
        {
            Close();
        }
    }
}