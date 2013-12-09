using System;
using System.ComponentModel;
using System.Drawing;

namespace VisualAsterisk.Manager.Controls
{
    /// <summary>
    /// A custom windows control to display text vertically
    /// </summary>
    [ToolboxBitmap(typeof(VerticalLabel), "VerticalLabel.ico")]
    public class VerticalLabel : System.Windows.Forms.Control
    {
        private string labelText;
        private DrawMode _dm = DrawMode.BottomUp;

        private System.ComponentModel.Container components = new System.ComponentModel.Container();

        /// <summary>
        /// VerticalLabel constructor
        /// </summary>
        public VerticalLabel()
        {
            base.CreateControl();
            InitializeComponent();
        }

        /// <summary>
        /// Dispose override method
        /// </summary>
        /// <param Name="disposing">boolean parameter</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (!((components == null)))
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.Size = new System.Drawing.Size(24, 100);
        }

        /// <summary>
        /// OnPaint override. This is where the text is rendered vertically.
        /// </summary>
        /// <param Name="e">PaintEventArgs</param>
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            float vlblControlWidth;
            float vlblControlHeight;
            float vlblTransformX;
            float vlblTransformY;
            Color controlBackColor = BackColor;
            Pen labelBorderPen = new Pen(controlBackColor, 0);
            SolidBrush labelBackColorBrush = new SolidBrush(controlBackColor);
            SolidBrush labelForeColorBrush = new SolidBrush(base.ForeColor);
            base.OnPaint(e);
            vlblControlWidth = this.Size.Width;
            vlblControlHeight = this.Size.Height;
            e.Graphics.DrawRectangle(labelBorderPen, 0, 0, vlblControlWidth, vlblControlHeight);
            e.Graphics.FillRectangle(labelBackColorBrush, 0, 0, vlblControlWidth, vlblControlHeight);
            
            
            if (this.TextDrawMode == DrawMode.BottomUp)
            {
                vlblTransformX = 0;
                vlblTransformY = vlblControlHeight;
                e.Graphics.TranslateTransform(vlblTransformX, vlblTransformY);
                e.Graphics.RotateTransform(270);
                e.Graphics.DrawString(labelText, Font, labelForeColorBrush, 0, 0);
            }
            else
            {
                vlblTransformX = vlblControlWidth;
                vlblTransformY = vlblControlHeight;
                e.Graphics.TranslateTransform(vlblControlWidth, 0);
                e.Graphics.RotateTransform(90);
                e.Graphics.DrawString(labelText, Font, labelForeColorBrush, 0, 0, StringFormat.GenericTypographic);
            }
        }

        private void VerticalTextBox_Resize(object sender, System.EventArgs e)
        {
            Invalidate();
        }

        /// <summary>
        /// The text to be displayed in the control
        /// </summary>
        [Category("VerticalLabel"), Description("Text is displayed vertically in container.")]
        public override string Text
        {
            get
            {
                return labelText;
            }
            set
            {
                labelText = value;
                Invalidate();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Category("Properties"), Description("Whether the text will be drawn from Bottom or from Top.")]
        public DrawMode TextDrawMode
        {
            get { return _dm; }
            set { _dm = value; }
        }
    }
    /// <summary>
    /// Text Drawing Mode
    /// </summary>
    public enum DrawMode{
        /// <summary>
        /// Text is drawn from bottom - up
        /// </summary>
        BottomUp = 1,
        /// <summary>
        /// Text is drawn from top to bottom
        /// </summary>
        TopBottom
    }
}
