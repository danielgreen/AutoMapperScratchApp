Console.WriteLine("AutoMapper scratch app");

TestProfileA();
TestProfileB();

Console.WriteLine("done");

void TestProfileA()
{
    var config = new MapperConfiguration(c => c.AddProfile<ProfileA>());
    config.AssertConfigurationIsValid();

    var mapper = config.CreateMapper();
    var boo = new Boo { FooText = "Hi" };
    var foo = mapper.Map<Foo>(boo);

    Console.WriteLine("Testing ProfileA - what is the value of Foo.FooText?");
    Console.WriteLine(foo.FooText ?? "(null)");
    Console.WriteLine();
}

void TestProfileB()
{
    var config = new MapperConfiguration(c => c.AddProfile<ProfileB>());
    config.AssertConfigurationIsValid();

    var mapper = config.CreateMapper();
    var boo = new Boo { FooText = "Hi" };
    var foo = mapper.Map<Foo>(boo);

    Console.WriteLine("Testing ProfileB - what is the value of Foo.FooText?");
    Console.WriteLine(foo.FooText ?? "(null)");
    Console.WriteLine();
}