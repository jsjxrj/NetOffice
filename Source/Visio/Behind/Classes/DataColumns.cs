﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.VisioApi.Behind
{
	/// <summary>
	/// CoClass DataColumns 
	/// SupportByVersion Visio, 12,14,15,16
	/// </summary>
	/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/ff769253(v=office.14).aspx </remarks>
	[SupportByVersion("Visio", 12,14,15,16)]
	[EntityType(EntityType.IsCoClass)]
 	public class DataColumns : IVDataColumns, NetOffice.VisioApi.DataColumns
    {
		#pragma warning disable

		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
        private static Type _type;

        #endregion

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
        
        /// <summary>
        /// Type Cache
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(DataColumns);
                return _type;
            }
        }
        
        #endregion
        		
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public DataColumns() : base()
		{

		}

		#endregion

		#region Static CoClass Methods
		#endregion

		#region Events

		#endregion
       
		#pragma warning restore
	}
}

