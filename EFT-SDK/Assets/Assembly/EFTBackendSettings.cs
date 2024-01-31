using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020005DC RID: 1500
[CreateAssetMenu]
public sealed class EFTBackendSettings : ScriptableObject
{
	// Token: 0x1700065F RID: 1631
	// (get) Token: 0x0600229D RID: 8861 RVA: 0x00002050 File Offset: 0x00000250
	private string String_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000660 RID: 1632
	// (get) Token: 0x0600229E RID: 8862 RVA: 0x00002050 File Offset: 0x00000250
	private string String_1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000661 RID: 1633
	// (get) Token: 0x0600229F RID: 8863 RVA: 0x00002050 File Offset: 0x00000250
	public static EFTBackendSettings Instance
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000662 RID: 1634
	// (get) Token: 0x060022A0 RID: 8864 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060022A1 RID: 8865 RVA: 0x00002050 File Offset: 0x00000250
	public string SelectedBackendUrl
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x060022A2 RID: 8866 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reset()
	{
		throw null;
	}

	// Token: 0x04002202 RID: 8706
	private const string string_0 = "EFTBackendURLs";

	// Token: 0x04002203 RID: 8707
	private const string string_1 = "EscapeFromTarkov/selectedBackendUrl";

	// Token: 0x04002204 RID: 8708
	[SerializeField]
	public EFTBackendSettings.BackendUrl[] AvailableUrls;

	// Token: 0x04002205 RID: 8709
	[CompilerGenerated]
	private static readonly EFTBackendSettings eftbackendSettings_0;

	// Token: 0x04002206 RID: 8710
	[CompilerGenerated]
	private string string_2;

	// Token: 0x020005DD RID: 1501
	public enum EBackendLabel
	{
		// Token: 0x04002208 RID: 8712
		Production,
		// Token: 0x04002209 RID: 8713
		Stage,
		// Token: 0x0400220A RID: 8714
		Development,
		// Token: 0x0400220B RID: 8715
		Custom,
		// Token: 0x0400220C RID: 8716
		Unknown
	}

	// Token: 0x020005DE RID: 1502
	[Serializable]
	public struct BackendUrl : IComparable<EFTBackendSettings.BackendUrl>
	{
		// Token: 0x060022A3 RID: 8867 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060022A4 RID: 8868 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(EFTBackendSettings.BackendUrl other)
		{
			throw null;
		}

		// Token: 0x060022A5 RID: 8869 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x060022A6 RID: 8870 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060022A7 RID: 8871 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CompareTo(EFTBackendSettings.BackendUrl other)
		{
			throw null;
		}

		// Token: 0x0400220D RID: 8717
		public string Url;

		// Token: 0x0400220E RID: 8718
		public EFTBackendSettings.EBackendLabel Label;
	}
}
