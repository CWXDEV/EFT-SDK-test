using System;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

namespace ChartAndGraph
{
	// Token: 0x02003192 RID: 12690
	[Serializable]
	public class TextFormatting : IInternalSettings
	{
		// Token: 0x17002B41 RID: 11073
		// (get) Token: 0x0600FA26 RID: 64038 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600FA27 RID: 64039 RVA: 0x00002050 File Offset: 0x00000250
		public string Suffix
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

		// Token: 0x17002B42 RID: 11074
		// (get) Token: 0x0600FA28 RID: 64040 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600FA29 RID: 64041 RVA: 0x00002050 File Offset: 0x00000250
		public string Prefix
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

		// Token: 0x140003B4 RID: 948
		// (add) Token: 0x0600FA2A RID: 64042 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600FA2B RID: 64043 RVA: 0x00002050 File Offset: 0x00000250
		private event EventHandler Event_0
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x140003B5 RID: 949
		// (add) Token: 0x0600FA2C RID: 64044 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600FA2D RID: 64045 RVA: 0x00002050 File Offset: 0x00000250
		private event EventHandler Event_1
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x0600FA2E RID: 64046 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void RaiseOnChanged()
		{
			throw null;
		}

		// Token: 0x0600FA2F RID: 64047 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void RaiseOnUpdate()
		{
			throw null;
		}

		// Token: 0x140003B6 RID: 950
		// (add) Token: 0x0600FA30 RID: 64048 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600FA31 RID: 64049 RVA: 0x00002050 File Offset: 0x00000250
		event EventHandler IInternalSettings.InternalOnDataUpdate
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x140003B7 RID: 951
		// (add) Token: 0x0600FA32 RID: 64050 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600FA33 RID: 64051 RVA: 0x00002050 File Offset: 0x00000250
		event EventHandler IInternalSettings.InternalOnDataChanged
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x0600FA34 RID: 64052 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string smethod_0(string str, string category, string group)
		{
			throw null;
		}

		// Token: 0x0600FA35 RID: 64053 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_1(StringBuilder builder, string category, string group)
		{
			throw null;
		}

		// Token: 0x0600FA36 RID: 64054 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string smethod_2(string str)
		{
			throw null;
		}

		// Token: 0x0600FA37 RID: 64055 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Format(StringBuilder builder, string data, string category, string group)
		{
			throw null;
		}

		// Token: 0x0600FA38 RID: 64056 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string Format(string data, string category, string group)
		{
			throw null;
		}

		// Token: 0x0400FE40 RID: 65088
		[SerializeField]
		private string prefix;

		// Token: 0x0400FE41 RID: 65089
		[SerializeField]
		private string suffix;

		// Token: 0x0400FE42 RID: 65090
		[CompilerGenerated]
		private EventHandler OnDataUpdate;

		// Token: 0x0400FE43 RID: 65091
		[CompilerGenerated]
		private EventHandler OnDataChanged;
	}
}
