﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.OWC10Api;

namespace NetOffice.OWC10Api.Behind
{
	/// <summary>
	/// DispatchInterface IAddinHost 
	/// SupportByVersion OWC10, 1
	/// </summary>
	[SupportByVersion("OWC10", 1)]
	[EntityType(EntityType.IsDispatchInterface)]
 	public class IAddinHost : COMObject, NetOffice.OWC10Api.IAddinHost
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
                    _type = typeof(IAddinHost);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public IAddinHost() : base()
		{

		}

		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion OWC10 1
		/// </summary>
		/// <param name="varoper">object varoper</param>
		/// <param name="grbit">NetOffice.OWC10Api.Enums.AddinClientTypeEnum grbit</param>
		[SupportByVersion("OWC10", 1)]
		public virtual object CoerceOper(object varoper, NetOffice.OWC10Api.Enums.AddinClientTypeEnum grbit)
		{
			return InvokerService.InvokeInternal.ExecuteVariantMethodGet(this, "CoerceOper", varoper, grbit);
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// </summary>
		[SupportByVersion("OWC10", 1)]
		public virtual object RandOper()
		{
			return InvokerService.InvokeInternal.ExecuteVariantMethodGet(this, "RandOper");
		}

		#endregion

		#pragma warning restore
	}
}

