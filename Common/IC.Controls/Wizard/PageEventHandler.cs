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

namespace IC.Controls.Wizard
{
	/// <summary>
	/// Delegate definition for handling NextPageEvents
	/// </summary>
	public delegate void PageEventHandler(object sender, PageEventArgs e);

	/// <summary>
	/// Arguments passed to an application when Page is closed in a wizard. The Next page to be displayed 
	/// can be changed, by the application, by setting the NextPage to a wizardPage which is part of the 
	/// wizard that generated this event.
	/// </summary>
	public class PageEventArgs : EventArgs
	{
		private int vPage;
		private PageCollection vPages;
        private bool cancel = false;
		/// <summary>
		/// Constructs a new event
		/// </summary>
		/// <param name="index">The index of the next page in the collection</param>
		/// <param name="pages">Pages in the wizard that are acceptable to be </param>
		public PageEventArgs(int index, PageCollection pages) : base()
		{
			vPage = index;
			vPages = pages;
		}

		/// <summary>
		/// Gets/Sets the wizard page that will be displayed next. If you set this it must be to a wizardPage from the wizard.
		/// </summary>
		public WizardPage Page
		{
			get
			{
				//Is this a valid page
				if (vPage >=0 && vPage <vPages.Count)
					return vPages[vPage];
				return null;
			}
			set
			{
				if (vPages.Contains(value) == true)
				{
					//If this is a valid page then set it
					vPage = vPages.IndexOf(value);
				}
				else
				{
					throw new ArgumentOutOfRangeException("NextPage",value,"The page you tried to set was not found in the wizard.");
				}
			}
		}


		/// <summary>
		/// Gets the index of the page 
		/// </summary>
		public int PageIndex
		{
			get
			{
				return vPage;
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
