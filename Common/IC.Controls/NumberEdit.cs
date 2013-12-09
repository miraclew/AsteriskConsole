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
using System.Drawing.Text;
using System.Drawing.Drawing2D;
using System.Data;
using System.Windows.Forms;

namespace IC.Controls
{
	/// <summary>
	/// Summary description for NumberEdit.
	/// </summary>
	public class NumberEdit : System.Windows.Forms.UserControl
	{
		public event EventHandler		ValueChanged;

		private const int				upDownColumnWidth = 10;
				
		private int						intValue = 0;
		private int						maxValue = 100;
		private int						minValue = 0;
		private bool					antiAlias = true;
		private int						columnWidth = 0;
		private int						selectedColumn = -1;
		private Color					selectedColumnColor = Color.LightSteelBlue;

		private bool					upButton = false;
		private bool					downButton = false;

		private StringFormat			stringFormat;
		private System.Windows.Forms.Panel pnlButtons;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public NumberEdit()
		{
			this.SetStyle(ControlStyles.ResizeRedraw | ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.Selectable, true);

			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Center;
			stringFormat.LineAlignment = StringAlignment.Center;

			CalculateColumnWidth();
		}

		public Color SelectionColor
		{
			get
			{
				return selectedColumnColor;
			}
			set
			{
				selectedColumnColor = value;
				Redraw();
			}
		}

		public int MaxValue
		{
			get
			{
				return maxValue;
			}
			set
			{
				maxValue = value;
			}
		}

		public int MinValue
		{
			get
			{
				return minValue;
			}
			set
			{
				minValue = value;
			}
		}
			
		public int Value
		{
			get
			{
				return intValue;
			}
			set
			{

				if(value > maxValue)
					intValue = maxValue;
				else if(value < minValue)
					intValue = minValue;
				else
					intValue = value;

				Redraw();
			}
		}

		private void SetValue(int newValue)
		{
			this.Value = newValue;

			if(ValueChanged != null)
				ValueChanged(this, new EventArgs());
		}

		public bool AntiAliasText
		{
			get
			{
				return antiAlias;
			}
			set
			{
				antiAlias = value;
				Redraw();
			}
		}

		private void Redraw()
		{
			this.Invalidate();
		}

		private void CalculateColumnWidth()
		{
			using(Graphics g = this.CreateGraphics())
			{
				columnWidth = (int)g.MeasureString("0", this.Font).Width;
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			string valueString = intValue.ToString();

			if(antiAlias)
				e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;

			if(selectedColumn >= 0 && this.Focused)
			{
				using(SolidBrush selectionBrush = new SolidBrush(selectedColumnColor))
				{
					Rectangle selectRect = new Rectangle(selectedColumn * columnWidth, 0, columnWidth, this.Height);
					e.Graphics.FillRectangle(selectionBrush, selectRect);
				}
			}
			
			using(SolidBrush stringBrush = new SolidBrush(this.ForeColor))
			{
				for(int index = 0; index < valueString.Length; index++)
				{
					Rectangle stringRect = new Rectangle(index * columnWidth, 0, columnWidth, this.Height);

					e.Graphics.DrawString(valueString[index].ToString(), this.Font, stringBrush, stringRect, stringFormat);
				}
			}
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
			this.SuspendLayout();
			// 
			// pnlButtons
			// 
			this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlButtons.Location = new System.Drawing.Point(264, 0);
			this.pnlButtons.Name = "pnlButtons";
			this.pnlButtons.Size = new System.Drawing.Size(16, 16);
			this.pnlButtons.TabIndex = 0;
			this.pnlButtons.Resize += new System.EventHandler(this.pnlButtons_Resize);
			this.pnlButtons.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlButtons_MouseUp);
			this.pnlButtons.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlButtons_Paint);
			this.pnlButtons.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlButtons_MouseDown);
			// 
			// NumberEdit
			// 
			this.Controls.Add(this.pnlButtons);
			this.Name = "NumberEdit";
			this.Size = new System.Drawing.Size(280, 16);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberEdit_KeyPress);
			this.Enter += new System.EventHandler(this.NumberEdit_Enter);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumberEdit_KeyDown);
			this.Leave += new System.EventHandler(this.NumberEdit_Leave);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NumberEdit_MouseDown);
			this.ResumeLayout(false);

		}
		#endregion

		private void NumberEdit_Enter(object sender, System.EventArgs e)
		{
			Redraw();
		}

		private void NumberEdit_Leave(object sender, System.EventArgs e)
		{
			Redraw();
		}

		private void SetStringValue(string strValue)
		{
			try
			{
				if(strValue.Length == 0)
					SetValue(0);
				else
					SetValue(Convert.ToInt32(strValue));
			}
			catch
			{
			}
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if(keyData == Keys.Left)
			{
				if(selectedColumn > 0)
					selectedColumn--;

				Redraw();

				return true;
			}
			else if(keyData == Keys.Right)
			{
				if(selectedColumn < intValue.ToString().Length)
					selectedColumn++;

				Redraw();

				return true;
			}
			else if(keyData == Keys.Up || keyData == Keys.Down)
			{
				string numberString = intValue.ToString();

				if(selectedColumn >= 0)
				{
					char columnChar = '0';

					if(selectedColumn < numberString.Length)
						columnChar = numberString[selectedColumn];
					else
					{
						numberString += "0";
					}

					if(Char.IsNumber(columnChar))
					{
						int newValue = Convert.ToInt32(columnChar.ToString());

						if(keyData == Keys.Up)
							newValue++;
						else
							newValue--;

						if(newValue > 9)
							newValue = 0;
						else if(newValue < 0)
							newValue = 9;

						numberString = numberString.Remove(selectedColumn, 1);
						numberString = numberString.Insert(selectedColumn, newValue.ToString());

						SetStringValue(numberString);
					}
				}

				return true;
			}
			else
				return base.ProcessCmdKey(ref msg, keyData);			
		}

		private void NumberEdit_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(Char.IsNumber(e.KeyChar) || e.KeyChar == '-')
			{
				string numberString = intValue.ToString();
				
				if(selectedColumn >= 0)
				{
					if(selectedColumn > numberString.Length - 1)
						numberString += e.KeyChar;
					else
					{
						numberString = numberString.Remove(selectedColumn, 1);
						numberString = numberString.Insert(selectedColumn, e.KeyChar.ToString());
					}
				}

				SetStringValue(numberString);

				if(numberString[0] != '0' && selectedColumn + 1 <= intValue.ToString().Length)
					selectedColumn++;

			}
			// Backspace key
			else if(e.KeyChar == 8)
			{
				if(selectedColumn >= 1)
				{
					string numberString = intValue.ToString();

					if(selectedColumn == 0)
						numberString = numberString.Remove(0, 1);
					else
						numberString = numberString.Remove(selectedColumn - 1, 1);

					SetStringValue(numberString);
					selectedColumn--;

					Redraw();
				}
			}
		}

		protected override void OnFontChanged(EventArgs e)
		{
			CalculateColumnWidth();
			base.OnFontChanged (e);
		}


		private void NumberEdit_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			// Find the right column
			int column = e.X / columnWidth;

			string numberString = intValue.ToString();

			if(column > numberString.Length - 1)
				column = numberString.Length;
			
			selectedColumn = column;

			Redraw();
		}

		private void NumberEdit_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Delete)
			{
				string numberString = intValue.ToString();

				if(selectedColumn >= 0 && selectedColumn < numberString.Length)
				{
					numberString = numberString.Remove(selectedColumn, 1);

					SetStringValue(numberString);
				}
			}
		}

		private void pnlButtons_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			e.Graphics.Clear(this.BackColor);

			e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

			if(upButton)
				ControlPaint.DrawScrollButton(e.Graphics, 0, 0, pnlButtons.Width, pnlButtons.Height / 2, ScrollButton.Up, ButtonState.Pushed);
			else
				ControlPaint.DrawScrollButton(e.Graphics, 0, 0, pnlButtons.Width, pnlButtons.Height / 2, ScrollButton.Up, ButtonState.Normal);

			if(downButton)
				ControlPaint.DrawScrollButton(e.Graphics, 0, pnlButtons.Height / 2, pnlButtons.Width, pnlButtons.Height / 2, ScrollButton.Down, ButtonState.Pushed);
			else
				ControlPaint.DrawScrollButton(e.Graphics, 0, pnlButtons.Height / 2, pnlButtons.Width, pnlButtons.Height / 2, ScrollButton.Down, ButtonState.Normal);
		}

		private void pnlButtons_Resize(object sender, System.EventArgs e)
		{
			pnlButtons.Invalidate();
		}

		private void pnlButtons_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			selectedColumn = -1;

			if(e.Y <= this.Height / 2)
			{
				upButton = true;
				SetValue(this.Value + 1);
			}
			else
			{
				downButton = true;
				SetValue(this.Value - 1);
			}

			pnlButtons.Invalidate();
		}

		private void pnlButtons_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			upButton = false;
			downButton = false;

			pnlButtons.Invalidate();
		}
	}
}
