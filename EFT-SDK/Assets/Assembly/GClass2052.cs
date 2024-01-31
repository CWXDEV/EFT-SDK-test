using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT.Trading;

// Token: 0x02001D51 RID: 7505
public sealed class GClass2052 : IDisposable, IEnumerable, IEnumerable<GClass2052.GStruct248>
{
	// Token: 0x140001D5 RID: 469
	// (add) Token: 0x06009B11 RID: 39697 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06009B12 RID: 39698 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GClass2052.GStruct248> OnLineAdded
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

	// Token: 0x06009B13 RID: 39699 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddLine(EDialogSide dialogSide, string speakerName, DialogDataStruct lineConstructor)
	{
		throw null;
	}

	// Token: 0x06009B14 RID: 39700 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void IDisposable.Dispose()
	{
		throw null;
	}

	// Token: 0x06009B15 RID: 39701 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator<GClass2052.GStruct248> GetEnumerator()
	{
		throw null;
	}

	// Token: 0x06009B16 RID: 39702 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		throw null;
	}

	// Token: 0x0400A26C RID: 41580
	[CompilerGenerated]
	private Action<GClass2052.GStruct248> action_0;

	// Token: 0x0400A26D RID: 41581
	private readonly List<GClass2052.GStruct248> list_0;

	// Token: 0x02001D52 RID: 7506
	[StructLayout(LayoutKind.Auto)]
	public readonly struct GStruct248
	{
		// Token: 0x17001816 RID: 6166
		// (get) Token: 0x06009B17 RID: 39703 RVA: 0x00002050 File Offset: 0x00000250
		public string Line
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001817 RID: 6167
		// (get) Token: 0x06009B18 RID: 39704 RVA: 0x00002050 File Offset: 0x00000250
		public string SpeakerName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400A26E RID: 41582
		public readonly EDialogSide DialogSide;

		// Token: 0x0400A26F RID: 41583
		private readonly string string_0;

		// Token: 0x0400A270 RID: 41584
		private readonly DialogDataStruct gstruct245_0;
	}
}
