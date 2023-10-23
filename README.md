# Dpi Awareness Library
A library for enabling DPI awareness in a Windows Forms application.
## Downloads
- [ ![Download Win64](https://img.shields.io/badge/Download-x64-brightgreen )](https://github.com/korayustundag/DpiAwareness/releases/download/v1.0.0/DpiAwareness_x64.zip)
- [ ![Download Win32](https://img.shields.io/badge/Download-x86-brightgreen )](https://github.com/korayustundag/DpiAwareness/releases/download/v1.0.0/DpiAwareness_x86.zip)
- [ ![Download WinArm64](https://img.shields.io/badge/Download-ARM64-brightgreen )](https://github.com/korayustundag/DpiAwareness/releases/download/v1.0.0/DpiAwareness_ARM64.zip)
- [ ![Download AnyCPU](https://img.shields.io/badge/Download-Any_CPU-brightgreen )](https://github.com/korayustundag/DpiAwareness/releases/download/v1.0.0/DpiAwareness_AnyCPU.zip)
## Usage
1. Download the Dpi Awareness library.
2. Extract to any location.
3. Add libDpi.dll to your project's references.

![se](https://github.com/korayustundag/DpiAwareness/blob/main/img/se.png)

4. Set the AutoScaleMode of the Forms used in your project to Dpi.

![pw](https://github.com/korayustundag/DpiAwareness/blob/main/img/pw.gif)

5. Add the following code to the Program.cs file.
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms; // <-- Necessary

namespace ExampleApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            DpiAwareness.Enable(); // <-- Enable DPI Awareness

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ExampleForm());
        }
    }
}
```
