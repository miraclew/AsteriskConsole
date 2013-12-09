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
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace IC.Controls
{
  public delegate void TriggerCharacterEventHandler(object sender, TriggerCharacterEventArgs e);

	public class IntelliTextBox : RichTextBoxEx
	{
        const short WM_PAINT = 0x00f;
        public static bool _Paint = true;

		public event TriggerCharacterEventHandler	TriggerCharacterEntered;

		private ListBoxEx						listBox;
		private char[]							triggerChars;
        private System.Collections.Generic.Dictionary<char, Color> triggerColors;
		private int								startSelectionPos = -1;
		private char							startChar = '\0';
        private Popup.Popup                     popupWindow;
        private string                          triggerCharsString = "";

		public IntelliTextBox()
		{
            triggerColors = new System.Collections.Generic.Dictionary<char, Color>();

            this.TextChanged += new EventHandler(IntelliTextBox_TextChanged);
			this.KeyPress += new KeyPressEventHandler(IntelliTextBox_KeyPress);
			this.MouseDown += new MouseEventHandler(IntelliTextBox_MouseDown);
			this.Leave += new EventHandler(IntelliTextBox_Leave);

			listBox = new ListBoxEx();
			listBox.ItemMargin = 2;
            listBox.Width = 200;
			listBox.AntiAliasText = false;
			listBox.BorderStyle = BorderStyle.FixedSingle;
			listBox.Click += new EventHandler(listBox_Click);
            listBox.Visible = false;

            popupWindow = new Controls.Popup.Popup(listBox);
            popupWindow.AutoClose = false;
            popupWindow.AcceptAlt = false;
            popupWindow.FocusOnOpen = false;
            popupWindow.Visible = false;
            popupWindow.Close();
		}

        void IntelliTextBox_TextChanged(object sender, EventArgs e)
        {
            HighlightSyntax(true);
        }

        public void RedrawSyntaxHighlighting()
        {
            HighlightSyntax(false);
        }

        protected override void OnParentVisibleChanged(EventArgs e)
        {
            if (this.Parent.Visible)
            {
                HighlightSyntax(false);
            }

            base.OnParentVisibleChanged(e);
        }

        private void HighlightSyntax(bool currentLineOnly)
        {
            if (this.Text.Length > 0 && _Paint)
            {
                _Paint = false;

                if (triggerCharsString.Length == 0)
                    return;

                int start = 0;
                int end = 0;

                if (currentLineOnly)
                {
                    for (start = this.SelectionStart - 1; start > 0; start--)
                    {
                        if (this.Text[start] == '\n')
                        {
                            start++;
                            break;
                        }
                    }

                    if (start < 0)
                        start = 0;

                    for (end = this.SelectionStart; end < this.Text.Length; end++)
                    {
                        if (this.Text[end] == '\n')
                            break;
                    }
                }
                else
                {
                    start = 0;
                    end = this.Text.Length;

                    if (end < 0)
                        end = 0;
                }

                string line = this.Text.Substring(start, end - start);

                int tmpSelStart = this.SelectionStart;
                int tmpSelLength = this.SelectionLength;

                // Change the whole line to our original color
                this.SelectionStart = start;
                this.SelectionLength = end - start;
                this.SelectionColor = this.ForeColor;

                // Find our code pieces
                System.Text.RegularExpressions.MatchCollection matches = System.Text.RegularExpressions.Regex.Matches(line, string.Format("[{0}].+?[{0}]", triggerCharsString));

                foreach (System.Text.RegularExpressions.Match match in matches)
                {
                    char triggerChar = match.Value[0];

                    if (triggerColors.ContainsKey(triggerChar))
                    {
                        this.SelectionStart = start + match.Index;
                        this.SelectionLength = match.Length;
                        this.SelectionColor = triggerColors[triggerChar];
                    }
                }

                this.SelectionStart = tmpSelStart;
                this.SelectionLength = tmpSelLength;
                this.SelectionColor = this.ForeColor;

                _Paint = true;
            }
        }

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            if (m.Msg == WM_PAINT)
            {
                if (_Paint) base.WndProc(ref m);
                else
                    m.Result = IntPtr.Zero;
            }
            else
                base.WndProc(ref m);
        }

        protected override void Dispose(bool disposing)
        {
            popupWindow.Dispose();
            listBox.Click -= new EventHandler(listBox_Click);
            listBox.Dispose();

            base.Dispose(disposing);
        }

		protected override void OnCreateControl()
		{
            try
            {
                if (!DesignMode)
                {
                    this.TopLevelControl.Controls.Add(listBox);

                    HideListBox();
                }
            }
            catch
            {
            }

			base.OnCreateControl();
		}

		public char[] TriggerCharacters
		{
			get
			{
				return triggerChars;
			}
			set
			{
				triggerChars = value;

                triggerCharsString = "";

                if (triggerChars != null)
                {
                    foreach (char triggerChar in triggerChars)
                    {
                        triggerCharsString += triggerChar + ",";
                    }

                    triggerCharsString = triggerCharsString.Trim(',');
                }
			}
		}

        public void SetTriggerSyntaxColor(char triggerChar, Color color)
        {
            triggerColors[triggerChar] = color;
        }

		private bool IsTriggerCharacter(char inputChar)
		{
			if(triggerChars != null)
			{
				for(int index = 0; index < triggerChars.Length; index++)
				{
					if(triggerChars[index] == inputChar)
						return true;
				}
			}

			return false;
		}

		private void ShowListBox()
		{
			startSelectionPos = this.SelectionStart;

			Point point = this.GetPositionFromCharIndex(startSelectionPos);
			point.Y += (int) Math.Ceiling(this.Font.GetHeight()) + 2;

            popupWindow.Show(this, point);
            this.Focus();
		}

		private void HideListBox()
		{
			startSelectionPos = -1;
			startChar = '\0';
            popupWindow.Close();
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if(popupWindow.Visible && listBox.Items.Count > 0)
			{
				if(keyData == Keys.Up)
				{
					if(listBox.SelectedIndex <= 0)
						listBox.SelectedIndex = listBox.Items.Count - 1;
					else
						listBox.SelectedIndex--;

					return true;
				}
				else if(keyData == Keys.Down)
				{
					if(listBox.SelectedIndex >= listBox.Items.Count - 1)
						listBox.SelectedIndex = 0;
					else
						listBox.SelectedIndex++;

					return true;
				}
			}

			return base.ProcessCmdKey (ref msg, keyData);
		}

		private void IntelliTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(!DesignMode)
			{
				if(IsTriggerCharacter(e.KeyChar))
				{
					int charCount = FindCharacterCount(this.Text.Substring(0, this.SelectionStart), e.KeyChar);

                    if (!popupWindow.Visible && charCount % 2 == 0)
					{
						startChar = e.KeyChar;
						listBox.Items.Clear();

						if(TriggerCharacterEntered != null)
						{
							TriggerCharacterEntered(this, new TriggerCharacterEventArgs(e.KeyChar, listBox));
						}
						
						if(listBox.Items.Count > 0)
							ShowListBox();
					}
					else if(e.KeyChar == startChar)
					{	
						HideListBox();
					}
				}
				else if(e.KeyChar == ' ')
				{
					if(this.SelectionStart == startSelectionPos + 1)
						HideListBox();
				}
				else if((int)e.KeyChar == 8)
				{
					if(this.SelectionStart <= startSelectionPos)
						HideListBox();
                    else if (popupWindow.Visible)
						FindListBoxSelection(this.Text.Substring(startSelectionPos + 1, this.SelectionStart - startSelectionPos - 1) + e.KeyChar);
				}
				else if((int)e.KeyChar == 13)
				{
                    if (popupWindow.Visible)
					{
						ProcessListBoxSelection();
					}
					else
					{
						HideListBox();
					}

					e.Handled = true;
				}
                else if (popupWindow.Visible)
				{
					FindListBoxSelection(this.Text.Substring(startSelectionPos + 1, this.SelectionStart - startSelectionPos - 1) + e.KeyChar);
				}
			}
		}

		private void IntelliTextBox_MouseDown(object sender, MouseEventArgs e)
		{
			HideListBox();
		}

		private void listBox_Click(object sender, EventArgs e)
		{
			ProcessListBoxSelection();
		}

		private int FindCharacterCount(string inputString, char charToFind)
		{
			int charCount = 0;

			for(int index = 0; index < inputString.Length; index++)
			{
				if(inputString[index] == charToFind)
					charCount++;
			}

			return charCount;
		}

		private void FindListBoxSelection(string inputString)
		{
			for(int index = 0; index < listBox.Items.Count; index++)
			{
				if(listBox.Items[index].ToString().ToUpper().StartsWith(inputString.ToUpper()))
				{
					listBox.SelectedIndex = index;
					return;
				}
			}
		}

		private void ProcessListBoxSelection()
		{
            try
            {
                if (listBox.SelectedItem != null)
                {
                    string newText = this.Text.Remove(startSelectionPos, this.SelectionStart - startSelectionPos);
                    newText = newText.Insert(startSelectionPos, startChar + listBox.SelectedItem.ToString() + startChar);

                    this.Text = newText;

                    this.SelectionStart = startSelectionPos + listBox.SelectedItem.ToString().Length + 2;
                }
            }
            catch
            {
            }

			HideListBox();
		}

		private void IntelliTextBox_Leave(object sender, EventArgs e)
		{
			if(!listBox.Focused)
				HideListBox();
		}

	}

  public class TriggerCharacterEventArgs : EventArgs
  {
    public char TriggerCharacter;
    public ListBoxEx ListBox;

    public TriggerCharacterEventArgs(char triggerChar, ListBoxEx listBox)
    {
      TriggerCharacter = triggerChar;
      ListBox = listBox;
    }
  }
}
