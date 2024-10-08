/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package bea1;

/**
 *
 * @author palyi
 */
public class Circle extends Shape{
    
    private int radius;
    
    public Circle(Coord center, int radius) {
        super(center);
        this.radius = radius;
    }

    public int getRadius() {
        return radius;
    }

    /**
     *
     * @param radius - a non-negative int for the radius of a circle
     * @throws InvalidInputException - thrown when given radius is negative
     */
    public void setRadius(int radius) throws InvalidInputException {
        if( radius < 0){
            throw new InvalidInputException();
        }
        this.radius = radius;
    }
    
    @Override
    public double CalcPerimeter(){
        double per = 2 * radius * Math.PI;
        double roundedPer = Math.round(per * 100.0) / 100.0;
        return roundedPer;
    }
    
    @Override
    public double CalcArea(){
        double area = Math.PI * Math.pow(radius, 2);
        double roundedArea = Math.round(area * 100.0) / 100.0;
        return roundedArea;
    }
    
    @Override
    public String toString(){
        return "Circle(" + this.getCenter().getX() + ", " + this.getCenter().getY() + ")";
    }
    
}
