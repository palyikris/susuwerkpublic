/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package bea1;

/**
 *
 * @author palyi
 */
public class Hexagon extends Polygon{
    
    public Hexagon(Coord center, int sideLength) {
        super(center, sideLength);
    }
    
    @Override
    public double CalcPerimeter(){
        return 6 * this.getSideLength();
    }
    
    @Override
    public double CalcArea(){
        double area = (3 * Math.sqrt(3) / 2) * Math.pow(this.getSideLength(), 2);
        double roundedArea = Math.round(area * 100.0) / 100.0;
        return roundedArea;
    }
    
    @Override
    public String toString(){
        return "Hexagon(" + this.getCenter().getX() + ", " + this.getCenter().getY() + ")";
    }
    
}
