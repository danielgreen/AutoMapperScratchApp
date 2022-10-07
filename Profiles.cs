namespace ScratchApp;

public class ProfileA : Profile
{
    public ProfileA()
    {
        this.CreateMap<object, IFoo>()
            .ForMember(d => d.FooText, o => o.Ignore())
            .IncludeAllDerived();

        this.CreateMap<Bar, IFoo>()
            .ForMember(d => d.FooText, o => o.MapFrom(s => s.FooText))
            .IncludeAllDerived();

        this.CreateMap<Boo, Foo>();
    }
}

public class ProfileB : Profile
{
    public ProfileB()
    {
        this.CreateMap<Bar, IFoo>()
            .ForMember(d => d.FooText, o => o.MapFrom(s => s.FooText))
            .IncludeAllDerived();

        this.CreateMap<object, IFoo>()
            .ForMember(d => d.FooText, o => o.Ignore())
            .IncludeAllDerived();

        this.CreateMap<Boo, Foo>();
    }
}
