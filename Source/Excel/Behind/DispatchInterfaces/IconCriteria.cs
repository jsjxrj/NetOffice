﻿using System.Collections;
using System.Collections.Generic;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.CollectionsGeneric;
using NetOffice.ExcelApi;

namespace NetOffice.ExcelApi.Behind
{
	/// <summary>
	/// DispatchInterface IconCriteria 
	/// SupportByVersion Excel, 12,14,15,16
	/// </summary>	/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff838790.aspx </remarks>
	[SupportByVersion("Excel", 12,14,15,16)]
	[EntityType(EntityType.IsDispatchInterface), Enumerator(Enumerator.Reference, EnumeratorInvoke.Property), HasIndexProperty(IndexInvoke.Property, "_Default")]
	public class IconCriteria : COMObject, NetOffice.ExcelApi.IconCriteria
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
                    _type = typeof(IconCriteria);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public IconCriteria() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff194608.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual Int32 Count
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "Count");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("Excel", 12,14,15,16)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
		public virtual NetOffice.ExcelApi.IconCriterion this[object index]
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.IconCriterion>(this, "_Default", typeof(NetOffice.ExcelApi.IconCriterion), index);
			}
		}

        #endregion

        #region Methods

        #endregion

        #region IEnumerableProvider<NetOffice.ExcelApi.IconCriterion>

        ICOMObject IEnumerableProvider<NetOffice.ExcelApi.IconCriterion>.GetComObjectEnumerator(ICOMObject parent)
        {
            return NetOffice.Utils.GetComObjectEnumeratorAsProperty(parent, this, false);
        }

        IEnumerable IEnumerableProvider<NetOffice.ExcelApi.IconCriterion>.FetchVariantComObjectEnumerator(ICOMObject parent, ICOMObject enumerator)
        {
            return NetOffice.Utils.FetchVariantComObjectEnumerator(parent, enumerator, false);
        }

        #endregion

        #region IEnumerable<NetOffice.ExcelApi.IconCriterion>

        /// <summary>
        /// SupportByVersion Excel, 12,14,15,16
        /// </summary>
        [SupportByVersion("Excel", 12, 14, 15, 16)]
        public virtual IEnumerator<NetOffice.ExcelApi.IconCriterion> GetEnumerator()
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.ExcelApi.IconCriterion item in innerEnumerator)
                yield return item;
        }

        #endregion

        #region IEnumerable

        /// <summary>
        /// SupportByVersion Excel, 12,14,15,16
        /// </summary>
        [SupportByVersion("Excel", 12,14,15,16)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this, false);
		}

		#endregion

		#pragma warning restore
	}
}

