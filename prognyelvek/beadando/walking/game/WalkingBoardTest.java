package walking.game;

import static check.CheckThat.*;
import static org.junit.jupiter.api.Assertions.*;
import org.junit.jupiter.api.*;
import org.junit.jupiter.api.condition.*;
import org.junit.jupiter.api.extension.*;
import org.junit.jupiter.params.*;
import org.junit.jupiter.params.provider.*;
import check.*;

import java.util.*;
import walking.game.util.*;

public class WalkingBoardTest {

  @ParameterizedTest
  @CsvSource({
      "1",
      "2",
      "3",
      "4",
      "5",
      "6",
      "7",
      "8",
      "9",
      "10"
  })
  public void testSimpleInit(int size) {
    WalkingBoard board = new WalkingBoard(size);
    int[][] tiles = board.getTiles();
    assertEquals(size, tiles[0].length);
    assertEquals(size, tiles.length);
    for (int i = 0; i < size; i++) {
      for (int j = 0; j < size; j++) {
        assertEquals(WalkingBoard.BASE_TILE_SCORE, tiles[i][j]);
      }
    }
  }

  @ParameterizedTest
  @CsvSource({
      "1, 1, 1",
      "2, 2, 2",
      "3, 3, 3",
      "4, 4, 4",
      "5, 5, 5",
      "6, 6, 6",
      "7, 7, 7",
      "8, 8, 8",
      "9, 9, 9",
      "10, 10, 10"
  })
  public void testCustomInit(int x, int y, int expected) {
    int[][] tiles = new int[x][y];
    for (int i = 0; i < x; i++) {
      for (int j = 0; j < y; j++) {
        tiles[i][j] = expected;
      }
    }
    WalkingBoard board = new WalkingBoard(tiles);
    for (int i = 0; i < x; i++) {
      for (int j = 0; j < y; j++) {
        if (expected < WalkingBoard.BASE_TILE_SCORE) {
          assertEquals(WalkingBoard.BASE_TILE_SCORE, board.getTile(i, j));
        } else {
          assertEquals(expected, board.getTile(i, j));
        }
      }
      tiles[0][0] = 0;
      assertEquals(false, board.getTile(0, 0) == tiles[0][0]);
      int[][] boardTiles = board.getTiles();
      boardTiles[0][0] = 0;
      assertEquals(false, board.getTile(0, 0) == boardTiles[0][0]);
    }
  }

  @Test
  public void testMoves() {
    WalkingBoard board = new WalkingBoard(4);
    assertEquals(0, board.moveAndSet(Direction.LEFT, 2));
    assertEquals(WalkingBoard.BASE_TILE_SCORE, board.moveAndSet(Direction.RIGHT, 6));
    assertEquals(WalkingBoard.BASE_TILE_SCORE, board.moveAndSet(Direction.DOWN, 4));
    assertEquals(6, board.moveAndSet(Direction.UP, 3));
    assertEquals(0, board.moveAndSet(Direction.UP, 4));
  }
}
