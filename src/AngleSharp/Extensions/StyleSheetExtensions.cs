﻿namespace AngleSharp.Extensions
{
    using AngleSharp.Dom.Html;
    using AngleSharp.Html;
    using System;

    /// <summary>
    /// Defines a set of extension methods for style sheets.
    /// </summary>
    public static class StyleSheetExtensions
    {
        #region Linked Stylesheet States

        /// <summary>
        /// Gets if the link contains a stylesheet that is regarded persistent.
        /// </summary>
        /// <param name="link">The link to examine.</param>
        /// <returns>True if the link hosts a persistent stylesheet.</returns>
        public static Boolean IsPersistent(this IHtmlLinkElement link)
        {
            return link.Relation.Isi(LinkRelNames.StyleSheet) && link.Title == null;
        }

        /// <summary>
        /// Gets if the link contains a stylesheet that is regarded preferred.
        /// </summary>
        /// <param name="link">The link to examine.</param>
        /// <returns>True if the link hosts a preferred stylesheet.</returns>
        public static Boolean IsPreferred(this IHtmlLinkElement link)
        {
            return link.Relation.Isi(LinkRelNames.StyleSheet) && link.Title != null;
        }

        /// <summary>
        /// Gets if the link contains a stylesheet that is regarded alternate.
        /// </summary>
        /// <param name="link">The link to examine.</param>
        /// <returns>True if the link hosts an alternate stylesheet.</returns>
        public static Boolean IsAlternate(this IHtmlLinkElement link)
        {
            var relation = link.RelationList;
            return relation.Contains(LinkRelNames.StyleSheet) && relation.Contains(LinkRelNames.Alternate) && link.Title != null;
        }

        #endregion
    }
}
