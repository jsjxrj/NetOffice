﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.ExcelApi;

namespace NetOffice.ExcelApi.Behind
{
    /// <summary>
    /// Interface IIconCriterion 
    /// SupportByVersion Excel, 12,14,15,16
    /// </summary>
    [SupportByVersion("Excel", 12, 14, 15, 16)]
    [EntityType(EntityType.IsInterface)]
    public class IIconCriterion : COMObject, NetOffice.ExcelApi.IIconCriterion
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
                    _type = typeof(IIconCriterion);
                return _type;
            }
        }

        #endregion

		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public IIconCriterion() : base()
		{

		}

		#endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Excel 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 12, 14, 15, 16)]
        public virtual Int32 Index
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "Index");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Enums.XlConditionValueTypes Type
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlConditionValueTypes>(this, "Type");
            }
            set
            {
                Factory.ExecuteEnumPropertySet(this, "Type", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 12, 14, 15, 16)]
        public virtual object Value
        {
            get
            {
                return Factory.ExecuteVariantPropertyGet(this, "Value");
            }
            set
            {
                Factory.ExecuteVariantPropertySet(this, "Value", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 12, 14, 15, 16)]
        public virtual Int32 Operator
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "Operator");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Operator", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Enums.XlIcon Icon
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlIcon>(this, "Icon");
            }
            set
            {
                Factory.ExecuteEnumPropertySet(this, "Icon", value);
            }
        }

        #endregion

        #region Methods

        #endregion

        #pragma warning restore
    }
}