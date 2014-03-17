using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ESO___Skill_Point_Calculator.Popup
{
    class descriptionSpells
    {
        ToolTip popup = new ToolTip();
        string name = "jmeno našeho spelu";
        string type = "Typ: Ultimate";
        string separator = "----------------------";
        string description = "test";
        string range = "15";
        string radius = "2";
        string castTime = "Instant";
        string duration = "5";

        public descriptionSpells(object sender)
        {
            popup.OwnerDraw = true;
            popup.Popup += new PopupEventHandler(this.OnPopup);
            popup.SetToolTip((Button)sender, StringAlignment.Center + name
                + Environment.NewLine + type
                + Environment.NewLine + separator
                + Environment.NewLine
                + Environment.NewLine + description 
                + Environment.NewLine + radius 
                + Environment.NewLine + range 
                + Environment.NewLine + castTime 
                + Environment.NewLine + duration);
            popup.Draw += description_Draw;
        }

        private void OnPopup(object sender, PopupEventArgs e)
        {
            e.ToolTipSize = new Size(300, 300);
        }

        private void description_Draw(object sender, DrawToolTipEventArgs e)
        {
            Graphics g = e.Graphics;

            LinearGradientBrush b = new LinearGradientBrush(e.Bounds,
                Color.BurlyWood, Color.Gray, 45f);

            g.FillRectangle(b, e.Bounds);

            g.DrawRectangle(new Pen(Brushes.Black, 1), new Rectangle(e.Bounds.X, e.Bounds.Y,
                e.Bounds.Width - 1, e.Bounds.Height - 1));

            g.DrawString(e.ToolTipText, new Font(e.Font, FontStyle.Bold), Brushes.Silver,
                new PointF(e.Bounds.X + 6, e.Bounds.Y + 6));
            g.DrawString(e.ToolTipText, new Font(e.Font, FontStyle.Bold), Brushes.Black,
                new PointF(e.Bounds.X + 5, e.Bounds.Y + 5));
            b.Dispose();
        }
    }
}
