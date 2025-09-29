local Character = {}

local function ability(scores)
    table.sort(scores)
    return scores[4] + scores[3] + scores[2]
end

local function roll_dice()
    return {
        math.random(6),
        math.random(6),
        math.random(6),
        math.random(6)
    }
end

local function modifier(input)
    return math.floor((input - 10) / 2)
end

function Character:new(name)
    character = {}
    character.name = name
    character.strength = ability(roll_dice())
    character.dexterity = ability(roll_dice())
    character.constitution = ability(roll_dice())
    character.intelligence = ability(roll_dice())
    character.wisdom = ability(roll_dice())
    character.charisma = ability(roll_dice())
    character.hitpoints = 10 + modifier(character.constitution)
    setmetatable(character, self)
    self.__index = self
    return character
end

return {
  Character = Character,
  ability = ability,
  roll_dice = roll_dice,
  modifier = modifier
}
