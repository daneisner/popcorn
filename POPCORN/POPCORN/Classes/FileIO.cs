using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace POPCORN.Classes
{
    public abstract class FileIO
    {
        /// <summary>
        /// Private method for several FileIO methods that need to determine the full path, assumes files go in the current directory.
        /// </summary>
        /// <param name="fileName">String of the file name to combine with the path</param>
        /// <returns>String including the fully qualified name of the necessary file</returns>
        private static string FilePath(string fileName)
        {
            string currentDirectory = Environment.CurrentDirectory;
            string fullPath = Path.Combine(currentDirectory, fileName);
            return fullPath;
        }

        public static Dictionary<string,string> ReadTime(string fileName)
        {
            // Dictionary to translate numbers to text
            Dictionary<string, string> times = new Dictionary<string, string>();

            string fullPath = FilePath(fileName);

            try
            {
                using (StreamReader timeReader = new StreamReader(fullPath))
                {
                    // read each line of the file into the dictionary
                    while (!timeReader.EndOfStream)
                    {
                        string[] currentTime = timeReader.ReadLine().Split(",");
                        times[currentTime[0]] = currentTime[1];
                    }
                }
            }
            catch (IOException ioe)
            {
                throw ioe;
            }
            catch (Exception e)
            {
                throw e;
            }

            return times;
        }
    }
}
