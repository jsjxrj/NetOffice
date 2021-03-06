﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.ADODBApi;

namespace NetOffice.ADODBApi.Behind
{
	/// <summary>
	/// DispatchInterface Field15_Deprecated 
	/// SupportByVersion ADODB, 2.5
	/// </summary>
	[SupportByVersion("ADODB", 2.5)]
	[EntityType(EntityType.IsDispatchInterface)]
 	public class Field15_Deprecated : _ADO, NetOffice.ADODBApi.Field15_Deprecated
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
                    _type = typeof(Field15_Deprecated);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public Field15_Deprecated() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion ADODB 2.5
		/// Get
		/// </summary>
		[SupportByVersion("ADODB", 2.5)]
		public virtual Int32 ActualSize
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "ActualSize");
			}
		}

		/// <summary>
		/// SupportByVersion ADODB 2.5
		/// Get
		/// </summary>
		[SupportByVersion("ADODB", 2.5)]
		public virtual Int32 Attributes
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "Attributes");
			}
		}

		/// <summary>
		/// SupportByVersion ADODB 2.5
		/// Get
		/// </summary>
		[SupportByVersion("ADODB", 2.5)]
		public virtual Int32 DefinedSize
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "DefinedSize");
			}
		}

		/// <summary>
		/// SupportByVersion ADODB 2.5
		/// Get
		/// </summary>
		[SupportByVersion("ADODB", 2.5)]
		public virtual string Name
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Name");
			}
		}

		/// <summary>
		/// SupportByVersion ADODB 2.5
		/// Get
		/// </summary>
		[SupportByVersion("ADODB", 2.5)]
		public virtual NetOffice.ADODBApi.Enums.DataTypeEnum Type
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ADODBApi.Enums.DataTypeEnum>(this, "Type");
			}
		}

		/// <summary>
		/// SupportByVersion ADODB 2.5
		/// Get/Set
		/// </summary>
		[SupportByVersion("ADODB", 2.5)]
		public virtual object Value
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Value");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Value", value);
			}
		}

		/// <summary>
		/// SupportByVersion ADODB 2.5
		/// Get
		/// </summary>
		[SupportByVersion("ADODB", 2.5)]
		public virtual byte Precision
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBytePropertyGet(this, "Precision");
			}
		}

		/// <summary>
		/// SupportByVersion ADODB 2.5
		/// Get
		/// </summary>
		[SupportByVersion("ADODB", 2.5)]
		public virtual byte NumericScale
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBytePropertyGet(this, "NumericScale");
			}
		}

		/// <summary>
		/// SupportByVersion ADODB 2.5
		/// Get
		/// </summary>
		[SupportByVersion("ADODB", 2.5)]
		public virtual object OriginalValue
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "OriginalValue");
			}
		}

		/// <summary>
		/// SupportByVersion ADODB 2.5
		/// Get
		/// </summary>
		[SupportByVersion("ADODB", 2.5)]
		public virtual object UnderlyingValue
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "UnderlyingValue");
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion ADODB 2.5
		/// </summary>
		/// <param name="data">object data</param>
		[SupportByVersion("ADODB", 2.5)]
		public virtual void AppendChunk(object data)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "AppendChunk", data);
		}

		/// <summary>
		/// SupportByVersion ADODB 2.5
		/// </summary>
		/// <param name="length">Int32 length</param>
		[SupportByVersion("ADODB", 2.5)]
		public virtual object GetChunk(Int32 length)
		{
			return InvokerService.InvokeInternal.ExecuteVariantMethodGet(this, "GetChunk", length);
		}

		#endregion

		#pragma warning restore
	}
}

