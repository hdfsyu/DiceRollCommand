//	Auto-generated command skeleton class.
//	Use this as a basis for custom MCGalaxy commands.
//	Naming should be kept consistent. (e.g. /update command should have a class name of 'CmdUpdate' and a filename of 'CmdUpdate.cs')
// As a note, MCGalaxy is designed for .NET 4.0

// To reference other assemblies, put a "//reference [assembly filename]" at the top of the file
//   e.g. to reference the System.Data assembly, put "//reference System.Data.dll"

// Add any other using statements you need after this
using System;

namespace MCGalaxy 
{
	public class CmdDiceroll : Command
	{
		// The command's name (what you put after a slash to use this command)
		public override string name { get { return "DiceRoll"; } }

		// Command's shortcut, can be left blank (e.g. "/Copy" has a shortcut of "c")
		public override string shortcut { get { return "dice"; } }

		// Which submenu this command displays in under /Help
		public override string type { get { return "Games"; } }

		// Whether or not this command can be used in a museum. Block/map altering commands should return false to avoid errors.
		public override bool museumUsable { get { return true; } }

		// The default rank required to use this command. Valid values are:
		//   LevelPermission.Guest, LevelPermission.Builder, LevelPermission.AdvBuilder,
		//   LevelPermission.Operator, LevelPermission.Admin, LevelPermission.Nobody
		public override LevelPermission defaultRank { get { return LevelPermission.Guest; } }

		// This is for when a player executes this command by doing /Diceroll
		//   p is the player object for the player executing the command. 
		//   message is the arguments given to the command. (e.g. for '/Diceroll this', message is "this")
		public override void Use(Player p, string message)
		{
			Random random = new Random();
			int dice1 = random.Next(1,6);
			int dice2 = random.Next(1,6);
			int score = dice1 + dice2;
			    Chat.MessageGlobal(p.name + " &fhas rolled &a" + dice1 + "&f and &a" + dice2 + "&f in Dice!");
    			Chat.MessageGlobal("&fThat's &a" + score + "&f points!");
		}

		// This is for when a player does /Help Diceroll
		public override void Help(Player p)
		{
			p.Message("/DiceRoll - Rolls 2 dices and generates a random number between 1-6 using the 2 dices, then calculates the total!");
		}
	}
}