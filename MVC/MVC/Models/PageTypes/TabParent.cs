﻿//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at https://docs.xperience.io/.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.Generic;

[assembly: RegisterDocumentType(TabParent.CLASS_NAME, typeof(TabParent))]

namespace CMS.DocumentEngine.Types.Generic
{
	/// <summary>
	/// Represents a content item of type TabParent.
	/// </summary>
	public partial class TabParent : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "Generic.TabParent";


		/// <summary>
		/// The instance of the class that provides extended API for working with TabParent fields.
		/// </summary>
		private readonly TabParentFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// TabParentID.
		/// </summary>
		[DatabaseIDField]
		public int TabParentID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("TabParentID"), 0);
			}
			set
			{
				SetValue("TabParentID", value);
			}
		}


		/// <summary>
		/// Name.
		/// </summary>
		[DatabaseField]
		public string TabParentName
		{
			get
			{
				return ValidationHelper.GetString(GetValue("TabParentName"), @"");
			}
			set
			{
				SetValue("TabParentName", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with TabParent fields.
		/// </summary>
		[RegisterProperty]
		public TabParentFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with TabParent fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class TabParentFields : AbstractHierarchicalObject<TabParentFields>
		{
			/// <summary>
			/// The content item of type TabParent that is a target of the extended API.
			/// </summary>
			private readonly TabParent mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="TabParentFields" /> class with the specified content item of type TabParent.
			/// </summary>
			/// <param name="instance">The content item of type TabParent that is a target of the extended API.</param>
			public TabParentFields(TabParent instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// TabParentID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.TabParentID;
				}
				set
				{
					mInstance.TabParentID = value;
				}
			}


			/// <summary>
			/// Name.
			/// </summary>
			public string Name
			{
				get
				{
					return mInstance.TabParentName;
				}
				set
				{
					mInstance.TabParentName = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="TabParent" /> class.
		/// </summary>
		public TabParent() : base(CLASS_NAME)
		{
			mFields = new TabParentFields(this);
		}

		#endregion
	}
}