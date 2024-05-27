package linear.program;

import java.util.List;
import java.util.Random;

import linear.program.utils.Variable;

public class RandomHeuristic extends Heuristic {
  private Random random;

  public void RandomHeuristic() {
    this.random = new Random();
  }

  public void RandomHeuristic(int seed) {
    this.random = new Random(seed);
  }

  public boolean getNextVariables(List<Variable> vars) {
    for (int i = 0; i < vars.size(); i++) {
      int bound = vars.get(i).getUpperBound();
      int value = random.nextInt(bound);
      while (bound <= vars.get(i).getLowerBound()) {
        bound = vars.get(i).getUpperBound();
        value = random.nextInt(bound);
      }
      vars.get(i).setValue(value);
    }

    return true;
  }
}
