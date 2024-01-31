using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02001523 RID: 5411
[StructLayout(LayoutKind.Auto)]
public struct GStruct170
{
	// Token: 0x06007419 RID: 29721 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Equals(GStruct170 other)
	{
		throw null;
	}

	// Token: 0x0600741A RID: 29722 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Equals(object obj)
	{
		throw null;
	}

	// Token: 0x0600741B RID: 29723 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetHashCode()
	{
		throw null;
	}

	// Token: 0x0600741C RID: 29724 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(GInterface79 writer)
	{
		throw null;
	}

	// Token: 0x0600741D RID: 29725 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Deserialize(GInterface76 reader)
	{
		throw null;
	}

	// Token: 0x04007A59 RID: 31321
	public bool IsVaulting;

	// Token: 0x04007A5A RID: 31322
	public bool DoVault;

	// Token: 0x04007A5B RID: 31323
	public bool DoClimb;

	// Token: 0x04007A5C RID: 31324
	public float VaultingHeight;

	// Token: 0x04007A5D RID: 31325
	public float VaultingLength;

	// Token: 0x04007A5E RID: 31326
	public float BehindObstacleHeight;

	// Token: 0x04007A5F RID: 31327
	public float AbsoluteForwardVelocity;
}
