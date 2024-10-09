/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package bea1;

/**
 *
 * @author palyi
 */
public class Square extends Polygon{
    
    public Square(Coord center, int sideLength) {
        super(center, sideLength);
    }
    
    @Override
    public double CalcPerimeter(){
        return 4 * this.getSideLength();
    }
    
    @Override
    public double CalcArea(){
        double area = Math.pow(this.getSideLength(), 2);
        double roundedArea = Math.round(area * 100.0) / 100.0;
        return roundedArea;
    }
    
    @Override
    public String toString(){
        return "Square(" + this.getCenter().getX() + ", " + this.getCenter().getY() + ")";
    }
}
