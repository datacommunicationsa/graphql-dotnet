namespace GraphQL
{
    public static class StringExtensions
    {
        /// <summary>
        /// Equivalent to String.Format.
        /// </summary>
        /// <param name="format">The format string in String.Format style.</param>
        /// <param name="args">The arguments.</param>
        public static string ToFormat( this string format, params object[] args )
            => string.Format( format, args );

        /// <summary>
        /// Returns a camel case version of the string.
        /// </summary>
        /// <param name="s">The source string.</param>
        /// <returns>System.String.</returns>
        public static string ToCamelCase( this string s )
        {
            if ( string.IsNullOrWhiteSpace( s ) )
            {
                return string.Empty;
            }

            char newFirstLetter = char.ToLowerInvariant( s[0] );
            return newFirstLetter == s[0] ? s : newFirstLetter + s.Substring( 1 );
        }

        /// <summary>
        /// Returns a pascal case version of the string.
        /// </summary>
        /// <param name="s">The source string.</param>
        /// <returns>System.String.</returns>
        public static string ToPascalCase( this string s )
        {
            if ( string.IsNullOrWhiteSpace( s ) )
            {
                return string.Empty;
            }

            char newFirstLetter = char.ToUpperInvariant( s[0] );
            return newFirstLetter == s[0] ? s : newFirstLetter + s.Substring( 1 );
        }
    }
}
