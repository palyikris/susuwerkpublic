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
    
    private int sideLength;
    
    public Polygon(Coord center, int sideLength) {
        super(center);
        this.sideLength = sideLength;
    }

    public int getSideLength() {
        return sideLength;
    }

    /**
     *
     * @param sideLength - the side length of the new polygon
     * @throws InvalidInputException - thrown when given side length is negative
     */
    public void setSideLength(int sideLength) throws InvalidInputException {
        
        if(sideLength < 0){
            throw new InvalidInputException();
        }
        this.sideLength = sideLength;
    }
    
    
    
}
