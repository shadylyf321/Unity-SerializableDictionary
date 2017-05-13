﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Text;

public static class DebugUtilsEditor
{
	public static string ToString(SerializedProperty property)
	{
		StringBuilder sb = new StringBuilder();
		var iterator = property.Copy();
		var end = property.GetEndProperty();
		do
		{
			sb.AppendLine(iterator.propertyPath + " (" + iterator.type + " " + iterator.propertyType + ") = " + SerializableDictionaryPropertyDrawer.GetPropertyValue(iterator) + (iterator.isArray ? " (" + iterator.arrayElementType + ")" : ""));
		} while(iterator.Next(true) && iterator.propertyPath != end.propertyPath);
		return sb.ToString();
	}
}
