
using Pratice_OOP;

PredAlien predAlien = new PredAlien();
Vampire vampire = new Vampire();

BattleField battleField = new BattleField();

battleField.Add(predAlien);
battleField.Add(vampire);

battleField.Simulate();