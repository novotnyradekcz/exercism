const Nationality = {
  englishman : 'Englishman',
  spaniard   : 'Spaniard',
  ukrainian  : 'Ukrainian',
  norwegian  : 'Norwegian',
  japanese   : 'Japanese',
}
const Color = {
  red    : 'red',
  green  : 'green',
  ivory  : 'ivory',
  yellow : 'yellow',
  blue   : 'blue',
}
const Pet = {
  dog    : 'dog',
  snails : 'snails',
  fox    : 'fox',
  horse  : 'horse',
  zebra  : 'zebra',
}
const Beverage = {
  coffee      : 'coffee',
  tea         : 'tea',
  milk        : 'milk',
  orangeJuice : 'orangeJuice',
  water       : 'water',
}
const Tobacco = {
  oldGold       : 'oldGold',
  kools         : 'kools',
  chesterfields : 'chesterfields',
  luckyStrike   : 'luckyStrike',
  parliaments   : 'parliaments',
}

class House {
  houseNo     = 0
  nationality = undefined
  color       = undefined
  pet         = undefined
  beverage    = undefined
  tobacco     = undefined

  constructor(houseNo,nationality,color,pet,beverage,tobacco) {
    this.houseNo      = houseNo
    this.nationality  = nationality
    this.color        = color
    this.pet          = pet
    this.beverage     = beverage
    this.tobacco      = tobacco
  }

  static from(houseNo, attr) {
    return new House(houseNo,
      attr?.nationality,
      attr?.color,
      attr?.pet,
      attr?.beverage,
      attr?.tobacco
    )
  }
}

export class ZebraPuzzle {

  solution = []

  constructor() {
    this.solve()
  }

  waterDrinker() {
    return this.solution.find(house => house.beverage == Beverage.water)?.nationality
  }

  zebraOwner() {
    return this.solution.find(house => house.pet == Pet.zebra)?.nationality
  }

  solve() {
    // Template houses with known house-specific facts.
    var templates = [
      // The Norwegian lives in the first house.
      House.from(0, {nationality: Nationality.norwegian}),
      // The Norwegian lives next to the blue house.
      House.from(1, {color: Color.blue}),
      // Milk is drunk in the middle house.
      House.from(2, {beverage: Beverage.milk}),
      House.from(3, {}),
      House.from(4, {}),
    ]
    var attributes  = this.getValidAttributes()
    var houses      = []

    var usedAttributes = {
      nationality : new Set(),
      color       : new Set(),
      pet         : new Set(),
      beverage    : new Set(),
      tobacco     : new Set()
    }

    // Generate variant for all houses from templates and valid non-used attributes.
    for(var house0 of this.getHouseVariants(templates[0], attributes, usedAttributes)) {
      this.addHouse(houses, usedAttributes, house0)
      for(var house1 of this.getHouseVariants(templates[1], attributes, usedAttributes)) {
        this.addHouse(houses, usedAttributes, house1)
        for(var house2 of this.getHouseVariants(templates[2], attributes, usedAttributes)) {
          this.addHouse(houses, usedAttributes, house2)
          for(var house3 of this.getHouseVariants(templates[3], attributes, usedAttributes)) {
            this.addHouse(houses, usedAttributes, house3)
            for(var house4 of this.getHouseVariants(templates[4], attributes, usedAttributes)) {
              this.addHouse(houses, usedAttributes, house4)

              // Verify full set of generated houses.
              if(this.verifySolution(houses)) {
                this.solution = houses
                return
              }

              this.removeHouse(houses, usedAttributes, house4)
            }
            this.removeHouse(houses, usedAttributes, house3)
          }
          this.removeHouse(houses, usedAttributes, house2)
        }
        this.removeHouse(houses, usedAttributes, house1)
      }
      this.removeHouse(houses, usedAttributes, house0)
    }
  }

  getHouseVariants(house, attributes, used) {
    var houses = []

    for(var attribute of attributes) {
      // Do not use if already used.
      if(this.isAnyAttributeUsed(attribute, used))
        continue

      // Skip alternative house if attribute already set from template house.
      if(!this.attributesApplicableOnTemplate(house, attribute))
        continue

      // Add as valid house alternative.
      houses.push(House.from(house.houseNo, attribute))
    }

    return houses
  }

  isAnyAttributeUsed(attribute, used) {
    return used.nationality.has(attribute.nationality) ||
      used.color.has(attribute.color) ||
      used.pet.has(attribute.pet) ||
      used.beverage.has(attribute.beverage) ||
      used.tobacco.has(attribute.tobacco)
  }

  attributesApplicableOnTemplate(template, attribute) {
    return (template.nationality ?? attribute.nationality) == attribute.nationality &&
      (template.color ?? attribute.color) == attribute.color &&
      (template.pet ?? attribute.pet) == attribute.pet &&
      (template.beverage ?? attribute.beverage) == attribute.beverage &&
      (template.tobacco ?? attribute.tobacco) == attribute.tobacco
  }

  addHouse(houses, used, house) {
    houses.push(house)
    if(house.nationality)
      used.nationality.add(house.nationality)
    if(house.color)
      used.color.add(house.color)
    if(house.pet)
      used.pet.add(house.pet)
    if(house.beverage)
      used.beverage.add(house.beverage)
    if(house.tobacco)
      used.tobacco.add(house.tobacco)
  }

  removeHouse(houses, used, house) {
    var index = houses.findIndex(h => h.houseNo == house.houseNo)
    if(index != -1)
      houses.splice(index, 1)
    if(house.nationality)
      used.nationality.delete(house.nationality)
    if(house.color)
      used.color.delete(house.color)
    if(house.pet)
      used.pet.delete(house.pet)
    if(house.beverage)
      used.beverage.delete(house.beverage)
    if(house.tobacco)
      used.tobacco.delete(house.tobacco)
  }

  getValidAttributes() {
    var validAttributes = []

    for(var nationality of Object.values(Nationality))
      for(var color of Object.values(Color))
        for(var pet of Object.values(Pet))
          for(var beverage of Object.values(Beverage))
            for(var tobacco of Object.values(Tobacco)) {
              var attributes = {
                nationality : nationality,
                color       : color,
                pet         : pet,
                beverage    : beverage,
                tobacco     : tobacco
              }
              if(this.validateAttributes(attributes))
                validAttributes.push(attributes)
            }

    return validAttributes
  }

  validateAttributes(attribute) {

    // The Englishman lives in the red house.
    if(attribute.nationality == Nationality.englishman && attribute.color != Color.red ||
       attribute.color == Color.red && attribute.nationality != Nationality.englishman)
      return false;

    // The Spaniard owns the dog.
    if(attribute.nationality == Nationality.spaniard && attribute.pet != Pet.dog ||
       attribute.pet == Pet.dog && attribute.nationality != Nationality.spaniard)
      return false;

    // Coffee is drunk in the green house.
    if(attribute.color == Color.green && attribute.beverage != Beverage.coffee ||
       attribute.beverage == Beverage.coffee && attribute.color != Color.green)
      return false;

    // The Ukrainian drinks tea.
    if(attribute.nationality == Nationality.ukrainian && attribute.beverage != Beverage.tea ||
       attribute.beverage == Beverage.tea && attribute.nationality != Nationality.ukrainian)
      return false;

    // The Old Gold smoker owns snails.
    if(attribute.tobacco == Tobacco.oldGold && attribute.pet != Pet.snails ||
       attribute.pet == Pet.snails && attribute.tobacco != Tobacco.oldGold)
      return false;

    // Kools are smoked in the yellow house.
    if(attribute.color == Color.yellow && attribute.tobacco != Tobacco.kools ||
       attribute.tobacco == Tobacco.kools && attribute.color != Color.yellow)
      return false;

    // The Lucky Strike smoker drinks orange juice.
    if(attribute.tobacco == Tobacco.luckyStrike && attribute.beverage != Beverage.orangeJuice ||
       attribute.beverage == Beverage.orangeJuice && attribute.tobacco != Tobacco.luckyStrike)
      return false;

    // The Japanese smokes Parliaments.
    if(attribute.nationality == Nationality.japanese && attribute.tobacco != Tobacco.parliaments ||
       attribute.tobacco == Tobacco.parliaments && attribute.nationality != Nationality.japanese)
      return false;

    return true
  }

  verifySolution(houses) {

    for(var house of houses) {
      // The green house is immediately to the right of the ivory house.
      if(house.color == Color.ivory &&
         (house.houseNo >= houses.length-1 || houses[house.houseNo+1].color != Color.green))
        return false;

      // The man who smokes Chesterfields lives in the house next to the man with the fox.
      if(house.tobacco == Tobacco.chesterfields &&
         !(
           (house.houseNo > 0 && houses[house.houseNo-1].pet == Pet.fox) ||
           (house.houseNo < houses.length-1 && houses[house.houseNo+1].pet == Pet.fox)
         ))
        return false;

      // Kools are smoked in the house next to the house where the horse is kept.
      if(house.tobacco == Tobacco.kools &&
         !(
           (house.houseNo > 0 && houses[house.houseNo-1].pet == Pet.horse) ||
           (house.houseNo < houses.length-1 && houses[house.houseNo+1].pet == Pet.horse)
         ))
        return false;
    }

    return true
  }

}
