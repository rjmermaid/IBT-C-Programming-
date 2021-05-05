using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Chapter13ProgramDirectories.zip
{
    class clsDirectory
    {
        const string TAB = " ";
        static private int visits;
        private int dirCounter;

        public clsDirectory()
        {
            dirCounter = 1;
        }

        public int DirectoryCount
        {
            get
            {
                return dirCounter;
            }
        }
        public int ShowDirectory (DirectoryInfo curDir, int inLevel, ArrayList dirs)
        {
            int i;
            string indent = "";

            try
            {
                for (i = 0; i < visits; i++)
                {
                    indent += TAB;
                }
                dirs.Add(indent + curDir.Name);
                visits++;
                
                foreach (DirectoryInfo subDir in curDir.GetDirectories())
                {
                    dirCounter++;
                    ShowDirectory(subDir, visits, dirs);
                }
                visits--;
                
                if (indent.Length > 0)
                {
                    indent.Substring(0, indent.Length - TAB.Length);
                }
            }
            catch (Exception ex)
            {
                return 1;
            }
            return dirCounter;
        }
        

    }
}
