namespace Prism.Scoping.Root;

public abstract class ContainerRegistrar
{
    protected internal abstract IContainerRegistry Register(IContainerRegistry containerRegistry);
}