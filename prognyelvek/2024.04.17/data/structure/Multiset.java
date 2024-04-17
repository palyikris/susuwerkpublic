package data.structure;

import java.util.HashMap;

public class Multiset<E> {
  private HashMap<E, Integer> elemToCount;

  public Multiset(E[] elements) {
    elemToCount = new HashMap<E, Integer>();

    for (E elem : elements) {
      if (elemToCount.containsKey(elem)) {
        elemToCount.put(elem, elemToCount.get(elem) + 1);
      } else {
        elemToCount.put(elem, 1);
      }
    }
  }
}
