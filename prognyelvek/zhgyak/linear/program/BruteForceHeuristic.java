package linear.program;

import java.util.List;

import linear.program.utils.Variable;

public class BruteForceHeuristic extends Heuristic {

  @Override
  public boolean getNextVariables(List<Variable> vars) {
    for (Variable var : vars) {
      if (var.getValue() >= var.getUpperBound()) {
        var.setValue(var.getLowerBound());
      } else {
        var.setValue(var.getValue() + 1);
        ;
        return true;
      }
    }
    return false;
  }

}
