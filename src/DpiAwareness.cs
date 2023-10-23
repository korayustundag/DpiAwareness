using System.Runtime.InteropServices;

namespace System.Windows.Forms
{
    /// <summary>
    /// A static class for enabling DPI awareness in a Windows Forms application.
    /// </summary>
    public static class DpiAwareness
    {
        /// <summary>
        /// Enables DPI awareness for the current process.
        /// </summary>
        /// <remarks>
        /// <br>To use the Enable method, you need to set the <b>AutoScaleMode</b> of the Forms used in your project to <b>Dpi</b>.</br>
        /// <br>You can follow these steps to make the necessary adjustment:</br>
        /// <br>1. Select the <b>form</b> in your project.</br>
        /// <br>2. In the <b>Properties</b> window, navigate to <b>Layout</b>.</br>
        /// <br>3. Set the <b>AutoScaleMode</b> property to <b>Dpi</b>.</br>
        /// </remarks>
        public static void Enable()
        {
            int osver = Environment.OSVersion.Version.Major + Environment.OSVersion.Version.Minor;
            if (osver >= 7)
            {
                SetProcessDPIAware();
            }
        }

        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
