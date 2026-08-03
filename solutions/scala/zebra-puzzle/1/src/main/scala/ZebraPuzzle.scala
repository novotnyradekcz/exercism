object ZebraPuzzle {

  sealed trait Resident
  case object Englishman extends Resident
  case object Spaniard extends Resident
  case object Ukrainian extends Resident
  case object Norwegian extends Resident
  case object Japanese extends Resident

  case class Solution(waterDrinker: Resident, zebraOwner: Resident)

  lazy val solve: Solution = solver().next()

  private def solver(): Iterator[Solution] = {
    for (
      nations <- Nation.permute
        if nations.indexOf(Nation.Norwegian) == 0;

      colors <- Color.permute
        if nations.indexOf(Nation.English) == colors.indexOf(Color.Red)
        if (nations.indexOf(Nation.Norwegian) - colors.indexOf(Color.Blue)).abs == 1
        if colors.indexOf(Color.Ivory) + 1 == colors.indexOf(Color.Green);

      smokes <- Smoke.permute
        if smokes.indexOf(Smoke.Kool) == colors.indexOf(Color.Yellow)
        if smokes.indexOf(Smoke.Parliament) == nations.indexOf(Nation.Japanese);

      animals <- Animal.permute
        if (smokes.indexOf(Smoke.Chesterfield) - animals.indexOf(Animal.Fox)).abs == 1
        if (smokes.indexOf(Smoke.Kool) - animals.indexOf(Animal.Horse)).abs == 1
        if nations.indexOf(Nation.Spanish) == animals.indexOf(Animal.Dog)
        if smokes.indexOf(Smoke.OldGold) == animals.indexOf(Animal.Snail);

      drinks <- Drink.permute
        if drinks.indexOf(Drink.Milk) == 2
        if nations.indexOf(Nation.Ukrainian) == drinks.indexOf(Drink.Tea)
        if colors.indexOf(Color.Green) == drinks.indexOf(Drink.Coffee)
        if smokes.indexOf(Smoke.LuckyStrike) == drinks.indexOf(Drink.OrangeJuice)
    ) yield {
      Solution(
        waterDrinker = nationToResident(nations(drinks.indexOf(Drink.Water)).toString),
        zebraOwner = nationToResident(nations(animals.indexOf(Animal.Zebra)).toString)
      )
    }
  }

  def nationToResident(nation: String): Resident =
    Nation.withName(nation) match {
      case Nation.English => Englishman
      case Nation.Spanish => Spaniard
      case Nation.Ukrainian => Ukrainian
      case Nation.Norwegian => Norwegian
      case Nation.Japanese => Japanese
    }
}

trait PermutableEnumeration extends Enumeration {
  def permute: Iterator[List[_]] = this.values.toList.permutations
}

object Nation extends PermutableEnumeration {
  type Nation = Value
  val English, Spanish, Ukrainian, Norwegian, Japanese = Value
}

object Color extends PermutableEnumeration {
  type Color = Value
  val Red, Green, Ivory, Yellow, Blue = Value
}

object Smoke extends PermutableEnumeration {
  type Smoke = Value
  val OldGold, Kool, Chesterfield, LuckyStrike, Parliament = Value
}

object Animal extends PermutableEnumeration {
  type Animal = Value
  val Dog, Snail, Fox, Horse, Zebra = Value
}

object Drink extends PermutableEnumeration {
  type Drink = Value
  val Coffee, Milk, OrangeJuice, Tea, Water = Value
}
