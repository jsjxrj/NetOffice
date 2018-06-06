﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.OfficeApi;

namespace NetOffice.OfficeApi.Behind
{
    /// <summary>
    /// DispatchInterface ChartFont 
    /// SupportByVersion Office, 12,14,15,16
    /// </summary>
    [SupportByVersion("Office", 12, 14, 15, 16)]
    [EntityType(EntityType.IsDispatchInterface)]
    public class ChartFont : COMObject, NetOffice.OfficeApi.ChartFont
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
                    _type = typeof(ChartFont);
                return _type;
            }
        }

        #endregion

		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public ChartFont() : base()
		{

		}

		#endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual object Background
        {
            get
            {
                return Factory.ExecuteVariantPropertyGet(this, "Background");
            }
            set
            {
                Factory.ExecuteVariantPropertySet(this, "Background", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual object Bold
        {
            get
            {
                return Factory.ExecuteVariantPropertyGet(this, "Bold");
            }
            set
            {
                Factory.ExecuteVariantPropertySet(this, "Bold", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual object Color
        {
            get
            {
                return Factory.ExecuteVariantPropertyGet(this, "Color");
            }
            set
            {
                Factory.ExecuteVariantPropertySet(this, "Color", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual object ColorIndex
        {
            get
            {
                return Factory.ExecuteVariantPropertyGet(this, "ColorIndex");
            }
            set
            {
                Factory.ExecuteVariantPropertySet(this, "ColorIndex", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual object FontStyle
        {
            get
            {
                return Factory.ExecuteVariantPropertyGet(this, "FontStyle");
            }
            set
            {
                Factory.ExecuteVariantPropertySet(this, "FontStyle", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual object Italic
        {
            get
            {
                return Factory.ExecuteVariantPropertyGet(this, "Italic");
            }
            set
            {
                Factory.ExecuteVariantPropertySet(this, "Italic", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual object Name
        {
            get
            {
                return Factory.ExecuteVariantPropertyGet(this, "Name");
            }
            set
            {
                Factory.ExecuteVariantPropertySet(this, "Name", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual object OutlineFont
        {
            get
            {
                return Factory.ExecuteVariantPropertyGet(this, "OutlineFont");
            }
            set
            {
                Factory.ExecuteVariantPropertySet(this, "OutlineFont", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual object Shadow
        {
            get
            {
                return Factory.ExecuteVariantPropertyGet(this, "Shadow");
            }
            set
            {
                Factory.ExecuteVariantPropertySet(this, "Shadow", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual object Size
        {
            get
            {
                return Factory.ExecuteVariantPropertyGet(this, "Size");
            }
            set
            {
                Factory.ExecuteVariantPropertySet(this, "Size", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual object StrikeThrough
        {
            get
            {
                return Factory.ExecuteVariantPropertyGet(this, "StrikeThrough");
            }
            set
            {
                Factory.ExecuteVariantPropertySet(this, "StrikeThrough", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual object Subscript
        {
            get
            {
                return Factory.ExecuteVariantPropertyGet(this, "Subscript");
            }
            set
            {
                Factory.ExecuteVariantPropertySet(this, "Subscript", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual object Superscript
        {
            get
            {
                return Factory.ExecuteVariantPropertyGet(this, "Superscript");
            }
            set
            {
                Factory.ExecuteVariantPropertySet(this, "Superscript", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual object Underline
        {
            get
            {
                return Factory.ExecuteVariantPropertyGet(this, "Underline");
            }
            set
            {
                Factory.ExecuteVariantPropertySet(this, "Underline", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        [SupportByVersion("Office", 14, 15, 16), ProxyResult]
        public virtual object Application
        {
            get
            {
                return Factory.ExecuteReferencePropertyGet(this, "Application");
            }
        }

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 14, 15, 16)]
        public virtual Int32 Creator
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "Creator");
            }
        }

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        [SupportByVersion("Office", 14, 15, 16), ProxyResult]
        public virtual object Parent
        {
            get
            {
                return Factory.ExecuteReferencePropertyGet(this, "Parent");
            }
        }

        #endregion

        #region Methods

        #endregion

        #pragma warning restore
    }
}