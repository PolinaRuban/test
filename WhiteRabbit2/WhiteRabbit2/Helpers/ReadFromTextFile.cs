using System;
using System.Collections.Generic;
using System.IO;
using WhiteRabbit2.Models;

namespace WhiteRabbit2.Helpers
{
    public class ReadFromTextFile
    {
        private readonly string fileName;

        public ReadFromTextFile(string textFile)
        {
            String directory = "C:\\Users\\Polina\\Documents\\GitHub\\test\\WhiteRabbit2\\WhiteRabbit2";
            fileName = directory + "\\Menu\\" + textFile;
        }

        /// <summary>
        /// Read from file using separators (spaces and quotations)
        /// https://msdn.microsoft.com/en-us/library/db5x7c0d%28v=vs.110%29.aspx
        /// </summary>
        /// <returns>List of Courses</returns>

        public List<MyMenu> AddDataToCourses()
        {
            var courseList = new List<MyMenu>();
            using (var reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    String line = reader.ReadLine();
                    // as a result we have string[3] : id, name and both times (which are separated below)
                    if (line != null)
                    {
                        var split = line.Split(new Char[] { '\"' });
                        int id = Int32.Parse(split[0]);
                        string name = split[1];
                        var times = split[2].Split(new char[] { ' ' });
                        //times has three string: " ", first time, second time. Times in minutes.
                        var timeForCooking = times[1];
                        var timeForEating = times[2];
                        courseList.Add(new MyMenu
                        {
                            CourseId = id,
                            CourseName = name,
                            TimeForCooking = timeForCooking,
                            TimeForEating = timeForEating
                        });
                    }
                }
            }
            return courseList;
        }
    }
}
