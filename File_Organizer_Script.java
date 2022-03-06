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