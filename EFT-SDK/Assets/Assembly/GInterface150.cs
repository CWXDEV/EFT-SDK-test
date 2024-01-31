using System;
using EFT.InputSystem;

// Token: 0x02001906 RID: 6406
public interface GInterface150
{
	// Token: 0x06008A0A RID: 35338
	InputNode.ETranslateResult TranslateCommand(ECommand command);

	// Token: 0x06008A0B RID: 35339
	void TranslateAxes(ref float[] axes);
}
