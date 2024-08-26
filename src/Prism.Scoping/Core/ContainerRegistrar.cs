namespace Prism.Scoping.Core;

public abstract class ContainerRegistrar
{
    protected internal abstract IContainerRegistry Register(IContainerRegistry containerRegistry);
}