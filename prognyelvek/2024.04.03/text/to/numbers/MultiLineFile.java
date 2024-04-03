package text.to.numbers;

import java.io.*;
import java.util.*;

public class MultiLineFile {
  public static int addNumbers(String fileName, String sep) throws IOException {
    int result = 0;

    try (BufferedReader bf = new BufferedReader(new FileReader(fileName))) {
      String line;
      while ((line = bf.readLine()) != null) {
        String[] words = line.split(sep);

        for (String word : words) {
          try {
            result += Integer.parseInt(word);
          } catch (NumberFormatException e) {
            // todo: log error
          }
        }
      }
    } catch (IOException e) {
      System.err.println("Error reading file: " + e.getMessage());
    }

    return result;
  }

  public static void main(String[] args) throws IOException {
    System.out.println(addNumbers("testmulti.txt", " "));
  }
}
