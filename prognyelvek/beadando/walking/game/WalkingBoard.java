package walking.game;

import walking.game.util.Direction;

public class WalkingBoard {
  private int[][] tiles;
  private int x;
  private int y;
  public static final int BASE_TILE_SCORE = 3;

  public WalkingBoard(int size) {
    int[][] newTiles = new int[size][size];
    for (int i = 0; i < size; i++) {
      for (int j = 0; j < size; j++) {
        newTiles[i][j] = BASE_TILE_SCORE;
      }
    }
    this.tiles = newTiles;
  }

  public WalkingBoard(int[][] tiles) {
    int[][] newTiles = new int[tiles.length][tiles[0].length];
    for (int i = 0; i < tiles.length; i++) {
      for (int j = 0; j < tiles.length; j++) {
        if (tiles[i][j] >= BASE_TILE_SCORE) {
          newTiles[i][j] = tiles[i][j];
        } else {
          newTiles[i][j] = BASE_TILE_SCORE;
        }
      }
    }
    this.tiles = newTiles;
  }

  public int[][] getTiles() {
    int[][] copy = new int[tiles.length][tiles[0].length];
    for (int i = 0; i < tiles.length; i++) {
      for (int j = 0; j < tiles.length; j++) {
        copy[i][j] = tiles[i][j];
      }
    }
    return copy;
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

  public static int getXStep(Direction direction) {
    return direction == Direction.RIGHT ? 1 : direction == Direction.LEFT ? -1 : 0;
  }

  public static int getYStep(Direction direction) {
    return direction == Direction.UP ? -1 : direction == Direction.DOWN ? 1 : 0;
  }

  public int moveAndSet(Direction direction, int value) {
    int xStep = getXStep(direction);
    int yStep = getYStep(direction);
    if (isValidPosition(x + xStep, y + yStep)) {
      x += xStep;
      y += yStep;
      int oldValue = tiles[x][y];
      tiles[x][y] = value;
      return oldValue;

    }
    return 0;
  }
}
