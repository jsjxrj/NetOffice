﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.MSHTMLApi
{
	/// <summary>
	/// DispatchInterface IHTMLControlRange2 
	/// SupportByVersion MSHTML, 4
	/// </summary>
	[SupportByVersion("MSHTML", 4)]
	[EntityType(EntityType.IsDispatchInterface)]
	[TypeId("3050F65E-98B5-11CF-BB82-00AA00BDCE0B")]
	public interface IHTMLControlRange2 : ICOMObject
	{
		#region Methods

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="item">NetOffice.MSHTMLApi.IHTMLElement item</param>
		[SupportByVersion("MSHTML", 4)]
		void addElement(NetOffice.MSHTMLApi.IHTMLElement item);

		#endregion
	}
}
