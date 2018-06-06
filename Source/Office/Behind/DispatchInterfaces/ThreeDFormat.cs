﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.OfficeApi;

namespace NetOffice.OfficeApi.Behinds
{
    /// <summary>
    /// DispatchInterface ThreeDFormat 
    /// SupportByVersion Office, 9,10,11,12,14,15,16
    /// </summary>
    [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
    [EntityType(EntityType.IsDispatchInterface)]
    [Duplicate("NetOffice.ExcelApi.ThreeDFormat")]
    public class ThreeDFormat : NetOffice.OfficeApi.Behind._IMsoDispObj, NetOffice.OfficeApi.ThreeDFormat
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
                    _type = typeof(ThreeDFormat);
                return _type;
            }
        }

        #endregion

		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public ThreeDFormat() : base()
		{

		}

		#endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16), ProxyResult]
        public virtual object Parent
        {
            get
            {
                return Factory.ExecuteReferencePropertyGet(this, "Parent");
            }
        }

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Single Depth
        {
            get
            {
                return Factory.ExecuteSinglePropertyGet(this, "Depth");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Depth", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.OfficeApi.ColorFormat ExtrusionColor
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.OfficeApi.ColorFormat>(this, "ExtrusionColor", typeof(NetOffice.OfficeApi.ColorFormat));
            }
        }

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.OfficeApi.Enums.MsoExtrusionColorType ExtrusionColorType
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.OfficeApi.Enums.MsoExtrusionColorType>(this, "ExtrusionColorType");
            }
            set
            {
                Factory.ExecuteEnumPropertySet(this, "ExtrusionColorType", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.OfficeApi.Enums.MsoTriState Perspective
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.OfficeApi.Enums.MsoTriState>(this, "Perspective");
            }
            set
            {
                Factory.ExecuteEnumPropertySet(this, "Perspective", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.OfficeApi.Enums.MsoPresetExtrusionDirection PresetExtrusionDirection
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.OfficeApi.Enums.MsoPresetExtrusionDirection>(this, "PresetExtrusionDirection");
            }
        }

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.OfficeApi.Enums.MsoPresetLightingDirection PresetLightingDirection
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.OfficeApi.Enums.MsoPresetLightingDirection>(this, "PresetLightingDirection");
            }
            set
            {
                Factory.ExecuteEnumPropertySet(this, "PresetLightingDirection", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.OfficeApi.Enums.MsoPresetLightingSoftness PresetLightingSoftness
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.OfficeApi.Enums.MsoPresetLightingSoftness>(this, "PresetLightingSoftness");
            }
            set
            {
                Factory.ExecuteEnumPropertySet(this, "PresetLightingSoftness", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.OfficeApi.Enums.MsoPresetMaterial PresetMaterial
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.OfficeApi.Enums.MsoPresetMaterial>(this, "PresetMaterial");
            }
            set
            {
                Factory.ExecuteEnumPropertySet(this, "PresetMaterial", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.OfficeApi.Enums.MsoPresetThreeDFormat PresetThreeDFormat
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.OfficeApi.Enums.MsoPresetThreeDFormat>(this, "PresetThreeDFormat");
            }
        }

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Single RotationX
        {
            get
            {
                return Factory.ExecuteSinglePropertyGet(this, "RotationX");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "RotationX", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Single RotationY
        {
            get
            {
                return Factory.ExecuteSinglePropertyGet(this, "RotationY");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "RotationY", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.OfficeApi.Enums.MsoTriState Visible
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.OfficeApi.Enums.MsoTriState>(this, "Visible");
            }
            set
            {
                Factory.ExecuteEnumPropertySet(this, "Visible", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual NetOffice.OfficeApi.Enums.MsoLightRigType PresetLighting
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.OfficeApi.Enums.MsoLightRigType>(this, "PresetLighting");
            }
            set
            {
                Factory.ExecuteEnumPropertySet(this, "PresetLighting", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual Single Z
        {
            get
            {
                return Factory.ExecuteSinglePropertyGet(this, "Z");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Z", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual NetOffice.OfficeApi.Enums.MsoBevelType BevelTopType
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.OfficeApi.Enums.MsoBevelType>(this, "BevelTopType");
            }
            set
            {
                Factory.ExecuteEnumPropertySet(this, "BevelTopType", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual Single BevelTopInset
        {
            get
            {
                return Factory.ExecuteSinglePropertyGet(this, "BevelTopInset");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "BevelTopInset", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual Single BevelTopDepth
        {
            get
            {
                return Factory.ExecuteSinglePropertyGet(this, "BevelTopDepth");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "BevelTopDepth", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual NetOffice.OfficeApi.Enums.MsoBevelType BevelBottomType
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.OfficeApi.Enums.MsoBevelType>(this, "BevelBottomType");
            }
            set
            {
                Factory.ExecuteEnumPropertySet(this, "BevelBottomType", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual Single BevelBottomInset
        {
            get
            {
                return Factory.ExecuteSinglePropertyGet(this, "BevelBottomInset");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "BevelBottomInset", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual Single BevelBottomDepth
        {
            get
            {
                return Factory.ExecuteSinglePropertyGet(this, "BevelBottomDepth");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "BevelBottomDepth", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual NetOffice.OfficeApi.Enums.MsoPresetCamera PresetCamera
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.OfficeApi.Enums.MsoPresetCamera>(this, "PresetCamera");
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual Single RotationZ
        {
            get
            {
                return Factory.ExecuteSinglePropertyGet(this, "RotationZ");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "RotationZ", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual Single ContourWidth
        {
            get
            {
                return Factory.ExecuteSinglePropertyGet(this, "ContourWidth");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "ContourWidth", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual NetOffice.OfficeApi.ColorFormat ContourColor
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.OfficeApi.ColorFormat>(this, "ContourColor", typeof(NetOffice.OfficeApi.ColorFormat));
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual Single FieldOfView
        {
            get
            {
                return Factory.ExecuteSinglePropertyGet(this, "FieldOfView");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "FieldOfView", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual NetOffice.OfficeApi.Enums.MsoTriState ProjectText
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.OfficeApi.Enums.MsoTriState>(this, "ProjectText");
            }
            set
            {
                Factory.ExecuteEnumPropertySet(this, "ProjectText", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual Single LightAngle
        {
            get
            {
                return Factory.ExecuteSinglePropertyGet(this, "LightAngle");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "LightAngle", value);
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="increment">Single increment</param>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        public virtual void IncrementRotationX(Single increment)
        {
            Factory.ExecuteMethod(this, "IncrementRotationX", increment);
        }

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="increment">Single increment</param>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        public virtual void IncrementRotationY(Single increment)
        {
            Factory.ExecuteMethod(this, "IncrementRotationY", increment);
        }

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        public virtual void ResetRotation()
        {
            Factory.ExecuteMethod(this, "ResetRotation");
        }

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="presetThreeDFormat">NetOffice.OfficeApi.Enums.MsoPresetThreeDFormat presetThreeDFormat</param>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        public virtual void SetThreeDFormat(NetOffice.OfficeApi.Enums.MsoPresetThreeDFormat presetThreeDFormat)
        {
            Factory.ExecuteMethod(this, "SetThreeDFormat", presetThreeDFormat);
        }

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="presetExtrusionDirection">NetOffice.OfficeApi.Enums.MsoPresetExtrusionDirection presetExtrusionDirection</param>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        public virtual void SetExtrusionDirection(NetOffice.OfficeApi.Enums.MsoPresetExtrusionDirection presetExtrusionDirection)
        {
            Factory.ExecuteMethod(this, "SetExtrusionDirection", presetExtrusionDirection);
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// </summary>
        /// <param name="presetCamera">NetOffice.OfficeApi.Enums.MsoPresetCamera presetCamera</param>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual void SetPresetCamera(NetOffice.OfficeApi.Enums.MsoPresetCamera presetCamera)
        {
            Factory.ExecuteMethod(this, "SetPresetCamera", presetCamera);
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// </summary>
        /// <param name="increment">Single increment</param>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual void IncrementRotationZ(Single increment)
        {
            Factory.ExecuteMethod(this, "IncrementRotationZ", increment);
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// </summary>
        /// <param name="increment">Single increment</param>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual void IncrementRotationHorizontal(Single increment)
        {
            Factory.ExecuteMethod(this, "IncrementRotationHorizontal", increment);
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// </summary>
        /// <param name="increment">Single increment</param>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual void IncrementRotationVertical(Single increment)
        {
            Factory.ExecuteMethod(this, "IncrementRotationVertical", increment);
        }

        #endregion

        #pragma warning restore
    }
}