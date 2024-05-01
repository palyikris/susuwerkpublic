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

public class WalkingBoardWithPlayersTest {

  @Test
  public void walk1() {
    WalkingBoardWithPlayers board = new WalkingBoardWithPlayers(4, 4);
    int[] scores = board.walk(3, 2, 3, 4, 5, 6, 2);
    assertEquals("[0, 15, 3, 0]", Arrays.toString(scores));
    assertEquals("[[3, 3, 3, 3], [0, 3, 3, 3], [1, 3, 3, 3], [0, 0, 1, 2]]", Arrays.deepToString(board.getTiles()));
  }

  @Test
  public void walk2() {
    WalkingBoardWithPlayers board = new WalkingBoardWithPlayers(7, 2);
    int[] scores = board.walk(4, 4, 1, 3, 5, 3);
    assertEquals("[18, 21]", Arrays.toString(scores));
    assertEquals(
        "[[3, 3, 3, 4, 3, 3, 3], [0, 3, 3, 3, 3, 3, 3], [1, 3, 3, 2, 3, 3, 3], [2, 3, 3, 1, 3, 3, 3], [3, 3, 3, 0, 3, 3, 3], [0, 0, 1, 2, 3, 3, 3], [3, 3, 3, 3, 3, 3, 3]]",
        Arrays.deepToString(board.getTiles()));
  }
}