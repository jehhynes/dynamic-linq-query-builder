﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Castle.DynamicLinqQueryBuilder
{
    /// <summary>
    /// This class is used to define a hierarchical filter for a given collection.
    /// </summary>
    [ExcludeFromCodeCoverage]
    [Obsolete("This type is deprecated in favor of QueryBuilderFilterRule or JsonNetFilterRule - see Wiki for more")]
    public class FilterRule : IFilterRule
    {
        /// <summary>
        /// Condition - acceptable values are "and" and "or".
        /// </summary>
        /// <value>
        /// The condition.
        /// </value>
        public string Condition { get; set; }
        /// <summary>
        /// The name of the field that the filter applies to.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public string Field { get; set; }
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }
        /// <summary>
        /// Gets or sets the input.
        /// </summary>
        /// <value>
        /// The input.
        /// </value>
        public string Input { get; set; }
        /// <summary>
        /// Gets or sets the operator.
        /// </summary>
        /// <value>
        /// The operator.
        /// </value>
        public string Operator { get; set; }
        /// <summary>
        /// Gets or sets nested filter rules.
        /// </summary>
        /// <value>
        /// The rules.
        /// </value>
        public List<FilterRule> Rules { get; set; }
        /// <summary>
        /// Gets or sets the type. Supported values are "integer", "double", "string", "date", "datetime", and "boolean".
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public string Type { get; set; }
        /// <summary>
        /// Gets or sets the value of the filter.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public string Value { get; set; }
        /// <summary>
        /// Gets or sets whether the rule is negated.
        /// </summary>
        /// <value>
        /// Whether the rule is negated.
        /// </value>
        public bool Not { get; set; }

        IEnumerable<IFilterRule> IFilterRule.Rules => Rules;
        object IFilterRule.Value => Value;
    }
}
