﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.MSHTMLApi;

namespace NetOffice.MSHTMLApi.Behind
{
	/// <summary>
	/// DispatchInterface IHTMLAttributeCollection3 
	/// SupportByVersion MSHTML, 4
	/// </summary>
	[SupportByVersion("MSHTML", 4)]
	[EntityType(EntityType.IsDispatchInterface)]
 	public class IHTMLAttributeCollection3 : IHTMLAttributeCollection2, NetOffice.MSHTMLApi.IHTMLAttributeCollection3
	{
		#pragma warning disable

		#region Type Information

		/// <summary>
		/// Instance Type
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Advanced), Browsable(false), Category("NetOffice"), CoreOverridden]
		public override Type InstanceType
		{
			get
			{
				return LateBindingApiWrapperType;
			}
		}

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(IHTMLAttributeCollection3);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public IHTMLAttributeCollection3() : base()
		{

		}

		#endregion
		
		#region Properties



		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="pNodeIn">NetOffice.MSHTMLApi.IHTMLDOMAttribute pNodeIn</param>
		[SupportByVersion("MSHTML", 4)]
		[BaseResult]
		public virtual NetOffice.MSHTMLApi.IHTMLDOMAttribute setNamedItem(NetOffice.MSHTMLApi.IHTMLDOMAttribute pNodeIn)
		{
			return InvokerService.InvokeInternal.ExecuteBaseReferenceMethodGet<NetOffice.MSHTMLApi.IHTMLDOMAttribute>(this, "setNamedItem", pNodeIn);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="index">Int32 index</param>
		[SupportByVersion("MSHTML", 4)]
		[BaseResult]
		public virtual NetOffice.MSHTMLApi.IHTMLDOMAttribute item(Int32 index)
		{
			return InvokerService.InvokeInternal.ExecuteBaseReferenceMethodGet<NetOffice.MSHTMLApi.IHTMLDOMAttribute>(this, "item", index);
		}

		#endregion

		#pragma warning restore
	}
}

