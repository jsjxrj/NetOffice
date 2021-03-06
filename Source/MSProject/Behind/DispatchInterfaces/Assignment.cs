﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.MSProjectApi;

namespace NetOffice.MSProjectApi.Behind
{
	/// <summary>
	/// DispatchInterface Assignment 
	/// SupportByVersion MSProject, 11,12,14
	/// </summary>
	/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff920546(v=office.14).aspx </remarks>
	[SupportByVersion("MSProject", 11,12,14)]
	[EntityType(EntityType.IsDispatchInterface)]
 	public class Assignment : COMObject, NetOffice.MSProjectApi.Assignment
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
                    _type = typeof(Assignment);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public Assignment() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Int32 UniqueID
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "UniqueID");
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Int32 TaskUniqueID
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "TaskUniqueID");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "TaskUniqueID", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Int32 ResourceUniqueID
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "ResourceUniqueID");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "ResourceUniqueID", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Int32 TaskID
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "TaskID");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "TaskID", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Int32 ResourceID
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "ResourceID");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "ResourceID", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string TaskName
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "TaskName");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "TaskName", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string ResourceName
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "ResourceName");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "ResourceName", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Units
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Units");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Units", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Work
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Work");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Work", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object OvertimeWork
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "OvertimeWork");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "OvertimeWork", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object ActualWork
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "ActualWork");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "ActualWork", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object RegularWork
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "RegularWork");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "RegularWork", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object RemainingWork
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "RemainingWork");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "RemainingWork", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object ActualOvertimeWork
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "ActualOvertimeWork");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "ActualOvertimeWork", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object RemainingOvertimeWork
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "RemainingOvertimeWork");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "RemainingOvertimeWork", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object BaselineWork
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "BaselineWork");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "BaselineWork", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Peak
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Peak");
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Start
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Start");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Start", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Finish
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Finish");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Finish", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object ActualStart
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "ActualStart");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "ActualStart", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object ActualFinish
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "ActualFinish");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "ActualFinish", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Delay
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Delay");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Delay", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Cost
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Cost");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Cost", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object OvertimeCost
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "OvertimeCost");
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object ActualCost
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "ActualCost");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "ActualCost", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object RemainingCost
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "RemainingCost");
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object ActualOvertimeCost
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "ActualOvertimeCost");
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object RemainingOvertimeCost
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "RemainingOvertimeCost");
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object BaselineCost
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "BaselineCost");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "BaselineCost", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object BCWS
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "BCWS");
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object BCWP
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "BCWP");
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object ACWP
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "ACWP");
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object SV
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "SV");
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object CostVariance
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "CostVariance");
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual NetOffice.MSProjectApi.Enums.PjWorkContourType WorkContour
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.MSProjectApi.Enums.PjWorkContourType>(this, "WorkContour");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteEnumPropertySet(this, "WorkContour", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object PercentWorkComplete
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "PercentWorkComplete");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "PercentWorkComplete", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string Project
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Project");
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string Notes
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Notes");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Notes", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Confirmed
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Confirmed");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Confirmed", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object ResponsePending
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "ResponsePending");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "ResponsePending", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object UpdateNeeded
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "UpdateNeeded");
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object TeamStatusPending
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "TeamStatusPending");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "TeamStatusPending", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object CostRateTable
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "CostRateTable");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "CostRateTable", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14), ProxyResult]
		public virtual object Parent
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "Parent");
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual NetOffice.MSProjectApi.Application Application
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.MSProjectApi.Application>(this, "Application", typeof(NetOffice.MSProjectApi.Application));
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string Text1
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Text1");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Text1", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string Text2
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Text2");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Text2", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string Text3
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Text3");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Text3", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string Text4
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Text4");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Text4", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string Text5
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Text5");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Text5", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string Text6
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Text6");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Text6", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string Text7
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Text7");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Text7", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string Text8
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Text8");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Text8", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string Text9
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Text9");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Text9", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string Text10
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Text10");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Text10", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Start1
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Start1");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Start1", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Start2
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Start2");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Start2", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Start3
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Start3");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Start3", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Start4
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Start4");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Start4", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Start5
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Start5");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Start5", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Finish1
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Finish1");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Finish1", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Finish2
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Finish2");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Finish2", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Finish3
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Finish3");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Finish3", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Finish4
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Finish4");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Finish4", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Finish5
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Finish5");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Finish5", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double Number1
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "Number1");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Number1", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double Number2
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "Number2");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Number2", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double Number3
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "Number3");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Number3", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double Number4
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "Number4");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Number4", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double Number5
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "Number5");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Number5", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Duration1
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Duration1");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Duration1", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Duration2
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Duration2");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Duration2", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Duration3
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Duration3");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Duration3", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Cost1
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Cost1");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Cost1", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Cost2
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Cost2");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Cost2", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Cost3
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Cost3");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Cost3", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Flag10
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Flag10");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Flag10", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Flag1
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Flag1");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Flag1", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Flag2
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Flag2");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Flag2", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Flag3
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Flag3");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Flag3", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Flag4
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Flag4");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Flag4", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Flag5
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Flag5");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Flag5", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Flag6
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Flag6");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Flag6", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Flag7
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Flag7");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Flag7", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Flag8
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Flag8");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Flag8", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Flag9
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Flag9");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Flag9", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object LinkedFields
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "LinkedFields");
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Overallocated
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Overallocated");
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string TaskSummaryName
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "TaskSummaryName");
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object LevelingDelay
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "LevelingDelay");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "LevelingDelay", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object BaselineStart
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "BaselineStart");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "BaselineStart", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object BaselineFinish
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "BaselineFinish");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "BaselineFinish", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string Hyperlink
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Hyperlink");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Hyperlink", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string HyperlinkAddress
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "HyperlinkAddress");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "HyperlinkAddress", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string HyperlinkSubAddress
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "HyperlinkSubAddress");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "HyperlinkSubAddress", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string HyperlinkHREF
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "HyperlinkHREF");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "HyperlinkHREF", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Cost4
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Cost4");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Cost4", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Cost5
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Cost5");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Cost5", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Cost6
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Cost6");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Cost6", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Cost7
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Cost7");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Cost7", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Cost8
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Cost8");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Cost8", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Cost9
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Cost9");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Cost9", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Cost10
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Cost10");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Cost10", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Date1
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Date1");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Date1", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Date2
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Date2");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Date2", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Date3
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Date3");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Date3", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Date4
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Date4");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Date4", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Date5
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Date5");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Date5", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Date6
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Date6");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Date6", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Date7
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Date7");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Date7", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Date8
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Date8");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Date8", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Date9
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Date9");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Date9", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Date10
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Date10");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Date10", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Duration4
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Duration4");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Duration4", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Duration5
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Duration5");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Duration5", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Duration6
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Duration6");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Duration6", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Duration7
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Duration7");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Duration7", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Duration8
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Duration8");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Duration8", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Duration9
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Duration9");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Duration9", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Duration10
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Duration10");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Duration10", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Finish6
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Finish6");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Finish6", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Finish7
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Finish7");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Finish7", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Finish8
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Finish8");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Finish8", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Finish9
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Finish9");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Finish9", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Finish10
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Finish10");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Finish10", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Flag11
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Flag11");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Flag11", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Flag12
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Flag12");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Flag12", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Flag13
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Flag13");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Flag13", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Flag14
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Flag14");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Flag14", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Flag15
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Flag15");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Flag15", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Flag16
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Flag16");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Flag16", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Flag17
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Flag17");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Flag17", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Flag18
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Flag18");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Flag18", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Flag19
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Flag19");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Flag19", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Flag20
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Flag20");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Flag20", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double Number6
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "Number6");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Number6", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double Number7
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "Number7");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Number7", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double Number8
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "Number8");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Number8", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double Number9
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "Number9");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Number9", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double Number10
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "Number10");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Number10", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double Number11
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "Number11");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Number11", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double Number12
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "Number12");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Number12", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double Number13
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "Number13");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Number13", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double Number14
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "Number14");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Number14", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double Number15
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "Number15");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Number15", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double Number16
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "Number16");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Number16", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double Number17
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "Number17");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Number17", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double Number18
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "Number18");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Number18", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double Number19
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "Number19");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Number19", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double Number20
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "Number20");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Number20", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Start6
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Start6");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Start6", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Start7
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Start7");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Start7", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Start8
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Start8");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Start8", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Start9
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Start9");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Start9", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Start10
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Start10");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Start10", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string Text11
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Text11");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Text11", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string Text12
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Text12");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Text12", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string Text13
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Text13");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Text13", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string Text14
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Text14");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Text14", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string Text15
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Text15");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Text15", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string Text16
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Text16");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Text16", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string Text17
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Text17");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Text17", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string Text18
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Text18");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Text18", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string Text19
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Text19");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Text19", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string Text20
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Text20");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Text20", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string Text21
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Text21");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Text21", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string Text22
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Text22");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Text22", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string Text23
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Text23");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Text23", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string Text24
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Text24");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Text24", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string Text25
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Text25");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Text25", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string Text26
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Text26");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Text26", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string Text27
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Text27");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Text27", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string Text28
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Text28");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Text28", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string Text29
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Text29");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Text29", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string Text30
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Text30");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Text30", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Int32 Index
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "Index");
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object CV
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "CV");
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object WorkVariance
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "WorkVariance");
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object StartVariance
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "StartVariance");
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object FinishVariance
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "FinishVariance");
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object VAC
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "VAC");
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object FixedMaterialAssignment
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "FixedMaterialAssignment");
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual NetOffice.MSProjectApi.Enums.PjResourceTypes ResourceType
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.MSProjectApi.Enums.PjResourceTypes>(this, "ResourceType");
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string HyperlinkScreenTip
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "HyperlinkScreenTip");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "HyperlinkScreenTip", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline1Work
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline1Work");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline1Work", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline1Cost
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline1Cost");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline1Cost", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline1Start
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline1Start");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline1Start", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline1Finish
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline1Finish");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline1Finish", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline2Work
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline2Work");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline2Work", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline2Cost
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline2Cost");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline2Cost", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline2Start
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline2Start");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline2Start", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline2Finish
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline2Finish");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline2Finish", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline3Work
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline3Work");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline3Work", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline3Cost
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline3Cost");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline3Cost", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline3Start
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline3Start");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline3Start", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline3Finish
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline3Finish");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline3Finish", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline4Work
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline4Work");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline4Work", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline4Cost
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline4Cost");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline4Cost", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline4Start
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline4Start");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline4Start", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline4Finish
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline4Finish");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline4Finish", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline5Work
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline5Work");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline5Work", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline5Cost
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline5Cost");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline5Cost", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline5Start
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline5Start");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline5Start", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline5Finish
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline5Finish");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline5Finish", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline6Work
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline6Work");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline6Work", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline6Cost
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline6Cost");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline6Cost", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline6Start
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline6Start");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline6Start", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline6Finish
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline6Finish");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline6Finish", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline7Work
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline7Work");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline7Work", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline7Cost
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline7Cost");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline7Cost", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline7Start
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline7Start");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline7Start", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline7Finish
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline7Finish");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline7Finish", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline8Work
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline8Work");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline8Work", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline8Cost
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline8Cost");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline8Cost", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline8Start
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline8Start");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline8Start", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline8Finish
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline8Finish");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline8Finish", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline9Work
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline9Work");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline9Work", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline9Cost
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline9Cost");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline9Cost", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline9Start
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline9Start");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline9Start", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline9Finish
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline9Finish");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline9Finish", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline10Work
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline10Work");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline10Work", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline10Cost
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline10Cost");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline10Cost", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline10Start
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline10Start");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline10Start", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline10Finish
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline10Finish");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline10Finish", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string TaskOutlineNumber
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "TaskOutlineNumber");
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseCost1
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseCost1");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseCost1", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseCost2
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseCost2");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseCost2", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseCost3
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseCost3");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseCost3", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseCost4
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseCost4");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseCost4", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseCost5
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseCost5");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseCost5", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseCost6
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseCost6");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseCost6", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseCost7
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseCost7");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseCost7", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseCost8
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseCost8");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseCost8", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseCost9
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseCost9");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseCost9", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseCost10
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseCost10");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseCost10", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDate1
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDate1");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDate1", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDate2
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDate2");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDate2", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDate3
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDate3");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDate3", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDate4
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDate4");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDate4", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDate5
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDate5");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDate5", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDate6
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDate6");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDate6", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDate7
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDate7");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDate7", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDate8
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDate8");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDate8", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDate9
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDate9");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDate9", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDate10
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDate10");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDate10", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDate11
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDate11");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDate11", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDate12
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDate12");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDate12", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDate13
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDate13");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDate13", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDate14
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDate14");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDate14", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDate15
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDate15");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDate15", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDate16
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDate16");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDate16", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDate17
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDate17");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDate17", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDate18
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDate18");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDate18", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDate19
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDate19");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDate19", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDate20
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDate20");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDate20", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDate21
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDate21");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDate21", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDate22
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDate22");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDate22", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDate23
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDate23");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDate23", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDate24
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDate24");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDate24", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDate25
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDate25");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDate25", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDate26
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDate26");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDate26", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDate27
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDate27");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDate27", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDate28
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDate28");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDate28", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDate29
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDate29");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDate29", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDate30
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDate30");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDate30", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDuration1
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDuration1");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDuration1", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDuration2
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDuration2");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDuration2", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDuration3
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDuration3");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDuration3", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDuration4
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDuration4");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDuration4", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDuration5
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDuration5");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDuration5", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDuration6
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDuration6");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDuration6", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDuration7
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDuration7");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDuration7", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDuration8
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDuration8");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDuration8", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDuration9
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDuration9");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDuration9", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseDuration10
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseDuration10");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseDuration10", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseFlag1
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseFlag1");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseFlag1", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseFlag2
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseFlag2");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseFlag2", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseFlag3
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseFlag3");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseFlag3", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseFlag4
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseFlag4");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseFlag4", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseFlag5
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseFlag5");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseFlag5", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseFlag6
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseFlag6");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseFlag6", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseFlag7
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseFlag7");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseFlag7", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseFlag8
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseFlag8");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseFlag8", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseFlag9
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseFlag9");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseFlag9", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseFlag10
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseFlag10");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseFlag10", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseFlag11
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseFlag11");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseFlag11", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseFlag12
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseFlag12");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseFlag12", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseFlag13
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseFlag13");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseFlag13", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseFlag14
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseFlag14");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseFlag14", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseFlag15
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseFlag15");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseFlag15", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseFlag16
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseFlag16");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseFlag16", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseFlag17
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseFlag17");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseFlag17", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseFlag18
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseFlag18");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseFlag18", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseFlag19
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseFlag19");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseFlag19", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object EnterpriseFlag20
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EnterpriseFlag20");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EnterpriseFlag20", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber1
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber1");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber1", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber2
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber2");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber2", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber3
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber3");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber3", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber4
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber4");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber4", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber5
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber5");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber5", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber6
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber6");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber6", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber7
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber7");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber7", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber8
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber8");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber8", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber9
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber9");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber9", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber10
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber10");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber10", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber11
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber11");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber11", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber12
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber12");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber12", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber13
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber13");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber13", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber14
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber14");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber14", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber15
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber15");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber15", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber16
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber16");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber16", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber17
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber17");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber17", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber18
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber18");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber18", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber19
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber19");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber19", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber20
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber20");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber20", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber21
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber21");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber21", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber22
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber22");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber22", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber23
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber23");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber23", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber24
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber24");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber24", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber25
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber25");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber25", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber26
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber26");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber26", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber27
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber27");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber27", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber28
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber28");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber28", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber29
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber29");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber29", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber30
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber30");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber30", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber31
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber31");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber31", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber32
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber32");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber32", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber33
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber33");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber33", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber34
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber34");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber34", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber35
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber35");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber35", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber36
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber36");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber36", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber37
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber37");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber37", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber38
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber38");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber38", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber39
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber39");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber39", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Double EnterpriseNumber40
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "EnterpriseNumber40");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseNumber40", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText1
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText1");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText1", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText2
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText2");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText2", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText3
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText3");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText3", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText4
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText4");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText4", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText5
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText5");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText5", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText6
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText6");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText6", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText7
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText7");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText7", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText8
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText8");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText8", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText9
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText9");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText9", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText10
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText10");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText10", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText11
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText11");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText11", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText12
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText12");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText12", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText13
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText13");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText13", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText14
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText14");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText14", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText15
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText15");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText15", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText16
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText16");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText16", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText17
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText17");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText17", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText18
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText18");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText18", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText19
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText19");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText19", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText20
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText20");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText20", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText21
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText21");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText21", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText22
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText22");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText22", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText23
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText23");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText23", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText24
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText24");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText24", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText25
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText25");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText25", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText26
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText26");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText26", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText27
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText27");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText27", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText28
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText28");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText28", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText29
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText29");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText29", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText30
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText30");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText30", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText31
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText31");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText31", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText32
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText32");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText32", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText33
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText33");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText33", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText34
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText34");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText34", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText35
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText35");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText35", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText36
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText36");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText36", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText37
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText37");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText37", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText38
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText38");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText38", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText39
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText39");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText39", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseText40
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseText40");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseText40", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceOutlineCode1
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceOutlineCode1");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceOutlineCode1", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceOutlineCode2
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceOutlineCode2");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceOutlineCode2", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceOutlineCode3
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceOutlineCode3");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceOutlineCode3", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceOutlineCode4
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceOutlineCode4");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceOutlineCode4", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceOutlineCode5
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceOutlineCode5");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceOutlineCode5", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceOutlineCode6
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceOutlineCode6");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceOutlineCode6", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceOutlineCode7
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceOutlineCode7");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceOutlineCode7", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceOutlineCode8
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceOutlineCode8");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceOutlineCode8", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceOutlineCode9
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceOutlineCode9");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceOutlineCode9", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceOutlineCode10
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceOutlineCode10");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceOutlineCode10", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceOutlineCode11
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceOutlineCode11");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceOutlineCode11", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceOutlineCode12
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceOutlineCode12");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceOutlineCode12", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceOutlineCode13
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceOutlineCode13");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceOutlineCode13", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceOutlineCode14
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceOutlineCode14");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceOutlineCode14", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceOutlineCode15
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceOutlineCode15");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceOutlineCode15", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceOutlineCode16
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceOutlineCode16");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceOutlineCode16", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceOutlineCode17
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceOutlineCode17");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceOutlineCode17", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceOutlineCode18
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceOutlineCode18");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceOutlineCode18", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceOutlineCode19
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceOutlineCode19");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceOutlineCode19", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceOutlineCode20
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceOutlineCode20");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceOutlineCode20", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceOutlineCode21
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceOutlineCode21");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceOutlineCode21", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceOutlineCode22
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceOutlineCode22");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceOutlineCode22", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceOutlineCode23
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceOutlineCode23");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceOutlineCode23", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceOutlineCode24
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceOutlineCode24");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceOutlineCode24", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceOutlineCode25
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceOutlineCode25");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceOutlineCode25", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceOutlineCode26
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceOutlineCode26");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceOutlineCode26", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceOutlineCode27
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceOutlineCode27");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceOutlineCode27", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceOutlineCode28
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceOutlineCode28");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceOutlineCode28", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceOutlineCode29
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceOutlineCode29");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceOutlineCode29", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceRBS
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceRBS");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceRBS", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual NetOffice.MSProjectApi.Enums.PjResourceRequestType ResourceRequestType
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.MSProjectApi.Enums.PjResourceRequestType>(this, "ResourceRequestType");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteEnumPropertySet(this, "ResourceRequestType", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceMultiValue20
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceMultiValue20");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceMultiValue20", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceMultiValue21
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceMultiValue21");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceMultiValue21", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceMultiValue22
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceMultiValue22");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceMultiValue22", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceMultiValue23
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceMultiValue23");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceMultiValue23", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceMultiValue24
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceMultiValue24");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceMultiValue24", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceMultiValue25
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceMultiValue25");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceMultiValue25", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceMultiValue26
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceMultiValue26");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceMultiValue26", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceMultiValue27
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceMultiValue27");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceMultiValue27", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceMultiValue28
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceMultiValue28");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceMultiValue28", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string EnterpriseResourceMultiValue29
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EnterpriseResourceMultiValue29");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnterpriseResourceMultiValue29", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object ActualWorkProtected
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "ActualWorkProtected");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "ActualWorkProtected", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object ActualOvtWorkProtected
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "ActualOvtWorkProtected");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "ActualOvtWorkProtected", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Created
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Created");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Created", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string WBS
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "WBS");
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual NetOffice.MSProjectApi.Enums.PjBookingTypes BookingType
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.MSProjectApi.Enums.PjBookingTypes>(this, "BookingType");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteEnumPropertySet(this, "BookingType", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string Guid
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Guid");
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string TaskGuid
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "TaskGuid");
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string ResourceGuid
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "ResourceGuid");
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string Summary
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Summary");
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual string Owner
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Owner");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Owner", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object BudgetWork
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "BudgetWork");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "BudgetWork", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object BudgetCost
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "BudgetCost");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "BudgetCost", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object BaselineBudgetWork
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "BaselineBudgetWork");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "BaselineBudgetWork", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object BaselineBudgetCost
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "BaselineBudgetCost");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "BaselineBudgetCost", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline1BudgetWork
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline1BudgetWork");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline1BudgetWork", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline1BudgetCost
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline1BudgetCost");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline1BudgetCost", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline2BudgetWork
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline2BudgetWork");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline2BudgetWork", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline2BudgetCost
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline2BudgetCost");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline2BudgetCost", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline3BudgetWork
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline3BudgetWork");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline3BudgetWork", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline3BudgetCost
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline3BudgetCost");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline3BudgetCost", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline4BudgetWork
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline4BudgetWork");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline4BudgetWork", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline4BudgetCost
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline4BudgetCost");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline4BudgetCost", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline5BudgetWork
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline5BudgetWork");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline5BudgetWork", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline5BudgetCost
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline5BudgetCost");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline5BudgetCost", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline6BudgetWork
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline6BudgetWork");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline6BudgetWork", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline6BudgetCost
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline6BudgetCost");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline6BudgetCost", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline7BudgetWork
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline7BudgetWork");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline7BudgetWork", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline7BudgetCost
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline7BudgetCost");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline7BudgetCost", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline8BudgetWork
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline8BudgetWork");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline8BudgetWork", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline8BudgetCost
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline8BudgetCost");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline8BudgetCost", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline9BudgetWork
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline9BudgetWork");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline9BudgetWork", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline9BudgetCost
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline9BudgetCost");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline9BudgetCost", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline10BudgetWork
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline10BudgetWork");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline10BudgetWork", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual object Baseline10BudgetCost
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Baseline10BudgetCost");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Baseline10BudgetCost", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,14)]
		public virtual NetOffice.MSProjectApi.Task Task
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.MSProjectApi.Task>(this, "Task", typeof(NetOffice.MSProjectApi.Task));
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,14)]
		public virtual NetOffice.MSProjectApi.Resource Resource
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.MSProjectApi.Resource>(this, "Resource", typeof(NetOffice.MSProjectApi.Resource));
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual void Delete()
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "Delete");
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// </summary>
		/// <param name="value">string value</param>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual void AppendNotes(string value)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "AppendNotes", value);
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// </summary>
		/// <param name="startDate">object startDate</param>
		/// <param name="endDate">object endDate</param>
		/// <param name="type">optional NetOffice.MSProjectApi.Enums.PjAssignmentTimescaledData Type = 8</param>
		/// <param name="timeScaleUnit">optional NetOffice.MSProjectApi.Enums.PjTimescaleUnit TimeScaleUnit = 3</param>
		/// <param name="count">optional Int32 Count = 1</param>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual NetOffice.MSProjectApi.TimeScaleValues TimeScaleData(object startDate, object endDate, object type, object timeScaleUnit, object count)
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.MSProjectApi.TimeScaleValues>(this, "TimeScaleData", typeof(NetOffice.MSProjectApi.TimeScaleValues), new object[]{ startDate, endDate, type, timeScaleUnit, count });
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// </summary>
		/// <param name="startDate">object startDate</param>
		/// <param name="endDate">object endDate</param>
		[CustomMethod]
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual NetOffice.MSProjectApi.TimeScaleValues TimeScaleData(object startDate, object endDate)
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.MSProjectApi.TimeScaleValues>(this, "TimeScaleData", typeof(NetOffice.MSProjectApi.TimeScaleValues), startDate, endDate);
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// </summary>
		/// <param name="startDate">object startDate</param>
		/// <param name="endDate">object endDate</param>
		/// <param name="type">optional NetOffice.MSProjectApi.Enums.PjAssignmentTimescaledData Type = 8</param>
		[CustomMethod]
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual NetOffice.MSProjectApi.TimeScaleValues TimeScaleData(object startDate, object endDate, object type)
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.MSProjectApi.TimeScaleValues>(this, "TimeScaleData", typeof(NetOffice.MSProjectApi.TimeScaleValues), startDate, endDate, type);
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// </summary>
		/// <param name="startDate">object startDate</param>
		/// <param name="endDate">object endDate</param>
		/// <param name="type">optional NetOffice.MSProjectApi.Enums.PjAssignmentTimescaledData Type = 8</param>
		/// <param name="timeScaleUnit">optional NetOffice.MSProjectApi.Enums.PjTimescaleUnit TimeScaleUnit = 3</param>
		[CustomMethod]
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual NetOffice.MSProjectApi.TimeScaleValues TimeScaleData(object startDate, object endDate, object type, object timeScaleUnit)
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.MSProjectApi.TimeScaleValues>(this, "TimeScaleData", typeof(NetOffice.MSProjectApi.TimeScaleValues), startDate, endDate, type, timeScaleUnit);
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// </summary>
		/// <param name="project">object project</param>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual bool EnterpriseTeamMember(object project)
		{
			return InvokerService.InvokeInternal.ExecuteBoolMethodGet(this, "EnterpriseTeamMember", project);
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 14
		/// </summary>
		/// <param name="action">NetOffice.MSProjectApi.Enums.PjAssignmentReplanAction action</param>
		[SupportByVersion("MSProject", 11,14)]
		public virtual void Replan(NetOffice.MSProjectApi.Enums.PjAssignmentReplanAction action)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "Replan", action);
		}

		#endregion

		#pragma warning restore
	}
}


