using System;
using EFT.InputSystem;

// Token: 0x02001901 RID: 6401
public interface GInterface149
{
	// Token: 0x060089E1 RID: 35297
	InputNode.ETranslateResult TranslateCommand(ECommand command);

	// Token: 0x060089E2 RID: 35298
	void TranslateAxes(ref float[] axes);
}
