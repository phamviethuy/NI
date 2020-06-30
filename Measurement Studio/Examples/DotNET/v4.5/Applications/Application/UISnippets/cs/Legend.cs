using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.Snippets
{
    class SnipsLegend : SnipsControlBase
    {
        private Legend legend;

        public SnipsLegend(Legend Legend)
            : base (Legend)
        {
            legend = Legend;            
        }

        #region code snippets for NationalInstruments.UI.WindowsForms.Legend

        /// <summary>
        /// Returns a LegendHitTestInfo that specifies where on the control the given
        /// point is located.  It is implemented in the Legend class. To run this method,
        /// you must first click the run snippet button, and then click somewhere inside 
        /// the legend area. 
        /// </summary>
        /// <signature>HitTest(int, int)</signature>
        /// <OtherMethods>
        /// Legend.GetItemAt(int, int)
        /// </OtherMethods>
        /// <ExampleMethod />
        [EventBased("MouseDown")]
        public void Legend_HitTest_int_int(object sender, MouseEventArgs e)
        {
            // The following example demonstrates using the HitTest method to determine
            // where a user clicked on a Legend object.
            LegendHitTestInfo hitTestRegion;
            Color randomColor = Color.FromArgb(RandNumberGenerator.Next(255),
                                                RandNumberGenerator.Next(255),
                                                RandNumberGenerator.Next(255));

            hitTestRegion = legend.HitTest(e.X, e.Y);
            switch (hitTestRegion)
            {
                case LegendHitTestInfo.HorizontalScrollBar:
                    Debug.WriteLine("horizontal scrollbar selected");                    
                    break;
                case LegendHitTestInfo.Item:
                    LegendItem item = legend.GetItemAt(e.X, e.Y);
                    if (item.Source is Plot)
                    {
                        Plot plot = (Plot)item.Source;
                        plot.LineColor = randomColor;
                        Debug.WriteLine("Item selected was a Plot");
                    }
                    else if (item.Source is DigitalPlot)
                    {
                        DigitalPlot plot = (DigitalPlot)item.Source;
                        plot.LineColor = randomColor;
                        Debug.WriteLine("Item selected was a Digital Plot");
                    }
                    break;
                case LegendHitTestInfo.Text:
                    Debug.WriteLine("Text area of legend selected");
                    break;
                case LegendHitTestInfo.VerticalScrollBar:
                    Debug.WriteLine("vertical scrollbar selected");
                    break;
                case LegendHitTestInfo.None:
                    Debug.WriteLine("Unknown legend area selected");
                    break;
            }
        }

        /// <summary>
        /// Retrieves the size of a rectangular area into which the control can 
        /// be fitted. This member overrides Control.GetPreferredSize and is 
        /// implemented in the Legend class.  
        /// </summary>
        /// <signature>Legend.GetPreferredSize(Size)</signature>
        /// <ExampleMethod />
        public void GetPreferredSize_Size()
        {
            // The following example demonstrates getting the preferred size of a Legend object.
            Size newSize = legend.GetPreferredSize(Size.Empty);            

            Debug.WriteLine(string.Format("The legend's original size is {0}", legend.Size.ToString()));
            Debug.WriteLine(string.Format("The legend's proposed size is {0}", newSize.ToString()));
        }

        #endregion

        #region helper methods and classes for the SnipsLegend class

        public override string ToString()
        {
            return legend.ToString();
        }

        /// <summary>
        /// Updates the legend to display the items in the SnipsLegendItem list
        /// </summary>
        /// <param name="items">Items to be displayed in the legend.</param>
        public void SetItems(List<SnipsLegendItem> items)
        {
            LegendItem legendItem;            

            legend.Items.Clear();

            if (items != null)
            {
                foreach (SnipsLegendItem item in items)
                {
                    if (item.IsVisible)
                    {
                        legendItem = new LegendItem(item, item.ItemLabel);
                        legend.Items.Add(legendItem);
                    }
                }
            }
        }
    }

    /// <summary>
    /// A helper class for snips controls that need to be added to a legend
    /// </summary>
    public class SnipsLegendItem : ILegendItemSource
    {
        private ILegendItemSource item;
        private string itemLabel;
        private bool visible;

        /// <summary>
        /// Public constructor for the Snips Legend Item
        /// </summary>
        /// <param name="item">The item to be added to the legend</param>
        /// <param name="itemLabel">The label to be displayed on the legend</param>
        /// <param name="visible">Whether or not the item is visible</param>
        public SnipsLegendItem(ILegendItemSource item, string itemLabel, bool visible)
        {
            this.item = item;
            this.itemLabel = itemLabel;
            this.visible = visible;
        }

        /// <summary>
        /// Draws the symbol of a legend item
        /// </summary>
        /// <param name="args">A ComponentDrawArgs that contains the graphics 
        /// surface to draw the legend item on and the bounds in which to 
        /// draw the legend item.</param>
        public void DrawLegendItem(ComponentDrawArgs args)
        {
            item.DrawLegendItem(args);
        }

        /// <summary>
        /// Event signaling when the legend item has been disposed
        /// </summary>
        public event EventHandler Disposed;
        /// <summary>
        /// Raises the Disposed event
        /// </summary>
        /// <param name="e">Contains event data</param>
        protected virtual void OnDisposed(EventArgs e)
        {
            if (Disposed != null)
                Disposed(this, e);
        }

        /// <summary>
        /// Event signaling when the legend item changes
        /// </summary>
        public event EventHandler LegendItemChanged;
        /// <summary>
        /// Raises the LegendItemChanged event
        /// </summary>
        /// <param name="e">Contains event data</param>
        protected virtual void OnLegendItemChanged(EventArgs e)
        {
            if (LegendItemChanged != null)
                LegendItemChanged(this, e);
        }

        /// <summary>
        /// The label to be displayed for the legend item
        /// </summary>
        public string ItemLabel
        {
            get { return itemLabel; }
            set { itemLabel = value; }
        }

        /// <summary>
        /// Whether or not the item is visible
        /// </summary>
        public bool IsVisible
        {
            get { return visible; }
            set { visible = value; }
        }
    }
    #endregion
}
