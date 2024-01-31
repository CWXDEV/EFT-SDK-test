using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x020007F9 RID: 2041
[Serializable]
public abstract class SerializableEnumDictionary<TEnum, T> : Dictionary<TEnum, T>, ISerializationCallbackReceiver where TEnum : struct, Enum
{
	// Token: 0x06002F23 RID: 12067 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public T GetValueOrDefault(TEnum key)
	{
		throw null;
	}

	// Token: 0x06002F24 RID: 12068 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void ISerializationCallbackReceiver.OnAfterDeserialize()
	{
		throw null;
	}

	// Token: 0x06002F25 RID: 12069 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void ISerializationCallbackReceiver.OnBeforeSerialize()
	{
		throw null;
	}

	// Token: 0x04002E45 RID: 11845
	[SerializeField]
	[HideInInspector]
	private List<string> _keys;

	// Token: 0x04002E46 RID: 11846
	[HideInInspector]
	[SerializeField]
	private List<T> _values;
}
