using System;
using System.Runtime.CompilerServices;
using EFT.InputSystem;

// Token: 0x02001A3B RID: 6715
public abstract class GClass1890
{
	// Token: 0x1700158F RID: 5519
	// (get) Token: 0x06008E2C RID: 36396 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06008E2D RID: 36397 RVA: 0x00002050 File Offset: 0x00000250
	public int Priority
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			throw null;
		}
	}

	// Token: 0x06008E2E RID: 36398
	public abstract int GetInputCount();

	// Token: 0x06008E2F RID: 36399
	public abstract ECommand UpdateCommand(float deltaTime);

	// Token: 0x06008E30 RID: 36400 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsLowerPriority(GClass1890 combination)
	{
		throw null;
	}

	// Token: 0x0400958E RID: 38286
	public const int SIMULTANEOUS_FIRST_PRIORITY = -2;

	// Token: 0x0400958F RID: 38287
	public const int NO_SPECIAL_PRIORITY = -1;

	// Token: 0x04009590 RID: 38288
	public int Order;

	// Token: 0x04009591 RID: 38289
	public bool IsImportant;

	// Token: 0x04009592 RID: 38290
	[CompilerGenerated]
	private int int_0;

	// Token: 0x04009593 RID: 38291
	public static EKeyPress[,] MergeMatrix;
}
