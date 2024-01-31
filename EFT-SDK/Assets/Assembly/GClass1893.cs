using System;
using System.Runtime.CompilerServices;
using EFT.InputSystem;

// Token: 0x02001A52 RID: 6738
public sealed class GClass1893 : GClass1892
{
	// Token: 0x06008E6C RID: 36460 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override GClass1892 Clone()
	{
		throw null;
	}

	// Token: 0x06008E6D RID: 36461 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x040095B4 RID: 38324
	private readonly ECommand ecommand_1;

	// Token: 0x02001A53 RID: 6739
	private sealed class Class1581 : GClass1892.ContinuousIdlingState
	{
		// Token: 0x06008E6E RID: 36462 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override ECommand GetCommand(float deltaTime)
		{
			throw null;
		}

		// Token: 0x040095B5 RID: 38325
		private GClass1893 gclass1893_0;
	}

	// Token: 0x02001A54 RID: 6740
	private sealed class Class1582 : GClass1892.ContinuousPressedState
	{
		// Token: 0x06008E6F RID: 36463 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override ECommand GetCommandInternal()
		{
			throw null;
		}

		// Token: 0x040095B6 RID: 38326
		private GClass1893 gclass1893_0;
	}
}
