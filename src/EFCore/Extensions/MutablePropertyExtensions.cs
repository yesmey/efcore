// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata;

// ReSharper disable once CheckNamespace
namespace Microsoft.EntityFrameworkCore
{
    /// <summary>
    ///     Extension methods for <see cref="IMutableProperty" />.
    /// </summary>
    [Obsolete("Use IMutableProperty")]
    public static class MutablePropertyExtensions
    {
        /// <summary>
        ///     Finds the list of principal properties including the given property that the given property is constrained by
        ///     if the given property is part of a foreign key.
        /// </summary>
        /// <param name="property"> The foreign key property. </param>
        /// <returns> The list of all associated principal properties including the given property. </returns>
        [Obsolete("Use IMutableProperty.GetPrincipals")]
        public static IReadOnlyList<IMutableProperty> FindPrincipals([NotNull] this IMutableProperty property)
            => property.GetPrincipals();

        /// <summary>
        ///     Sets the custom <see cref="ValueComparer" /> for this property when performing key comparisons.
        /// </summary>
        /// <param name="property"> The property. </param>
        /// <param name="comparer"> The comparer, or <see langword="null" /> to remove any previously set comparer. </param>
        [Obsolete("Use SetValueComparer. Only a single value comparer is allowed for a given property.")]
        public static void SetKeyValueComparer([NotNull] this IMutableProperty property, [CanBeNull] ValueComparer? comparer)
            => property.SetValueComparer(comparer);

        /// <summary>
        ///     Sets the custom <see cref="ValueComparer" /> for structural copies for this property.
        /// </summary>
        /// <param name="property"> The property. </param>
        /// <param name="comparer"> The comparer, or <see langword="null" /> to remove any previously set comparer. </param>
        [Obsolete("Use SetValueComparer. Only a single value comparer is allowed for a given property.")]
        public static void SetStructuralValueComparer([NotNull] this IMutableProperty property, [CanBeNull] ValueComparer? comparer)
            => property.SetValueComparer(comparer);
    }
}
