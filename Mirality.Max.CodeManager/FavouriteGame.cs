using System;
using System.Xml.Serialization;
using Mirality.Max.MaxCodes;
using x3a260771fe762331;

namespace Mirality.Max.CodeManager;

public class FavouriteGame
{
	[XmlAttribute("Id")]
	public uint GameId;

	public string Name;

	public RegionCode Region = RegionCode.Unknown;

	public static FavouriteGame x7fb4a4853286849b(GameEntry game)
	{
		if (game == null)
		{
			throw new ArgumentNullException("game");
		}
		return new FavouriteGame(game.x52b8174788d367f9, game.Name, game.Region);
	}

	public FavouriteGame()
	{
	}

	public FavouriteGame(uint xeaf1b27180c0557b, string xc15bd84e01929885, RegionCode xa4d52e34b62b5495)
		: this()
	{
		GameId = xeaf1b27180c0557b;
		Name = xc15bd84e01929885;
		Region = xa4d52e34b62b5495;
	}
}
