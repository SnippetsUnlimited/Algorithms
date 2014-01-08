using Company.Graphics.ColorConversions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestConsoleApplication
{
    public partial class frmConsole : Form
    {
        private bool disableRGBEvents = false;
        private bool disableHSIEvents = false;
        private bool disableCMYKEvents = false;
        private bool disableHSVEvents = false;
        private bool disableHSLEvents = false;


        public frmConsole()
        {
            InitializeComponent();
        }

        private void frmConsole_Load(object sender, EventArgs e)
        {
            hsRedGreenBlue_ValueChanged(sender, e);
        }

        private void hsRedGreenBlue_ValueChanged(object sender, EventArgs e)
        {
            if (!disableRGBEvents)
            {
                disableHSIEvents = true;
                disableCMYKEvents = true;
                disableHSVEvents = true;
                disableHSLEvents = true;

                RGBColor rgb = new RGBColor();

                rgb.Red = hsRed.Value / 255f;
                rgb.Green = hsGreen.Value / 255f;
                rgb.Blue = hsBlue.Value / 255f;

                panel1.BackColor = Color.FromArgb(255, hsRed.Value, hsGreen.Value, hsBlue.Value);

                HSIColor hsi = Company.Graphics.ColorConversions.ColorConverter.ToHSI(rgb);

                hsHSIHue.Value = (int)(360 * hsi.Hue);
                hsHSISaturation.Value = (int)(100 * hsi.Saturation);
                hsHSIIntensity.Value = (int)(100 * hsi.Intensity);

                CMYKColor cmyk = Company.Graphics.ColorConversions.ColorConverter.ToCMYK(rgb);

                hsCMYKCyan.Value = (int)(255 * cmyk.Cyan);
                hsCMYKMagenta.Value = (int)(255 * cmyk.Magenta);
                hsCMYKYellow.Value = (int)(255 * cmyk.Yellow);
                hsCMYKBlack.Value = (int)(255 * cmyk.Black);

                HSVColor hsv = Company.Graphics.ColorConversions.ColorConverter.ToHSV(rgb);

                hsHSVHue.Value = (int)(360 * hsv.Hue);
                hsHSVSaturation.Value = (int)(100 * hsv.Saturation);
                hsHSVValue.Value = (int)(100 * hsv.Value);

                HSLColor hsl = Company.Graphics.ColorConversions.ColorConverter.ToHSL(rgb);

                hsHSLHue.Value = (int)(360 * hsl.Hue);
                hsHSLSaturation.Value = (int)(100 * hsl.Saturation);
                hsHSLLuminosity.Value = (int)(100 * hsl.Luminosity);

                disableHSLEvents = false;
                disableHSVEvents = false;
                disableCMYKEvents = false;
                disableHSIEvents = false;
            }
        }

        private void hsHSI_ValueChanged(object sender, EventArgs e)
        {
            if (!disableHSIEvents)
            {
                disableRGBEvents = true;

                HSIColor hsi = new HSIColor();

                hsi.Hue = hsHSIHue.Value / 360f;
                hsi.Saturation = hsHSISaturation.Value / 100f;
                hsi.Intensity = hsHSIIntensity.Value / 100f;


                RGBColor rgb = Company.Graphics.ColorConversions.ColorConverter.ToRGB(hsi);

                hsRed.Value = (int)(255 * rgb.Red);
                hsGreen.Value = (int)(255 * rgb.Green);
                hsBlue.Value = (int)(255 * rgb.Blue);

                panel1.BackColor = Color.FromArgb(255, hsRed.Value, hsGreen.Value, hsBlue.Value);

                disableRGBEvents = false;
            }
        }

        private void hsCMYK_ValueChanged(object sender, EventArgs e)
        {
            if (!disableCMYKEvents)
            {
                disableRGBEvents = true;

                CMYKColor cmyk = new CMYKColor();

                cmyk.Cyan = hsCMYKCyan.Value / 255f;
                cmyk.Magenta = hsCMYKMagenta.Value / 255f;
                cmyk.Yellow = hsCMYKYellow.Value / 255f;
                cmyk.Black = hsCMYKBlack.Value / 255f;


                RGBColor rgb = Company.Graphics.ColorConversions.ColorConverter.ToRGB(cmyk);

                hsRed.Value = (int)(255 * rgb.Red);
                hsGreen.Value = (int)(255 * rgb.Green);
                hsBlue.Value = (int)(255 * rgb.Blue);

                panel1.BackColor = Color.FromArgb(255, hsRed.Value, hsGreen.Value, hsBlue.Value);

                disableRGBEvents = false;
            }
        }

        private void hsHSV_ValueChanged(object sender, EventArgs e)
        {
            if (!disableHSVEvents)
            {
                disableRGBEvents = true;

                HSVColor hsv = new HSVColor();

                hsv.Hue = hsHSVHue.Value / 360f;
                hsv.Saturation = hsHSVSaturation.Value / 100f;
                hsv.Value = hsHSVValue.Value / 100f;

                RGBColor rgb = Company.Graphics.ColorConversions.ColorConverter.ToRGB(hsv);

                hsRed.Value = (int)(255 * rgb.Red);
                hsGreen.Value = (int)(255 * rgb.Green);
                hsBlue.Value = (int)(255 * rgb.Blue);

                panel1.BackColor = Color.FromArgb(255, hsRed.Value, hsGreen.Value, hsBlue.Value);


                disableRGBEvents = false;

            }
        }

        private void hsHSL_ValueChanged(object sender, EventArgs e)
        {
            if (!disableHSLEvents)
            {
                disableRGBEvents = true;

                HSLColor hsl = new HSLColor();

                hsl.Hue = hsHSVHue.Value / 360f;
                hsl.Saturation = hsHSVSaturation.Value / 100f;
                hsl.Luminosity = hsHSVValue.Value / 100f;

                RGBColor rgb = Company.Graphics.ColorConversions.ColorConverter.ToRGB(hsl);

                hsRed.Value = (int)(255 * rgb.Red);
                hsGreen.Value = (int)(255 * rgb.Green);
                hsBlue.Value = (int)(255 * rgb.Blue);

                panel1.BackColor = Color.FromArgb(255, hsRed.Value, hsGreen.Value, hsBlue.Value);


                disableRGBEvents = false;

            }
        }

    }
}
