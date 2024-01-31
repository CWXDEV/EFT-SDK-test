using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace ChartAndGraph
{
	// Token: 0x0200318E RID: 12686
	[Serializable]
	public abstract class ItemLabelsBase : ChartSettingItemBase, ISerializationCallbackReceiver
	{
		// Token: 0x17002B38 RID: 11064
		// (get) Token: 0x0600FA03 RID: 64003 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600FA04 RID: 64004 RVA: 0x00002050 File Offset: 0x00000250
		public Text TextPrefab
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600FA05 RID: 64005 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x17002B39 RID: 11065
		// (get) Token: 0x0600FA06 RID: 64006 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600FA07 RID: 64007 RVA: 0x00002050 File Offset: 0x00000250
		public TextFormatting TextFormat
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17002B3A RID: 11066
		// (get) Token: 0x0600FA08 RID: 64008 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600FA09 RID: 64009 RVA: 0x00002050 File Offset: 0x00000250
		public int FontSize
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17002B3B RID: 11067
		// (get) Token: 0x0600FA0A RID: 64010 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600FA0B RID: 64011 RVA: 0x00002050 File Offset: 0x00000250
		public float FontSharpness
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17002B3C RID: 11068
		// (get) Token: 0x0600FA0C RID: 64012 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600FA0D RID: 64013 RVA: 0x00002050 File Offset: 0x00000250
		public float Seperation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600FA0E RID: 64014 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ValidateProperties()
		{
			throw null;
		}

		// Token: 0x17002B3D RID: 11069
		// (get) Token: 0x0600FA0F RID: 64015 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600FA10 RID: 64016 RVA: 0x00002050 File Offset: 0x00000250
		public ChartOrientedSize Location
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600FA11 RID: 64017 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
			throw null;
		}

		// Token: 0x0600FA12 RID: 64018 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
			throw null;
		}

		// Token: 0x0400FE25 RID: 65061
		[SerializeField]
		[Tooltip("This prefab will be used to create all the text associated with the chart. If the prefab is null no labels will be shown")]
		private Text textPrefab;

		// Token: 0x0400FE26 RID: 65062
		[SerializeField]
		[Tooltip(" determine the formatting of the label data. when the values are available , you can use the predefined macros : '\\n' for newline , '<?category>' for the current category and '<?group>' for the current group")]
		private TextFormatting textFormat;

		// Token: 0x0400FE27 RID: 65063
		[SerializeField]
		[Tooltip("the font size for the labels")]
		private int fontSize;

		// Token: 0x0400FE28 RID: 65064
		[Tooltip("adjusts the sharpness of the font")]
		[Range(1f, 3f)]
		[SerializeField]
		private float fontSharpness;

		// Token: 0x0400FE29 RID: 65065
		[SerializeField]
		[Tooltip("the seperation of each label from it's origin")]
		private float seperation;

		// Token: 0x0400FE2A RID: 65066
		[Tooltip("the location of the label relative to the item")]
		[SerializeField]
		private ChartOrientedSize location;
	}
}
