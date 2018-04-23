// Developer Express Code Central Example:
// How to create a GridView descendant, which will allow using a specific repository item for displaying and editing data in a row preview section
// 
// This example shows how to create a GridView
// (ms-help://MS.VSCC.v90/MS.VSIPCC.v90/DevExpress.NETv9.2/DevExpress.XtraGrid/clsDevExpressXtraGridViewsGridGridViewtopic.htm)
// descendant, which will allow using a specific repository item for displaying and
// editing data in a row preview section.
// 
// 
// See Also:
// <kblink id = "K18341"/>
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E2002

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GridView_RowPreview
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}