﻿using System.Collections;
using System.Collections.Generic;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.CollectionsGeneric;

namespace NetOffice.ExcelApi
{
    /// <summary>
    /// Interface IListColumns 
    /// SupportByVersion Excel, 11,12,14,15,16
    /// </summary>
    [SupportByVersion("Excel", 11, 12, 14, 15, 16)]
    [EntityType(EntityType.IsInterface), Enumerator(Enumerator.Reference, EnumeratorInvoke.Property), HasIndexProperty(IndexInvoke.Property, "_Default")]
	[TypeId("00024472-0001-0000-C000-000000000046")]
    public interface IListColumns : ICOMObject, IEnumerableProvider<NetOffice.ExcelApi.ListColumn>
    {
        #region Properties

        /// <summary>
        /// SupportByVersion Excel 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 11, 12, 14, 15, 16)]
        NetOffice.ExcelApi.Application Application { get; }

        /// <summary>
        /// SupportByVersion Excel 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 11, 12, 14, 15, 16)]
        NetOffice.ExcelApi.Enums.XlCreator Creator { get; }

        /// <summary>
        /// SupportByVersion Excel 11, 12, 14, 15, 16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        [SupportByVersion("Excel", 11, 12, 14, 15, 16), ProxyResult]
        object Parent { get; }

        /// <summary>
        /// SupportByVersion Excel 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <param name="index">object index</param>
        [SupportByVersion("Excel", 11, 12, 14, 15, 16)]
        [NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
        NetOffice.ExcelApi.ListColumn this[object index] { get; }

        /// <summary>
        /// SupportByVersion Excel 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 11, 12, 14, 15, 16)]
        Int32 Count { get; }

        #endregion

        #region Methods

        /// <summary>
        /// SupportByVersion Excel 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="position">optional object position</param>
        [SupportByVersion("Excel", 11, 12, 14, 15, 16)]
        NetOffice.ExcelApi.ListColumn Add(object position);

        /// <summary>
        /// SupportByVersion Excel 11, 12, 14, 15, 16
        /// </summary>
        [CustomMethod]
        [SupportByVersion("Excel", 11, 12, 14, 15, 16)]
        NetOffice.ExcelApi.ListColumn Add();

        #endregion
    }
}
