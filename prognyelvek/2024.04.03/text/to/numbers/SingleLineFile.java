package text.to.numbers;

import java.io.*;
import java.nio.Buffer;
import java.util.*;

public class SingleLineFile {
  public static int addNumbers(String fileName) throws IOException {
    int result = 0;

    try (BufferedReader bf = new BufferedReader(new FileReader(fileName));) {
      String line = bf.readLine();
      if (line == null) {
        throw new IllegalArgumentException("File is empty");
      }

      String[] words = line.split(" ");

      for (String word : words) {
        try {
          result += Integer.parseInt(word);
        } catch (NumberFormatException e) {
          System.err.println("Invalid number: " + word);
        }
      }
    } catch (FileNotFoundException e) {
      throw new IOException(e.getMessage());
    }

    return result;
  }

  public static void main(String[] args) throws IOException {
    System.out.println(addNumbers("test.txt"));
  }
}