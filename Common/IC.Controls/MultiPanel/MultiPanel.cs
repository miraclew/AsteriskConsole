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

namespace IC.Controls.MultiPanel
{
	/// <summary>
	/// A MultiPanel is the control added to a form to provide a step by step functionality.
	/// It contains <see cref="MultiPanelPage"/>s in the <see cref="Pages"/> collection, which
	/// are containers for other controls. Only one MultiPanel page is shown at a time in the client
	/// are of the MultiPanel.
	/// </summary>
	[Designer(typeof(Controls.MultiPanel.MultiPanelDesigner))]
	[ToolboxItem(true)]
	[ToolboxBitmap(typeof(Controls.MultiPanel.MultiPanel))]
	public class MultiPanel : System.Windows.Forms.UserControl
    {
        public event EventHandler PageChanged;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		/// <summary>
		/// MultiPanel control with designer support
		/// </summary>
		public MultiPanel()
		{
			//Empty collection of Pages
			vPages = new PageCollection(this);

			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
		}

		private void MultiPanel_Load(object sender, System.EventArgs e)
		{
            /*if (DesignMode)
            {
                Padding padding = new Padding(10);
                this.Padding = padding;
            }*/

			//Attempt to activate a page
			//ActivatePage(0);
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
            this.SuspendLayout();
            // 
            // MultiPanel
            // 
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MultiPanel";
            this.Size = new System.Drawing.Size(444, 272);
            this.Load += new System.EventHandler(this.MultiPanel_Load);
            this.ResumeLayout(false);

		}
		#endregion

		private PageCollection vPages;
		/// <summary>
		/// Returns the collection of Pages in the MultiPanel
		/// </summary>
		[Category("MultiPanel")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public PageCollection Pages
		{
			get
			{
				return vPages;
			}
		}

		private MultiPanelPage vActivePage = null;
		/// <summary>
		/// Gets/Sets the activePage in the MultiPanel
		/// </summary>
		[Category("MultiPanel")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
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
					ActivatePage(-1);
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
				ActivatePage(value);
			}
		}

		protected internal void ActivatePage(int index)
		{
            //If the new page is invalid
            if (index < 0 || index >= vPages.Count)
            {
                return;
            }

			//Change to the new Page
			MultiPanelPage tWizPage = ((MultiPanelPage) vPages[index]);

			//Really activate the page
			ActivatePage(tWizPage);
		}

		protected internal void ActivatePage(MultiPanelPage page)
		{
			//Deactivate the current
			if (vActivePage != null)
			{
				vActivePage.Visible = false;
			}

			//Activate the new page
			vActivePage = page;

			if (vActivePage != null)
			{
				//Ensure that this panel displays inside the MultiPanel
				vActivePage.Parent = this;
				if (this.Contains(vActivePage) == false)
				{	
					this.Container.Add(vActivePage);
				}

                //if (DesignMode && vActivePage.BackColor == SystemColors.Control)
                //    vActivePage.BackColor = Color.FromArgb(this.Parent.BackColor.ToArgb());

				//Make it fill the space
				vActivePage.Dock = DockStyle.Fill;
				vActivePage.Visible = true;
				vActivePage.BringToFront();
				//vActivePage.FocusFirstTabIndex();
			}
			
			//Cause a refresh
			if (vActivePage != null)
				vActivePage.Invalidate();
			else
				this.Invalidate();

            if (PageChanged != null)
                PageChanged(this, EventArgs.Empty);
		}

		/*protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint (e);

			if (DesignMode)
			{
                using (Pen borderPen = new Pen(Color.DarkGray, 10))
                {
                    e.Graphics.Clear(this.BackColor);

                    e.Graphics.DrawRectangle(borderPen, 0, 0, this.Width, this.Height);
                }
			}
		}*/

		protected override void OnResize(EventArgs e)
		{
			base.OnResize (e);

			if (DesignMode)
			{
				this.Invalidate();
			}
		}
	}
}