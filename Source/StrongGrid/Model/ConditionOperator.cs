﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace StrongGrid.Model
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ConditionOperator
	{
		[EnumMember(Value = "eq")]
		Equal,
		[EnumMember(Value = "ne")]
		NotEqual,
		[EnumMember(Value = "lt")]
		LessThan,
		[EnumMember(Value = "gt")]
		GreatherThan,
		[EnumMember(Value = "contains")]
		Contains
	}
}
