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
using System.Windows.Forms;

namespace IC.Controls.Wizard
{
	/// <summary>
	/// Summary description for PanelCollection.
	/// </summary>
	public class PageCollection : CollectionBase
	{
		private Wizard vParent;
		/// <summary>
		/// Constructor requires the  wizard that owns this collection
		/// </summary>
		/// <param name="parent">Wizard</param>
		public PageCollection(Wizard parent):base()
		{
			vParent = parent;
		}

		/// <summary>
		/// Returns the wizard that owns this collection
		/// </summary>
		public Wizard Parent
		{
			get 
			{
				return vParent;
			}
		}

		/// <summary>
		/// Finds the Page in the collection
		/// </summary>
		public WizardPage this[ int index ]  
		{
			get  
			{
				return( (WizardPage) List[index] );
			}
			set  
			{
				List[index] = value;
			}
		}


		/// <summary>
		/// Adds a WizardPage into the Collection
		/// </summary>
		/// <param name="value">The page to add</param>
		/// <returns></returns>
		public int Add(WizardPage value )  
		{		
			int result = List.Add( value );

			return result;
		}


		/// <summary>
		/// Adds an array of pages into the collection. Used by the Studio Designer generated coed
		/// </summary>
		/// <param name="pages">Array of pages to add</param>
		public void AddRange(WizardPage[] pages)
		{
			// Use external to validate and add each entry
			foreach(WizardPage page in pages)
			{
				this.Add(page);
			}
		}

		/// <summary>
		/// Finds the position of the page in the colleciton
		/// </summary>
		/// <param name="value">Page to find position of</param>
		/// <returns>Index of Page in collection</returns>
		public int IndexOf( WizardPage value )  
		{
			return( List.IndexOf( value ) );
		}

		/// <summary>
		/// Adds a new page at a particular position in the Collection
		/// </summary>
		/// <param name="index">Position</param>
		/// <param name="value">Page to be added</param>
		public void Insert( int index, WizardPage value )  
		{
			List.Insert(index, value );
		}


		/// <summary>
		/// Removes the given page from the collection
		/// </summary>
		/// <param name="value">Page to remove</param>
		public void Remove( WizardPage value )  
		{
			//Remove the item
			List.Remove( value );
		}

		/// <summary>
		/// Detects if a given Page is in the Collection
		/// </summary>
		/// <param name="value">Page to find</param>
		/// <returns></returns>
		public bool Contains( WizardPage value )  
		{
			// If value is not of type Int16, this will return false.
			return( List.Contains( value ) );
		}

		/// <summary>
		/// Propgate when a external designer modifies the pages
		/// </summary>
		/// <param name="index"></param>
		/// <param name="value"></param>
		protected override void OnInsertComplete(int index, object value)
		{
			base.OnInsertComplete (index, value);

            WizardPage page = (WizardPage)value;

            page.PageTabControl.Dock = DockStyle.Top;
            vParent.TabPanel.Controls.Add(page.PageTabControl);
            vParent.TabPanel.Controls.SetChildIndex(page.PageTabControl, 0);

            page.PageTabControl.TabLinkButton.ForeColor = vParent.ForeColor;
            page.PageTabControl.TabLinkButton.Font = vParent.Font;
            page.PageTabControl.TabLinkButton.Tag = index;
            page.PageTabControl.TabLinkButton.Click += new EventHandler(TabLinkButton_Click);

            page.PageTabControl.Show();

			//Showthe page added
			vParent.PageIndex = index;
		}

        void TabLinkButton_Click(object sender, EventArgs e)
        {
            vParent.PageIndex = (int)((Control)sender).Tag;
        }
	
		/// <summary>
		/// Propogates when external designers remove items from page
		/// </summary>
		/// <param name="index"></param>
		/// <param name="value"></param>
		protected override void OnRemoveComplete(int index, object value)
		{
			base.OnRemoveComplete (index, value);

            WizardPage page = (WizardPage)value;
            vParent.TabPanel.Controls.Remove(page.PageTabControl);

			//If the page that was added was the one that was visible
			if (vParent.PageIndex == index)
			{
				//Can I show the one after
				if (index < InnerList.Count)
				{
					vParent.PageIndex = index;
				}
				else
				{
					//Can I show the end one (if not -1 makes everythign disappear
					vParent.PageIndex = InnerList.Count-1;
				}
			}
		}

	}
}
