﻿using Mafi;
using Mafi.Base;
using Mafi.Core;
using Mafi.Core.Mods;
using StreetMod;

namespace StreetsMod {
	public sealed class Mod : DataOnlyMod {

		public override string Name => "Street mod";


		// Constructor that lists mod dependencies as parameters. You probably want to depend on both core and base
		// mods so this mod will be initialized after them.
		public Mod(CoreMod coreMod, BaseMod baseMod) {
			Log.Info("My mod was created!");
		}

		public override void RegisterPrototypes(ProtoRegistrator registrator) {
			// Register all prototypes here.

			// Registers all products from this assembly. See MyIds.Products.cs for examples.
			registrator.RegisterAllProducts();

			// Use data class registration to register other protos such as machines, recipes, etc.
			registrator.RegisterData<RecipesData>();
			registrator.RegisterData<RockCrusherData>();

			// Registers all research from this assembly. See ExampleResearchData.cs for examples.
			registrator.RegisterDataWithInterface<IResearchNodesData>();

		}

	}
}
