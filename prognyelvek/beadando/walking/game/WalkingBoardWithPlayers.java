package walking.game;

import walking.game.player.Player;
import walking.game.player.MadlyRotatingBuccaneer;

public class WalkingBoardWithPlayers extends WalkingBoard {
  private Player[] players;
  private int round = 0;
  public static final int SCORE_EACH_STEP = 13;

  public WalkingBoardWithPlayers(int[][] board, int playerCount) {
    super(board);
    initPlayers(playerCount);

  }

  public WalkingBoardWithPlayers(int size, int playerCount) {
    super(size);
    initPlayers(playerCount);
  }

  private void initPlayers(int playerCount) {
    if (playerCount < 2) {
      throw new IllegalArgumentException("playerCount must be at least 2");
    }
    players = new Player[playerCount];
    players[0] = new MadlyRotatingBuccaneer();
    for (int i = 1; i < playerCount; i++) {
      players[i] = new Player();
    }

  }

  public int[] walk(int... stepCounts) {
    for (int i = 0; i < stepCounts.length; i++) {
      Player mp = players[i % players.length];
      if (mp instanceof MadlyRotatingBuccaneer) {
        for (int j = 0; j < round; j++) {
          mp.turn();
        }
        round++;
      } else {
        mp.turn();
      }
      for (int j = 0; j < stepCounts[i]; j++) {
        int oldVal = moveAndSet(mp.getDirection(), Math.min(j, SCORE_EACH_STEP));
        mp.addToScore(oldVal);
      }
    }
    int[] scores = new int[players.length];
    for (int i = 0; i < players.length; i++) {
      scores[i] = players[i].getScore();
    }

    return scores;
  }

}
