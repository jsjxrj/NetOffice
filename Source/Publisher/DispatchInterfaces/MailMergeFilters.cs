﻿using System.Collections;
using System.Collections.Generic;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.PublisherApi
{
	/// <summary>
	/// DispatchInterface MailMergeFilters 
	/// SupportByVersion Publisher, 14,15,16
	/// </summary>
	[SupportByVersion("Publisher", 14,15,16)]
	[EntityType(EntityType.IsDispatchInterface), Enumerator(Enumerator.Variant, EnumeratorInvoke.Custom), HasIndexProperty(IndexInvoke.Method, "Item")]
	public class MailMergeFilters : NetOffice.OfficeApi._IMsoDispObj , IEnumerable<object>
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
                    _type = typeof(MailMergeFilters);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <param name="factory">current used factory core</param>
		/// <param name="parentObject">object there has created the proxy</param>
		/// <param name="proxyShare">proxy share instead if com proxy</param>
		public MailMergeFilters(Core factory, ICOMObject parentObject, COMProxyShare proxyShare) : base(factory, parentObject, proxyShare)
		{
		}

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public MailMergeFilters(Core factory, ICOMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MailMergeFilters(ICOMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MailMergeFilters(Core factory, ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MailMergeFilters(ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MailMergeFilters(ICOMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MailMergeFilters() : base()
		{
		}
		
		/// <param name="progId">registered progID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MailMergeFilters(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16)]
		public Int32 Count
		{
			get
			{
				return Factory.ExecuteInt32PropertyGet(this, "Count");
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16), ProxyResult]
		public object Parent
		{
			get
			{
				return Factory.ExecuteReferencePropertyGet(this, "Parent");
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// </summary>
		/// <param name="index">Int32 index</param>
		[SupportByVersion("Publisher", 14,15,16)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
		public object this[Int32 index]
		{
			get
			{
				return Factory.ExecuteVariantMethodGet(this, "Item", index);
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// </summary>
		/// <param name="column">string column</param>
		/// <param name="comparison">NetOffice.OfficeApi.Enums.MsoFilterComparison comparison</param>
		/// <param name="conjunction">NetOffice.OfficeApi.Enums.MsoFilterConjunction conjunction</param>
		/// <param name="bstrCompareTo">optional string bstrCompareTo = </param>
		/// <param name="deferUpdate">optional bool DeferUpdate = false</param>
		[SupportByVersion("Publisher", 14,15,16)]
		public void Add(string column, NetOffice.OfficeApi.Enums.MsoFilterComparison comparison, NetOffice.OfficeApi.Enums.MsoFilterConjunction conjunction, object bstrCompareTo, object deferUpdate)
		{
			 Factory.ExecuteMethod(this, "Add", new object[]{ column, comparison, conjunction, bstrCompareTo, deferUpdate });
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// </summary>
		/// <param name="column">string column</param>
		/// <param name="comparison">NetOffice.OfficeApi.Enums.MsoFilterComparison comparison</param>
		/// <param name="conjunction">NetOffice.OfficeApi.Enums.MsoFilterConjunction conjunction</param>
		[CustomMethod]
		[SupportByVersion("Publisher", 14,15,16)]
		public void Add(string column, NetOffice.OfficeApi.Enums.MsoFilterComparison comparison, NetOffice.OfficeApi.Enums.MsoFilterConjunction conjunction)
		{
			 Factory.ExecuteMethod(this, "Add", column, comparison, conjunction);
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// </summary>
		/// <param name="column">string column</param>
		/// <param name="comparison">NetOffice.OfficeApi.Enums.MsoFilterComparison comparison</param>
		/// <param name="conjunction">NetOffice.OfficeApi.Enums.MsoFilterConjunction conjunction</param>
		/// <param name="bstrCompareTo">optional string bstrCompareTo = </param>
		[CustomMethod]
		[SupportByVersion("Publisher", 14,15,16)]
		public void Add(string column, NetOffice.OfficeApi.Enums.MsoFilterComparison comparison, NetOffice.OfficeApi.Enums.MsoFilterConjunction conjunction, object bstrCompareTo)
		{
			 Factory.ExecuteMethod(this, "Add", column, comparison, conjunction, bstrCompareTo);
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// </summary>
		/// <param name="index">Int32 index</param>
		/// <param name="deferUpdate">optional bool DeferUpdate = false</param>
		[SupportByVersion("Publisher", 14,15,16)]
		public void Delete(Int32 index, object deferUpdate)
		{
			 Factory.ExecuteMethod(this, "Delete", index, deferUpdate);
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// </summary>
		/// <param name="index">Int32 index</param>
		[CustomMethod]
		[SupportByVersion("Publisher", 14,15,16)]
		public void Delete(Int32 index)
		{
			 Factory.ExecuteMethod(this, "Delete", index);
		}

		#endregion
       #region IEnumerable<object> Member
        
        /// <summary>
		/// SupportByVersion Publisher, 14,15,16
		/// This is a custom enumerator from NetOffice
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16)]
        [CustomEnumerator]
       public IEnumerator<object> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (object item in innerEnumerator)
               yield return item;
       }

       #endregion
   
       #region IEnumerable Members
        
       /// <summary>
		/// SupportByVersion Publisher, 14,15,16
		/// This is a custom enumerator from NetOffice
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16)]
        [CustomEnumerator]
        IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
       {
            int count = Count;
            object[] enumeratorObjects = new object[count];
            for (int i = 0; i < count; i++)
                enumeratorObjects[i] = this[i+1];

            foreach (object item in enumeratorObjects)
                yield return item;
       }

       #endregion

       		#pragma warning restore
	}
}