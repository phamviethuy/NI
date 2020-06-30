using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.Snippets
{
    /// <summary>
    /// This class corresponds to the base WindowsForms.ControlBase class, which is the base 
    /// National Instruments control class.
    /// </summary>
    public class SnipsControlBase : SnipsControl
    {
        private ControlBase baseControl;        
        
        /// <summary>
        /// Public constructor taking a reference to the control being
        /// created by one of the parent classes.
        /// </summary>
        /// <param name="control">The control being created by a parent class</param>
        public SnipsControlBase(ControlBase control)
            : base (control)
        {
            baseControl = control;            
        }

        #region Code Snippets for NationalInstruments.UI.WindowsForms.ControlBase

        /// <summary>
        /// Draws the control with the specified ComponentDrawArgs. It is 
        /// implemented in the ControlBase class. 
        /// </summary>
        /// <signature>Draw(ComponentDrawArgs)</signature>
        /// <ExampleMethod />
        [EventBased("Paint", "Invalidate")]
        public void Draw_ComponentDrawArgs(object sender, PaintEventArgs e)
        {
            // The following example demonstrates drawing a control to a .png image
            // in response to the Paint event.
            string imageFileName = "ControlImage.png";
            using (Bitmap bmp = new Bitmap(baseControl.Width, baseControl.Height))
            {
                Graphics g = Graphics.FromImage(bmp);
                ComponentDrawArgs args = new ComponentDrawArgs(g, new Rectangle(0, 0, bmp.Width, bmp.Height));

                baseControl.Draw(args);                
                bmp.Save(imageFileName, ImageFormat.Png);
            }
            Debug.WriteLine(string.Format("file {0} has been saved", imageFileName));
        }

        /// <summary>
        /// Copies a bitmap image of the control to the clipboard with a 
        /// specified size.  It is implemented in the ControlBase class.
        /// To run this method, you must first click the run snippet button.  
        /// Then, you must click on the control, and then press Ctrl+C.
        /// An image of the control will be copied to the clipboard.
        /// </summary>
        /// <signature>ToClipboard(Size)</signature>
        /// <ExampleMethod />
        [EventBased("KeyDown")]
        public void ToClipboard_Size(object sender, KeyEventArgs e)
        {
            // The following example demonstrates placing a bitmap image of a control
            // onto the clipboard in response to a user pressing ctrl+c while the 
            // the control has focus

            // copy the control to the clipboard when ctrl+c is pressed
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.C)
                baseControl.ToClipboard(new Size (baseControl.Width, baseControl.Height));
        }

        /// <summary>
        /// Writes an image of the control to a file with a specified size.   
        /// It is implemented in the ControlBase class.  To run this method, 
        /// you must first click the run snippet button.  Then, you must 
        /// click on the control, and then press Ctrl+S.  An image of the 
        /// control will be saved as ToFileImage.png.
        /// </summary>
        /// <signature>ToFile(string, ImageType, Size)</signature>
        /// <ExampleMethod />
        [EventBased("KeyDown")]
        public void ToFile_String_ImageType_Size(object sender, KeyEventArgs e)
        {
            // The following example demonstrates writing the control to a .png file
            // in response to a user pressing ctrl+s while the control has focus.

            // copy the control to the clipboard when ctrl+s is pressed
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.S)
                baseControl.ToFile("ToFileImage.png", ImageType.Png, new Size (baseControl.Width, baseControl.Height));
        }

        /// <summary>
        /// Copies a bitmap image of the control to the clipboard with a 
        /// specified size.  It is implemented in the ControlBase class.
        /// To run this method, you must first click the run snippet button.  
        /// Then, you must click on the control, and then press Ctrl+S.
        /// An image of the control will be saved as FlippedImage.png.
        /// </summary>
        /// <signature>ToImage(Size)</signature>
        /// <ExampleMethod />
        [EventBased("KeyDown")]
        public void ToImage_Size(object sender, KeyEventArgs e)
        {
            // The following example demonstrates getting an image object from 
            // a control, manipulating it, and then saving it to a .png file in 
            // response to a user pressing ctrl+s while the control has focus.

            // rotate and save the control when ctrl+s is pressed
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.S)
            {
                // get the controls image, then rotates it 90 degrees
                Image image = baseControl.ToImage(new Size(baseControl.Width, baseControl.Height));
                image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                image.Save("FlippedImage.png", ImageFormat.Png);
            }
        }

        /// <summary>
        /// Writes an image of the control to a stream with a specified size.
        /// It is implemented in the ControlBase class.  To run this method, you 
        /// must first click the run snippet button.  Then, you must click on 
        /// the control, and then press Ctrl+S.  The image will be saved to a file
        /// named ImageFromStream.png.
        /// </summary>
        /// <signature>ToStream(Stream, ImageType, Size)</signature>
        /// <ExampleMethod />
        [EventBased("KeyDown")]
        public void ToStream_Stream_ImageType_Size(object sender, KeyEventArgs e)
        { 
            // The following example demonstrates writing a control to a Stream object 
            // and then saving that stream as a .png image in response to a user pressing
            // ctrl + s while the control has focus.

            // save the control from a stream when ctrl+s is pressed
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.S)
            {
                FileStream imageStream = new FileStream("ImageFromStream.png", FileMode.Create);
                // writes the control's image to a stream
                baseControl.ToStream(imageStream, ImageType.Png, new Size(baseControl.Width, baseControl.Height));
                imageStream.Dispose();
            }
        }

        #endregion
    }
}
