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
    /// IDropDowns
    /// </summary>
    [SyntaxBypass]
    public class IDropDowns_ : COMObject, NetOffice.ExcelApi.IDropDowns_
    {
        #region Ctor

        /// <summary>
        /// Stub Ctor, not indented to use
        /// </summary>
        public IDropDowns_() : base()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <param name="index">optional object index</param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual object get_List(object index)
        {
            return Factory.ExecuteVariantPropertyGet(this, "List", index);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <param name="index">optional object index</param>
        /// <param name="value">optional object value</param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual void set_List(object index, object value)
        {
            Factory.ExecutePropertySet(this, "List", index, value);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Alias for get_List
        /// </summary>
        /// <param name="index">optional object index</param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16), Redirect("get_List")]
        public virtual object List(object index)
        {
            return get_List(index);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <param name="index">optional object index</param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual object get_Selected(object index)
        {
            return Factory.ExecuteVariantPropertyGet(this, "Selected", index);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <param name="index">optional object index</param>
        /// <param name="value">optional object value</param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual void set_Selected(object index, object value)
        {
            Factory.ExecutePropertySet(this, "Selected", index, value);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Alias for get_Selected
        /// </summary>
        /// <param name="index">optional object index</param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16), Redirect("get_Selected")]
        public virtual object Selected(object index)
        {
            return get_Selected(index);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <param name="start">optional object start</param>
        /// <param name="length">optional object length</param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual NetOffice.ExcelApi.Characters get_Characters(object start, object length)
        {
            return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Characters>(this, "Characters", typeof(NetOffice.ExcelApi.Characters), start, length);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Alias for get_Characters
        /// </summary>
        /// <param name="start">optional object start</param>
        /// <param name="length">optional object length</param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16), Redirect("get_Characters")]
        public virtual NetOffice.ExcelApi.Characters Characters(object start, object length)
        {
            return get_Characters(start, length);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <param name="start">optional object start</param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual NetOffice.ExcelApi.Characters get_Characters(object start)
        {
            return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Characters>(this, "Characters", typeof(NetOffice.ExcelApi.Characters), start);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Alias for get_Characters
        /// </summary>
        /// <param name="start">optional object start</param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16), Redirect("get_Characters")]
        public virtual NetOffice.ExcelApi.Characters Characters(object start)
        {
            return get_Characters(start);
        }

        #endregion

        #region Methods

        #endregion
    }

    /// <summary>
    /// Interface IDropDowns 
    /// SupportByVersion Excel, 9,10,11,12,14,15,16
    /// </summary>
    [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
    [EntityType(EntityType.IsInterface), Enumerator(Enumerator.Reference, EnumeratorInvoke.Method)]
    public class IDropDowns : NetOffice.ExcelApi.Behind.IDropDowns_, NetOffice.ExcelApi.IDropDowns
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
                    _type = typeof(IDropDowns);
                return _type;
            }
        }

        #endregion

        #region Ctor

        /// <summary>
        /// Stub Ctor, not indented to use
        /// </summary>
        public IDropDowns() : base()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Application Application
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Application>(this, "Application", typeof(NetOffice.ExcelApi.Application));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Enums.XlCreator Creator
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlCreator>(this, "Creator");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16), ProxyResult]
        public virtual object Parent
        {
            get
            {
                return Factory.ExecuteReferencePropertyGet(this, "Parent");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool Enabled
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "Enabled");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Enabled", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Double Height
        {
            get
            {
                return Factory.ExecuteDoublePropertyGet(this, "Height");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Height", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Double Left
        {
            get
            {
                return Factory.ExecuteDoublePropertyGet(this, "Left");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Left", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool Locked
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "Locked");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Locked", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual string OnAction
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "OnAction");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "OnAction", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual object Placement
        {
            get
            {
                return Factory.ExecuteVariantPropertyGet(this, "Placement");
            }
            set
            {
                Factory.ExecuteVariantPropertySet(this, "Placement", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool PrintObject
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "PrintObject");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "PrintObject", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Double Top
        {
            get
            {
                return Factory.ExecuteDoublePropertyGet(this, "Top");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Top", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool Visible
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "Visible");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Visible", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Double Width
        {
            get
            {
                return Factory.ExecuteDoublePropertyGet(this, "Width");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Width", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 ZOrder
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "ZOrder");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.ShapeRange ShapeRange
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.ShapeRange>(this, "ShapeRange", typeof(NetOffice.ExcelApi.ShapeRange));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool Display3DShading
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "Display3DShading");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Display3DShading", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 _Default
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "_Default");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "_Default", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual string LinkedCell
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "LinkedCell");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "LinkedCell", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual object List
        {
            get
            {
                return Factory.ExecuteVariantPropertyGet(this, "List");
            }
            set
            {
                Factory.ExecuteVariantPropertySet(this, "List", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual string ListFillRange
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "ListFillRange");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "ListFillRange", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 ListIndex
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "ListIndex");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "ListIndex", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual object Selected
        {
            get
            {
                return Factory.ExecuteVariantPropertyGet(this, "Selected");
            }
            set
            {
                Factory.ExecuteVariantPropertySet(this, "Selected", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 Value
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "Value");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Value", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual string Caption
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "Caption");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Caption", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Characters Characters
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Characters>(this, "Characters", typeof(NetOffice.ExcelApi.Characters));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 DropDownLines
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "DropDownLines");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "DropDownLines", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual string Text
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "Text");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Text", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
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
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual void _Dummy3()
        {
            Factory.ExecuteMethod(this, "_Dummy3");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual object BringToFront()
        {
            return Factory.ExecuteVariantMethodGet(this, "BringToFront");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual object Copy()
        {
            return Factory.ExecuteVariantMethodGet(this, "Copy");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="appearance">optional NetOffice.ExcelApi.Enums.XlPictureAppearance Appearance = 2</param>
        /// <param name="format">optional NetOffice.ExcelApi.Enums.XlCopyPictureFormat Format = -4147</param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual object CopyPicture(object appearance, object format)
        {
            return Factory.ExecuteVariantMethodGet(this, "CopyPicture", appearance, format);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual object CopyPicture()
        {
            return Factory.ExecuteVariantMethodGet(this, "CopyPicture");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="appearance">optional NetOffice.ExcelApi.Enums.XlPictureAppearance Appearance = 2</param>
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual object CopyPicture(object appearance)
        {
            return Factory.ExecuteVariantMethodGet(this, "CopyPicture", appearance);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual object Cut()
        {
            return Factory.ExecuteVariantMethodGet(this, "Cut");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual object Delete()
        {
            return Factory.ExecuteVariantMethodGet(this, "Delete");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual object Duplicate()
        {
            return Factory.ExecuteVariantMethodGet(this, "Duplicate");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual void _Dummy12()
        {
            Factory.ExecuteMethod(this, "_Dummy12");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual void _Dummy15()
        {
            Factory.ExecuteMethod(this, "_Dummy15");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="replace">optional object replace</param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual object Select(object replace)
        {
            return Factory.ExecuteVariantMethodGet(this, "Select", replace);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual object Select()
        {
            return Factory.ExecuteVariantMethodGet(this, "Select");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual object SendToBack()
        {
            return Factory.ExecuteVariantMethodGet(this, "SendToBack");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual void _Dummy22()
        {
            Factory.ExecuteMethod(this, "_Dummy22");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="text">object text</param>
        /// <param name="index">optional object index</param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual object AddItem(object text, object index)
        {
            return Factory.ExecuteVariantMethodGet(this, "AddItem", text, index);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="text">object text</param>
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual object AddItem(object text)
        {
            return Factory.ExecuteVariantMethodGet(this, "AddItem", text);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual void _Dummy31()
        {
            Factory.ExecuteMethod(this, "_Dummy31");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual void _Dummy33()
        {
            Factory.ExecuteMethod(this, "_Dummy33");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual void _Dummy36()
        {
            Factory.ExecuteMethod(this, "_Dummy36");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual object RemoveAllItems()
        {
            return Factory.ExecuteVariantMethodGet(this, "RemoveAllItems");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="index">Int32 index</param>
        /// <param name="count">optional object count</param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual object RemoveItem(Int32 index, object count)
        {
            return Factory.ExecuteVariantMethodGet(this, "RemoveItem", index, count);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="index">Int32 index</param>
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual object RemoveItem(Int32 index)
        {
            return Factory.ExecuteVariantMethodGet(this, "RemoveItem", index);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="left">Double left</param>
        /// <param name="top">Double top</param>
        /// <param name="width">Double width</param>
        /// <param name="height">Double height</param>
        /// <param name="editable">optional object editable</param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.DropDown Add(Double left, Double top, Double width, Double height, object editable)
        {
            return Factory.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.DropDown>(this, "Add", typeof(NetOffice.ExcelApi.DropDown), new object[] { left, top, width, height, editable });
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="left">Double left</param>
        /// <param name="top">Double top</param>
        /// <param name="width">Double width</param>
        /// <param name="height">Double height</param>
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.DropDown Add(Double left, Double top, Double width, Double height)
        {
            return Factory.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.DropDown>(this, "Add", typeof(NetOffice.ExcelApi.DropDown), left, top, width, height);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.GroupObject Group()
        {
            return Factory.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.GroupObject>(this, "Group", typeof(NetOffice.ExcelApi.GroupObject));
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="index">object index</param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual object Item(object index)
        {
            return Factory.ExecuteVariantMethodGet(this, "Item", index);
        }

        #endregion

        #region IEnumerableProvider<object>

        ICOMObject IEnumerableProvider<object>.GetComObjectEnumerator(ICOMObject parent)
        {
            return NetOffice.Utils.GetComObjectEnumeratorAsMethod(parent, this, false);
        }

        IEnumerable IEnumerableProvider<object>.FetchVariantComObjectEnumerator(ICOMObject parent, ICOMObject enumerator)
        {
            return NetOffice.Utils.FetchVariantComObjectEnumerator(parent, enumerator, true);
        }

        #endregion

        #region IEnumerable<object>

        /// <summary>
        /// SupportByVersion Excel, 9,10,11,12,14,15,16
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual IEnumerator<object> GetEnumerator()
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (object item in innerEnumerator)
                yield return item;
        }

        #endregion

        #region IEnumerable

        /// <summary>
        /// SupportByVersion Excel, 9,10,11,12,14,15,16
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
        {
            return NetOffice.Utils.GetProxyEnumeratorAsMethod(this, true);
        }

        #endregion

        #pragma warning restore
    }
}
