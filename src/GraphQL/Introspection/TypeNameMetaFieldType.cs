using GraphQL.Resolvers;
using GraphQL.Types;

namespace GraphQL.Introspection
{
    public class TypeNameMetaFieldType : FieldType
    {
        public TypeNameMetaFieldType()
        {
            Name = "__typename";
            Type = typeof(NonNullGraphType<StringGraphType>);
            Description = "The name of the current Object type at runtime.";
            Resolver = new FuncFieldResolver<object>(context => context.ParentType.Name);

            // TODO: kapiris additions - need PR!
            /*
            Resolver = new FuncFieldResolver<object>((context) =>
            {
                if (context.ParentType.IsCompositeType()
                    && context.ParentType.GetType().GetGenericTypeDefinition() == typeof(ObjectGraphType<>))
                {
                    return $"ObjectGraphType<{context.ParentType.GetType().GetGenericArguments()[0]?.Name}>";
                }

                return context.ParentType.Name;
            });
            */
        }
    }
}
