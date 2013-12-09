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
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;

namespace IC.Controls.Wizard
{
    public enum WizardTabDividerLineType
    {
        None,
        SingleLine,
        Cutout
    }

	/// <summary>
	/// A wizard is the control added to a form to provide a step by step functionality.
	/// It contains <see cref="WizardPage"/>s in the <see cref="Pages"/> collection, which
	/// are containers for other controls. Only one wizard page is shown at a time in the client
	/// are of the wizard.
	/// </summary>
	[Designer(typeof(Controls.Wizard.WizardDesigner))]
	[ToolboxItem(true)]
	[ToolboxBitmap(typeof(Controls.Wizard.Wizard))]
	public class Wizard : System.Windows.Forms.UserControl
	{
        public event EventHandler<PageChangedEventArgs> BeforePageChanged;
        public event EventHandler PageChanged;
        public event EventHandler<PageChangedEventArgs> WizardFinished;

		protected internal System.Windows.Forms.Panel pnlButtons;
		private System.Windows.Forms.Panel pnlButtonBright3d;
		private System.Windows.Forms.Panel pnlButtonDark3d;
		protected internal System.Windows.Forms.Button btnBack;
		protected internal System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnCancel;
        private bool closeOnFinish = true;
        private bool closeOnCancel = true;
        private bool displayButtons = true;
        private bool alwaysShowFinishButton = false;
        private WizardTabDividerLineType dividerLineType = WizardTabDividerLineType.SingleLine;
        private Panel pnlTabs;
        private int tabWidth = 50;
        private Panel pnlNext;
        private Panel pnlFinish;
        protected internal Button btnFinish;
        private Panel pnlCancel;
        private Panel pnlBack;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		/// <summary>
		/// Wizard control with designer support
		/// </summary>
		public Wizard()
		{
			//Empty collection of Pages
			vPages = new PageCollection(this);

			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
		}

		private void Wizard_Load(object sender, System.EventArgs e)
		{
			//Attempt to activate a page
			ActivatePage(PageIndex,false);

			//Can I add my self as default cancel button
			Form form = this.FindForm();
			if (form != null && DesignMode == false)
				form.CancelButton = btnCancel;
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing ) 
		{
			if( disposing ) 
			{         
				if(components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}


		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlBack = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlNext = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.pnlFinish = new System.Windows.Forms.Panel();
            this.btnFinish = new System.Windows.Forms.Button();
            this.pnlCancel = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlButtonBright3d = new System.Windows.Forms.Panel();
            this.pnlButtonDark3d = new System.Windows.Forms.Panel();
            this.pnlTabs = new System.Windows.Forms.Panel();
            this.pnlButtons.SuspendLayout();
            this.pnlBack.SuspendLayout();
            this.pnlNext.SuspendLayout();
            this.pnlFinish.SuspendLayout();
            this.pnlCancel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.pnlBack);
            this.pnlButtons.Controls.Add(this.pnlNext);
            this.pnlButtons.Controls.Add(this.pnlFinish);
            this.pnlButtons.Controls.Add(this.pnlCancel);
            this.pnlButtons.Controls.Add(this.pnlButtonBright3d);
            this.pnlButtons.Controls.Add(this.pnlButtonDark3d);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(100, 224);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(344, 48);
            this.pnlButtons.TabIndex = 0;
            // 
            // pnlBack
            // 
            this.pnlBack.Controls.Add(this.btnBack);
            this.pnlBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBack.Location = new System.Drawing.Point(6, 2);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(79, 46);
            this.pnlBack.TabIndex = 9;
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBack.Location = new System.Drawing.Point(1, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "< &Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBack_MouseDown);
            // 
            // pnlNext
            // 
            this.pnlNext.Controls.Add(this.btnNext);
            this.pnlNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlNext.Location = new System.Drawing.Point(85, 2);
            this.pnlNext.Name = "pnlNext";
            this.pnlNext.Size = new System.Drawing.Size(87, 46);
            this.pnlNext.TabIndex = 7;
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNext.Location = new System.Drawing.Point(3, 10);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "&Next >";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnNext_MouseDown);
            // 
            // pnlFinish
            // 
            this.pnlFinish.Controls.Add(this.btnFinish);
            this.pnlFinish.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlFinish.Location = new System.Drawing.Point(172, 2);
            this.pnlFinish.Name = "pnlFinish";
            this.pnlFinish.Size = new System.Drawing.Size(81, 46);
            this.pnlFinish.TabIndex = 8;
            this.pnlFinish.Visible = false;
            // 
            // btnFinish
            // 
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFinish.Location = new System.Drawing.Point(3, 10);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 4;
            this.btnFinish.Text = "&Finish";
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // pnlCancel
            // 
            this.pnlCancel.Controls.Add(this.btnCancel);
            this.pnlCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCancel.Location = new System.Drawing.Point(253, 2);
            this.pnlCancel.Name = "pnlCancel";
            this.pnlCancel.Size = new System.Drawing.Size(91, 46);
            this.pnlCancel.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Location = new System.Drawing.Point(3, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlButtonBright3d
            // 
            this.pnlButtonBright3d.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlButtonBright3d.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtonBright3d.Location = new System.Drawing.Point(0, 1);
            this.pnlButtonBright3d.Name = "pnlButtonBright3d";
            this.pnlButtonBright3d.Size = new System.Drawing.Size(344, 1);
            this.pnlButtonBright3d.TabIndex = 1;
            // 
            // pnlButtonDark3d
            // 
            this.pnlButtonDark3d.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlButtonDark3d.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtonDark3d.Location = new System.Drawing.Point(0, 0);
            this.pnlButtonDark3d.Name = "pnlButtonDark3d";
            this.pnlButtonDark3d.Size = new System.Drawing.Size(344, 1);
            this.pnlButtonDark3d.TabIndex = 2;
            // 
            // pnlTabs
            // 
            this.pnlTabs.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTabs.Location = new System.Drawing.Point(0, 0);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.pnlTabs.Size = new System.Drawing.Size(100, 272);
            this.pnlTabs.TabIndex = 1;
            this.pnlTabs.Visible = false;
            this.pnlTabs.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTabs_Paint);
            // 
            // Wizard
            // 
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlTabs);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Wizard";
            this.Size = new System.Drawing.Size(444, 272);
            this.Load += new System.EventHandler(this.Wizard_Load);
            this.pnlButtons.ResumeLayout(false);
            this.pnlBack.ResumeLayout(false);
            this.pnlNext.ResumeLayout(false);
            this.pnlFinish.ResumeLayout(false);
            this.pnlCancel.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private PageCollection vPages;
		/// <summary>
		/// Returns the collection of Pages in the wizard
		/// </summary>
		[Category("Wizard")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public PageCollection Pages
		{
			get
			{
				return vPages;
			}
		}

        internal Panel TabPanel
        {
            get
            {
                return pnlTabs;
            }
        }

        public bool AlwaysShowFinishButton
        {
            get
            {
                return alwaysShowFinishButton;
            }
            set
            {
                alwaysShowFinishButton = value;
                pnlFinish.Visible = value;
            }
        }

        public WizardTabDividerLineType TabDividerLineType
        {
            get
            {
                return dividerLineType;
            }
            set
            {
                dividerLineType = value;
                pnlTabs.Invalidate();
            }
        }

		private WizardPage vActivePage = null;
		/// <summary>
		/// Gets/Sets the activePage in the wizard
		/// </summary>
		[Category("Wizard")]
		public int PageIndex
		{
			get
			{
				return vPages.IndexOf(vActivePage);
			}
			set
			{
				//Do I have any pages?
				if(vPages.Count == 0)
				{
					//No then show nothing
					ActivatePage(-1,false);
					return;
				}
				// Validate the page asked for
				if (value < -1 || value >= vPages.Count)
				{
					throw new ArgumentOutOfRangeException("PageIndex",
						value,
						"The page index must be between 0 and "+Convert.ToString(vPages.Count-1)
						);
				}
				//Select the new page
                if (this.PageIndex > value)
                {
                    ActivatePage(value, true);
                }
                else
                {
                    ActivatePage(value, false);
                }
			}
		}

		/// <summary>
		/// Alternative way of getting/Setiing  the current page by using wizardPage objects
		/// </summary>
		public WizardPage Page
		{
			get
			{
				return vActivePage;
			}
			//Dont use this anymore, see Next, Back, NextTo and BackTo
//			set
//			{
//				ActivatePage(value);
//			}
		}

        public bool ShowTabs
        {
            get
            {
                return pnlTabs.Visible;
            }
            set
            {
                pnlTabs.Visible = value;
            }
        }

        [Localizable(true)]
        public int TabPanelWidth
        {
            get
            {
                return pnlTabs.Width;
            }
            set
            {
                pnlTabs.Width = value;
                UpdateTabPanelSize();
            }
        }

        [Localizable(true)]
        public int TabWidth
        {
            get
            {
                return tabWidth;
            }
            set
            {
                tabWidth = value;
                UpdateTabPanelSize();
            }
        }

        [Localizable(true)]
        public int TablPanelTopMargin
        {
            get
            {
                return pnlTabs.Padding.Top;
            }
            set
            {
                pnlTabs.Padding = new Padding(pnlTabs.Padding.Left, value, pnlTabs.Padding.Right, pnlTabs.Padding.Bottom);
            }
        }

        private void UpdateTabPanelSize()
        {
            pnlTabs.Padding = new Padding(TabPanelWidth - tabWidth, pnlTabs.Padding.Top, pnlTabs.Padding.Right, pnlTabs.Padding.Bottom);
        }

        public Color TabBackColor
        {
            get
            {
                return pnlTabs.BackColor;
            }
            set
            {
                pnlTabs.BackColor = value;
            }
        }

        [TypeConverter(typeof(ImageConverter)), DefaultValue(typeof(Image), null), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image TabBackgroundImage
        {
            get
            {
                return pnlTabs.BackgroundImage;
            }
            set
            {
                pnlTabs.BackgroundImage = value;
            }
        }

        public ImageLayout TabBackgroundImageLayout
        {
            get
            {
                return pnlTabs.BackgroundImageLayout;
            }
            set
            {
                pnlTabs.BackgroundImageLayout = value;
            }
        }

        public bool CloseOnFinish
        {
            get
            {
                return closeOnFinish;
            }
            set
            {
                closeOnFinish = value;
            }
        }

        public bool DisplayButtons
        {
            get
            {
                return displayButtons;
            }
            set
            {
                displayButtons = value;

                if (!DesignMode)
                {
                    pnlButtons.Visible = value;
                }
            }
        }

        public bool CloseOnCancel
        {
            get
            {
                return closeOnCancel;
            }
            set
            {
                closeOnCancel = value;
            }
        }

		protected internal void ActivatePage(int index,  bool backButtonPressed)
		{
			//If the new page is invalid
            if (index < 0 || index >= vPages.Count)
            {
                btnNext.Enabled = false;
                btnBack.Enabled = false;

                return;
            }

			//Change to the new Page
			WizardPage tWizPage = ((WizardPage) vPages[index]);

			//Really activate the page
			ActivatePage(tWizPage, backButtonPressed);
		}

		protected internal void ActivatePage(WizardPage page, bool backButtonPressed)
		{
            if (BeforePageChanged != null)
            {
                PageChangedEventArgs barg = new PageChangedEventArgs(backButtonPressed);
                BeforePageChanged(this, barg);

                if (barg.Cancel)
                {
                    return;
                }
            }

            // Update the background colors of the tabs
            Color nonSelectedColor = Color.FromArgb((int)(page.BackColor.R * 0.95f), (int)(page.BackColor.G * 0.95f), (int)(page.BackColor.B * 0.95f));

            foreach (WizardPage wizPage in vPages)
            {
                if (wizPage == page)
                {
                    wizPage.PageTabControl.TabPanel.PanelColor = page.BackColor;
                    wizPage.PageTabControl.Padding = new Padding(0, 0, 0, 3);
                    wizPage.PageTabControl.TabPanel.Selected = true;
                }
                else
                {
                    wizPage.PageTabControl.TabPanel.PanelColor = nonSelectedColor;
                    wizPage.PageTabControl.Padding = new Padding(5, 0, 0, 3);
                    wizPage.PageTabControl.TabPanel.Selected = false;
                }
            }

			//Deactivate the current
			if (vActivePage != null)
			{
				vActivePage.Visible = false;
			}

			//Activate the new page
			vActivePage = page;

			if (vActivePage != null)
			{
				//Ensure that this panel displays inside the wizard
				vActivePage.Parent = this;
				if (this.Contains(vActivePage) == false)
				{	
					this.Container.Add(vActivePage);
				}
				//Make it fill the space
				vActivePage.Dock = DockStyle.Fill;
				vActivePage.Visible = true;
				vActivePage.BringToFront();
			}
			
			//What should the back button say
			if (this.PageIndex > 0)
			{
				btnBack.Enabled = true;
			}
			else
			{
				btnBack.Enabled = false;
			}

			//What should the Next button say
			if (vPages.IndexOf(vActivePage) < vPages.Count-1 && vActivePage.IsFinishPage == false)
			{
                btnNext.Enabled = true;
                pnlNext.Visible = true;

				//Don't close the wizard :)
				btnNext.DialogResult = DialogResult.None;

                if (alwaysShowFinishButton)
                    pnlFinish.Visible = true;
                else
                    pnlFinish.Visible = false;
			}
			else
			{
                pnlFinish.Visible = true;

                if (alwaysShowFinishButton)
                {
                    btnNext.Enabled = false;
                }
                else
                {
                    pnlNext.Visible = false;
                }

				//btnNext.Text = "Fi&nish";
				//Dont allow a finish in designer
				/*if (DesignMode == true
					&& vPages.IndexOf(vActivePage) == vPages.Count-1)
				{
					btnNext.Enabled = false;
				}*/
				//else
				//{
					//btnNext.Enabled = true;
					//If Not in design mode then allow a close
					btnNext.DialogResult = DialogResult.OK;
				//}

                
			}
			
			//Cause a refresh
			if (vActivePage != null)
				vActivePage.Invalidate();
			else
				this.Invalidate();

            if (PageChanged != null)
                PageChanged(this, EventArgs.Empty);
		}
	

		private void btnNext_Click(object sender, System.EventArgs e)
		{
			Next();
		}
	
		private void btnNext_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (DesignMode == true)
				Next();
		}

		private void btnBack_Click(object sender, System.EventArgs e)
		{
			Back();
		}
		
		private void btnBack_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (DesignMode == true)
				Back();
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			CancelEventArgs arg = new CancelEventArgs();

			//Throw the event out to subscribers
			if (CloseFromCancel != null)
			{
				CloseFromCancel(this, arg);
			}
			//If nobody told me to cancel
			if (arg.Cancel == false && closeOnCancel)
			{
				//Then we close the form
				this.FindForm().Close();
			}
		}

		/// <summary>
		/// Gets/Sets the enabled state of the Next button. 
		/// </summary>
		[Category("Wizard")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool NextEnabled
		{
			get
			{
				return btnNext.Enabled;
			}
			set
			{
				btnNext.Enabled = value;
			}
		}
		/// <summary>
		/// Gets/Sets the enabled state of the back button. 
		/// </summary>
		[Category("Wizard")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool BackEnabled
		{
			get
			{
				return btnBack.Enabled;
			}
			set
			{
				btnBack.Enabled = value;
			}
		}
		/// <summary>
		/// Gets/Sets the enabled state of the cancel button. 
		/// </summary>
		[Category("Wizard")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool CancelEnabled
		{
			get
			{
				return btnCancel.Enabled;
			}
			set
			{
		
				btnCancel.Enabled = value;
			}
		}


		/// <summary>
		/// Called when the cancel button is pressed, before the form is closed. Set e.Cancel to true if 
		/// you do not wish the cancel to close the wizard.
		/// </summary>
		public event CancelEventHandler CloseFromCancel;


		/// <summary>
		/// Closes the current page after a <see cref="WizardPage.CloseFromNext"/>, then moves to 
		/// the Next page and calls <see cref="WizardPage.ShowFromNext"/>
		/// </summary>
		public void Next()
		{
			Debug.Assert(this.PageIndex >=0,"Page Index was below 0");
			//Tell the Application I just closed a Page
			int newPage = vActivePage.OnCloseFromNext(this);

			//Did I just press Finish instead of Next
			if (this.PageIndex <vPages.Count -1
				&& (vActivePage.IsFinishPage == false || DesignMode == true))
			{
				//No still going
				ActivatePage(newPage,false);
				//Tell the application, I have just shown a page
				vActivePage.OnShowFromNext(this);
			}
			/*else
			{
				Debug.Assert(this.PageIndex < vPages.Count, "Error I've just gone past the finish",
					"btnNext_Click tried to go to page "+Convert.ToString(this.PageIndex+1)
					+", but I only have "+Convert.ToString(vPages.Count));

                if (WizardFinished != null)
                    WizardFinished(this, EventArgs.Empty);

				//yep Finish was pressed
				if (DesignMode == false && closeOnFinish)
					this.ParentForm.Close();
			}*/
		}

		/// <summary>
		/// Moves to the page given and calls <see cref="WizardPage.ShowFromNext"/>
		/// </summary>
		/// <remarks>Does NOT call <see cref="WizardPage.CloseFromNext"/> on the current page</remarks>
		/// <param name="page"></param>
		public void NextTo(WizardPage page)
		{
			//Since we have a page to go to, then there is no need to validate most of it
			ActivatePage(page, false);
			//Tell the application, I have just shown a page
			vActivePage.OnShowFromNext(this);
		}

		/// <summary>
		/// Closes the current page after a <see cref="WizardPage.CloseFromBack"/>, then moves to 
		/// the previous page and calls <see cref="WizardPage.ShowFromBack"/>
		/// </summary>
		public void Back()
		{
			Debug.Assert(this.PageIndex <vPages.Count,"Page Index was beyond Maximum pages");
			//Can I press back
			Debug.Assert(this.PageIndex>0 && this.PageIndex < vPages.Count,"Attempted to go back to a page that doesn't exist");
			//Tell the application that I closed a page
			int newPage = vActivePage.OnCloseFromBack(this);

			ActivatePage(newPage,true);
			//Tell the application I have shown a page
			vActivePage.OnShowFromBack(this);
		}

		/// <summary>
		/// Moves to the page given and calls <see cref="WizardPage.ShowFromBack"/>
		/// </summary>
		/// <remarks>Does NOT call <see cref="WizardPage.CloseFromBack"/> on the current page</remarks>
		/// <param name="page"></param>
		public void BackTo(WizardPage page)
		{
			//Since we have a page to go to, then there is no need to validate most of it
			ActivatePage(page,true);
			//Tell the application, I have just shown a page
			vActivePage.OnShowFromNext(this);
		}

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                
                if (WizardFinished != null)
                {
                    PageChangedEventArgs args = new PageChangedEventArgs(false);
                    WizardFinished(this, args);
                    if (args.Cancel)
                    {
                        return;
                    }

                }

                //yep Finish was pressed
                if (DesignMode == false && closeOnFinish)
                {
                    this.btnFinish.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.ParentForm.DialogResult = DialogResult.OK;
                    this.ParentForm.Close();
                }
            }
        }

        private void pnlTabs_Paint(object sender, PaintEventArgs e)
        {
            // Draw a divider line to the right of the tab
            if (ShowTabs)
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                switch (dividerLineType)
                {
                    case WizardTabDividerLineType.Cutout:
                        {
                            if (pnlTabs.Controls.Count > 0)
                            {
                                using (SolidBrush brush = new SolidBrush(pnlButtonDark3d.BackColor))
                                {
                                    e.Graphics.FillEllipse(brush, Rectangle.FromLTRB(pnlTabs.Width - 7, pnlTabs.Controls[pnlTabs.Controls.Count - 1].Top - 10, pnlTabs.Width + 7, pnlTabs.Controls[0].Bottom + 10));
                                }
                            }
                            break;
                        }
                    case WizardTabDividerLineType.SingleLine:
                        using (Pen linePen = new Pen(pnlButtonDark3d.BackColor))
                        {
                            e.Graphics.DrawLine(linePen, pnlTabs.Width - 1, 0, pnlTabs.Width - 1, this.Height);
                        }

                        break;
                }
            }
        }

#if DEBUG
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint (e);

			if (DesignMode && Pages.Count == 0)
			{
				const string noPagesText = "No wizard pages inside the wizard.";

				
				SizeF textSize = e.Graphics.MeasureString(noPagesText, this.Font);
				RectangleF layout = new RectangleF( (this.Width- textSize.Width)/2,
					(this.pnlButtons.Top-textSize.Height)/2,
					textSize.Width, textSize.Height);
		
				Pen dashPen = (Pen) SystemPens.GrayText.Clone();
				dashPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

				e.Graphics.DrawRectangle(dashPen,
					this.Left+8, this.Top+8, 
					this.Width-17, this.pnlButtons.Top-17);

				e.Graphics.DrawString(noPagesText,this.Font,new SolidBrush(SystemColors.GrayText) ,layout);	
			}
		}
		protected override void OnResize(EventArgs e)
		{
			base.OnResize (e);

			if (DesignMode)
			{
				this.Invalidate();
			}
		}
#endif


	}

    public class PageChangedEventArgs : System.EventArgs
    {
        bool cancel;

        bool backButtonPressed;

        public PageChangedEventArgs(bool backButtonPressed)
        {
            this.backButtonPressed = backButtonPressed;
        }

        public bool BackButtonPressed
        {
            get
            {
                return this.backButtonPressed;
            }
        }

        public bool Cancel
        {
            get
            {
                return cancel;
            }
            set
            {
                cancel = value;
            }

        }

    }
}