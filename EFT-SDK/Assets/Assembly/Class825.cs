using System;
using System.Runtime.CompilerServices;
using FlyingWormConsole3.LiteNetLib;

// Token: 0x0200113A RID: 4410
internal sealed class Class825
{
	// Token: 0x17000E70 RID: 3696
	// (get) Token: 0x06005CC4 RID: 23748 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06005CC5 RID: 23749 RVA: 0x00002050 File Offset: 0x00000250
	public PacketProperty Property
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

	// Token: 0x17000E71 RID: 3697
	// (get) Token: 0x06005CC6 RID: 23750 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06005CC7 RID: 23751 RVA: 0x00002050 File Offset: 0x00000250
	public byte ConnectionNumber
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

	// Token: 0x17000E72 RID: 3698
	// (get) Token: 0x06005CC8 RID: 23752 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06005CC9 RID: 23753 RVA: 0x00002050 File Offset: 0x00000250
	public ushort Sequence
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

	// Token: 0x17000E73 RID: 3699
	// (get) Token: 0x06005CCA RID: 23754 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsFragmented
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06005CCB RID: 23755 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MarkFragmented()
	{
		throw null;
	}

	// Token: 0x17000E74 RID: 3700
	// (get) Token: 0x06005CCC RID: 23756 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06005CCD RID: 23757 RVA: 0x00002050 File Offset: 0x00000250
	public byte ChannelId
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

	// Token: 0x17000E75 RID: 3701
	// (get) Token: 0x06005CCE RID: 23758 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06005CCF RID: 23759 RVA: 0x00002050 File Offset: 0x00000250
	public ushort FragmentId
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

	// Token: 0x17000E76 RID: 3702
	// (get) Token: 0x06005CD0 RID: 23760 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06005CD1 RID: 23761 RVA: 0x00002050 File Offset: 0x00000250
	public ushort FragmentPart
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

	// Token: 0x17000E77 RID: 3703
	// (get) Token: 0x06005CD2 RID: 23762 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06005CD3 RID: 23763 RVA: 0x00002050 File Offset: 0x00000250
	public ushort FragmentsTotal
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

	// Token: 0x06005CD4 RID: 23764 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetHeaderSize(PacketProperty property)
	{
		throw null;
	}

	// Token: 0x06005CD5 RID: 23765 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetHeaderSize()
	{
		throw null;
	}

	// Token: 0x06005CD6 RID: 23766 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Verify()
	{
		throw null;
	}

	// Token: 0x0400683F RID: 26687
	private static readonly int int_0;

	// Token: 0x04006840 RID: 26688
	private static readonly int[] int_1;

	// Token: 0x04006841 RID: 26689
	public byte[] RawData;

	// Token: 0x04006842 RID: 26690
	public int Size;

	// Token: 0x04006843 RID: 26691
	public object UserData;

	// Token: 0x04006844 RID: 26692
	public Class825 Next;
}
