Imports System.IO
Imports NationalInstruments.UI.WindowsForms
Imports System.Drawing.Imaging

''' <summary>
''' This is the base Snips class.  All other Snips classes derive 
''' from this class.
''' </summary>
Public Class SnipsControlBase
    Inherits SnipsControl
    Private baseControl As ControlBase

    ''' <summary>
    ''' Public constructor taking a reference to the control being
    ''' created by one of the parent classes.
    ''' </summary>
    ''' <param name="control">The control being created by a parent class</param>
    Public Sub New(ByVal control As ControlBase)
        MyBase.New(control)
        baseControl = control
    End Sub

#Region "Code Snippets for NationalInstruments.UI.WindowsForms.ControlBase"

    ''' <summary>
    ''' Draws the control with the specified ComponentDrawArgs. It is 
    ''' implemented in the ControlBase class. 
    ''' </summary>
    ''' <signature>Draw(ComponentDrawArgs)</signature>
    ''' <ExampleMethod />
    <EventBased("Paint", "Invalidate")> _
    Public Sub Draw_ComponentDrawArgs(ByVal sender As Object, ByVal e As PaintEventArgs)
        ' The following example demonstrates drawing a control to a .png image
        ' in response to the Paint event.
        Dim imageFileName As String = "ControlImage.png"
        Using bmp As New Bitmap(baseControl.Width, baseControl.Height)
            Dim g As Graphics = Graphics.FromImage(bmp)
            Dim args As New ComponentDrawArgs(g, New Rectangle(0, 0, bmp.Width, bmp.Height))

            baseControl.Draw(args)
            bmp.Save(imageFileName, ImageFormat.Png)
        End Using
        Debug.WriteLine(String.Format("file {0} has been saved", imageFileName))
    End Sub

    ''' <summary>
    ''' Copies a bitmap image of the control to the clipboard with a 
    ''' specified size.  It is implemented in the ControlBase class.
    ''' To run this method, you must first click the run snippet button.  
    ''' Then, you must click on the control, and then press Ctrl+C.
    ''' An image of the control will be copied to the clipboard.
    ''' </summary>
    ''' <signature>ToClipboard(Size)</signature>
    ''' <ExampleMethod />
    <EventBased("KeyDown")> _
    Public Sub ToClipboard_Size(ByVal sender As Object, ByVal e As KeyEventArgs)
        ' The following example demonstrates placing a bitmap image of a control
        ' onto the clipboard in response to a user pressing ctrl+c while the 
        ' the control has focus

        ' copy the control to the clipboard when ctrl+c is pressed
        If Control.ModifierKeys = Keys.Control AndAlso e.KeyCode = Keys.C Then
            baseControl.ToClipboard(New Size(baseControl.Width, baseControl.Height))
        End If
    End Sub

    ''' <summary>
    ''' Writes an image of the control to a file with a specified size.   
    ''' It is implemented in the ControlBase class.  To run this method, 
    ''' you must first click the run snippet button.  Then, you must 
    ''' click on the control, and then press Ctrl+S.  An image of the 
    ''' control will be saved as ToFileImage.png.
    ''' </summary>
    ''' <signature>ToFile(String, ImageType, Size)</signature>
    ''' <ExampleMethod />
    <EventBased("KeyDown")> _
    Public Sub ToFile_String_ImageType_Size(ByVal sender As Object, ByVal e As KeyEventArgs)
        ' The following example demonstrates writing the control to a .png file
        ' in response to a user pressing ctrl+s while the control has focus.

        ' copy the control to the clipboard when ctrl+s is pressed
        If Control.ModifierKeys = Keys.Control AndAlso e.KeyCode = Keys.S Then
            baseControl.ToFile("ToFileImage.png", ImageType.Png, New Size(baseControl.Width, baseControl.Height))
        End If
    End Sub

    ''' <summary>
    ''' Copies a bitmap image of the control to the clipboard with a 
    ''' specified size.  It is implemented in the ControlBase class.
    ''' To run this method, you must first click the run snippet button.  
    ''' Then, you must click on the control, and then press Ctrl+S.
    ''' An image of the control will be saved as FlippedImage.png.
    ''' </summary>
    ''' <signature>ToImage(Size)</signature>
    ''' <ExampleMethod />
    <EventBased("KeyDown")> _
    Public Sub ToImage_Size(ByVal sender As Object, ByVal e As KeyEventArgs)
        ' The following example demonstrates getting an image object from 
        ' a control, manipulating it, and then saving it to a .png file in 
        ' response to a user pressing ctrl+s while the control has focus.

        ' rotate and save the control when ctrl+s is pressed
        If Control.ModifierKeys = Keys.Control AndAlso e.KeyCode = Keys.S Then
            ' get the controls image, then rotates it 90 degrees
            Dim image As Image = baseControl.ToImage(New Size(baseControl.Width, baseControl.Height))
            image.RotateFlip(RotateFlipType.Rotate90FlipNone)
            image.Save("FlippedImage.png", ImageFormat.Png)
        End If
    End Sub

    ''' <summary>
    ''' Writes an image of the control to a stream with a specified size.
    ''' It is implemented in the ControlBase class.  To run this method, you 
    ''' must first click the run snippet button.  Then, you must click on 
    ''' the control, and then press Ctrl+S.  The image will be saved to a file
    ''' named ImageFromStream.png.
    ''' </summary>
    ''' <signature>ToStream(Stream, ImageType, Size)</signature>
    ''' <ExampleMethod />
    <EventBased("KeyDown")> _
    Public Sub ToStream_Stream_ImageType_Size(ByVal sender As Object, ByVal e As KeyEventArgs)
        ' The following example demonstrates writing a control to a Stream object 
        ' and then saving that stream as a .png image in response to a user pressing
        ' ctrl + s while the control has focus.

        ' save the control from a stream when ctrl+s is pressed
        If Control.ModifierKeys = Keys.Control AndAlso e.KeyCode = Keys.S Then
            Dim imageStream As New FileStream("ImageFromStream.png", FileMode.Create)
            ' writes the control's image to a stream
            baseControl.ToStream(imageStream, ImageType.Png, New Size(baseControl.Width, baseControl.Height))
            imageStream.Dispose()
        End If
    End Sub

#End Region
End Class
