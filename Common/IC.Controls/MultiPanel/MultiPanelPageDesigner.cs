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
using System.Windows.Forms.Design;
using System.ComponentModel.Design;


namespace IC.Controls.MultiPanel
{
	/// <summary>
	/// Summary description for MultiPanelPageDesigner.
	/// </summary>
	public class MultiPanelPageDesigner : ParentControlDesigner
	{
	
	
		public override DesignerVerbCollection Verbs
		{
			get
			{
				DesignerVerbCollection verbs = new DesignerVerbCollection();

                MultiPanelPage page = this.Control as MultiPanelPage;

                if (page.Parent is MultiPanel)
                {
                    MultiPanel wiz = page.Parent as MultiPanel;

                    if (wiz.PageIndex < wiz.Pages.Count - 1)
                    {
                        verbs.Add(new DesignerVerb("Next Page >", new EventHandler(handleNextPage)));
                    }

                    if (wiz.Pages.Count > 0 && wiz.PageIndex > 0)
                    {
                        verbs.Add(new DesignerVerb("< Previous Page", new EventHandler(handlePrevPage)));
                    }
                }

                verbs.Add(new DesignerVerb("Select Parent Container", new EventHandler(selectParentContainer)));
				verbs.Add(new DesignerVerb("Remove Page", new EventHandler(handleRemovePage)));

				return verbs;
			}
		}

        private void selectParentContainer(object sender, EventArgs e)
        {
            MultiPanelPage page = this.Control as MultiPanelPage;

            page.Parent.Select();
            /*if (page.Parent is MultiPanel)
            {
                MultiPanel wiz = page.Parent as MultiPanel;

                wiz.PageIndex--;
            }*/
        }

        private void handlePrevPage(object sender, EventArgs e)
        {
            MultiPanelPage page = this.Control as MultiPanelPage;

            if (page.Parent is MultiPanel)
            {
                MultiPanel wiz = page.Parent as MultiPanel;

                wiz.PageIndex--;
            }
        }

        private void handleNextPage(object sender, EventArgs e)
        {
            MultiPanelPage page = this.Control as MultiPanelPage;

            if (page.Parent is MultiPanel)
            {
                MultiPanel wiz = page.Parent as MultiPanel;

                wiz.PageIndex++;
            }
        }

		private void handleRemovePage(object sender, EventArgs e)
		{			
			MultiPanelPage page = this.Control as MultiPanelPage;

			IDesignerHost h  = (IDesignerHost) GetService(typeof(IDesignerHost));
			IComponentChangeService c = (IComponentChangeService) GetService(typeof (IComponentChangeService));

			DesignerTransaction dt = h.CreateTransaction("Remove Page");
			
			if (page.Parent is MultiPanel)
			{
				MultiPanel wiz = page.Parent as MultiPanel;

				c.OnComponentChanging(wiz, null);
				//Drop from MultiPanel
				wiz.Pages.Remove(page);
				wiz.Controls.Remove(page);
				c.OnComponentChanged(wiz, null, null, null);
				h.DestroyComponent(page);
			}
			else
			{
				c.OnComponentChanging(page, null);
				//Mark for destruction
				page.Dispose();
				c.OnComponentChanged(page, null, null, null);
			}
			dt.Commit();
		}

	}
}
