using System;
using System.Runtime.CompilerServices;

// Token: 0x02000A21 RID: 2593
public class BaseLight : UpdateInEditorSystemComponent<BaseLight>
{
	// Token: 0x0600390A RID: 14602 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ManualUpdate(float deltaTime)
	{
		throw null;
	}

	// Token: 0x04003B10 RID: 15120
	public float m_Intensity;
}
