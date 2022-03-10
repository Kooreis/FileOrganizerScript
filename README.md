# Python Documentation

# Python File Organizer

This Python script is designed to help you organize your files in a directory by their file extensions. It will create new directories for each file type and move the corresponding files into their respective directories.

## Libraries Used

- `os`: This is a built-in Python library used for interacting with the operating system. In this script, it is used to walk through the directory, create new directories, and join paths.

- `shutil`: This is another built-in Python library used for high-level file operations. In this script, it is used to move files from one directory to another.

## How the Script Works

1. The script first prompts the user to enter the path of the directory they want to organize.

2. It then walks through the directory and its subdirectories, and for each file it encounters, it extracts the file extension and adds the file to a dictionary where the key is the file extension and the value is a list of files with that extension.

3. After all files have been added to the dictionary, the script iterates over the dictionary. For each file extension, it checks if a directory with that name already exists in the main directory. If not, it creates one.

4. Finally, it moves each file in the list to the newly created directory corresponding to its file extension.

## Usage

To use this script, simply run it in a Python environment. When prompted, enter the path of the directory you want to organize. The script will then organize the files in that directory by their extensions.

Please note that this script will move files from their current location to new directories. Make sure to backup your files before running the script if you want to keep the original file structure.

---

# C# Documentation

# CSharp File Mover Script

This script is written in C#, and its main function is to move all text files from one directory to another. The source and destination directories are provided as command-line arguments when running the script.

## Script Explanation

The script starts by defining the source and destination directories based on the command-line arguments. It then attempts to enumerate all text files in the source directory and move them to the destination directory. After all files have been attempted to be moved, the script checks if there are any text files left in the source directory. If there are, it outputs a message stating that some files couldn't be moved. If there aren't, it outputs a message stating that all files have been moved. If an exception occurs at any point during this process, the script catches it and outputs the exception message.

## Imported Libraries

The script imports three libraries from the System namespace:

- `System`: This namespace contains fundamental classes and base classes that define commonly-used value and reference data types, events and event handlers, interfaces, attributes, and processing exceptions. In this script, it is used for handling exceptions and outputting to the console.

- `System.IO`: This namespace contains types that allow reading and writing to files and data streams, and types that provide basic file and directory support. In this script, it is used for enumerating files in a directory, moving files, and working with paths.

- `System.Linq`: This namespace provides classes and interfaces that support queries that use Language-Integrated Query (LINQ). In this script, it is used for checking if any files are left in the source directory after attempting to move them.

---

# Java Documentation

# File Organizer in Java

This Java script is designed to organize files in a directory. It sorts the files in such a way that directories are listed first, followed by files. Both directories and files are sorted in alphabetical order.

## How it works

The script prompts the user to enter a directory path. It then checks if the directory exists and if it is indeed a directory (not a file). If these conditions are met, it retrieves a list of all files and directories within the specified directory. If the directory is empty, it informs the user and ends the program.

The script then sorts the list of files and directories. Directories are prioritized over files. If both items being compared are directories or files, they are sorted alphabetically.

Finally, the script prints out the names of the files and directories, in the order determined by the sorting process.

## Imported Libraries

The script uses the following libraries:

- `java.io.File`: This library provides an abstraction of file and directory pathnames. It is used to interact with the file system, allowing the script to retrieve and manipulate information about files and directories.

- `java.util.Arrays`: This library provides static methods to manipulate arrays. It is used to sort the array of files and directories.

- `java.util.Scanner`: This library is used to read input from various sources, in this case, the console. It is used to get the directory path from the user.

## Code

```java
import java.io.File;
import java.util.Arrays;
import java.util.Scanner;

public class FileOrganizer {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter directory path:");
        String directoryPath = scanner.nextLine();
        File directory = new File(directoryPath);
        if (!directory.exists()) {
            System.out.println("Directory does not exist.");
            return;
        }
        if (!directory.isDirectory()) {
            System.out.println("Path is not a directory.");
            return;
        }
        File[] files = directory.listFiles();
        if (files == null || files.length == 0) {
            System.out.println("Directory is empty.");
            return;
        }
        Arrays.sort(files, (f1, f2) -> {
            if (f1.isDirectory() && !f2.isDirectory()) {
                return -1;
            } else if (!f1.isDirectory() && f2.isDirectory()) {
                return 1;
            } else {
                return f1.compareTo(f2);
            }
        });
        for (File file : files) {
            System.out.println(file.getName());
        }
    }
}
```

## Usage

To use this script, simply run it in a Java environment. When prompted, enter the path to the directory you want to organize. The script will then print out the names of the files and directories in the specified directory, sorted as described above.

---
