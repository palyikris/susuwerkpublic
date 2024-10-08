/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package bea1;

import java.io.FileNotFoundException;

/**
 *
 * @author palyi
 */
public class Bea1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {

        ShapeDb database = new ShapeDb();
        try {
            database.read("shapes.txt");
        } catch (FileNotFoundException ex) {
            System.out.println("File not found!");
            System.exit(-1);
        } catch (InvalidInputException ex) {
            System.out.println("Invalid input!");
            System.exit(-1);
        }
        database.report();
    }
    
}
