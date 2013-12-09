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
using System.Drawing.Design;
using System.Drawing.Text;
using System.Data;
using System.Windows.Forms;
using System.Reflection;

namespace IC.Controls
{
	public class ListBoxEx : System.Windows.Forms.ListBox
	{
		private int					itemMargin = 0;
		private const int			minHeight = 15;
		private bool				antiAlias = true;
		private Color				selectionColor = Color.RoyalBlue;
		private Color				borderColor = Color.Gray;
		private Color				captionColor = Color.Silver;
		private Font				captionFont;
		private StringFormat		stringFormat = new StringFormat();
		private bool				drawBorder = false;
        private string              captionMember = "";
        private Image               itemImage;

		public ListBoxEx()
		{
			//this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);

			this.DrawMode = DrawMode.OwnerDrawVariable;

			stringFormat = new StringFormat(StringFormatFlags.NoWrap);
			stringFormat.LineAlignment = StringAlignment.Center;
			stringFormat.Trimming = StringTrimming.EllipsisCharacter;

			captionFont = this.Font;
		}

		public bool DrawBorder
		{
			get
			{
				return drawBorder;
			}
			set
			{
				drawBorder = value;
				this.Invalidate();
			}
		}

        [TypeConverter(typeof(ImageConverter)), DefaultValue(typeof(Image), null), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image ItemImage
        {
            get
            {
                return itemImage;
            }
            set
            {
                itemImage = value;

                this.Invalidate();
            }
        }

		public int ItemMargin
		{
			get
			{
				return itemMargin;
			}
			set
			{
				itemMargin = value;

				this.Invalidate();
			}
		}

		public Color CaptionColor
		{
			get
			{
				return captionColor;
			}
			set
			{
				captionColor = value;

				this.Invalidate();
			}
		}

		public Font CaptionFont
		{
			get
			{
				return captionFont;
			}
			set
			{
				captionFont = value;

				this.Invalidate();
			}
		}
			
		public Color BorderColor
		{
			get
			{
				return borderColor;
			}
			set
			{
				borderColor = value;
				this.Invalidate();
			}
		}

		public Color SelectionColor
		{
			get
			{
				return selectionColor;
			}
			set
			{
				selectionColor = value;
				this.Invalidate();
			}
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
				this.Invalidate();
			}
		}

        [Browsable(true), Category("Data"), DefaultValue(""), Editor("System.Windows.Forms.Design.DataMemberListEditor", typeof(System.Drawing.Design.UITypeEditor))]
        public string CaptionMember
        {
            get
            {
                return captionMember;
            }
            set
            {
                captionMember = value;
                this.Invalidate();
            }
        }

		protected override void OnResize(EventArgs e)
		{
			base.OnResize (e);
			this.Invalidate();
		}

		protected override void OnFontChanged(EventArgs e)
		{
			base.OnFontChanged (e);
		}


		private Image GetItemImage(object item)
		{
            Type itemType = item.GetType();

            PropertyInfo propInfo = itemType.GetProperty("Image", typeof(Image));

            if (propInfo == null)
            {
                FieldInfo fieldInfo = itemType.GetField("Image");

                if (fieldInfo != null)
                    return (Image)fieldInfo.GetValue(item);
            }
            else
            {
                return (Image)propInfo.GetValue(item, null);
            }

            return null;
		}

		private string GetItemCaption(object item)
		{
            if (this.CaptionMember != null && this.CaptionMember.Length > 0 && item is System.Data.DataRowView)
            {
                return ((DataRowView)item).Row[this.CaptionMember].ToString();
            }
            else
            {
                Type itemType = item.GetType();

                PropertyInfo propInfo = itemType.GetProperty("Caption", typeof(string));

                if (propInfo == null)
                {
                    FieldInfo fieldInfo = itemType.GetField("Caption");

                    if (fieldInfo != null)
                        return (string)fieldInfo.GetValue(item);
                }
                else
                {
                    return (string)propInfo.GetValue(item, null);
                }
            }

			return "";
		}

		private int GetItemImageIndex(object item)
		{
			Type itemType = item.GetType();

			PropertyInfo propInfo = itemType.GetProperty("ImageIndex", typeof(int));

			if(propInfo == null)
			{
				FieldInfo fieldInfo = itemType.GetField("ImageIndex");

				if(fieldInfo != null)
					return (int)fieldInfo.GetValue(item);
			}
			else
			{
				return (int)propInfo.GetValue(item, null);
			}

			return -1;
		}

        private string GetItemText(object item)
        {
            string itemText = item.ToString();

            if (this.DisplayMember != null && this.DisplayMember.Length > 0 && item is System.Data.DataRowView)
            {
                itemText = ((DataRowView)item).Row[this.DisplayMember].ToString();
            }

            return itemText;
        }

		protected override void OnMeasureItem(MeasureItemEventArgs e)
		{
			if(this.Items.Count > 0)
			{
				e.ItemHeight = MeasureItemHeight(this.Items[e.Index], true);
			}
		}

		private int MeasureItemHeight(object item, bool includeCaption)
		{
			int itemHeight = 0;
			int imageHeight = 0;
			int textHeight = 0;
			
			Image itemImage = GetItemImage(item);

			if(itemImage != null)
				imageHeight = itemImage.Height + (itemMargin * 2);

			using(Graphics g = this.CreateGraphics())
			{
                if(antiAlias)
                    textHeight = (int)g.MeasureString(GetItemText(item), this.Font, 1000, stringFormat).Height + (itemMargin * 2);
                else
                    textHeight = (int)TextRenderer.MeasureText(g, GetItemText(item), this.Font, new Size(1000, 0), TextFormatFlags.VerticalCenter | TextFormatFlags.Left).Height + (itemMargin * 2);
                
			
				itemHeight = Math.Max(Math.Max(imageHeight, textHeight), minHeight);

				if(includeCaption)
				{
					string caption = GetItemCaption(item);

					if(caption.Length > 0)
					{
                        if (antiAlias)
                            itemHeight += (int)g.MeasureString(caption, captionFont, this.Width).Height;
                        else
                            itemHeight += (int)TextRenderer.MeasureText(g, caption, captionFont, new Size(this.Width, 0), TextFormatFlags.Left | TextFormatFlags.WordBreak).Height;
					}
				}
			}

			return itemHeight;
		}

		protected override void OnDrawItem(DrawItemEventArgs e)
		{	
			e.DrawFocusRectangle();
			e.DrawBackground();

			if((e.State & DrawItemState.Selected) == DrawItemState.Selected)
			{
				using(SolidBrush backBrush = new SolidBrush(selectionColor))
				{
					e.Graphics.FillRectangle(backBrush, e.Bounds);
				}
			}

			if(Items.Count > 0 && e.Index >= 0)
			{
				Rectangle stringRect;
				Image itemImage = GetItemImage(Items[e.Index]);
				string caption = GetItemCaption(Items[e.Index]);
				int mainItemHeight = MeasureItemHeight(this.Items[e.Index], false);


                if (itemImage == null)
                    itemImage = this.itemImage;

				if(itemImage != null)
				{	
					Rectangle imageRect = new Rectangle(e.Bounds.Left + itemMargin, e.Bounds.Top + (mainItemHeight - itemImage.Height) / 2, itemImage.Width, itemImage.Height);
					e.Graphics.DrawImage(itemImage, imageRect);	
					
					stringRect = new Rectangle(imageRect.Right + 2, e.Bounds.Top, e.Bounds.Width - imageRect.Right - itemMargin, mainItemHeight);
				}
				else
				{
					stringRect = new Rectangle(e.Bounds.Left + itemMargin, e.Bounds.Top, e.Bounds.Width - itemMargin * 2, mainItemHeight);
				}

				using(SolidBrush textBrush = new SolidBrush(ForeColor))
				{
                    string itemText = Items[e.Index].ToString();

                    if (this.DisplayMember != null && Items[e.Index] is System.Data.DataRowView)
                    {
                        itemText = ((DataRowView)Items[e.Index]).Row[this.DisplayMember].ToString();
                    }

                    if (antiAlias)
                    {
                        e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;

                        e.Graphics.DrawString(GetItemText(Items[e.Index]), e.Font, textBrush, stringRect, stringFormat);
                    }
                    else
                    {
                        e.Graphics.TextRenderingHint = TextRenderingHint.SystemDefault;

                        TextRenderer.DrawText(e.Graphics, GetItemText(Items[e.Index]), e.Font, stringRect, ForeColor, TextFormatFlags.EndEllipsis | TextFormatFlags.SingleLine | TextFormatFlags.VerticalCenter);
                    }
			
					// Draw caption
					if(caption.Length > 0)
					{
						textBrush.Color = captionColor;

						stringRect.Y = stringRect.Bottom - itemMargin;
						stringRect.Height = e.Bounds.Bottom - stringRect.Y - itemMargin;

                        if (antiAlias)
                        {
                            e.Graphics.DrawString(caption, captionFont, textBrush, stringRect);
                        }
                        else
                        {
                            TextRenderer.DrawText(e.Graphics, caption, captionFont, stringRect, captionColor, TextFormatFlags.Left | TextFormatFlags.Top | TextFormatFlags.WordBreak);
                        }
					}
				}
			}

			if(drawBorder)
			{
				using(Pen borderPen = new Pen(borderColor))
				{
					e.Graphics.DrawRectangle(borderPen, 0, 0, this.Width - 1, this.Height - 1);
				}
			}
		}
	}

	public class ListBoxExItem
	{
		private string				text = "";
		private Image				image = null;
		private string				caption = "";
		private object				tag = null;

		public ListBoxExItem()
		{
		}

		public ListBoxExItem(string text)
		{
			this.Text = text;
		}

		public ListBoxExItem(string text, string caption)
		{
			this.Text = text;
			this.Caption = caption;
		}

		public ListBoxExItem(string text, Image image)
		{
			this.Text = text;
			this.Image = image;
		}

        public ListBoxExItem(string text, string caption, Image image)
		{
			this.Text = text;
			this.Image = image;
			this.Caption = caption;
		}

		public override string ToString()
		{
			return this.Text;
		}

		public string Text
		{
			get
			{
				return text;
			}
			set
			{
				text = value;
			}
		}

		public string Caption
		{
			get
			{
				return caption;
			}
			set
			{
				caption = value;
			}
		}

		public Image Image
		{
			get
			{
				return image;
			}
			set
			{
				image = value;
			}
		}

		public object Tag
		{
			get
			{
				return tag;
			}
			set
			{
				tag = value;
			}
		}
	}
}
