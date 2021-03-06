﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.ExcelApi;

namespace NetOffice.ExcelApi.Behind
{
    /// <summary>
    /// Interface IModule 
    /// SupportByVersion Excel, 9,10,11,12,14,15,16
    /// </summary>
    [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
    [EntityType(EntityType.IsInterface)]
    public class IModule : COMObject, NetOffice.ExcelApi.IModule
    {
        #pragma warning disable

        #region Type Information

        /// <summary>        /// Instance Type
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
                    _type = typeof(IModule);
                return _type;
            }
        }

        #endregion

		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public IModule() : base()
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
                return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Application>(this, "Application", typeof(NetOffice.ExcelApi.Application));
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
                return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlCreator>(this, "Creator");
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
                return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "Parent");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual string CodeName
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "CodeName");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual string _CodeName
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "_CodeName");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "_CodeName", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 Index
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "Index");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual string Name
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Name");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Name", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16), ProxyResult]
        public virtual object Next
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "Next");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual string OnDoubleClick
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "OnDoubleClick");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "OnDoubleClick", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual string OnSheetActivate
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "OnSheetActivate");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "OnSheetActivate", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual string OnSheetDeactivate
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "OnSheetDeactivate");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "OnSheetDeactivate", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.PageSetup PageSetup
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.PageSetup>(this, "PageSetup", typeof(NetOffice.ExcelApi.PageSetup));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16), ProxyResult]
        public virtual object Previous
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "Previous");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool ProtectContents
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "ProtectContents");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool ProtectionMode
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "ProtectionMode");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Enums.XlSheetVisibility Visible
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlSheetVisibility>(this, "Visible");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteEnumPropertySet(this, "Visible", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Shapes Shapes
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Shapes>(this, "Shapes", typeof(NetOffice.ExcelApi.Shapes));
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 Activate()
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "Activate");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="before">optional object before</param>
        /// <param name="after">optional object after</param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 Copy(object before, object after)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "Copy", before, after);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 Copy()
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "Copy");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="before">optional object before</param>
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 Copy(object before)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "Copy", before);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 Delete()
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "Delete");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="before">optional object before</param>
        /// <param name="after">optional object after</param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 Move(object before, object after)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "Move", before, after);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 Move()
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "Move");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="before">optional object before</param>
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 Move(object before)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "Move", before);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="from">optional object from</param>
        /// <param name="to">optional object to</param>
        /// <param name="copies">optional object copies</param>
        /// <param name="preview">optional object preview</param>
        /// <param name="activePrinter">optional object activePrinter</param>
        /// <param name="printToFile">optional object printToFile</param>
        /// <param name="collate">optional object collate</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 _PrintOut(object from, object to, object copies, object preview, object activePrinter, object printToFile, object collate)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "_PrintOut", new object[] { from, to, copies, preview, activePrinter, printToFile, collate });
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 _PrintOut()
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "_PrintOut");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="from">optional object from</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 _PrintOut(object from)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "_PrintOut", from);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="from">optional object from</param>
        /// <param name="to">optional object to</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 _PrintOut(object from, object to)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "_PrintOut", from, to);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="from">optional object from</param>
        /// <param name="to">optional object to</param>
        /// <param name="copies">optional object copies</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 _PrintOut(object from, object to, object copies)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "_PrintOut", from, to, copies);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="from">optional object from</param>
        /// <param name="to">optional object to</param>
        /// <param name="copies">optional object copies</param>
        /// <param name="preview">optional object preview</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 _PrintOut(object from, object to, object copies, object preview)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "_PrintOut", from, to, copies, preview);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="from">optional object from</param>
        /// <param name="to">optional object to</param>
        /// <param name="copies">optional object copies</param>
        /// <param name="preview">optional object preview</param>
        /// <param name="activePrinter">optional object activePrinter</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 _PrintOut(object from, object to, object copies, object preview, object activePrinter)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "_PrintOut", new object[] { from, to, copies, preview, activePrinter });
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="from">optional object from</param>
        /// <param name="to">optional object to</param>
        /// <param name="copies">optional object copies</param>
        /// <param name="preview">optional object preview</param>
        /// <param name="activePrinter">optional object activePrinter</param>
        /// <param name="printToFile">optional object printToFile</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 _PrintOut(object from, object to, object copies, object preview, object activePrinter, object printToFile)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "_PrintOut", new object[] { from, to, copies, preview, activePrinter, printToFile });
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual void _Dummy18()
        {
            InvokerService.InvokeInternal.ExecuteMethod(this, "_Dummy18");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="password">optional object password</param>
        /// <param name="drawingObjects">optional object drawingObjects</param>
        /// <param name="contents">optional object contents</param>
        /// <param name="scenarios">optional object scenarios</param>
        /// <param name="userInterfaceOnly">optional object userInterfaceOnly</param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 Protect(object password, object drawingObjects, object contents, object scenarios, object userInterfaceOnly)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "Protect", new object[] { password, drawingObjects, contents, scenarios, userInterfaceOnly });
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 Protect()
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "Protect");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="password">optional object password</param>
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 Protect(object password)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "Protect", password);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="password">optional object password</param>
        /// <param name="drawingObjects">optional object drawingObjects</param>
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 Protect(object password, object drawingObjects)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "Protect", password, drawingObjects);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="password">optional object password</param>
        /// <param name="drawingObjects">optional object drawingObjects</param>
        /// <param name="contents">optional object contents</param>
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 Protect(object password, object drawingObjects, object contents)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "Protect", password, drawingObjects, contents);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="password">optional object password</param>
        /// <param name="drawingObjects">optional object drawingObjects</param>
        /// <param name="contents">optional object contents</param>
        /// <param name="scenarios">optional object scenarios</param>
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 Protect(object password, object drawingObjects, object contents, object scenarios)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "Protect", password, drawingObjects, contents, scenarios);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual void _Dummy21()
        {
            InvokerService.InvokeInternal.ExecuteMethod(this, "_Dummy21");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual void _Dummy23()
        {
            InvokerService.InvokeInternal.ExecuteMethod(this, "_Dummy23");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="filename">string filename</param>
        /// <param name="fileFormat">optional object fileFormat</param>
        /// <param name="password">optional object password</param>
        /// <param name="writeResPassword">optional object writeResPassword</param>
        /// <param name="readOnlyRecommended">optional object readOnlyRecommended</param>
        /// <param name="createBackup">optional object createBackup</param>
        /// <param name="addToMru">optional object addToMru</param>
        /// <param name="textCodepage">optional object textCodepage</param>
        /// <param name="textVisualLayout">optional object textVisualLayout</param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 SaveAs(string filename, object fileFormat, object password, object writeResPassword, object readOnlyRecommended, object createBackup, object addToMru, object textCodepage, object textVisualLayout)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "SaveAs", new object[] { filename, fileFormat, password, writeResPassword, readOnlyRecommended, createBackup, addToMru, textCodepage, textVisualLayout });
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="filename">string filename</param>
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 SaveAs(string filename)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "SaveAs", filename);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="filename">string filename</param>
        /// <param name="fileFormat">optional object fileFormat</param>
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 SaveAs(string filename, object fileFormat)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "SaveAs", filename, fileFormat);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="filename">string filename</param>
        /// <param name="fileFormat">optional object fileFormat</param>
        /// <param name="password">optional object password</param>
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 SaveAs(string filename, object fileFormat, object password)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "SaveAs", filename, fileFormat, password);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="filename">string filename</param>
        /// <param name="fileFormat">optional object fileFormat</param>
        /// <param name="password">optional object password</param>
        /// <param name="writeResPassword">optional object writeResPassword</param>
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 SaveAs(string filename, object fileFormat, object password, object writeResPassword)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "SaveAs", filename, fileFormat, password, writeResPassword);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="filename">string filename</param>
        /// <param name="fileFormat">optional object fileFormat</param>
        /// <param name="password">optional object password</param>
        /// <param name="writeResPassword">optional object writeResPassword</param>
        /// <param name="readOnlyRecommended">optional object readOnlyRecommended</param>
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 SaveAs(string filename, object fileFormat, object password, object writeResPassword, object readOnlyRecommended)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "SaveAs", new object[] { filename, fileFormat, password, writeResPassword, readOnlyRecommended });
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="filename">string filename</param>
        /// <param name="fileFormat">optional object fileFormat</param>
        /// <param name="password">optional object password</param>
        /// <param name="writeResPassword">optional object writeResPassword</param>
        /// <param name="readOnlyRecommended">optional object readOnlyRecommended</param>
        /// <param name="createBackup">optional object createBackup</param>
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 SaveAs(string filename, object fileFormat, object password, object writeResPassword, object readOnlyRecommended, object createBackup)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "SaveAs", new object[] { filename, fileFormat, password, writeResPassword, readOnlyRecommended, createBackup });
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="filename">string filename</param>
        /// <param name="fileFormat">optional object fileFormat</param>
        /// <param name="password">optional object password</param>
        /// <param name="writeResPassword">optional object writeResPassword</param>
        /// <param name="readOnlyRecommended">optional object readOnlyRecommended</param>
        /// <param name="createBackup">optional object createBackup</param>
        /// <param name="addToMru">optional object addToMru</param>
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 SaveAs(string filename, object fileFormat, object password, object writeResPassword, object readOnlyRecommended, object createBackup, object addToMru)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "SaveAs", new object[] { filename, fileFormat, password, writeResPassword, readOnlyRecommended, createBackup, addToMru });
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="filename">string filename</param>
        /// <param name="fileFormat">optional object fileFormat</param>
        /// <param name="password">optional object password</param>
        /// <param name="writeResPassword">optional object writeResPassword</param>
        /// <param name="readOnlyRecommended">optional object readOnlyRecommended</param>
        /// <param name="createBackup">optional object createBackup</param>
        /// <param name="addToMru">optional object addToMru</param>
        /// <param name="textCodepage">optional object textCodepage</param>
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 SaveAs(string filename, object fileFormat, object password, object writeResPassword, object readOnlyRecommended, object createBackup, object addToMru, object textCodepage)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "SaveAs", new object[] { filename, fileFormat, password, writeResPassword, readOnlyRecommended, createBackup, addToMru, textCodepage });
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="replace">optional object replace</param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 Select(object replace)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "Select", replace);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 Select()
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "Select");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="password">optional object password</param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 Unprotect(object password)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "Unprotect", password);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 Unprotect()
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "Unprotect");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="filename">object filename</param>
        /// <param name="merge">optional object merge</param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual object InsertFile(object filename, object merge)
        {
            return InvokerService.InvokeInternal.ExecuteVariantMethodGet(this, "InsertFile", filename, merge);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="filename">object filename</param>
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual object InsertFile(object filename)
        {
            return InvokerService.InvokeInternal.ExecuteVariantMethodGet(this, "InsertFile", filename);
        }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="password">optional object password</param>
        /// <param name="drawingObjects">optional object drawingObjects</param>
        /// <param name="contents">optional object contents</param>
        /// <param name="scenarios">optional object scenarios</param>
        /// <param name="userInterfaceOnly">optional object userInterfaceOnly</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual Int32 _Protect(object password, object drawingObjects, object contents, object scenarios, object userInterfaceOnly)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "_Protect", new object[] { password, drawingObjects, contents, scenarios, userInterfaceOnly });
        }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [CustomMethod]
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual Int32 _Protect()
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "_Protect");
        }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="password">optional object password</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [CustomMethod]
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual Int32 _Protect(object password)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "_Protect", password);
        }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="password">optional object password</param>
        /// <param name="drawingObjects">optional object drawingObjects</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [CustomMethod]
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual Int32 _Protect(object password, object drawingObjects)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "_Protect", password, drawingObjects);
        }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="password">optional object password</param>
        /// <param name="drawingObjects">optional object drawingObjects</param>
        /// <param name="contents">optional object contents</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [CustomMethod]
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual Int32 _Protect(object password, object drawingObjects, object contents)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "_Protect", password, drawingObjects, contents);
        }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="password">optional object password</param>
        /// <param name="drawingObjects">optional object drawingObjects</param>
        /// <param name="contents">optional object contents</param>
        /// <param name="scenarios">optional object scenarios</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [CustomMethod]
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual Int32 _Protect(object password, object drawingObjects, object contents, object scenarios)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "_Protect", password, drawingObjects, contents, scenarios);
        }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="filename">string filename</param>
        /// <param name="fileFormat">optional object fileFormat</param>
        /// <param name="password">optional object password</param>
        /// <param name="writeResPassword">optional object writeResPassword</param>
        /// <param name="readOnlyRecommended">optional object readOnlyRecommended</param>
        /// <param name="createBackup">optional object createBackup</param>
        /// <param name="addToMru">optional object addToMru</param>
        /// <param name="textCodepage">optional object textCodepage</param>
        /// <param name="textVisualLayout">optional object textVisualLayout</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual Int32 _SaveAs(string filename, object fileFormat, object password, object writeResPassword, object readOnlyRecommended, object createBackup, object addToMru, object textCodepage, object textVisualLayout)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "_SaveAs", new object[] { filename, fileFormat, password, writeResPassword, readOnlyRecommended, createBackup, addToMru, textCodepage, textVisualLayout });
        }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="filename">string filename</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [CustomMethod]
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual Int32 _SaveAs(string filename)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "_SaveAs", filename);
        }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="filename">string filename</param>
        /// <param name="fileFormat">optional object fileFormat</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [CustomMethod]
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual Int32 _SaveAs(string filename, object fileFormat)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "_SaveAs", filename, fileFormat);
        }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="filename">string filename</param>
        /// <param name="fileFormat">optional object fileFormat</param>
        /// <param name="password">optional object password</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [CustomMethod]
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual Int32 _SaveAs(string filename, object fileFormat, object password)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "_SaveAs", filename, fileFormat, password);
        }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="filename">string filename</param>
        /// <param name="fileFormat">optional object fileFormat</param>
        /// <param name="password">optional object password</param>
        /// <param name="writeResPassword">optional object writeResPassword</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [CustomMethod]
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual Int32 _SaveAs(string filename, object fileFormat, object password, object writeResPassword)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "_SaveAs", filename, fileFormat, password, writeResPassword);
        }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="filename">string filename</param>
        /// <param name="fileFormat">optional object fileFormat</param>
        /// <param name="password">optional object password</param>
        /// <param name="writeResPassword">optional object writeResPassword</param>
        /// <param name="readOnlyRecommended">optional object readOnlyRecommended</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [CustomMethod]
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual Int32 _SaveAs(string filename, object fileFormat, object password, object writeResPassword, object readOnlyRecommended)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "_SaveAs", new object[] { filename, fileFormat, password, writeResPassword, readOnlyRecommended });
        }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="filename">string filename</param>
        /// <param name="fileFormat">optional object fileFormat</param>
        /// <param name="password">optional object password</param>
        /// <param name="writeResPassword">optional object writeResPassword</param>
        /// <param name="readOnlyRecommended">optional object readOnlyRecommended</param>
        /// <param name="createBackup">optional object createBackup</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [CustomMethod]
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual Int32 _SaveAs(string filename, object fileFormat, object password, object writeResPassword, object readOnlyRecommended, object createBackup)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "_SaveAs", new object[] { filename, fileFormat, password, writeResPassword, readOnlyRecommended, createBackup });
        }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="filename">string filename</param>
        /// <param name="fileFormat">optional object fileFormat</param>
        /// <param name="password">optional object password</param>
        /// <param name="writeResPassword">optional object writeResPassword</param>
        /// <param name="readOnlyRecommended">optional object readOnlyRecommended</param>
        /// <param name="createBackup">optional object createBackup</param>
        /// <param name="addToMru">optional object addToMru</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [CustomMethod]
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual Int32 _SaveAs(string filename, object fileFormat, object password, object writeResPassword, object readOnlyRecommended, object createBackup, object addToMru)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "_SaveAs", new object[] { filename, fileFormat, password, writeResPassword, readOnlyRecommended, createBackup, addToMru });
        }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="filename">string filename</param>
        /// <param name="fileFormat">optional object fileFormat</param>
        /// <param name="password">optional object password</param>
        /// <param name="writeResPassword">optional object writeResPassword</param>
        /// <param name="readOnlyRecommended">optional object readOnlyRecommended</param>
        /// <param name="createBackup">optional object createBackup</param>
        /// <param name="addToMru">optional object addToMru</param>
        /// <param name="textCodepage">optional object textCodepage</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [CustomMethod]
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual Int32 _SaveAs(string filename, object fileFormat, object password, object writeResPassword, object readOnlyRecommended, object createBackup, object addToMru, object textCodepage)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "_SaveAs", new object[] { filename, fileFormat, password, writeResPassword, readOnlyRecommended, createBackup, addToMru, textCodepage });
        }

        /// <summary>
        /// SupportByVersion Excel 12, 14, 15, 16
        /// </summary>
        /// <param name="from">optional object from</param>
        /// <param name="to">optional object to</param>
        /// <param name="copies">optional object copies</param>
        /// <param name="preview">optional object preview</param>
        /// <param name="activePrinter">optional object activePrinter</param>
        /// <param name="printToFile">optional object printToFile</param>
        /// <param name="collate">optional object collate</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [SupportByVersion("Excel", 12, 14, 15, 16)]
        public virtual Int32 __PrintOut(object from, object to, object copies, object preview, object activePrinter, object printToFile, object collate)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "__PrintOut", new object[] { from, to, copies, preview, activePrinter, printToFile, collate });
        }

        /// <summary>
        /// SupportByVersion Excel 12, 14, 15, 16
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [CustomMethod]
        [SupportByVersion("Excel", 12, 14, 15, 16)]
        public virtual Int32 __PrintOut()
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "__PrintOut");
        }

        /// <summary>
        /// SupportByVersion Excel 12, 14, 15, 16
        /// </summary>
        /// <param name="from">optional object from</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [CustomMethod]
        [SupportByVersion("Excel", 12, 14, 15, 16)]
        public virtual Int32 __PrintOut(object from)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "__PrintOut", from);
        }

        /// <summary>
        /// SupportByVersion Excel 12, 14, 15, 16
        /// </summary>
        /// <param name="from">optional object from</param>
        /// <param name="to">optional object to</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [CustomMethod]
        [SupportByVersion("Excel", 12, 14, 15, 16)]
        public virtual Int32 __PrintOut(object from, object to)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "__PrintOut", from, to);
        }

        /// <summary>
        /// SupportByVersion Excel 12, 14, 15, 16
        /// </summary>
        /// <param name="from">optional object from</param>
        /// <param name="to">optional object to</param>
        /// <param name="copies">optional object copies</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [CustomMethod]
        [SupportByVersion("Excel", 12, 14, 15, 16)]
        public virtual Int32 __PrintOut(object from, object to, object copies)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "__PrintOut", from, to, copies);
        }

        /// <summary>
        /// SupportByVersion Excel 12, 14, 15, 16
        /// </summary>
        /// <param name="from">optional object from</param>
        /// <param name="to">optional object to</param>
        /// <param name="copies">optional object copies</param>
        /// <param name="preview">optional object preview</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [CustomMethod]
        [SupportByVersion("Excel", 12, 14, 15, 16)]
        public virtual Int32 __PrintOut(object from, object to, object copies, object preview)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "__PrintOut", from, to, copies, preview);
        }

        /// <summary>
        /// SupportByVersion Excel 12, 14, 15, 16
        /// </summary>
        /// <param name="from">optional object from</param>
        /// <param name="to">optional object to</param>
        /// <param name="copies">optional object copies</param>
        /// <param name="preview">optional object preview</param>
        /// <param name="activePrinter">optional object activePrinter</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [CustomMethod]
        [SupportByVersion("Excel", 12, 14, 15, 16)]
        public virtual Int32 __PrintOut(object from, object to, object copies, object preview, object activePrinter)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "__PrintOut", new object[] { from, to, copies, preview, activePrinter });
        }

        /// <summary>
        /// SupportByVersion Excel 12, 14, 15, 16
        /// </summary>
        /// <param name="from">optional object from</param>
        /// <param name="to">optional object to</param>
        /// <param name="copies">optional object copies</param>
        /// <param name="preview">optional object preview</param>
        /// <param name="activePrinter">optional object activePrinter</param>
        /// <param name="printToFile">optional object printToFile</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [CustomMethod]
        [SupportByVersion("Excel", 12, 14, 15, 16)]
        public virtual Int32 __PrintOut(object from, object to, object copies, object preview, object activePrinter, object printToFile)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "__PrintOut", new object[] { from, to, copies, preview, activePrinter, printToFile });
        }

        /// <summary>
        /// SupportByVersion Excel 12, 14, 15, 16
        /// </summary>
        /// <param name="from">optional object from</param>
        /// <param name="to">optional object to</param>
        /// <param name="copies">optional object copies</param>
        /// <param name="preview">optional object preview</param>
        /// <param name="activePrinter">optional object activePrinter</param>
        /// <param name="printToFile">optional object printToFile</param>
        /// <param name="collate">optional object collate</param>
        [SupportByVersion("Excel", 12, 14, 15, 16)]
        public virtual Int32 PrintOut(object from, object to, object copies, object preview, object activePrinter, object printToFile, object collate)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "PrintOut", new object[] { from, to, copies, preview, activePrinter, printToFile, collate });
        }

        /// <summary>
        /// SupportByVersion Excel 12, 14, 15, 16
        /// </summary>
        [CustomMethod]
        [SupportByVersion("Excel", 12, 14, 15, 16)]
        public virtual Int32 PrintOut()
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "PrintOut");
        }

        /// <summary>
        /// SupportByVersion Excel 12, 14, 15, 16
        /// </summary>
        /// <param name="from">optional object from</param>
        [CustomMethod]
        [SupportByVersion("Excel", 12, 14, 15, 16)]
        public virtual Int32 PrintOut(object from)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "PrintOut", from);
        }

        /// <summary>
        /// SupportByVersion Excel 12, 14, 15, 16
        /// </summary>
        /// <param name="from">optional object from</param>
        /// <param name="to">optional object to</param>
        [CustomMethod]
        [SupportByVersion("Excel", 12, 14, 15, 16)]
        public virtual Int32 PrintOut(object from, object to)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "PrintOut", from, to);
        }

        /// <summary>
        /// SupportByVersion Excel 12, 14, 15, 16
        /// </summary>
        /// <param name="from">optional object from</param>
        /// <param name="to">optional object to</param>
        /// <param name="copies">optional object copies</param>
        [CustomMethod]
        [SupportByVersion("Excel", 12, 14, 15, 16)]
        public virtual Int32 PrintOut(object from, object to, object copies)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "PrintOut", from, to, copies);
        }

        /// <summary>
        /// SupportByVersion Excel 12, 14, 15, 16
        /// </summary>
        /// <param name="from">optional object from</param>
        /// <param name="to">optional object to</param>
        /// <param name="copies">optional object copies</param>
        /// <param name="preview">optional object preview</param>
        [CustomMethod]
        [SupportByVersion("Excel", 12, 14, 15, 16)]
        public virtual Int32 PrintOut(object from, object to, object copies, object preview)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "PrintOut", from, to, copies, preview);
        }

        /// <summary>
        /// SupportByVersion Excel 12, 14, 15, 16
        /// </summary>
        /// <param name="from">optional object from</param>
        /// <param name="to">optional object to</param>
        /// <param name="copies">optional object copies</param>
        /// <param name="preview">optional object preview</param>
        /// <param name="activePrinter">optional object activePrinter</param>
        [CustomMethod]
        [SupportByVersion("Excel", 12, 14, 15, 16)]
        public virtual Int32 PrintOut(object from, object to, object copies, object preview, object activePrinter)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "PrintOut", new object[] { from, to, copies, preview, activePrinter });
        }

        /// <summary>
        /// SupportByVersion Excel 12, 14, 15, 16
        /// </summary>
        /// <param name="from">optional object from</param>
        /// <param name="to">optional object to</param>
        /// <param name="copies">optional object copies</param>
        /// <param name="preview">optional object preview</param>
        /// <param name="activePrinter">optional object activePrinter</param>
        /// <param name="printToFile">optional object printToFile</param>
        [CustomMethod]
        [SupportByVersion("Excel", 12, 14, 15, 16)]
        public virtual Int32 PrintOut(object from, object to, object copies, object preview, object activePrinter, object printToFile)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "PrintOut", new object[] { from, to, copies, preview, activePrinter, printToFile });
        }

        #endregion

        #pragma warning restore
    }
}

