///////////////////////////////////////////////////////////////////////////////////////////////
//
//    This File is Part of the CallButler Open Source PBX (http://www.codeplex.com/callbutler
//
//    Copyright (c) 2005-2008, Jim Heising
//    All rights reserved.
//
//    Redistribution and use in source and binary forms, with or without modification,
//    are permitted provided that the following conditions are met:
//
//    * Redistributions of source code must retain the above copyright notice,
//      this list of conditions and the following disclaimer.
//
//    * Redistributions in binary form must reproduce the above copyright notice,
//      this list of conditions and the following disclaimer in the documentation and/or
//      other materials provided with the distribution.
//
//    * Neither the name of Jim Heising nor the names of its contributors may be
//      used to endorse or promote products derived from this software without specific prior
//      written permission.
//
//    THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
//    ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
//    WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
//    IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT,
//    INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT
//    NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR
//    PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY,
//    WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
//    ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
//    POSSIBILITY OF SUCH DAMAGE.
//
///////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace IC.Controls.Popup
{
    /// <summary>
    /// Represents a Windows combo box control which can be used in a popup's content control.
    /// </summary>
    [ToolboxBitmap(typeof(System.Windows.Forms.ComboBox)), ToolboxItem(true), ToolboxItemFilter("System.Windows.Forms"), Description("Displays an editable text box with a drop-down list of permitted values.")]
    public partial class ComboBox : System.Windows.Forms.ComboBox
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Controls.Popup.ComboBox" /> class.
        /// </summary>
        public ComboBox()
        {
            InitializeComponent();
        }

        private static Type _modalMenuFilter;
        private static Type modalMenuFilter
        {
            get
            {
                if (_modalMenuFilter == null)
                {
                    _modalMenuFilter = Type.GetType("System.Windows.Forms.ToolStripManager+ModalMenuFilter");
                }
                if (_modalMenuFilter == null)
                {
                    _modalMenuFilter = new List<Type>(typeof(ToolStripManager).Assembly.GetTypes()).Find(
                    delegate(Type type)
                    {
                        return type.FullName == "System.Windows.Forms.ToolStripManager+ModalMenuFilter";
                    });
                }
                return _modalMenuFilter;
            }
        }

        private static MethodInfo _suspendMenuMode;
        private static MethodInfo suspendMenuMode
        {
            get
            {
                if (_suspendMenuMode == null)
                {
                    Type t = modalMenuFilter;
                    if (t != null)
                    {
                        _suspendMenuMode = t.GetMethod("SuspendMenuMode", BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
                    }
                }
                return _suspendMenuMode;
            }
        }

        private static void SuspendMenuMode()
        {
            MethodInfo suspendMenuMode = ComboBox.suspendMenuMode;
            if (suspendMenuMode != null)
            {
                suspendMenuMode.Invoke(null, null);
            }
        }

        private static MethodInfo _resumeMenuMode;
        private static MethodInfo resumeMenuMode
        {
            get
            {
                if (_resumeMenuMode == null)
                {
                    Type t = modalMenuFilter;
                    if (t != null)
                    {
                        _resumeMenuMode = t.GetMethod("ResumeMenuMode", BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
                    }
                }
                return _resumeMenuMode;
            }
        }

        private static void ResumeMenuMode()
        {
            MethodInfo resumeMenuMode = ComboBox.resumeMenuMode;
            if (resumeMenuMode != null)
            {
                resumeMenuMode.Invoke(null, null);
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.ComboBox.DropDown" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnDropDown(EventArgs e)
        {
            SuspendMenuMode();
            base.OnDropDown(e);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.ComboBox.DropDownClosed" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnDropDownClosed(EventArgs e)
        {
            ResumeMenuMode();
            base.OnDropDownClosed(e);
        }
    }
}
