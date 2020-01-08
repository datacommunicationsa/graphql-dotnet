using System.Reflection;

namespace GraphQL.Types
{
    public interface IInputObjectGraphType : IComplexGraphType
    {
    }

    public class InputObjectGraphType : InputObjectGraphType<object>
    {
    }

    public class InputObjectGraphType<TSourceType> : ComplexGraphType<TSourceType>, IInputObjectGraphType
    {
        // TODO: kapiris additions - need PR!
        /*
            public override string CollectTypes(TypeCollectionContext context)
        {
            var typeInfo = GetType().GetTypeInfo();
            var innerType = typeInfo.IsGenericType ? typeInfo.GenericTypeArguments[0] : null;
            return typeInfo.IsGenericType
                && !innerType.IsGraphType()
                && innerType.GetTypeInfo().IsClass
                ? GetType().GetFriendlyName()
                : base.CollectTypes(context);
        }
        */
    }
}

