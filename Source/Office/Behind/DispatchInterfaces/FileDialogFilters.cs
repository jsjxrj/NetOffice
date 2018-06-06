﻿using System.Collections;
using System.Collections.Generic;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.CollectionsGeneric;
using NetOffice.OfficeApi;

namespace NetOffice.OfficeApi.Behind
{
    /// <summary>
    /// DispatchInterface FileDialogFilters 
    /// SupportByVersion Office, 10,11,12,14,15,16
    /// </summary>
    /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff863542.aspx </remarks>
    [SupportByVersion("Office", 10,11,12,14,15,16)]
	[EntityType(EntityType.IsDispatchInterface), Enumerator(Enumerator.Reference, EnumeratorInvoke.Property), HasIndexProperty(IndexInvoke.Method, "Item")]
	public class FileDialogFilters : NetOffice.OfficeApi.Behind._IMsoDispObj, NetOffice.OfficeApi.FileDialogFilters
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
                    _type = typeof(FileDialogFilters);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public FileDialogFilters() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15, 16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff865321.aspx </remarks>
		[SupportByVersion("Office", 10,11,12,14,15,16), ProxyResult]
		public virtual object Parent
		{
			get
			{
				return Factory.ExecuteReferencePropertyGet(this, "Parent");
			}
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff860290.aspx </remarks>
		[SupportByVersion("Office", 10,11,12,14,15,16)]
		public virtual Int32 Count
		{
			get
			{
				return Factory.ExecuteInt32PropertyGet(this, "Count");
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="index">Int32 index</param>
		[SupportByVersion("Office", 10,11,12,14,15,16)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
		public virtual NetOffice.OfficeApi.FileDialogFilter this[Int32 index]
		{
			get
			{
				return Factory.ExecuteKnownReferenceMethodGet<NetOffice.OfficeApi.FileDialogFilter>(this, "Item", typeof(NetOffice.OfficeApi.FileDialogFilter), index);
			}
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff862434.aspx </remarks>
		/// <param name="filter">optional object filter</param>
		[SupportByVersion("Office", 10,11,12,14,15,16)]
		public virtual void Delete(object filter)
		{
			 Factory.ExecuteMethod(this, "Delete", filter);
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff862434.aspx </remarks>
		[CustomMethod]
		[SupportByVersion("Office", 10,11,12,14,15,16)]
		public virtual void Delete()
		{
			 Factory.ExecuteMethod(this, "Delete");
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff860610.aspx </remarks>
		[SupportByVersion("Office", 10,11,12,14,15,16)]
		public virtual void Clear()
		{
			 Factory.ExecuteMethod(this, "Clear");
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff865351.aspx </remarks>
		/// <param name="description">string description</param>
		/// <param name="extensions">string extensions</param>
		/// <param name="position">optional object position</param>
		[SupportByVersion("Office", 10,11,12,14,15,16)]
		public virtual NetOffice.OfficeApi.FileDialogFilter Add(string description, string extensions, object position)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.OfficeApi.FileDialogFilter>(this, "Add", typeof(NetOffice.OfficeApi.FileDialogFilter), description, extensions, position);
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff865351.aspx </remarks>
		/// <param name="description">string description</param>
		/// <param name="extensions">string extensions</param>
		[CustomMethod]
		[SupportByVersion("Office", 10,11,12,14,15,16)]
		public virtual NetOffice.OfficeApi.FileDialogFilter Add(string description, string extensions)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.OfficeApi.FileDialogFilter>(this, "Add", typeof(NetOffice.OfficeApi.FileDialogFilter), description, extensions);
		}

        #endregion

        #region IEnumerableProvider<NetOffice.OfficeApi.FileDialogFilter>

        ICOMObject IEnumerableProvider<NetOffice.OfficeApi.FileDialogFilter>.GetComObjectEnumerator(ICOMObject parent)
        {
            return NetOffice.Utils.GetComObjectEnumeratorAsProperty(parent, this, false);
        }

        IEnumerable IEnumerableProvider<NetOffice.OfficeApi.FileDialogFilter>.FetchVariantComObjectEnumerator(ICOMObject parent, ICOMObject enumerator)
        {
            return NetOffice.Utils.FetchVariantComObjectEnumerator(parent, enumerator, false);
        }

        #endregion

        #region IEnumerable<NetOffice.OfficeApi.FileDialogFilter>

        /// <summary>
        /// SupportByVersion Office, 10,11,12,14,15,16
        /// </summary>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public virtual IEnumerator<NetOffice.OfficeApi.FileDialogFilter> GetEnumerator()
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.OfficeApi.FileDialogFilter item in innerEnumerator)
                yield return item;
        }

        #endregion

        #region IEnumerable

        /// <summary>
        /// SupportByVersion Office, 10,11,12,14,15,16
        /// </summary>
        [SupportByVersion("Office", 10,11,12,14,15,16)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this, false);
		}

		#endregion

		#pragma warning restore
	}
}