using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InputSystem;

// Token: 0x02001A30 RID: 6704
public static class GClass1888
{
	// Token: 0x06008E01 RID: 36353 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static EPressType GetSpecificPressType(this EGameKey gameKey)
	{
		throw null;
	}

	// Token: 0x06008E02 RID: 36354 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsPressTypeSpecific(this EGameKey gameKey)
	{
		throw null;
	}

	// Token: 0x06008E03 RID: 36355 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsPressTypeSelectionAllowed(this EGameKey gameKey)
	{
		throw null;
	}

	// Token: 0x06008E04 RID: 36356 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryGetAssociatedCommand(this ECommand command, out ECommand associatedCommand)
	{
		throw null;
	}

	// Token: 0x06008E05 RID: 36357 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsCommand(this ECommand command, ECommand checkCommand)
	{
		throw null;
	}

	// Token: 0x06008E06 RID: 36358 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsCommand(this ECommand command, params ECommand[] checkCommands)
	{
		throw null;
	}

	// Token: 0x0400956E RID: 38254
	private static readonly HashSet<EGameKey> hashSet_0;

	// Token: 0x0400956F RID: 38255
	private static readonly Dictionary<EGameKey, EPressType> dictionary_0;

	// Token: 0x04009570 RID: 38256
	private static readonly Dictionary<ECommand, ECommand> dictionary_1;
}
