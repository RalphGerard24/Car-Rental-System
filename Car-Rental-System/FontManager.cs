using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace Car_Rental_System
{
    public static class FontManager
    {
        private static PrivateFontCollection privateFontCollection;
        public static Font GlobalFont { get; private set; }

        public static void LoadCustomFont()
        {
            if (GlobalFont != null) return;

            // Load from embedded resources
            byte[] fontData = Properties.Resources.Poppins_Regular; // match your actual name
            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);

            privateFontCollection = new PrivateFontCollection();
            privateFontCollection.AddMemoryFont(fontPtr, fontData.Length);
            Marshal.FreeCoTaskMem(fontPtr);

            FontFamily family = privateFontCollection.Families[0];
            GlobalFont = new Font(family, 10f); // default size 10
        }
    }
}
