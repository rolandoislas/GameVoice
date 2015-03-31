using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameVoice.Gui.Control {
    public static class FlowLayoutPanelExtension {

        public static void setImage(this FlowLayoutPanel panel, Image image, int repeatX) {
            setImage(panel, new Image[] { image }, repeatX);
        }

        public static void setImage(this FlowLayoutPanel panel, Image[] image, int repeatX) {
            Bitmap bitmap = new Bitmap(image[0].Width * repeatX, image[0].Height * image.Length);
            Graphics g = Graphics.FromImage(bitmap);
            for (int i = 0; i < image.Length; i++) {
                for (int x = 0; x <= bitmap.Width - image[i].Width; x += image[i].Width) {
                    int y = image[0].Height * i;
                    g.DrawImage(image[i], new Point(x, y));
                }
            }
            panel.BackgroundImage = bitmap;
        }

    }
}
