﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.PowerPointApi
{
	/// <summary>
	/// DispatchInterface PPDropDownEdit 
	/// SupportByVersion PowerPoint, 9
	/// </summary>
	[SupportByVersion("PowerPoint", 9)]
	[EntityType(EntityType.IsDispatchInterface)]
	[TypeId("914934B6-5A91-11CF-8700-00AA0060263B")]
	public interface PPDropDownEdit : PPControl
	{
		#region Properties

		/// <summary>
		/// SupportByVersion PowerPoint 9
		/// Get
		/// </summary>
		[SupportByVersion("PowerPoint", 9)]
		NetOffice.PowerPointApi.PPStrings Strings { get; }

		/// <summary>
		/// SupportByVersion PowerPoint 9
		/// Get/Set
		/// </summary>
		[SupportByVersion("PowerPoint", 9)]
		Int32 FocusItem { get; set; }

		/// <summary>
		/// SupportByVersion PowerPoint 9
		/// Get/Set
		/// </summary>
		[SupportByVersion("PowerPoint", 9)]
		string OnSelectionChange { get; set; }

		/// <summary>
		/// SupportByVersion PowerPoint 9
		/// Get/Set
		/// </summary>
		[SupportByVersion("PowerPoint", 9)]
		string OnEdit { get; set; }

		#endregion

	}
}
