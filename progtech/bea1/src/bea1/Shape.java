/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package bea1;

/**
 *
 * @author palyi
 */
public abstract class Shape {
    
    private Coord center;

    public Shape(Coord center) {
        this.center = center;
    }

    public Coord getCenter() {
        return center;
    }

    public void setCenter(Coord center) {
        this.center = center;
    }
    
    /**
     *
     * @return returns the perimeter of a shape as a double
     */
    public abstract double CalcPerimeter();
    
    /**
     *
     * @return returns the area of a shape as a double
     */
    public abstract double CalcArea();
    
    
}
