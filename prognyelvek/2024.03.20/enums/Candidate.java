package enums;

public enum Candidate {
  JACK("Republican"),
  JILL("Democrat"),
  SAM("Independent"),
  MAX("Libertarian");

  public String party;

  Candidate(String party) {
    this.party = party;
  }

}
