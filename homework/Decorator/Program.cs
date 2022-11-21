using Decorator;

IGigantosaurus gigantosaurus = new Gigantosaurus();
gigantosaurus = new LoudGigantosarusDecorator(gigantosaurus);
gigantosaurus = new ExtraLoudGigantosaurusDecorator(gigantosaurus);

Console.WriteLine(gigantosaurus.Roar());