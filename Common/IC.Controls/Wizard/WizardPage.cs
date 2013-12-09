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
using System.Windows.Forms;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Diagnostics;

namespace IC.Controls.Wizard
{
	/// <summary>
	/// 
	/// </summary>
	[Designer(typeof(Controls.Wizard.WizardPageDesigner))]
	public class WizardPage : Panel
	{
        private string text = "";
        private WizardPageTabControl tabControl;
        private Color tabLinkColor = Color.FromArgb(83, 83, 83);

		/// <summary>
		/// Event called before this page is closed when the back button is pressed. If you don't want to show pageIndex -1 then
		/// set page to be the new page that you wish to show
		/// </summary>
		public event PageEventHandler CloseFromBack;
		/// <summary>
		/// Event called before this page is closed when the next button is pressed. If you don't want to show pageIndex -1 then
		/// set page to be the new page that you wish to show 
		/// </summary>
		public event PageEventHandler CloseFromNext;
		/// <summary>
		/// Event called after this page is shown when the back button is pressed.
		/// </summary>
		public event EventHandler ShowFromBack;
		/// <summary>
		/// Event called after this page is shown when the next button is pressed. 
		/// </summary>
		public event EventHandler ShowFromNext;

        public WizardPage()
        {
            tabControl = new WizardPageTabControl();
        }

		/// <summary>
		/// Fires the CloseFromBack Event
		/// </summary>
		/// <param name="wiz">Wizard to pass into the sender argument</param>
		/// <returns>Index of Page that the event handlers would like to see next</returns>
		public int OnCloseFromBack(Wizard wiz)
		{
            int newPageIndex = wiz.PageIndex - 1;

            // Skip disabled pages
            while (newPageIndex >= 0 && !wiz.Pages[newPageIndex].Enabled)
            {
                newPageIndex--;
            }

			//Event args thinks that the next pgae will be the one before this one
			PageEventArgs e = new PageEventArgs(newPageIndex, wiz.Pages);

			//Tell anybody who listens
			if (CloseFromBack != null)
				CloseFromBack(wiz, e);

            if (e.Cancel)
                return wiz.PageIndex;
            else
			    return e.PageIndex;
		}

		/// <summary>
		/// Fires the CloseFromNextEvent
		/// </summary>
		/// <param name="wiz">Sender</param>
		public int OnCloseFromNext(Wizard wiz)
		{
            int newPageIndex = wiz.PageIndex + 1;

            // Skip disabled pages
            while (newPageIndex < wiz.Pages.Count && !wiz.Pages[newPageIndex].Enabled)
            {
                newPageIndex++;
            }

			//Event args thinks that the next pgae will be the one before this one
			PageEventArgs e = new PageEventArgs(newPageIndex, wiz.Pages);
			//Tell anybody who listens
			if (CloseFromNext != null)
				CloseFromNext(wiz, e);

			//And then tell whomever called me what the prefered page is
            if (e.Cancel)
                return wiz.PageIndex;
            else
                return e.PageIndex;
		}
		
		/// <summary>
		/// Fires the showFromBack event
		/// </summary>
		/// <param name="wiz">sender</param>
		public void OnShowFromBack(Wizard wiz)
		{
			if (ShowFromBack != null)
				ShowFromBack(wiz, EventArgs.Empty);
		}

		/// <summary>
		/// Fires the showFromNext event
		/// </summary>
		/// <param name="wiz">Sender</param>
		public void OnShowFromNext(Wizard wiz)
		{
			if (ShowFromNext != null)
				ShowFromNext(wiz, EventArgs.Empty);
		}

        [Browsable(true)]
        [Localizable(true)]
        public override string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
                tabControl.TabLinkButton.Text = text;
            }
        }

        public Color TabLinkColor
        {
            get
            {
                return tabLinkColor;
            }
            set
            {
                tabLinkColor = value;
                tabControl.TabLinkButton.ForeColor = value;
            }
        }

        [TypeConverter(typeof(ImageConverter)), DefaultValue(typeof(Image), null), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public System.Drawing.Image Icon
        {
            get
            {
                return tabControl.TabLinkButton.LinkImage;
            }
            set
            {
                tabControl.TabLinkButton.LinkImage = value;
            }
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);

            tabControl.TabPanel.Parent.Visible = this.Enabled;
        }
        
		[Category("Wizard")]
		public bool IsFinishPage
		{
			get
			{
				return _IsFinishPage;
			}
			set
			{
				_IsFinishPage=value;
			}
		}
		private bool _IsFinishPage = false;
	
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing"></param>

		protected override void Dispose( bool disposing ) 
		{
			if( disposing ) 
			{
//				//Unregister callbacks
//				ClearChangeNotifications();      
			}
			base.Dispose( disposing );
		}

        internal WizardPageTabControl PageTabControl
        {
            get
            {
                return tabControl;
            }
        }

		/// <summary>
		/// Set the focus to the contained control with a lowest tabIndex
		/// </summary>
		public void FocusFirstTabIndex()
		{
			//Activate the first control in the Panel
			Control found = null;
			//find the control with the lowest 
			foreach (Control control in this.Controls)
			{
				if (control.CanFocus && (found == null || control.TabIndex < found.TabIndex))
				{
					found = control;
				}
			}
			//Have we actually found anything
			if (found != null)
			{
				//Focus the found control
				found.Focus();
			}
			else
			{
				//Just focus the wizard Page
				this.Focus();
			}
		}

	}
}