﻿using System;
using static System.Console;
using System.IO;
class DebugFourteen1
{
    static void Main()
    {
        string fileName;
        string directory;
        string path;
        string[] files;//added []
        int x;

        Write("Enter a directory: ");
        directory = ReadLine();

        if (Directory.Exists(directory))//fix capilization 
        {
            files = Directory.GetFiles(directory);
            if (files.Length == 0)//added == sign
                WriteLine("There are no files in " + directory);
            else
            {
                WriteLine(directory + " contains the following files");

                for (x = 0; x <= files.Length; ++x)
                    WriteLine("  " + Path.GetFileName(files[x]));//add get file name

                Write("\nEnter a file name: ");
                fileName = ReadLine();
                path = directory + "\\" + fileName;

                if (File.Exists(path))
                {
                    WriteLine("  File exists and was created " + File.GetCreationTime(path));
                    WriteLine("File was created " + File.GetCreationTime(fileName));
                }
                else
                    WriteLine("  " + fileName + " does not exist in the " + directory, " directory");
            }
        }
        else
        {
            WriteLine("Directory " + directory + " does not exist");
        }
    }
}