package walking.game;

import walking.game.util.Direction;

public class WalkingBoard {
  private int[][] tiles;
  private int x;
  private int y;
  public static final int BASE_TILE_SCORE = 3;

  public WalkingBoard(int size) {
    this.tiles = new int[size][size];
  }

  public WalkingBoard(int[][] tiles) {
    this.tiles = tiles;
  }

  public int[] getPosition() {
    return new int[] { x, y };
  }

  public boolean isValidPosition(int x, int y) {
    return x >= 0 && x < tiles.length && y >= 0 && y < tiles.length;
  }

  public int getTile(int x, int y) {
    return tiles[x][y];
  }

  public int getXStep(Direction direction) {
    return direction == Direction.RIGHT ? 1 : direction == Direction.LEFT ? -1 : 0;
  }

  public int getYStep(Direction direction) {
    return direction == Direction.UP ? 1 : direction == Direction.DOWN ? -1 : 0;
  }

  public int moveAndSet(Direction direction, int value) {
    int xStep = getXStep(direction);
    int yStep = getYStep(direction);
    if (isValidPosition(x + xStep, y + yStep)) {
      x += xStep;
      y += yStep;
      return tiles[x][y] = value;
    }
    return 0;
  }
}
