using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InputSystem;
using EFT.Trading;

// Token: 0x02001D7F RID: 7551
public abstract class GClass2069 : IDisposable
{
	// Token: 0x140001DD RID: 477
	// (add) Token: 0x06009BA4 RID: 39844 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06009BA5 RID: 39845 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GStruct243, DialogDataStruct> OnChangeDialog
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

	// Token: 0x140001DE RID: 478
	// (add) Token: 0x06009BA6 RID: 39846 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06009BA7 RID: 39847 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnBlockDialog
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

	// Token: 0x140001DF RID: 479
	// (add) Token: 0x06009BA8 RID: 39848 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06009BA9 RID: 39849 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnRedraw
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

	// Token: 0x140001E0 RID: 480
	// (add) Token: 0x06009BAA RID: 39850 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06009BAB RID: 39851 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GStruct246.GStruct247> OnSaveState
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

	// Token: 0x17001862 RID: 6242
	// (get) Token: 0x06009BAC RID: 39852
	public abstract ETraderDialogType Type { get; }

	// Token: 0x17001863 RID: 6243
	// (get) Token: 0x06009BAD RID: 39853 RVA: 0x00002050 File Offset: 0x00000250
	public string DescriptionKey
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001864 RID: 6244
	// (get) Token: 0x06009BAE RID: 39854 RVA: 0x00002050 File Offset: 0x00000250
	public GStruct243 DialogData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001865 RID: 6245
	// (get) Token: 0x06009BAF RID: 39855 RVA: 0x00002050 File Offset: 0x00000250
	public string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001866 RID: 6246
	// (get) Token: 0x06009BB0 RID: 39856 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009BB1 RID: 39857 RVA: 0x00002050 File Offset: 0x00000250
	public IEnumerable<GClass2053> Lines
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

	// Token: 0x17001867 RID: 6247
	// (get) Token: 0x06009BB2 RID: 39858
	protected abstract string BaseDescriptionKey { get; }

	// Token: 0x06009BB3 RID: 39859 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeTraderLine(string newLine)
	{
		throw null;
	}

	// Token: 0x06009BB4 RID: 39860 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_0(IEnumerable<GClass2053> lines)
	{
		throw null;
	}

	// Token: 0x06009BB5 RID: 39861 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void InitLine(GClass2053 line)
	{
		throw null;
	}

	// Token: 0x06009BB6 RID: 39862 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(GClass2053 line)
	{
		throw null;
	}

	// Token: 0x06009BB7 RID: 39863 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(GStruct243 dialogData, DialogDataStruct lineConstructor)
	{
		throw null;
	}

	// Token: 0x06009BB8 RID: 39864 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_3()
	{
		throw null;
	}

	// Token: 0x06009BB9 RID: 39865 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(GStruct246.GStruct247 saveData)
	{
		throw null;
	}

	// Token: 0x06009BBA RID: 39866 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_5()
	{
		throw null;
	}

	// Token: 0x06009BBB RID: 39867 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public InputNode.ETranslateResult TranslateCommand(ECommand command)
	{
		throw null;
	}

	// Token: 0x06009BBC RID: 39868 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Dispose()
	{
		throw null;
	}

	// Token: 0x0400A2FA RID: 41722
	[CompilerGenerated]
	private Action<GStruct243, DialogDataStruct> action_0;

	// Token: 0x0400A2FB RID: 41723
	[CompilerGenerated]
	private Action action_1;

	// Token: 0x0400A2FC RID: 41724
	[CompilerGenerated]
	private Action action_2;

	// Token: 0x0400A2FD RID: 41725
	[CompilerGenerated]
	private Action<GStruct246.GStruct247> action_3;

	// Token: 0x0400A2FE RID: 41726
	private string string_0;

	// Token: 0x0400A2FF RID: 41727
	public readonly GStruct243 Source;

	// Token: 0x0400A300 RID: 41728
	private bool bool_0;

	// Token: 0x0400A301 RID: 41729
	protected readonly GClass763 gclass763_0;

	// Token: 0x0400A302 RID: 41730
	[CompilerGenerated]
	private IEnumerable<GClass2053> ienumerable_0;

	// Token: 0x02001D80 RID: 7552
	[CompilerGenerated]
	private sealed class Class1758
	{
		// Token: 0x06009BBD RID: 39869 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x0400A303 RID: 41731
		public GClass2053 line;

		// Token: 0x0400A304 RID: 41732
		public GClass2069 gclass2069_0;
	}

	// Token: 0x02001D81 RID: 7553
	[CompilerGenerated]
	private sealed class Class1759
	{
		// Token: 0x06009BBE RID: 39870 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x0400A305 RID: 41733
		public GClass2053 line;

		// Token: 0x0400A306 RID: 41734
		public GClass2069 gclass2069_0;
	}
}
