/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package bea1;

/**
 *
 * @author palyi
 */
public abstract class Polygon extends Shape{
    
    private double sideLength;
    
    public Polygon(Coord center, double sideLength) throws InvalidInputException {
        super(center);
        if(sideLength < 0){
            throw new InvalidInputException();
        }
        this.sideLength = sideLength;
    }

    public double getSideLength() {
        return sideLength;
    }

    /**
     *
     * @param sideLength - the side length of the new polygon
     * @throws InvalidInputException - thrown when given side length is negative
     */
    public void setSideLength(double sideLength) throws InvalidInputException {
        
        if(sideLength < 0){
            throw new InvalidInputException();
        }
        this.sideLength = sideLength;
    }
    
    
    
}
