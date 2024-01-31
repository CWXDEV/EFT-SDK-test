using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000A0A RID: 2570
public class SkirmishResultDebug : MonoBehaviour
{
	// Token: 0x060038B3 RID: 14515 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(Vector3 from, Vector3 to, string aggressor, string victim, ESkirmishLogType logType, string part, string isRicochet, string isPenetrate)
	{
		throw null;
	}

	// Token: 0x060038B4 RID: 14516 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmosSelected()
	{
		throw null;
	}

	// Token: 0x04003A5F RID: 14943
	public Vector3 From;

	// Token: 0x04003A60 RID: 14944
	public Vector3 To;

	// Token: 0x04003A61 RID: 14945
	public string Aggressor;

	// Token: 0x04003A62 RID: 14946
	public string Victim;

	// Token: 0x04003A63 RID: 14947
	public float Dist;

	// Token: 0x04003A64 RID: 14948
	public ESkirmishLogType LogType;

	// Token: 0x04003A65 RID: 14949
	public string Part;

	// Token: 0x04003A66 RID: 14950
	public string Ricochet;

	// Token: 0x04003A67 RID: 14951
	public string Penetrate;
}
