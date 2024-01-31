using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x02002B7E RID: 11134
public class GClass3066 : GClass3065
{
	// Token: 0x17002694 RID: 9876
	// (get) Token: 0x0600DBD5 RID: 56277 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600DBD6 RID: 56278 RVA: 0x00002050 File Offset: 0x00000250
	public int SelectedLevel
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x0600DBD7 RID: 56279 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateInteractableTabs(int activeLevel)
	{
		throw null;
	}

	// Token: 0x0600DBD8 RID: 56280 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Show(int level, bool sendCallback = true)
	{
		throw null;
	}

	// Token: 0x0600DBD9 RID: 56281 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void SelectTab(Tab tab, bool sendCallback = true)
	{
		throw null;
	}

	// Token: 0x0400DFDA RID: 57306
	[CompilerGenerated]
	private int int_0;

	// Token: 0x02002B7F RID: 11135
	public static class GClass3067
	{
		// Token: 0x0600DBDA RID: 56282 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Tab[] SelectTabs(Tab[] levelTabs, Tab allItemsTab, Tab eliteLevelTab, int eliteLevelIndex)
		{
			throw null;
		}

		// Token: 0x02002B80 RID: 11136
		[CompilerGenerated]
		private sealed class Class2635
		{
			// Token: 0x0600DBDB RID: 56283 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<Tab> method_0()
			{
				throw null;
			}

			// Token: 0x0400DFDB RID: 57307
			public Tab[] levelTabs;

			// Token: 0x0400DFDC RID: 57308
			public int eliteLevelIndex;

			// Token: 0x02002B81 RID: 11137
			private sealed class Class2636 : IEnumerator, IDisposable, IEnumerable, IEnumerable<Tab>, IEnumerator<Tab>
			{
				// Token: 0x0600DBDC RID: 56284 RVA: 0x00002050 File Offset: 0x00000250
				[DebuggerHidden]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IDisposable.Dispose()
				{
					throw null;
				}

				// Token: 0x0600DBDD RID: 56285 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				bool IEnumerator.MoveNext()
				{
					throw null;
				}

				// Token: 0x0600DBDE RID: 56286 RVA: 0x00002050 File Offset: 0x00000250
				[DebuggerHidden]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IEnumerator.Reset()
				{
					throw null;
				}

				public Tab Current { get; }

				// Token: 0x17002696 RID: 9878
				// (get) Token: 0x0600DBDF RID: 56287 RVA: 0x00002050 File Offset: 0x00000250
				object IEnumerator.Current
				{
					[DebuggerHidden]
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}

				// Token: 0x0600DBE0 RID: 56288 RVA: 0x00002050 File Offset: 0x00000250
				public IEnumerator<Tab> GetEnumerator()
				{
					throw new NotImplementedException();
				}

				[DebuggerHidden]
				[MethodImpl(MethodImplOptions.NoInlining)]
				IEnumerator IEnumerable.GetEnumerator()
				{
					throw null;
				}

				// Token: 0x0400DFDD RID: 57309
				private int int_0;

				// Token: 0x0400DFDE RID: 57310
				private Tab tab_0;

				// Token: 0x0400DFDF RID: 57311
				private int int_1;

				// Token: 0x0400DFE0 RID: 57312
				public GClass3066.GClass3067.Class2635 class2635_0;

				// Token: 0x0400DFE1 RID: 57313
				private int int_2;
			}
		}
	}
}
