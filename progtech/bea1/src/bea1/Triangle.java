/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package bea1;

/**
 *
 * @author palyi
 */
public class Triangle extends Polygon{

    public Triangle(Coord center, double sideLength) throws InvalidInputException {
        super(center, sideLength);
    }
    
    
    @Override
    public double CalcPerimeter(){
        return 3 * this.getSideLength();
    }
    
    @Override
    public double CalcArea(){
        double area = (Math.sqrt(3) / 4) * Math.pow(this.getSideLength(), 2);
        double roundedArea = Math.round(area * 100.0) / 100.0;
        return roundedArea;
    }
    
    @Override
    public String toString(){
        return "Triangle(" + this.getCenter().getX() + ", " + this.getCenter().getY() + ")";
    }
}
