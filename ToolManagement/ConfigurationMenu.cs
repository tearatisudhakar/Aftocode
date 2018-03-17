using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToolManagement
{
    public partial class ConfigurationMenu : Form
    {
        public ConfigurationMenu()
        {
            InitializeComponent();
        }

        private void tabConfig_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabConfig.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabConfig.GetTabRect(e.Index);
            if (e.State == DrawItemState.Selected)
            {
                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.White);
                //g.FillRectangle(Brushes.DarkGray, e.Bounds);
                Color myrgb = new Color();
                myrgb = Color.FromArgb(67, 88, 109);
                SolidBrush sb = new SolidBrush(myrgb);

                g.FillRectangle(sb, _tabBounds);
            }

            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Calibri", (float)14.0, FontStyle.Regular, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();

            _stringFlags.Alignment = StringAlignment.Center;

            _stringFlags.LineAlignment = StringAlignment.Center;

            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));

        }
        }
    }

