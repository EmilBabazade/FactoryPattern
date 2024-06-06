using SimpleFactory;

var weazelsRUs = new CarRetailer();
var aston = weazelsRUs.Sell("aston martin");
var lada = weazelsRUs.Sell("lada");
var reno = weazelsRUs.Sell("reno");
var bobcat = weazelsRUs.Sell("bobcat");