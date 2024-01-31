using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200082F RID: 2095
[ExecuteInEditMode]
[DisallowMultipleComponent]
public class GuidComponent : MonoBehaviour, ISerializationCallbackReceiver
{
	// Token: 0x1700084A RID: 2122
	// (get) Token: 0x06002FEF RID: 12271 RVA: 0x00002050 File Offset: 0x00000250
	public byte[] AsByteGuid
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06002FF0 RID: 12272 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsGuidAssigned()
	{
		throw null;
	}

	// Token: 0x06002FF1 RID: 12273 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06002FF2 RID: 12274 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnBeforeSerialize()
	{
		throw null;
	}

	// Token: 0x06002FF3 RID: 12275 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAfterDeserialize()
	{
		throw null;
	}

	// Token: 0x06002FF4 RID: 12276 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06002FF5 RID: 12277 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnValidate()
	{
		throw null;
	}

	// Token: 0x06002FF6 RID: 12278 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Guid GetGuid()
	{
		throw null;
	}

	// Token: 0x06002FF7 RID: 12279 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDestroy()
	{
		throw null;
	}

	// Token: 0x04002F31 RID: 12081
	private Guid guid_0;

	// Token: 0x04002F32 RID: 12082
	[SerializeField]
	private byte[] serializedGuid;
}
