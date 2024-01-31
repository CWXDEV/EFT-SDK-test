using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200065D RID: 1629
public class GenericEventTranslator : MonoBehaviour
{
	// Token: 0x06002562 RID: 9570 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PlaySoundBank(string bankType)
	{
		throw null;
	}

	// Token: 0x04002485 RID: 9349
	public Action<string> OnSoundBankPlay;
}
