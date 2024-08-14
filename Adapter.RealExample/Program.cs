using Adapter.RealWorld;

/// <summary>
/// Adapter Design Pattern
/// </summary>

// Non-adapted chemical compound 
Compound compound = new();
compound.Display();

// Adapted chemical compounds
var water = new RichCompound(Chemical.Water);
water.Display();

var benzene = new RichCompound(Chemical.Benzene);
benzene.Display();
var ethanol = new RichCompound(Chemical.Ethanol);
ethanol.Display();
