using System;
using System.Runtime.CompilerServices;

// Token: 0x020014D3 RID: 5331
public abstract class GClass1644
{
	// Token: 0x0600720D RID: 29197 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ArraySegment<byte> Encrypt(ArraySegment<byte> source)
	{
		throw null;
	}

	// Token: 0x0600720E RID: 29198 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ArraySegment<byte> Decrypt(ArraySegment<byte> source)
	{
		throw null;
	}

	// Token: 0x0600720F RID: 29199 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ArraySegment<byte> Encrypt(byte[] sourceArray, int sourceIndex, int sourceLength)
	{
		throw null;
	}

	// Token: 0x06007210 RID: 29200 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ArraySegment<byte> Decrypt(byte[] sourceArray, int sourceIndex, int sourceLength)
	{
		throw null;
	}

	// Token: 0x06007211 RID: 29201 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ArraySegment<byte> Encrypt(ArraySegment<byte> source, byte[] destinationArray)
	{
		throw null;
	}

	// Token: 0x06007212 RID: 29202 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ArraySegment<byte> Decrypt(ArraySegment<byte> source, byte[] destinationArray)
	{
		throw null;
	}

	// Token: 0x06007213 RID: 29203 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ArraySegment<byte> Encrypt(byte[] sourceArray, int sourceIndex, int sourceLength, byte[] destinationArray)
	{
		throw null;
	}

	// Token: 0x06007214 RID: 29204 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ArraySegment<byte> Decrypt(byte[] sourceArray, int sourceIndex, int sourceLength, byte[] destinationArray)
	{
		throw null;
	}

	// Token: 0x06007215 RID: 29205
	public abstract void Encrypt(byte[] sourceArray, int sourceIndex, int sourceLength, byte[] destinationArray, int destinationIndex, out int destinationLength);

	// Token: 0x06007216 RID: 29206
	public abstract void Decrypt(byte[] sourceArray, int sourceIndex, int sourceLength, byte[] destinationArray, int destinationIndex, out int destinationLength);

	// Token: 0x06007217 RID: 29207 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_0(byte[] sourceArray, int sourceIndex, int sourceLength, byte[] destinationArray, int destinationIndex, out int destinationLength)
	{
		throw null;
	}

	// Token: 0x06007218 RID: 29208 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_1(byte[] sourceArray, int sourceIndex, int sourceLength, byte[] destinationArray, int destinationIndex, out int destinationLength)
	{
		throw null;
	}

	// Token: 0x040078B4 RID: 30900
	public const int BUFFER_SIZE = 65535;

	// Token: 0x040078B5 RID: 30901
	public const int BUFFER_OVERHAND_SIZE = 16;

	// Token: 0x040078B6 RID: 30902
	public const int BUFFER_PAYLOAD_SIZE = 65519;

	// Token: 0x040078B7 RID: 30903
	private readonly byte[] byte_0;

	// Token: 0x040078B8 RID: 30904
	protected bool bool_0;

	// Token: 0x040078B9 RID: 30905
	protected bool bool_1;

	// Token: 0x040078BA RID: 30906
	private readonly byte[] byte_1;
}
