/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package bea1;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.util.ArrayList;
import java.util.Collections;
import java.util.HashMap;
import java.util.Scanner;
import java.util.Set;

/**
 *
 * @author palyi
 */
public class ShapeDb {
    private final ArrayList<Shape> shapes;

    public ShapeDb() {
        this.shapes = new ArrayList<>();
    }
    
    /**
     *
     * @param filename - name of the file to be read
     * @throws FileNotFoundException - thrown when no file exists named as the parameter
     * @throws InvalidInputException - thrown when the first letter of a line cannot be associated with a class
     */
    public void read(String filename) throws FileNotFoundException, InvalidInputException {
       Scanner sc = new Scanner(new BufferedReader(new FileReader(filename)));
       int nOfShapes = sc.nextInt();
       if(nOfShapes == 0){
           System.out.println("No shapes to read!");
           return;
       }
       while (sc.hasNext()) {
           Shape shape;
           switch (sc.next()) {
               case "C":
                   shape = new Circle(new Coord(sc.nextInt(), sc.nextInt()), sc.nextInt());
                   System.out.println("Read a Circle!");
                   break;
               case "T":
                   shape = new Triangle(new Coord(sc.nextInt(), sc.nextInt()), sc.nextInt());
                   System.out.println("Read a Triangle!");
                   break;
               case "S":
                   shape = new Square(new Coord(sc.nextInt(), sc.nextInt()), sc.nextInt());
                   System.out.println("Read a Square!");
                   break;
               case "H":
                   shape = new Hexagon(new Coord(sc.nextInt(), sc.nextInt()), sc.nextInt());
                   System.out.println("Read a Hexagon!");
                   break;
               default:
                   throw new InvalidInputException();
           }

           shapes.add(shape);
       }
    }
     
    public void report(){
       if(shapes.isEmpty()){
           return;
       }
       System.out.println("Shapes in the database:");
       for (Shape s : shapes) {
           System.out.printf("%s, Area: %.2f Perimeter: %.2f \n", s, s.CalcArea(), s.CalcPerimeter());
       }
       HashMap<Double, Shape> shapeMap = new HashMap<>();
       for (Shape s: shapes){
           Double diff = Math.abs(s.CalcArea() - s.CalcPerimeter());
           shapeMap.put(diff, s);
       }
       Set<Double> keys = shapeMap.keySet();

       ArrayList<Double> keyList = new ArrayList<>(keys);
       double minDiff = Collections.min(keyList);

       Shape shapeWithMinDiff = shapeMap.get(minDiff);

       System.out.printf("The shape with the lowest difference between area and perimeter: (%.2f) \n", minDiff);
       System.out.println(shapeWithMinDiff);

    }
    
}


