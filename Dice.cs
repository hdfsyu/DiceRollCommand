using System;
using MCGalaxy;
using MCGalaxy.Commands;


namespace server {

  //This part specifies info about the plugin
  public sealed class DiceGame : Plugin {
    public override string name { get { return "The Dice Game"; } }
    public override string creator { get { return "hdfsyu"; } }
    public override string MCGalaxy_Version { get { return "1.9.1.9"; } }

  //This part runs when the plugin is loaded
    public override void Load(bool startup) {
			Command.Register(new CmdDice());

			Chat.MessageGlobal("The Dice Game plugin loaded!");
		}

  //This part runs when the plugin is unloaded
  //Make sure you unregister any commands
  //you have registered in Load()
    public override void Unload(bool shutdown) {
			Command.Unregister(Command.Find("DiceRoll"));

			Chat.MessageGlobal("The Dice Game plugin unloaded!");
		}
  }


  //Registering our command
  public class CmdDice : Command {
    //You use this name to actually run the command
    //So in this case we make the command be activated with /dice
    public override string name { get { return "DiceRoll"; }}
    //A shortcut to use in-game. Quite interestingly the shortcut can be longer
    //than the name
    public override string shortcut { get { return "dice"; }}
    //Category of the plugin
    public override string type { get { return "Games"; }}
    //The lowest rank that can use the command
    public override LevelPermission defaultRank { get { return LevelPermission.Guest; }}




    //This is the actual function that happens
    //when you use it in the in-game chat
    public override void Use(Player p, string message) {
    //Create a randomizator object
    Random random = new Random();

    //Create a variable called 'dice1'
    //And assign it a random random from 0 to 7 (7 will not be included)
    int dice1 = random.Next(0, 7);

    //Same for the second dice
    int dice2 = random.Next(0, 7);

    //Create a variable that's the sum of the both dice to calculate total points
    int score = dice1 + dice2;


    Chat.MessageGlobal(p.name + " &fhas rolled &a" + dice1 +
    "&f and &a" + dice2 + "&f in Dice!");
    Chat.MessageGlobal("&fThat's &a" + score + "&f points!");

    }

    public override void Help(Player p) {
      p.Message("/dice - Uses 2 dices and generates a random number between 1-6 then calculates the total!");
    }

  }


}
